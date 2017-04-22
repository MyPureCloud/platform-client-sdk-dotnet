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
    /// ConversationAssociation
    /// </summary>
    [DataContract]
    public partial class ConversationAssociation :  IEquatable<ConversationAssociation>
    {
        /// <summary>
        /// Media type
        /// </summary>
        /// <value>Media type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Call for "CALL"
            /// </summary>
            [EnumMember(Value = "CALL")]
            Call,
            
            /// <summary>
            /// Enum Callback for "CALLBACK"
            /// </summary>
            [EnumMember(Value = "CALLBACK")]
            Callback,
            
            /// <summary>
            /// Enum Chat for "CHAT"
            /// </summary>
            [EnumMember(Value = "CHAT")]
            Chat,
            
            /// <summary>
            /// Enum Cobrowse for "COBROWSE"
            /// </summary>
            [EnumMember(Value = "COBROWSE")]
            Cobrowse,
            
            /// <summary>
            /// Enum Email for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            Email,
            
            /// <summary>
            /// Enum SocialExpression for "SOCIAL_EXPRESSION"
            /// </summary>
            [EnumMember(Value = "SOCIAL_EXPRESSION")]
            SocialExpression,
            
            /// <summary>
            /// Enum Video for "VIDEO"
            /// </summary>
            [EnumMember(Value = "VIDEO")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "SCREENSHARE"
            /// </summary>
            [EnumMember(Value = "SCREENSHARE")]
            Screenshare
        }
        /// <summary>
        /// Media type
        /// </summary>
        /// <value>Media type</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAssociation" /> class.
        /// </summary>
        /// <param name="ConversationId">Conversation ID (required).</param>
        /// <param name="CommunicationId">Communication ID (required).</param>
        /// <param name="MediaType">Media type (required).</param>
        public ConversationAssociation(string ConversationId = null, string CommunicationId = null, MediaTypeEnum? MediaType = null)
        {
            // to ensure "ConversationId" is required (not null)
            if (ConversationId == null)
            {
                throw new InvalidDataException("ConversationId is a required property for ConversationAssociation and cannot be null");
            }
            else
            {
                this.ConversationId = ConversationId;
            }
            // to ensure "CommunicationId" is required (not null)
            if (CommunicationId == null)
            {
                throw new InvalidDataException("CommunicationId is a required property for ConversationAssociation and cannot be null");
            }
            else
            {
                this.CommunicationId = CommunicationId;
            }
            // to ensure "MediaType" is required (not null)
            if (MediaType == null)
            {
                throw new InvalidDataException("MediaType is a required property for ConversationAssociation and cannot be null");
            }
            else
            {
                this.MediaType = MediaType;
            }
        }
        
        /// <summary>
        /// External Contact ID; populated from url
        /// </summary>
        /// <value>External Contact ID; populated from url</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; private set; }
        /// <summary>
        /// Conversation ID
        /// </summary>
        /// <value>Conversation ID</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        /// <summary>
        /// Communication ID
        /// </summary>
        /// <value>Communication ID</value>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAssociation {\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConversationAssociation);
        }

        /// <summary>
        /// Returns true if ConversationAssociation instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAssociation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                return hash;
            }
        }
    }

}
