using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentQueryClause
	/// </summary>
	[DataContract]
	public partial class DocumentQueryClause : IEquatable<DocumentQueryClause>
	{
		/// <summary>
		/// Specifies how the predicates will be applied together.
		/// </summary>
		/// <value>Specifies how the predicates will be applied together.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OperatorEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Or for "Or"
			/// </summary>
			[EnumMember(Value = "Or")]
			Or,

			/// <summary>
			/// Enum And for "And"
			/// </summary>
			[EnumMember(Value = "And")]
			And
		}
		/// <summary>
		/// Specifies how the predicates will be applied together.
		/// </summary>
		/// <value>Specifies how the predicates will be applied together.</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentQueryClause" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DocumentQueryClause() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentQueryClause" /> class.
		/// </summary>
		/// <param name="Operator">Specifies how the predicates will be applied together. (required).</param>
		/// <param name="Predicates">To apply multiple conditions. Limit of 10 predicates across all clauses. (required).</param>
		public DocumentQueryClause(OperatorEnum? Operator = null, List<DocumentQueryPredicate> Predicates = null)
		{
			this.Operator = Operator;
			this.Predicates = Predicates;

		}





		/// <summary>
		/// To apply multiple conditions. Limit of 10 predicates across all clauses.
		/// </summary>
		/// <value>To apply multiple conditions. Limit of 10 predicates across all clauses.</value>
		[DataMember(Name = "predicates", EmitDefaultValue = false)]
		public List<DocumentQueryPredicate> Predicates { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentQueryClause {\n");

			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
			return this.Equals(obj as DocumentQueryClause);
		}

		/// <summary>
		/// Returns true if DocumentQueryClause instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentQueryClause to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentQueryClause other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Operator == other.Operator ||
					this.Operator != null &&
					this.Operator.Equals(other.Operator)
				) &&
				(
					this.Predicates == other.Predicates ||
					this.Predicates != null &&
					this.Predicates.SequenceEqual(other.Predicates)
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
				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				if (this.Predicates != null)
					hash = hash * 59 + this.Predicates.GetHashCode();

				return hash;
			}
		}
	}

}
