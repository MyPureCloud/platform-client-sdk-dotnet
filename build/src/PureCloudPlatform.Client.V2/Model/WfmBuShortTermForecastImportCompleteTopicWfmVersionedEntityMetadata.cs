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
    /// WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata
    /// </summary>
    [DataContract]
    public partial class WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata :  IEquatable<WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata" /> class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">DateModified.</param>
        public WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata(int? Version = null, WfmBuShortTermForecastImportCompleteTopicUserReference ModifiedBy = null, DateTime? DateModified = null)
        {
            this.Version = Version;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public WfmBuShortTermForecastImportCompleteTopicUserReference ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata {\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata);
        }

        /// <summary>
        /// Returns true if WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuShortTermForecastImportCompleteTopicWfmVersionedEntityMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                return hash;
            }
        }
    }

}
