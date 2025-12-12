using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UrlCondition
	/// </summary>
	[DataContract]
	public partial class UrlCondition : IEquatable<UrlCondition>
	{
		/// <summary>
		/// The comparison operator.
		/// </summary>
		/// <value>The comparison operator.</value>
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
			/// Enum Containsall for "containsAll"
			/// </summary>
			[EnumMember(Value = "containsAll")]
			Containsall,

			/// <summary>
			/// Enum Containsany for "containsAny"
			/// </summary>
			[EnumMember(Value = "containsAny")]
			Containsany,

			/// <summary>
			/// Enum Notcontainsall for "notContainsAll"
			/// </summary>
			[EnumMember(Value = "notContainsAll")]
			Notcontainsall,

			/// <summary>
			/// Enum Notcontainsany for "notContainsAny"
			/// </summary>
			[EnumMember(Value = "notContainsAny")]
			Notcontainsany,

			/// <summary>
			/// Enum Equal for "equal"
			/// </summary>
			[EnumMember(Value = "equal")]
			Equal,

			/// <summary>
			/// Enum Notequal for "notEqual"
			/// </summary>
			[EnumMember(Value = "notEqual")]
			Notequal,

			/// <summary>
			/// Enum Greaterthan for "greaterThan"
			/// </summary>
			[EnumMember(Value = "greaterThan")]
			Greaterthan,

			/// <summary>
			/// Enum Greaterthanorequal for "greaterThanOrEqual"
			/// </summary>
			[EnumMember(Value = "greaterThanOrEqual")]
			Greaterthanorequal,

			/// <summary>
			/// Enum Lessthan for "lessThan"
			/// </summary>
			[EnumMember(Value = "lessThan")]
			Lessthan,

			/// <summary>
			/// Enum Lessthanorequal for "lessThanOrEqual"
			/// </summary>
			[EnumMember(Value = "lessThanOrEqual")]
			Lessthanorequal,

			/// <summary>
			/// Enum Startswith for "startsWith"
			/// </summary>
			[EnumMember(Value = "startsWith")]
			Startswith,

			/// <summary>
			/// Enum Endswith for "endsWith"
			/// </summary>
			[EnumMember(Value = "endsWith")]
			Endswith
		}
		/// <summary>
		/// The comparison operator.
		/// </summary>
		/// <value>The comparison operator.</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="UrlCondition" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UrlCondition() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UrlCondition" /> class.
		/// </summary>
		/// <param name="Values">The URL condition value. (required).</param>
		/// <param name="Operator">The comparison operator. (required).</param>
		public UrlCondition(List<string> Values = null, OperatorEnum? Operator = null)
		{
			this.Values = Values;
			this.Operator = Operator;

		}



		/// <summary>
		/// The URL condition value.
		/// </summary>
		/// <value>The URL condition value.</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<string> Values { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UrlCondition {\n");

			sb.Append("  Values: ").Append(Values).Append("\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
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
			return this.Equals(obj as UrlCondition);
		}

		/// <summary>
		/// Returns true if UrlCondition instances are equal
		/// </summary>
		/// <param name="other">Instance of UrlCondition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UrlCondition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Values == other.Values ||
					this.Values != null &&
					this.Values.SequenceEqual(other.Values)
				) &&
				(
					this.Operator == other.Operator ||
					this.Operator != null &&
					this.Operator.Equals(other.Operator)
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
				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				return hash;
			}
		}
	}

}
