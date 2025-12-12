using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkPlanOverrideListWrapperWorkPlanOverrideRequest
	/// </summary>
	[DataContract]
	public partial class WorkPlanOverrideListWrapperWorkPlanOverrideRequest : IEquatable<WorkPlanOverrideListWrapperWorkPlanOverrideRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanOverrideListWrapperWorkPlanOverrideRequest" /> class.
		/// </summary>
		/// <param name="Values">Values.</param>
		/// <param name="DeleteAll">if true, should delete all existing overrides for the agent and update the given overrides.</param>
		public WorkPlanOverrideListWrapperWorkPlanOverrideRequest(List<WorkPlanOverrideRequest> Values = null, bool? DeleteAll = null)
		{
			this.Values = Values;
			this.DeleteAll = DeleteAll;

		}



		/// <summary>
		/// Gets or Sets Values
		/// </summary>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<WorkPlanOverrideRequest> Values { get; set; }



		/// <summary>
		/// if true, should delete all existing overrides for the agent and update the given overrides
		/// </summary>
		/// <value>if true, should delete all existing overrides for the agent and update the given overrides</value>
		[DataMember(Name = "deleteAll", EmitDefaultValue = false)]
		public bool? DeleteAll { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkPlanOverrideListWrapperWorkPlanOverrideRequest {\n");

			sb.Append("  Values: ").Append(Values).Append("\n");
			sb.Append("  DeleteAll: ").Append(DeleteAll).Append("\n");
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
			return this.Equals(obj as WorkPlanOverrideListWrapperWorkPlanOverrideRequest);
		}

		/// <summary>
		/// Returns true if WorkPlanOverrideListWrapperWorkPlanOverrideRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkPlanOverrideListWrapperWorkPlanOverrideRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkPlanOverrideListWrapperWorkPlanOverrideRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Values == other.Values ||
					this.Values != null &&
					this.Values.SequenceEqual(other.Values)
				) &&
				(
					this.DeleteAll == other.DeleteAll ||
					this.DeleteAll != null &&
					this.DeleteAll.Equals(other.DeleteAll)
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
				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				if (this.DeleteAll != null)
					hash = hash * 59 + this.DeleteAll.GetHashCode();

				return hash;
			}
		}
	}

}
