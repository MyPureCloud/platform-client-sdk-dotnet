using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Description of a data value returned from an intent
	/// </summary>
	[DataContract]
	public partial class BotEntity : IEquatable<BotEntity>
	{
		/// <summary>
		/// The data type of the entity.
		/// </summary>
		/// <value>The data type of the entity.</value>
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
		/// The data type of the entity.
		/// </summary>
		/// <value>The data type of the entity.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BotEntity" /> class.
		/// </summary>
		/// <param name="Name">The name of the entity..</param>
		/// <param name="Type">The data type of the entity..</param>
		public BotEntity(string Name = null, TypeEnum? Type = null)
		{
			this.Name = Name;
			this.Type = Type;

		}



		/// <summary>
		/// The name of the entity.
		/// </summary>
		/// <value>The name of the entity.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BotEntity {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return this.Equals(obj as BotEntity);
		}

		/// <summary>
		/// Returns true if BotEntity instances are equal
		/// </summary>
		/// <param name="other">Instance of BotEntity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BotEntity other)
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

				return hash;
			}
		}
	}

}
