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
    /// TaskManagementObservationQuery
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationQuery :  IEquatable<TaskManagementObservationQuery>
    {
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Typeid for "typeId"
            /// </summary>
            [EnumMember(Value = "typeId")]
            Typeid,
            
            /// <summary>
            /// Enum Assigneeid for "assigneeId"
            /// </summary>
            [EnumMember(Value = "assigneeId")]
            Assigneeid,
            
            /// <summary>
            /// Enum Statuscategory for "statusCategory"
            /// </summary>
            [EnumMember(Value = "statusCategory")]
            Statuscategory
        }
        /// <summary>
        /// Gets or Sets Expands
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExpandsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Type for "type"
            /// </summary>
            [EnumMember(Value = "type")]
            Type,
            
            /// <summary>
            /// Enum Assignee for "assignee"
            /// </summary>
            [EnumMember(Value = "assignee")]
            Assignee
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskManagementObservationQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationQuery" /> class.
        /// </summary>
        /// <param name="GroupBy">Dimension(s) to group by. Determines how the results will be grouped in the response. (required).</param>
        /// <param name="Metrics">List of metrics to be retrieved. Specifies which observational metrics should be included in the response. (required).</param>
        /// <param name="Filter">Filter to return a subset of observations. (required).</param>
        /// <param name="Expands">List of properties to expand. Additional details about the objects returned in the results will be included in the response if supplied..</param>
        public TaskManagementObservationQuery(List<GroupByEnum> GroupBy = null, List<TaskManagementQueryMetric> Metrics = null, TaskManagementObservationQueryFilter Filter = null, List<ExpandsEnum> Expands = null)
        {
            this.GroupBy = GroupBy;
            this.Metrics = Metrics;
            this.Filter = Filter;
            this.Expands = Expands;
            
        }
        


        /// <summary>
        /// Dimension(s) to group by. Determines how the results will be grouped in the response.
        /// </summary>
        /// <value>Dimension(s) to group by. Determines how the results will be grouped in the response.</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<GroupByEnum> GroupBy { get; set; }



        /// <summary>
        /// List of metrics to be retrieved. Specifies which observational metrics should be included in the response.
        /// </summary>
        /// <value>List of metrics to be retrieved. Specifies which observational metrics should be included in the response.</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<TaskManagementQueryMetric> Metrics { get; set; }



        /// <summary>
        /// Filter to return a subset of observations.
        /// </summary>
        /// <value>Filter to return a subset of observations.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public TaskManagementObservationQueryFilter Filter { get; set; }



        /// <summary>
        /// List of properties to expand. Additional details about the objects returned in the results will be included in the response if supplied.
        /// </summary>
        /// <value>List of properties to expand. Additional details about the objects returned in the results will be included in the response if supplied.</value>
        [DataMember(Name="expands", EmitDefaultValue=false)]
        public List<ExpandsEnum> Expands { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationQuery {\n");

            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Expands: ").Append(Expands).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationQuery);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.GroupBy == other.GroupBy ||
                    this.GroupBy != null &&
                    this.GroupBy.SequenceEqual(other.GroupBy)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Expands == other.Expands ||
                    this.Expands != null &&
                    this.Expands.SequenceEqual(other.Expands)
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
                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.Expands != null)
                    hash = hash * 59 + this.Expands.GetHashCode();

                return hash;
            }
        }
    }

}
