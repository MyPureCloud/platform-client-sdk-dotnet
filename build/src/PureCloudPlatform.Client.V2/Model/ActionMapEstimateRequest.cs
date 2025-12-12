using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ActionMapEstimateRequest
	/// </summary>
	[DataContract]
	public partial class ActionMapEstimateRequest : IEquatable<ActionMapEstimateRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ActionMapEstimateRequest" /> class.
		/// </summary>
		/// <param name="SegmentIds">List of Segment IDs..</param>
		/// <param name="OutcomeCriteria">Outcome Criteria containing outcomeId and probability thresholds..</param>
		public ActionMapEstimateRequest(List<string> SegmentIds = null, ActionMapEstimateOutcomeCriteria OutcomeCriteria = null)
		{
			this.SegmentIds = SegmentIds;
			this.OutcomeCriteria = OutcomeCriteria;

		}



		/// <summary>
		/// List of Segment IDs.
		/// </summary>
		/// <value>List of Segment IDs.</value>
		[DataMember(Name = "segmentIds", EmitDefaultValue = false)]
		public List<string> SegmentIds { get; set; }



		/// <summary>
		/// Outcome Criteria containing outcomeId and probability thresholds.
		/// </summary>
		/// <value>Outcome Criteria containing outcomeId and probability thresholds.</value>
		[DataMember(Name = "outcomeCriteria", EmitDefaultValue = false)]
		public ActionMapEstimateOutcomeCriteria OutcomeCriteria { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ActionMapEstimateRequest {\n");

			sb.Append("  SegmentIds: ").Append(SegmentIds).Append("\n");
			sb.Append("  OutcomeCriteria: ").Append(OutcomeCriteria).Append("\n");
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
			return this.Equals(obj as ActionMapEstimateRequest);
		}

		/// <summary>
		/// Returns true if ActionMapEstimateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ActionMapEstimateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ActionMapEstimateRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SegmentIds == other.SegmentIds ||
					this.SegmentIds != null &&
					this.SegmentIds.SequenceEqual(other.SegmentIds)
				) &&
				(
					this.OutcomeCriteria == other.OutcomeCriteria ||
					this.OutcomeCriteria != null &&
					this.OutcomeCriteria.Equals(other.OutcomeCriteria)
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
				if (this.SegmentIds != null)
					hash = hash * 59 + this.SegmentIds.GetHashCode();

				if (this.OutcomeCriteria != null)
					hash = hash * 59 + this.OutcomeCriteria.GetHashCode();

				return hash;
			}
		}
	}

}
