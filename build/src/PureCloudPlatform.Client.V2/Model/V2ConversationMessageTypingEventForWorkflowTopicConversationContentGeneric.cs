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
    /// V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric :  IEquatable<V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric" /> class.
        /// </summary>
        /// <param name="Title">Title.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Image">Image.</param>
        /// <param name="Video">Video.</param>
        /// <param name="Actions">Actions.</param>
        /// <param name="Components">Components.</param>
        public V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric(string Title = null, string Description = null, string Image = null, string Video = null, V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions Actions = null, List<V2ConversationMessageTypingEventForWorkflowTopicConversationButtonComponent> Components = null)
        {
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.Video = Video;
            this.Actions = Actions;
            this.Components = Components;
            
        }
        


        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }



        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public string Video { get; set; }



        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForWorkflowTopicConversationContentActions Actions { get; set; }



        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public List<V2ConversationMessageTypingEventForWorkflowTopicConversationButtonComponent> Components { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric {\n");

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
            return this.Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicConversationContentGeneric other)
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
