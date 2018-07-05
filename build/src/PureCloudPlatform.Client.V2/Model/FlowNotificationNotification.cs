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
    /// FlowNotificationNotification
    /// </summary>
    [DataContract]
    public partial class FlowNotificationNotification :  IEquatable<FlowNotificationNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowNotificationNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Deleted">Deleted.</param>
        /// <param name="CheckedInVersion">CheckedInVersion.</param>
        /// <param name="SavedVersion">SavedVersion.</param>
        /// <param name="PublishedVersion">PublishedVersion.</param>
        /// <param name="CurrentOperation">CurrentOperation.</param>
        public FlowNotificationNotification(string Id = null, string Name = null, string Description = null, bool? Deleted = null, DocumentDataV2NotificationWorkspace CheckedInVersion = null, FlowNotificationNotificationFlowVersion SavedVersion = null, FlowNotificationNotificationFlowVersion PublishedVersion = null, PromptNotificationNotificationCurrentOperation CurrentOperation = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Deleted = Deleted;
            this.CheckedInVersion = CheckedInVersion;
            this.SavedVersion = SavedVersion;
            this.PublishedVersion = PublishedVersion;
            this.CurrentOperation = CurrentOperation;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CheckedInVersion
        /// </summary>
        [DataMember(Name="checkedInVersion", EmitDefaultValue=false)]
        public DocumentDataV2NotificationWorkspace CheckedInVersion { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SavedVersion
        /// </summary>
        [DataMember(Name="savedVersion", EmitDefaultValue=false)]
        public FlowNotificationNotificationFlowVersion SavedVersion { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PublishedVersion
        /// </summary>
        [DataMember(Name="publishedVersion", EmitDefaultValue=false)]
        public FlowNotificationNotificationFlowVersion PublishedVersion { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CurrentOperation
        /// </summary>
        [DataMember(Name="currentOperation", EmitDefaultValue=false)]
        public PromptNotificationNotificationCurrentOperation CurrentOperation { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowNotificationNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  CheckedInVersion: ").Append(CheckedInVersion).Append("\n");
            sb.Append("  SavedVersion: ").Append(SavedVersion).Append("\n");
            sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
            sb.Append("  CurrentOperation: ").Append(CurrentOperation).Append("\n");
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
            return this.Equals(obj as FlowNotificationNotification);
        }

        /// <summary>
        /// Returns true if FlowNotificationNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowNotificationNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowNotificationNotification other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.CheckedInVersion == other.CheckedInVersion ||
                    this.CheckedInVersion != null &&
                    this.CheckedInVersion.Equals(other.CheckedInVersion)
                ) &&
                (
                    this.SavedVersion == other.SavedVersion ||
                    this.SavedVersion != null &&
                    this.SavedVersion.Equals(other.SavedVersion)
                ) &&
                (
                    this.PublishedVersion == other.PublishedVersion ||
                    this.PublishedVersion != null &&
                    this.PublishedVersion.Equals(other.PublishedVersion)
                ) &&
                (
                    this.CurrentOperation == other.CurrentOperation ||
                    this.CurrentOperation != null &&
                    this.CurrentOperation.Equals(other.CurrentOperation)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                
                if (this.CheckedInVersion != null)
                    hash = hash * 59 + this.CheckedInVersion.GetHashCode();
                
                if (this.SavedVersion != null)
                    hash = hash * 59 + this.SavedVersion.GetHashCode();
                
                if (this.PublishedVersion != null)
                    hash = hash * 59 + this.PublishedVersion.GetHashCode();
                
                if (this.CurrentOperation != null)
                    hash = hash * 59 + this.CurrentOperation.GetHashCode();
                
                return hash;
            }
        }
    }

}
