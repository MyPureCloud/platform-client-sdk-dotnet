using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ChatPresence
	/// </summary>
	[DataContract]
	public partial class ChatPresence : IEquatable<ChatPresence>
	{
		/// <summary>
		/// Gets or Sets SystemPresence
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SystemPresenceEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Available for "Available"
			/// </summary>
			[EnumMember(Value = "Available")]
			Available,

			/// <summary>
			/// Enum Away for "Away"
			/// </summary>
			[EnumMember(Value = "Away")]
			Away,

			/// <summary>
			/// Enum Busy for "Busy"
			/// </summary>
			[EnumMember(Value = "Busy")]
			Busy,

			/// <summary>
			/// Enum Offline for "Offline"
			/// </summary>
			[EnumMember(Value = "Offline")]
			Offline,

			/// <summary>
			/// Enum Idle for "Idle"
			/// </summary>
			[EnumMember(Value = "Idle")]
			Idle,

			/// <summary>
			/// Enum Onqueue for "OnQueue"
			/// </summary>
			[EnumMember(Value = "OnQueue")]
			Onqueue,

			/// <summary>
			/// Enum Meal for "Meal"
			/// </summary>
			[EnumMember(Value = "Meal")]
			Meal,

			/// <summary>
			/// Enum Training for "Training"
			/// </summary>
			[EnumMember(Value = "Training")]
			Training,

			/// <summary>
			/// Enum Meeting for "Meeting"
			/// </summary>
			[EnumMember(Value = "Meeting")]
			Meeting,

			/// <summary>
			/// Enum Break for "Break"
			/// </summary>
			[EnumMember(Value = "Break")]
			Break
		}
		/// <summary>
		/// Gets or Sets SystemPresence
		/// </summary>
		[DataMember(Name = "systemPresence", EmitDefaultValue = false)]
		public SystemPresenceEnum? SystemPresence { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ChatPresence" /> class.
		/// </summary>
		/// <param name="Source">Source.</param>
		/// <param name="OrganizationPresence">OrganizationPresence.</param>
		/// <param name="SystemPresence">SystemPresence.</param>
		/// <param name="Message">Message.</param>
		/// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="OutOfOffice">OutOfOffice.</param>
		public ChatPresence(string Source = null, OrganizationPresence OrganizationPresence = null, SystemPresenceEnum? SystemPresence = null, string Message = null, DateTime? DateModified = null, OutOfOffice OutOfOffice = null)
		{
			this.Source = Source;
			this.OrganizationPresence = OrganizationPresence;
			this.SystemPresence = SystemPresence;
			this.Message = Message;
			this.DateModified = DateModified;
			this.OutOfOffice = OutOfOffice;

		}



		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string Source { get; set; }



		/// <summary>
		/// Gets or Sets OrganizationPresence
		/// </summary>
		[DataMember(Name = "organizationPresence", EmitDefaultValue = false)]
		public OrganizationPresence OrganizationPresence { get; set; }





		/// <summary>
		/// Gets or Sets Message
		/// </summary>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// Gets or Sets OutOfOffice
		/// </summary>
		[DataMember(Name = "outOfOffice", EmitDefaultValue = false)]
		public OutOfOffice OutOfOffice { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ChatPresence {\n");

			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  OrganizationPresence: ").Append(OrganizationPresence).Append("\n");
			sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
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
			return this.Equals(obj as ChatPresence);
		}

		/// <summary>
		/// Returns true if ChatPresence instances are equal
		/// </summary>
		/// <param name="other">Instance of ChatPresence to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ChatPresence other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
				) &&
				(
					this.OrganizationPresence == other.OrganizationPresence ||
					this.OrganizationPresence != null &&
					this.OrganizationPresence.Equals(other.OrganizationPresence)
				) &&
				(
					this.SystemPresence == other.SystemPresence ||
					this.SystemPresence != null &&
					this.SystemPresence.Equals(other.SystemPresence)
				) &&
				(
					this.Message == other.Message ||
					this.Message != null &&
					this.Message.Equals(other.Message)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.OutOfOffice == other.OutOfOffice ||
					this.OutOfOffice != null &&
					this.OutOfOffice.Equals(other.OutOfOffice)
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
				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				if (this.OrganizationPresence != null)
					hash = hash * 59 + this.OrganizationPresence.GetHashCode();

				if (this.SystemPresence != null)
					hash = hash * 59 + this.SystemPresence.GetHashCode();

				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.OutOfOffice != null)
					hash = hash * 59 + this.OutOfOffice.GetHashCode();

				return hash;
			}
		}
	}

}
