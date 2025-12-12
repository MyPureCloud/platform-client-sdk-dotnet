using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RequestJourneyPattern
	/// </summary>
	[DataContract]
	public partial class RequestJourneyPattern : IEquatable<RequestJourneyPattern>
	{
		/// <summary>
		/// The stream type for which this pattern can be matched on.
		/// </summary>
		/// <value>The stream type for which this pattern can be matched on.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StreamTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Web for "Web"
			/// </summary>
			[EnumMember(Value = "Web")]
			Web,

			/// <summary>
			/// Enum Custom for "Custom"
			/// </summary>
			[EnumMember(Value = "Custom")]
			Custom,

			/// <summary>
			/// Enum Conversation for "Conversation"
			/// </summary>
			[EnumMember(Value = "Conversation")]
			Conversation,

			/// <summary>
			/// Enum App for "App"
			/// </summary>
			[EnumMember(Value = "App")]
			App
		}
		/// <summary>
		/// The stream type for which this pattern can be matched on.
		/// </summary>
		/// <value>The stream type for which this pattern can be matched on.</value>
		[DataMember(Name = "streamType", EmitDefaultValue = false)]
		public StreamTypeEnum? StreamType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="RequestJourneyPattern" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected RequestJourneyPattern() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="RequestJourneyPattern" /> class.
		/// </summary>
		/// <param name="Criteria">A list of one or more criteria to satisfy. (required).</param>
		/// <param name="Count">The number of times the pattern must match. (required).</param>
		/// <param name="StreamType">The stream type for which this pattern can be matched on. (required).</param>
		/// <param name="SessionType">The session type for which this pattern can be matched on. (required).</param>
		/// <param name="EventName">The name of the event for which this pattern can be matched on..</param>
		public RequestJourneyPattern(List<RequestCriteria> Criteria = null, int? Count = null, StreamTypeEnum? StreamType = null, string SessionType = null, string EventName = null)
		{
			this.Criteria = Criteria;
			this.Count = Count;
			this.StreamType = StreamType;
			this.SessionType = SessionType;
			this.EventName = EventName;

		}



		/// <summary>
		/// A list of one or more criteria to satisfy.
		/// </summary>
		/// <value>A list of one or more criteria to satisfy.</value>
		[DataMember(Name = "criteria", EmitDefaultValue = false)]
		public List<RequestCriteria> Criteria { get; set; }



		/// <summary>
		/// The number of times the pattern must match.
		/// </summary>
		/// <value>The number of times the pattern must match.</value>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public int? Count { get; set; }





		/// <summary>
		/// The session type for which this pattern can be matched on.
		/// </summary>
		/// <value>The session type for which this pattern can be matched on.</value>
		[DataMember(Name = "sessionType", EmitDefaultValue = false)]
		public string SessionType { get; set; }



		/// <summary>
		/// The name of the event for which this pattern can be matched on.
		/// </summary>
		/// <value>The name of the event for which this pattern can be matched on.</value>
		[DataMember(Name = "eventName", EmitDefaultValue = false)]
		public string EventName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RequestJourneyPattern {\n");

			sb.Append("  Criteria: ").Append(Criteria).Append("\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  StreamType: ").Append(StreamType).Append("\n");
			sb.Append("  SessionType: ").Append(SessionType).Append("\n");
			sb.Append("  EventName: ").Append(EventName).Append("\n");
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
			return this.Equals(obj as RequestJourneyPattern);
		}

		/// <summary>
		/// Returns true if RequestJourneyPattern instances are equal
		/// </summary>
		/// <param name="other">Instance of RequestJourneyPattern to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RequestJourneyPattern other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Criteria == other.Criteria ||
					this.Criteria != null &&
					this.Criteria.SequenceEqual(other.Criteria)
				) &&
				(
					this.Count == other.Count ||
					this.Count != null &&
					this.Count.Equals(other.Count)
				) &&
				(
					this.StreamType == other.StreamType ||
					this.StreamType != null &&
					this.StreamType.Equals(other.StreamType)
				) &&
				(
					this.SessionType == other.SessionType ||
					this.SessionType != null &&
					this.SessionType.Equals(other.SessionType)
				) &&
				(
					this.EventName == other.EventName ||
					this.EventName != null &&
					this.EventName.Equals(other.EventName)
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
				if (this.Criteria != null)
					hash = hash * 59 + this.Criteria.GetHashCode();

				if (this.Count != null)
					hash = hash * 59 + this.Count.GetHashCode();

				if (this.StreamType != null)
					hash = hash * 59 + this.StreamType.GetHashCode();

				if (this.SessionType != null)
					hash = hash * 59 + this.SessionType.GetHashCode();

				if (this.EventName != null)
					hash = hash * 59 + this.EventName.GetHashCode();

				return hash;
			}
		}
	}

}
