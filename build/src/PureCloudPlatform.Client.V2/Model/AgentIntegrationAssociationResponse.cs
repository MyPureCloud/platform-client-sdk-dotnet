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
    /// AgentIntegrationAssociationResponse
    /// </summary>
    [DataContract]
    public partial class AgentIntegrationAssociationResponse :  IEquatable<AgentIntegrationAssociationResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationAssociationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentIntegrationAssociationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIntegrationAssociationResponse" /> class.
        /// </summary>
        /// <param name="AgentExternalId">ID of the agent in external system (required).</param>
        /// <param name="Integration">The integration associated with the agent (required).</param>
        /// <param name="Locked">Whether agentExternalId should be protected from update by automatic processes (required).</param>
        public AgentIntegrationAssociationResponse(string AgentExternalId = null, WfmIntegrationReference Integration = null, bool? Locked = null)
        {
            this.AgentExternalId = AgentExternalId;
            this.Integration = Integration;
            this.Locked = Locked;
            
        }
        


        /// <summary>
        /// ID of the agent in external system
        /// </summary>
        /// <value>ID of the agent in external system</value>
        [DataMember(Name="agentExternalId", EmitDefaultValue=false)]
        public string AgentExternalId { get; set; }



        /// <summary>
        /// The integration associated with the agent
        /// </summary>
        /// <value>The integration associated with the agent</value>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public WfmIntegrationReference Integration { get; set; }



        /// <summary>
        /// Whether agentExternalId should be protected from update by automatic processes
        /// </summary>
        /// <value>Whether agentExternalId should be protected from update by automatic processes</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentIntegrationAssociationResponse {\n");

            sb.Append("  AgentExternalId: ").Append(AgentExternalId).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
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
            return this.Equals(obj as AgentIntegrationAssociationResponse);
        }

        /// <summary>
        /// Returns true if AgentIntegrationAssociationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentIntegrationAssociationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentIntegrationAssociationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentExternalId == other.AgentExternalId ||
                    this.AgentExternalId != null &&
                    this.AgentExternalId.Equals(other.AgentExternalId)
                ) &&
                (
                    this.Integration == other.Integration ||
                    this.Integration != null &&
                    this.Integration.Equals(other.Integration)
                ) &&
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
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
                if (this.AgentExternalId != null)
                    hash = hash * 59 + this.AgentExternalId.GetHashCode();

                if (this.Integration != null)
                    hash = hash * 59 + this.Integration.GetHashCode();

                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();

                return hash;
            }
        }
    }

}
