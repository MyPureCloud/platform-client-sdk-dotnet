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
    /// ConversationChecklistTopicConversationContextTurnInfo
    /// </summary>
    [DataContract]
    public partial class ConversationChecklistTopicConversationContextTurnInfo :  IEquatable<ConversationChecklistTopicConversationContextTurnInfo>
    {
        /// <summary>
        /// Gets or Sets Participant
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Internal for "Internal"
            /// </summary>
            [EnumMember(Value = "Internal")]
            Internal,
            
            /// <summary>
            /// Enum External for "External"
            /// </summary>
            [EnumMember(Value = "External")]
            External
        }
        /// <summary>
        /// Gets or Sets Participant
        /// </summary>
        [DataMember(Name="participant", EmitDefaultValue=false)]
        public ParticipantEnum? Participant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationChecklistTopicConversationContextTurnInfo" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Participant">Participant.</param>
        public ConversationChecklistTopicConversationContextTurnInfo(Guid? Id = null, ParticipantEnum? Participant = null)
        {
            this.Id = Id;
            this.Participant = Participant;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationChecklistTopicConversationContextTurnInfo {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Participant: ").Append(Participant).Append("\n");
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
            return this.Equals(obj as ConversationChecklistTopicConversationContextTurnInfo);
        }

        /// <summary>
        /// Returns true if ConversationChecklistTopicConversationContextTurnInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationChecklistTopicConversationContextTurnInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationChecklistTopicConversationContextTurnInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Participant == other.Participant ||
                    this.Participant != null &&
                    this.Participant.Equals(other.Participant)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Participant != null)
                    hash = hash * 59 + this.Participant.GetHashCode();

                return hash;
            }
        }
    }

}
