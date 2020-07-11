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
    /// Structured template button object
    /// </summary>
    [DataContract]
    public partial class ButtonComponent :  IEquatable<ButtonComponent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonComponent" /> class.
        /// </summary>
        /// <param name="Id">An ID assigned to this component.</param>
        /// <param name="Text">Text to show inside the button.</param>
        /// <param name="Title">Tooltip text to show when hovering over the button.</param>
        /// <param name="Actions">User actions available on the content. All actions are optional and all actions are executed simultaneously..</param>
        public ButtonComponent(string Id = null, string Text = null, string Title = null, ContentActions Actions = null)
        {
            this.Id = Id;
            this.Text = Text;
            this.Title = Title;
            this.Actions = Actions;
            
        }
        
        
        
        /// <summary>
        /// An ID assigned to this component
        /// </summary>
        /// <value>An ID assigned to this component</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Text to show inside the button
        /// </summary>
        /// <value>Text to show inside the button</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Tooltip text to show when hovering over the button
        /// </summary>
        /// <value>Tooltip text to show when hovering over the button</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// User actions available on the content. All actions are optional and all actions are executed simultaneously.
        /// </summary>
        /// <value>User actions available on the content. All actions are optional and all actions are executed simultaneously.</value>
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
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                return hash;
            }
        }
    }

}
