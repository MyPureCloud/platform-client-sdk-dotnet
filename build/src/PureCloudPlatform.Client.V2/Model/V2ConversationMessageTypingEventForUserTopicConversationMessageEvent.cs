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
    /// V2ConversationMessageTypingEventForUserTopicConversationMessageEvent
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForUserTopicConversationMessageEvent :  IEquatable<V2ConversationMessageTypingEventForUserTopicConversationMessageEvent>
    {
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
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
            Typing
        }
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationMessageEvent" /> class.
        /// </summary>
        /// <param name="EventType">EventType.</param>
        /// <param name="Typing">Typing.</param>
        public V2ConversationMessageTypingEventForUserTopicConversationMessageEvent(EventTypeEnum? EventType = null, V2ConversationMessageTypingEventForUserTopicConversationEventTyping Typing = null)
        {
            this.EventType = EventType;
            this.Typing = Typing;
            
        }
        




        /// <summary>
        /// Gets or Sets Typing
        /// </summary>
        [DataMember(Name="typing", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationEventTyping Typing { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationMessageEvent {\n");

            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Typing: ").Append(Typing).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationMessageEvent);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationMessageEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationMessageEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationMessageEvent other)
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
                    this.Typing == other.Typing ||
                    this.Typing != null &&
                    this.Typing.Equals(other.Typing)
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

                if (this.Typing != null)
                    hash = hash * 59 + this.Typing.GetHashCode();

                return hash;
            }
        }
    }

}
