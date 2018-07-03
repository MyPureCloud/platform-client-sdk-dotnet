using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
using RestSharp;

namespace PureCloudPlatform.Client.V2.Extensions
{
    public static class AuthExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUri"></param>
        /// <param name="authorizationCode"></param>
        /// <returns></returns>
        public static AuthTokenInfo PostToken(this ApiClient apiClient, string clientId, string clientSecret,string redirectUri = "", string authorizationCode = "")
        {
            var response = apiClient.PostTokenWithHttpInfo(clientId, clientSecret, redirectUri, authorizationCode);
            return response.Data;
        }

        public static ApiResponse<AuthTokenInfo> PostTokenWithHttpInfo(this ApiClient apiClient, string clientId,
            string clientSecret, string redirectUri = "", string authorizationCode = "")
        {
            var path_ = "/token";

            // This may be uninitialized if no API classes have been constructed yet
            if (apiClient.Configuration == null)
                apiClient.Configuration = new Configuration(apiClient);

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(apiClient.Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[]
            {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = apiClient.Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[]
            {
                "application/json"
            };
            String httpHeaderAccept = apiClient.Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // Add form params
            formParams.Add("grant_type",
                string.IsNullOrEmpty(authorizationCode) ? "client_credentials" : "authorization_code");
            if (!string.IsNullOrEmpty(authorizationCode))
                formParams.Add("code", apiClient.Configuration.ApiClient.ParameterToString(authorizationCode));
            if (!string.IsNullOrEmpty(redirectUri))
                formParams.Add("redirect_uri", apiClient.Configuration.ApiClient.ParameterToString(redirectUri));

            // authentication required
            var basicAuth =
                Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(clientId + ":" + clientSecret));
            headerParams["Authorization"] = "Basic " + basicAuth;

            // make the HTTP request
            IRestResponse response = (IRestResponse)CallTokenApi(apiClient, path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.ErrorMessage,
                    response.ErrorMessage);

            return new ApiResponse<AuthTokenInfo>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AuthTokenInfo) apiClient.Configuration.ApiClient.Deserialize(response, typeof (AuthTokenInfo)));
        }

        private static Object CallTokenApi(ApiClient apiClient,
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            var regex = new Regex(@"://(api)\.");
            var authUrl = regex.Replace(apiClient.Configuration.ApiClient.RestClient.BaseUrl.ToString(), "://login.");
            var restClient = new RestClient(authUrl);

            var request = PrepareTokenRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);

            var response = restClient.Execute(request);
            return (Object) response;
        }

        private static RestRequest PrepareTokenRequest(
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            var request = new RestRequest(path, method);

            // add path parameter, if any
            foreach (var param in pathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            // add header parameter, if any
            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach (var param in queryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // add form parameter, if any
            foreach (var param in formParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach (var param in fileParams)
                request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentLength, param.Value.ContentType);

            if (postBody != null) // http body (model or byte[]) parameter
            {
                if (postBody.GetType() == typeof (String))
                {
                    request.AddParameter("application/json", postBody, ParameterType.RequestBody);
                }
                else if (postBody.GetType() == typeof (byte[]))
                {
                    request.AddParameter(contentType, postBody, ParameterType.RequestBody);
                }
            }

            return request;
        }
    }
}
