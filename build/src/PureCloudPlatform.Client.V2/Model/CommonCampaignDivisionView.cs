using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CommonCampaignDivisionView
	/// </summary>
	[DataContract]
	public partial class CommonCampaignDivisionView : IEquatable<CommonCampaignDivisionView>
	{
		/// <summary>
		/// The media type used for this campaign.
		/// </summary>
		/// <value>The media type used for this campaign.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MediaTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Email for "email"
			/// </summary>
			[EnumMember(Value = "email")]
			Email,

			/// <summary>
			/// Enum Sms for "sms"
			/// </summary>
			[EnumMember(Value = "sms")]
			Sms,

			/// <summary>
			/// Enum Voice for "voice"
			/// </summary>
			[EnumMember(Value = "voice")]
			Voice,

			/// <summary>
			/// Enum Whatsapp for "whatsapp"
			/// </summary>
			[EnumMember(Value = "whatsapp")]
			Whatsapp
		}
		/// <summary>
		/// The media type used for this campaign.
		/// </summary>
		/// <value>The media type used for this campaign.</value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CommonCampaignDivisionView" /> class.
		/// </summary>
		/// <param name="Name">The name of the Campaign..</param>
		/// <param name="Division">The division to which this entity belongs..</param>
		/// <param name="MediaType">The media type used for this campaign..</param>
		public CommonCampaignDivisionView(string Name = null, Division Division = null, MediaTypeEnum? MediaType = null)
		{
			this.Name = Name;
			this.Division = Division;
			this.MediaType = MediaType;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the Campaign.
		/// </summary>
		/// <value>The name of the Campaign.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The division to which this entity belongs.
		/// </summary>
		/// <value>The division to which this entity belongs.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public Division Division { get; set; }





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
			sb.Append("class CommonCampaignDivisionView {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
			return this.Equals(obj as CommonCampaignDivisionView);
		}

		/// <summary>
		/// Returns true if CommonCampaignDivisionView instances are equal
		/// </summary>
		/// <param name="other">Instance of CommonCampaignDivisionView to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CommonCampaignDivisionView other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
