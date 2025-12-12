using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateStaffingGroupRequest
	/// </summary>
	[DataContract]
	public partial class UpdateStaffingGroupRequest : IEquatable<UpdateStaffingGroupRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateStaffingGroupRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateStaffingGroupRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateStaffingGroupRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the staffing group.</param>
		/// <param name="UserIds">The set of user Ids to associate with the staffing group.</param>
		/// <param name="PlanningGroupIds">The set of planning group Ids to associate with the staffing group.</param>
		/// <param name="Metadata">Version metadata for the staffing group (required).</param>
		public UpdateStaffingGroupRequest(string Name = null, SetWrapperString UserIds = null, SetWrapperString PlanningGroupIds = null, WfmVersionedEntityMetadata Metadata = null)
		{
			this.Name = Name;
			this.UserIds = UserIds;
			this.PlanningGroupIds = PlanningGroupIds;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// The name of the staffing group
		/// </summary>
		/// <value>The name of the staffing group</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The set of user Ids to associate with the staffing group
		/// </summary>
		/// <value>The set of user Ids to associate with the staffing group</value>
		[DataMember(Name = "userIds", EmitDefaultValue = false)]
		public SetWrapperString UserIds { get; set; }



		/// <summary>
		/// The set of planning group Ids to associate with the staffing group
		/// </summary>
		/// <value>The set of planning group Ids to associate with the staffing group</value>
		[DataMember(Name = "planningGroupIds", EmitDefaultValue = false)]
		public SetWrapperString PlanningGroupIds { get; set; }



		/// <summary>
		/// Version metadata for the staffing group
		/// </summary>
		/// <value>Version metadata for the staffing group</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateStaffingGroupRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  UserIds: ").Append(UserIds).Append("\n");
			sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
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
			return this.Equals(obj as UpdateStaffingGroupRequest);
		}

		/// <summary>
		/// Returns true if UpdateStaffingGroupRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateStaffingGroupRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateStaffingGroupRequest other)
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
					this.UserIds == other.UserIds ||
					this.UserIds != null &&
					this.UserIds.Equals(other.UserIds)
				) &&
				(
					this.PlanningGroupIds == other.PlanningGroupIds ||
					this.PlanningGroupIds != null &&
					this.PlanningGroupIds.Equals(other.PlanningGroupIds)
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

				if (this.UserIds != null)
					hash = hash * 59 + this.UserIds.GetHashCode();

				if (this.PlanningGroupIds != null)
					hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				return hash;
			}
		}
	}

}
