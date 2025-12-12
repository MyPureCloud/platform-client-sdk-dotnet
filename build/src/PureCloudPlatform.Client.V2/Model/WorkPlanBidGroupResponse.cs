using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkPlanBidGroupResponse
	/// </summary>
	[DataContract]
	public partial class WorkPlanBidGroupResponse : IEquatable<WorkPlanBidGroupResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanBidGroupResponse" /> class.
		/// </summary>
		/// <param name="WorkPlanBidGroup">The work plan bid group.</param>
		/// <param name="Metadata">The meta data of the bid group.</param>
		public WorkPlanBidGroupResponse(WorkPlanBidGroup WorkPlanBidGroup = null, WorkPlanBidMetadata Metadata = null)
		{
			this.WorkPlanBidGroup = WorkPlanBidGroup;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The work plan bid group
		/// </summary>
		/// <value>The work plan bid group</value>
		[DataMember(Name = "workPlanBidGroup", EmitDefaultValue = false)]
		public WorkPlanBidGroup WorkPlanBidGroup { get; set; }



		/// <summary>
		/// The meta data of the bid group
		/// </summary>
		/// <value>The meta data of the bid group</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WorkPlanBidMetadata Metadata { get; set; }



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
			sb.Append("class WorkPlanBidGroupResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  WorkPlanBidGroup: ").Append(WorkPlanBidGroup).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
			return this.Equals(obj as WorkPlanBidGroupResponse);
		}

		/// <summary>
		/// Returns true if WorkPlanBidGroupResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkPlanBidGroupResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkPlanBidGroupResponse other)
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
					this.WorkPlanBidGroup == other.WorkPlanBidGroup ||
					this.WorkPlanBidGroup != null &&
					this.WorkPlanBidGroup.Equals(other.WorkPlanBidGroup)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
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

				if (this.WorkPlanBidGroup != null)
					hash = hash * 59 + this.WorkPlanBidGroup.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
