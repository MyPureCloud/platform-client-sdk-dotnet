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
    /// PatchCallbackRequest
    /// </summary>
    [DataContract]
    public partial class PatchCallbackRequest :  IEquatable<PatchCallbackRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCallbackRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatchCallbackRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCallbackRequest" /> class.
        /// </summary>
        /// <param name="ConversationId">The conversationId. (required).</param>
        /// <param name="QueueId">The identifier of the queue to be used for the callback..</param>
        /// <param name="AgentId">The agentId. (required).</param>
        /// <param name="CallbackScheduledTime">The scheduled date-time for the callback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CountryCode">The countryCode.</param>
        /// <param name="CallbackNumbers">The callbackNumbers.</param>
        /// <param name="ValidateCallbackNumbers">validateCallbackNumbers.</param>
        public PatchCallbackRequest(string ConversationId = null, string QueueId = null, string AgentId = null, DateTime? CallbackScheduledTime = null, string CountryCode = null, List<string> CallbackNumbers = null, bool? ValidateCallbackNumbers = null)
        {
            this.ConversationId = ConversationId;
            this.QueueId = QueueId;
            this.AgentId = AgentId;
            this.CallbackScheduledTime = CallbackScheduledTime;
            this.CountryCode = CountryCode;
            this.CallbackNumbers = CallbackNumbers;
            this.ValidateCallbackNumbers = ValidateCallbackNumbers;
            
        }
        


        /// <summary>
        /// The conversationId.
        /// </summary>
        /// <value>The conversationId.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// The identifier of the queue to be used for the callback.
        /// </summary>
        /// <value>The identifier of the queue to be used for the callback.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The agentId.
        /// </summary>
        /// <value>The agentId.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }



        /// <summary>
        /// The scheduled date-time for the callback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The scheduled date-time for the callback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="callbackScheduledTime", EmitDefaultValue=false)]
        public DateTime? CallbackScheduledTime { get; set; }



        /// <summary>
        /// The countryCode
        /// </summary>
        /// <value>The countryCode</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }



        /// <summary>
        /// The callbackNumbers
        /// </summary>
        /// <value>The callbackNumbers</value>
        [DataMember(Name="callbackNumbers", EmitDefaultValue=false)]
        public List<string> CallbackNumbers { get; set; }



        /// <summary>
        /// validateCallbackNumbers
        /// </summary>
        /// <value>validateCallbackNumbers</value>
        [DataMember(Name="validateCallbackNumbers", EmitDefaultValue=false)]
        public bool? ValidateCallbackNumbers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchCallbackRequest {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
            sb.Append("  ValidateCallbackNumbers: ").Append(ValidateCallbackNumbers).Append("\n");
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
            return this.Equals(obj as PatchCallbackRequest);
        }

        /// <summary>
        /// Returns true if PatchCallbackRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchCallbackRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchCallbackRequest other)
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
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) &&
                (
                    this.CallbackScheduledTime == other.CallbackScheduledTime ||
                    this.CallbackScheduledTime != null &&
                    this.CallbackScheduledTime.Equals(other.CallbackScheduledTime)
                ) &&
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) &&
                (
                    this.CallbackNumbers == other.CallbackNumbers ||
                    this.CallbackNumbers != null &&
                    this.CallbackNumbers.SequenceEqual(other.CallbackNumbers)
                ) &&
                (
                    this.ValidateCallbackNumbers == other.ValidateCallbackNumbers ||
                    this.ValidateCallbackNumbers != null &&
                    this.ValidateCallbackNumbers.Equals(other.ValidateCallbackNumbers)
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

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();

                if (this.CallbackScheduledTime != null)
                    hash = hash * 59 + this.CallbackScheduledTime.GetHashCode();

                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();

                if (this.CallbackNumbers != null)
                    hash = hash * 59 + this.CallbackNumbers.GetHashCode();

                if (this.ValidateCallbackNumbers != null)
                    hash = hash * 59 + this.ValidateCallbackNumbers.GetHashCode();

                return hash;
            }
        }
    }

}
