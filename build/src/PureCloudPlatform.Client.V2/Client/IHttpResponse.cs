using System.Collections.Generic;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// Interface representing an HTTP response.
    /// Provides properties for all components needed for the response.
    /// </summary>
    public interface IHttpResponse
    {
        /// <summary>
        /// HTTP status code of the response
        /// </summary>
        int StatusCode { get; }

        /// <summary>
        /// HTTP status description message
        /// </summary>
        string StatusDescription { get; }

        /// <summary>
        /// Dictionary of response headers
        /// </summary>
        Dictionary<string, string> Headers { get; }

        /// <summary>
        /// Response content as a string
        /// </summary>
        string Content { get; }

        /// <summary>
        /// Error message associated with the response
        /// </summary>
        string ErrorMessage { get; }

        /// <summary>
        /// Raw response bytes
        /// </summary>
        byte[] RawBytes { get; }
    }
}
