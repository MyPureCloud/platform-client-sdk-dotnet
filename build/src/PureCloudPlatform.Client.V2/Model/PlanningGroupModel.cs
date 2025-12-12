using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PlanningGroupModel
	/// </summary>
	[DataContract]
	public partial class PlanningGroupModel : IEquatable<PlanningGroupModel>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PlanningGroupModel" /> class.
		/// </summary>
		/// <param name="PlanningGroup">Planning group id.</param>
		public PlanningGroupModel(string PlanningGroup = null)
		{
			this.PlanningGroup = PlanningGroup;

		}



		/// <summary>
		/// Planning group id
		/// </summary>
		/// <value>Planning group id</value>
		[DataMember(Name = "planningGroup", EmitDefaultValue = false)]
		public string PlanningGroup { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PlanningGroupModel {\n");

			sb.Append("  PlanningGroup: ").Append(PlanningGroup).Append("\n");
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
			return this.Equals(obj as PlanningGroupModel);
		}

		/// <summary>
		/// Returns true if PlanningGroupModel instances are equal
		/// </summary>
		/// <param name="other">Instance of PlanningGroupModel to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PlanningGroupModel other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PlanningGroup == other.PlanningGroup ||
					this.PlanningGroup != null &&
					this.PlanningGroup.Equals(other.PlanningGroup)
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
				if (this.PlanningGroup != null)
					hash = hash * 59 + this.PlanningGroup.GetHashCode();

				return hash;
			}
		}
	}

}
