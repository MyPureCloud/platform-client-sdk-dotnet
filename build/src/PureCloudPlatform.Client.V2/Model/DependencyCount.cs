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
    /// An estimated count of entities that depend on this entity, including indirect dependencies.
    /// </summary>
    [DataContract]
    public partial class DependencyCount :  IEquatable<DependencyCount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyCount" /> class.
        /// </summary>
        public DependencyCount()
        {
            
        }
        


        /// <summary>
        /// Number of dependents.
        /// </summary>
        /// <value>Number of dependents.</value>
        [DataMember(Name="estimatedCount", EmitDefaultValue=false)]
        public int? EstimatedCount { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DependencyCount {\n");

            sb.Append("  EstimatedCount: ").Append(EstimatedCount).Append("\n");
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
            return this.Equals(obj as DependencyCount);
        }

        /// <summary>
        /// Returns true if DependencyCount instances are equal
        /// </summary>
        /// <param name="other">Instance of DependencyCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DependencyCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EstimatedCount == other.EstimatedCount ||
                    this.EstimatedCount != null &&
                    this.EstimatedCount.Equals(other.EstimatedCount)
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
                if (this.EstimatedCount != null)
                    hash = hash * 59 + this.EstimatedCount.GetHashCode();

                return hash;
            }
        }
    }

}
