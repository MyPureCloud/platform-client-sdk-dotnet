using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

using RestSharp;

namespace PureCloudPlatform.Client.V2.Client
{
	/// <summary>
	/// Default implementation of HTTP client that uses RestSharp to execute HTTP requests
	/// </summary>
	public class DefaultHttpClient : AbstractHttpClient
	{
		private RestClient restClient;
		private bool usingMTLS = false;
		private Configuration configuration;
		private ClientRestOptions clientOptions;

		///<Summary>
		/// Create an instane of the DefaultHttpClient with configuration
		///</Summary>
		public DefaultHttpClient(ClientRestOptions apiClientOptions, Configuration config = null) : base()
		{
			configuration = config != null ? config : Configuration.Default;
			clientOptions = apiClientOptions;

			configuration.Timeout = (configuration.Timeout > 0) ? configuration.Timeout : 100000;

			SetTimeout(configuration.Timeout);
			SetUserAgent(configuration.UserAgent);

			if (clientOptions.LocalClientCertificates != null && clientOptions.LocalClientCertificates.Count > 0)
			{
				// use HttpWebRequest
				usingMTLS = true;
				ConfigureServicePoint();
			}
			else
			{
				// use RestClient
				BuildRestOptions();
			}
		}

		private void BuildRestOptions()
		{
			RestClientOptions options = new RestClientOptions(Configuration.Default.ApiClient.GetConfUri(
				clientOptions.Prefix,
				clientOptions.BaseUrl
			))
			{
				UserAgent = this.UserAgent,
				Timeout = TimeSpan.FromMilliseconds(this.Timeout)
			};

			if (clientOptions.Proxy != null)
			{
				options.Proxy = clientOptions.Proxy;
			}

			if (clientOptions.HttpMessageHandler != null)
			{
				options.ConfigureMessageHandler = _ =>
				{
					return clientOptions.HttpMessageHandler;
				};
			}

			restClient = new RestClient(options);
		}

		private void ConfigureServicePoint()
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			ServicePointManager.ServerCertificateValidationCallback = ValidateServerCertificate;
		}

		private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			X509Certificate2 cert2 = certificate as X509Certificate2 ?? new X509Certificate2(certificate);

			Console.WriteLine("In Certificate Validation Callback");
			var expectedCertThumbprint = "5898175B9B25A0BEBEE6D59DE67BDD8D87D06D70"; //test cert
			if (cert2.Thumbprint.Equals(expectedCertThumbprint))
			{
				Console.WriteLine("Accepting Test Cert based on thumbprint");
				return true;
			}

			if (sslPolicyErrors != SslPolicyErrors.None)
			{
				Console.WriteLine($"SSL Policy Errors: {sslPolicyErrors}");
				foreach (var element in chain.ChainElements)
				{
					Console.WriteLine($"Certificate: {element.Certificate.Subject}");
					foreach (var status in element.ChainElementStatus)
					{
						Console.WriteLine($"Status: {status.StatusInformation}");
					}
				}
			}
			return sslPolicyErrors == SslPolicyErrors.None;
		}

		/// <summary>
		/// Asynchronously executes an HTTP request
		/// </summary>
		public override async Task<IHttpResponse> ExecuteAsync(IHttpRequest httpRequest, CancellationToken cancellationToken = default(CancellationToken))
		{
			httpRequest = ApplyPreRequestHook(httpRequest);
			IHttpResponse resp;

			if (usingMTLS)  //using HttpWebRequest
			{
				var request = PrepareWebRequest((HttpRequestOptions)httpRequest);

				if (httpRequest.Method != "GET" && httpRequest.PostBody != null)
				{
					using (var requestStream = await request.GetRequestStreamAsync())
					{
						if (httpRequest.PostBody is string stringContent)
						{
							using (var writer = new StreamWriter(requestStream))
							{
								await writer.WriteAsync(stringContent);
							}
						}
						else if (httpRequest.PostBody is byte[] byteContent)
						{
							await requestStream.WriteAsync(byteContent, 0, byteContent.Length);
						}
					}
				}

				try
				{
					using (var response = (HttpWebResponse)await request.GetResponseAsync())
					{
						resp = await ConvertToHttpResponse(response);
					}
				}
				catch (WebException ex)
				{
					if (ex.Response is HttpWebResponse errorResponse)
					{
						return await ConvertToHttpResponse(errorResponse);
					}
					throw;
				}
			}
			else //using RestSharp (HttpClient)
			{
				var request = PrepareRestRequest((HttpRequestOptions)httpRequest);

				var restResp = await restClient.ExecuteAsync(request, cancellationToken);

				resp = ConvertToHttpResponse(restResp);
			}

			return ApplyPostRequestHook(resp);
		}

		/// <summary>
		/// Executes an HTTP request.
		/// </summary>
		public override IHttpResponse Execute(IHttpRequest httpRequest)
		{
			IHttpResponse resp;

			if (usingMTLS) //using HttpWebRequest
			{
				resp = ExecuteAsync(httpRequest).GetAwaiter().GetResult();
			}
			else //using RestSharp (HttpClient)
			{
				httpRequest = ApplyPreRequestHook(httpRequest);
				var request = PrepareRestRequest((HttpRequestOptions)httpRequest);

				var restResp = restClient.Execute(request);

				resp = ConvertToHttpResponse(restResp);
				resp = ApplyPostRequestHook(resp);
			}

			return resp;
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
						g => string.Join(", ", g.Select(h => h.Value?.ToString()))
					) ?? new Dictionary<string, string>()
			};
		}

		private async Task<IHttpResponse> ConvertToHttpResponse(HttpWebResponse response)
		{
			using (var streamReader = new StreamReader(response.GetResponseStream()))
			{
				var content = await streamReader.ReadToEndAsync();
				var rawBytes = System.Text.Encoding.UTF8.GetBytes(content);

				return new HttpResponse
				{
					StatusCode = (int)response.StatusCode,
					StatusDescription = response.StatusDescription,
					Content = content,
					RawBytes = rawBytes,
					Headers = response.Headers.AllKeys
						.GroupBy(key => key)
						.ToDictionary(
							g => g.Key,
							g => string.Join(", ", g.Select(key => response.Headers[key]))
						)
				};
			}
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

		private HttpWebRequest PrepareWebRequest(HttpRequestOptions options)
		{
			var path = options.Url;
			foreach (var pathParam in options.PathParams)
			{
				path = path.Replace("{" + pathParam.Key + "}", WebUtility.UrlEncode(pathParam.Value));
			}

			var fullUri = new Uri(Configuration.Default.ApiClient.GetConfUri(
				clientOptions.Prefix,
				clientOptions.BaseUrl
			), path.TrimStart('/'));

			if (options.QueryParams.Any())
			{
				var uriBuilder = new UriBuilder(fullUri);
				var query = string.Join("&", options.QueryParams.Select(p => $"{p.Item1}={WebUtility.UrlEncode(p.Item2)}"));

				if (!string.IsNullOrEmpty(uriBuilder.Query) && uriBuilder.Query.Length > 1)
				{
					uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + query;
				}
				else
				{
					uriBuilder.Query = query;
				}

				fullUri = uriBuilder.Uri;
			}

			var request = (HttpWebRequest)WebRequest.Create(fullUri);
			request.Method = options.Method;
			request.Timeout = this.Timeout;
			request.UserAgent = this.UserAgent;

			if (clientOptions.LocalClientCertificates != null && clientOptions.LocalClientCertificates.Count > 0)
			{
				request.ClientCertificates = clientOptions.LocalClientCertificates;
			}

			if (clientOptions.Proxy != null)
			{
				request.Proxy = clientOptions.Proxy;
			}

			foreach (var header in options.HeaderParams)
			{
				switch (header.Key.ToLower())
				{
					case "accept":
						request.Accept = header.Value;
						break;
					case "user-agent":
						request.UserAgent = header.Value;
						break;
					case "connection":
						request.KeepAlive = header.Value.ToLower() == "keep-alive";
						break;
					case "date":
						request.Date = DateTime.Parse(header.Value);
						break;
					case "expect":
						request.Expect = header.Value;
						break;
					case "if-modified-since":
						request.IfModifiedSince = DateTime.Parse(header.Value);
						break;
					case "range":
						var rangeValue = header.Value.Replace("bytes=", "").Split('-');
						if (rangeValue.Length == 2)
						{
							long from = long.Parse(rangeValue[0]);
							long to = long.Parse(rangeValue[1]);
							request.AddRange(from, to);
						}
						break;
					case "referer":
						request.Referer = header.Value;
						break;
					case "transfer-encoding":
						request.TransferEncoding = header.Value;
						break;
					default:
						request.Headers[header.Key] = header.Value;
						break;
				}
			}

			bool hasBody = options.PostBody != null ||
						(options.FormParams != null && options.FormParams.Count > 0) ||
						(options.FileParams != null && options.FileParams.Count > 0);

			if (hasBody && options.Method != "GET")
			{
				if (options.FileParams != null && options.FileParams.Count > 0)
				{
					string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
					request.ContentType = "multipart/form-data; boundary=" + boundary;

					using (var requestStream = request.GetRequestStream())
					using (var writer = new StreamWriter(requestStream))
					{
						// Add form parameters
						if (options.FormParams != null)
						{
							foreach (var param in options.FormParams)
							{
								writer.WriteLine("--" + boundary);
								writer.WriteLine($"Content-Disposition: form-data; name=\"{param.Key}\"");
								writer.WriteLine();
								writer.WriteLine(param.Value);
								writer.Flush();
							}
						}

						// Add file parameters
						foreach (var param in options.FileParams)
						{
							writer.WriteLine("--" + boundary);
							writer.WriteLine($"Content-Disposition: form-data; name=\"{param.Key}\"; filename=\"{param.Value.FileName}\"");
							writer.WriteLine($"Content-Type: {param.Value.ContentType}");
							writer.WriteLine();
							writer.Flush();

							using (Stream fileStream = param.Value.GetFile())
							{
								fileStream.CopyTo(requestStream);
							}

							writer.WriteLine();
							writer.Flush();
						}

						writer.WriteLine("--" + boundary + "--");
						writer.Flush();
					}
				}
				// Handle form parameters (no files)
				else if (options.FormParams != null && options.FormParams.Count > 0)
				{
					request.ContentType = "application/x-www-form-urlencoded";
					var formData = string.Join("&", options.FormParams.Select(p => $"{WebUtility.UrlEncode(p.Key)}={WebUtility.UrlEncode(p.Value)}"));

					using (var requestStream = request.GetRequestStream())
					using (var writer = new StreamWriter(requestStream))
					{
						writer.Write(formData);
					}
				}
				// Handle JSON or binary body
				else if (options.PostBody != null)
				{
					if (options.PostBody is string stringContent)
					{
						request.ContentType = options.ContentType ?? "application/json";
						using (var requestStream = request.GetRequestStream())
						using (var writer = new StreamWriter(requestStream))
						{
							writer.Write(stringContent);
						}
					}
					else if (options.PostBody is byte[] byteContent)
					{
						request.ContentType = options.ContentType ?? "application/octet-stream";
						using (var requestStream = request.GetRequestStream())
						{
							requestStream.Write(byteContent, 0, byteContent.Length);
						}
					}
				}
			}

			return request;
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