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
    /// QueueConversationCallEventTopicRecordersState
    /// </summary>
    [DataContract]
    public partial class QueueConversationCallEventTopicRecordersState :  IEquatable<QueueConversationCallEventTopicRecordersState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationCallEventTopicRecordersState" /> class.
        /// </summary>
        /// <param name="AdhocState">Indicates the state of the adhoc recorder..</param>
        /// <param name="CustomerExperienceState">Indicates the state of the customer experience recorder..</param>
        /// <param name="AgentExperienceState">Indicates the state of the agent experience recorder..</param>
        public QueueConversationCallEventTopicRecordersState(string AdhocState = null, string CustomerExperienceState = null, string AgentExperienceState = null)
        {
            this.AdhocState = AdhocState;
            this.CustomerExperienceState = CustomerExperienceState;
            this.AgentExperienceState = AgentExperienceState;
            
        }
        


        /// <summary>
        /// Indicates the state of the adhoc recorder.
        /// </summary>
        /// <value>Indicates the state of the adhoc recorder.</value>
        [DataMember(Name="adhocState", EmitDefaultValue=false)]
        public string AdhocState { get; set; }



        /// <summary>
        /// Indicates the state of the customer experience recorder.
        /// </summary>
        /// <value>Indicates the state of the customer experience recorder.</value>
        [DataMember(Name="customerExperienceState", EmitDefaultValue=false)]
        public string CustomerExperienceState { get; set; }



        /// <summary>
        /// Indicates the state of the agent experience recorder.
        /// </summary>
        /// <value>Indicates the state of the agent experience recorder.</value>
        [DataMember(Name="agentExperienceState", EmitDefaultValue=false)]
        public string AgentExperienceState { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationCallEventTopicRecordersState {\n");

            sb.Append("  AdhocState: ").Append(AdhocState).Append("\n");
            sb.Append("  CustomerExperienceState: ").Append(CustomerExperienceState).Append("\n");
            sb.Append("  AgentExperienceState: ").Append(AgentExperienceState).Append("\n");
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
            return this.Equals(obj as QueueConversationCallEventTopicRecordersState);
        }

        /// <summary>
        /// Returns true if QueueConversationCallEventTopicRecordersState instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationCallEventTopicRecordersState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationCallEventTopicRecordersState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AdhocState == other.AdhocState ||
                    this.AdhocState != null &&
                    this.AdhocState.Equals(other.AdhocState)
                ) &&
                (
                    this.CustomerExperienceState == other.CustomerExperienceState ||
                    this.CustomerExperienceState != null &&
                    this.CustomerExperienceState.Equals(other.CustomerExperienceState)
                ) &&
                (
                    this.AgentExperienceState == other.AgentExperienceState ||
                    this.AgentExperienceState != null &&
                    this.AgentExperienceState.Equals(other.AgentExperienceState)
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
                if (this.AdhocState != null)
                    hash = hash * 59 + this.AdhocState.GetHashCode();

                if (this.CustomerExperienceState != null)
                    hash = hash * 59 + this.CustomerExperienceState.GetHashCode();

                if (this.AgentExperienceState != null)
                    hash = hash * 59 + this.AgentExperienceState.GetHashCode();

                return hash;
            }
        }
    }

}
