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
    /// EntityChange
    /// </summary>
    [DataContract]
    public partial class EntityChange :  IEquatable<EntityChange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityChange" /> class.
        /// </summary>
        /// <param name="EntityId">Id of the entity that was changed.</param>
        /// <param name="EntityName">Name of the entity that was changed.</param>
        /// <param name="EntityType">Type of the entity that was changed.</param>
        /// <param name="OldValues">Previous values for the entity..</param>
        /// <param name="NewValues">New values for the entity..</param>
        public EntityChange(string EntityId = null, string EntityName = null, string EntityType = null, List<string> OldValues = null, List<string> NewValues = null)
        {
            this.EntityId = EntityId;
            this.EntityName = EntityName;
            this.EntityType = EntityType;
            this.OldValues = OldValues;
            this.NewValues = NewValues;
            
        }
        


        /// <summary>
        /// Id of the entity that was changed
        /// </summary>
        /// <value>Id of the entity that was changed</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }



        /// <summary>
        /// Name of the entity that was changed
        /// </summary>
        /// <value>Name of the entity that was changed</value>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }



        /// <summary>
        /// Type of the entity that was changed
        /// </summary>
        /// <value>Type of the entity that was changed</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }



        /// <summary>
        /// Previous values for the entity.
        /// </summary>
        /// <value>Previous values for the entity.</value>
        [DataMember(Name="oldValues", EmitDefaultValue=false)]
        public List<string> OldValues { get; set; }



        /// <summary>
        /// New values for the entity.
        /// </summary>
        /// <value>New values for the entity.</value>
        [DataMember(Name="newValues", EmitDefaultValue=false)]
        public List<string> NewValues { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityChange {\n");

            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  OldValues: ").Append(OldValues).Append("\n");
            sb.Append("  NewValues: ").Append(NewValues).Append("\n");
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
            return this.Equals(obj as EntityChange);
        }

        /// <summary>
        /// Returns true if EntityChange instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) &&
                (
                    this.EntityName == other.EntityName ||
                    this.EntityName != null &&
                    this.EntityName.Equals(other.EntityName)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.OldValues == other.OldValues ||
                    this.OldValues != null &&
                    this.OldValues.SequenceEqual(other.OldValues)
                ) &&
                (
                    this.NewValues == other.NewValues ||
                    this.NewValues != null &&
                    this.NewValues.SequenceEqual(other.NewValues)
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
                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();

                if (this.EntityName != null)
                    hash = hash * 59 + this.EntityName.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.OldValues != null)
                    hash = hash * 59 + this.OldValues.GetHashCode();

                if (this.NewValues != null)
                    hash = hash * 59 + this.NewValues.GetHashCode();

                return hash;
            }
        }
    }

}
