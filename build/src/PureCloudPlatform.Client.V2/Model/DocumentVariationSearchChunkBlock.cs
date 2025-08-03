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
    /// DocumentVariationSearchChunkBlock
    /// </summary>
    [DataContract]
    public partial class DocumentVariationSearchChunkBlock :  IEquatable<DocumentVariationSearchChunkBlock>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVariationSearchChunkBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentVariationSearchChunkBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVariationSearchChunkBlock" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the chunk. (required).</param>
        /// <param name="Text">The chunk text associated with the variation. (required).</param>
        /// <param name="Confidence">The confidence associated with a chunk with respect to a search query..</param>
        public DocumentVariationSearchChunkBlock(string Id = null, string Text = null, float? Confidence = null)
        {
            this.Id = Id;
            this.Text = Text;
            this.Confidence = Confidence;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the chunk.
        /// </summary>
        /// <value>The globally unique identifier for the chunk.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The chunk text associated with the variation.
        /// </summary>
        /// <value>The chunk text associated with the variation.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The confidence associated with a chunk with respect to a search query.
        /// </summary>
        /// <value>The confidence associated with a chunk with respect to a search query.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public float? Confidence { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentVariationSearchChunkBlock {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
            return this.Equals(obj as DocumentVariationSearchChunkBlock);
        }

        /// <summary>
        /// Returns true if DocumentVariationSearchChunkBlock instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentVariationSearchChunkBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentVariationSearchChunkBlock other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();

                return hash;
            }
        }
    }

}
