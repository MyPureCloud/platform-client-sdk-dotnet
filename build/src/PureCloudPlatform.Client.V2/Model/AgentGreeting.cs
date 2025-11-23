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
    /// AgentGreeting
    /// </summary>
    [DataContract]
    public partial class AgentGreeting :  IEquatable<AgentGreeting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGreeting" /> class.
        /// </summary>
        /// <param name="InboundPrompt">The agent greeting prompt to use when inbound calls are connected.</param>
        /// <param name="OutboundPrompt">The agent greeting prompt to use when outbound calls are connected.</param>
        /// <param name="InboundPromptDefaultLanguage">The default language to use for the agent greeting inbound prompt.</param>
        /// <param name="OutboundPromptDefaultLanguage">The default language to use for the agent greeting outbound prompt.</param>
        public AgentGreeting(Prompt InboundPrompt = null, Prompt OutboundPrompt = null, string InboundPromptDefaultLanguage = null, string OutboundPromptDefaultLanguage = null)
        {
            this.InboundPrompt = InboundPrompt;
            this.OutboundPrompt = OutboundPrompt;
            this.InboundPromptDefaultLanguage = InboundPromptDefaultLanguage;
            this.OutboundPromptDefaultLanguage = OutboundPromptDefaultLanguage;
            
        }
        


        /// <summary>
        /// The ID of the associated user.
        /// </summary>
        /// <value>The ID of the associated user.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The agent greeting prompt to use when inbound calls are connected
        /// </summary>
        /// <value>The agent greeting prompt to use when inbound calls are connected</value>
        [DataMember(Name="inboundPrompt", EmitDefaultValue=false)]
        public Prompt InboundPrompt { get; set; }



        /// <summary>
        /// The agent greeting prompt to use when outbound calls are connected
        /// </summary>
        /// <value>The agent greeting prompt to use when outbound calls are connected</value>
        [DataMember(Name="outboundPrompt", EmitDefaultValue=false)]
        public Prompt OutboundPrompt { get; set; }



        /// <summary>
        /// The default language to use for the agent greeting inbound prompt
        /// </summary>
        /// <value>The default language to use for the agent greeting inbound prompt</value>
        [DataMember(Name="inboundPromptDefaultLanguage", EmitDefaultValue=false)]
        public string InboundPromptDefaultLanguage { get; set; }



        /// <summary>
        /// The default language to use for the agent greeting outbound prompt
        /// </summary>
        /// <value>The default language to use for the agent greeting outbound prompt</value>
        [DataMember(Name="outboundPromptDefaultLanguage", EmitDefaultValue=false)]
        public string OutboundPromptDefaultLanguage { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentGreeting {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InboundPrompt: ").Append(InboundPrompt).Append("\n");
            sb.Append("  OutboundPrompt: ").Append(OutboundPrompt).Append("\n");
            sb.Append("  InboundPromptDefaultLanguage: ").Append(InboundPromptDefaultLanguage).Append("\n");
            sb.Append("  OutboundPromptDefaultLanguage: ").Append(OutboundPromptDefaultLanguage).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as AgentGreeting);
        }

        /// <summary>
        /// Returns true if AgentGreeting instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentGreeting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentGreeting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.InboundPrompt == other.InboundPrompt ||
                    this.InboundPrompt != null &&
                    this.InboundPrompt.Equals(other.InboundPrompt)
                ) &&
                (
                    this.OutboundPrompt == other.OutboundPrompt ||
                    this.OutboundPrompt != null &&
                    this.OutboundPrompt.Equals(other.OutboundPrompt)
                ) &&
                (
                    this.InboundPromptDefaultLanguage == other.InboundPromptDefaultLanguage ||
                    this.InboundPromptDefaultLanguage != null &&
                    this.InboundPromptDefaultLanguage.Equals(other.InboundPromptDefaultLanguage)
                ) &&
                (
                    this.OutboundPromptDefaultLanguage == other.OutboundPromptDefaultLanguage ||
                    this.OutboundPromptDefaultLanguage != null &&
                    this.OutboundPromptDefaultLanguage.Equals(other.OutboundPromptDefaultLanguage)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.InboundPrompt != null)
                    hash = hash * 59 + this.InboundPrompt.GetHashCode();

                if (this.OutboundPrompt != null)
                    hash = hash * 59 + this.OutboundPrompt.GetHashCode();

                if (this.InboundPromptDefaultLanguage != null)
                    hash = hash * 59 + this.InboundPromptDefaultLanguage.GetHashCode();

                if (this.OutboundPromptDefaultLanguage != null)
                    hash = hash * 59 + this.OutboundPromptDefaultLanguage.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
