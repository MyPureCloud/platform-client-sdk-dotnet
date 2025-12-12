using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate
	/// </summary>
	[DataContract]
	public partial class WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate : IEquatable<WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate>
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
			/// Enum Added for "Added"
			/// </summary>
			[EnumMember(Value = "Added")]
			Added,

			/// <summary>
			/// Enum Edited for "Edited"
			/// </summary>
			[EnumMember(Value = "Edited")]
			Edited,

			/// <summary>
			/// Enum Deleted for "Deleted"
			/// </summary>
			[EnumMember(Value = "Deleted")]
			Deleted
		}
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="ShiftStartDates">ShiftStartDates.</param>
		public WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate(TypeEnum? Type = null, List<DateTime?> ShiftStartDates = null)
		{
			this.Type = Type;
			this.ShiftStartDates = ShiftStartDates;

		}





		/// <summary>
		/// Gets or Sets ShiftStartDates
		/// </summary>
		[DataMember(Name = "shiftStartDates", EmitDefaultValue = false)]
		public List<DateTime?> ShiftStartDates { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  ShiftStartDates: ").Append(ShiftStartDates).Append("\n");
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
			return this.Equals(obj as WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate);
		}

		/// <summary>
		/// Returns true if WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate instances are equal
		/// </summary>
		/// <param name="other">Instance of WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WfmAgentScheduleUpdateTopicAgentScheduleShiftUpdate other)
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
					this.ShiftStartDates == other.ShiftStartDates ||
					this.ShiftStartDates != null &&
					this.ShiftStartDates.SequenceEqual(other.ShiftStartDates)
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

				if (this.ShiftStartDates != null)
					hash = hash * 59 + this.ShiftStartDates.GetHashCode();

				return hash;
			}
		}
	}

}
