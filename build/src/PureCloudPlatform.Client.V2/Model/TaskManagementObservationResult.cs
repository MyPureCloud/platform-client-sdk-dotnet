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
    /// TaskManagementObservationResult
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationResult :  IEquatable<TaskManagementObservationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationResult" /> class.
        /// </summary>
        /// <param name="Group">The group dimensions and their values for this result. Represents the combination of groupBy dimensions that define this result set..</param>
        /// <param name="Data">The metric data for this group. Contains the actual observation values for each requested metric..</param>
        public TaskManagementObservationResult(TaskManagementObservationGroupResult Group = null, List<TaskManagementObservationDataContainer> Data = null)
        {
            this.Group = Group;
            this.Data = Data;
            
        }
        


        /// <summary>
        /// The group dimensions and their values for this result. Represents the combination of groupBy dimensions that define this result set.
        /// </summary>
        /// <value>The group dimensions and their values for this result. Represents the combination of groupBy dimensions that define this result set.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public TaskManagementObservationGroupResult Group { get; set; }



        /// <summary>
        /// The metric data for this group. Contains the actual observation values for each requested metric.
        /// </summary>
        /// <value>The metric data for this group. Contains the actual observation values for each requested metric.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<TaskManagementObservationDataContainer> Data { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationResult {\n");

            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationResult);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();

                return hash;
            }
        }
    }

}
