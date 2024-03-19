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
    /// NamespaceDocs
    /// </summary>
    [DataContract]
    public partial class NamespaceDocs :  IEquatable<NamespaceDocs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceDocs" /> class.
        /// </summary>
        /// <param name="FriendlyName">FriendlyName.</param>
        /// <param name="Limits">Limits.</param>
        public NamespaceDocs(string FriendlyName = null, List<LimitDocs> Limits = null)
        {
            this.FriendlyName = FriendlyName;
            this.Limits = Limits;
            
        }
        


        /// <summary>
        /// Gets or Sets FriendlyName
        /// </summary>
        [DataMember(Name="friendlyName", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }



        /// <summary>
        /// Gets or Sets Limits
        /// </summary>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<LimitDocs> Limits { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamespaceDocs {\n");

            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
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
            return this.Equals(obj as NamespaceDocs);
        }

        /// <summary>
        /// Returns true if NamespaceDocs instances are equal
        /// </summary>
        /// <param name="other">Instance of NamespaceDocs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamespaceDocs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FriendlyName == other.FriendlyName ||
                    this.FriendlyName != null &&
                    this.FriendlyName.Equals(other.FriendlyName)
                ) &&
                (
                    this.Limits == other.Limits ||
                    this.Limits != null &&
                    this.Limits.SequenceEqual(other.Limits)
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
                if (this.FriendlyName != null)
                    hash = hash * 59 + this.FriendlyName.GetHashCode();

                if (this.Limits != null)
                    hash = hash * 59 + this.Limits.GetHashCode();

                return hash;
            }
        }
    }

}
