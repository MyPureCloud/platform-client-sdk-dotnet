using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AlertRequest
	/// </summary>
	[DataContract]
	public partial class AlertRequest : IEquatable<AlertRequest>
	{
		/// <summary>
		/// The action being taken on the alert.
		/// </summary>
		/// <value>The action being taken on the alert.</value>
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
			/// Enum Mute for "Mute"
			/// </summary>
			[EnumMember(Value = "Mute")]
			Mute,

			/// <summary>
			/// Enum Snooze for "Snooze"
			/// </summary>
			[EnumMember(Value = "Snooze")]
			Snooze,

			/// <summary>
			/// Enum Unread for "Unread"
			/// </summary>
			[EnumMember(Value = "Unread")]
			Unread
		}
		/// <summary>
		/// The action being taken on the alert.
		/// </summary>
		/// <value>The action being taken on the alert.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AlertRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AlertRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AlertRequest" /> class.
		/// </summary>
		/// <param name="Type">The action being taken on the alert. (required).</param>
		/// <param name="DateStart">The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateEnd">The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Unread">The fields need for an unread update requests.</param>
		/// <param name="ValidRequest">ValidRequest.</param>
		public AlertRequest(TypeEnum? Type = null, DateTime? DateStart = null, DateTime? DateEnd = null, UnreadFields Unread = null, bool? ValidRequest = null)
		{
			this.Type = Type;
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.Unread = Unread;
			this.ValidRequest = ValidRequest;

		}





		/// <summary>
		/// The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public DateTime? DateStart { get; set; }



		/// <summary>
		/// The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateEnd", EmitDefaultValue = false)]
		public DateTime? DateEnd { get; set; }



		/// <summary>
		/// The fields need for an unread update requests
		/// </summary>
		/// <value>The fields need for an unread update requests</value>
		[DataMember(Name = "unread", EmitDefaultValue = false)]
		public UnreadFields Unread { get; set; }



		/// <summary>
		/// Gets or Sets ValidRequest
		/// </summary>
		[DataMember(Name = "validRequest", EmitDefaultValue = false)]
		public bool? ValidRequest { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertRequest {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
			sb.Append("  Unread: ").Append(Unread).Append("\n");
			sb.Append("  ValidRequest: ").Append(ValidRequest).Append("\n");
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
			return this.Equals(obj as AlertRequest);
		}

		/// <summary>
		/// Returns true if AlertRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of AlertRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AlertRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.DateEnd == other.DateEnd ||
					this.DateEnd != null &&
					this.DateEnd.Equals(other.DateEnd)
				) &&
				(
					this.Unread == other.Unread ||
					this.Unread != null &&
					this.Unread.Equals(other.Unread)
				) &&
				(
					this.ValidRequest == other.ValidRequest ||
					this.ValidRequest != null &&
					this.ValidRequest.Equals(other.ValidRequest)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.DateEnd != null)
					hash = hash * 59 + this.DateEnd.GetHashCode();

				if (this.Unread != null)
					hash = hash * 59 + this.Unread.GetHashCode();

				if (this.ValidRequest != null)
					hash = hash * 59 + this.ValidRequest.GetHashCode();

				return hash;
			}
		}
	}

}
