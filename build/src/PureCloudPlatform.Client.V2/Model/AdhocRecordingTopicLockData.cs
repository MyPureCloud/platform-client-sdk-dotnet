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
    /// AdhocRecordingTopicLockData
    /// </summary>
    [DataContract]
    public partial class AdhocRecordingTopicLockData :  IEquatable<AdhocRecordingTopicLockData>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocRecordingTopicLockData" /> class.
        /// </summary>
        /// <param name="LockedBy">LockedBy.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateExpires">DateExpires.</param>
        public AdhocRecordingTopicLockData(AdhocRecordingTopicUserData LockedBy = null, DateTime? DateCreated = null, DateTime? DateExpires = null)
        {
            this.LockedBy = LockedBy;
            this.DateCreated = DateCreated;
            this.DateExpires = DateExpires;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets LockedBy
        /// </summary>
        [DataMember(Name="lockedBy", EmitDefaultValue=false)]
        public AdhocRecordingTopicUserData LockedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateExpires
        /// </summary>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdhocRecordingTopicLockData {\n");
            
            sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
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
            return this.Equals(obj as AdhocRecordingTopicLockData);
        }

        /// <summary>
        /// Returns true if AdhocRecordingTopicLockData instances are equal
        /// </summary>
        /// <param name="other">Instance of AdhocRecordingTopicLockData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdhocRecordingTopicLockData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LockedBy == other.LockedBy ||
                    this.LockedBy != null &&
                    this.LockedBy.Equals(other.LockedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateExpires == other.DateExpires ||
                    this.DateExpires != null &&
                    this.DateExpires.Equals(other.DateExpires)
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
                
                if (this.LockedBy != null)
                    hash = hash * 59 + this.LockedBy.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();
                
                return hash;
            }
        }
    }

}
