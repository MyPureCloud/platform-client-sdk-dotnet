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
    /// Model for setting the launch configuration for Nuance bots available to Genesys Cloud
    /// </summary>
    [DataContract]
    public partial class NuanceBotLaunchSettings :  IEquatable<NuanceBotLaunchSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NuanceBotLaunchSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NuanceBotLaunchSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NuanceBotLaunchSettings" /> class.
        /// </summary>
        /// <param name="BotExecutionConfigurations">The list of Nuance bots that are configured as available to the Genesys Cloud system (required).</param>
        public NuanceBotLaunchSettings(List<BotExecutionConfiguration> BotExecutionConfigurations = null)
        {
            this.BotExecutionConfigurations = BotExecutionConfigurations;
            
        }
        


        /// <summary>
        /// The list of Nuance bots that are configured as available to the Genesys Cloud system
        /// </summary>
        /// <value>The list of Nuance bots that are configured as available to the Genesys Cloud system</value>
        [DataMember(Name="botExecutionConfigurations", EmitDefaultValue=false)]
        public List<BotExecutionConfiguration> BotExecutionConfigurations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NuanceBotLaunchSettings {\n");

            sb.Append("  BotExecutionConfigurations: ").Append(BotExecutionConfigurations).Append("\n");
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
            return this.Equals(obj as NuanceBotLaunchSettings);
        }

        /// <summary>
        /// Returns true if NuanceBotLaunchSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of NuanceBotLaunchSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NuanceBotLaunchSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BotExecutionConfigurations == other.BotExecutionConfigurations ||
                    this.BotExecutionConfigurations != null &&
                    this.BotExecutionConfigurations.SequenceEqual(other.BotExecutionConfigurations)
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
                if (this.BotExecutionConfigurations != null)
                    hash = hash * 59 + this.BotExecutionConfigurations.GetHashCode();

                return hash;
            }
        }
    }

}
