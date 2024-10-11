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
    /// SocialKeyword
    /// </summary>
    [DataContract]
    public partial class SocialKeyword :  IEquatable<SocialKeyword>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialKeyword" /> class.
        /// </summary>
        /// <param name="Includes">List of keywords that must be included.</param>
        /// <param name="Excludes">List of keywords that must be excluded.</param>
        public SocialKeyword(List<string> Includes = null, List<string> Excludes = null)
        {
            this.Includes = Includes;
            this.Excludes = Excludes;
            
        }
        


        /// <summary>
        /// List of keywords that must be included
        /// </summary>
        /// <value>List of keywords that must be included</value>
        [DataMember(Name="includes", EmitDefaultValue=false)]
        public List<string> Includes { get; set; }



        /// <summary>
        /// List of keywords that must be excluded
        /// </summary>
        /// <value>List of keywords that must be excluded</value>
        [DataMember(Name="excludes", EmitDefaultValue=false)]
        public List<string> Excludes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialKeyword {\n");

            sb.Append("  Includes: ").Append(Includes).Append("\n");
            sb.Append("  Excludes: ").Append(Excludes).Append("\n");
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
            return this.Equals(obj as SocialKeyword);
        }

        /// <summary>
        /// Returns true if SocialKeyword instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialKeyword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialKeyword other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Includes == other.Includes ||
                    this.Includes != null &&
                    this.Includes.SequenceEqual(other.Includes)
                ) &&
                (
                    this.Excludes == other.Excludes ||
                    this.Excludes != null &&
                    this.Excludes.SequenceEqual(other.Excludes)
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
                if (this.Includes != null)
                    hash = hash * 59 + this.Includes.GetHashCode();

                if (this.Excludes != null)
                    hash = hash * 59 + this.Excludes.GetHashCode();

                return hash;
            }
        }
    }

}
