using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PatchContextPattern
	/// </summary>
	[DataContract]
	public partial class PatchContextPattern : IEquatable<PatchContextPattern>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PatchContextPattern" /> class.
		/// </summary>
		/// <param name="Criteria">A list of one or more criteria to satisfy..</param>
		public PatchContextPattern(List<PatchEntityTypeCriteria> Criteria = null)
		{
			this.Criteria = Criteria;

		}



		/// <summary>
		/// A list of one or more criteria to satisfy.
		/// </summary>
		/// <value>A list of one or more criteria to satisfy.</value>
		[DataMember(Name = "criteria", EmitDefaultValue = false)]
		public List<PatchEntityTypeCriteria> Criteria { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PatchContextPattern {\n");

			sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
			return this.Equals(obj as PatchContextPattern);
		}

		/// <summary>
		/// Returns true if PatchContextPattern instances are equal
		/// </summary>
		/// <param name="other">Instance of PatchContextPattern to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PatchContextPattern other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Criteria == other.Criteria ||
					this.Criteria != null &&
					this.Criteria.SequenceEqual(other.Criteria)
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
				if (this.Criteria != null)
					hash = hash * 59 + this.Criteria.GetHashCode();

				return hash;
			}
		}
	}

}
