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
    /// WfmShiftTradingJobCompleteEventWfmVersionMetadata
    /// </summary>
    [DataContract]
    public partial class WfmShiftTradingJobCompleteEventWfmVersionMetadata :  IEquatable<WfmShiftTradingJobCompleteEventWfmVersionMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmShiftTradingJobCompleteEventWfmVersionMetadata" /> class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="DeletedBy">DeletedBy.</param>
        /// <param name="DateDeleted">DateDeleted.</param>
        public WfmShiftTradingJobCompleteEventWfmVersionMetadata(long? Version = null, string CreatedBy = null, string DateCreated = null, string ModifiedBy = null, string DateModified = null, string DeletedBy = null, string DateDeleted = null)
        {
            this.Version = Version;
            this.CreatedBy = CreatedBy;
            this.DateCreated = DateCreated;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            this.DeletedBy = DeletedBy;
            this.DateDeleted = DateDeleted;
            
        }
        


        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }



        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }



        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public string DateCreated { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }



        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public string DateModified { get; set; }



        /// <summary>
        /// Gets or Sets DeletedBy
        /// </summary>
        [DataMember(Name="deletedBy", EmitDefaultValue=false)]
        public string DeletedBy { get; set; }



        /// <summary>
        /// Gets or Sets DateDeleted
        /// </summary>
        [DataMember(Name="dateDeleted", EmitDefaultValue=false)]
        public string DateDeleted { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmShiftTradingJobCompleteEventWfmVersionMetadata {\n");

            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  DateDeleted: ").Append(DateDeleted).Append("\n");
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
            return this.Equals(obj as WfmShiftTradingJobCompleteEventWfmVersionMetadata);
        }

        /// <summary>
        /// Returns true if WfmShiftTradingJobCompleteEventWfmVersionMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmShiftTradingJobCompleteEventWfmVersionMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmShiftTradingJobCompleteEventWfmVersionMetadata other)
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
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
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
                ) &&
                (
                    this.DeletedBy == other.DeletedBy ||
                    this.DeletedBy != null &&
                    this.DeletedBy.Equals(other.DeletedBy)
                ) &&
                (
                    this.DateDeleted == other.DateDeleted ||
                    this.DateDeleted != null &&
                    this.DateDeleted.Equals(other.DateDeleted)
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

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DeletedBy != null)
                    hash = hash * 59 + this.DeletedBy.GetHashCode();

                if (this.DateDeleted != null)
                    hash = hash * 59 + this.DateDeleted.GetHashCode();

                return hash;
            }
        }
    }

}
