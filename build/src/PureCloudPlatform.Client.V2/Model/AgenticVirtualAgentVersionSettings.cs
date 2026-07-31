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
    /// Runtime behavior settings for a virtual agent.
    /// </summary>
    [DataContract]
    public partial class AgenticVirtualAgentVersionSettings :  IEquatable<AgenticVirtualAgentVersionSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticVirtualAgentVersionSettings" /> class.
        /// </summary>
        /// <param name="ComfortStatement">Comfort statement settings for tool calls..</param>
        public AgenticVirtualAgentVersionSettings(AgenticVirtualAgentComfortStatementSettings ComfortStatement = null)
        {
            this.ComfortStatement = ComfortStatement;
            
        }
        


        /// <summary>
        /// Comfort statement settings for tool calls.
        /// </summary>
        /// <value>Comfort statement settings for tool calls.</value>
        [DataMember(Name="comfortStatement", EmitDefaultValue=false)]
        public AgenticVirtualAgentComfortStatementSettings ComfortStatement { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenticVirtualAgentVersionSettings {\n");

            sb.Append("  ComfortStatement: ").Append(ComfortStatement).Append("\n");
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
            return this.Equals(obj as AgenticVirtualAgentVersionSettings);
        }

        /// <summary>
        /// Returns true if AgenticVirtualAgentVersionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AgenticVirtualAgentVersionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgenticVirtualAgentVersionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ComfortStatement == other.ComfortStatement ||
                    this.ComfortStatement != null &&
                    this.ComfortStatement.Equals(other.ComfortStatement)
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
                if (this.ComfortStatement != null)
                    hash = hash * 59 + this.ComfortStatement.GetHashCode();

                return hash;
            }
        }
    }

}
