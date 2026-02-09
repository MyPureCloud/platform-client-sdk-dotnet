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
    /// TaskManagementObservationMetricStats
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationMetricStats :  IEquatable<TaskManagementObservationMetricStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationMetricStats" /> class.
        /// </summary>
        /// <param name="Count">The observed value for this metric.</param>
        /// <param name="Max">The maximum observed value for this metric. Used for &#x60;oWorkitemOldestUnassigned&#x60; and  &#x60;oWorkitemOldestAssigned&#x60;.</param>
        public TaskManagementObservationMetricStats(int? Count = null, long? Max = null)
        {
            this.Count = Count;
            this.Max = Max;
            
        }
        


        /// <summary>
        /// The observed value for this metric
        /// </summary>
        /// <value>The observed value for this metric</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }



        /// <summary>
        /// The maximum observed value for this metric. Used for &#x60;oWorkitemOldestUnassigned&#x60; and  &#x60;oWorkitemOldestAssigned&#x60;
        /// </summary>
        /// <value>The maximum observed value for this metric. Used for &#x60;oWorkitemOldestUnassigned&#x60; and  &#x60;oWorkitemOldestAssigned&#x60;</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public long? Max { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationMetricStats {\n");

            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationMetricStats);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationMetricStats instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationMetricStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationMetricStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) &&
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();

                return hash;
            }
        }
    }

}
