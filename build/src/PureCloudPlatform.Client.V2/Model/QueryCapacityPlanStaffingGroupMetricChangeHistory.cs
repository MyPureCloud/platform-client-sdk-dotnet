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
    /// QueryCapacityPlanStaffingGroupMetricChangeHistory
    /// </summary>
    [DataContract]
    public partial class QueryCapacityPlanStaffingGroupMetricChangeHistory :  IEquatable<QueryCapacityPlanStaffingGroupMetricChangeHistory>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCapacityPlanStaffingGroupMetricChangeHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryCapacityPlanStaffingGroupMetricChangeHistory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCapacityPlanStaffingGroupMetricChangeHistory" /> class.
        /// </summary>
        /// <param name="StaffingGroupIds">The IDs of the staffing groups for which to fetch the metric change history (required).</param>
        /// <param name="QueryEndDate">Fetch the history of metric changes on or before this date, in IS0-8601 format. If not specified, sets to current date.</param>
        public QueryCapacityPlanStaffingGroupMetricChangeHistory(List<string> StaffingGroupIds = null, DateTime? QueryEndDate = null)
        {
            this.StaffingGroupIds = StaffingGroupIds;
            this.QueryEndDate = QueryEndDate;
            
        }
        


        /// <summary>
        /// The IDs of the staffing groups for which to fetch the metric change history
        /// </summary>
        /// <value>The IDs of the staffing groups for which to fetch the metric change history</value>
        [DataMember(Name="staffingGroupIds", EmitDefaultValue=false)]
        public List<string> StaffingGroupIds { get; set; }



        /// <summary>
        /// Fetch the history of metric changes on or before this date, in IS0-8601 format. If not specified, sets to current date
        /// </summary>
        /// <value>Fetch the history of metric changes on or before this date, in IS0-8601 format. If not specified, sets to current date</value>
        [DataMember(Name="queryEndDate", EmitDefaultValue=false)]
        public DateTime? QueryEndDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCapacityPlanStaffingGroupMetricChangeHistory {\n");

            sb.Append("  StaffingGroupIds: ").Append(StaffingGroupIds).Append("\n");
            sb.Append("  QueryEndDate: ").Append(QueryEndDate).Append("\n");
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
            return this.Equals(obj as QueryCapacityPlanStaffingGroupMetricChangeHistory);
        }

        /// <summary>
        /// Returns true if QueryCapacityPlanStaffingGroupMetricChangeHistory instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryCapacityPlanStaffingGroupMetricChangeHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryCapacityPlanStaffingGroupMetricChangeHistory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StaffingGroupIds == other.StaffingGroupIds ||
                    this.StaffingGroupIds != null &&
                    this.StaffingGroupIds.SequenceEqual(other.StaffingGroupIds)
                ) &&
                (
                    this.QueryEndDate == other.QueryEndDate ||
                    this.QueryEndDate != null &&
                    this.QueryEndDate.Equals(other.QueryEndDate)
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
                if (this.StaffingGroupIds != null)
                    hash = hash * 59 + this.StaffingGroupIds.GetHashCode();

                if (this.QueryEndDate != null)
                    hash = hash * 59 + this.QueryEndDate.GetHashCode();

                return hash;
            }
        }
    }

}
