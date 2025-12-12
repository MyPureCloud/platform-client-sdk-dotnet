using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserObservationQueryPredicate
	/// </summary>
	[DataContract]
	public partial class UserObservationQueryPredicate : IEquatable<UserObservationQueryPredicate>
	{
		/// <summary>
		/// Optional type, can usually be inferred
		/// </summary>
		/// <value>Optional type, can usually be inferred</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Dimension for "dimension"
			/// </summary>
			[EnumMember(Value = "dimension")]
			Dimension,

			/// <summary>
			/// Enum Property for "property"
			/// </summary>
			[EnumMember(Value = "property")]
			Property,

			/// <summary>
			/// Enum Metric for "metric"
			/// </summary>
			[EnumMember(Value = "metric")]
			Metric
		}
		/// <summary>
		/// Left hand side for dimension predicates
		/// </summary>
		/// <value>Left hand side for dimension predicates</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DimensionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Userid for "userId"
			/// </summary>
			[EnumMember(Value = "userId")]
			Userid
		}
		/// <summary>
		/// Optional operator, default is matches
		/// </summary>
		/// <value>Optional operator, default is matches</value>
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
			/// Enum Matches for "matches"
			/// </summary>
			[EnumMember(Value = "matches")]
			Matches,

			/// <summary>
			/// Enum Exists for "exists"
			/// </summary>
			[EnumMember(Value = "exists")]
			Exists,

			/// <summary>
			/// Enum Notexists for "notExists"
			/// </summary>
			[EnumMember(Value = "notExists")]
			Notexists
		}
		/// <summary>
		/// Optional type, can usually be inferred
		/// </summary>
		/// <value>Optional type, can usually be inferred</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Left hand side for dimension predicates
		/// </summary>
		/// <value>Left hand side for dimension predicates</value>
		[DataMember(Name = "dimension", EmitDefaultValue = false)]
		public DimensionEnum? Dimension { get; set; }
		/// <summary>
		/// Optional operator, default is matches
		/// </summary>
		/// <value>Optional operator, default is matches</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserObservationQueryPredicate" /> class.
		/// </summary>
		/// <param name="Type">Optional type, can usually be inferred.</param>
		/// <param name="Dimension">Left hand side for dimension predicates.</param>
		/// <param name="Operator">Optional operator, default is matches.</param>
		/// <param name="Value">Right hand side for dimension predicates.</param>
		/// <param name="Range">Right hand side for dimension predicates.</param>
		public UserObservationQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
		{
			this.Type = Type;
			this.Dimension = Dimension;
			this.Operator = Operator;
			this.Value = Value;
			this.Range = Range;

		}









		/// <summary>
		/// Right hand side for dimension predicates
		/// </summary>
		/// <value>Right hand side for dimension predicates</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }



		/// <summary>
		/// Right hand side for dimension predicates
		/// </summary>
		/// <value>Right hand side for dimension predicates</value>
		[DataMember(Name = "range", EmitDefaultValue = false)]
		public NumericRange Range { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserObservationQueryPredicate {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Dimension: ").Append(Dimension).Append("\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
			sb.Append("  Range: ").Append(Range).Append("\n");
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
			return this.Equals(obj as UserObservationQueryPredicate);
		}

		/// <summary>
		/// Returns true if UserObservationQueryPredicate instances are equal
		/// </summary>
		/// <param name="other">Instance of UserObservationQueryPredicate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserObservationQueryPredicate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Dimension == other.Dimension ||
					this.Dimension != null &&
					this.Dimension.Equals(other.Dimension)
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
				) &&
				(
					this.Range == other.Range ||
					this.Range != null &&
					this.Range.Equals(other.Range)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Dimension != null)
					hash = hash * 59 + this.Dimension.GetHashCode();

				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				if (this.Range != null)
					hash = hash * 59 + this.Range.GetHashCode();

				return hash;
			}
		}
	}

}
