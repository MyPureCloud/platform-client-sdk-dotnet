using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContestMetrics
	/// </summary>
	[DataContract]
	public partial class ContestMetrics : IEquatable<ContestMetrics>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContestMetrics" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContestMetrics() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContestMetrics" /> class.
		/// </summary>
		/// <param name="Id">The globally unique identifier for the object. (required).</param>
		/// <param name="Name">Name.</param>
		/// <param name="Weight">The Contest Metrics weight, allowed values are 1-100 (required).</param>
		/// <param name="MinimumQualifier">The Contest Metrics minimum qualifier. Min value is 0, no Max value (required).</param>
		public ContestMetrics(string Id = null, string Name = null, int? Weight = null, int? MinimumQualifier = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Weight = Weight;
			this.MinimumQualifier = MinimumQualifier;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The Contest Metrics weight, allowed values are 1-100
		/// </summary>
		/// <value>The Contest Metrics weight, allowed values are 1-100</value>
		[DataMember(Name = "weight", EmitDefaultValue = false)]
		public int? Weight { get; set; }



		/// <summary>
		/// The Contest Metrics minimum qualifier. Min value is 0, no Max value
		/// </summary>
		/// <value>The Contest Metrics minimum qualifier. Min value is 0, no Max value</value>
		[DataMember(Name = "minimumQualifier", EmitDefaultValue = false)]
		public int? MinimumQualifier { get; set; }



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
			sb.Append("class ContestMetrics {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Weight: ").Append(Weight).Append("\n");
			sb.Append("  MinimumQualifier: ").Append(MinimumQualifier).Append("\n");
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
			return this.Equals(obj as ContestMetrics);
		}

		/// <summary>
		/// Returns true if ContestMetrics instances are equal
		/// </summary>
		/// <param name="other">Instance of ContestMetrics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContestMetrics other)
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
					this.Weight == other.Weight ||
					this.Weight != null &&
					this.Weight.Equals(other.Weight)
				) &&
				(
					this.MinimumQualifier == other.MinimumQualifier ||
					this.MinimumQualifier != null &&
					this.MinimumQualifier.Equals(other.MinimumQualifier)
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

				if (this.Weight != null)
					hash = hash * 59 + this.Weight.GetHashCode();

				if (this.MinimumQualifier != null)
					hash = hash * 59 + this.MinimumQualifier.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
