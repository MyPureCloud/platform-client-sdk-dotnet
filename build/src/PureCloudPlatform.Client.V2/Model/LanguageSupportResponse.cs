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
    /// LanguageSupportResponse
    /// </summary>
    [DataContract]
    public partial class LanguageSupportResponse :  IEquatable<LanguageSupportResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageSupportResponse" /> class.
        /// </summary>
        public LanguageSupportResponse()
        {
            
        }
        


        /// <summary>
        /// List of feature support information by language.
        /// </summary>
        /// <value>List of feature support information by language.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguageSupportInfoRecord> Languages { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageSupportResponse {\n");

            sb.Append("  Languages: ").Append(Languages).Append("\n");
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
            return this.Equals(obj as LanguageSupportResponse);
        }

        /// <summary>
        /// Returns true if LanguageSupportResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LanguageSupportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageSupportResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Languages == other.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(other.Languages)
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
                if (this.Languages != null)
                    hash = hash * 59 + this.Languages.GetHashCode();

                return hash;
            }
        }
    }

}
