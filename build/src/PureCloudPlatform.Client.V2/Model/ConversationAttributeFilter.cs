using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationAttributeFilter
	/// </summary>
	[DataContract]
	public partial class ConversationAttributeFilter : IEquatable<ConversationAttributeFilter>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationAttributeFilter" /> class.
		/// </summary>
		/// <param name="Schemas">Schemas and attributes to filter for..</param>
		public ConversationAttributeFilter(List<ConversationSchemaData> Schemas = null)
		{
			this.Schemas = Schemas;

		}



		/// <summary>
		/// Schemas and attributes to filter for.
		/// </summary>
		/// <value>Schemas and attributes to filter for.</value>
		[DataMember(Name = "schemas", EmitDefaultValue = false)]
		public List<ConversationSchemaData> Schemas { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationAttributeFilter {\n");

			sb.Append("  Schemas: ").Append(Schemas).Append("\n");
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
			return this.Equals(obj as ConversationAttributeFilter);
		}

		/// <summary>
		/// Returns true if ConversationAttributeFilter instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationAttributeFilter to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationAttributeFilter other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Schemas == other.Schemas ||
					this.Schemas != null &&
					this.Schemas.SequenceEqual(other.Schemas)
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
				if (this.Schemas != null)
					hash = hash * 59 + this.Schemas.GetHashCode();

				return hash;
			}
		}
	}

}
