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
    /// Generic content object
    /// </summary>
    [DataContract]
    public partial class ContentGeneric :  IEquatable<ContentGeneric>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGeneric" /> class.
        /// </summary>
        /// <param name="Id">An ID assigned to this rich message content. Each instance inside the content array has a unique ID..</param>
        /// <param name="Title">Text to show in the title row.</param>
        /// <param name="Description">Text to show in the description row. This is immediately below the title.</param>
        /// <param name="Image">Path or URI to an image file.</param>
        /// <param name="Video">Path or URI to a video file.</param>
        /// <param name="Actions">User actions available on the content. All actions are optional and all actions are executed simultaneously..</param>
        /// <param name="Components">An array of component objects.</param>
        public ContentGeneric(string Id = null, string Title = null, string Description = null, string Image = null, string Video = null, ContentActions Actions = null, List<ButtonComponent> Components = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.Video = Video;
            this.Actions = Actions;
            this.Components = Components;
            
        }
        
        
        
        /// <summary>
        /// An ID assigned to this rich message content. Each instance inside the content array has a unique ID.
        /// </summary>
        /// <value>An ID assigned to this rich message content. Each instance inside the content array has a unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Text to show in the title row
        /// </summary>
        /// <value>Text to show in the title row</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// Text to show in the description row. This is immediately below the title
        /// </summary>
        /// <value>Text to show in the description row. This is immediately below the title</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Path or URI to an image file
        /// </summary>
        /// <value>Path or URI to an image file</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        
        
        
        /// <summary>
        /// Path or URI to a video file
        /// </summary>
        /// <value>Path or URI to a video file</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public string Video { get; set; }
        
        
        
        /// <summary>
        /// User actions available on the content. All actions are optional and all actions are executed simultaneously.
        /// </summary>
        /// <value>User actions available on the content. All actions are optional and all actions are executed simultaneously.</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public ContentActions Actions { get; set; }
        
        
        
        /// <summary>
        /// An array of component objects
        /// </summary>
        /// <value>An array of component objects</value>
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
            
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
