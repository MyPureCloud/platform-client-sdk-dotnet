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
    /// CreateWebChatRequest
    /// </summary>
    [DataContract]
    public partial class CreateWebChatRequest :  IEquatable<CreateWebChatRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebChatRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatRequest" /> class.
        /// </summary>
        /// <param name="QueueId">The ID of the queue to use for routing the chat conversation. (required).</param>
        /// <param name="Provider">The name of the provider that is sourcing the web chat. (required).</param>
        /// <param name="SkillIds">The list of skill ID&#39;s to use for routing..</param>
        /// <param name="LanguageId">The ID of the langauge to use for routing..</param>
        /// <param name="Priority">The priority to assign to the conversation for routing..</param>
        /// <param name="Attributes">The list of attributes to associate with the customer participant..</param>
        /// <param name="CustomerName">The name of the customer participating in the web chat..</param>
        public CreateWebChatRequest(string QueueId = null, string Provider = null, List<string> SkillIds = null, string LanguageId = null, long? Priority = null, Dictionary<string, string> Attributes = null, string CustomerName = null)
        {
            // to ensure "QueueId" is required (not null)
            if (QueueId == null)
            {
                throw new InvalidDataException("QueueId is a required property for CreateWebChatRequest and cannot be null");
            }
            else
            {
                this.QueueId = QueueId;
            }
            // to ensure "Provider" is required (not null)
            if (Provider == null)
            {
                throw new InvalidDataException("Provider is a required property for CreateWebChatRequest and cannot be null");
            }
            else
            {
                this.Provider = Provider;
            }
            this.SkillIds = SkillIds;
            this.LanguageId = LanguageId;
            this.Priority = Priority;
            this.Attributes = Attributes;
            this.CustomerName = CustomerName;
        }
        
        /// <summary>
        /// The ID of the queue to use for routing the chat conversation.
        /// </summary>
        /// <value>The ID of the queue to use for routing the chat conversation.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        /// <summary>
        /// The name of the provider that is sourcing the web chat.
        /// </summary>
        /// <value>The name of the provider that is sourcing the web chat.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }
        /// <summary>
        /// The list of skill ID&#39;s to use for routing.
        /// </summary>
        /// <value>The list of skill ID&#39;s to use for routing.</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }
        /// <summary>
        /// The ID of the langauge to use for routing.
        /// </summary>
        /// <value>The ID of the langauge to use for routing.</value>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public string LanguageId { get; set; }
        /// <summary>
        /// The priority to assign to the conversation for routing.
        /// </summary>
        /// <value>The priority to assign to the conversation for routing.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public long? Priority { get; set; }
        /// <summary>
        /// The list of attributes to associate with the customer participant.
        /// </summary>
        /// <value>The list of attributes to associate with the customer participant.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }
        /// <summary>
        /// The name of the customer participating in the web chat.
        /// </summary>
        /// <value>The name of the customer participating in the web chat.</value>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebChatRequest {\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
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
            return this.Equals(obj as CreateWebChatRequest);
        }

        /// <summary>
        /// Returns true if CreateWebChatRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateWebChatRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebChatRequest other)
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
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.LanguageId == other.LanguageId ||
                    this.LanguageId != null &&
                    this.LanguageId.Equals(other.LanguageId)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.CustomerName == other.CustomerName ||
                    this.CustomerName != null &&
                    this.CustomerName.Equals(other.CustomerName)
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
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                if (this.LanguageId != null)
                    hash = hash * 59 + this.LanguageId.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                return hash;
            }
        }
    }

}
