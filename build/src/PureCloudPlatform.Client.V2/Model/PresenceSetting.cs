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
    /// PresenceSetting
    /// </summary>
    [DataContract]
    public partial class PresenceSetting :  IEquatable<PresenceSetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceSetting" /> class.
        /// </summary>
        /// <param name="Join">Should Presence Events be sent.</param>
        public PresenceSetting(SettingDirection Join = null)
        {
            this.Join = Join;
            
        }
        


        /// <summary>
        /// Should Presence Events be sent
        /// </summary>
        /// <value>Should Presence Events be sent</value>
        [DataMember(Name="join", EmitDefaultValue=false)]
        public SettingDirection Join { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresenceSetting {\n");

            sb.Append("  Join: ").Append(Join).Append("\n");
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
            return this.Equals(obj as PresenceSetting);
        }

        /// <summary>
        /// Returns true if PresenceSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of PresenceSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenceSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Join == other.Join ||
                    this.Join != null &&
                    this.Join.Equals(other.Join)
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
                if (this.Join != null)
                    hash = hash * 59 + this.Join.GetHashCode();

                return hash;
            }
        }
    }

}
