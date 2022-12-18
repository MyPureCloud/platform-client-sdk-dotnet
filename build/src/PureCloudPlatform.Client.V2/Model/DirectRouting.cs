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
    /// DirectRouting
    /// </summary>
    [DataContract]
    public partial class DirectRouting :  IEquatable<DirectRouting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectRouting" /> class.
        /// </summary>
        /// <param name="CallMediaSettings">Direct Routing Settings specific to Call media..</param>
        /// <param name="EmailMediaSettings">Direct Routing Settings specific to Email media..</param>
        /// <param name="MessageMediaSettings">Direct Routing Settings specific to Message media..</param>
        /// <param name="BackupQueueId">ID of queue to be used as the default backup if an agent does not have their Backup Settings configured..</param>
        /// <param name="WaitForAgent">Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup..</param>
        /// <param name="AgentWaitSeconds">Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000]..</param>
        public DirectRouting(DirectRoutingCallMediaSettings CallMediaSettings = null, DirectRoutingMediaSettings EmailMediaSettings = null, DirectRoutingMediaSettings MessageMediaSettings = null, string BackupQueueId = null, bool? WaitForAgent = null, int? AgentWaitSeconds = null)
        {
            this.CallMediaSettings = CallMediaSettings;
            this.EmailMediaSettings = EmailMediaSettings;
            this.MessageMediaSettings = MessageMediaSettings;
            this.BackupQueueId = BackupQueueId;
            this.WaitForAgent = WaitForAgent;
            this.AgentWaitSeconds = AgentWaitSeconds;
            
        }
        


        /// <summary>
        /// Direct Routing Settings specific to Call media.
        /// </summary>
        /// <value>Direct Routing Settings specific to Call media.</value>
        [DataMember(Name="callMediaSettings", EmitDefaultValue=false)]
        public DirectRoutingCallMediaSettings CallMediaSettings { get; set; }



        /// <summary>
        /// Direct Routing Settings specific to Email media.
        /// </summary>
        /// <value>Direct Routing Settings specific to Email media.</value>
        [DataMember(Name="emailMediaSettings", EmitDefaultValue=false)]
        public DirectRoutingMediaSettings EmailMediaSettings { get; set; }



        /// <summary>
        /// Direct Routing Settings specific to Message media.
        /// </summary>
        /// <value>Direct Routing Settings specific to Message media.</value>
        [DataMember(Name="messageMediaSettings", EmitDefaultValue=false)]
        public DirectRoutingMediaSettings MessageMediaSettings { get; set; }



        /// <summary>
        /// ID of queue to be used as the default backup if an agent does not have their Backup Settings configured.
        /// </summary>
        /// <value>ID of queue to be used as the default backup if an agent does not have their Backup Settings configured.</value>
        [DataMember(Name="backupQueueId", EmitDefaultValue=false)]
        public string BackupQueueId { get; set; }



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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectRouting {\n");

            sb.Append("  CallMediaSettings: ").Append(CallMediaSettings).Append("\n");
            sb.Append("  EmailMediaSettings: ").Append(EmailMediaSettings).Append("\n");
            sb.Append("  MessageMediaSettings: ").Append(MessageMediaSettings).Append("\n");
            sb.Append("  BackupQueueId: ").Append(BackupQueueId).Append("\n");
            sb.Append("  WaitForAgent: ").Append(WaitForAgent).Append("\n");
            sb.Append("  AgentWaitSeconds: ").Append(AgentWaitSeconds).Append("\n");
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
            return this.Equals(obj as DirectRouting);
        }

        /// <summary>
        /// Returns true if DirectRouting instances are equal
        /// </summary>
        /// <param name="other">Instance of DirectRouting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectRouting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallMediaSettings == other.CallMediaSettings ||
                    this.CallMediaSettings != null &&
                    this.CallMediaSettings.Equals(other.CallMediaSettings)
                ) &&
                (
                    this.EmailMediaSettings == other.EmailMediaSettings ||
                    this.EmailMediaSettings != null &&
                    this.EmailMediaSettings.Equals(other.EmailMediaSettings)
                ) &&
                (
                    this.MessageMediaSettings == other.MessageMediaSettings ||
                    this.MessageMediaSettings != null &&
                    this.MessageMediaSettings.Equals(other.MessageMediaSettings)
                ) &&
                (
                    this.BackupQueueId == other.BackupQueueId ||
                    this.BackupQueueId != null &&
                    this.BackupQueueId.Equals(other.BackupQueueId)
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
                if (this.CallMediaSettings != null)
                    hash = hash * 59 + this.CallMediaSettings.GetHashCode();

                if (this.EmailMediaSettings != null)
                    hash = hash * 59 + this.EmailMediaSettings.GetHashCode();

                if (this.MessageMediaSettings != null)
                    hash = hash * 59 + this.MessageMediaSettings.GetHashCode();

                if (this.BackupQueueId != null)
                    hash = hash * 59 + this.BackupQueueId.GetHashCode();

                if (this.WaitForAgent != null)
                    hash = hash * 59 + this.WaitForAgent.GetHashCode();

                if (this.AgentWaitSeconds != null)
                    hash = hash * 59 + this.AgentWaitSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
