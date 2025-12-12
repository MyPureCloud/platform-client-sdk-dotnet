using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EntityTypeCriteria
	/// </summary>
	[DataContract]
	public partial class EntityTypeCriteria : IEquatable<EntityTypeCriteria>
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
		/// The entity to match the pattern against.
		/// </summary>
		/// <value>The entity to match the pattern against.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EntityTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Visit for "visit"
			/// </summary>
			[EnumMember(Value = "visit")]
			Visit
		}
		/// <summary>
		/// The comparison operator.
		/// </summary>
		/// <value>The comparison operator.</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }
		/// <summary>
		/// The entity to match the pattern against.
		/// </summary>
		/// <value>The entity to match the pattern against.</value>
		[DataMember(Name = "entityType", EmitDefaultValue = false)]
		public EntityTypeEnum? EntityType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="EntityTypeCriteria" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected EntityTypeCriteria() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityTypeCriteria" /> class.
		/// </summary>
		/// <param name="Key">The criteria key. (required).</param>
		/// <param name="Values">The criteria values. (required).</param>
		/// <param name="ShouldIgnoreCase">Should criteria be case insensitive. (required).</param>
		/// <param name="Operator">The comparison operator. (required).</param>
		/// <param name="EntityType">The entity to match the pattern against. (required).</param>
		public EntityTypeCriteria(string Key = null, List<string> Values = null, bool? ShouldIgnoreCase = null, OperatorEnum? Operator = null, EntityTypeEnum? EntityType = null)
		{
			this.Key = Key;
			this.Values = Values;
			this.ShouldIgnoreCase = ShouldIgnoreCase;
			this.Operator = Operator;
			this.EntityType = EntityType;

		}



		/// <summary>
		/// The criteria key.
		/// </summary>
		/// <value>The criteria key.</value>
		[DataMember(Name = "key", EmitDefaultValue = false)]
		public string Key { get; set; }



		/// <summary>
		/// The criteria values.
		/// </summary>
		/// <value>The criteria values.</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<string> Values { get; set; }



		/// <summary>
		/// Should criteria be case insensitive.
		/// </summary>
		/// <value>Should criteria be case insensitive.</value>
		[DataMember(Name = "shouldIgnoreCase", EmitDefaultValue = false)]
		public bool? ShouldIgnoreCase { get; set; }






		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EntityTypeCriteria {\n");

			sb.Append("  Key: ").Append(Key).Append("\n");
			sb.Append("  Values: ").Append(Values).Append("\n");
			sb.Append("  ShouldIgnoreCase: ").Append(ShouldIgnoreCase).Append("\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
			return this.Equals(obj as EntityTypeCriteria);
		}

		/// <summary>
		/// Returns true if EntityTypeCriteria instances are equal
		/// </summary>
		/// <param name="other">Instance of EntityTypeCriteria to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EntityTypeCriteria other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Key == other.Key ||
					this.Key != null &&
					this.Key.Equals(other.Key)
				) &&
				(
					this.Values == other.Values ||
					this.Values != null &&
					this.Values.SequenceEqual(other.Values)
				) &&
				(
					this.ShouldIgnoreCase == other.ShouldIgnoreCase ||
					this.ShouldIgnoreCase != null &&
					this.ShouldIgnoreCase.Equals(other.ShouldIgnoreCase)
				) &&
				(
					this.Operator == other.Operator ||
					this.Operator != null &&
					this.Operator.Equals(other.Operator)
				) &&
				(
					this.EntityType == other.EntityType ||
					this.EntityType != null &&
					this.EntityType.Equals(other.EntityType)
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
				if (this.Key != null)
					hash = hash * 59 + this.Key.GetHashCode();

				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				if (this.ShouldIgnoreCase != null)
					hash = hash * 59 + this.ShouldIgnoreCase.GetHashCode();

				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				if (this.EntityType != null)
					hash = hash * 59 + this.EntityType.GetHashCode();

				return hash;
			}
		}
	}

}
