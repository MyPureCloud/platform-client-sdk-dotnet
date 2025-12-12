using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateWorkPlanRotationRequest
	/// </summary>
	[DataContract]
	public partial class UpdateWorkPlanRotationRequest : IEquatable<UpdateWorkPlanRotationRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateWorkPlanRotationRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateWorkPlanRotationRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateWorkPlanRotationRequest" /> class.
		/// </summary>
		/// <param name="Name">Name of this work plan rotation.</param>
		/// <param name="Enabled">Whether the work plan rotation is enabled for scheduling.</param>
		/// <param name="DateRange">The date range to which this work plan rotation applies.</param>
		/// <param name="Agents">Agents in this work plan rotation.</param>
		/// <param name="Pattern">Pattern with list of work plan IDs that rotate on a weekly basis.</param>
		/// <param name="Metadata">Version metadata for this work plan rotation (required).</param>
		public UpdateWorkPlanRotationRequest(string Name = null, bool? Enabled = null, DateRangeWithOptionalEnd DateRange = null, List<UpdateWorkPlanRotationAgentRequest> Agents = null, WorkPlanPatternRequest Pattern = null, WfmVersionedEntityMetadata Metadata = null)
		{
			this.Name = Name;
			this.Enabled = Enabled;
			this.DateRange = DateRange;
			this.Agents = Agents;
			this.Pattern = Pattern;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// Name of this work plan rotation
		/// </summary>
		/// <value>Name of this work plan rotation</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Whether the work plan rotation is enabled for scheduling
		/// </summary>
		/// <value>Whether the work plan rotation is enabled for scheduling</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// The date range to which this work plan rotation applies
		/// </summary>
		/// <value>The date range to which this work plan rotation applies</value>
		[DataMember(Name = "dateRange", EmitDefaultValue = false)]
		public DateRangeWithOptionalEnd DateRange { get; set; }



		/// <summary>
		/// Agents in this work plan rotation
		/// </summary>
		/// <value>Agents in this work plan rotation</value>
		[DataMember(Name = "agents", EmitDefaultValue = false)]
		public List<UpdateWorkPlanRotationAgentRequest> Agents { get; set; }



		/// <summary>
		/// Pattern with list of work plan IDs that rotate on a weekly basis
		/// </summary>
		/// <value>Pattern with list of work plan IDs that rotate on a weekly basis</value>
		[DataMember(Name = "pattern", EmitDefaultValue = false)]
		public WorkPlanPatternRequest Pattern { get; set; }



		/// <summary>
		/// Version metadata for this work plan rotation
		/// </summary>
		/// <value>Version metadata for this work plan rotation</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateWorkPlanRotationRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  DateRange: ").Append(DateRange).Append("\n");
			sb.Append("  Agents: ").Append(Agents).Append("\n");
			sb.Append("  Pattern: ").Append(Pattern).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
			return this.Equals(obj as UpdateWorkPlanRotationRequest);
		}

		/// <summary>
		/// Returns true if UpdateWorkPlanRotationRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateWorkPlanRotationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateWorkPlanRotationRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.DateRange == other.DateRange ||
					this.DateRange != null &&
					this.DateRange.Equals(other.DateRange)
				) &&
				(
					this.Agents == other.Agents ||
					this.Agents != null &&
					this.Agents.SequenceEqual(other.Agents)
				) &&
				(
					this.Pattern == other.Pattern ||
					this.Pattern != null &&
					this.Pattern.Equals(other.Pattern)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.DateRange != null)
					hash = hash * 59 + this.DateRange.GetHashCode();

				if (this.Agents != null)
					hash = hash * 59 + this.Agents.GetHashCode();

				if (this.Pattern != null)
					hash = hash * 59 + this.Pattern.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				return hash;
			}
		}
	}

}
