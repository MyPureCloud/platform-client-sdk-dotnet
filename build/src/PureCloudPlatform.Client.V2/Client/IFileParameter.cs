namespace PureCloudPlatform.Client.V2.Client
{
	/// <summary>
	/// Interface for file upload parameters
	/// </summary>
	public interface IFileParameter
	{
		/// <summary>
		/// Gets the name of the file parameter
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Gets the filename
		/// </summary>
		string FileName { get; }

		/// <summary>
		/// Gets the content type
		/// </summary>
		string ContentType { get; }

		/// <summary>
		/// Gets the file content stream
		/// </summary>
		/// <returns>Stream containing the file content</returns>
		Stream GetFile();
	}
}