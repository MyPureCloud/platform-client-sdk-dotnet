using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemQueryJobQueryFiltersPredicate
	/// </summary>
	[DataContract]
	public partial class WorkitemQueryJobQueryFiltersPredicate : IEquatable<WorkitemQueryJobQueryFiltersPredicate>
	{
		/// <summary>
		/// Query filter predicate operator.
		/// </summary>
		/// <value>Query filter predicate operator.</value>
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
			/// Enum Eq for "EQ"
			/// </summary>
			[EnumMember(Value = "EQ")]
			Eq,

			/// <summary>
			/// Enum Neq for "NEQ"
			/// </summary>
			[EnumMember(Value = "NEQ")]
			Neq,

			/// <summary>
			/// Enum Gt for "GT"
			/// </summary>
			[EnumMember(Value = "GT")]
			Gt,

			/// <summary>
			/// Enum Lt for "LT"
			/// </summary>
			[EnumMember(Value = "LT")]
			Lt,

			/// <summary>
			/// Enum Gte for "GTE"
			/// </summary>
			[EnumMember(Value = "GTE")]
			Gte,

			/// <summary>
			/// Enum Lte for "LTE"
			/// </summary>
			[EnumMember(Value = "LTE")]
			Lte,

			/// <summary>
			/// Enum In for "IN"
			/// </summary>
			[EnumMember(Value = "IN")]
			In,

			/// <summary>
			/// Enum Contains for "CONTAINS"
			/// </summary>
			[EnumMember(Value = "CONTAINS")]
			Contains,

			/// <summary>
			/// Enum Between for "BETWEEN"
			/// </summary>
			[EnumMember(Value = "BETWEEN")]
			Between,

			/// <summary>
			/// Enum BeginsWith for "BEGINS_WITH"
			/// </summary>
			[EnumMember(Value = "BEGINS_WITH")]
			BeginsWith,

			/// <summary>
			/// Enum Exists for "EXISTS"
			/// </summary>
			[EnumMember(Value = "EXISTS")]
			Exists
		}
		/// <summary>
		/// Query filter predicate operator.
		/// </summary>
		/// <value>Query filter predicate operator.</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public OperatorEnum? Operator { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFiltersPredicate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WorkitemQueryJobQueryFiltersPredicate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemQueryJobQueryFiltersPredicate" /> class.
		/// </summary>
		/// <param name="Name">Property name. (required).</param>
		/// <param name="Operator">Query filter predicate operator. (required).</param>
		/// <param name="Values">List of values to be used in the query filter predicate..</param>
		public WorkitemQueryJobQueryFiltersPredicate(string Name = null, OperatorEnum? Operator = null, List<Object> Values = null)
		{
			this.Name = Name;
			this.Operator = Operator;
			this.Values = Values;

		}



		/// <summary>
		/// Property name.
		/// </summary>
		/// <value>Property name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }





		/// <summary>
		/// List of values to be used in the query filter predicate.
		/// </summary>
		/// <value>List of values to be used in the query filter predicate.</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<Object> Values { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemQueryJobQueryFiltersPredicate {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  Values: ").Append(Values).Append("\n");
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
			return this.Equals(obj as WorkitemQueryJobQueryFiltersPredicate);
		}

		/// <summary>
		/// Returns true if WorkitemQueryJobQueryFiltersPredicate instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemQueryJobQueryFiltersPredicate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemQueryJobQueryFiltersPredicate other)
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
					this.Operator == other.Operator ||
					this.Operator != null &&
					this.Operator.Equals(other.Operator)
				) &&
				(
					this.Values == other.Values ||
					this.Values != null &&
					this.Values.SequenceEqual(other.Values)
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

				if (this.Operator != null)
					hash = hash * 59 + this.Operator.GetHashCode();

				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				return hash;
			}
		}
	}

}
