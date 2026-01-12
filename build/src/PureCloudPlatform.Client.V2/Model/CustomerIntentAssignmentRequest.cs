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
    /// CustomerIntentAssignmentRequest
    /// </summary>
    [DataContract]
    public partial class CustomerIntentAssignmentRequest :  IEquatable<CustomerIntentAssignmentRequest>
    {
        /// <summary>
        /// Type of source of assignment
        /// </summary>
        /// <value>Type of source of assignment</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "Bot"
            /// </summary>
            [EnumMember(Value = "Bot")]
            Bot,
            
            /// <summary>
            /// Enum Copilot for "Copilot"
            /// </summary>
            [EnumMember(Value = "Copilot")]
            Copilot,
            
            /// <summary>
            /// Enum Digitalbot for "Digitalbot"
            /// </summary>
            [EnumMember(Value = "Digitalbot")]
            Digitalbot,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Type of source of assignment
        /// </summary>
        /// <value>Type of source of assignment</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerIntentAssignmentRequest" /> class.
        /// </summary>
        /// <param name="SourceId">Id of the source of assignment.</param>
        /// <param name="SessionId">Id of session assignment occurred in.</param>
        /// <param name="ConversationId">Id of conversation assignment occurred in.</param>
        /// <param name="SourceType">Type of source of assignment.</param>
        public CustomerIntentAssignmentRequest(string SourceId = null, string SessionId = null, string ConversationId = null, SourceTypeEnum? SourceType = null)
        {
            this.SourceId = SourceId;
            this.SessionId = SessionId;
            this.ConversationId = ConversationId;
            this.SourceType = SourceType;
            
        }
        


        /// <summary>
        /// Id of the source of assignment
        /// </summary>
        /// <value>Id of the source of assignment</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }



        /// <summary>
        /// Id of session assignment occurred in
        /// </summary>
        /// <value>Id of session assignment occurred in</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }



        /// <summary>
        /// Id of conversation assignment occurred in
        /// </summary>
        /// <value>Id of conversation assignment occurred in</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerIntentAssignmentRequest {\n");

            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
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
            return this.Equals(obj as CustomerIntentAssignmentRequest);
        }

        /// <summary>
        /// Returns true if CustomerIntentAssignmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerIntentAssignmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerIntentAssignmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
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
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();

                return hash;
            }
        }
    }

}
