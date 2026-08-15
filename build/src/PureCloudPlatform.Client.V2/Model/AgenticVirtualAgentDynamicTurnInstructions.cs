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
    /// Instructions dynamically added to the virtual agent based on conversation state.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentDynamicTurnInstructions :  IEquatable<AgenticVirtualAgentDynamicTurnInstructions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentDynamicTurnInstructions" /> class.
        /// </summary>
        /// <param name="RepetitionChecks">Checks that can be configured to add dynamic instructions for the agent, if user / agent messages repeat..</param>
        public AgenticVirtualAgentDynamicTurnInstructions(List<AgenticVirtualAgentRepetitionCheck> RepetitionChecks = null)
        {
            this.RepetitionChecks = RepetitionChecks;
            
        }
        


        /// <summary>
        /// Checks that can be configured to add dynamic instructions for the agent, if user / agent messages repeat.
        /// </summary>
        /// <value>Checks that can be configured to add dynamic instructions for the agent, if user / agent messages repeat.</value>
        [DataMember(Name="repetitionChecks", EmitDefaultValue=false)]
        public List<AgenticVirtualAgentRepetitionCheck> RepetitionChecks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentDynamicTurnInstructions {\n");

            sb.Append("  RepetitionChecks: ").Append(RepetitionChecks).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentDynamicTurnInstructions);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentDynamicTurnInstructions instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentDynamicTurnInstructions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentDynamicTurnInstructions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RepetitionChecks == other.RepetitionChecks ||
                    this.RepetitionChecks != null &&
                    this.RepetitionChecks.SequenceEqual(other.RepetitionChecks)
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
                if (this.RepetitionChecks != null)
                    hash = hash * 59 + this.RepetitionChecks.GetHashCode();

                return hash;
            }
        }
    }

}
