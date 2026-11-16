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
    /// CredentialPropertiesOutput
    /// </summary>
    [DataContract]
    public partial class CredentialPropertiesOutput :  IEquatable<CredentialPropertiesOutput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialPropertiesOutput" /> class.
        /// </summary>
        /// <param name="Rk">Whether the credential is a resident (discoverable) credential..</param>
        public CredentialPropertiesOutput(bool? Rk = null)
        {
            this.Rk = Rk;
            
        }
        


        /// <summary>
        /// Whether the credential is a resident (discoverable) credential.
        /// </summary>
        /// <value>Whether the credential is a resident (discoverable) credential.</value>
        [DataMember(Name="rk", EmitDefaultValue=false)]
        public bool? Rk { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialPropertiesOutput {\n");

            sb.Append("  Rk: ").Append(Rk).Append("\n");
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
            return this.Equals(obj as CredentialPropertiesOutput);
        }

        /// <summary>
        /// Returns true if CredentialPropertiesOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of CredentialPropertiesOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialPropertiesOutput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Rk == other.Rk ||
                    this.Rk != null &&
                    this.Rk.Equals(other.Rk)
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
                if (this.Rk != null)
                    hash = hash * 59 + this.Rk.GetHashCode();

                return hash;
            }
        }
    }

}
