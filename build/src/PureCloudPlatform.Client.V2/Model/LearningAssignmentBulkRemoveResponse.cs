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
    /// LearningAssignmentBulkRemoveResponse
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentBulkRemoveResponse :  IEquatable<LearningAssignmentBulkRemoveResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentBulkRemoveResponse" /> class.
        /// </summary>
        /// <param name="Entities">The learning assignments that were removed successfully.</param>
        /// <param name="DisallowedEntities">The learning assignments that were not removed due to missing permissions.</param>
        public LearningAssignmentBulkRemoveResponse(List<LearningAssignmentEntity> Entities = null, List<DisallowedEntityLearningAssignmentReference> DisallowedEntities = null)
        {
            this.Entities = Entities;
            this.DisallowedEntities = DisallowedEntities;
            
        }
        
        
        
        /// <summary>
        /// The learning assignments that were removed successfully
        /// </summary>
        /// <value>The learning assignments that were removed successfully</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<LearningAssignmentEntity> Entities { get; set; }
        
        
        
        /// <summary>
        /// The learning assignments that were not removed due to missing permissions
        /// </summary>
        /// <value>The learning assignments that were not removed due to missing permissions</value>
        [DataMember(Name="disallowedEntities", EmitDefaultValue=false)]
        public List<DisallowedEntityLearningAssignmentReference> DisallowedEntities { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentBulkRemoveResponse {\n");
            
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  DisallowedEntities: ").Append(DisallowedEntities).Append("\n");
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
            return this.Equals(obj as LearningAssignmentBulkRemoveResponse);
        }

        /// <summary>
        /// Returns true if LearningAssignmentBulkRemoveResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentBulkRemoveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentBulkRemoveResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.DisallowedEntities == other.DisallowedEntities ||
                    this.DisallowedEntities != null &&
                    this.DisallowedEntities.SequenceEqual(other.DisallowedEntities)
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
                
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();
                
                if (this.DisallowedEntities != null)
                    hash = hash * 59 + this.DisallowedEntities.GetHashCode();
                
                return hash;
            }
        }
    }

}
