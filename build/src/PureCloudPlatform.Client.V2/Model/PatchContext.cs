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
    /// PatchContext
    /// </summary>
    [DataContract]
    public partial class PatchContext :  IEquatable<PatchContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchContext" /> class.
        /// </summary>
        /// <param name="Patterns">A list of one or more patterns to match..</param>
        public PatchContext(List<PatchContextPattern> Patterns = null)
        {
            this.Patterns = Patterns;
            
        }
        


        /// <summary>
        /// A list of one or more patterns to match.
        /// </summary>
        /// <value>A list of one or more patterns to match.</value>
        [DataMember(Name="patterns", EmitDefaultValue=false)]
        public List<PatchContextPattern> Patterns { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchContext {\n");

            sb.Append("  Patterns: ").Append(Patterns).Append("\n");
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
            return this.Equals(obj as PatchContext);
        }

        /// <summary>
        /// Returns true if PatchContext instances are equal
        /// </summary>
        /// <param name="other">Instance of PatchContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Patterns == other.Patterns ||
                    this.Patterns != null &&
                    this.Patterns.SequenceEqual(other.Patterns)
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
                if (this.Patterns != null)
                    hash = hash * 59 + this.Patterns.GetHashCode();

                return hash;
            }
        }
    }

}
