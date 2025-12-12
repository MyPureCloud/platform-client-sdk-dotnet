using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// StaffingGroupResponse
	/// </summary>
	[DataContract]
	public partial class StaffingGroupResponse : IEquatable<StaffingGroupResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="StaffingGroupResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected StaffingGroupResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="StaffingGroupResponse" /> class.
		/// </summary>
		/// <param name="Name">The name of the staffing group (required).</param>
		/// <param name="Users">The list of users that belong to the staffing group.</param>
		/// <param name="ManagementUnit">The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit.</param>
		/// <param name="PlanningGroups">The list of planning groups that are associated with the staffing group.</param>
		/// <param name="Metadata">Version metadata for the staffing group (required).</param>
		public StaffingGroupResponse(string Name = null, List<UserReference> Users = null, ManagementUnitReference ManagementUnit = null, List<PlanningGroupReference> PlanningGroups = null, WfmVersionedEntityMetadata Metadata = null)
		{
			this.Name = Name;
			this.Users = Users;
			this.ManagementUnit = ManagementUnit;
			this.PlanningGroups = PlanningGroups;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the staffing group
		/// </summary>
		/// <value>The name of the staffing group</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The list of users that belong to the staffing group
		/// </summary>
		/// <value>The list of users that belong to the staffing group</value>
		[DataMember(Name = "users", EmitDefaultValue = false)]
		public List<UserReference> Users { get; set; }



		/// <summary>
		/// The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit
		/// </summary>
		/// <value>The ID of the management unit to which the staffing group users belong. If undefined the staffing group can include users from the entire business unit</value>
		[DataMember(Name = "managementUnit", EmitDefaultValue = false)]
		public ManagementUnitReference ManagementUnit { get; set; }



		/// <summary>
		/// The list of planning groups that are associated with the staffing group
		/// </summary>
		/// <value>The list of planning groups that are associated with the staffing group</value>
		[DataMember(Name = "planningGroups", EmitDefaultValue = false)]
		public List<PlanningGroupReference> PlanningGroups { get; set; }



		/// <summary>
		/// Version metadata for the staffing group
		/// </summary>
		/// <value>Version metadata for the staffing group</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }



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
			sb.Append("class StaffingGroupResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Users: ").Append(Users).Append("\n");
			sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
			sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
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
			return this.Equals(obj as StaffingGroupResponse);
		}

		/// <summary>
		/// Returns true if StaffingGroupResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of StaffingGroupResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(StaffingGroupResponse other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Users == other.Users ||
					this.Users != null &&
					this.Users.SequenceEqual(other.Users)
				) &&
				(
					this.ManagementUnit == other.ManagementUnit ||
					this.ManagementUnit != null &&
					this.ManagementUnit.Equals(other.ManagementUnit)
				) &&
				(
					this.PlanningGroups == other.PlanningGroups ||
					this.PlanningGroups != null &&
					this.PlanningGroups.SequenceEqual(other.PlanningGroups)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Users != null)
					hash = hash * 59 + this.Users.GetHashCode();

				if (this.ManagementUnit != null)
					hash = hash * 59 + this.ManagementUnit.GetHashCode();

				if (this.PlanningGroups != null)
					hash = hash * 59 + this.PlanningGroups.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
