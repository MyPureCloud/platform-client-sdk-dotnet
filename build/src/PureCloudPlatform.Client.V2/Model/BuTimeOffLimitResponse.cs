using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuTimeOffLimitResponse
	/// </summary>
	[DataContract]
	public partial class BuTimeOffLimitResponse : IEquatable<BuTimeOffLimitResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BuTimeOffLimitResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuTimeOffLimitResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuTimeOffLimitResponse" /> class.
		/// </summary>
		/// <param name="StaffingGroup">The staffing group to which this time-off limit is associated. If managementUnit is set, then the staffing group belongs to that management unit.Otherwise, if managementUnit is not set, it is a business unit level staffing group.At least one of managementUnit and staffingGroup must be set.</param>
		/// <param name="ManagementUnit">The management unit to which this time-off limit is associated. If staffingGroup is set, then the limit is associated with that staffing group, which belongs to this management unit.At least one of managementUnit and staffingGroup must be set.</param>
		/// <param name="Metadata">Version metadata for the time-off limit (required).</param>
		public BuTimeOffLimitResponse(StaffingGroupReference StaffingGroup = null, ManagementUnitReference ManagementUnit = null, WfmVersionedEntityMetadata Metadata = null)
		{
			this.StaffingGroup = StaffingGroup;
			this.ManagementUnit = ManagementUnit;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The staffing group to which this time-off limit is associated. If managementUnit is set, then the staffing group belongs to that management unit.Otherwise, if managementUnit is not set, it is a business unit level staffing group.At least one of managementUnit and staffingGroup must be set
		/// </summary>
		/// <value>The staffing group to which this time-off limit is associated. If managementUnit is set, then the staffing group belongs to that management unit.Otherwise, if managementUnit is not set, it is a business unit level staffing group.At least one of managementUnit and staffingGroup must be set</value>
		[DataMember(Name = "staffingGroup", EmitDefaultValue = false)]
		public StaffingGroupReference StaffingGroup { get; set; }



		/// <summary>
		/// The management unit to which this time-off limit is associated. If staffingGroup is set, then the limit is associated with that staffing group, which belongs to this management unit.At least one of managementUnit and staffingGroup must be set
		/// </summary>
		/// <value>The management unit to which this time-off limit is associated. If staffingGroup is set, then the limit is associated with that staffing group, which belongs to this management unit.At least one of managementUnit and staffingGroup must be set</value>
		[DataMember(Name = "managementUnit", EmitDefaultValue = false)]
		public ManagementUnitReference ManagementUnit { get; set; }



		/// <summary>
		/// Version metadata for the time-off limit
		/// </summary>
		/// <value>Version metadata for the time-off limit</value>
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
			sb.Append("class BuTimeOffLimitResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  StaffingGroup: ").Append(StaffingGroup).Append("\n");
			sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
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
			return this.Equals(obj as BuTimeOffLimitResponse);
		}

		/// <summary>
		/// Returns true if BuTimeOffLimitResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of BuTimeOffLimitResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuTimeOffLimitResponse other)
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
					this.StaffingGroup == other.StaffingGroup ||
					this.StaffingGroup != null &&
					this.StaffingGroup.Equals(other.StaffingGroup)
				) &&
				(
					this.ManagementUnit == other.ManagementUnit ||
					this.ManagementUnit != null &&
					this.ManagementUnit.Equals(other.ManagementUnit)
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

				if (this.StaffingGroup != null)
					hash = hash * 59 + this.StaffingGroup.GetHashCode();

				if (this.ManagementUnit != null)
					hash = hash * 59 + this.ManagementUnit.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
