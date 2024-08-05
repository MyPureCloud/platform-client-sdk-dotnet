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
    /// LimitCount
    /// </summary>
    [DataContract]
    public partial class LimitCount :  IEquatable<LimitCount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitCount" /> class.
        /// </summary>
        /// <param name="Name">The name of the limit..</param>
        /// <param name="EstimatedCount">The total used count of the limit..</param>
        /// <param name="Max">The maximum value of the limit..</param>
        /// <param name="EntityId">The entity which makes this count unique. The context of what the entity is would be dependant on the limit. May not be applicable for all limits..</param>
        /// <param name="UserId">The user which makes this count unique. May not be applicable for all limits..</param>
        public LimitCount(string Name = null, long? EstimatedCount = null, long? Max = null, string EntityId = null, string UserId = null)
        {
            this.Name = Name;
            this.EstimatedCount = EstimatedCount;
            this.Max = Max;
            this.EntityId = EntityId;
            this.UserId = UserId;
            
        }
        


        /// <summary>
        /// The name of the limit.
        /// </summary>
        /// <value>The name of the limit.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The total used count of the limit.
        /// </summary>
        /// <value>The total used count of the limit.</value>
        [DataMember(Name="estimatedCount", EmitDefaultValue=false)]
        public long? EstimatedCount { get; set; }



        /// <summary>
        /// The maximum value of the limit.
        /// </summary>
        /// <value>The maximum value of the limit.</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public long? Max { get; set; }



        /// <summary>
        /// The entity which makes this count unique. The context of what the entity is would be dependant on the limit. May not be applicable for all limits.
        /// </summary>
        /// <value>The entity which makes this count unique. The context of what the entity is would be dependant on the limit. May not be applicable for all limits.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }



        /// <summary>
        /// The user which makes this count unique. May not be applicable for all limits.
        /// </summary>
        /// <value>The user which makes this count unique. May not be applicable for all limits.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitCount {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EstimatedCount: ").Append(EstimatedCount).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as LimitCount);
        }

        /// <summary>
        /// Returns true if LimitCount instances are equal
        /// </summary>
        /// <param name="other">Instance of LimitCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.EstimatedCount == other.EstimatedCount ||
                    this.EstimatedCount != null &&
                    this.EstimatedCount.Equals(other.EstimatedCount)
                ) &&
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
                ) &&
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.EstimatedCount != null)
                    hash = hash * 59 + this.EstimatedCount.GetHashCode();

                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();

                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                return hash;
            }
        }
    }

}
