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
    /// FreeTrialLimitDocs
    /// </summary>
    [DataContract]
    public partial class FreeTrialLimitDocs :  IEquatable<FreeTrialLimitDocs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FreeTrialLimitDocs" /> class.
        /// </summary>
        /// <param name="Namespaces">Namespaces.</param>
        public FreeTrialLimitDocs(List<FreeTrialNamespace> Namespaces = null)
        {
            this.Namespaces = Namespaces;
            
        }
        


        /// <summary>
        /// Gets or Sets Namespaces
        /// </summary>
        [DataMember(Name="namespaces", EmitDefaultValue=false)]
        public List<FreeTrialNamespace> Namespaces { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeTrialLimitDocs {\n");

            sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
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
            return this.Equals(obj as FreeTrialLimitDocs);
        }

        /// <summary>
        /// Returns true if FreeTrialLimitDocs instances are equal
        /// </summary>
        /// <param name="other">Instance of FreeTrialLimitDocs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FreeTrialLimitDocs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Namespaces == other.Namespaces ||
                    this.Namespaces != null &&
                    this.Namespaces.SequenceEqual(other.Namespaces)
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
                if (this.Namespaces != null)
                    hash = hash * 59 + this.Namespaces.GetHashCode();

                return hash;
            }
        }
    }

}
