using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PredictorWorkloadBalancing
	/// </summary>
	[DataContract]
	public partial class PredictorWorkloadBalancing : IEquatable<PredictorWorkloadBalancing>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="PredictorWorkloadBalancing" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PredictorWorkloadBalancing() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PredictorWorkloadBalancing" /> class.
		/// </summary>
		/// <param name="Enabled">Flag to activate and deactivate workload balancing. (required).</param>
		/// <param name="MinimumOccupancy">Desired minimum occupancy threshold of agents. Must be between 0 and 100..</param>
		/// <param name="MaximumOccupancy">Desired maximum occupancy threshold of agents. Must be between 0 and 100..</param>
		public PredictorWorkloadBalancing(bool? Enabled = null, int? MinimumOccupancy = null, int? MaximumOccupancy = null)
		{
			this.Enabled = Enabled;
			this.MinimumOccupancy = MinimumOccupancy;
			this.MaximumOccupancy = MaximumOccupancy;

		}



		/// <summary>
		/// Flag to activate and deactivate workload balancing.
		/// </summary>
		/// <value>Flag to activate and deactivate workload balancing.</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// Desired minimum occupancy threshold of agents. Must be between 0 and 100.
		/// </summary>
		/// <value>Desired minimum occupancy threshold of agents. Must be between 0 and 100.</value>
		[DataMember(Name = "minimumOccupancy", EmitDefaultValue = false)]
		public int? MinimumOccupancy { get; set; }



		/// <summary>
		/// Desired maximum occupancy threshold of agents. Must be between 0 and 100.
		/// </summary>
		/// <value>Desired maximum occupancy threshold of agents. Must be between 0 and 100.</value>
		[DataMember(Name = "maximumOccupancy", EmitDefaultValue = false)]
		public int? MaximumOccupancy { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PredictorWorkloadBalancing {\n");

			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  MinimumOccupancy: ").Append(MinimumOccupancy).Append("\n");
			sb.Append("  MaximumOccupancy: ").Append(MaximumOccupancy).Append("\n");
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
			return this.Equals(obj as PredictorWorkloadBalancing);
		}

		/// <summary>
		/// Returns true if PredictorWorkloadBalancing instances are equal
		/// </summary>
		/// <param name="other">Instance of PredictorWorkloadBalancing to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PredictorWorkloadBalancing other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.MinimumOccupancy == other.MinimumOccupancy ||
					this.MinimumOccupancy != null &&
					this.MinimumOccupancy.Equals(other.MinimumOccupancy)
				) &&
				(
					this.MaximumOccupancy == other.MaximumOccupancy ||
					this.MaximumOccupancy != null &&
					this.MaximumOccupancy.Equals(other.MaximumOccupancy)
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
				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.MinimumOccupancy != null)
					hash = hash * 59 + this.MinimumOccupancy.GetHashCode();

				if (this.MaximumOccupancy != null)
					hash = hash * 59 + this.MaximumOccupancy.GetHashCode();

				return hash;
			}
		}
	}

}
