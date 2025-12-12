namespace PureCloudPlatform.Client.V2.Client
{
	/// <summary>
	/// Represents HTTP request options and parameters
	/// </summary>
	public class HttpRequestOptions : IHttpRequest
	{
		/// <summary>Gets the request URL</summary>
		public string Url { get; private set; }

		/// <summary>Gets the HTTP method</summary>
		public string Method { get; private set; }

		/// <summary>Gets the query parameters</summary>
		public List<Tuple<string, string>> QueryParams { get; private set; }

		/// <summary>Gets the header parameters</summary>
		public Dictionary<string, string> HeaderParams { get; private set; }

		/// <summary>Gets the form parameters</summary>
		public Dictionary<string, string> FormParams { get; private set; }

		/// <summary>Gets the file parameters</summary>
		public Dictionary<string, IFileParameter> FileParams { get; private set; }

		/// <summary>Gets the path parameters</summary>
		public Dictionary<string, string> PathParams { get; private set; }

		/// <summary>Gets the request body</summary>
		public object PostBody { get; private set; }

		/// <summary>Gets the content type</summary>
		public string ContentType { get; private set; }

		private static readonly string[] ValidMethods = { "GET", "POST", "PUT", "DELETE", "PATCH", "OPTIONS", "HEAD", "MERGE", "COPY" };

		/// <summary>
		/// Initializes a new instance of the HttpRequestOptions class
		/// </summary>
		/// <param name="url">The request URL</param>
		/// <param name="method">The HTTP method</param>
		/// <param name="queryParams">Optional query parameters</param>
		/// <param name="headerParams">Optional header parameters</param>
		/// <param name="formParams">Optional form parameters</param>
		/// <param name="fileParams">Optional file parameters</param>
		/// <param name="pathParams">Optional path parameters</param>
		/// <param name="postBody">Optional request body</param>
		/// <param name="contentType">Optional content type</param>
		public HttpRequestOptions(
			string url,
			string method,
			List<Tuple<string, string>> queryParams = null,
			Dictionary<string, string> headerParams = null,
			Dictionary<string, string> formParams = null,
			Dictionary<string, IFileParameter> fileParams = null,
			Dictionary<string, string> pathParams = null,
			object postBody = null,
			string contentType = null)
		{
			SetUrl(url);
			SetMethod(method);

			if (queryParams != null)
			{
				SetQueryParams(queryParams);
			}

			if (headerParams != null)
			{
				SetHeaderParams(headerParams);
			}

			if (formParams != null)
			{
				SetFormParams(formParams);
			}

			if (fileParams != null)
			{
				SetFileParams(fileParams);
			}

			if (pathParams != null)
			{
				SetPathParams(pathParams);
			}

			if (postBody != null)
			{
				SetPostBody(postBody);
			}

			if (contentType != null)
			{
				SetContentType(contentType);
			}
		}

		// Mandatory fields with validation
		/// <summary>
		/// Sets the request URL
		/// </summary>
		/// <param name="url">The URL to set</param>
		/// <exception cref="ArgumentException">Thrown when URL is null or empty</exception>
		public void SetUrl(string url)
		{
			if (string.IsNullOrEmpty(url))
			{
				throw new ArgumentException("The 'url' property is required");
			}
			Url = url;
		}

		/// <summary>
		/// Sets the HTTP method
		/// </summary>
		/// <param name="method">The method to set</param>
		/// <exception cref="ArgumentException">Thrown when method is invalid</exception>
		public void SetMethod(string method)
		{
			if (string.IsNullOrEmpty(method) || !ValidMethods.Contains(method.ToUpper()))
			{
				throw new ArgumentException("The 'method' property is required");
			}
			Method = method.ToUpper();
		}

		// Optional fields
		/// <summary>
		/// Sets the query parameters
		/// </summary>
		/// <param name="queryParams">The query parameters to set</param>
		/// <exception cref="ArgumentException">Thrown when queryParams is null</exception>
		public void SetQueryParams(List<Tuple<string, string>> queryParams)
		{
			QueryParams = queryParams ?? throw new ArgumentException("QueryParams cannot be null");
		}

		/// <summary>
		/// Sets the header parameters
		/// </summary>
		/// <param name="headerParams">The header parameters to set</param>
		/// <exception cref="ArgumentException">Thrown when headerParams is null</exception>
		public void SetHeaderParams(Dictionary<string, string> headerParams)
		{
			HeaderParams = headerParams ?? throw new ArgumentException("HeaderParams cannot be null");
		}

		/// <summary>
		/// Sets the form parameters
		/// </summary>
		/// <param name="formParams">The form parameters to set</param>
		/// <exception cref="ArgumentException">Thrown when formParams is null</exception>
		public void SetFormParams(Dictionary<string, string> formParams)
		{
			FormParams = formParams ?? throw new ArgumentException("FormParams cannot be null");
		}

		/// <summary>
		/// Sets the file parameters
		/// </summary>
		/// <param name="fileParams">The file parameters to set</param>
		/// <exception cref="ArgumentException">Thrown when fileParams is null</exception>
		public void SetFileParams(Dictionary<string, IFileParameter> fileParams)
		{
			FileParams = fileParams ?? throw new ArgumentException("FileParams cannot be null");
		}

		/// <summary>
		/// Sets the path parameters
		/// </summary>
		/// <param name="pathParams">The path parameters to set</param>
		/// <exception cref="ArgumentException">Thrown when pathParams is null</exception>
		public void SetPathParams(Dictionary<string, string> pathParams)
		{
			PathParams = pathParams ?? throw new ArgumentException("PathParams cannot be null");
		}

		/// <summary>
		/// Sets the request body
		/// </summary>
		/// <param name="postBody">The body to set</param>
		/// <exception cref="ArgumentException">Thrown when postBody is null</exception>
		public void SetPostBody(object postBody)
		{
			if (postBody == null)
			{
				throw new ArgumentException("The 'postBody' property is required");
			}
			PostBody = postBody;
		}

		/// <summary>
		/// Sets the content type
		/// </summary>
		/// <param name="contentType">The content type to set</param>
		public void SetContentType(string contentType)
		{
			ContentType = contentType;
		}

		/// <summary>
		/// Adds a header parameter
		/// </summary>
		/// <param name="key">The header key</param>
		/// <param name="value">The header value</param>
		public void AddHeaderParam(string key, string value)
		{
			HeaderParams[key] = value;
		}
	}
}
