using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TranscriptsFilters
	/// </summary>
	[DataContract]
	public partial class TranscriptsFilters : IEquatable<TranscriptsFilters>
	{
		/// <summary>
		/// The media type of the transcripts, default value is all 
		/// </summary>
		/// <value>The media type of the transcripts, default value is all </value>
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
			/// Enum Call for "call"
			/// </summary>
			[EnumMember(Value = "call")]
			Call,

			/// <summary>
			/// Enum Message for "message"
			/// </summary>
			[EnumMember(Value = "message")]
			Message,

			/// <summary>
			/// Enum Email for "email"
			/// </summary>
			[EnumMember(Value = "email")]
			Email,

			/// <summary>
			/// Enum Chat for "chat"
			/// </summary>
			[EnumMember(Value = "chat")]
			Chat,

			/// <summary>
			/// Enum Callback for "callback"
			/// </summary>
			[EnumMember(Value = "callback")]
			Callback,

			/// <summary>
			/// Enum All for "all"
			/// </summary>
			[EnumMember(Value = "all")]
			All
		}
		/// <summary>
		/// The media type of the transcripts, default value is all 
		/// </summary>
		/// <value>The media type of the transcripts, default value is all </value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public MediaTypeEnum? MediaType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TranscriptsFilters" /> class.
		/// </summary>
		/// <param name="MediaType">The media type of the transcripts, default value is all .</param>
		/// <param name="StartTimeMs">start time to filter by, default value is 7 days into the past.</param>
		/// <param name="EndTimeMs">end time to filter by, default value is current time.</param>
		/// <param name="Queues">list of queues ids to filter by.</param>
		/// <param name="Flows">list of flows ids to filter by.</param>
		public TranscriptsFilters(MediaTypeEnum? MediaType = null, long? StartTimeMs = null, long? EndTimeMs = null, List<string> Queues = null, List<string> Flows = null)
		{
			this.MediaType = MediaType;
			this.StartTimeMs = StartTimeMs;
			this.EndTimeMs = EndTimeMs;
			this.Queues = Queues;
			this.Flows = Flows;

		}





		/// <summary>
		/// start time to filter by, default value is 7 days into the past
		/// </summary>
		/// <value>start time to filter by, default value is 7 days into the past</value>
		[DataMember(Name = "startTimeMs", EmitDefaultValue = false)]
		public long? StartTimeMs { get; set; }



		/// <summary>
		/// end time to filter by, default value is current time
		/// </summary>
		/// <value>end time to filter by, default value is current time</value>
		[DataMember(Name = "endTimeMs", EmitDefaultValue = false)]
		public long? EndTimeMs { get; set; }



		/// <summary>
		/// list of queues ids to filter by
		/// </summary>
		/// <value>list of queues ids to filter by</value>
		[DataMember(Name = "queues", EmitDefaultValue = false)]
		public List<string> Queues { get; set; }



		/// <summary>
		/// list of flows ids to filter by
		/// </summary>
		/// <value>list of flows ids to filter by</value>
		[DataMember(Name = "flows", EmitDefaultValue = false)]
		public List<string> Flows { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TranscriptsFilters {\n");

			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
			sb.Append("  EndTimeMs: ").Append(EndTimeMs).Append("\n");
			sb.Append("  Queues: ").Append(Queues).Append("\n");
			sb.Append("  Flows: ").Append(Flows).Append("\n");
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
			return this.Equals(obj as TranscriptsFilters);
		}

		/// <summary>
		/// Returns true if TranscriptsFilters instances are equal
		/// </summary>
		/// <param name="other">Instance of TranscriptsFilters to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TranscriptsFilters other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.StartTimeMs == other.StartTimeMs ||
					this.StartTimeMs != null &&
					this.StartTimeMs.Equals(other.StartTimeMs)
				) &&
				(
					this.EndTimeMs == other.EndTimeMs ||
					this.EndTimeMs != null &&
					this.EndTimeMs.Equals(other.EndTimeMs)
				) &&
				(
					this.Queues == other.Queues ||
					this.Queues != null &&
					this.Queues.SequenceEqual(other.Queues)
				) &&
				(
					this.Flows == other.Flows ||
					this.Flows != null &&
					this.Flows.SequenceEqual(other.Flows)
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
				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.StartTimeMs != null)
					hash = hash * 59 + this.StartTimeMs.GetHashCode();

				if (this.EndTimeMs != null)
					hash = hash * 59 + this.EndTimeMs.GetHashCode();

				if (this.Queues != null)
					hash = hash * 59 + this.Queues.GetHashCode();

				if (this.Flows != null)
					hash = hash * 59 + this.Flows.GetHashCode();

				return hash;
			}
		}
	}

}
