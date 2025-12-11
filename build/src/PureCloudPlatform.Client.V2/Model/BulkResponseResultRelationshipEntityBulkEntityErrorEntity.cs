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
    /// BulkResponseResultRelationshipEntityBulkEntityErrorEntity
    /// </summary>
    [DataContract]
    public partial class BulkResponseResultRelationshipEntityBulkEntityErrorEntity :  IEquatable<BulkResponseResultRelationshipEntityBulkEntityErrorEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResponseResultRelationshipEntityBulkEntityErrorEntity" /> class.
        /// </summary>
        /// <param name="Id">The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity..</param>
        /// <param name="Success">Whether the requested operation completed successfully..</param>
        /// <param name="Entity">The entity which was affected by this Bulk operation. Only returned on success..</param>
        /// <param name="Error">An error describing why this Bulk operation failed. Only returned on failure..</param>
        /// <param name="Status">Status Code for the requested operation..</param>
        public BulkResponseResultRelationshipEntityBulkEntityErrorEntity(string Id = null, bool? Success = null, Relationship Entity = null, BulkEntityErrorEntity Error = null, int? Status = null)
        {
            this.Id = Id;
            this.Success = Success;
            this.Entity = Entity;
            this.Error = Error;
            this.Status = Status;
            
        }
        


        /// <summary>
        /// The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity.
        /// </summary>
        /// <value>The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Whether the requested operation completed successfully.
        /// </summary>
        /// <value>Whether the requested operation completed successfully.</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }



        /// <summary>
        /// The entity which was affected by this Bulk operation. Only returned on success.
        /// </summary>
        /// <value>The entity which was affected by this Bulk operation. Only returned on success.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Relationship Entity { get; set; }



        /// <summary>
        /// An error describing why this Bulk operation failed. Only returned on failure.
        /// </summary>
        /// <value>An error describing why this Bulk operation failed. Only returned on failure.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public BulkEntityErrorEntity Error { get; set; }



        /// <summary>
        /// Status Code for the requested operation.
        /// </summary>
        /// <value>Status Code for the requested operation.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkResponseResultRelationshipEntityBulkEntityErrorEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as BulkResponseResultRelationshipEntityBulkEntityErrorEntity);
        }

        /// <summary>
        /// Returns true if BulkResponseResultRelationshipEntityBulkEntityErrorEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkResponseResultRelationshipEntityBulkEntityErrorEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkResponseResultRelationshipEntityBulkEntityErrorEntity other)
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
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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

                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                return hash;
            }
        }
    }

}
