using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConditionalGroupActivationCondition
	/// </summary>
	[DataContract]
	public partial class ConditionalGroupActivationCondition : IEquatable<ConditionalGroupActivationCondition>
	{
		/// <summary>
		/// The operator used to compare the actual value against the threshold value
		/// </summary>
		/// <value>The operator used to compare the actual value against the threshold value</value>
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
			/// Enum Greaterthan for "GreaterThan"
			/// </summary>
			[EnumMember(Value = "GreaterThan")]
			Greaterthan,

			/// <summary>
			/// Enum Greaterthanorequalto for "GreaterThanOrEqualTo"
			/// </summary>
			[EnumMember(Value = "GreaterThanOrEqualTo")]
			Greaterthanorequalto,

			/// <summary>
			/// Enum Lessthan for "LessThan"
			/// </summary>
			[EnumMember(Value = "LessThan")]
			Lessthan,

			/// <summary>
			/// Enum Lessthanorequalto for "LessThanOrEqualTo"
			/// </summary>
			[EnumMember(Value = "LessThanOrEqualTo")]
			Lessthanorequalto,

			/// <summary>
			/// Enum Equalto for "EqualTo"
			/// </summary>
			[EnumMember(Value = "EqualTo")]
			Equalto,

			/// <summary>
			/// Enum Notequalto for "NotEqualTo"
			/// </summary>
			[EnumMember(Value = "NotEqualTo")]
			Notequalto
		}
		/// <summary>
		/// The operator used to compare the actual value against the threshold value
		/// </summary>
		/// <value>The operator used to compare the actual value against the threshold value</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConditionalGroupActivationCondition" /> class.
		/// </summary>
		/// <param name="SimpleMetric">Instructs this condition to evaluate a simple queue-level metric.</param>
		/// <param name="Operator">The operator used to compare the actual value against the threshold value.</param>
		/// <param name="Value">The threshold value, beyond which a rule evaluates as true.</param>
		public ConditionalGroupActivationCondition(ConditionalGroupActivationSimpleMetric SimpleMetric = null, OperatorEnum? Operator = null, double? Value = null)
		{
			this.SimpleMetric = SimpleMetric;
			this.Operator = Operator;
			this.Value = Value;

		}



		/// <summary>
		/// Instructs this condition to evaluate a simple queue-level metric
		/// </summary>
		/// <value>Instructs this condition to evaluate a simple queue-level metric</value>
		[DataMember(Name = "simpleMetric", EmitDefaultValue = false)]
		public ConditionalGroupActivationSimpleMetric SimpleMetric { get; set; }





		/// <summary>
		/// The threshold value, beyond which a rule evaluates as true
		/// </summary>
		/// <value>The threshold value, beyond which a rule evaluates as true</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public double? Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConditionalGroupActivationCondition {\n");

			sb.Append("  SimpleMetric: ").Append(SimpleMetric).Append("\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as ConditionalGroupActivationCondition);
		}

		/// <summary>
		/// Returns true if ConditionalGroupActivationCondition instances are equal
		/// </summary>
		/// <param name="other">Instance of ConditionalGroupActivationCondition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConditionalGroupActivationCondition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SimpleMetric == other.SimpleMetric ||
					this.SimpleMetric != null &&
					this.SimpleMetric.Equals(other.SimpleMetric)
				) &&
				(
					this.Operator == other.Operator ||
					this.Operator != null &&
					this.Operator.Equals(other.Operator)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.SimpleMetric != null)
					hash = hash * 59 + this.SimpleMetric.GetHashCode();

				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
