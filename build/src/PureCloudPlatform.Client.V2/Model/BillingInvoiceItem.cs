using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BillingInvoiceItem
	/// </summary>
	[DataContract]
	public partial class BillingInvoiceItem : IEquatable<BillingInvoiceItem>
	{
		/// <summary>
		/// Unit of Measure.
		/// </summary>
		/// <value>Unit of Measure.</value>
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
		/// Unit of Measure.
		/// </summary>
		/// <value>Unit of Measure.</value>
		[DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
		public UnitOfMeasureEnum? UnitOfMeasure { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BillingInvoiceItem" /> class.
		/// </summary>
		/// <param name="Product">Represents the details of a product..</param>
		/// <param name="Description">Line Item Description..</param>
		/// <param name="DateTransacted">Invoice transaction date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="DateStart">Invoice start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="DateEnd">Invoice end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="Organization">A Genesys Cloud Organization..</param>
		/// <param name="Quantity">Quantity of the item..</param>
		/// <param name="UnitOfMeasure">Unit of Measure..</param>
		/// <param name="Amount">Amount..</param>
		public BillingInvoiceItem(BillingProduct Product = null, string Description = null, String DateTransacted = null, String DateStart = null, String DateEnd = null, NamedEntity Organization = null, int? Quantity = null, UnitOfMeasureEnum? UnitOfMeasure = null, double? Amount = null)
		{
			this.Product = Product;
			this.Description = Description;
			this.DateTransacted = DateTransacted;
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.Organization = Organization;
			this.Quantity = Quantity;
			this.UnitOfMeasure = UnitOfMeasure;
			this.Amount = Amount;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Represents the details of a product.
		/// </summary>
		/// <value>Represents the details of a product.</value>
		[DataMember(Name = "product", EmitDefaultValue = false)]
		public BillingProduct Product { get; set; }



		/// <summary>
		/// Line Item Description.
		/// </summary>
		/// <value>Line Item Description.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Invoice transaction date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Invoice transaction date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateTransacted", EmitDefaultValue = false)]
		public String DateTransacted { get; set; }



		/// <summary>
		/// Invoice start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Invoice start date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public String DateStart { get; set; }



		/// <summary>
		/// Invoice end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Invoice end date. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEnd", EmitDefaultValue = false)]
		public String DateEnd { get; set; }



		/// <summary>
		/// A Genesys Cloud Organization.
		/// </summary>
		/// <value>A Genesys Cloud Organization.</value>
		[DataMember(Name = "organization", EmitDefaultValue = false)]
		public NamedEntity Organization { get; set; }



		/// <summary>
		/// Quantity of the item.
		/// </summary>
		/// <value>Quantity of the item.</value>
		[DataMember(Name = "quantity", EmitDefaultValue = false)]
		public int? Quantity { get; set; }





		/// <summary>
		/// Amount.
		/// </summary>
		/// <value>Amount.</value>
		[DataMember(Name = "amount", EmitDefaultValue = false)]
		public double? Amount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BillingInvoiceItem {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Product: ").Append(Product).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  DateTransacted: ").Append(DateTransacted).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
			sb.Append("  Organization: ").Append(Organization).Append("\n");
			sb.Append("  Quantity: ").Append(Quantity).Append("\n");
			sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
			sb.Append("  Amount: ").Append(Amount).Append("\n");
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
			return this.Equals(obj as BillingInvoiceItem);
		}

		/// <summary>
		/// Returns true if BillingInvoiceItem instances are equal
		/// </summary>
		/// <param name="other">Instance of BillingInvoiceItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BillingInvoiceItem other)
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
					this.Product == other.Product ||
					this.Product != null &&
					this.Product.Equals(other.Product)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.DateTransacted == other.DateTransacted ||
					this.DateTransacted != null &&
					this.DateTransacted.Equals(other.DateTransacted)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.DateEnd == other.DateEnd ||
					this.DateEnd != null &&
					this.DateEnd.Equals(other.DateEnd)
				) &&
				(
					this.Organization == other.Organization ||
					this.Organization != null &&
					this.Organization.Equals(other.Organization)
				) &&
				(
					this.Quantity == other.Quantity ||
					this.Quantity != null &&
					this.Quantity.Equals(other.Quantity)
				) &&
				(
					this.UnitOfMeasure == other.UnitOfMeasure ||
					this.UnitOfMeasure != null &&
					this.UnitOfMeasure.Equals(other.UnitOfMeasure)
				) &&
				(
					this.Amount == other.Amount ||
					this.Amount != null &&
					this.Amount.Equals(other.Amount)
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

				if (this.Product != null)
					hash = hash * 59 + this.Product.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.DateTransacted != null)
					hash = hash * 59 + this.DateTransacted.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.DateEnd != null)
					hash = hash * 59 + this.DateEnd.GetHashCode();

				if (this.Organization != null)
					hash = hash * 59 + this.Organization.GetHashCode();

				if (this.Quantity != null)
					hash = hash * 59 + this.Quantity.GetHashCode();

				if (this.UnitOfMeasure != null)
					hash = hash * 59 + this.UnitOfMeasure.GetHashCode();

				if (this.Amount != null)
					hash = hash * 59 + this.Amount.GetHashCode();

				return hash;
			}
		}
	}

}
