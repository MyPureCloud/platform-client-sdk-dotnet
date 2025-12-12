using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AfterCallWork
	/// </summary>
	[DataContract]
	public partial class AfterCallWork : IEquatable<AfterCallWork>
	{
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Notapplicable for "notApplicable"
			/// </summary>
			[EnumMember(Value = "notApplicable")]
			Notapplicable,

			/// <summary>
			/// Enum Skipped for "skipped"
			/// </summary>
			[EnumMember(Value = "skipped")]
			Skipped,

			/// <summary>
			/// Enum Pending for "pending"
			/// </summary>
			[EnumMember(Value = "pending")]
			Pending,

			/// <summary>
			/// Enum Complete for "complete"
			/// </summary>
			[EnumMember(Value = "complete")]
			Complete
		}
		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="AfterCallWork" /> class.
		/// </summary>
		/// <param name="StartTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="EndTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="State">State.</param>
		public AfterCallWork(DateTime? StartTime = null, DateTime? EndTime = null, StateEnum? State = null)
		{
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.State = State;

		}



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "startTime", EmitDefaultValue = false)]
		public DateTime? StartTime { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public DateTime? EndTime { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AfterCallWork {\n");

			sb.Append("  StartTime: ").Append(StartTime).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
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
			return this.Equals(obj as AfterCallWork);
		}

		/// <summary>
		/// Returns true if AfterCallWork instances are equal
		/// </summary>
		/// <param name="other">Instance of AfterCallWork to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AfterCallWork other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartTime == other.StartTime ||
					this.StartTime != null &&
					this.StartTime.Equals(other.StartTime)
				) &&
				(
					this.EndTime == other.EndTime ||
					this.EndTime != null &&
					this.EndTime.Equals(other.EndTime)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
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
				if (this.StartTime != null)
					hash = hash * 59 + this.StartTime.GetHashCode();

				if (this.EndTime != null)
					hash = hash * 59 + this.EndTime.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				return hash;
			}
		}
	}

}
