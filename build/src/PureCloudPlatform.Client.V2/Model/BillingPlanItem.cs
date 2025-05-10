using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BillingPlanItem
    /// </summary>
    [DataContract]
    public partial class BillingPlanItem :  IEquatable<BillingPlanItem>
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
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum? UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlanItem" /> class.
        /// </summary>
        /// <param name="ItemNumber">Item number..</param>
        /// <param name="Name">Name of the item..</param>
        /// <param name="Type">Type of the item..</param>
        /// <param name="Function">Function of the item..</param>
        /// <param name="Description">Detailed description of the item..</param>
        /// <param name="DateChargedThrough">The date through which a customer has been billed for the charge. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="CurrencyIsoCode">Contains the ISO code for any currency allowed by the organization..</param>
        /// <param name="DiscountAmount">The amount of the discount..</param>
        /// <param name="DateEffectiveStart">The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateEffectiveEnd">The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="OveragePrice">The price for units over the allowed amount..</param>
        /// <param name="Price">The price associated with the item expressed as a decimal..</param>
        /// <param name="Quantity">The quantity of units..</param>
        /// <param name="UnitOfMeasure">The unit of measure for the wallet..</param>
        public BillingPlanItem(string ItemNumber = null, string Name = null, string Type = null, string Function = null, string Description = null, String DateChargedThrough = null, string CurrencyIsoCode = null, double? DiscountAmount = null, String DateEffectiveStart = null, String DateEffectiveEnd = null, double? OveragePrice = null, double? Price = null, int? Quantity = null, UnitOfMeasureEnum? UnitOfMeasure = null)
        {
            this.ItemNumber = ItemNumber;
            this.Name = Name;
            this.Type = Type;
            this.Function = Function;
            this.Description = Description;
            this.DateChargedThrough = DateChargedThrough;
            this.CurrencyIsoCode = CurrencyIsoCode;
            this.DiscountAmount = DiscountAmount;
            this.DateEffectiveStart = DateEffectiveStart;
            this.DateEffectiveEnd = DateEffectiveEnd;
            this.OveragePrice = OveragePrice;
            this.Price = Price;
            this.Quantity = Quantity;
            this.UnitOfMeasure = UnitOfMeasure;
            
        }
        


        /// <summary>
        /// Item number.
        /// </summary>
        /// <value>Item number.</value>
        [DataMember(Name="itemNumber", EmitDefaultValue=false)]
        public string ItemNumber { get; set; }



        /// <summary>
        /// Name of the item.
        /// </summary>
        /// <value>Name of the item.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Type of the item.
        /// </summary>
        /// <value>Type of the item.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// Function of the item.
        /// </summary>
        /// <value>Function of the item.</value>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public string Function { get; set; }



        /// <summary>
        /// Detailed description of the item.
        /// </summary>
        /// <value>Detailed description of the item.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The date through which a customer has been billed for the charge. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date through which a customer has been billed for the charge. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateChargedThrough", EmitDefaultValue=false)]
        public String DateChargedThrough { get; set; }



        /// <summary>
        /// Contains the ISO code for any currency allowed by the organization.
        /// </summary>
        /// <value>Contains the ISO code for any currency allowed by the organization.</value>
        [DataMember(Name="currencyIsoCode", EmitDefaultValue=false)]
        public string CurrencyIsoCode { get; set; }



        /// <summary>
        /// The amount of the discount.
        /// </summary>
        /// <value>The amount of the discount.</value>
        [DataMember(Name="discountAmount", EmitDefaultValue=false)]
        public double? DiscountAmount { get; set; }



        /// <summary>
        /// The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEffectiveStart", EmitDefaultValue=false)]
        public String DateEffectiveStart { get; set; }



        /// <summary>
        /// The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date when the Address became effective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEffectiveEnd", EmitDefaultValue=false)]
        public String DateEffectiveEnd { get; set; }



        /// <summary>
        /// The price for units over the allowed amount.
        /// </summary>
        /// <value>The price for units over the allowed amount.</value>
        [DataMember(Name="overagePrice", EmitDefaultValue=false)]
        public double? OveragePrice { get; set; }



        /// <summary>
        /// The price associated with the item expressed as a decimal.
        /// </summary>
        /// <value>The price associated with the item expressed as a decimal.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }



        /// <summary>
        /// The quantity of units.
        /// </summary>
        /// <value>The quantity of units.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPlanItem {\n");

            sb.Append("  ItemNumber: ").Append(ItemNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateChargedThrough: ").Append(DateChargedThrough).Append("\n");
            sb.Append("  CurrencyIsoCode: ").Append(CurrencyIsoCode).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DateEffectiveStart: ").Append(DateEffectiveStart).Append("\n");
            sb.Append("  DateEffectiveEnd: ").Append(DateEffectiveEnd).Append("\n");
            sb.Append("  OveragePrice: ").Append(OveragePrice).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(obj as BillingPlanItem);
        }

        /// <summary>
        /// Returns true if BillingPlanItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPlanItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPlanItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ItemNumber == other.ItemNumber ||
                    this.ItemNumber != null &&
                    this.ItemNumber.Equals(other.ItemNumber)
                ) &&
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
                    this.Function == other.Function ||
                    this.Function != null &&
                    this.Function.Equals(other.Function)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DateChargedThrough == other.DateChargedThrough ||
                    this.DateChargedThrough != null &&
                    this.DateChargedThrough.Equals(other.DateChargedThrough)
                ) &&
                (
                    this.CurrencyIsoCode == other.CurrencyIsoCode ||
                    this.CurrencyIsoCode != null &&
                    this.CurrencyIsoCode.Equals(other.CurrencyIsoCode)
                ) &&
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) &&
                (
                    this.DateEffectiveStart == other.DateEffectiveStart ||
                    this.DateEffectiveStart != null &&
                    this.DateEffectiveStart.Equals(other.DateEffectiveStart)
                ) &&
                (
                    this.DateEffectiveEnd == other.DateEffectiveEnd ||
                    this.DateEffectiveEnd != null &&
                    this.DateEffectiveEnd.Equals(other.DateEffectiveEnd)
                ) &&
                (
                    this.OveragePrice == other.OveragePrice ||
                    this.OveragePrice != null &&
                    this.OveragePrice.Equals(other.OveragePrice)
                ) &&
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
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
                if (this.ItemNumber != null)
                    hash = hash * 59 + this.ItemNumber.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Function != null)
                    hash = hash * 59 + this.Function.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateChargedThrough != null)
                    hash = hash * 59 + this.DateChargedThrough.GetHashCode();

                if (this.CurrencyIsoCode != null)
                    hash = hash * 59 + this.CurrencyIsoCode.GetHashCode();

                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();

                if (this.DateEffectiveStart != null)
                    hash = hash * 59 + this.DateEffectiveStart.GetHashCode();

                if (this.DateEffectiveEnd != null)
                    hash = hash * 59 + this.DateEffectiveEnd.GetHashCode();

                if (this.OveragePrice != null)
                    hash = hash * 59 + this.OveragePrice.GetHashCode();

                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();

                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();

                if (this.UnitOfMeasure != null)
                    hash = hash * 59 + this.UnitOfMeasure.GetHashCode();

                return hash;
            }
        }
    }

}
