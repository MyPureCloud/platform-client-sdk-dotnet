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
    /// AgentDirectRoutingBackupSettings
    /// </summary>
    [DataContract]
    public partial class AgentDirectRoutingBackupSettings :  IEquatable<AgentDirectRoutingBackupSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDirectRoutingBackupSettings" /> class.
        /// </summary>
        /// <param name="QueueId">ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup..</param>
        /// <param name="UserId">ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup..</param>
        /// <param name="WaitForAgent">Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup..</param>
        /// <param name="AgentWaitSeconds">Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000]..</param>
        public AgentDirectRoutingBackupSettings(string QueueId = null, string UserId = null, bool? WaitForAgent = null, int? AgentWaitSeconds = null)
        {
            this.QueueId = QueueId;
            this.UserId = UserId;
            this.WaitForAgent = WaitForAgent;
            this.AgentWaitSeconds = AgentWaitSeconds;
            
        }
        


        /// <summary>
        /// ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup.
        /// </summary>
        /// <value>ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup.
        /// </summary>
        /// <value>ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.
        /// </summary>
        /// <value>Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.</value>
        [DataMember(Name="waitForAgent", EmitDefaultValue=false)]
        public bool? WaitForAgent { get; set; }



        /// <summary>
        /// Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].
        /// </summary>
        /// <value>Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].</value>
        [DataMember(Name="agentWaitSeconds", EmitDefaultValue=false)]
        public int? AgentWaitSeconds { get; set; }



        /// <summary>
        /// Set of users that this user is a backup for.
        /// </summary>
        /// <value>Set of users that this user is a backup for.</value>
        [DataMember(Name="backedUpUsers", EmitDefaultValue=false)]
        public List<string> BackedUpUsers { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentDirectRoutingBackupSettings {\n");

            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WaitForAgent: ").Append(WaitForAgent).Append("\n");
            sb.Append("  AgentWaitSeconds: ").Append(AgentWaitSeconds).Append("\n");
            sb.Append("  BackedUpUsers: ").Append(BackedUpUsers).Append("\n");
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
            return this.Equals(obj as AgentDirectRoutingBackupSettings);
        }

        /// <summary>
        /// Returns true if AgentDirectRoutingBackupSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentDirectRoutingBackupSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentDirectRoutingBackupSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.WaitForAgent == other.WaitForAgent ||
                    this.WaitForAgent != null &&
                    this.WaitForAgent.Equals(other.WaitForAgent)
                ) &&
                (
                    this.AgentWaitSeconds == other.AgentWaitSeconds ||
                    this.AgentWaitSeconds != null &&
                    this.AgentWaitSeconds.Equals(other.AgentWaitSeconds)
                ) &&
                (
                    this.BackedUpUsers == other.BackedUpUsers ||
                    this.BackedUpUsers != null &&
                    this.BackedUpUsers.SequenceEqual(other.BackedUpUsers)
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
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.WaitForAgent != null)
                    hash = hash * 59 + this.WaitForAgent.GetHashCode();

                if (this.AgentWaitSeconds != null)
                    hash = hash * 59 + this.AgentWaitSeconds.GetHashCode();

                if (this.BackedUpUsers != null)
                    hash = hash * 59 + this.BackedUpUsers.GetHashCode();

                return hash;
            }
        }
    }

}
