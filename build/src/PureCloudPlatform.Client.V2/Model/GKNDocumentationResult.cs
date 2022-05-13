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
    /// GKNDocumentationResult
    /// </summary>
    [DataContract]
    public partial class GKNDocumentationResult :  IEquatable<GKNDocumentationResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GKNDocumentationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GKNDocumentationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GKNDocumentationResult" /> class.
        /// </summary>
        /// <param name="Content">The text or html content for the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Link">URL link for the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Title">The title of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Type">The search type. Will be returned in responses for certain entities. (required).</param>
        public GKNDocumentationResult(string Content = null, string Link = null, string Title = null, string Type = null)
        {
            this.Content = Content;
            this.Link = Link;
            this.Title = Title;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// The text or html content for the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The text or html content for the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }



        /// <summary>
        /// URL link for the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>URL link for the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }



        /// <summary>
        /// The title of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The title of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// The search type. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The search type. Will be returned in responses for certain entities.</value>
        [DataMember(Name="_type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GKNDocumentationResult {\n");

            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as GKNDocumentationResult);
        }

        /// <summary>
        /// Returns true if GKNDocumentationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of GKNDocumentationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GKNDocumentationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.Link == other.Link ||
                    this.Link != null &&
                    this.Link.Equals(other.Link)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                if (this.Link != null)
                    hash = hash * 59 + this.Link.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
