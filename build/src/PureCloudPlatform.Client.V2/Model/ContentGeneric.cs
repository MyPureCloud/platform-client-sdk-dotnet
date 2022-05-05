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
    /// Deprecated, should use Card.
    /// </summary>
    [DataContract]
    public partial class ContentGeneric :  IEquatable<ContentGeneric>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGeneric" /> class.
        /// </summary>
        /// <param name="Title">Text to show in the title..</param>
        /// <param name="Description">Text to show in the description..</param>
        /// <param name="Image">URL of an image..</param>
        /// <param name="Video">URL of a video..</param>
        /// <param name="Actions">Actions to be taken (Deprecated)..</param>
        /// <param name="Components">An array of component objects..</param>
        public ContentGeneric(string Title = null, string Description = null, string Image = null, string Video = null, ContentActions Actions = null, List<ButtonComponent> Components = null)
        {
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.Video = Video;
            this.Actions = Actions;
            this.Components = Components;
            
        }
        
        
        
        /// <summary>
        /// Text to show in the title.
        /// </summary>
        /// <value>Text to show in the title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// Text to show in the description.
        /// </summary>
        /// <value>Text to show in the description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// URL of an image.
        /// </summary>
        /// <value>URL of an image.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        
        
        
        /// <summary>
        /// URL of a video.
        /// </summary>
        /// <value>URL of a video.</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public string Video { get; set; }
        
        
        
        /// <summary>
        /// Actions to be taken (Deprecated).
        /// </summary>
        /// <value>Actions to be taken (Deprecated).</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public ContentActions Actions { get; set; }
        
        
        
        /// <summary>
        /// An array of component objects.
        /// </summary>
        /// <value>An array of component objects.</value>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public List<ButtonComponent> Components { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentGeneric {\n");
            
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
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
            return this.Equals(obj as ContentGeneric);
        }

        /// <summary>
        /// Returns true if ContentGeneric instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentGeneric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentGeneric other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) &&
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
                ) &&
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
                ) &&
                (
                    this.Components == other.Components ||
                    this.Components != null &&
                    this.Components.SequenceEqual(other.Components)
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
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                
                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                if (this.Components != null)
                    hash = hash * 59 + this.Components.GetHashCode();
                
                return hash;
            }
        }
    }

}
