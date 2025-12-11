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
    /// ActivationTrigger
    /// </summary>
    [DataContract]
    public partial class ActivationTrigger :  IEquatable<ActivationTrigger>
    {
        /// <summary>
        /// Trigger type that activated this checklist.
        /// </summary>
        /// <value>Trigger type that activated this checklist.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TriggerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Intent for "Intent"
            /// </summary>
            [EnumMember(Value = "Intent")]
            Intent,
            
            /// <summary>
            /// Enum Conversationstart for "ConversationStart"
            /// </summary>
            [EnumMember(Value = "ConversationStart")]
            Conversationstart
        }
        /// <summary>
        /// Trigger type that activated this checklist.
        /// </summary>
        /// <value>Trigger type that activated this checklist.</value>
        [DataMember(Name="triggerType", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivationTrigger" /> class.
        /// </summary>
        /// <param name="TriggerType">Trigger type that activated this checklist..</param>
        /// <param name="TriggerDate">Date when the checklist was triggered. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="IntentId">The intent ID if checklist was triggered by an intent..</param>
        /// <param name="IntentName">The intent name if checklist was triggered by an intent..</param>
        public ActivationTrigger(TriggerTypeEnum? TriggerType = null, DateTime? TriggerDate = null, string IntentId = null, string IntentName = null)
        {
            this.TriggerType = TriggerType;
            this.TriggerDate = TriggerDate;
            this.IntentId = IntentId;
            this.IntentName = IntentName;
            
        }
        




        /// <summary>
        /// Date when the checklist was triggered. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the checklist was triggered. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="triggerDate", EmitDefaultValue=false)]
        public DateTime? TriggerDate { get; set; }



        /// <summary>
        /// The intent ID if checklist was triggered by an intent.
        /// </summary>
        /// <value>The intent ID if checklist was triggered by an intent.</value>
        [DataMember(Name="intentId", EmitDefaultValue=false)]
        public string IntentId { get; set; }



        /// <summary>
        /// The intent name if checklist was triggered by an intent.
        /// </summary>
        /// <value>The intent name if checklist was triggered by an intent.</value>
        [DataMember(Name="intentName", EmitDefaultValue=false)]
        public string IntentName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivationTrigger {\n");

            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  TriggerDate: ").Append(TriggerDate).Append("\n");
            sb.Append("  IntentId: ").Append(IntentId).Append("\n");
            sb.Append("  IntentName: ").Append(IntentName).Append("\n");
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
            return this.Equals(obj as ActivationTrigger);
        }

        /// <summary>
        /// Returns true if ActivationTrigger instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivationTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivationTrigger other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TriggerType == other.TriggerType ||
                    this.TriggerType != null &&
                    this.TriggerType.Equals(other.TriggerType)
                ) &&
                (
                    this.TriggerDate == other.TriggerDate ||
                    this.TriggerDate != null &&
                    this.TriggerDate.Equals(other.TriggerDate)
                ) &&
                (
                    this.IntentId == other.IntentId ||
                    this.IntentId != null &&
                    this.IntentId.Equals(other.IntentId)
                ) &&
                (
                    this.IntentName == other.IntentName ||
                    this.IntentName != null &&
                    this.IntentName.Equals(other.IntentName)
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
                if (this.TriggerType != null)
                    hash = hash * 59 + this.TriggerType.GetHashCode();

                if (this.TriggerDate != null)
                    hash = hash * 59 + this.TriggerDate.GetHashCode();

                if (this.IntentId != null)
                    hash = hash * 59 + this.IntentId.GetHashCode();

                if (this.IntentName != null)
                    hash = hash * 59 + this.IntentName.GetHashCode();

                return hash;
            }
        }
    }

}
