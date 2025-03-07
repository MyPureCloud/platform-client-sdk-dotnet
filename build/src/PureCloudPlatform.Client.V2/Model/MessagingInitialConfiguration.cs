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
    /// MessagingInitialConfiguration
    /// </summary>
    [DataContract]
    public partial class MessagingInitialConfiguration :  IEquatable<MessagingInitialConfiguration>
    {
        /// <summary>
        /// The type of message platform from which the message originated.
        /// </summary>
        /// <value>The type of message platform from which the message originated.</value>
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
            /// Enum Twitter for "Twitter"
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "Facebook"
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "WhatsApp"
            /// </summary>
            [EnumMember(Value = "WhatsApp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessage for "WebMessage"
            /// </summary>
            [EnumMember(Value = "WebMessage")]
            Webmessage,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Instagram for "Instagram"
            /// </summary>
            [EnumMember(Value = "Instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The type of message platform from which the message originated.
        /// </summary>
        /// <value>The type of message platform from which the message originated.</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingInitialConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingInitialConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingInitialConfiguration" /> class.
        /// </summary>
        /// <param name="ToAddress">Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended. (required).</param>
        /// <param name="FromAddress">Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended. (required).</param>
        /// <param name="MessageType">The type of message platform from which the message originated..</param>
        /// <param name="Held">Indicates that this communication&#39;s initial state is held..</param>
        /// <param name="Alerting">Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state..</param>
        /// <param name="Inbound">Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND..</param>
        /// <param name="InvitedBy">The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred..</param>
        /// <param name="AdditionalInfo">Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields..</param>
        public MessagingInitialConfiguration(string ToAddress = null, string FromAddress = null, MessageTypeEnum? MessageType = null, bool? Held = null, bool? Alerting = null, bool? Inbound = null, string InvitedBy = null, Dictionary<string, string> AdditionalInfo = null)
        {
            this.ToAddress = ToAddress;
            this.FromAddress = FromAddress;
            this.MessageType = MessageType;
            this.Held = Held;
            this.Alerting = Alerting;
            this.Inbound = Inbound;
            this.InvitedBy = InvitedBy;
            this.AdditionalInfo = AdditionalInfo;
            
        }
        


        /// <summary>
        /// Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended.
        /// </summary>
        /// <value>Address for the participant on receiving side of the message conversation. If the address is a phone number, E.164 format is recommended.</value>
        [DataMember(Name="toAddress", EmitDefaultValue=false)]
        public string ToAddress { get; set; }



        /// <summary>
        /// Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended.
        /// </summary>
        /// <value>Address for the participant on the sending side of the message conversation. If the address is a phone number, E.164 format is recommended.</value>
        [DataMember(Name="fromAddress", EmitDefaultValue=false)]
        public string FromAddress { get; set; }





        /// <summary>
        /// Indicates that this communication&#39;s initial state is held.
        /// </summary>
        /// <value>Indicates that this communication&#39;s initial state is held.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }



        /// <summary>
        /// Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.
        /// </summary>
        /// <value>Indicates that this communication&#39;s initial state is alerting. If false, the communication started in a connected state.</value>
        [DataMember(Name="alerting", EmitDefaultValue=false)]
        public bool? Alerting { get; set; }



        /// <summary>
        /// Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.
        /// </summary>
        /// <value>Indicates the direction of this communication with respect to the contact center. &#x60;true&#x60; means the communication is INBOUND. &#x60;false&#x60; means the communication is OUTBOUND.</value>
        [DataMember(Name="inbound", EmitDefaultValue=false)]
        public bool? Inbound { get; set; }



        /// <summary>
        /// The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.
        /// </summary>
        /// <value>The id of the communication (the \&quot;peer\&quot;) that \&quot;invited\&quot; this communication, if this occurred.</value>
        [DataMember(Name="invitedBy", EmitDefaultValue=false)]
        public string InvitedBy { get; set; }



        /// <summary>
        /// Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.
        /// </summary>
        /// <value>Additional metadata about this session which should be recorded by the platform but which will not be indexed or searchable. Primarily for diagnostic value. Any information that needs to be accessible through other components like Analytics should be moved to dedicated fields.</value>
        [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingInitialConfiguration {\n");

            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  Alerting: ").Append(Alerting).Append("\n");
            sb.Append("  Inbound: ").Append(Inbound).Append("\n");
            sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return this.Equals(obj as MessagingInitialConfiguration);
        }

        /// <summary>
        /// Returns true if MessagingInitialConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingInitialConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingInitialConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ToAddress == other.ToAddress ||
                    this.ToAddress != null &&
                    this.ToAddress.Equals(other.ToAddress)
                ) &&
                (
                    this.FromAddress == other.FromAddress ||
                    this.FromAddress != null &&
                    this.FromAddress.Equals(other.FromAddress)
                ) &&
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.Alerting == other.Alerting ||
                    this.Alerting != null &&
                    this.Alerting.Equals(other.Alerting)
                ) &&
                (
                    this.Inbound == other.Inbound ||
                    this.Inbound != null &&
                    this.Inbound.Equals(other.Inbound)
                ) &&
                (
                    this.InvitedBy == other.InvitedBy ||
                    this.InvitedBy != null &&
                    this.InvitedBy.Equals(other.InvitedBy)
                ) &&
                (
                    this.AdditionalInfo == other.AdditionalInfo ||
                    this.AdditionalInfo != null &&
                    this.AdditionalInfo.SequenceEqual(other.AdditionalInfo)
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
                if (this.ToAddress != null)
                    hash = hash * 59 + this.ToAddress.GetHashCode();

                if (this.FromAddress != null)
                    hash = hash * 59 + this.FromAddress.GetHashCode();

                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();

                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();

                if (this.Alerting != null)
                    hash = hash * 59 + this.Alerting.GetHashCode();

                if (this.Inbound != null)
                    hash = hash * 59 + this.Inbound.GetHashCode();

                if (this.InvitedBy != null)
                    hash = hash * 59 + this.InvitedBy.GetHashCode();

                if (this.AdditionalInfo != null)
                    hash = hash * 59 + this.AdditionalInfo.GetHashCode();

                return hash;
            }
        }
    }

}
