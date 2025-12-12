using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OutboundPreviewCampaignPreContactVoiceAttributes
	/// </summary>
	[DataContract]
	public partial class OutboundPreviewCampaignPreContactVoiceAttributes : IEquatable<OutboundPreviewCampaignPreContactVoiceAttributes>
	{
		/// <summary>
		/// Gets or Sets ContactPhoneType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ContactPhoneTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "UNKNOWN"
			/// </summary>
			[EnumMember(Value = "UNKNOWN")]
			Unknown,

			/// <summary>
			/// Enum Cell for "CELL"
			/// </summary>
			[EnumMember(Value = "CELL")]
			Cell,

			/// <summary>
			/// Enum Daytime for "DAYTIME"
			/// </summary>
			[EnumMember(Value = "DAYTIME")]
			Daytime,

			/// <summary>
			/// Enum Evening for "EVENING"
			/// </summary>
			[EnumMember(Value = "EVENING")]
			Evening,

			/// <summary>
			/// Enum Home for "HOME"
			/// </summary>
			[EnumMember(Value = "HOME")]
			Home,

			/// <summary>
			/// Enum Work for "WORK"
			/// </summary>
			[EnumMember(Value = "WORK")]
			Work
		}
		/// <summary>
		/// Gets or Sets ContactPhoneType
		/// </summary>
		[DataMember(Name = "contactPhoneType", EmitDefaultValue = false)]
		public ContactPhoneTypeEnum? ContactPhoneType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutboundPreviewCampaignPreContactVoiceAttributes" /> class.
		/// </summary>
		/// <param name="ContactPhoneNumber">ContactPhoneNumber.</param>
		/// <param name="ContactPhoneType">ContactPhoneType.</param>
		/// <param name="CallerIdPhoneNumber">CallerIdPhoneNumber.</param>
		/// <param name="CallerIdName">CallerIdName.</param>
		/// <param name="AgentOwnedColumnName">AgentOwnedColumnName.</param>
		/// <param name="PreviewModeColumnName">PreviewModeColumnName.</param>
		/// <param name="IsDeliveredAsPreview">IsDeliveredAsPreview.</param>
		public OutboundPreviewCampaignPreContactVoiceAttributes(string ContactPhoneNumber = null, ContactPhoneTypeEnum? ContactPhoneType = null, string CallerIdPhoneNumber = null, string CallerIdName = null, string AgentOwnedColumnName = null, string PreviewModeColumnName = null, bool? IsDeliveredAsPreview = null)
		{
			this.ContactPhoneNumber = ContactPhoneNumber;
			this.ContactPhoneType = ContactPhoneType;
			this.CallerIdPhoneNumber = CallerIdPhoneNumber;
			this.CallerIdName = CallerIdName;
			this.AgentOwnedColumnName = AgentOwnedColumnName;
			this.PreviewModeColumnName = PreviewModeColumnName;
			this.IsDeliveredAsPreview = IsDeliveredAsPreview;

		}



		/// <summary>
		/// Gets or Sets ContactPhoneNumber
		/// </summary>
		[DataMember(Name = "contactPhoneNumber", EmitDefaultValue = false)]
		public string ContactPhoneNumber { get; set; }





		/// <summary>
		/// Gets or Sets CallerIdPhoneNumber
		/// </summary>
		[DataMember(Name = "callerIdPhoneNumber", EmitDefaultValue = false)]
		public string CallerIdPhoneNumber { get; set; }



		/// <summary>
		/// Gets or Sets CallerIdName
		/// </summary>
		[DataMember(Name = "callerIdName", EmitDefaultValue = false)]
		public string CallerIdName { get; set; }



		/// <summary>
		/// Gets or Sets AgentOwnedColumnName
		/// </summary>
		[DataMember(Name = "agentOwnedColumnName", EmitDefaultValue = false)]
		public string AgentOwnedColumnName { get; set; }



		/// <summary>
		/// Gets or Sets PreviewModeColumnName
		/// </summary>
		[DataMember(Name = "previewModeColumnName", EmitDefaultValue = false)]
		public string PreviewModeColumnName { get; set; }



		/// <summary>
		/// Gets or Sets IsDeliveredAsPreview
		/// </summary>
		[DataMember(Name = "isDeliveredAsPreview", EmitDefaultValue = false)]
		public bool? IsDeliveredAsPreview { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutboundPreviewCampaignPreContactVoiceAttributes {\n");

			sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
			sb.Append("  ContactPhoneType: ").Append(ContactPhoneType).Append("\n");
			sb.Append("  CallerIdPhoneNumber: ").Append(CallerIdPhoneNumber).Append("\n");
			sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
			sb.Append("  AgentOwnedColumnName: ").Append(AgentOwnedColumnName).Append("\n");
			sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
			sb.Append("  IsDeliveredAsPreview: ").Append(IsDeliveredAsPreview).Append("\n");
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
			return this.Equals(obj as OutboundPreviewCampaignPreContactVoiceAttributes);
		}

		/// <summary>
		/// Returns true if OutboundPreviewCampaignPreContactVoiceAttributes instances are equal
		/// </summary>
		/// <param name="other">Instance of OutboundPreviewCampaignPreContactVoiceAttributes to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutboundPreviewCampaignPreContactVoiceAttributes other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ContactPhoneNumber == other.ContactPhoneNumber ||
					this.ContactPhoneNumber != null &&
					this.ContactPhoneNumber.Equals(other.ContactPhoneNumber)
				) &&
				(
					this.ContactPhoneType == other.ContactPhoneType ||
					this.ContactPhoneType != null &&
					this.ContactPhoneType.Equals(other.ContactPhoneType)
				) &&
				(
					this.CallerIdPhoneNumber == other.CallerIdPhoneNumber ||
					this.CallerIdPhoneNumber != null &&
					this.CallerIdPhoneNumber.Equals(other.CallerIdPhoneNumber)
				) &&
				(
					this.CallerIdName == other.CallerIdName ||
					this.CallerIdName != null &&
					this.CallerIdName.Equals(other.CallerIdName)
				) &&
				(
					this.AgentOwnedColumnName == other.AgentOwnedColumnName ||
					this.AgentOwnedColumnName != null &&
					this.AgentOwnedColumnName.Equals(other.AgentOwnedColumnName)
				) &&
				(
					this.PreviewModeColumnName == other.PreviewModeColumnName ||
					this.PreviewModeColumnName != null &&
					this.PreviewModeColumnName.Equals(other.PreviewModeColumnName)
				) &&
				(
					this.IsDeliveredAsPreview == other.IsDeliveredAsPreview ||
					this.IsDeliveredAsPreview != null &&
					this.IsDeliveredAsPreview.Equals(other.IsDeliveredAsPreview)
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
				if (this.ContactPhoneNumber != null)
					hash = hash * 59 + this.ContactPhoneNumber.GetHashCode();

				if (this.ContactPhoneType != null)
					hash = hash * 59 + this.ContactPhoneType.GetHashCode();

				if (this.CallerIdPhoneNumber != null)
					hash = hash * 59 + this.CallerIdPhoneNumber.GetHashCode();

				if (this.CallerIdName != null)
					hash = hash * 59 + this.CallerIdName.GetHashCode();

				if (this.AgentOwnedColumnName != null)
					hash = hash * 59 + this.AgentOwnedColumnName.GetHashCode();

				if (this.PreviewModeColumnName != null)
					hash = hash * 59 + this.PreviewModeColumnName.GetHashCode();

				if (this.IsDeliveredAsPreview != null)
					hash = hash * 59 + this.IsDeliveredAsPreview.GetHashCode();

				return hash;
			}
		}
	}

}
