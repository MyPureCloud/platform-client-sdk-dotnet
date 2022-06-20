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
    /// Metadata information about a message event.
    /// </summary>
    [DataContract]
    public partial class ConversationMessageMetadataEvent :  IEquatable<ConversationMessageMetadataEvent>
    {
        /// <summary>
        /// Type of this event element
        /// </summary>
        /// <value>Type of this event element</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Cobrowse for "CoBrowse"
            /// </summary>
            [EnumMember(Value = "CoBrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Typing for "Typing"
            /// </summary>
            [EnumMember(Value = "Typing")]
            Typing,
            
            /// <summary>
            /// Enum Presence for "Presence"
            /// </summary>
            [EnumMember(Value = "Presence")]
            Presence,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Event subtype
        /// </summary>
        /// <value>Event subtype</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SubTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum On for "On"
            /// </summary>
            [EnumMember(Value = "On")]
            On,
            
            /// <summary>
            /// Enum Join for "Join"
            /// </summary>
            [EnumMember(Value = "Join")]
            Join,
            
            /// <summary>
            /// Enum Offering for "Offering"
            /// </summary>
            [EnumMember(Value = "Offering")]
            Offering,
            
            /// <summary>
            /// Enum Offeringexpired for "OfferingExpired"
            /// </summary>
            [EnumMember(Value = "OfferingExpired")]
            Offeringexpired,
            
            /// <summary>
            /// Enum Offeringaccepted for "OfferingAccepted"
            /// </summary>
            [EnumMember(Value = "OfferingAccepted")]
            Offeringaccepted,
            
            /// <summary>
            /// Enum Offeringrejected for "OfferingRejected"
            /// </summary>
            [EnumMember(Value = "OfferingRejected")]
            Offeringrejected,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Type of this event element
        /// </summary>
        /// <value>Type of this event element</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Event subtype
        /// </summary>
        /// <value>Event subtype</value>
        [DataMember(Name="subType", EmitDefaultValue=false)]
        public SubTypeEnum? SubType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessageMetadataEvent" /> class.
        /// </summary>
        /// <param name="EventType">Type of this event element.</param>
        /// <param name="SubType">Event subtype.</param>
        public ConversationMessageMetadataEvent(EventTypeEnum? EventType = null, SubTypeEnum? SubType = null)
        {
            this.EventType = EventType;
            this.SubType = SubType;
            
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMessageMetadataEvent {\n");

            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
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
            return this.Equals(obj as ConversationMessageMetadataEvent);
        }

        /// <summary>
        /// Returns true if ConversationMessageMetadataEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationMessageMetadataEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMessageMetadataEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) &&
                (
                    this.SubType == other.SubType ||
                    this.SubType != null &&
                    this.SubType.Equals(other.SubType)
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
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();

                if (this.SubType != null)
                    hash = hash * 59 + this.SubType.GetHashCode();

                return hash;
            }
        }
    }

}
