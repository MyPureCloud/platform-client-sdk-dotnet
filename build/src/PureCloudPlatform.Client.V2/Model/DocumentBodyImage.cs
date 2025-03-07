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
    /// DocumentBodyImage
    /// </summary>
    [DataContract]
    public partial class DocumentBodyImage :  IEquatable<DocumentBodyImage>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyImage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentBodyImage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBodyImage" /> class.
        /// </summary>
        /// <param name="Url">The URL for the image. (required).</param>
        /// <param name="Hyperlink">The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt;.</param>
        /// <param name="Properties">The properties for the image..</param>
        public DocumentBodyImage(string Url = null, string Hyperlink = null, DocumentBodyImageProperties Properties = null)
        {
            this.Url = Url;
            this.Hyperlink = Hyperlink;
            this.Properties = Properties;
            
        }
        


        /// <summary>
        /// The URL for the image.
        /// </summary>
        /// <value>The URL for the image.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt;
        /// </summary>
        /// <value>The URL of the page OR an email OR the reference to the knowledge article that the hyperlink goes to. Possible URL value types are https://&lt;url link&gt; | mailto:&lt;email&gt; | grn:knowledge:::documentVariation/&lt;knowledgeBaseId&gt;/&lt;documentId&gt;/&lt;variationId&gt; | grn:knowledge:::document/&lt;knowledgeBaseId&gt;/&lt;documentId&gt; | grn:knowledge:::category/&lt;knowledgeBaseId&gt;/&lt;categoryId&gt; | grn:knowledge:::label/&lt;knowledgeBaseId&gt;/&lt;labelId&gt;</value>
        [DataMember(Name="hyperlink", EmitDefaultValue=false)]
        public string Hyperlink { get; set; }



        /// <summary>
        /// The properties for the image.
        /// </summary>
        /// <value>The properties for the image.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public DocumentBodyImageProperties Properties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBodyImage {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Hyperlink: ").Append(Hyperlink).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as DocumentBodyImage);
        }

        /// <summary>
        /// Returns true if DocumentBodyImage instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentBodyImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentBodyImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Hyperlink == other.Hyperlink ||
                    this.Hyperlink != null &&
                    this.Hyperlink.Equals(other.Hyperlink)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Hyperlink != null)
                    hash = hash * 59 + this.Hyperlink.GetHashCode();

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                return hash;
            }
        }
    }

}
