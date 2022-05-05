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
    /// Structured template button object.
    /// </summary>
    [DataContract]
    public partial class ButtonComponent :  IEquatable<ButtonComponent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonComponent" /> class.
        /// </summary>
        /// <param name="Title">Text to show inside the button..</param>
        /// <param name="Actions">The button actions (Deprecated)..</param>
        public ButtonComponent(string Title = null, ContentActions Actions = null)
        {
            this.Title = Title;
            this.Actions = Actions;
            
        }
        
        
        
        /// <summary>
        /// Text to show inside the button.
        /// </summary>
        /// <value>Text to show inside the button.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// The button actions (Deprecated).
        /// </summary>
        /// <value>The button actions (Deprecated).</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public ContentActions Actions { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ButtonComponent {\n");
            
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as ButtonComponent);
        }

        /// <summary>
        /// Returns true if ButtonComponent instances are equal
        /// </summary>
        /// <param name="other">Instance of ButtonComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ButtonComponent other)
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
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
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
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                return hash;
            }
        }
    }

}
