using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Request to update an existing Business Rules Schema
	/// </summary>
	[DataContract]
	public partial class BusinessRulesSchemaUpdateRequest : IEquatable<BusinessRulesSchemaUpdateRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessRulesSchemaUpdateRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BusinessRulesSchemaUpdateRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BusinessRulesSchemaUpdateRequest" /> class.
		/// </summary>
		/// <param name="Version">The schema&#39;s version, a positive integer. Required for updates. (required).</param>
		/// <param name="Enabled">The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists..</param>
		/// <param name="JsonSchema">A JSON schema defining the extension to the built-in entity type. (required).</param>
		public BusinessRulesSchemaUpdateRequest(int? Version = null, bool? Enabled = null, JsonSchemaWithDefinitions JsonSchema = null)
		{
			this.Version = Version;
			this.Enabled = Enabled;
			this.JsonSchema = JsonSchema;

		}



		/// <summary>
		/// The schema&#39;s version, a positive integer. Required for updates.
		/// </summary>
		/// <value>The schema&#39;s version, a positive integer. Required for updates.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }



		/// <summary>
		/// The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.
		/// </summary>
		/// <value>The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }



		/// <summary>
		/// A JSON schema defining the extension to the built-in entity type.
		/// </summary>
		/// <value>A JSON schema defining the extension to the built-in entity type.</value>
		[DataMember(Name = "jsonSchema", EmitDefaultValue = false)]
		public JsonSchemaWithDefinitions JsonSchema { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BusinessRulesSchemaUpdateRequest {\n");

			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  JsonSchema: ").Append(JsonSchema).Append("\n");
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
			return this.Equals(obj as BusinessRulesSchemaUpdateRequest);
		}

		/// <summary>
		/// Returns true if BusinessRulesSchemaUpdateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of BusinessRulesSchemaUpdateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BusinessRulesSchemaUpdateRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
				) &&
				(
					this.JsonSchema == other.JsonSchema ||
					this.JsonSchema != null &&
					this.JsonSchema.Equals(other.JsonSchema)
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
				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				if (this.JsonSchema != null)
					hash = hash * 59 + this.JsonSchema.GetHashCode();

				return hash;
			}
		}
	}

}
