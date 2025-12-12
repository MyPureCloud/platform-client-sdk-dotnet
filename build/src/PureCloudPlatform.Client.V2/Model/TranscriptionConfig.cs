using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TranscriptionConfig
	/// </summary>
	[DataContract]
	public partial class TranscriptionConfig : IEquatable<TranscriptionConfig>
	{
		/// <summary>
		/// The name of the vendor used for speech transcription.
		/// </summary>
		/// <value>The name of the vendor used for speech transcription.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum VendorNameEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Googledialogflow for "GoogleDialogflow"
			/// </summary>
			[EnumMember(Value = "GoogleDialogflow")]
			Googledialogflow,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Genesys for "Genesys"
			/// </summary>
			[EnumMember(Value = "Genesys")]
			Genesys
		}
		/// <summary>
		/// The name of the vendor used for speech transcription.
		/// </summary>
		/// <value>The name of the vendor used for speech transcription.</value>
		[DataMember(Name = "vendorName", EmitDefaultValue = false)]
		public VendorNameEnum? VendorName { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TranscriptionConfig() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
		/// </summary>
		/// <param name="VendorName">The name of the vendor used for speech transcription. (required).</param>
		public TranscriptionConfig(VendorNameEnum? VendorName = null)
		{
			this.VendorName = VendorName;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TranscriptionConfig {\n");

			sb.Append("  VendorName: ").Append(VendorName).Append("\n");
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
			return this.Equals(obj as TranscriptionConfig);
		}

		/// <summary>
		/// Returns true if TranscriptionConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of TranscriptionConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TranscriptionConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.VendorName == other.VendorName ||
					this.VendorName != null &&
					this.VendorName.Equals(other.VendorName)
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
				if (this.VendorName != null)
					hash = hash * 59 + this.VendorName.GetHashCode();

				return hash;
			}
		}
	}

}
