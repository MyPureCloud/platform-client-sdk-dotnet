using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NamedEntityTypeDefinition
	/// </summary>
	[DataContract]
	public partial class NamedEntityTypeDefinition : IEquatable<NamedEntityTypeDefinition>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="NamedEntityTypeDefinition" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NamedEntityTypeDefinition() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NamedEntityTypeDefinition" /> class.
		/// </summary>
		/// <param name="Name">The name of the entity type. (required).</param>
		/// <param name="Description">Description of the of the named entity type..</param>
		/// <param name="Mechanism">The mechanism enabling detection of the named entity type. (required).</param>
		public NamedEntityTypeDefinition(string Name = null, string Description = null, NamedEntityTypeMechanism Mechanism = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.Mechanism = Mechanism;

		}



		/// <summary>
		/// The name of the entity type.
		/// </summary>
		/// <value>The name of the entity type.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Description of the of the named entity type.
		/// </summary>
		/// <value>Description of the of the named entity type.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The mechanism enabling detection of the named entity type.
		/// </summary>
		/// <value>The mechanism enabling detection of the named entity type.</value>
		[DataMember(Name = "mechanism", EmitDefaultValue = false)]
		public NamedEntityTypeMechanism Mechanism { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NamedEntityTypeDefinition {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
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
			return this.Equals(obj as NamedEntityTypeDefinition);
		}

		/// <summary>
		/// Returns true if NamedEntityTypeDefinition instances are equal
		/// </summary>
		/// <param name="other">Instance of NamedEntityTypeDefinition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NamedEntityTypeDefinition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Mechanism == other.Mechanism ||
					this.Mechanism != null &&
					this.Mechanism.Equals(other.Mechanism)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Mechanism != null)
					hash = hash * 59 + this.Mechanism.GetHashCode();

				return hash;
			}
		}
	}

}
