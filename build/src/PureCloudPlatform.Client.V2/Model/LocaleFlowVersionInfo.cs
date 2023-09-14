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
    /// LocaleFlowVersionInfo
    /// </summary>
    [DataContract]
    public partial class LocaleFlowVersionInfo :  IEquatable<LocaleFlowVersionInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocaleFlowVersionInfo" /> class.
        /// </summary>
        /// <param name="NluVersion">NLU Version Info for this flow version..</param>
        public LocaleFlowVersionInfo(AddressableEntityRef NluVersion = null)
        {
            this.NluVersion = NluVersion;
            
        }
        


        /// <summary>
        /// NLU Version Info for this flow version.
        /// </summary>
        /// <value>NLU Version Info for this flow version.</value>
        [DataMember(Name="nluVersion", EmitDefaultValue=false)]
        public AddressableEntityRef NluVersion { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocaleFlowVersionInfo {\n");

            sb.Append("  NluVersion: ").Append(NluVersion).Append("\n");
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
            return this.Equals(obj as LocaleFlowVersionInfo);
        }

        /// <summary>
        /// Returns true if LocaleFlowVersionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of LocaleFlowVersionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocaleFlowVersionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.NluVersion == other.NluVersion ||
                    this.NluVersion != null &&
                    this.NluVersion.Equals(other.NluVersion)
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
                if (this.NluVersion != null)
                    hash = hash * 59 + this.NluVersion.GetHashCode();

                return hash;
            }
        }
    }

}
