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
    /// PhraseAssociations
    /// </summary>
    [DataContract]
    public partial class PhraseAssociations :  IEquatable<PhraseAssociations>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PhraseAssociations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhraseAssociations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhraseAssociations" /> class.
        /// </summary>
        /// <param name="PhraseId">Id of the phrase to be linked (required).</param>
        /// <param name="DocumentId">Id of the document to be linked (required).</param>
        public PhraseAssociations(string PhraseId = null, string DocumentId = null)
        {
            this.PhraseId = PhraseId;
            this.DocumentId = DocumentId;
            
        }
        


        /// <summary>
        /// Id of the phrase to be linked
        /// </summary>
        /// <value>Id of the phrase to be linked</value>
        [DataMember(Name="phraseId", EmitDefaultValue=false)]
        public string PhraseId { get; set; }



        /// <summary>
        /// Id of the document to be linked
        /// </summary>
        /// <value>Id of the document to be linked</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhraseAssociations {\n");

            sb.Append("  PhraseId: ").Append(PhraseId).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
            return this.Equals(obj as PhraseAssociations);
        }

        /// <summary>
        /// Returns true if PhraseAssociations instances are equal
        /// </summary>
        /// <param name="other">Instance of PhraseAssociations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhraseAssociations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PhraseId == other.PhraseId ||
                    this.PhraseId != null &&
                    this.PhraseId.Equals(other.PhraseId)
                ) &&
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
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
                if (this.PhraseId != null)
                    hash = hash * 59 + this.PhraseId.GetHashCode();

                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();

                return hash;
            }
        }
    }

}
