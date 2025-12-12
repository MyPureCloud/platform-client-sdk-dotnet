using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BillingWallet
	/// </summary>
	[DataContract]
	public partial class BillingWallet : IEquatable<BillingWallet>
	{
		/// <summary>
		/// The unit of measure for the wallet.
		/// </summary>
		/// <value>The unit of measure for the wallet.</value>
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
		/// The unit of measure for the wallet.
		/// </summary>
		/// <value>The unit of measure for the wallet.</value>
		[DataMember(Name = "unitOfMeasure", EmitDefaultValue = false)]
		public UnitOfMeasureEnum? UnitOfMeasure { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BillingWallet" /> class.
		/// </summary>
		/// <param name="Organizations">A Genesys Cloud Organization and it&#39;s related plans..</param>
		/// <param name="Product">Represents the details of a product..</param>
		/// <param name="StartingBalance">The initial balance in the wallet..</param>
		/// <param name="EndingBalance">The final balance in the wallet after transactions..</param>
		/// <param name="BalanceIncrease">Total amount added to the wallet..</param>
		/// <param name="BalanceDecrease">The amount removed from the wallet due to a contract change..</param>
		/// <param name="BalanceConsumption">Total consumption deducted from the wallet..</param>
		/// <param name="BalanceOverage">The amount exceeding a predefined balance threshold..</param>
		/// <param name="BalanceOverageRate">The rate charged for an overage...</param>
		/// <param name="BalanceOverageCharge">The amount to be charged..</param>
		/// <param name="BalanceOverageCurrency">The currency in which the overage charge is invoiced..</param>
		/// <param name="UnitOfMeasure">The unit of measure for the wallet..</param>
		public BillingWallet(List<NamedEntity> Organizations = null, BillingProduct Product = null, double? StartingBalance = null, double? EndingBalance = null, double? BalanceIncrease = null, double? BalanceDecrease = null, double? BalanceConsumption = null, double? BalanceOverage = null, double? BalanceOverageRate = null, double? BalanceOverageCharge = null, string BalanceOverageCurrency = null, UnitOfMeasureEnum? UnitOfMeasure = null)
		{
			this.Organizations = Organizations;
			this.Product = Product;
			this.StartingBalance = StartingBalance;
			this.EndingBalance = EndingBalance;
			this.BalanceIncrease = BalanceIncrease;
			this.BalanceDecrease = BalanceDecrease;
			this.BalanceConsumption = BalanceConsumption;
			this.BalanceOverage = BalanceOverage;
			this.BalanceOverageRate = BalanceOverageRate;
			this.BalanceOverageCharge = BalanceOverageCharge;
			this.BalanceOverageCurrency = BalanceOverageCurrency;
			this.UnitOfMeasure = UnitOfMeasure;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the object.
		/// </summary>
		/// <value>The name of the object.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; private set; }



		/// <summary>
		/// A Genesys Cloud Organization and it&#39;s related plans.
		/// </summary>
		/// <value>A Genesys Cloud Organization and it&#39;s related plans.</value>
		[DataMember(Name = "organizations", EmitDefaultValue = false)]
		public List<NamedEntity> Organizations { get; set; }



		/// <summary>
		/// Represents the details of a product.
		/// </summary>
		/// <value>Represents the details of a product.</value>
		[DataMember(Name = "product", EmitDefaultValue = false)]
		public BillingProduct Product { get; set; }



		/// <summary>
		/// The initial balance in the wallet.
		/// </summary>
		/// <value>The initial balance in the wallet.</value>
		[DataMember(Name = "startingBalance", EmitDefaultValue = false)]
		public double? StartingBalance { get; set; }



		/// <summary>
		/// The final balance in the wallet after transactions.
		/// </summary>
		/// <value>The final balance in the wallet after transactions.</value>
		[DataMember(Name = "endingBalance", EmitDefaultValue = false)]
		public double? EndingBalance { get; set; }



		/// <summary>
		/// Total amount added to the wallet.
		/// </summary>
		/// <value>Total amount added to the wallet.</value>
		[DataMember(Name = "balanceIncrease", EmitDefaultValue = false)]
		public double? BalanceIncrease { get; set; }



		/// <summary>
		/// The amount removed from the wallet due to a contract change.
		/// </summary>
		/// <value>The amount removed from the wallet due to a contract change.</value>
		[DataMember(Name = "balanceDecrease", EmitDefaultValue = false)]
		public double? BalanceDecrease { get; set; }



		/// <summary>
		/// Total consumption deducted from the wallet.
		/// </summary>
		/// <value>Total consumption deducted from the wallet.</value>
		[DataMember(Name = "balanceConsumption", EmitDefaultValue = false)]
		public double? BalanceConsumption { get; set; }



		/// <summary>
		/// The amount exceeding a predefined balance threshold.
		/// </summary>
		/// <value>The amount exceeding a predefined balance threshold.</value>
		[DataMember(Name = "balanceOverage", EmitDefaultValue = false)]
		public double? BalanceOverage { get; set; }



		/// <summary>
		/// The rate charged for an overage..
		/// </summary>
		/// <value>The rate charged for an overage..</value>
		[DataMember(Name = "balanceOverageRate", EmitDefaultValue = false)]
		public double? BalanceOverageRate { get; set; }



		/// <summary>
		/// The amount to be charged.
		/// </summary>
		/// <value>The amount to be charged.</value>
		[DataMember(Name = "balanceOverageCharge", EmitDefaultValue = false)]
		public double? BalanceOverageCharge { get; set; }



		/// <summary>
		/// The currency in which the overage charge is invoiced.
		/// </summary>
		/// <value>The currency in which the overage charge is invoiced.</value>
		[DataMember(Name = "balanceOverageCurrency", EmitDefaultValue = false)]
		public string BalanceOverageCurrency { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BillingWallet {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Organizations: ").Append(Organizations).Append("\n");
			sb.Append("  Product: ").Append(Product).Append("\n");
			sb.Append("  StartingBalance: ").Append(StartingBalance).Append("\n");
			sb.Append("  EndingBalance: ").Append(EndingBalance).Append("\n");
			sb.Append("  BalanceIncrease: ").Append(BalanceIncrease).Append("\n");
			sb.Append("  BalanceDecrease: ").Append(BalanceDecrease).Append("\n");
			sb.Append("  BalanceConsumption: ").Append(BalanceConsumption).Append("\n");
			sb.Append("  BalanceOverage: ").Append(BalanceOverage).Append("\n");
			sb.Append("  BalanceOverageRate: ").Append(BalanceOverageRate).Append("\n");
			sb.Append("  BalanceOverageCharge: ").Append(BalanceOverageCharge).Append("\n");
			sb.Append("  BalanceOverageCurrency: ").Append(BalanceOverageCurrency).Append("\n");
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
			return this.Equals(obj as BillingWallet);
		}

		/// <summary>
		/// Returns true if BillingWallet instances are equal
		/// </summary>
		/// <param name="other">Instance of BillingWallet to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BillingWallet other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Organizations == other.Organizations ||
					this.Organizations != null &&
					this.Organizations.SequenceEqual(other.Organizations)
				) &&
				(
					this.Product == other.Product ||
					this.Product != null &&
					this.Product.Equals(other.Product)
				) &&
				(
					this.StartingBalance == other.StartingBalance ||
					this.StartingBalance != null &&
					this.StartingBalance.Equals(other.StartingBalance)
				) &&
				(
					this.EndingBalance == other.EndingBalance ||
					this.EndingBalance != null &&
					this.EndingBalance.Equals(other.EndingBalance)
				) &&
				(
					this.BalanceIncrease == other.BalanceIncrease ||
					this.BalanceIncrease != null &&
					this.BalanceIncrease.Equals(other.BalanceIncrease)
				) &&
				(
					this.BalanceDecrease == other.BalanceDecrease ||
					this.BalanceDecrease != null &&
					this.BalanceDecrease.Equals(other.BalanceDecrease)
				) &&
				(
					this.BalanceConsumption == other.BalanceConsumption ||
					this.BalanceConsumption != null &&
					this.BalanceConsumption.Equals(other.BalanceConsumption)
				) &&
				(
					this.BalanceOverage == other.BalanceOverage ||
					this.BalanceOverage != null &&
					this.BalanceOverage.Equals(other.BalanceOverage)
				) &&
				(
					this.BalanceOverageRate == other.BalanceOverageRate ||
					this.BalanceOverageRate != null &&
					this.BalanceOverageRate.Equals(other.BalanceOverageRate)
				) &&
				(
					this.BalanceOverageCharge == other.BalanceOverageCharge ||
					this.BalanceOverageCharge != null &&
					this.BalanceOverageCharge.Equals(other.BalanceOverageCharge)
				) &&
				(
					this.BalanceOverageCurrency == other.BalanceOverageCurrency ||
					this.BalanceOverageCurrency != null &&
					this.BalanceOverageCurrency.Equals(other.BalanceOverageCurrency)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Organizations != null)
					hash = hash * 59 + this.Organizations.GetHashCode();

				if (this.Product != null)
					hash = hash * 59 + this.Product.GetHashCode();

				if (this.StartingBalance != null)
					hash = hash * 59 + this.StartingBalance.GetHashCode();

				if (this.EndingBalance != null)
					hash = hash * 59 + this.EndingBalance.GetHashCode();

				if (this.BalanceIncrease != null)
					hash = hash * 59 + this.BalanceIncrease.GetHashCode();

				if (this.BalanceDecrease != null)
					hash = hash * 59 + this.BalanceDecrease.GetHashCode();

				if (this.BalanceConsumption != null)
					hash = hash * 59 + this.BalanceConsumption.GetHashCode();

				if (this.BalanceOverage != null)
					hash = hash * 59 + this.BalanceOverage.GetHashCode();

				if (this.BalanceOverageRate != null)
					hash = hash * 59 + this.BalanceOverageRate.GetHashCode();

				if (this.BalanceOverageCharge != null)
					hash = hash * 59 + this.BalanceOverageCharge.GetHashCode();

				if (this.BalanceOverageCurrency != null)
					hash = hash * 59 + this.BalanceOverageCurrency.GetHashCode();

				if (this.UnitOfMeasure != null)
					hash = hash * 59 + this.UnitOfMeasure.GetHashCode();

				return hash;
			}
		}
	}

}
