using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using RestSharp;
using PureCloudPlatform.Client.V2.Extensions;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// Default implementation of HTTP client that uses RestSharp to execute HTTP requests
    /// </summary>
    public class DefaultHttpClient : AbstractHttpClient
    {
        private RestClient restClient;

        ///<Summary>
        /// Create an instane of the DefaultHttpClient with config and client options
        ///</Summary>
        ////// <summary>
        public DefaultHttpClient(Configuration config, ClientRestOptions clientOptions) : base()
        {
            config.Timeout = (config.Timeout > 0) ? config.Timeout : 100000;

            SetTimeout(config.Timeout);
            SetUserAgent(config.UserAgent);

            RestClientOptions options = BuildRestOptions(config, clientOptions);

            restClient = new RestClient(options);
        }

        private RestClientOptions BuildRestOptions(Configuration config, ClientRestOptions clientOptions)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));
            if (clientOptions == null) throw new ArgumentNullException(nameof(clientOptions));

            var options = new RestClientOptions(config.ApiClient.GetConfUri(clientOptions.Prefix, clientOptions.BaseUrl))
            {
                UserAgent = this.UserAgent,
                Timeout = TimeSpan.FromMilliseconds(this.Timeout)
            };

            options.ConfigureMessageHandler = handler =>
            {
                if (clientOptions.HttpMessageHandler != null)
                {
                    return clientOptions.HttpMessageHandler;
                }

                return handler;
            };

            if (clientOptions.Proxy != null)
            {
                options.Proxy = clientOptions.Proxy;
            }

            return options;
        }

        /// <summary>
        /// Asynchronously executes an HTTP request
        /// </summary>
        public override async Task<IHttpResponse> ExecuteAsync(IHttpRequest httpRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = PrepareRestRequest((HttpRequestOptions)httpRequest);

            var restResp =  await restClient.ExecuteAsync(request, cancellationToken);

            return ConvertToHttpResponse(restResp);
        }

        /// <summary>
        /// Executes an HTTP request.
        /// </summary>
        public override IHttpResponse Execute(IHttpRequest httpRequest)
        {
            var request = PrepareRestRequest((HttpRequestOptions)httpRequest);

            var restResp = restClient.Execute(request);

            return ConvertToHttpResponse(restResp);
        }

        private IHttpResponse ConvertToHttpResponse(RestResponse response)
        {
            return new HttpResponse
            {
                StatusCode = (int)response.StatusCode,
                StatusDescription = response.StatusDescription,
                Content = response.Content,
                ErrorMessage = response.ErrorMessage,
                RawBytes = response.RawBytes,
                Headers = response.Headers?
                    .GroupBy(h => h.Name)
                    .ToDictionary(
                        g => g.Key,
                        g => string.Join(";", g.Select(h => h.Value?.ToString()))
                    ) ?? new Dictionary<string, string>()
            };
        }

        private RestRequest PrepareRestRequest(HttpRequestOptions options)
        {
            Method restSharpMethod = ConvertToRestSharpMethod(options.Method);

            var request = new RestRequest(options.Url, restSharpMethod);

            // add path parameter, if any
            foreach (var param in options.PathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            // add header parameter, if any
            foreach (var param in options.HeaderParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach (var param in options.QueryParams)
                request.AddQueryParameter(param.Item1, param.Item2);

            // add form parameter, if any
            foreach (var param in options.FormParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach (var param in options.FileParams)
            {
                var file = param.Value;
                request.AddFile(
                    file.Name,
                    file.GetFile,
                    file.FileName,
                    file.ContentType
                );
            }

            if (options.PostBody != null) // http body (model or byte[]) parameter
            {
                if (options.PostBody.GetType() == typeof(String))
                {
                    request.AddParameter("application/json", options.PostBody, ParameterType.RequestBody);
                }
                else if (options.PostBody.GetType() == typeof(byte[]))
                {
                    request.AddParameter(options.ContentType, options.PostBody, ParameterType.RequestBody);
                }
            }

            request.Timeout = TimeSpan.FromMilliseconds(this.Timeout);

            return request;
        }

        private Method ConvertToRestSharpMethod(string method)
        {
            switch (method.ToUpper())
            {
                case "GET":
                    return Method.Get;
                case "POST":
                    return Method.Post;
                case "PUT":
                    return Method.Put;
                case "DELETE":
                    return Method.Delete;
                case "HEAD":
                    return Method.Head;
                case "OPTIONS":
                    return Method.Options;
                case "PATCH":
                    return Method.Patch;
                case "MERGE":
                    return Method.Merge;
                case "COPY":
                    return Method.Copy;
                default:
                    throw new ArgumentException($"Unsupported HTTP method: {method}");
            }
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream)
        {
            if (stream is FileStream)
                return FileParameter.Create(name, ApiClient.ReadAsBytes(stream), Path.GetFileName(((FileStream)stream).Name));
            else
                return FileParameter.Create(name, ApiClient.ReadAsBytes(stream), "no_file_name_provided");
        }
    }
}