using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// StaffingGroupAllocationsResponseTemplate
	/// </summary>
	[DataContract]
	public partial class StaffingGroupAllocationsResponseTemplate : IEquatable<StaffingGroupAllocationsResponseTemplate>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="StaffingGroupAllocationsResponseTemplate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected StaffingGroupAllocationsResponseTemplate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="StaffingGroupAllocationsResponseTemplate" /> class.
		/// </summary>
		/// <param name="StaffingGroupAllocations">List of staffing group allocations (required).</param>
		public StaffingGroupAllocationsResponseTemplate(List<StaffingGroupAllocation> StaffingGroupAllocations = null)
		{
			this.StaffingGroupAllocations = StaffingGroupAllocations;

		}



		/// <summary>
		/// List of staffing group allocations
		/// </summary>
		/// <value>List of staffing group allocations</value>
		[DataMember(Name = "staffingGroupAllocations", EmitDefaultValue = false)]
		public List<StaffingGroupAllocation> StaffingGroupAllocations { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class StaffingGroupAllocationsResponseTemplate {\n");

			sb.Append("  StaffingGroupAllocations: ").Append(StaffingGroupAllocations).Append("\n");
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
			return this.Equals(obj as StaffingGroupAllocationsResponseTemplate);
		}

		/// <summary>
		/// Returns true if StaffingGroupAllocationsResponseTemplate instances are equal
		/// </summary>
		/// <param name="other">Instance of StaffingGroupAllocationsResponseTemplate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(StaffingGroupAllocationsResponseTemplate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StaffingGroupAllocations == other.StaffingGroupAllocations ||
					this.StaffingGroupAllocations != null &&
					this.StaffingGroupAllocations.SequenceEqual(other.StaffingGroupAllocations)
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
				if (this.StaffingGroupAllocations != null)
					hash = hash * 59 + this.StaffingGroupAllocations.GetHashCode();

				return hash;
			}
		}
	}

}
