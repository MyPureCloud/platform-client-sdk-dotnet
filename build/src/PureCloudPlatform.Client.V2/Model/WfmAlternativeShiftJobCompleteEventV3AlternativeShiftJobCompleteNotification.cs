using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification
	/// </summary>
	[DataContract]
	public partial class WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification : IEquatable<WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification>
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Listoffers for "ListOffers"
			/// </summary>
			[EnumMember(Value = "ListOffers")]
			Listoffers,

			/// <summary>
			/// Enum Searchoffers for "SearchOffers"
			/// </summary>
			[EnumMember(Value = "SearchOffers")]
			Searchoffers,

			/// <summary>
			/// Enum Listusertrades for "ListUserTrades"
			/// </summary>
			[EnumMember(Value = "ListUserTrades")]
			Listusertrades,

			/// <summary>
			/// Enum Searchtrades for "SearchTrades"
			/// </summary>
			[EnumMember(Value = "SearchTrades")]
			Searchtrades,

			/// <summary>
			/// Enum Bulkupdatetrades for "BulkUpdateTrades"
			/// </summary>
			[EnumMember(Value = "BulkUpdateTrades")]
			Bulkupdatetrades
		}
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
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
			/// Enum Processing for "Processing"
			/// </summary>
			[EnumMember(Value = "Processing")]
			Processing,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Type">Type.</param>
		/// <param name="Status">Status.</param>
		/// <param name="DownloadUrl">DownloadUrl.</param>
		/// <param name="Error">Error.</param>
		public WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification(string Id = null, TypeEnum? Type = null, StatusEnum? Status = null, string DownloadUrl = null, WfmAlternativeShiftJobCompleteEventV3ErrorBody Error = null)
		{
			this.Id = Id;
			this.Type = Type;
			this.Status = Status;
			this.DownloadUrl = DownloadUrl;
			this.Error = Error;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }







		/// <summary>
		/// Gets or Sets DownloadUrl
		/// </summary>
		[DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
		public string DownloadUrl { get; set; }



		/// <summary>
		/// Gets or Sets Error
		/// </summary>
		[DataMember(Name = "error", EmitDefaultValue = false)]
		public WfmAlternativeShiftJobCompleteEventV3ErrorBody Error { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
			sb.Append("  Error: ").Append(Error).Append("\n");
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
			return this.Equals(obj as WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification);
		}

		/// <summary>
		/// Returns true if WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmAlternativeShiftJobCompleteEventV3AlternativeShiftJobCompleteNotification other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.DownloadUrl == other.DownloadUrl ||
					this.DownloadUrl != null &&
					this.DownloadUrl.Equals(other.DownloadUrl)
				) &&
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.DownloadUrl != null)
					hash = hash * 59 + this.DownloadUrl.GetHashCode();

				if (this.Error != null)
					hash = hash * 59 + this.Error.GetHashCode();

				return hash;
			}
		}
	}

}
