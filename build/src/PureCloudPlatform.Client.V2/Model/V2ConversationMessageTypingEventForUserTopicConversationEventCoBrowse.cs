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
    /// V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse :  IEquatable<V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse>
    {
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
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
            Offeringrejected
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="SessionId">SessionId.</param>
        /// <param name="SessionJoinToken">SessionJoinToken.</param>
        public V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse(TypeEnum? Type = null, string SessionId = null, string SessionJoinToken = null)
        {
            this.Type = Type;
            this.SessionId = SessionId;
            this.SessionJoinToken = SessionJoinToken;
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SessionJoinToken
        /// </summary>
        [DataMember(Name="sessionJoinToken", EmitDefaultValue=false)]
        public string SessionJoinToken { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SessionJoinToken: ").Append(SessionJoinToken).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationEventCoBrowse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.SessionJoinToken == other.SessionJoinToken ||
                    this.SessionJoinToken != null &&
                    this.SessionJoinToken.Equals(other.SessionJoinToken)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                
                if (this.SessionJoinToken != null)
                    hash = hash * 59 + this.SessionJoinToken.GetHashCode();
                
                return hash;
            }
        }
    }

}
