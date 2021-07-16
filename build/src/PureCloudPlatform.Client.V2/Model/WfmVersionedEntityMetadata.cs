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
    /// Metadata to associate with a given entity
    /// </summary>
    [DataContract]
    public partial class WfmVersionedEntityMetadata :  IEquatable<WfmVersionedEntityMetadata>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmVersionedEntityMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WfmVersionedEntityMetadata() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmVersionedEntityMetadata" /> class.
        /// </summary>
        /// <param name="Version">The version of the associated entity.  Used to prevent conflicts on concurrent edits (required).</param>
        /// <param name="ModifiedBy">The user who last modified the associated entity.</param>
        public WfmVersionedEntityMetadata(int? Version = null, UserReference ModifiedBy = null)
        {
            this.Version = Version;
            this.ModifiedBy = ModifiedBy;
            
        }
        
        
        
        /// <summary>
        /// The version of the associated entity.  Used to prevent conflicts on concurrent edits
        /// </summary>
        /// <value>The version of the associated entity.  Used to prevent conflicts on concurrent edits</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The user who last modified the associated entity
        /// </summary>
        /// <value>The user who last modified the associated entity</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// The date the associated entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the associated entity was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmVersionedEntityMetadata {\n");
            
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
            return this.Equals(obj as WfmVersionedEntityMetadata);
        }

        /// <summary>
        /// Returns true if WfmVersionedEntityMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmVersionedEntityMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmVersionedEntityMetadata other)
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
