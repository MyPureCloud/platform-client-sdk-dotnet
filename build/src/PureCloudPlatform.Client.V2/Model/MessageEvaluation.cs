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
    /// MessageEvaluation
    /// </summary>
    [DataContract]
    public partial class MessageEvaluation :  IEquatable<MessageEvaluation>
    {
        /// <summary>
        /// The type of message sent
        /// </summary>
        /// <value>The type of message sent</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Whatsapp for "WhatsApp"
            /// </summary>
            [EnumMember(Value = "WhatsApp")]
            Whatsapp
        }
        /// <summary>
        /// The type of message sent
        /// </summary>
        /// <value>The type of message sent</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageEvaluation" /> class.
        /// </summary>
        /// <param name="ContactColumn">The name of the contact column that was wrapped up.</param>
        /// <param name="ContactAddress">The address (phone or email) that was wrapped up.</param>
        /// <param name="MessageType">The type of message sent.</param>
        /// <param name="WrapupCodeId">The id of the wrap-up code.</param>
        /// <param name="Timestamp">The time that the wrap-up was applied. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public MessageEvaluation(string ContactColumn = null, string ContactAddress = null, MessageTypeEnum? MessageType = null, string WrapupCodeId = null, DateTime? Timestamp = null)
        {
            this.ContactColumn = ContactColumn;
            this.ContactAddress = ContactAddress;
            this.MessageType = MessageType;
            this.WrapupCodeId = WrapupCodeId;
            this.Timestamp = Timestamp;
            
        }
        


        /// <summary>
        /// The name of the contact column that was wrapped up
        /// </summary>
        /// <value>The name of the contact column that was wrapped up</value>
        [DataMember(Name="contactColumn", EmitDefaultValue=false)]
        public string ContactColumn { get; set; }



        /// <summary>
        /// The address (phone or email) that was wrapped up
        /// </summary>
        /// <value>The address (phone or email) that was wrapped up</value>
        [DataMember(Name="contactAddress", EmitDefaultValue=false)]
        public string ContactAddress { get; set; }





        /// <summary>
        /// The id of the wrap-up code
        /// </summary>
        /// <value>The id of the wrap-up code</value>
        [DataMember(Name="wrapupCodeId", EmitDefaultValue=false)]
        public string WrapupCodeId { get; set; }



        /// <summary>
        /// The time that the wrap-up was applied. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The time that the wrap-up was applied. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageEvaluation {\n");

            sb.Append("  ContactColumn: ").Append(ContactColumn).Append("\n");
            sb.Append("  ContactAddress: ").Append(ContactAddress).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  WrapupCodeId: ").Append(WrapupCodeId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as MessageEvaluation);
        }

        /// <summary>
        /// Returns true if MessageEvaluation instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageEvaluation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageEvaluation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactColumn == other.ContactColumn ||
                    this.ContactColumn != null &&
                    this.ContactColumn.Equals(other.ContactColumn)
                ) &&
                (
                    this.ContactAddress == other.ContactAddress ||
                    this.ContactAddress != null &&
                    this.ContactAddress.Equals(other.ContactAddress)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.WrapupCodeId == other.WrapupCodeId ||
                    this.WrapupCodeId != null &&
                    this.WrapupCodeId.Equals(other.WrapupCodeId)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                if (this.ContactColumn != null)
                    hash = hash * 59 + this.ContactColumn.GetHashCode();

                if (this.ContactAddress != null)
                    hash = hash * 59 + this.ContactAddress.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.WrapupCodeId != null)
                    hash = hash * 59 + this.WrapupCodeId.GetHashCode();

                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();

                return hash;
            }
        }
    }

}
