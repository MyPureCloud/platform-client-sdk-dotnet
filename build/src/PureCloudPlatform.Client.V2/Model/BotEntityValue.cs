using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BotEntityValue
	/// </summary>
	[DataContract]
	public partial class BotEntityValue : IEquatable<BotEntityValue>
	{
		/// <summary>
		/// The data type of the entity. Valid types include: String, Integer, Decimal, Boolean, Duration, Datetime, Currency, StringCollection, IntegerCollection, DecimalCollection, BooleanCollection, DurationCollection, DatetimeCollection, CurrencyCollection.
		/// </summary>
		/// <value>The data type of the entity. Valid types include: String, Integer, Decimal, Boolean, Duration, Datetime, Currency, StringCollection, IntegerCollection, DecimalCollection, BooleanCollection, DurationCollection, DatetimeCollection, CurrencyCollection.</value>
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
			/// Enum String for "String"
			/// </summary>
			[EnumMember(Value = "String")]
			String,

			/// <summary>
			/// Enum Integer for "Integer"
			/// </summary>
			[EnumMember(Value = "Integer")]
			Integer,

			/// <summary>
			/// Enum Decimal for "Decimal"
			/// </summary>
			[EnumMember(Value = "Decimal")]
			Decimal,

			/// <summary>
			/// Enum Duration for "Duration"
			/// </summary>
			[EnumMember(Value = "Duration")]
			Duration,

			/// <summary>
			/// Enum Boolean for "Boolean"
			/// </summary>
			[EnumMember(Value = "Boolean")]
			Boolean,

			/// <summary>
			/// Enum Currency for "Currency"
			/// </summary>
			[EnumMember(Value = "Currency")]
			Currency,

			/// <summary>
			/// Enum Datetime for "Datetime"
			/// </summary>
			[EnumMember(Value = "Datetime")]
			Datetime,

			/// <summary>
			/// Enum Stringcollection for "StringCollection"
			/// </summary>
			[EnumMember(Value = "StringCollection")]
			Stringcollection,

			/// <summary>
			/// Enum Integercollection for "IntegerCollection"
			/// </summary>
			[EnumMember(Value = "IntegerCollection")]
			Integercollection,

			/// <summary>
			/// Enum Decimalcollection for "DecimalCollection"
			/// </summary>
			[EnumMember(Value = "DecimalCollection")]
			Decimalcollection,

			/// <summary>
			/// Enum Durationcollection for "DurationCollection"
			/// </summary>
			[EnumMember(Value = "DurationCollection")]
			Durationcollection,

			/// <summary>
			/// Enum Booleancollection for "BooleanCollection"
			/// </summary>
			[EnumMember(Value = "BooleanCollection")]
			Booleancollection,

			/// <summary>
			/// Enum Currencycollection for "CurrencyCollection"
			/// </summary>
			[EnumMember(Value = "CurrencyCollection")]
			Currencycollection,

			/// <summary>
			/// Enum Datetimecollection for "DatetimeCollection"
			/// </summary>
			[EnumMember(Value = "DatetimeCollection")]
			Datetimecollection
		}
		/// <summary>
		/// The data type of the entity. Valid types include: String, Integer, Decimal, Boolean, Duration, Datetime, Currency, StringCollection, IntegerCollection, DecimalCollection, BooleanCollection, DurationCollection, DatetimeCollection, CurrencyCollection.
		/// </summary>
		/// <value>The data type of the entity. Valid types include: String, Integer, Decimal, Boolean, Duration, Datetime, Currency, StringCollection, IntegerCollection, DecimalCollection, BooleanCollection, DurationCollection, DatetimeCollection, CurrencyCollection.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="BotEntityValue" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BotEntityValue() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BotEntityValue" /> class.
		/// </summary>
		/// <param name="Name">The name of the entity. (required).</param>
		/// <param name="Type">The data type of the entity. Valid types include: String, Integer, Decimal, Boolean, Duration, Datetime, Currency, StringCollection, IntegerCollection, DecimalCollection, BooleanCollection, DurationCollection, DatetimeCollection, CurrencyCollection. (required).</param>
		/// <param name="Value">The string value of the entity for simple types. Required when using non-collection types. Format depends on the &#39;type&#39; field: String: \&quot;any text\&quot;; Integer: whole number (e.g., \&quot;42\&quot;); Decimal: number with optional decimal point (e.g., \&quot;42.5\&quot;); Boolean: \&quot;true\&quot; or \&quot;false\&quot;; Duration: ISO-8601 duration format (e.g., \&quot;PT1H30M\&quot; for 1 hour and 30 minutes); Datetime: ISO-8601 datetime format (e.g., \&quot;2023-04-15T14:30:00Z\&quot;); Currency: JSON object with &#39;amount&#39; and &#39;code&#39; fields as an escaped JSON string (e.g., \&quot;{\\\&quot;amount\\\&quot;:10.50,\\\&quot;code\\\&quot;:\\\&quot;USD\\\&quot;}\&quot; - note the escaped quotes)..</param>
		/// <param name="Values">The collection values for collection types. Required when using collection types. Each value must follow the format of its base type: StringCollection: array of strings; IntegerCollection: array of integer strings (e.g., [\&quot;1\&quot;, \&quot;2\&quot;, \&quot;3\&quot;]); DecimalCollection: array of decimal strings (e.g., [\&quot;1.5\&quot;, \&quot;2.0\&quot;, \&quot;3.75\&quot;]); BooleanCollection: array of boolean strings (e.g., [\&quot;true\&quot;, \&quot;false\&quot;]); DurationCollection: array of ISO-8601 duration strings; DatetimeCollection: array of ISO-8601 datetime strings; CurrencyCollection: array of escaped JSON currency object strings (e.g., [\&quot;{\\\&quot;amount\\\&quot;:10.50,\\\&quot;code\\\&quot;:\\\&quot;USD\\\&quot;}\&quot;, \&quot;{\\\&quot;amount\\\&quot;:25.00,\\\&quot;code\\\&quot;:\\\&quot;EUR\\\&quot;}\&quot;] - note the escaped quotes)..</param>
		public BotEntityValue(string Name = null, TypeEnum? Type = null, string Value = null, List<string> Values = null)
		{
			this.Name = Name;
			this.Type = Type;
			this.Value = Value;
			this.Values = Values;

		}



		/// <summary>
		/// The name of the entity.
		/// </summary>
		/// <value>The name of the entity.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }





		/// <summary>
		/// The string value of the entity for simple types. Required when using non-collection types. Format depends on the &#39;type&#39; field: String: \&quot;any text\&quot;; Integer: whole number (e.g., \&quot;42\&quot;); Decimal: number with optional decimal point (e.g., \&quot;42.5\&quot;); Boolean: \&quot;true\&quot; or \&quot;false\&quot;; Duration: ISO-8601 duration format (e.g., \&quot;PT1H30M\&quot; for 1 hour and 30 minutes); Datetime: ISO-8601 datetime format (e.g., \&quot;2023-04-15T14:30:00Z\&quot;); Currency: JSON object with &#39;amount&#39; and &#39;code&#39; fields as an escaped JSON string (e.g., \&quot;{\\\&quot;amount\\\&quot;:10.50,\\\&quot;code\\\&quot;:\\\&quot;USD\\\&quot;}\&quot; - note the escaped quotes).
		/// </summary>
		/// <value>The string value of the entity for simple types. Required when using non-collection types. Format depends on the &#39;type&#39; field: String: \&quot;any text\&quot;; Integer: whole number (e.g., \&quot;42\&quot;); Decimal: number with optional decimal point (e.g., \&quot;42.5\&quot;); Boolean: \&quot;true\&quot; or \&quot;false\&quot;; Duration: ISO-8601 duration format (e.g., \&quot;PT1H30M\&quot; for 1 hour and 30 minutes); Datetime: ISO-8601 datetime format (e.g., \&quot;2023-04-15T14:30:00Z\&quot;); Currency: JSON object with &#39;amount&#39; and &#39;code&#39; fields as an escaped JSON string (e.g., \&quot;{\\\&quot;amount\\\&quot;:10.50,\\\&quot;code\\\&quot;:\\\&quot;USD\\\&quot;}\&quot; - note the escaped quotes).</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }



		/// <summary>
		/// The collection values for collection types. Required when using collection types. Each value must follow the format of its base type: StringCollection: array of strings; IntegerCollection: array of integer strings (e.g., [\&quot;1\&quot;, \&quot;2\&quot;, \&quot;3\&quot;]); DecimalCollection: array of decimal strings (e.g., [\&quot;1.5\&quot;, \&quot;2.0\&quot;, \&quot;3.75\&quot;]); BooleanCollection: array of boolean strings (e.g., [\&quot;true\&quot;, \&quot;false\&quot;]); DurationCollection: array of ISO-8601 duration strings; DatetimeCollection: array of ISO-8601 datetime strings; CurrencyCollection: array of escaped JSON currency object strings (e.g., [\&quot;{\\\&quot;amount\\\&quot;:10.50,\\\&quot;code\\\&quot;:\\\&quot;USD\\\&quot;}\&quot;, \&quot;{\\\&quot;amount\\\&quot;:25.00,\\\&quot;code\\\&quot;:\\\&quot;EUR\\\&quot;}\&quot;] - note the escaped quotes).
		/// </summary>
		/// <value>The collection values for collection types. Required when using collection types. Each value must follow the format of its base type: StringCollection: array of strings; IntegerCollection: array of integer strings (e.g., [\&quot;1\&quot;, \&quot;2\&quot;, \&quot;3\&quot;]); DecimalCollection: array of decimal strings (e.g., [\&quot;1.5\&quot;, \&quot;2.0\&quot;, \&quot;3.75\&quot;]); BooleanCollection: array of boolean strings (e.g., [\&quot;true\&quot;, \&quot;false\&quot;]); DurationCollection: array of ISO-8601 duration strings; DatetimeCollection: array of ISO-8601 datetime strings; CurrencyCollection: array of escaped JSON currency object strings (e.g., [\&quot;{\\\&quot;amount\\\&quot;:10.50,\\\&quot;code\\\&quot;:\\\&quot;USD\\\&quot;}\&quot;, \&quot;{\\\&quot;amount\\\&quot;:25.00,\\\&quot;code\\\&quot;:\\\&quot;EUR\\\&quot;}\&quot;] - note the escaped quotes).</value>
		[DataMember(Name = "values", EmitDefaultValue = false)]
		public List<string> Values { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BotEntityValue {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as BotEntityValue);
		}

		/// <summary>
		/// Returns true if BotEntityValue instances are equal
		/// </summary>
		/// <param name="other">Instance of BotEntityValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BotEntityValue other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				if (this.Values != null)
					hash = hash * 59 + this.Values.GetHashCode();

				return hash;
			}
		}
	}

}
