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
    /// DocumentVariationQueryChunkBlock
    /// </summary>
    [DataContract]
    public partial class DocumentVariationQueryChunkBlock :  IEquatable<DocumentVariationQueryChunkBlock>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVariationQueryChunkBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentVariationQueryChunkBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentVariationQueryChunkBlock" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the chunk. (required).</param>
        /// <param name="Text">The chunk text associated with the variation. (required).</param>
        public DocumentVariationQueryChunkBlock(string Id = null, string Text = null)
        {
            this.Id = Id;
            this.Text = Text;
            
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentVariationQueryChunkBlock {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as DocumentVariationQueryChunkBlock);
        }

        /// <summary>
        /// Returns true if DocumentVariationQueryChunkBlock instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentVariationQueryChunkBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentVariationQueryChunkBlock other)
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

                return hash;
            }
        }
    }

}
