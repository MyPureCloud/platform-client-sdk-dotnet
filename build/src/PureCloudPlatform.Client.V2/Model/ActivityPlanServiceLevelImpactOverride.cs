using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ActivityPlanServiceLevelImpactOverride
	/// </summary>
	[DataContract]
	public partial class ActivityPlanServiceLevelImpactOverride : IEquatable<ActivityPlanServiceLevelImpactOverride>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ActivityPlanServiceLevelImpactOverride" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ActivityPlanServiceLevelImpactOverride() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ActivityPlanServiceLevelImpactOverride" /> class.
		/// </summary>
		/// <param name="DecreaseByPercent">Allowed service level decrease percent, from 0.0 to 100.0 (required).</param>
		public ActivityPlanServiceLevelImpactOverride(double? DecreaseByPercent = null)
		{
			this.DecreaseByPercent = DecreaseByPercent;

		}



		/// <summary>
		/// Allowed service level decrease percent, from 0.0 to 100.0
		/// </summary>
		/// <value>Allowed service level decrease percent, from 0.0 to 100.0</value>
		[DataMember(Name = "decreaseByPercent", EmitDefaultValue = false)]
		public double? DecreaseByPercent { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ActivityPlanServiceLevelImpactOverride {\n");

			sb.Append("  DecreaseByPercent: ").Append(DecreaseByPercent).Append("\n");
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
			return this.Equals(obj as ActivityPlanServiceLevelImpactOverride);
		}

		/// <summary>
		/// Returns true if ActivityPlanServiceLevelImpactOverride instances are equal
		/// </summary>
		/// <param name="other">Instance of ActivityPlanServiceLevelImpactOverride to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ActivityPlanServiceLevelImpactOverride other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DecreaseByPercent == other.DecreaseByPercent ||
					this.DecreaseByPercent != null &&
					this.DecreaseByPercent.Equals(other.DecreaseByPercent)
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
				if (this.DecreaseByPercent != null)
					hash = hash * 59 + this.DecreaseByPercent.GetHashCode();

				return hash;
			}
		}
	}

}
