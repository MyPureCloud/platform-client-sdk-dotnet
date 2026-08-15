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
    /// A dependency entity with its type and ID.
    /// </summary>
    [DataContract]
    public partial class DependencyEntity :  IEquatable<DependencyEntity>
    {
        /// <summary>
        /// The type of the entity
        /// </summary>
        /// <value>The type of the entity</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Integration for "Integration"
            /// </summary>
            [EnumMember(Value = "Integration")]
            Integration,
            
            /// <summary>
            /// Enum Dataaction for "DataAction"
            /// </summary>
            [EnumMember(Value = "DataAction")]
            Dataaction,
            
            /// <summary>
            /// Enum Credential for "Credential"
            /// </summary>
            [EnumMember(Value = "Credential")]
            Credential
        }
        /// <summary>
        /// The type of the entity
        /// </summary>
        /// <value>The type of the entity</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DependencyEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyEntity" /> class.
        /// </summary>
        /// <param name="EntityId">The ID of the entity. (required).</param>
        /// <param name="EntityType">The type of the entity (required).</param>
        public DependencyEntity(string EntityId = null, EntityTypeEnum? EntityType = null)
        {
            this.EntityId = EntityId;
            this.EntityType = EntityType;
            
        }
        


        /// <summary>
        /// The ID of the entity.
        /// </summary>
        /// <value>The ID of the entity.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DependencyEntity {\n");

            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
            return this.Equals(obj as DependencyEntity);
        }

        /// <summary>
        /// Returns true if DependencyEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of DependencyEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DependencyEntity other)
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
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
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

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                return hash;
            }
        }
    }

}
