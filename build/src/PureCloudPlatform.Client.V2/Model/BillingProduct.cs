using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BillingProduct
	/// </summary>
	[DataContract]
	public partial class BillingProduct : IEquatable<BillingProduct>
	{
		/// <summary>
		/// The unit of measure for the product.
		/// </summary>
		/// <value>The unit of measure for the product.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum UnitOfMeasureEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Call for "Call"
			/// </summary>
			[EnumMember(Value = "Call")]
			Call,

			/// <summary>
			/// Enum Character for "Character"
			/// </summary>
			[EnumMember(Value = "Character")]
			Character,

			/// <summary>
			/// Enum Conversation for "Conversation"
			/// </summary>
			[EnumMember(Value = "Conversation")]
			Conversation,

			/// <summary>
			/// Enum Course for "Course"
			/// </summary>
			[EnumMember(Value = "Course")]
			Course,

			/// <summary>
			/// Enum Day for "Day"
			/// </summary>
			[EnumMember(Value = "Day")]
			Day,

			/// <summary>
			/// Enum Each for "Each"
			/// </summary>
			[EnumMember(Value = "Each")]
			Each,

			/// <summary>
			/// Enum Employee for "Employee"
			/// </summary>
			[EnumMember(Value = "Employee")]
			Employee,

			/// <summary>
			/// Enum Engagement for "Engagement"
			/// </summary>
			[EnumMember(Value = "Engagement")]
			Engagement,

			/// <summary>
			/// Enum Event for "Event"
			/// </summary>
			[EnumMember(Value = "Event")]
			Event,

			/// <summary>
			/// Enum Exam for "Exam"
			/// </summary>
			[EnumMember(Value = "Exam")]
			Exam,

			/// <summary>
			/// Enum Gb for "GB"
			/// </summary>
			[EnumMember(Value = "GB")]
			Gb,

			/// <summary>
			/// Enum Hour for "Hour"
			/// </summary>
			[EnumMember(Value = "Hour")]
			Hour,

			/// <summary>
			/// Enum Instance for "Instance"
			/// </summary>
			[EnumMember(Value = "Instance")]
			Instance,

			/// <summary>
			/// Enum Interaction for "Interaction"
			/// </summary>
			[EnumMember(Value = "Interaction")]
			Interaction,

			/// <summary>
			/// Enum Invocation for "Invocation"
			/// </summary>
			[EnumMember(Value = "Invocation")]
			Invocation,

			/// <summary>
			/// Enum Message for "Message"
			/// </summary>
			[EnumMember(Value = "Message")]
			Message,

			/// <summary>
			/// Enum Millioncharacters for "MillionCharacters"
			/// </summary>
			[EnumMember(Value = "MillionCharacters")]
			Millioncharacters,

			/// <summary>
			/// Enum Minute for "Minute"
			/// </summary>
			[EnumMember(Value = "Minute")]
			Minute,

			/// <summary>
			/// Enum Person for "Person"
			/// </summary>
			[EnumMember(Value = "Person")]
			Person,

			/// <summary>
			/// Enum Phonenumber for "PhoneNumber"
			/// </summary>
			[EnumMember(Value = "PhoneNumber")]
			Phonenumber,

			/// <summary>
			/// Enum Port for "Port"
			/// </summary>
			[EnumMember(Value = "Port")]
			Port,

			/// <summary>
			/// Enum Segment for "Segment"
			/// </summary>
			[EnumMember(Value = "Segment")]
			Segment,

			/// <summary>
			/// Enum Session for "Session"
			/// </summary>
			[EnumMember(Value = "Session")]
			Session,

			/// <summary>
			/// Enum Stream for "Stream"
			/// </summary>
			[EnumMember(Value = "Stream")]
			Stream,

			/// <summary>
			/// Enum Token for "Token"
			/// </summary>
			[EnumMember(Value = "Token")]
			Token,

			/// <summary>
			/// Enum Transaction for "Transaction"
			/// </summary>
			[EnumMember(Value = "Transaction")]
			Transaction,

			/// <summary>
			/// Enum Turn for "Turn"
			/// </summary>
			[EnumMember(Value = "Turn")]
			Turn,

			/// <summary>
			/// Enum Unit for "Unit"
			/// </summary>
			[EnumMember(Value = "Unit")]
			Unit,

			/// <summary>
			/// Enum User for "User"
			/// </summary>
			[EnumMember(Value = "User")]
			User
		}
		/// <summary>
		/// The unit of measure for the product.
		/// </summary>
		/// <value>The unit of measure for the product.</value>
		[DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
		public UnitOfMeasureEnum? UnitOfMeasure { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BillingProduct" /> class.
		/// </summary>
		/// <param name="Sku">The product associated with the fund..</param>
		/// <param name="Name">The name of the product..</param>
		/// <param name="UnitOfMeasure">The unit of measure for the product..</param>
		public BillingProduct(string Sku = null, string Name = null, UnitOfMeasureEnum? UnitOfMeasure = null)
		{
			this.Sku = Sku;
			this.Name = Name;
			this.UnitOfMeasure = UnitOfMeasure;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The product associated with the fund.
		/// </summary>
		/// <value>The product associated with the fund.</value>
		[DataMember(Name = "sku", EmitDefaultValue = false)]
		public string Sku { get; set; }



		/// <summary>
		/// The name of the product.
		/// </summary>
		/// <value>The name of the product.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BillingProduct {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Sku: ").Append(Sku).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
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
			return this.Equals(obj as BillingProduct);
		}

		/// <summary>
		/// Returns true if BillingProduct instances are equal
		/// </summary>
		/// <param name="other">Instance of BillingProduct to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BillingProduct other)
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
					this.Sku == other.Sku ||
					this.Sku != null &&
					this.Sku.Equals(other.Sku)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.UnitOfMeasure == other.UnitOfMeasure ||
					this.UnitOfMeasure != null &&
					this.UnitOfMeasure.Equals(other.UnitOfMeasure)
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

				if (this.Sku != null)
					hash = hash * 59 + this.Sku.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.UnitOfMeasure != null)
					hash = hash * 59 + this.UnitOfMeasure.GetHashCode();

				return hash;
			}
		}
	}

}
