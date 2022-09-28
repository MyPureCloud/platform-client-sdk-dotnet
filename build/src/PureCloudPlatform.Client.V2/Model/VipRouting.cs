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
    /// VipRouting
    /// </summary>
    [DataContract]
    public partial class VipRouting :  IEquatable<VipRouting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VipRouting" /> class.
        /// </summary>
        /// <param name="VipCallMediaSettings">VIP Settings specific to Call media..</param>
        /// <param name="VipEmailMediaSettings">VIP Settings specific to Email media..</param>
        /// <param name="VipMessageMediaSettings">VIP Settings specific to Message media..</param>
        /// <param name="VipMaxOwnershipTimeSeconds">The max amount of time a VIP interaction will wait for the VIP user before going to the selected backup option (in seconds). Allowable range 10 seconds - 864000 seconds (ten days)..</param>
        /// <param name="VipBackup">VIP queue default VIP Backup settings for unanswered VIP interactions to fallback to. VIP Backup set for a specific VIP user has preference before queue default..</param>
        public VipRouting(VipCallMediaSettings VipCallMediaSettings = null, VipMediaSettings VipEmailMediaSettings = null, VipMediaSettings VipMessageMediaSettings = null, int? VipMaxOwnershipTimeSeconds = null, VipBackup VipBackup = null)
        {
            this.VipCallMediaSettings = VipCallMediaSettings;
            this.VipEmailMediaSettings = VipEmailMediaSettings;
            this.VipMessageMediaSettings = VipMessageMediaSettings;
            this.VipMaxOwnershipTimeSeconds = VipMaxOwnershipTimeSeconds;
            this.VipBackup = VipBackup;
            
        }
        


        /// <summary>
        /// VIP Settings specific to Call media.
        /// </summary>
        /// <value>VIP Settings specific to Call media.</value>
        [DataMember(Name="vipCallMediaSettings", EmitDefaultValue=false)]
        public VipCallMediaSettings VipCallMediaSettings { get; set; }



        /// <summary>
        /// VIP Settings specific to Email media.
        /// </summary>
        /// <value>VIP Settings specific to Email media.</value>
        [DataMember(Name="vipEmailMediaSettings", EmitDefaultValue=false)]
        public VipMediaSettings VipEmailMediaSettings { get; set; }



        /// <summary>
        /// VIP Settings specific to Message media.
        /// </summary>
        /// <value>VIP Settings specific to Message media.</value>
        [DataMember(Name="vipMessageMediaSettings", EmitDefaultValue=false)]
        public VipMediaSettings VipMessageMediaSettings { get; set; }



        /// <summary>
        /// The max amount of time a VIP interaction will wait for the VIP user before going to the selected backup option (in seconds). Allowable range 10 seconds - 864000 seconds (ten days).
        /// </summary>
        /// <value>The max amount of time a VIP interaction will wait for the VIP user before going to the selected backup option (in seconds). Allowable range 10 seconds - 864000 seconds (ten days).</value>
        [DataMember(Name="vipMaxOwnershipTimeSeconds", EmitDefaultValue=false)]
        public int? VipMaxOwnershipTimeSeconds { get; set; }



        /// <summary>
        /// VIP queue default VIP Backup settings for unanswered VIP interactions to fallback to. VIP Backup set for a specific VIP user has preference before queue default.
        /// </summary>
        /// <value>VIP queue default VIP Backup settings for unanswered VIP interactions to fallback to. VIP Backup set for a specific VIP user has preference before queue default.</value>
        [DataMember(Name="vipBackup", EmitDefaultValue=false)]
        public VipBackup VipBackup { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VipRouting {\n");

            sb.Append("  VipCallMediaSettings: ").Append(VipCallMediaSettings).Append("\n");
            sb.Append("  VipEmailMediaSettings: ").Append(VipEmailMediaSettings).Append("\n");
            sb.Append("  VipMessageMediaSettings: ").Append(VipMessageMediaSettings).Append("\n");
            sb.Append("  VipMaxOwnershipTimeSeconds: ").Append(VipMaxOwnershipTimeSeconds).Append("\n");
            sb.Append("  VipBackup: ").Append(VipBackup).Append("\n");
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
            return this.Equals(obj as VipRouting);
        }

        /// <summary>
        /// Returns true if VipRouting instances are equal
        /// </summary>
        /// <param name="other">Instance of VipRouting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VipRouting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.VipCallMediaSettings == other.VipCallMediaSettings ||
                    this.VipCallMediaSettings != null &&
                    this.VipCallMediaSettings.Equals(other.VipCallMediaSettings)
                ) &&
                (
                    this.VipEmailMediaSettings == other.VipEmailMediaSettings ||
                    this.VipEmailMediaSettings != null &&
                    this.VipEmailMediaSettings.Equals(other.VipEmailMediaSettings)
                ) &&
                (
                    this.VipMessageMediaSettings == other.VipMessageMediaSettings ||
                    this.VipMessageMediaSettings != null &&
                    this.VipMessageMediaSettings.Equals(other.VipMessageMediaSettings)
                ) &&
                (
                    this.VipMaxOwnershipTimeSeconds == other.VipMaxOwnershipTimeSeconds ||
                    this.VipMaxOwnershipTimeSeconds != null &&
                    this.VipMaxOwnershipTimeSeconds.Equals(other.VipMaxOwnershipTimeSeconds)
                ) &&
                (
                    this.VipBackup == other.VipBackup ||
                    this.VipBackup != null &&
                    this.VipBackup.Equals(other.VipBackup)
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
                if (this.VipCallMediaSettings != null)
                    hash = hash * 59 + this.VipCallMediaSettings.GetHashCode();

                if (this.VipEmailMediaSettings != null)
                    hash = hash * 59 + this.VipEmailMediaSettings.GetHashCode();

                if (this.VipMessageMediaSettings != null)
                    hash = hash * 59 + this.VipMessageMediaSettings.GetHashCode();

                if (this.VipMaxOwnershipTimeSeconds != null)
                    hash = hash * 59 + this.VipMaxOwnershipTimeSeconds.GetHashCode();

                if (this.VipBackup != null)
                    hash = hash * 59 + this.VipBackup.GetHashCode();

                return hash;
            }
        }
    }

}
