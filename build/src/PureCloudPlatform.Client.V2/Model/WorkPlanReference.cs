using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkPlanReference
	/// </summary>
	[DataContract]
	public partial class WorkPlanReference : IEquatable<WorkPlanReference>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanReference" /> class.
		/// </summary>
		/// <param name="ManagementUnit">The management unit to which this work plan belongs.  Nullable in some routes.</param>
		public WorkPlanReference(ManagementUnitReference ManagementUnit = null)
		{
			this.ManagementUnit = ManagementUnit;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The management unit to which this work plan belongs.  Nullable in some routes
		/// </summary>
		/// <value>The management unit to which this work plan belongs.  Nullable in some routes</value>
		[DataMember(Name = "managementUnit", EmitDefaultValue = false)]
		public ManagementUnitReference ManagementUnit { get; set; }



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
			sb.Append("class WorkPlanReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
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
			return this.Equals(obj as WorkPlanReference);
		}

		/// <summary>
		/// Returns true if WorkPlanReference instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkPlanReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkPlanReference other)
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
					this.ManagementUnit == other.ManagementUnit ||
					this.ManagementUnit != null &&
					this.ManagementUnit.Equals(other.ManagementUnit)
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

				if (this.ManagementUnit != null)
					hash = hash * 59 + this.ManagementUnit.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
