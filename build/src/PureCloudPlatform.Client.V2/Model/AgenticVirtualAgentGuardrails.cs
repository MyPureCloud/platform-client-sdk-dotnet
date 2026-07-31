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
    /// Guardrail rules for a virtual agent.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentGuardrails :  IEquatable<AgenticVirtualAgentGuardrails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentGuardrails" /> class.
        /// </summary>
        /// <param name="Custom">Custom guardrail rules used to detect and block matching user behavior..</param>
        public AgenticVirtualAgentGuardrails(List<AgenticVirtualAgentGuardrailInstruction> Custom = null)
        {
            this.Custom = Custom;
            
        }
        


        /// <summary>
        /// Custom guardrail rules used to detect and block matching user behavior.
        /// </summary>
        /// <value>Custom guardrail rules used to detect and block matching user behavior.</value>
        [DataMember(Name="custom", EmitDefaultValue=false)]
        public List<AgenticVirtualAgentGuardrailInstruction> Custom { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentGuardrails {\n");

            sb.Append("  Custom: ").Append(Custom).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentGuardrails);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentGuardrails instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentGuardrails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentGuardrails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Custom == other.Custom ||
                    this.Custom != null &&
                    this.Custom.SequenceEqual(other.Custom)
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
                if (this.Custom != null)
                    hash = hash * 59 + this.Custom.GetHashCode();

                return hash;
            }
        }
    }

}
