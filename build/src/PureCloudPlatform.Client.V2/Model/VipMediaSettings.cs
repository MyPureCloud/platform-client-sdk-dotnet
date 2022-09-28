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
    /// VipMediaSettings
    /// </summary>
    [DataContract]
    public partial class VipMediaSettings :  IEquatable<VipMediaSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VipMediaSettings" /> class.
        /// </summary>
        /// <param name="Enabled">Toggle that enables VIP experience for this feature..</param>
        /// <param name="SkipOwnershipTime">Toggle that enables this media type to fallback immediately to the configured VIP Backup..</param>
        public VipMediaSettings(bool? Enabled = null, bool? SkipOwnershipTime = null)
        {
            this.Enabled = Enabled;
            this.SkipOwnershipTime = SkipOwnershipTime;
            
        }
        


        /// <summary>
        /// Toggle that enables VIP experience for this feature.
        /// </summary>
        /// <value>Toggle that enables VIP experience for this feature.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Toggle that enables this media type to fallback immediately to the configured VIP Backup.
        /// </summary>
        /// <value>Toggle that enables this media type to fallback immediately to the configured VIP Backup.</value>
        [DataMember(Name="skipOwnershipTime", EmitDefaultValue=false)]
        public bool? SkipOwnershipTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VipMediaSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SkipOwnershipTime: ").Append(SkipOwnershipTime).Append("\n");
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
            return this.Equals(obj as VipMediaSettings);
        }

        /// <summary>
        /// Returns true if VipMediaSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of VipMediaSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VipMediaSettings other)
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
                    this.SkipOwnershipTime == other.SkipOwnershipTime ||
                    this.SkipOwnershipTime != null &&
                    this.SkipOwnershipTime.Equals(other.SkipOwnershipTime)
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

                if (this.SkipOwnershipTime != null)
                    hash = hash * 59 + this.SkipOwnershipTime.GetHashCode();

                return hash;
            }
        }
    }

}
