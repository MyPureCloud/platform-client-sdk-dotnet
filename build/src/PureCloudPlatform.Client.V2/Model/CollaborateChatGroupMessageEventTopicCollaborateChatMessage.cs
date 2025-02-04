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
    /// CollaborateChatGroupMessageEventTopicCollaborateChatMessage
    /// </summary>
    [DataContract]
    public partial class CollaborateChatGroupMessageEventTopicCollaborateChatMessage :  IEquatable<CollaborateChatGroupMessageEventTopicCollaborateChatMessage>
    {
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum Edit for "Edit"
            /// </summary>
            [EnumMember(Value = "Edit")]
            Edit,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete
        }
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollaborateChatGroupMessageEventTopicCollaborateChatMessage" /> class.
        /// </summary>
        /// <param name="MessageId">MessageId.</param>
        /// <param name="Created">Created.</param>
        /// <param name="ActionType">ActionType.</param>
        /// <param name="Body">Body.</param>
        /// <param name="From">From.</param>
        /// <param name="To">To.</param>
        /// <param name="Mentions">Mentions.</param>
        /// <param name="NotifyAll">NotifyAll.</param>
        public CollaborateChatGroupMessageEventTopicCollaborateChatMessage(string MessageId = null, string Created = null, ActionTypeEnum? ActionType = null, string Body = null, CollaborateChatGroupMessageEventTopicCollaborateChatEntity From = null, CollaborateChatGroupMessageEventTopicCollaborateChatEntity To = null, List<CollaborateChatGroupMessageEventTopicCollaborateChatEntity> Mentions = null, bool? NotifyAll = null)
        {
            this.MessageId = MessageId;
            this.Created = Created;
            this.ActionType = ActionType;
            this.Body = Body;
            this.From = From;
            this.To = To;
            this.Mentions = Mentions;
            this.NotifyAll = NotifyAll;
            
        }
        


        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }



        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }





        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }



        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public CollaborateChatGroupMessageEventTopicCollaborateChatEntity From { get; set; }



        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public CollaborateChatGroupMessageEventTopicCollaborateChatEntity To { get; set; }



        /// <summary>
        /// Gets or Sets Mentions
        /// </summary>
        [DataMember(Name="mentions", EmitDefaultValue=false)]
        public List<CollaborateChatGroupMessageEventTopicCollaborateChatEntity> Mentions { get; set; }



        /// <summary>
        /// Gets or Sets NotifyAll
        /// </summary>
        [DataMember(Name="notifyAll", EmitDefaultValue=false)]
        public bool? NotifyAll { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollaborateChatGroupMessageEventTopicCollaborateChatMessage {\n");

            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  NotifyAll: ").Append(NotifyAll).Append("\n");
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
            return this.Equals(obj as CollaborateChatGroupMessageEventTopicCollaborateChatMessage);
        }

        /// <summary>
        /// Returns true if CollaborateChatGroupMessageEventTopicCollaborateChatMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of CollaborateChatGroupMessageEventTopicCollaborateChatMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollaborateChatGroupMessageEventTopicCollaborateChatMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) &&
                (
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.Mentions == other.Mentions ||
                    this.Mentions != null &&
                    this.Mentions.SequenceEqual(other.Mentions)
                ) &&
                (
                    this.NotifyAll == other.NotifyAll ||
                    this.NotifyAll != null &&
                    this.NotifyAll.Equals(other.NotifyAll)
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
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();

                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();

                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();

                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.Mentions != null)
                    hash = hash * 59 + this.Mentions.GetHashCode();

                if (this.NotifyAll != null)
                    hash = hash * 59 + this.NotifyAll.GetHashCode();

                return hash;
            }
        }
    }

}
