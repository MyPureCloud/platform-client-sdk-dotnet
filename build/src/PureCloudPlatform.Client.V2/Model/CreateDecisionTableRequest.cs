using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateDecisionTableRequest
	/// </summary>
	[DataContract]
	public partial class CreateDecisionTableRequest : IEquatable<CreateDecisionTableRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateDecisionTableRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateDecisionTableRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateDecisionTableRequest" /> class.
		/// </summary>
		/// <param name="Name">The decision table name. (required).</param>
		/// <param name="Description">The decision table description..</param>
		/// <param name="DivisionId">The ID of the division the decision table belongs to. (required).</param>
		/// <param name="SchemaId">The ID of the rules schema used by the decision table. (required).</param>
		/// <param name="Columns">The column definitions for this decision table. (required).</param>
		public CreateDecisionTableRequest(string Name = null, string Description = null, string DivisionId = null, string SchemaId = null, CreateDecisionTableColumnsRequest Columns = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.DivisionId = DivisionId;
			this.SchemaId = SchemaId;
			this.Columns = Columns;

		}



		/// <summary>
		/// The decision table name.
		/// </summary>
		/// <value>The decision table name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The decision table description.
		/// </summary>
		/// <value>The decision table description.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The ID of the division the decision table belongs to.
		/// </summary>
		/// <value>The ID of the division the decision table belongs to.</value>
		[DataMember(Name = "divisionId", EmitDefaultValue = false)]
		public string DivisionId { get; set; }



		/// <summary>
		/// The ID of the rules schema used by the decision table.
		/// </summary>
		/// <value>The ID of the rules schema used by the decision table.</value>
		[DataMember(Name = "schemaId", EmitDefaultValue = false)]
		public string SchemaId { get; set; }



		/// <summary>
		/// The column definitions for this decision table.
		/// </summary>
		/// <value>The column definitions for this decision table.</value>
		[DataMember(Name = "columns", EmitDefaultValue = false)]
		public CreateDecisionTableColumnsRequest Columns { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateDecisionTableRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
			sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
			sb.Append("  Columns: ").Append(Columns).Append("\n");
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
			return this.Equals(obj as CreateDecisionTableRequest);
		}

		/// <summary>
		/// Returns true if CreateDecisionTableRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateDecisionTableRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateDecisionTableRequest other)
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
					this.DivisionId == other.DivisionId ||
					this.DivisionId != null &&
					this.DivisionId.Equals(other.DivisionId)
				) &&
				(
					this.SchemaId == other.SchemaId ||
					this.SchemaId != null &&
					this.SchemaId.Equals(other.SchemaId)
				) &&
				(
					this.Columns == other.Columns ||
					this.Columns != null &&
					this.Columns.Equals(other.Columns)
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

				if (this.DivisionId != null)
					hash = hash * 59 + this.DivisionId.GetHashCode();

				if (this.SchemaId != null)
					hash = hash * 59 + this.SchemaId.GetHashCode();

				if (this.Columns != null)
					hash = hash * 59 + this.Columns.GetHashCode();

				return hash;
			}
		}
	}

}
