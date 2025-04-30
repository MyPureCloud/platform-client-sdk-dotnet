using PureCloudPlatform.Client.V2.Extensions;
using System.Collections.Generic;


namespace PureCloudPlatform.Client.V2.Client
{
/// <summary>
/// Represents an HTTP response
/// </summary>
public class HttpResponse : IHttpResponse
{
    /// <summary>
    /// Gets or sets the HTTP status code of the response
    /// </summary>
    public int StatusCode { get; set; }

    /// <summary>
    /// Gets or sets the HTTP status description
    /// </summary>
    public string StatusDescription { get; set; }

    /// <summary>
    /// Gets or sets the response headers as a dictionary
    /// </summary>
    public Dictionary<string, string> Headers { get; set; } 

    /// <summary>
    /// Gets or sets the response content as a string
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Gets or sets any error message associated with the response
    /// </summary>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or sets the raw response bytes
    /// </summary>
    public byte[] RawBytes { get; set; }
}
}
