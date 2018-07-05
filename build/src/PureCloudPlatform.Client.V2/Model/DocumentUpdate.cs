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
    /// DocumentUpdate
    /// </summary>
    [DataContract]
    public partial class DocumentUpdate :  IEquatable<DocumentUpdate>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentUpdate() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdate" /> class.
        /// </summary>
        /// <param name="ChangeNumber">ChangeNumber.</param>
        /// <param name="Name">The name of the document (required).</param>
        /// <param name="Read">Read.</param>
        /// <param name="AddTags">AddTags.</param>
        /// <param name="RemoveTags">RemoveTags.</param>
        /// <param name="AddTagIds">AddTagIds.</param>
        /// <param name="RemoveTagIds">RemoveTagIds.</param>
        /// <param name="UpdateAttributes">UpdateAttributes.</param>
        /// <param name="RemoveAttributes">RemoveAttributes.</param>
        public DocumentUpdate(int? ChangeNumber = null, string Name = null, bool? Read = null, List<string> AddTags = null, List<string> RemoveTags = null, List<string> AddTagIds = null, List<string> RemoveTagIds = null, List<DocumentAttribute> UpdateAttributes = null, List<string> RemoveAttributes = null)
        {
            this.ChangeNumber = ChangeNumber;
            this.Read = Read;
            this.AddTags = AddTags;
            this.RemoveTags = RemoveTags;
            this.AddTagIds = AddTagIds;
            this.RemoveTagIds = RemoveTagIds;
            this.UpdateAttributes = UpdateAttributes;
            this.RemoveAttributes = RemoveAttributes;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ChangeNumber
        /// </summary>
        [DataMember(Name="changeNumber", EmitDefaultValue=false)]
        public int? ChangeNumber { get; set; }
        
        
        
        /// <summary>
        /// The name of the document
        /// </summary>
        /// <value>The name of the document</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddTags
        /// </summary>
        [DataMember(Name="addTags", EmitDefaultValue=false)]
        public List<string> AddTags { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RemoveTags
        /// </summary>
        [DataMember(Name="removeTags", EmitDefaultValue=false)]
        public List<string> RemoveTags { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddTagIds
        /// </summary>
        [DataMember(Name="addTagIds", EmitDefaultValue=false)]
        public List<string> AddTagIds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RemoveTagIds
        /// </summary>
        [DataMember(Name="removeTagIds", EmitDefaultValue=false)]
        public List<string> RemoveTagIds { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UpdateAttributes
        /// </summary>
        [DataMember(Name="updateAttributes", EmitDefaultValue=false)]
        public List<DocumentAttribute> UpdateAttributes { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RemoveAttributes
        /// </summary>
        [DataMember(Name="removeAttributes", EmitDefaultValue=false)]
        public List<string> RemoveAttributes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentUpdate {\n");
            
            sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  AddTags: ").Append(AddTags).Append("\n");
            sb.Append("  RemoveTags: ").Append(RemoveTags).Append("\n");
            sb.Append("  AddTagIds: ").Append(AddTagIds).Append("\n");
            sb.Append("  RemoveTagIds: ").Append(RemoveTagIds).Append("\n");
            sb.Append("  UpdateAttributes: ").Append(UpdateAttributes).Append("\n");
            sb.Append("  RemoveAttributes: ").Append(RemoveAttributes).Append("\n");
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
            return this.Equals(obj as DocumentUpdate);
        }

        /// <summary>
        /// Returns true if DocumentUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChangeNumber == other.ChangeNumber ||
                    this.ChangeNumber != null &&
                    this.ChangeNumber.Equals(other.ChangeNumber)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) &&
                (
                    this.AddTags == other.AddTags ||
                    this.AddTags != null &&
                    this.AddTags.SequenceEqual(other.AddTags)
                ) &&
                (
                    this.RemoveTags == other.RemoveTags ||
                    this.RemoveTags != null &&
                    this.RemoveTags.SequenceEqual(other.RemoveTags)
                ) &&
                (
                    this.AddTagIds == other.AddTagIds ||
                    this.AddTagIds != null &&
                    this.AddTagIds.SequenceEqual(other.AddTagIds)
                ) &&
                (
                    this.RemoveTagIds == other.RemoveTagIds ||
                    this.RemoveTagIds != null &&
                    this.RemoveTagIds.SequenceEqual(other.RemoveTagIds)
                ) &&
                (
                    this.UpdateAttributes == other.UpdateAttributes ||
                    this.UpdateAttributes != null &&
                    this.UpdateAttributes.SequenceEqual(other.UpdateAttributes)
                ) &&
                (
                    this.RemoveAttributes == other.RemoveAttributes ||
                    this.RemoveAttributes != null &&
                    this.RemoveAttributes.SequenceEqual(other.RemoveAttributes)
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
                
                if (this.ChangeNumber != null)
                    hash = hash * 59 + this.ChangeNumber.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                
                if (this.AddTags != null)
                    hash = hash * 59 + this.AddTags.GetHashCode();
                
                if (this.RemoveTags != null)
                    hash = hash * 59 + this.RemoveTags.GetHashCode();
                
                if (this.AddTagIds != null)
                    hash = hash * 59 + this.AddTagIds.GetHashCode();
                
                if (this.RemoveTagIds != null)
                    hash = hash * 59 + this.RemoveTagIds.GetHashCode();
                
                if (this.UpdateAttributes != null)
                    hash = hash * 59 + this.UpdateAttributes.GetHashCode();
                
                if (this.RemoveAttributes != null)
                    hash = hash * 59 + this.RemoveAttributes.GetHashCode();
                
                return hash;
            }
        }
    }

}
