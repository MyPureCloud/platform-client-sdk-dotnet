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
    /// CreateSurveyRequest
    /// </summary>
    [DataContract]
    public partial class CreateSurveyRequest :  IEquatable<CreateSurveyRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSurveyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSurveyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSurveyRequest" /> class.
        /// </summary>
        /// <param name="ConversationId">The conversation to create the survey for. (required).</param>
        /// <param name="SurveyFormContextId">The survey form context to use for the survey. (required).</param>
        /// <param name="AgentId">The agent to associate with the survey. If not specified, the last agent on the conversation will be selected..</param>
        /// <param name="QueueId">The queue to associate with the survey. If not specified, the queue associated with the selected agent will be used..</param>
        public CreateSurveyRequest(string ConversationId = null, string SurveyFormContextId = null, string AgentId = null, string QueueId = null)
        {
            this.ConversationId = ConversationId;
            this.SurveyFormContextId = SurveyFormContextId;
            this.AgentId = AgentId;
            this.QueueId = QueueId;
            
        }
        


        /// <summary>
        /// The conversation to create the survey for.
        /// </summary>
        /// <value>The conversation to create the survey for.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The survey form context to use for the survey.
        /// </summary>
        /// <value>The survey form context to use for the survey.</value>
        [DataMember(Name="surveyFormContextId", EmitDefaultValue=false)]
        public string SurveyFormContextId { get; set; }



        /// <summary>
        /// The agent to associate with the survey. If not specified, the last agent on the conversation will be selected.
        /// </summary>
        /// <value>The agent to associate with the survey. If not specified, the last agent on the conversation will be selected.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The queue to associate with the survey. If not specified, the queue associated with the selected agent will be used.
        /// </summary>
        /// <value>The queue to associate with the survey. If not specified, the queue associated with the selected agent will be used.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSurveyRequest {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  SurveyFormContextId: ").Append(SurveyFormContextId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
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
            return this.Equals(obj as CreateSurveyRequest);
        }

        /// <summary>
        /// Returns true if CreateSurveyRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateSurveyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSurveyRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.SurveyFormContextId == other.SurveyFormContextId ||
                    this.SurveyFormContextId != null &&
                    this.SurveyFormContextId.Equals(other.SurveyFormContextId)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
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
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.SurveyFormContextId != null)
                    hash = hash * 59 + this.SurveyFormContextId.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                return hash;
            }
        }
    }

}
