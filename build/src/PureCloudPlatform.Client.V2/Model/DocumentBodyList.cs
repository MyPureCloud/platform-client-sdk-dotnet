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
    /// DocumentBodyList
    /// </summary>
    [DataContract]
    public partial class DocumentBodyList :  IEquatable<DocumentBodyList>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBodyList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyList" /> class.
        /// </summary>
        /// <param name="Properties">Properties for the UnorderedList or OrderedList..</param>
        /// <param name="Blocks">The list of items for an OrderedList or an UnorderedList. (required).</param>
        public DocumentBodyList(DocumentBodyListBlockProperties Properties = null, List<DocumentBodyListBlock> Blocks = null)
        {
            this.Properties = Properties;
            this.Blocks = Blocks;
            
        }
        


        /// <summary>
        /// Properties for the UnorderedList or OrderedList.
        /// </summary>
        /// <value>Properties for the UnorderedList or OrderedList.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public DocumentBodyListBlockProperties Properties { get; set; }



        /// <summary>
        /// The list of items for an OrderedList or an UnorderedList.
        /// </summary>
        /// <value>The list of items for an OrderedList or an UnorderedList.</value>
        [DataMember(Name="blocks", EmitDefaultValue=false)]
        public List<DocumentBodyListBlock> Blocks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyList {\n");

            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
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
            return this.Equals(obj as DocumentBodyList);
        }

        /// <summary>
        /// Returns true if DocumentBodyList instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) &&
                (
                    this.Blocks == other.Blocks ||
                    this.Blocks != null &&
                    this.Blocks.SequenceEqual(other.Blocks)
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
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.Blocks != null)
                    hash = hash * 59 + this.Blocks.GetHashCode();

                return hash;
            }
        }
    }

}
