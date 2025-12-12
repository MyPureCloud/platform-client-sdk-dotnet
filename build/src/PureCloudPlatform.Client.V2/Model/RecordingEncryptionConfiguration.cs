using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingEncryptionConfiguration
	/// </summary>
	[DataContract]
	public partial class RecordingEncryptionConfiguration : IEquatable<RecordingEncryptionConfiguration>
	{
		/// <summary>
		/// Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.
		/// </summary>
		/// <value>Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum KeyConfigurationTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Kmssymmetric for "KmsSymmetric"
			/// </summary>
			[EnumMember(Value = "KmsSymmetric")]
			Kmssymmetric,

			/// <summary>
			/// Enum Localkeymanager for "LocalKeyManager"
			/// </summary>
			[EnumMember(Value = "LocalKeyManager")]
			Localkeymanager,

			/// <summary>
			/// Enum Native for "Native"
			/// </summary>
			[EnumMember(Value = "Native")]
			Native,

			/// <summary>
			/// Enum None for "None"
			/// </summary>
			[EnumMember(Value = "None")]
			None
		}
		/// <summary>
		/// Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.
		/// </summary>
		/// <value>Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; 'Native' for disabling configuration.</value>
		[DataMember(Name = "keyConfigurationType", EmitDefaultValue = false)]
		public KeyConfigurationTypeEnum? KeyConfigurationType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingEncryptionConfiguration" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected RecordingEncryptionConfiguration() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingEncryptionConfiguration" /> class.
		/// </summary>
		/// <param name="Url">When keyConfigurationType is LocalKeyManager, this should be the url for decryption and must specify the path to where GenesysCloud can requests decryption. When keyConfigurationType is KmsSymmetric, this should be the arn to the key alias for the master key (required).</param>
		/// <param name="ApiId">The api id for Hawk Authentication. Null if keyConfigurationType is KmsSymmetric.</param>
		/// <param name="ApiKey">The api shared symmetric key used for hawk authentication. Null if keyConfigurationType is KmsSymmetric.</param>
		/// <param name="KeyConfigurationType">Type should be LocalKeyManager or KmsSymmetric when create or update Key configurations; &#39;Native&#39; for disabling configuration. (required).</param>
		/// <param name="LastError">The error message related to the configuration.</param>
		public RecordingEncryptionConfiguration(string Url = null, string ApiId = null, string ApiKey = null, KeyConfigurationTypeEnum? KeyConfigurationType = null, ErrorBody LastError = null)
		{
			this.Url = Url;
			this.ApiId = ApiId;
			this.ApiKey = ApiKey;
			this.KeyConfigurationType = KeyConfigurationType;
			this.LastError = LastError;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// When keyConfigurationType is LocalKeyManager, this should be the url for decryption and must specify the path to where GenesysCloud can requests decryption. When keyConfigurationType is KmsSymmetric, this should be the arn to the key alias for the master key
		/// </summary>
		/// <value>When keyConfigurationType is LocalKeyManager, this should be the url for decryption and must specify the path to where GenesysCloud can requests decryption. When keyConfigurationType is KmsSymmetric, this should be the arn to the key alias for the master key</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }



		/// <summary>
		/// The api id for Hawk Authentication. Null if keyConfigurationType is KmsSymmetric
		/// </summary>
		/// <value>The api id for Hawk Authentication. Null if keyConfigurationType is KmsSymmetric</value>
		[DataMember(Name = "apiId", EmitDefaultValue = false)]
		public string ApiId { get; set; }



		/// <summary>
		/// The api shared symmetric key used for hawk authentication. Null if keyConfigurationType is KmsSymmetric
		/// </summary>
		/// <value>The api shared symmetric key used for hawk authentication. Null if keyConfigurationType is KmsSymmetric</value>
		[DataMember(Name = "apiKey", EmitDefaultValue = false)]
		public string ApiKey { get; set; }





		/// <summary>
		/// The error message related to the configuration
		/// </summary>
		/// <value>The error message related to the configuration</value>
		[DataMember(Name = "lastError", EmitDefaultValue = false)]
		public ErrorBody LastError { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingEncryptionConfiguration {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  ApiId: ").Append(ApiId).Append("\n");
			sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
			sb.Append("  KeyConfigurationType: ").Append(KeyConfigurationType).Append("\n");
			sb.Append("  LastError: ").Append(LastError).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as RecordingEncryptionConfiguration);
		}

		/// <summary>
		/// Returns true if RecordingEncryptionConfiguration instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingEncryptionConfiguration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingEncryptionConfiguration other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
				) &&
				(
					this.ApiId == other.ApiId ||
					this.ApiId != null &&
					this.ApiId.Equals(other.ApiId)
				) &&
				(
					this.ApiKey == other.ApiKey ||
					this.ApiKey != null &&
					this.ApiKey.Equals(other.ApiKey)
				) &&
				(
					this.KeyConfigurationType == other.KeyConfigurationType ||
					this.KeyConfigurationType != null &&
					this.KeyConfigurationType.Equals(other.KeyConfigurationType)
				) &&
				(
					this.LastError == other.LastError ||
					this.LastError != null &&
					this.LastError.Equals(other.LastError)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				if (this.ApiId != null)
					hash = hash * 59 + this.ApiId.GetHashCode();

				if (this.ApiKey != null)
					hash = hash * 59 + this.ApiKey.GetHashCode();

				if (this.KeyConfigurationType != null)
					hash = hash * 59 + this.KeyConfigurationType.GetHashCode();

				if (this.LastError != null)
					hash = hash * 59 + this.LastError.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
