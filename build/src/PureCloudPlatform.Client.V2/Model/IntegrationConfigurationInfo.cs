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
    /// Configuration information for the integration
    /// </summary>
    [DataContract]
    public partial class IntegrationConfigurationInfo :  IEquatable<IntegrationConfigurationInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationConfigurationInfo" /> class.
        /// </summary>
        public IntegrationConfigurationInfo()
        {
            
        }
        


        /// <summary>
        /// The current, active configuration for the integration.
        /// </summary>
        /// <value>The current, active configuration for the integration.</value>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public IntegrationConfiguration Current { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationConfigurationInfo {\n");

            sb.Append("  Current: ").Append(Current).Append("\n");
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
            return this.Equals(obj as IntegrationConfigurationInfo);
        }

        /// <summary>
        /// Returns true if IntegrationConfigurationInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegrationConfigurationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationConfigurationInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Current == other.Current ||
                    this.Current != null &&
                    this.Current.Equals(other.Current)
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
                if (this.Current != null)
                    hash = hash * 59 + this.Current.GetHashCode();

                return hash;
            }
        }
    }

}
