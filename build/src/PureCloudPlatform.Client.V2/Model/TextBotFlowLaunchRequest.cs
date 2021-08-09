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
    /// Settings for launching an instance of a bot flow.
    /// </summary>
    [DataContract]
    public partial class TextBotFlowLaunchRequest :  IEquatable<TextBotFlowLaunchRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotFlowLaunchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotFlowLaunchRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotFlowLaunchRequest" /> class.
        /// </summary>
        /// <param name="Flow">Specifies which Bot Flow to launch. (required).</param>
        /// <param name="ExternalSessionId">The ID of the external session that is associated with the bot flow. (required).</param>
        /// <param name="ConversationId">A conversation ID to associate with the bot flow, if available..</param>
        /// <param name="InputData">Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema..</param>
        /// <param name="Channel">Channel information relevant to the bot flow. (required).</param>
        public TextBotFlowLaunchRequest(TextBotFlow Flow = null, string ExternalSessionId = null, string ConversationId = null, TextBotInputOutputData InputData = null, TextBotChannel Channel = null)
        {
            this.Flow = Flow;
            this.ExternalSessionId = ExternalSessionId;
            this.ConversationId = ConversationId;
            this.InputData = InputData;
            this.Channel = Channel;
            
        }
        
        
        
        /// <summary>
        /// Specifies which Bot Flow to launch.
        /// </summary>
        /// <value>Specifies which Bot Flow to launch.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public TextBotFlow Flow { get; set; }
        
        
        
        /// <summary>
        /// The ID of the external session that is associated with the bot flow.
        /// </summary>
        /// <value>The ID of the external session that is associated with the bot flow.</value>
        [DataMember(Name="externalSessionId", EmitDefaultValue=false)]
        public string ExternalSessionId { get; set; }
        
        
        
        /// <summary>
        /// A conversation ID to associate with the bot flow, if available.
        /// </summary>
        /// <value>A conversation ID to associate with the bot flow, if available.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
        
        
        
        /// <summary>
        /// Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema.
        /// </summary>
        /// <value>Input values to the flow. Valid values are defined by the flow&#39;s input JSON schema.</value>
        [DataMember(Name="inputData", EmitDefaultValue=false)]
        public TextBotInputOutputData InputData { get; set; }
        
        
        
        /// <summary>
        /// Channel information relevant to the bot flow.
        /// </summary>
        /// <value>Channel information relevant to the bot flow.</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public TextBotChannel Channel { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotFlowLaunchRequest {\n");
            
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  ExternalSessionId: ").Append(ExternalSessionId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  InputData: ").Append(InputData).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
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
            return this.Equals(obj as TextBotFlowLaunchRequest);
        }

        /// <summary>
        /// Returns true if TextBotFlowLaunchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotFlowLaunchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotFlowLaunchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.ExternalSessionId == other.ExternalSessionId ||
                    this.ExternalSessionId != null &&
                    this.ExternalSessionId.Equals(other.ExternalSessionId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.InputData == other.InputData ||
                    this.InputData != null &&
                    this.InputData.Equals(other.InputData)
                ) &&
                (
                    this.Channel == other.Channel ||
                    this.Channel != null &&
                    this.Channel.Equals(other.Channel)
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
                
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();
                
                if (this.ExternalSessionId != null)
                    hash = hash * 59 + this.ExternalSessionId.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                
                if (this.InputData != null)
                    hash = hash * 59 + this.InputData.GetHashCode();
                
                if (this.Channel != null)
                    hash = hash * 59 + this.Channel.GetHashCode();
                
                return hash;
            }
        }
    }

}
