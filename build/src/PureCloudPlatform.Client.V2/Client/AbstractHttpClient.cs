using System;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Security.Authentication;
using System.Net.Security;
using System.Threading;
using System.Threading.Tasks;
using PureCloudPlatform.Client.V2.Extensions;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// Delegate for pre-request hooks
    /// </summary>
    /// <param name="request">The HTTP request to be modified</param>
    /// <returns>Modified HTTP request</returns>
    public delegate IHttpRequest PreRequestHook(IHttpRequest request);

    /// <summary>
    /// Delegate for post-request hooks
    /// </summary>
    /// <param name="response">The HTTP response to be modified</param>
    /// <returns>Modified HTTP response</returns>
    public delegate IHttpResponse PostRequestHook(IHttpResponse response);

    /// <summary>
    /// Abstract base class for HTTP client implementations that provides common functionality for making HTTP requests
    /// </summary>
    public abstract class AbstractHttpClient
    {
        /// <summary>
        /// Gets or sets the timeout value in milliseconds for HTTP requests
        /// </summary>
        /// <value>The timeout in milliseconds. Default value is 100000.</value>
        protected int Timeout { get; set; } = 100000;

        /// <summary>
        /// Gets or sets the User-Agent header value for HTTP requests
        /// </summary>
        /// <value>The User-Agent string</value>
        protected string UserAgent { get; set; } = "null";

        /// <summary>
        /// Pre-request hook that will be called before each request
        /// </summary>
        protected PreRequestHook PreHook { get; set; }

        /// <summary>
        /// Post-request hook that will be called after each request
        /// </summary>
        protected PostRequestHook PostHook { get; set; }

        ///<Summary>
        /// Sets the request timeout
        ///</Summary>
        public void SetTimeout(int timeout)
        {
            if (timeout <= 0)
            {
                throw new ArgumentException("Timeout must be greater than 0");
            }
            Timeout = timeout;
        }

        ///<Summary>
        /// Sets the request useragent
        ///</Summary>
        public void SetUserAgent(string userAgent)
        {
            if (string.IsNullOrEmpty(userAgent))
            {
                throw new ArgumentException("UserAgent must not be null or empty");
            }
            UserAgent = userAgent;
        }

        /// <summary>
        /// Sets the pre-request hook
        /// </summary>
        /// <param name="hook">The hook function to call before each request</param>
        public void SetPreRequestHook(PreRequestHook hook)
        {
            PreHook = hook;
        }

        /// <summary>
        /// Sets the post-request hook
        /// </summary>
        /// <param name="hook">The hook function to call after each request</param>
        public void SetPostRequestHook(PostRequestHook hook)
        {
            PostHook = hook;
        }

        /// <summary>
        /// Applies the pre-request hook if set
        /// </summary>
        /// <param name="request">The original request</param>
        /// <returns>The modified request</returns>
        protected IHttpRequest ApplyPreRequestHook(IHttpRequest request)
        {
            if (PreHook != null)
            {
                try
                {
                    return PreHook(request);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in pre-request hook: {ex.Message}");
                    throw ex;
                }
            }
            return request;
        }

        /// <summary>
        /// Applies the post-request hook if set
        /// </summary>
        /// <param name="response">The original response</param>
        /// <returns>The modified response</returns>
        protected IHttpResponse ApplyPostRequestHook(IHttpResponse response)
        {
            if (PostHook != null)
            {
                try
                {
                    return PostHook(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in post-request hook: {ex.Message}");
                    throw ex;
                }
            }
            return response;
        }

        /// <summary>
        /// Asynchronously executes an HTTP request
        /// </summary>
        public abstract Task<IHttpResponse> ExecuteAsync(IHttpRequest httpRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Executes an HTTP request.
        /// </summary>
        public abstract IHttpResponse Execute(IHttpRequest httpRequest);
    }
}