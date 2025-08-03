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
        /// <param name="Name">Name.</param>
        /// <param name="InboundPrompt">The agent greeting prompt to use when the call is connected.</param>
        /// <param name="OutboundPrompt">The agent greeting prompt to use when the call is about to be disconnected.</param>
        public AgentGreeting(string Name = null, Prompt InboundPrompt = null, Prompt OutboundPrompt = null)
        {
            this.Name = Name;
            this.InboundPrompt = InboundPrompt;
            this.OutboundPrompt = OutboundPrompt;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The agent greeting prompt to use when the call is connected
        /// </summary>
        /// <value>The agent greeting prompt to use when the call is connected</value>
        [DataMember(Name="inboundPrompt", EmitDefaultValue=false)]
        public Prompt InboundPrompt { get; set; }



        /// <summary>
        /// The agent greeting prompt to use when the call is about to be disconnected
        /// </summary>
        /// <value>The agent greeting prompt to use when the call is about to be disconnected</value>
        [DataMember(Name="outboundPrompt", EmitDefaultValue=false)]
        public Prompt OutboundPrompt { get; set; }



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
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InboundPrompt: ").Append(InboundPrompt).Append("\n");
            sb.Append("  OutboundPrompt: ").Append(OutboundPrompt).Append("\n");
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.InboundPrompt != null)
                    hash = hash * 59 + this.InboundPrompt.GetHashCode();

                if (this.OutboundPrompt != null)
                    hash = hash * 59 + this.OutboundPrompt.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
