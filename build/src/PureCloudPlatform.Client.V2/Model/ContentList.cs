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
    /// List content object.
    /// </summary>
    [DataContract]
    public partial class ContentList :  IEquatable<ContentList>
    {
        
        
        
        
        
        /// <summary>
        /// The type of list this instance represents.
        /// </summary>
        /// <value>The type of list this instance represents.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ListTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Selection for "Selection"
            /// </summary>
            [EnumMember(Value = "Selection")]
            Selection,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>
            [EnumMember(Value = "Vertical")]
            Vertical
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of list this instance represents.
        /// </summary>
        /// <value>The type of list this instance represents.</value>
        [DataMember(Name="listType", EmitDefaultValue=false)]
        public ListTypeEnum? ListType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentList" /> class.
        /// </summary>
        /// <param name="Id">A unique ID assigned to this rich message content..</param>
        /// <param name="ListType">The type of list this instance represents..</param>
        /// <param name="Title">Text to show in the title..</param>
        /// <param name="Description">Text to show in the description..</param>
        /// <param name="SubmitLabel">Label for Submit button..</param>
        /// <param name="Actions">The list actions (Deprecated)..</param>
        /// <param name="Components">An array of component objects..</param>
        public ContentList(string Id = null, ListTypeEnum? ListType = null, string Title = null, string Description = null, string SubmitLabel = null, ContentActions Actions = null, List<ListItemComponent> Components = null)
        {
            this.Id = Id;
            this.ListType = ListType;
            this.Title = Title;
            this.Description = Description;
            this.SubmitLabel = SubmitLabel;
            this.Actions = Actions;
            this.Components = Components;
            
        }
        
        
        
        /// <summary>
        /// A unique ID assigned to this rich message content.
        /// </summary>
        /// <value>A unique ID assigned to this rich message content.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
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
        /// Label for Submit button.
        /// </summary>
        /// <value>Label for Submit button.</value>
        [DataMember(Name="submitLabel", EmitDefaultValue=false)]
        public string SubmitLabel { get; set; }
        
        
        
        /// <summary>
        /// The list actions (Deprecated).
        /// </summary>
        /// <value>The list actions (Deprecated).</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public ContentActions Actions { get; set; }
        
        
        
        /// <summary>
        /// An array of component objects.
        /// </summary>
        /// <value>An array of component objects.</value>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public List<ListItemComponent> Components { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentList {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ListType: ").Append(ListType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubmitLabel: ").Append(SubmitLabel).Append("\n");
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
            return this.Equals(obj as ContentList);
        }

        /// <summary>
        /// Returns true if ContentList instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentList other)
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
                    this.ListType == other.ListType ||
                    this.ListType != null &&
                    this.ListType.Equals(other.ListType)
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
                    this.SubmitLabel == other.SubmitLabel ||
                    this.SubmitLabel != null &&
                    this.SubmitLabel.Equals(other.SubmitLabel)
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
                
                if (this.ListType != null)
                    hash = hash * 59 + this.ListType.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.SubmitLabel != null)
                    hash = hash * 59 + this.SubmitLabel.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                
                if (this.Components != null)
                    hash = hash * 59 + this.Components.GetHashCode();
                
                return hash;
            }
        }
    }

}
