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
    /// QueryTimeOffLimitValuesRequest
    /// </summary>
    [DataContract]
    public partial class QueryTimeOffLimitValuesRequest :  IEquatable<QueryTimeOffLimitValuesRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTimeOffLimitValuesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryTimeOffLimitValuesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTimeOffLimitValuesRequest" /> class.
        /// </summary>
        /// <param name="TimeOffLimitId">The time off limit object id to retrieve values for. Required if activityCodeId is not specified.</param>
        /// <param name="ActivityCodeId">The ID of the activity code by which to filter the affected limit objects. Required if timeOffLimitId is not specified.</param>
        /// <param name="DateRanges">The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366. (required).</param>
        public QueryTimeOffLimitValuesRequest(string TimeOffLimitId = null, string ActivityCodeId = null, List<LocalDateRange> DateRanges = null)
        {
            this.TimeOffLimitId = TimeOffLimitId;
            this.ActivityCodeId = ActivityCodeId;
            this.DateRanges = DateRanges;
            
        }
        


        /// <summary>
        /// The time off limit object id to retrieve values for. Required if activityCodeId is not specified
        /// </summary>
        /// <value>The time off limit object id to retrieve values for. Required if activityCodeId is not specified</value>
        [DataMember(Name="timeOffLimitId", EmitDefaultValue=false)]
        public string TimeOffLimitId { get; set; }



        /// <summary>
        /// The ID of the activity code by which to filter the affected limit objects. Required if timeOffLimitId is not specified
        /// </summary>
        /// <value>The ID of the activity code by which to filter the affected limit objects. Required if timeOffLimitId is not specified</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366.
        /// </summary>
        /// <value>The list of the date ranges to return time off limit, allocated and waitlisted minutes. The valid number of date ranges is between 1 and 30. Maximum total number of days in all ranges in 366.</value>
        [DataMember(Name="dateRanges", EmitDefaultValue=false)]
        public List<LocalDateRange> DateRanges { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTimeOffLimitValuesRequest {\n");

            sb.Append("  TimeOffLimitId: ").Append(TimeOffLimitId).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
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
            return this.Equals(obj as QueryTimeOffLimitValuesRequest);
        }

        /// <summary>
        /// Returns true if QueryTimeOffLimitValuesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryTimeOffLimitValuesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryTimeOffLimitValuesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeOffLimitId == other.TimeOffLimitId ||
                    this.TimeOffLimitId != null &&
                    this.TimeOffLimitId.Equals(other.TimeOffLimitId)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.DateRanges == other.DateRanges ||
                    this.DateRanges != null &&
                    this.DateRanges.SequenceEqual(other.DateRanges)
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
                if (this.TimeOffLimitId != null)
                    hash = hash * 59 + this.TimeOffLimitId.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.DateRanges != null)
                    hash = hash * 59 + this.DateRanges.GetHashCode();

                return hash;
            }
        }
    }

}
