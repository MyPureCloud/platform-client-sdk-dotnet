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
    /// AiScoringSettings
    /// </summary>
    [DataContract]
    public partial class AiScoringSettings :  IEquatable<AiScoringSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AiScoringSettings" /> class.
        /// </summary>
        /// <param name="Enabled">True if AI scoring feature is configured, false if not..</param>
        /// <param name="Prompt">The prompt text that would be used by a LLM..</param>
        public AiScoringSettings(bool? Enabled = null, string Prompt = null)
        {
            this.Enabled = Enabled;
            this.Prompt = Prompt;
            
        }
        


        /// <summary>
        /// True if AI scoring feature is configured, false if not.
        /// </summary>
        /// <value>True if AI scoring feature is configured, false if not.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The prompt text that would be used by a LLM.
        /// </summary>
        /// <value>The prompt text that would be used by a LLM.</value>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiScoringSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
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
            return this.Equals(obj as AiScoringSettings);
        }

        /// <summary>
        /// Returns true if AiScoringSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AiScoringSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AiScoringSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Prompt == other.Prompt ||
                    this.Prompt != null &&
                    this.Prompt.Equals(other.Prompt)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Prompt != null)
                    hash = hash * 59 + this.Prompt.GetHashCode();

                return hash;
            }
        }
    }

}
