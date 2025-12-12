using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DecisionTableInputColumnExpression
	/// </summary>
	[DataContract]
	public partial class DecisionTableInputColumnExpression : IEquatable<DecisionTableInputColumnExpression>
	{
		/// <summary>
		/// A comparator used to join the left and right sides of a logical condition.
		/// </summary>
		/// <value>A comparator used to join the left and right sides of a logical condition.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ComparatorEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Equals for "Equals"
			/// </summary>
			[EnumMember(Value = "Equals")]
			Equals,

			/// <summary>
			/// Enum Notequals for "NotEquals"
			/// </summary>
			[EnumMember(Value = "NotEquals")]
			Notequals,

			/// <summary>
			/// Enum Greaterthan for "GreaterThan"
			/// </summary>
			[EnumMember(Value = "GreaterThan")]
			Greaterthan,

			/// <summary>
			/// Enum Greaterthanorequals for "GreaterThanOrEquals"
			/// </summary>
			[EnumMember(Value = "GreaterThanOrEquals")]
			Greaterthanorequals,

			/// <summary>
			/// Enum Lessthan for "LessThan"
			/// </summary>
			[EnumMember(Value = "LessThan")]
			Lessthan,

			/// <summary>
			/// Enum Lessthanorequals for "LessThanOrEquals"
			/// </summary>
			[EnumMember(Value = "LessThanOrEquals")]
			Lessthanorequals,

			/// <summary>
			/// Enum Startswith for "StartsWith"
			/// </summary>
			[EnumMember(Value = "StartsWith")]
			Startswith,

			/// <summary>
			/// Enum Notstartswith for "NotStartsWith"
			/// </summary>
			[EnumMember(Value = "NotStartsWith")]
			Notstartswith,

			/// <summary>
			/// Enum Endswith for "EndsWith"
			/// </summary>
			[EnumMember(Value = "EndsWith")]
			Endswith,

			/// <summary>
			/// Enum Notendswith for "NotEndsWith"
			/// </summary>
			[EnumMember(Value = "NotEndsWith")]
			Notendswith,

			/// <summary>
			/// Enum Contains for "Contains"
			/// </summary>
			[EnumMember(Value = "Contains")]
			Contains,

			/// <summary>
			/// Enum Notcontains for "NotContains"
			/// </summary>
			[EnumMember(Value = "NotContains")]
			Notcontains,

			/// <summary>
			/// Enum Containsany for "ContainsAny"
			/// </summary>
			[EnumMember(Value = "ContainsAny")]
			Containsany,

			/// <summary>
			/// Enum Notcontainsany for "NotContainsAny"
			/// </summary>
			[EnumMember(Value = "NotContainsAny")]
			Notcontainsany,

			/// <summary>
			/// Enum Containsall for "ContainsAll"
			/// </summary>
			[EnumMember(Value = "ContainsAll")]
			Containsall,

			/// <summary>
			/// Enum Notcontainsall for "NotContainsAll"
			/// </summary>
			[EnumMember(Value = "NotContainsAll")]
			Notcontainsall,

			/// <summary>
			/// Enum Containsexactly for "ContainsExactly"
			/// </summary>
			[EnumMember(Value = "ContainsExactly")]
			Containsexactly,

			/// <summary>
			/// Enum Notcontainsexactly for "NotContainsExactly"
			/// </summary>
			[EnumMember(Value = "NotContainsExactly")]
			Notcontainsexactly,

			/// <summary>
			/// Enum Containssequence for "ContainsSequence"
			/// </summary>
			[EnumMember(Value = "ContainsSequence")]
			Containssequence,

			/// <summary>
			/// Enum Notcontainssequence for "NotContainsSequence"
			/// </summary>
			[EnumMember(Value = "NotContainsSequence")]
			Notcontainssequence,

			/// <summary>
			/// Enum Issubset for "IsSubset"
			/// </summary>
			[EnumMember(Value = "IsSubset")]
			Issubset,

			/// <summary>
			/// Enum Notissubset for "NotIsSubset"
			/// </summary>
			[EnumMember(Value = "NotIsSubset")]
			Notissubset,

			/// <summary>
			/// Enum Issubsequence for "IsSubsequence"
			/// </summary>
			[EnumMember(Value = "IsSubsequence")]
			Issubsequence,

			/// <summary>
			/// Enum Notissubsequence for "NotIsSubsequence"
			/// </summary>
			[EnumMember(Value = "NotIsSubsequence")]
			Notissubsequence
		}
		/// <summary>
		/// A comparator used to join the left and right sides of a logical condition.
		/// </summary>
		/// <value>A comparator used to join the left and right sides of a logical condition.</value>
		[DataMember(Name = "comparator", EmitDefaultValue = false)]
		public ComparatorEnum? Comparator { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableInputColumnExpression" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DecisionTableInputColumnExpression() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DecisionTableInputColumnExpression" /> class.
		/// </summary>
		/// <param name="Contractual">A value that is defined by a contract schema and used to form the left side of a logical condition. (required).</param>
		/// <param name="Comparator">A comparator used to join the left and right sides of a logical condition. (required).</param>
		public DecisionTableInputColumnExpression(Contractual Contractual = null, ComparatorEnum? Comparator = null)
		{
			this.Contractual = Contractual;
			this.Comparator = Comparator;

		}



		/// <summary>
		/// A value that is defined by a contract schema and used to form the left side of a logical condition.
		/// </summary>
		/// <value>A value that is defined by a contract schema and used to form the left side of a logical condition.</value>
		[DataMember(Name = "contractual", EmitDefaultValue = false)]
		public Contractual Contractual { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DecisionTableInputColumnExpression {\n");

			sb.Append("  Contractual: ").Append(Contractual).Append("\n");
			sb.Append("  Comparator: ").Append(Comparator).Append("\n");
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
			return this.Equals(obj as DecisionTableInputColumnExpression);
		}

		/// <summary>
		/// Returns true if DecisionTableInputColumnExpression instances are equal
		/// </summary>
		/// <param name="other">Instance of DecisionTableInputColumnExpression to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DecisionTableInputColumnExpression other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Contractual == other.Contractual ||
					this.Contractual != null &&
					this.Contractual.Equals(other.Contractual)
				) &&
				(
					this.Comparator == other.Comparator ||
					this.Comparator != null &&
					this.Comparator.Equals(other.Comparator)
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
				if (this.Contractual != null)
					hash = hash * 59 + this.Contractual.GetHashCode();

				if (this.Comparator != null)
					hash = hash * 59 + this.Comparator.GetHashCode();

				return hash;
			}
		}
	}

}
