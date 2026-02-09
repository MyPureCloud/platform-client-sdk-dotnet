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
    /// TaskManagementObservationQueryFilter
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationQueryFilter :  IEquatable<TaskManagementObservationQueryFilter>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationQueryFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskManagementObservationQueryFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationQueryFilter" /> class.
        /// </summary>
        /// <param name="Predicates">List of predicates that define the filter conditions. Each predicate specifies a dimension and value to filter by. A single queueId predicate is always required. (required).</param>
        public TaskManagementObservationQueryFilter(List<TaskManagementObservationPredicate> Predicates = null)
        {
            this.Predicates = Predicates;
            
        }
        


        /// <summary>
        /// List of predicates that define the filter conditions. Each predicate specifies a dimension and value to filter by. A single queueId predicate is always required.
        /// </summary>
        /// <value>List of predicates that define the filter conditions. Each predicate specifies a dimension and value to filter by. A single queueId predicate is always required.</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<TaskManagementObservationPredicate> Predicates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationQueryFilter {\n");

            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationQueryFilter);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationQueryFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationQueryFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationQueryFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
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
                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();

                return hash;
            }
        }
    }

}
