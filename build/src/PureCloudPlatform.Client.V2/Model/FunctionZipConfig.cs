using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Action function zip file upload settings and state.
	/// </summary>
	[DataContract]
	public partial class FunctionZipConfig : IEquatable<FunctionZipConfig>
	{
		/// <summary>
		/// Status of zip upload.
		/// </summary>
		/// <value>Status of zip upload.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Pending for "Pending"
			/// </summary>
			[EnumMember(Value = "Pending")]
			Pending,

			/// <summary>
			/// Enum Transferring for "Transferring"
			/// </summary>
			[EnumMember(Value = "Transferring")]
			Transferring,

			/// <summary>
			/// Enum Available for "Available"
			/// </summary>
			[EnumMember(Value = "Available")]
			Available,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Invalid for "Invalid"
			/// </summary>
			[EnumMember(Value = "Invalid")]
			Invalid,

			/// <summary>
			/// Enum Invalidformat for "InvalidFormat"
			/// </summary>
			[EnumMember(Value = "InvalidFormat")]
			Invalidformat,

			/// <summary>
			/// Enum Invalidfile for "InvalidFile"
			/// </summary>
			[EnumMember(Value = "InvalidFile")]
			Invalidfile
		}
		/// <summary>
		/// Status of zip upload.
		/// </summary>
		/// <value>Status of zip upload.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FunctionZipConfig" /> class.
		/// </summary>
		public FunctionZipConfig()
		{

		}





		/// <summary>
		/// Zip file Identifier
		/// </summary>
		/// <value>Zip file Identifier</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Zip file name
		/// </summary>
		/// <value>Zip file name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; private set; }



		/// <summary>
		/// Date and time zip record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date and time zip record was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// Error message if upload failed.
		/// </summary>
		/// <value>Error message if upload failed.</value>
		[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
		public string ErrorMessage { get; private set; }



		/// <summary>
		/// Upload request id used for zip upload
		/// </summary>
		/// <value>Upload request id used for zip upload</value>
		[DataMember(Name = "requestId", EmitDefaultValue = false)]
		public string RequestId { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FunctionZipConfig {\n");

			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
			sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
			return this.Equals(obj as FunctionZipConfig);
		}

		/// <summary>
		/// Returns true if FunctionZipConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of FunctionZipConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FunctionZipConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.ErrorMessage == other.ErrorMessage ||
					this.ErrorMessage != null &&
					this.ErrorMessage.Equals(other.ErrorMessage)
				) &&
				(
					this.RequestId == other.RequestId ||
					this.RequestId != null &&
					this.RequestId.Equals(other.RequestId)
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
				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.ErrorMessage != null)
					hash = hash * 59 + this.ErrorMessage.GetHashCode();

				if (this.RequestId != null)
					hash = hash * 59 + this.RequestId.GetHashCode();

				return hash;
			}
		}
	}

}
