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
    /// CapacityPlanDeleteRequest
    /// </summary>
    [DataContract]
    public partial class CapacityPlanDeleteRequest :  IEquatable<CapacityPlanDeleteRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanDeleteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanDeleteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanDeleteRequest" /> class.
        /// </summary>
        /// <param name="CapacityPlanIds">The IDs of the capacity plans to be deleted (required).</param>
        public CapacityPlanDeleteRequest(List<string> CapacityPlanIds = null)
        {
            this.CapacityPlanIds = CapacityPlanIds;
            
        }
        


        /// <summary>
        /// The IDs of the capacity plans to be deleted
        /// </summary>
        /// <value>The IDs of the capacity plans to be deleted</value>
        [DataMember(Name="capacityPlanIds", EmitDefaultValue=false)]
        public List<string> CapacityPlanIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanDeleteRequest {\n");

            sb.Append("  CapacityPlanIds: ").Append(CapacityPlanIds).Append("\n");
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
            return this.Equals(obj as CapacityPlanDeleteRequest);
        }

        /// <summary>
        /// Returns true if CapacityPlanDeleteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanDeleteRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CapacityPlanIds == other.CapacityPlanIds ||
                    this.CapacityPlanIds != null &&
                    this.CapacityPlanIds.SequenceEqual(other.CapacityPlanIds)
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
                if (this.CapacityPlanIds != null)
                    hash = hash * 59 + this.CapacityPlanIds.GetHashCode();

                return hash;
            }
        }
    }

}
