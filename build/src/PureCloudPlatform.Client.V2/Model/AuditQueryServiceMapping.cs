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
    /// AuditQueryServiceMapping
    /// </summary>
    [DataContract]
    public partial class AuditQueryServiceMapping :  IEquatable<AuditQueryServiceMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditQueryServiceMapping" /> class.
        /// </summary>
        /// <param name="Services">List of Services.</param>
        public AuditQueryServiceMapping(List<AuditQueryService> Services = null)
        {
            this.Services = Services;
            
        }
        


        /// <summary>
        /// List of Services
        /// </summary>
        /// <value>List of Services</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<AuditQueryService> Services { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditQueryServiceMapping {\n");

            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return this.Equals(obj as AuditQueryServiceMapping);
        }

        /// <summary>
        /// Returns true if AuditQueryServiceMapping instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditQueryServiceMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditQueryServiceMapping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Services == other.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(other.Services)
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
                if (this.Services != null)
                    hash = hash * 59 + this.Services.GetHashCode();

                return hash;
            }
        }
    }

}
