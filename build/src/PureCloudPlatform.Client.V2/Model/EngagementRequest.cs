using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EngagementRequest
	/// </summary>
	[DataContract]
	public partial class EngagementRequest : IEquatable<EngagementRequest>
	{
		/// <summary>
		/// Represents the visibility of summary
		/// </summary>
		/// <value>Represents the visibility of summary</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum VisibilityEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Presented for "Presented"
			/// </summary>
			[EnumMember(Value = "Presented")]
			Presented,

			/// <summary>
			/// Enum Notpresented for "NotPresented"
			/// </summary>
			[EnumMember(Value = "NotPresented")]
			Notpresented,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Represents the engagements made by the agent in response to the generated summary
		/// </summary>
		/// <value>Represents the engagements made by the agent in response to the generated summary</value>
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
			/// Enum Copied for "Copied"
			/// </summary>
			[EnumMember(Value = "Copied")]
			Copied,

			/// <summary>
			/// Enum Notcopied for "NotCopied"
			/// </summary>
			[EnumMember(Value = "NotCopied")]
			Notcopied,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Represents the visibility of summary
		/// </summary>
		/// <value>Represents the visibility of summary</value>
		[DataMember(Name = "visibility", EmitDefaultValue = false)]
		public VisibilityEnum? Visibility { get; set; }
		/// <summary>
		/// Represents the engagements made by the agent in response to the generated summary
		/// </summary>
		/// <value>Represents the engagements made by the agent in response to the generated summary</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="EngagementRequest" /> class.
		/// </summary>
		/// <param name="Visibility">Represents the visibility of summary.</param>
		/// <param name="Status">Represents the engagements made by the agent in response to the generated summary.</param>
		public EngagementRequest(VisibilityEnum? Visibility = null, StatusEnum? Status = null)
		{
			this.Visibility = Visibility;
			this.Status = Status;

		}






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EngagementRequest {\n");

			sb.Append("  Visibility: ").Append(Visibility).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
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
			return this.Equals(obj as EngagementRequest);
		}

		/// <summary>
		/// Returns true if EngagementRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of EngagementRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EngagementRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Visibility == other.Visibility ||
					this.Visibility != null &&
					this.Visibility.Equals(other.Visibility)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
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
				if (this.Visibility != null)
					hash = hash * 59 + this.Visibility.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				return hash;
			}
		}
	}

}
