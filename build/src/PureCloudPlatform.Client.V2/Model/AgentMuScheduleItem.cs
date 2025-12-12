using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentMuScheduleItem
	/// </summary>
	[DataContract]
	public partial class AgentMuScheduleItem : IEquatable<AgentMuScheduleItem>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentMuScheduleItem" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentMuScheduleItem() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentMuScheduleItem" /> class.
		/// </summary>
		/// <param name="Agent">The agent to whom this schedule applies. Note: selfUri will not be populated if retrieving result via downloadUrl (required).</param>
		/// <param name="Shifts">The shift definitions for this agent schedule (required).</param>
		/// <param name="FullDayTimeOffMarkerDates">The full day time off marker dates which apply to this agent schedule, interpreted in the time zone of the relevant business unit (required).</param>
		public AgentMuScheduleItem(UserReference Agent = null, List<AgentMuScheduleShift> Shifts = null, List<String> FullDayTimeOffMarkerDates = null)
		{
			this.Agent = Agent;
			this.Shifts = Shifts;
			this.FullDayTimeOffMarkerDates = FullDayTimeOffMarkerDates;

		}



		/// <summary>
		/// The agent to whom this schedule applies. Note: selfUri will not be populated if retrieving result via downloadUrl
		/// </summary>
		/// <value>The agent to whom this schedule applies. Note: selfUri will not be populated if retrieving result via downloadUrl</value>
		[DataMember(Name = "agent", EmitDefaultValue = false)]
		public UserReference Agent { get; set; }



		/// <summary>
		/// The shift definitions for this agent schedule
		/// </summary>
		/// <value>The shift definitions for this agent schedule</value>
		[DataMember(Name = "shifts", EmitDefaultValue = false)]
		public List<AgentMuScheduleShift> Shifts { get; set; }



		/// <summary>
		/// The full day time off marker dates which apply to this agent schedule, interpreted in the time zone of the relevant business unit
		/// </summary>
		/// <value>The full day time off marker dates which apply to this agent schedule, interpreted in the time zone of the relevant business unit</value>
		[DataMember(Name = "fullDayTimeOffMarkerDates", EmitDefaultValue = false)]
		public List<String> FullDayTimeOffMarkerDates { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AgentMuScheduleItem {\n");

			sb.Append("  Agent: ").Append(Agent).Append("\n");
			sb.Append("  Shifts: ").Append(Shifts).Append("\n");
			sb.Append("  FullDayTimeOffMarkerDates: ").Append(FullDayTimeOffMarkerDates).Append("\n");
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
			return this.Equals(obj as AgentMuScheduleItem);
		}

		/// <summary>
		/// Returns true if AgentMuScheduleItem instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentMuScheduleItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentMuScheduleItem other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Agent == other.Agent ||
					this.Agent != null &&
					this.Agent.Equals(other.Agent)
				) &&
				(
					this.Shifts == other.Shifts ||
					this.Shifts != null &&
					this.Shifts.SequenceEqual(other.Shifts)
				) &&
				(
					this.FullDayTimeOffMarkerDates == other.FullDayTimeOffMarkerDates ||
					this.FullDayTimeOffMarkerDates != null &&
					this.FullDayTimeOffMarkerDates.SequenceEqual(other.FullDayTimeOffMarkerDates)
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
				if (this.Agent != null)
					hash = hash * 59 + this.Agent.GetHashCode();

				if (this.Shifts != null)
					hash = hash * 59 + this.Shifts.GetHashCode();

				if (this.FullDayTimeOffMarkerDates != null)
					hash = hash * 59 + this.FullDayTimeOffMarkerDates.GetHashCode();

				return hash;
			}
		}
	}

}
