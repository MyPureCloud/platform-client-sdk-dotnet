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
    /// EdgeOfflineConfigurationNetwork
    /// </summary>
    [DataContract]
    public partial class EdgeOfflineConfigurationNetwork :  IEquatable<EdgeOfflineConfigurationNetwork>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeOfflineConfigurationNetwork" /> class.
        /// </summary>
        /// <param name="Wan">Settings for the Edge WAN interface..</param>
        public EdgeOfflineConfigurationNetwork(EdgeOfflineConfigurationInterface Wan = null)
        {
            this.Wan = Wan;
            
        }
        


        /// <summary>
        /// Settings for the Edge WAN interface.
        /// </summary>
        /// <value>Settings for the Edge WAN interface.</value>
        [DataMember(Name="wan", EmitDefaultValue=false)]
        public EdgeOfflineConfigurationInterface Wan { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeOfflineConfigurationNetwork {\n");

            sb.Append("  Wan: ").Append(Wan).Append("\n");
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
            return this.Equals(obj as EdgeOfflineConfigurationNetwork);
        }

        /// <summary>
        /// Returns true if EdgeOfflineConfigurationNetwork instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeOfflineConfigurationNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeOfflineConfigurationNetwork other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Wan == other.Wan ||
                    this.Wan != null &&
                    this.Wan.Equals(other.Wan)
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
                if (this.Wan != null)
                    hash = hash * 59 + this.Wan.GetHashCode();

                return hash;
            }
        }
    }

}
