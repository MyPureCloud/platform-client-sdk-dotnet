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
    /// Assignment
    /// </summary>
    [DataContract]
    public partial class Assignment :  IEquatable<Assignment>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Assignment" /> class.
        /// </summary>
        /// <param name="AssignedMembers">The list of users successfully assigned to the custom performance profile.</param>
        /// <param name="RemovedMembers">The list of users successfully removed from the custom performance profile.</param>
        /// <param name="AssignmentErrors">The list of users failed assignment or removal for the custom performance profile.</param>
        public Assignment(List<UserReference> AssignedMembers = null, List<UserReference> RemovedMembers = null, List<AssignmentError> AssignmentErrors = null)
        {
            this.AssignedMembers = AssignedMembers;
            this.RemovedMembers = RemovedMembers;
            this.AssignmentErrors = AssignmentErrors;
            
        }
        
        
        
        /// <summary>
        /// The list of users successfully assigned to the custom performance profile
        /// </summary>
        /// <value>The list of users successfully assigned to the custom performance profile</value>
        [DataMember(Name="assignedMembers", EmitDefaultValue=false)]
        public List<UserReference> AssignedMembers { get; set; }
        
        
        
        /// <summary>
        /// The list of users successfully removed from the custom performance profile
        /// </summary>
        /// <value>The list of users successfully removed from the custom performance profile</value>
        [DataMember(Name="removedMembers", EmitDefaultValue=false)]
        public List<UserReference> RemovedMembers { get; set; }
        
        
        
        /// <summary>
        /// The list of users failed assignment or removal for the custom performance profile
        /// </summary>
        /// <value>The list of users failed assignment or removal for the custom performance profile</value>
        [DataMember(Name="assignmentErrors", EmitDefaultValue=false)]
        public List<AssignmentError> AssignmentErrors { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Assignment {\n");
            
            sb.Append("  AssignedMembers: ").Append(AssignedMembers).Append("\n");
            sb.Append("  RemovedMembers: ").Append(RemovedMembers).Append("\n");
            sb.Append("  AssignmentErrors: ").Append(AssignmentErrors).Append("\n");
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
            return this.Equals(obj as Assignment);
        }

        /// <summary>
        /// Returns true if Assignment instances are equal
        /// </summary>
        /// <param name="other">Instance of Assignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Assignment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AssignedMembers == other.AssignedMembers ||
                    this.AssignedMembers != null &&
                    this.AssignedMembers.SequenceEqual(other.AssignedMembers)
                ) &&
                (
                    this.RemovedMembers == other.RemovedMembers ||
                    this.RemovedMembers != null &&
                    this.RemovedMembers.SequenceEqual(other.RemovedMembers)
                ) &&
                (
                    this.AssignmentErrors == other.AssignmentErrors ||
                    this.AssignmentErrors != null &&
                    this.AssignmentErrors.SequenceEqual(other.AssignmentErrors)
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
                
                if (this.AssignedMembers != null)
                    hash = hash * 59 + this.AssignedMembers.GetHashCode();
                
                if (this.RemovedMembers != null)
                    hash = hash * 59 + this.RemovedMembers.GetHashCode();
                
                if (this.AssignmentErrors != null)
                    hash = hash * 59 + this.AssignmentErrors.GetHashCode();
                
                return hash;
            }
        }
    }

}
