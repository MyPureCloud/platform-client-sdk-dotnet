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
    /// Agent
    /// </summary>
    [DataContract]
    public partial class Agent :  IEquatable<Agent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="Stage">The current stage for this agent.</param>
        public Agent(string Stage = null)
        {
            this.Stage = Stage;
            
        }
        


        /// <summary>
        /// The current stage for this agent
        /// </summary>
        /// <value>The current stage for this agent</value>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public string Stage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Agent {\n");

            sb.Append("  Stage: ").Append(Stage).Append("\n");
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
            return this.Equals(obj as Agent);
        }

        /// <summary>
        /// Returns true if Agent instances are equal
        /// </summary>
        /// <param name="other">Instance of Agent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Agent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Stage == other.Stage ||
                    this.Stage != null &&
                    this.Stage.Equals(other.Stage)
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
                if (this.Stage != null)
                    hash = hash * 59 + this.Stage.GetHashCode();

                return hash;
            }
        }
    }

}
