using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DecisionTableInputColumn
	/// </summary>
	[DataContract]
	public partial class DecisionTableInputColumn : IEquatable<DecisionTableInputColumn>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableInputColumn" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DecisionTableInputColumn() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableInputColumn" /> class.
		/// </summary>
		/// <param name="DefaultsTo">The default row value for this column that will complete the condition expression where no value is provided by a row..</param>
		/// <param name="Expression">The input column condition expression, comprising the left side and comparator of a logical condition in the form of left|comparator|right, where each row of the decision table will provide the right side to form a complete condition (required).</param>
		public DecisionTableInputColumn(DecisionTableColumnDefaultRowValue DefaultsTo = null, DecisionTableInputColumnExpression Expression = null)
		{
			this.DefaultsTo = DefaultsTo;
			this.Expression = Expression;

		}



		/// <summary>
		/// The id of the column.
		/// </summary>
		/// <value>The id of the column.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The default row value for this column that will complete the condition expression where no value is provided by a row.
		/// </summary>
		/// <value>The default row value for this column that will complete the condition expression where no value is provided by a row.</value>
		[DataMember(Name = "defaultsTo", EmitDefaultValue = false)]
		public DecisionTableColumnDefaultRowValue DefaultsTo { get; set; }



		/// <summary>
		/// The input column condition expression, comprising the left side and comparator of a logical condition in the form of left|comparator|right, where each row of the decision table will provide the right side to form a complete condition
		/// </summary>
		/// <value>The input column condition expression, comprising the left side and comparator of a logical condition in the form of left|comparator|right, where each row of the decision table will provide the right side to form a complete condition</value>
		[DataMember(Name = "expression", EmitDefaultValue = false)]
		public DecisionTableInputColumnExpression Expression { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DecisionTableInputColumn {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DefaultsTo: ").Append(DefaultsTo).Append("\n");
			sb.Append("  Expression: ").Append(Expression).Append("\n");
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
			return this.Equals(obj as DecisionTableInputColumn);
		}

		/// <summary>
		/// Returns true if DecisionTableInputColumn instances are equal
		/// </summary>
		/// <param name="other">Instance of DecisionTableInputColumn to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DecisionTableInputColumn other)
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
					this.DefaultsTo == other.DefaultsTo ||
					this.DefaultsTo != null &&
					this.DefaultsTo.Equals(other.DefaultsTo)
				) &&
				(
					this.Expression == other.Expression ||
					this.Expression != null &&
					this.Expression.Equals(other.Expression)
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

				if (this.DefaultsTo != null)
					hash = hash * 59 + this.DefaultsTo.GetHashCode();

				if (this.Expression != null)
					hash = hash * 59 + this.Expression.GetHashCode();

				return hash;
			}
		}
	}

}
