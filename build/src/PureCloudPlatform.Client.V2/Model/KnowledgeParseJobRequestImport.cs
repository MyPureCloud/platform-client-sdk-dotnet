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
    /// KnowledgeParseJobRequestImport
    /// </summary>
    [DataContract]
    public partial class KnowledgeParseJobRequestImport :  IEquatable<KnowledgeParseJobRequestImport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeParseJobRequestImport" /> class.
        /// </summary>
        /// <param name="Edits">Override of the result of the parse..</param>
        /// <param name="Excludes">Excluded results..</param>
        public KnowledgeParseJobRequestImport(List<KnowledgeParseRecord> Edits = null, List<string> Excludes = null)
        {
            this.Edits = Edits;
            this.Excludes = Excludes;
            
        }
        


        /// <summary>
        /// Override of the result of the parse.
        /// </summary>
        /// <value>Override of the result of the parse.</value>
        [DataMember(Name="edits", EmitDefaultValue=false)]
        public List<KnowledgeParseRecord> Edits { get; set; }



        /// <summary>
        /// Excluded results.
        /// </summary>
        /// <value>Excluded results.</value>
        [DataMember(Name="excludes", EmitDefaultValue=false)]
        public List<string> Excludes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeParseJobRequestImport {\n");

            sb.Append("  Edits: ").Append(Edits).Append("\n");
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
            return this.Equals(obj as KnowledgeParseJobRequestImport);
        }

        /// <summary>
        /// Returns true if KnowledgeParseJobRequestImport instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeParseJobRequestImport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeParseJobRequestImport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Edits == other.Edits ||
                    this.Edits != null &&
                    this.Edits.SequenceEqual(other.Edits)
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
                if (this.Edits != null)
                    hash = hash * 59 + this.Edits.GetHashCode();

                if (this.Excludes != null)
                    hash = hash * 59 + this.Excludes.GetHashCode();

                return hash;
            }
        }
    }

}
