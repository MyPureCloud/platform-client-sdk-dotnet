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
    /// BillingAiSubItem
    /// </summary>
    [DataContract]
    public partial class BillingAiSubItem :  IEquatable<BillingAiSubItem>
    {
        /// <summary>
        /// Original unit of measure for the child product usage.
        /// </summary>
        /// <value>Original unit of measure for the child product usage.</value>
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
            /// Enum Ea for "EA"
            /// </summary>
            [EnumMember(Value = "EA")]
            Ea,
            
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
            /// Enum Evaluation for "Evaluation"
            /// </summary>
            [EnumMember(Value = "Evaluation")]
            Evaluation,
            
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
            /// Enum Guide for "Guide"
            /// </summary>
            [EnumMember(Value = "Guide")]
            Guide,
            
            /// <summary>
            /// Enum Hour for "Hour"
            /// </summary>
            [EnumMember(Value = "Hour")]
            Hour,
            
            /// <summary>
            /// Enum Ingestion for "Ingestion"
            /// </summary>
            [EnumMember(Value = "Ingestion")]
            Ingestion,
            
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
            /// Enum Ratetable for "RateTable"
            /// </summary>
            [EnumMember(Value = "RateTable")]
            Ratetable,
            
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
            /// Enum Summary for "Summary"
            /// </summary>
            [EnumMember(Value = "Summary")]
            Summary,
            
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
            /// Enum Translation for "Translation"
            /// </summary>
            [EnumMember(Value = "Translation")]
            Translation,
            
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
        /// Original unit of measure for the child product usage.
        /// </summary>
        /// <value>Original unit of measure for the child product usage.</value>
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public UnitOfMeasureEnum? UnitOfMeasure { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAiSubItem" /> class.
        /// </summary>
        /// <param name="ChargeName">Charge-level name of the member charge. Omitted when the source charge has no name..</param>
        /// <param name="ActualQuantity">Usage in the child product&#39;s original unit..</param>
        /// <param name="UnitOfMeasure">Original unit of measure for the child product usage..</param>
        /// <param name="ConvertedTokenCount">Child usage converted to parent-bundle tokens..</param>
        /// <param name="TokenConversionRate">Bundle tokens per one original unit..</param>
        public BillingAiSubItem(string ChargeName = null, double? ActualQuantity = null, UnitOfMeasureEnum? UnitOfMeasure = null, double? ConvertedTokenCount = null, double? TokenConversionRate = null)
        {
            this.ChargeName = ChargeName;
            this.ActualQuantity = ActualQuantity;
            this.UnitOfMeasure = UnitOfMeasure;
            this.ConvertedTokenCount = ConvertedTokenCount;
            this.TokenConversionRate = TokenConversionRate;
            
        }
        


        /// <summary>
        /// Charge-level name of the member charge. Omitted when the source charge has no name.
        /// </summary>
        /// <value>Charge-level name of the member charge. Omitted when the source charge has no name.</value>
        [DataMember(Name="chargeName", EmitDefaultValue=false)]
        public string ChargeName { get; set; }



        /// <summary>
        /// Usage in the child product&#39;s original unit.
        /// </summary>
        /// <value>Usage in the child product&#39;s original unit.</value>
        [DataMember(Name="actualQuantity", EmitDefaultValue=false)]
        public double? ActualQuantity { get; set; }





        /// <summary>
        /// Child usage converted to parent-bundle tokens.
        /// </summary>
        /// <value>Child usage converted to parent-bundle tokens.</value>
        [DataMember(Name="convertedTokenCount", EmitDefaultValue=false)]
        public double? ConvertedTokenCount { get; set; }



        /// <summary>
        /// Bundle tokens per one original unit.
        /// </summary>
        /// <value>Bundle tokens per one original unit.</value>
        [DataMember(Name="tokenConversionRate", EmitDefaultValue=false)]
        public double? TokenConversionRate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingAiSubItem {\n");

            sb.Append("  ChargeName: ").Append(ChargeName).Append("\n");
            sb.Append("  ActualQuantity: ").Append(ActualQuantity).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  ConvertedTokenCount: ").Append(ConvertedTokenCount).Append("\n");
            sb.Append("  TokenConversionRate: ").Append(TokenConversionRate).Append("\n");
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
            return this.Equals(obj as BillingAiSubItem);
        }

        /// <summary>
        /// Returns true if BillingAiSubItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingAiSubItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingAiSubItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChargeName == other.ChargeName ||
                    this.ChargeName != null &&
                    this.ChargeName.Equals(other.ChargeName)
                ) &&
                (
                    this.ActualQuantity == other.ActualQuantity ||
                    this.ActualQuantity != null &&
                    this.ActualQuantity.Equals(other.ActualQuantity)
                ) &&
                (
                    this.UnitOfMeasure == other.UnitOfMeasure ||
                    this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(other.UnitOfMeasure)
                ) &&
                (
                    this.ConvertedTokenCount == other.ConvertedTokenCount ||
                    this.ConvertedTokenCount != null &&
                    this.ConvertedTokenCount.Equals(other.ConvertedTokenCount)
                ) &&
                (
                    this.TokenConversionRate == other.TokenConversionRate ||
                    this.TokenConversionRate != null &&
                    this.TokenConversionRate.Equals(other.TokenConversionRate)
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
                if (this.ChargeName != null)
                    hash = hash * 59 + this.ChargeName.GetHashCode();

                if (this.ActualQuantity != null)
                    hash = hash * 59 + this.ActualQuantity.GetHashCode();

                if (this.UnitOfMeasure != null)
                    hash = hash * 59 + this.UnitOfMeasure.GetHashCode();

                if (this.ConvertedTokenCount != null)
                    hash = hash * 59 + this.ConvertedTokenCount.GetHashCode();

                if (this.TokenConversionRate != null)
                    hash = hash * 59 + this.TokenConversionRate.GetHashCode();

                return hash;
            }
        }
    }

}
