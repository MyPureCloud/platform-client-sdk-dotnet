using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContractItems
	/// </summary>
	[DataContract]
	public partial class ContractItems : IEquatable<ContractItems>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractItems" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Pattern">Pattern.</param>
		public ContractItems(List<string> Type = null, string Pattern = null)
		{
			this.Type = Type;
			this.Pattern = Pattern;

		}



		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public List<string> Type { get; set; }



		/// <summary>
		/// Gets or Sets Pattern
		/// </summary>
		[DataMember(Name = "pattern", EmitDefaultValue = false)]
		public string Pattern { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContractItems {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Pattern: ").Append(Pattern).Append("\n");
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
			return this.Equals(obj as ContractItems);
		}

		/// <summary>
		/// Returns true if ContractItems instances are equal
		/// </summary>
		/// <param name="other">Instance of ContractItems to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContractItems other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.SequenceEqual(other.Type)
				) &&
				(
					this.Pattern == other.Pattern ||
					this.Pattern != null &&
					this.Pattern.Equals(other.Pattern)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Pattern != null)
					hash = hash * 59 + this.Pattern.GetHashCode();

				return hash;
			}
		}
	}

}
