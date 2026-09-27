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
    /// CaseExternalIdUpdate
    /// </summary>
    [DataContract]
    public partial class CaseExternalIdUpdate :  IEquatable<CaseExternalIdUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseExternalIdUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseExternalIdUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseExternalIdUpdate" /> class.
        /// </summary>
        /// <param name="ExternalId">The identifier of the Case in an external system. Minimum length is 1 character. Maximum length of 64 characters. (required).</param>
        public CaseExternalIdUpdate(string ExternalId = null)
        {
            this.ExternalId = ExternalId;
            
        }
        


        /// <summary>
        /// The identifier of the Case in an external system. Minimum length is 1 character. Maximum length of 64 characters.
        /// </summary>
        /// <value>The identifier of the Case in an external system. Minimum length is 1 character. Maximum length of 64 characters.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseExternalIdUpdate {\n");

            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
            return this.Equals(obj as CaseExternalIdUpdate);
        }

        /// <summary>
        /// Returns true if CaseExternalIdUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseExternalIdUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseExternalIdUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
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
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();

                return hash;
            }
        }
    }

}
