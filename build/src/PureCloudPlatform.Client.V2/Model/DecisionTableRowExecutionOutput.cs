using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DecisionTableRowExecutionOutput
	/// </summary>
	[DataContract]
	public partial class DecisionTableRowExecutionOutput : IEquatable<DecisionTableRowExecutionOutput>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableRowExecutionOutput" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DecisionTableRowExecutionOutput() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableRowExecutionOutput" /> class.
		/// </summary>
		/// <param name="RowId">Unique rule identifier. (required).</param>
		/// <param name="RowIndex">Unique rule identifier. (required).</param>
		/// <param name="Outputs">The JSON output produced by this rule. Valid according to the execution output contract. In the case of enum decision table output columns, the enum options key will be provided as the value, not the enum options label as this can be changed. For business rules queue columns both “queue” and “id” keys will always be returned  regardless of the business rules queue attribute key and these do not change. (required).</param>
		public DecisionTableRowExecutionOutput(string RowId = null, int? RowIndex = null, Dictionary<string, Object> Outputs = null)
		{
			this.RowId = RowId;
			this.RowIndex = RowIndex;
			this.Outputs = Outputs;

		}



		/// <summary>
		/// Unique rule identifier.
		/// </summary>
		/// <value>Unique rule identifier.</value>
		[DataMember(Name = "rowId", EmitDefaultValue = false)]
		public string RowId { get; set; }



		/// <summary>
		/// Unique rule identifier.
		/// </summary>
		/// <value>Unique rule identifier.</value>
		[DataMember(Name = "rowIndex", EmitDefaultValue = false)]
		public int? RowIndex { get; set; }



		/// <summary>
		/// The JSON output produced by this rule. Valid according to the execution output contract. In the case of enum decision table output columns, the enum options key will be provided as the value, not the enum options label as this can be changed. For business rules queue columns both “queue” and “id” keys will always be returned  regardless of the business rules queue attribute key and these do not change.
		/// </summary>
		/// <value>The JSON output produced by this rule. Valid according to the execution output contract. In the case of enum decision table output columns, the enum options key will be provided as the value, not the enum options label as this can be changed. For business rules queue columns both “queue” and “id” keys will always be returned  regardless of the business rules queue attribute key and these do not change.</value>
		[DataMember(Name = "outputs", EmitDefaultValue = false)]
		public Dictionary<string, Object> Outputs { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DecisionTableRowExecutionOutput {\n");

			sb.Append("  RowId: ").Append(RowId).Append("\n");
			sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
			sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
			return this.Equals(obj as DecisionTableRowExecutionOutput);
		}

		/// <summary>
		/// Returns true if DecisionTableRowExecutionOutput instances are equal
		/// </summary>
		/// <param name="other">Instance of DecisionTableRowExecutionOutput to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DecisionTableRowExecutionOutput other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RowId == other.RowId ||
					this.RowId != null &&
					this.RowId.Equals(other.RowId)
				) &&
				(
					this.RowIndex == other.RowIndex ||
					this.RowIndex != null &&
					this.RowIndex.Equals(other.RowIndex)
				) &&
				(
					this.Outputs == other.Outputs ||
					this.Outputs != null &&
					this.Outputs.SequenceEqual(other.Outputs)
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
				if (this.RowId != null)
					hash = hash * 59 + this.RowId.GetHashCode();

				if (this.RowIndex != null)
					hash = hash * 59 + this.RowIndex.GetHashCode();

				if (this.Outputs != null)
					hash = hash * 59 + this.Outputs.GetHashCode();

				return hash;
			}
		}
	}

}
