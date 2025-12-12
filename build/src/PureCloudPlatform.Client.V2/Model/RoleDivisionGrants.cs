using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RoleDivisionGrants
	/// </summary>
	[DataContract]
	public partial class RoleDivisionGrants : IEquatable<RoleDivisionGrants>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="RoleDivisionGrants" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected RoleDivisionGrants() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="RoleDivisionGrants" /> class.
		/// </summary>
		/// <param name="Grants">A list containing pairs of role and division IDs (required).</param>
		public RoleDivisionGrants(List<RoleDivisionPair> Grants = null)
		{
			this.Grants = Grants;

		}



		/// <summary>
		/// A list containing pairs of role and division IDs
		/// </summary>
		/// <value>A list containing pairs of role and division IDs</value>
		[DataMember(Name = "grants", EmitDefaultValue = false)]
		public List<RoleDivisionPair> Grants { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoleDivisionGrants {\n");

			sb.Append("  Grants: ").Append(Grants).Append("\n");
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
			return this.Equals(obj as RoleDivisionGrants);
		}

		/// <summary>
		/// Returns true if RoleDivisionGrants instances are equal
		/// </summary>
		/// <param name="other">Instance of RoleDivisionGrants to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RoleDivisionGrants other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Grants == other.Grants ||
					this.Grants != null &&
					this.Grants.SequenceEqual(other.Grants)
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
				if (this.Grants != null)
					hash = hash * 59 + this.Grants.GetHashCode();

				return hash;
			}
		}
	}

}
