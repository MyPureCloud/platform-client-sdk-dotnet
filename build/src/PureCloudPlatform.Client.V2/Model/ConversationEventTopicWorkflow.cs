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
    /// Information about the workflow.
    /// </summary>
    [DataContract]
    public partial class ConversationEventTopicWorkflow :  IEquatable<ConversationEventTopicWorkflow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventTopicWorkflow" /> class.
        /// </summary>
        /// <param name="WorkflowId">The id of the workflow.</param>
        public ConversationEventTopicWorkflow(string WorkflowId = null)
        {
            this.WorkflowId = WorkflowId;
            
        }
        


        /// <summary>
        /// The id of the workflow
        /// </summary>
        /// <value>The id of the workflow</value>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public string WorkflowId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventTopicWorkflow {\n");

            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
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
            return this.Equals(obj as ConversationEventTopicWorkflow);
        }

        /// <summary>
        /// Returns true if ConversationEventTopicWorkflow instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationEventTopicWorkflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventTopicWorkflow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkflowId == other.WorkflowId ||
                    this.WorkflowId != null &&
                    this.WorkflowId.Equals(other.WorkflowId)
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
                if (this.WorkflowId != null)
                    hash = hash * 59 + this.WorkflowId.GetHashCode();

                return hash;
            }
        }
    }

}
