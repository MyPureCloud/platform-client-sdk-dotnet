using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NamedEntityTypeBinding
	/// </summary>
	[DataContract]
	public partial class NamedEntityTypeBinding : IEquatable<NamedEntityTypeBinding>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="NamedEntityTypeBinding" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NamedEntityTypeBinding() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NamedEntityTypeBinding" /> class.
		/// </summary>
		/// <param name="EntityType">The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType. (required).</param>
		/// <param name="EntityName">The name that this named entity type is bound to. (required).</param>
		public NamedEntityTypeBinding(string EntityType = null, string EntityName = null)
		{
			this.EntityType = EntityType;
			this.EntityName = EntityName;

		}



		/// <summary>
		/// The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType.
		/// </summary>
		/// <value>The named entity type of the binding. It can be a built-in one such as builtin:number or a custom entity type such as BeverageType.</value>
		[DataMember(Name = "entityType", EmitDefaultValue = false)]
		public string EntityType { get; set; }



		/// <summary>
		/// The name that this named entity type is bound to.
		/// </summary>
		/// <value>The name that this named entity type is bound to.</value>
		[DataMember(Name = "entityName", EmitDefaultValue = false)]
		public string EntityName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NamedEntityTypeBinding {\n");

			sb.Append("  EntityType: ").Append(EntityType).Append("\n");
			sb.Append("  EntityName: ").Append(EntityName).Append("\n");
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
			return this.Equals(obj as NamedEntityTypeBinding);
		}

		/// <summary>
		/// Returns true if NamedEntityTypeBinding instances are equal
		/// </summary>
		/// <param name="other">Instance of NamedEntityTypeBinding to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NamedEntityTypeBinding other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EntityType == other.EntityType ||
					this.EntityType != null &&
					this.EntityType.Equals(other.EntityType)
				) &&
				(
					this.EntityName == other.EntityName ||
					this.EntityName != null &&
					this.EntityName.Equals(other.EntityName)
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
				if (this.EntityType != null)
					hash = hash * 59 + this.EntityType.GetHashCode();

				if (this.EntityName != null)
					hash = hash * 59 + this.EntityName.GetHashCode();

				return hash;
			}
		}
	}

}
