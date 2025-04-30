using System;
using System.Collections.Generic;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// Interface defining the structure for HTTP requests.
    /// Provides properties for all components needed to make an HTTP request.
    /// </summary>
    public interface IHttpRequest
    {
        /// <summary>
        /// URL for the HTTP request
        /// </summary>
        string Url { get; }

        /// <summary>
        /// HTTP method
        /// </summary>
        string Method { get; }

        /// <summary>
        /// Collection of query parameters
        /// </summary>
        List<Tuple<string, string>> QueryParams { get; }

        /// <summary>
        /// Dictionary of HTTP header parameters
        /// </summary>
        Dictionary<string, string> HeaderParams { get; }

        /// <summary>
        /// Dictionary of form parameters
        /// </summary>
        Dictionary<string, string> FormParams { get; }

        /// <summary>
        /// Dictionary of file parameters
        /// </summary>
        Dictionary<string, IFileParameter> FileParams { get; }

        /// <summary>
        /// Dictionary of path parameters used in URL templating
        /// </summary>
        Dictionary<string, string> PathParams { get; }

        /// <summary>
        /// Request body object for requests
        /// </summary>
        object PostBody { get; }

        /// <summary>
        /// The content type of the request
        /// </summary>
        string ContentType { get; }
    }
}
