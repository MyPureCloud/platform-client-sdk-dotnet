using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AgentWorkPlanBids
	/// </summary>
	[DataContract]
	public partial class AgentWorkPlanBids : IEquatable<AgentWorkPlanBids>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AgentWorkPlanBids" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AgentWorkPlanBids() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AgentWorkPlanBids" /> class.
		/// </summary>
		/// <param name="BusinessUnit">The business unit to which the bids belong.</param>
		/// <param name="_AgentWorkPlanBids">Work plan bid summaries associated with this agent (required).</param>
		public AgentWorkPlanBids(BusinessUnitReference BusinessUnit = null, List<AgentWorkPlanBid> _AgentWorkPlanBids = null)
		{
			this.BusinessUnit = BusinessUnit;
			this._AgentWorkPlanBids = _AgentWorkPlanBids;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The business unit to which the bids belong
		/// </summary>
		/// <value>The business unit to which the bids belong</value>
		[DataMember(Name = "businessUnit", EmitDefaultValue = false)]
		public BusinessUnitReference BusinessUnit { get; set; }



		/// <summary>
		/// Work plan bid summaries associated with this agent
		/// </summary>
		/// <value>Work plan bid summaries associated with this agent</value>
		[DataMember(Name = "agentWorkPlanBids", EmitDefaultValue = false)]
		public List<AgentWorkPlanBid> _AgentWorkPlanBids { get; set; }



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
			sb.Append("class AgentWorkPlanBids {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
			sb.Append("  _AgentWorkPlanBids: ").Append(_AgentWorkPlanBids).Append("\n");
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
			return this.Equals(obj as AgentWorkPlanBids);
		}

		/// <summary>
		/// Returns true if AgentWorkPlanBids instances are equal
		/// </summary>
		/// <param name="other">Instance of AgentWorkPlanBids to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AgentWorkPlanBids other)
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
					this.BusinessUnit == other.BusinessUnit ||
					this.BusinessUnit != null &&
					this.BusinessUnit.Equals(other.BusinessUnit)
				) &&
				(
					this._AgentWorkPlanBids == other._AgentWorkPlanBids ||
					this._AgentWorkPlanBids != null &&
					this._AgentWorkPlanBids.SequenceEqual(other._AgentWorkPlanBids)
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

				if (this.BusinessUnit != null)
					hash = hash * 59 + this.BusinessUnit.GetHashCode();

				if (this._AgentWorkPlanBids != null)
					hash = hash * 59 + this._AgentWorkPlanBids.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
