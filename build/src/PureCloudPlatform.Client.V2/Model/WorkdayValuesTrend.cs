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
    /// WorkdayValuesTrend
    /// </summary>
    [DataContract]
    public partial class WorkdayValuesTrend :  IEquatable<WorkdayValuesTrend>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkdayValuesTrend" /> class.
        /// </summary>
        public WorkdayValuesTrend()
        {
            
        }
        


        /// <summary>
        /// The start workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStartWorkday", EmitDefaultValue=false)]
        public String DateStartWorkday { get; private set; }



        /// <summary>
        /// The end workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The end workday for the query range for the metric value trend. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEndWorkday", EmitDefaultValue=false)]
        public String DateEndWorkday { get; private set; }



        /// <summary>
        /// The reference workday used to determine the metric definition. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The reference workday used to determine the metric definition. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateReferenceWorkday", EmitDefaultValue=false)]
        public String DateReferenceWorkday { get; private set; }



        /// <summary>
        /// The targeted division for the query
        /// </summary>
        /// <value>The targeted division for the query</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; private set; }



        /// <summary>
        /// The targeted user for the query
        /// </summary>
        /// <value>The targeted user for the query</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; private set; }



        /// <summary>
        /// The time zone used for aggregating metric values
        /// </summary>
        /// <value>The time zone used for aggregating metric values</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; private set; }



        /// <summary>
        /// The metric value trends
        /// </summary>
        /// <value>The metric value trends</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<WorkdayValuesMetricItem> Results { get; private set; }



        /// <summary>
        /// The targeted performance profile for the average points
        /// </summary>
        /// <value>The targeted performance profile for the average points</value>
        [DataMember(Name="performanceProfile", EmitDefaultValue=false)]
        public AddressableEntityRef PerformanceProfile { get; private set; }



        /// <summary>
        /// The targeted metric for the average points
        /// </summary>
        /// <value>The targeted metric for the average points</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public AddressableEntityRef Metric { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkdayValuesTrend {\n");

            sb.Append("  DateStartWorkday: ").Append(DateStartWorkday).Append("\n");
            sb.Append("  DateEndWorkday: ").Append(DateEndWorkday).Append("\n");
            sb.Append("  DateReferenceWorkday: ").Append(DateReferenceWorkday).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  PerformanceProfile: ").Append(PerformanceProfile).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
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
            return this.Equals(obj as WorkdayValuesTrend);
        }

        /// <summary>
        /// Returns true if WorkdayValuesTrend instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkdayValuesTrend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkdayValuesTrend other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateStartWorkday == other.DateStartWorkday ||
                    this.DateStartWorkday != null &&
                    this.DateStartWorkday.Equals(other.DateStartWorkday)
                ) &&
                (
                    this.DateEndWorkday == other.DateEndWorkday ||
                    this.DateEndWorkday != null &&
                    this.DateEndWorkday.Equals(other.DateEndWorkday)
                ) &&
                (
                    this.DateReferenceWorkday == other.DateReferenceWorkday ||
                    this.DateReferenceWorkday != null &&
                    this.DateReferenceWorkday.Equals(other.DateReferenceWorkday)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.PerformanceProfile == other.PerformanceProfile ||
                    this.PerformanceProfile != null &&
                    this.PerformanceProfile.Equals(other.PerformanceProfile)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
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
                if (this.DateStartWorkday != null)
                    hash = hash * 59 + this.DateStartWorkday.GetHashCode();

                if (this.DateEndWorkday != null)
                    hash = hash * 59 + this.DateEndWorkday.GetHashCode();

                if (this.DateReferenceWorkday != null)
                    hash = hash * 59 + this.DateReferenceWorkday.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.PerformanceProfile != null)
                    hash = hash * 59 + this.PerformanceProfile.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                return hash;
            }
        }
    }

}
