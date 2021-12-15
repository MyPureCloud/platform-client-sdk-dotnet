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
    /// ArchitectFlowOutcomeNotificationFlowOutcomeNotification
    /// </summary>
    [DataContract]
    public partial class ArchitectFlowOutcomeNotificationFlowOutcomeNotification :  IEquatable<ArchitectFlowOutcomeNotificationFlowOutcomeNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectFlowOutcomeNotificationFlowOutcomeNotification" /> class.
        /// </summary>
        /// <param name="Id">The flow outcome ID.</param>
        /// <param name="Name">The flow outcome name.</param>
        /// <param name="Description">The flow outcome description.</param>
        /// <param name="CurrentOperation">CurrentOperation.</param>
        public ArchitectFlowOutcomeNotificationFlowOutcomeNotification(string Id = null, string Name = null, string Description = null, ArchitectFlowOutcomeNotificationArchitectOperation CurrentOperation = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.CurrentOperation = CurrentOperation;
            
        }
        
        
        
        /// <summary>
        /// The flow outcome ID
        /// </summary>
        /// <value>The flow outcome ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The flow outcome name
        /// </summary>
        /// <value>The flow outcome name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The flow outcome description
        /// </summary>
        /// <value>The flow outcome description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CurrentOperation
        /// </summary>
        [DataMember(Name="currentOperation", EmitDefaultValue=false)]
        public ArchitectFlowOutcomeNotificationArchitectOperation CurrentOperation { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectFlowOutcomeNotificationFlowOutcomeNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as ArchitectFlowOutcomeNotificationFlowOutcomeNotification);
        }

        /// <summary>
        /// Returns true if ArchitectFlowOutcomeNotificationFlowOutcomeNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectFlowOutcomeNotificationFlowOutcomeNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectFlowOutcomeNotificationFlowOutcomeNotification other)
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
                
                if (this.CurrentOperation != null)
                    hash = hash * 59 + this.CurrentOperation.GetHashCode();
                
                return hash;
            }
        }
    }

}
