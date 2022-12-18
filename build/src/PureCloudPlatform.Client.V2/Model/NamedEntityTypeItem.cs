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
    /// NamedEntityTypeItem
    /// </summary>
    [DataContract]
    public partial class NamedEntityTypeItem :  IEquatable<NamedEntityTypeItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityTypeItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NamedEntityTypeItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityTypeItem" /> class.
        /// </summary>
        /// <param name="Value">A value for an named entity type definition. (required).</param>
        /// <param name="Synonyms">Synonyms for the given named entity value..</param>
        /// <param name="AdditionalLanguages">Additional Language Synonyms for the given named entity value..</param>
        public NamedEntityTypeItem(string Value = null, List<string> Synonyms = null, Dictionary<string, AdditionalLanguagesSynonyms> AdditionalLanguages = null)
        {
            this.Value = Value;
            this.Synonyms = Synonyms;
            this.AdditionalLanguages = AdditionalLanguages;
            
        }
        


        /// <summary>
        /// A value for an named entity type definition.
        /// </summary>
        /// <value>A value for an named entity type definition.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }



        /// <summary>
        /// Synonyms for the given named entity value.
        /// </summary>
        /// <value>Synonyms for the given named entity value.</value>
        [DataMember(Name="synonyms", EmitDefaultValue=false)]
        public List<string> Synonyms { get; set; }



        /// <summary>
        /// Additional Language Synonyms for the given named entity value.
        /// </summary>
        /// <value>Additional Language Synonyms for the given named entity value.</value>
        [DataMember(Name="additionalLanguages", EmitDefaultValue=false)]
        public Dictionary<string, AdditionalLanguagesSynonyms> AdditionalLanguages { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamedEntityTypeItem {\n");

            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Synonyms: ").Append(Synonyms).Append("\n");
            sb.Append("  AdditionalLanguages: ").Append(AdditionalLanguages).Append("\n");
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
            return this.Equals(obj as NamedEntityTypeItem);
        }

        /// <summary>
        /// Returns true if NamedEntityTypeItem instances are equal
        /// </summary>
        /// <param name="other">Instance of NamedEntityTypeItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamedEntityTypeItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Synonyms == other.Synonyms ||
                    this.Synonyms != null &&
                    this.Synonyms.SequenceEqual(other.Synonyms)
                ) &&
                (
                    this.AdditionalLanguages == other.AdditionalLanguages ||
                    this.AdditionalLanguages != null &&
                    this.AdditionalLanguages.SequenceEqual(other.AdditionalLanguages)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Synonyms != null)
                    hash = hash * 59 + this.Synonyms.GetHashCode();

                if (this.AdditionalLanguages != null)
                    hash = hash * 59 + this.AdditionalLanguages.GetHashCode();

                return hash;
            }
        }
    }

}
