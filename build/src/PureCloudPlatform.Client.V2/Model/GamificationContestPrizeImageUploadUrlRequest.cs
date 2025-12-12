using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GamificationContestPrizeImageUploadUrlRequest
	/// </summary>
	[DataContract]
	public partial class GamificationContestPrizeImageUploadUrlRequest : IEquatable<GamificationContestPrizeImageUploadUrlRequest>
	{
		/// <summary>
		/// The content type of the file to upload.
		/// </summary>
		/// <value>The content type of the file to upload.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ContentTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Jpeg for "image/jpeg"
			/// </summary>
			[EnumMember(Value = "image/jpeg")]
			Jpeg,

			/// <summary>
			/// Enum Jpg for "image/jpg"
			/// </summary>
			[EnumMember(Value = "image/jpg")]
			Jpg,

			/// <summary>
			/// Enum Png for "image/png"
			/// </summary>
			[EnumMember(Value = "image/png")]
			Png
		}
		/// <summary>
		/// Gets or Sets ServerSideEncryption
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ServerSideEncryptionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Aes256 for "AES256"
			/// </summary>
			[EnumMember(Value = "AES256")]
			Aes256
		}
		/// <summary>
		/// The content type of the file to upload.
		/// </summary>
		/// <value>The content type of the file to upload.</value>
		[DataMember(Name = "contentType", EmitDefaultValue = false)]
		public ContentTypeEnum? ContentType { get; set; }
		/// <summary>
		/// Gets or Sets ServerSideEncryption
		/// </summary>
		[DataMember(Name = "serverSideEncryption", EmitDefaultValue = false)]
		public ServerSideEncryptionEnum? ServerSideEncryption { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="GamificationContestPrizeImageUploadUrlRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected GamificationContestPrizeImageUploadUrlRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="GamificationContestPrizeImageUploadUrlRequest" /> class.
		/// </summary>
		/// <param name="FileName">Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|.</param>
		/// <param name="ContentMd5">Content MD5 of the file to upload.</param>
		/// <param name="SignedUrlTimeoutSeconds">The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds.</param>
		/// <param name="ContentType">The content type of the file to upload. (required).</param>
		/// <param name="ContentLength">The size of the file to upload. (required).</param>
		/// <param name="ServerSideEncryption">ServerSideEncryption.</param>
		public GamificationContestPrizeImageUploadUrlRequest(string FileName = null, string ContentMd5 = null, int? SignedUrlTimeoutSeconds = null, ContentTypeEnum? ContentType = null, long? ContentLength = null, ServerSideEncryptionEnum? ServerSideEncryption = null)
		{
			this.FileName = FileName;
			this.ContentMd5 = ContentMd5;
			this.SignedUrlTimeoutSeconds = SignedUrlTimeoutSeconds;
			this.ContentType = ContentType;
			this.ContentLength = ContentLength;
			this.ServerSideEncryption = ServerSideEncryption;

		}



		/// <summary>
		/// Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|
		/// </summary>
		/// <value>Name of the file to upload. It must not start with a dot and not end with a forward slash. Whitespace and the following characters are not allowed: \\{^}%&#x60;]\&quot;&gt;[~&lt;#|</value>
		[DataMember(Name = "fileName", EmitDefaultValue = false)]
		public string FileName { get; set; }



		/// <summary>
		/// Content MD5 of the file to upload
		/// </summary>
		/// <value>Content MD5 of the file to upload</value>
		[DataMember(Name = "contentMd5", EmitDefaultValue = false)]
		public string ContentMd5 { get; set; }



		/// <summary>
		/// The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds
		/// </summary>
		/// <value>The number of seconds the presigned URL is valid for (from 1 to 604800 seconds). If none provided, defaults to 600 seconds</value>
		[DataMember(Name = "signedUrlTimeoutSeconds", EmitDefaultValue = false)]
		public int? SignedUrlTimeoutSeconds { get; set; }





		/// <summary>
		/// The size of the file to upload.
		/// </summary>
		/// <value>The size of the file to upload.</value>
		[DataMember(Name = "contentLength", EmitDefaultValue = false)]
		public long? ContentLength { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GamificationContestPrizeImageUploadUrlRequest {\n");

			sb.Append("  FileName: ").Append(FileName).Append("\n");
			sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
			sb.Append("  SignedUrlTimeoutSeconds: ").Append(SignedUrlTimeoutSeconds).Append("\n");
			sb.Append("  ContentType: ").Append(ContentType).Append("\n");
			sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
			sb.Append("  ServerSideEncryption: ").Append(ServerSideEncryption).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, new JsonSerializerSettings
			{
				MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
				Formatting = Formatting.Indented
			});
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return this.Equals(obj as GamificationContestPrizeImageUploadUrlRequest);
		}

		/// <summary>
		/// Returns true if GamificationContestPrizeImageUploadUrlRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of GamificationContestPrizeImageUploadUrlRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GamificationContestPrizeImageUploadUrlRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FileName == other.FileName ||
					this.FileName != null &&
					this.FileName.Equals(other.FileName)
				) &&
				(
					this.ContentMd5 == other.ContentMd5 ||
					this.ContentMd5 != null &&
					this.ContentMd5.Equals(other.ContentMd5)
				) &&
				(
					this.SignedUrlTimeoutSeconds == other.SignedUrlTimeoutSeconds ||
					this.SignedUrlTimeoutSeconds != null &&
					this.SignedUrlTimeoutSeconds.Equals(other.SignedUrlTimeoutSeconds)
				) &&
				(
					this.ContentType == other.ContentType ||
					this.ContentType != null &&
					this.ContentType.Equals(other.ContentType)
				) &&
				(
					this.ContentLength == other.ContentLength ||
					this.ContentLength != null &&
					this.ContentLength.Equals(other.ContentLength)
				) &&
				(
					this.ServerSideEncryption == other.ServerSideEncryption ||
					this.ServerSideEncryption != null &&
					this.ServerSideEncryption.Equals(other.ServerSideEncryption)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			// credit: http://stackoverflow.com/a/263416/677735
			unchecked // Overflow is fine, just wrap
			{
				int hash = 41;
				// Suitable nullity checks etc, of course :)
				if (this.FileName != null)
					hash = hash * 59 + this.FileName.GetHashCode();

				if (this.ContentMd5 != null)
					hash = hash * 59 + this.ContentMd5.GetHashCode();

				if (this.SignedUrlTimeoutSeconds != null)
					hash = hash * 59 + this.SignedUrlTimeoutSeconds.GetHashCode();

				if (this.ContentType != null)
					hash = hash * 59 + this.ContentType.GetHashCode();

				if (this.ContentLength != null)
					hash = hash * 59 + this.ContentLength.GetHashCode();

				if (this.ServerSideEncryption != null)
					hash = hash * 59 + this.ServerSideEncryption.GetHashCode();

				return hash;
			}
		}
	}

}
