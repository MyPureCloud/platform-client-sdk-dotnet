using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Extensions;
using System.Security.Cryptography;

namespace PureCloudPlatform.Client.V2.Extensions
{
    /// <summary>
    /// Extensions for Authorization processing
    /// </summary>
    public static class AuthExtensions
    {
        /// <summary>
        /// Performs the Client Credentials or Code Authorization and returns Token Information
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUri"></param>
        /// <param name="authorizationCode"></param>
        /// <param name="isRefreshRequest"></param>
        /// <returns>AuthTokenInfo</returns>
        public static AuthTokenInfo PostToken(this ApiClient apiClient, string clientId, string clientSecret,string redirectUri = "", string authorizationCode = "", bool isRefreshRequest = false)
        {
            var response = apiClient.PostTokenWithHttpInfo(clientId, clientSecret, redirectUri, authorizationCode, isRefreshRequest);
            return response.Data;
        }

        ///<Summary>
        /// Performs the Client Credentials or Code Authorization and returns ApiResponse with Token Information
        ///</Summary>
        /// <param name="apiClient"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUri"></param>
        /// <param name="authorizationCode"></param>
        /// <param name="isRefreshRequest"></param>
        /// <returns>ApiResponse with AuthTokenInfo</returns>
        public static ApiResponse<AuthTokenInfo> PostTokenWithHttpInfo(this ApiClient apiClient, string clientId,
            string clientSecret, string redirectUri = "", string authorizationCode = "", bool isRefreshRequest = false)
        {
            var path_ = "/oauth/token";
            var method = "POST";

            // This may be uninitialized if no API classes have been constructed yet
            if (apiClient.Configuration == null)
                apiClient.Configuration = new Configuration(apiClient);

            // If redirectUri is not null this is a Code Authorization grant and we need to save the clientId and clientSecret for a transparent token refresh
            if (!string.IsNullOrEmpty(redirectUri)) {
                apiClient.UsingCodeAuth = true;
                apiClient.ClientId = clientId;
                apiClient.ClientSecret = clientSecret;
            }

            var pathParams = new Dictionary<String, String>();
            var queryParams = new List<Tuple<String, String>>();
            var headerParams = new Dictionary<String, String>(apiClient.Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, IFileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[]
            {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = apiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[]
            {
                "application/json"
            };
            String httpHeaderAccept = apiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // Add form params
            if (isRefreshRequest) {
                formParams.Add("grant_type", "refresh_token");
                formParams.Add("refresh_token", authorizationCode);
            } else {
                formParams.Add("grant_type",
                    string.IsNullOrEmpty(authorizationCode) ? "client_credentials" : "authorization_code");
                if (!string.IsNullOrEmpty(authorizationCode))
                    formParams.Add("code", apiClient.ParameterToString(authorizationCode));
            }
            if (!string.IsNullOrEmpty(redirectUri))
                formParams.Add("redirect_uri", apiClient.ParameterToString(redirectUri));

            // authentication required
            var basicAuth =
                Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(clientId + ":" + clientSecret));
            headerParams["Authorization"] = "Basic " + basicAuth;

            // make the HTTP request
            HttpResponse response = (HttpResponse)CallTokenApi(apiClient, path_,
                method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.ErrorMessage,
                    response.ErrorMessage);

            var authTokenInfo = (AuthTokenInfo) apiClient.Deserialize(response, typeof (AuthTokenInfo));
            apiClient.Configuration.AuthTokenInfo = authTokenInfo;

            return new ApiResponse<AuthTokenInfo>(statusCode,
                response.Headers,
                authTokenInfo,
                response.Content,
                response.StatusDescription);
        }

        /// <summary>
        /// Performs the Saml2 Bearer Authorization and returns Token Information
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="orgName"></param>
        /// <param name="assertion"></param>
        /// <returns>AuthTokenInfo</returns>
        public static AuthTokenInfo PostTokenSaml2Bearer(this ApiClient apiClient, string clientId, string clientSecret,string orgName, string assertion)
        {
            var response = apiClient.PostTokenWithHttpInfoSaml2Bearer(clientId, clientSecret, orgName, assertion);
            return response.Data;
        }

        /// <summary>
        /// Performs the Saml2 Bearer Authorization and returns ApiResponse with Token Information
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="orgName"></param>
        /// <param name="assertion"></param>
        /// <returns>ApiResponse with AuthTokenInfo</returns>
        public static ApiResponse<AuthTokenInfo> PostTokenWithHttpInfoSaml2Bearer(this ApiClient apiClient, string clientId,
            string clientSecret, string orgName, string assertion)
        {
            var path_ = "/oauth/token";
            var method = "POST";

            // This may be uninitialized if no API classes have been constructed yet
            if (apiClient.Configuration == null)
                apiClient.Configuration = new Configuration(apiClient);

            var pathParams = new Dictionary<String, String>();
            var queryParams = new List<Tuple<String, String>>();
            var headerParams = new Dictionary<String, String>(apiClient.Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, IFileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[]
            {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = apiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[]
            {
                "application/json"
            };
            String httpHeaderAccept = apiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // Add form params
            formParams.Add("grant_type","urn:ietf:params:oauth:grant-type:saml2-bearer");
            formParams.Add("orgName", orgName);
            formParams.Add("assertion", assertion);

            // authentication required
            var basicAuth =
                Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(clientId + ":" + clientSecret));
            headerParams["Authorization"] = "Basic " + basicAuth;

            // make the HTTP request
            HttpResponse response = (HttpResponse)CallTokenApi(apiClient, path_,
                method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.ErrorMessage,
                    response.ErrorMessage);

            var authTokenInfo = (AuthTokenInfo) apiClient.Deserialize(response, typeof (AuthTokenInfo));
            apiClient.Configuration.AuthTokenInfo = authTokenInfo;

            return new ApiResponse<AuthTokenInfo>(statusCode,
                response.Headers,
                authTokenInfo,
                response.Content,
                response.StatusDescription);
        }

        /// <summary>
        /// Generate a random string used as PKCE Code Verifier - length = 43 to 128.
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="length"></param>
        /// <returns>String</returns>
        public static string GeneratePKCECodeVerifier(this ApiClient apiClient, int length)
        {
            if (length < 43 || length > 128)
                throw new ArgumentException("Error calling GeneratePKCECodeVerifier: PKCE Code Verifier (length) must be between 43 and 128 characters");

            // String that contain both alphabets and numbers
            String unreservedCharacters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-._~";
            // Initializing the empty string
            Random res = new Random();
            String randomString = "";
            for (int i = 0; i < length; i++) {
                // Selecting an index randomly
                int x = res.Next(unreservedCharacters.Length);
                // Appending the character at the index to the random alphanumeric string.
                randomString = randomString + unreservedCharacters[x];
            }
            return randomString;
        }

        /// <summary>
        /// Compute Base64Url PKCE Code Challenge from Code Verifier.
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="code"></param>
        /// <returns>String</returns>
        public static string ComputePKCECodeChallenge(this ApiClient apiClient, string code)
        {
            if (code.Length < 43 || code.Length > 128)
                throw new ArgumentException("Error calling ComputePKCECodeChallenge: PKCE Code Verifier (length) must be between 43 and 128 characters");

            var hashBase64Url = "";
            using (var sha256hash = SHA256.Create()) {
                byte[] payloadBytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(code));
                hashBase64Url = Convert.ToBase64String(payloadBytes);
                hashBase64Url = hashBase64Url.Replace('+', '-').Replace('/', '_');
                hashBase64Url = hashBase64Url.Split('=')[0];
            }
            return hashBase64Url;
        }

        /// <summary>
        /// Completes the PKCE Code Authorization and returns Token Information
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="authorizationCode"></param>
        /// <returns>AuthTokenInfo</returns>
        public static AuthTokenInfo PostTokenPKCE(this ApiClient apiClient, string clientId, string redirectUri, string codeVerifier, string authorizationCode)
        {
            var response = apiClient.PostTokenWithHttpInfoPKCE(clientId, redirectUri, codeVerifier, authorizationCode);
            return response.Data;
        }

        /// <summary>
        /// Completes the PKCE Code Authorization and returns ApiResponse with Token Information
        /// </summary>
        /// <param name="apiClient"></param>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="authorizationCode"></param>
        /// <returns>ApiResponse with AuthTokenInfo</returns>
        public static ApiResponse<AuthTokenInfo> PostTokenWithHttpInfoPKCE(this ApiClient apiClient, string clientId, string redirectUri, string codeVerifier, string authorizationCode)
        {
            var path_ = "/oauth/token";
            var method = "POST";

            // This may be uninitialized if no API classes have been constructed yet
            if (apiClient.Configuration == null)
                apiClient.Configuration = new Configuration(apiClient);

            var pathParams = new Dictionary<String, String>();
            var queryParams = new List<Tuple<String, String>>();
            var headerParams = new Dictionary<String, String>(apiClient.Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, IFileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[]
            {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = apiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[]
            {
                "application/json"
            };
            String httpHeaderAccept = apiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // Add form params
            formParams.Add("grant_type","authorization_code");
            formParams.Add("code", apiClient.ParameterToString(authorizationCode));
            formParams.Add("code_verifier", apiClient.ParameterToString(codeVerifier));
            formParams.Add("client_id", apiClient.ParameterToString(clientId));
            formParams.Add("redirect_uri", apiClient.ParameterToString(redirectUri));

            // make the HTTP request
            HttpResponse response = (HttpResponse)CallTokenApi(apiClient, path_,
                method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException(statusCode, "Error calling PostToken: " + response.ErrorMessage,
                    response.ErrorMessage);

            var authTokenInfo = (AuthTokenInfo) apiClient.Deserialize(response, typeof (AuthTokenInfo));
            apiClient.Configuration.AuthTokenInfo = authTokenInfo;

            return new ApiResponse<AuthTokenInfo>(statusCode,
                response.Headers,
                authTokenInfo,
                response.Content,
                response.StatusDescription);
        }

        private static Object CallTokenApi(ApiClient apiClient,
            String path, String method, List<Tuple<String, String>> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, IFileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            apiClient.ClientOptions.Prefix = "login";

            var httpClient = new DefaultHttpClient(apiClient.Configuration, apiClient.ClientOptions);

            var requestOptions = new HttpRequestOptions(
                path, 
                method, 
                queryParams, 
                headerParams, 
                formParams, 
                fileParams,
                pathParams, 
                postBody, 
                contentType
            );

            var response = httpClient.Execute(requestOptions);
            
            int statusCode = (int)response.StatusCode;
            apiClient.Configuration.Logger.Trace(method, path, postBody, statusCode, headerParams, response.Headers ?? new Dictionary<string, string>());
            apiClient.Configuration.Logger.Debug(method, path, postBody, statusCode, headerParams);
            
            if (statusCode >= 400 || statusCode == 0)
                apiClient.Configuration.Logger.Error(method, path, postBody, response.Content, statusCode, headerParams, response.Headers ?? new Dictionary<string, string>());

            return (Object) response;
        }
    }
}