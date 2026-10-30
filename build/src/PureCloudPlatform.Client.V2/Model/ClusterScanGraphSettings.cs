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
    /// ClusterScanGraphSettings
    /// </summary>
    [DataContract]
    public partial class ClusterScanGraphSettings :  IEquatable<ClusterScanGraphSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterScanGraphSettings" /> class.
        /// </summary>
        /// <param name="AutomaticMergingEnabled">Whether to enable automatic merging of discovered clusters.</param>
        public ClusterScanGraphSettings(bool? AutomaticMergingEnabled = null)
        {
            this.AutomaticMergingEnabled = AutomaticMergingEnabled;
            
        }
        


        /// <summary>
        /// Whether to enable automatic merging of discovered clusters
        /// </summary>
        /// <value>Whether to enable automatic merging of discovered clusters</value>
        [DataMember(Name="automaticMergingEnabled", EmitDefaultValue=false)]
        public bool? AutomaticMergingEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterScanGraphSettings {\n");

            sb.Append("  AutomaticMergingEnabled: ").Append(AutomaticMergingEnabled).Append("\n");
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
            return this.Equals(obj as ClusterScanGraphSettings);
        }

        /// <summary>
        /// Returns true if ClusterScanGraphSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ClusterScanGraphSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterScanGraphSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AutomaticMergingEnabled == other.AutomaticMergingEnabled ||
                    this.AutomaticMergingEnabled != null &&
                    this.AutomaticMergingEnabled.Equals(other.AutomaticMergingEnabled)
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
                if (this.AutomaticMergingEnabled != null)
                    hash = hash * 59 + this.AutomaticMergingEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
