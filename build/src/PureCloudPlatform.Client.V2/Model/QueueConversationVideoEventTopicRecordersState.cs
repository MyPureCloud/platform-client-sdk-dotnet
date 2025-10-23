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
    /// Contains the states of different recorders.
    /// </summary>
    [DataContract]
    public partial class QueueConversationVideoEventTopicRecordersState :  IEquatable<QueueConversationVideoEventTopicRecordersState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueConversationVideoEventTopicRecordersState" /> class.
        /// </summary>
        /// <param name="AdhocState">Indicates the state of the adhoc recorder..</param>
        /// <param name="CustomerExperienceState">Indicates the state of the customer experience recorder..</param>
        /// <param name="AgentExperienceState">Indicates the state of the agent experience recorder..</param>
        /// <param name="SnippetState">State of the snippet recording for this session. Note that snippets may never be paused. Valid values are in Constants.java with a prefix of RECORDER_STATE_*..</param>
        public QueueConversationVideoEventTopicRecordersState(string AdhocState = null, string CustomerExperienceState = null, string AgentExperienceState = null, string SnippetState = null)
        {
            this.AdhocState = AdhocState;
            this.CustomerExperienceState = CustomerExperienceState;
            this.AgentExperienceState = AgentExperienceState;
            this.SnippetState = SnippetState;
            
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
        /// State of the snippet recording for this session. Note that snippets may never be paused. Valid values are in Constants.java with a prefix of RECORDER_STATE_*.
        /// </summary>
        /// <value>State of the snippet recording for this session. Note that snippets may never be paused. Valid values are in Constants.java with a prefix of RECORDER_STATE_*.</value>
        [DataMember(Name="snippetState", EmitDefaultValue=false)]
        public string SnippetState { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueConversationVideoEventTopicRecordersState {\n");

            sb.Append("  AdhocState: ").Append(AdhocState).Append("\n");
            sb.Append("  CustomerExperienceState: ").Append(CustomerExperienceState).Append("\n");
            sb.Append("  AgentExperienceState: ").Append(AgentExperienceState).Append("\n");
            sb.Append("  SnippetState: ").Append(SnippetState).Append("\n");
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
            return this.Equals(obj as QueueConversationVideoEventTopicRecordersState);
        }

        /// <summary>
        /// Returns true if QueueConversationVideoEventTopicRecordersState instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueConversationVideoEventTopicRecordersState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueConversationVideoEventTopicRecordersState other)
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
                ) &&
                (
                    this.SnippetState == other.SnippetState ||
                    this.SnippetState != null &&
                    this.SnippetState.Equals(other.SnippetState)
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

                if (this.SnippetState != null)
                    hash = hash * 59 + this.SnippetState.GetHashCode();

                return hash;
            }
        }
    }

}
