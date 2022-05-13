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
    /// IntradayPlanningGroupRequest
    /// </summary>
    [DataContract]
    public partial class IntradayPlanningGroupRequest :  IEquatable<IntradayPlanningGroupRequest>
    {
        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoriesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Forecastdata for "ForecastData"
            /// </summary>
            [EnumMember(Value = "ForecastData")]
            Forecastdata,
            
            /// <summary>
            /// Enum Scheduledata for "ScheduleData"
            /// </summary>
            [EnumMember(Value = "ScheduleData")]
            Scheduledata,
            
            /// <summary>
            /// Enum Performancepredictiondata for "PerformancePredictionData"
            /// </summary>
            [EnumMember(Value = "PerformancePredictionData")]
            Performancepredictiondata
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayPlanningGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntradayPlanningGroupRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntradayPlanningGroupRequest" /> class.
        /// </summary>
        /// <param name="BusinessUnitDate">Requested date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="Categories">The metric categories (required).</param>
        /// <param name="PlanningGroupIds">The IDs of the planning groups for which to fetch data.  Omitting or passing an empty list will return all available planning groups.</param>
        /// <param name="IntervalLengthMinutes">The period/interval in minutes for which to aggregate the data. Required, defaults to 15.</param>
        public IntradayPlanningGroupRequest(String BusinessUnitDate = null, List<CategoriesEnum> Categories = null, List<string> PlanningGroupIds = null, int? IntervalLengthMinutes = null)
        {
            this.BusinessUnitDate = BusinessUnitDate;
            this.Categories = Categories;
            this.PlanningGroupIds = PlanningGroupIds;
            this.IntervalLengthMinutes = IntervalLengthMinutes;
            
        }
        


        /// <summary>
        /// Requested date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Requested date in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="businessUnitDate", EmitDefaultValue=false)]
        public String BusinessUnitDate { get; set; }



        /// <summary>
        /// The metric categories
        /// </summary>
        /// <value>The metric categories</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<CategoriesEnum> Categories { get; set; }



        /// <summary>
        /// The IDs of the planning groups for which to fetch data.  Omitting or passing an empty list will return all available planning groups
        /// </summary>
        /// <value>The IDs of the planning groups for which to fetch data.  Omitting or passing an empty list will return all available planning groups</value>
        [DataMember(Name="planningGroupIds", EmitDefaultValue=false)]
        public List<string> PlanningGroupIds { get; set; }



        /// <summary>
        /// The period/interval in minutes for which to aggregate the data. Required, defaults to 15
        /// </summary>
        /// <value>The period/interval in minutes for which to aggregate the data. Required, defaults to 15</value>
        [DataMember(Name="intervalLengthMinutes", EmitDefaultValue=false)]
        public int? IntervalLengthMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntradayPlanningGroupRequest {\n");

            sb.Append("  BusinessUnitDate: ").Append(BusinessUnitDate).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
            sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
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
            return this.Equals(obj as IntradayPlanningGroupRequest);
        }

        /// <summary>
        /// Returns true if IntradayPlanningGroupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of IntradayPlanningGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntradayPlanningGroupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BusinessUnitDate == other.BusinessUnitDate ||
                    this.BusinessUnitDate != null &&
                    this.BusinessUnitDate.Equals(other.BusinessUnitDate)
                ) &&
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) &&
                (
                    this.PlanningGroupIds == other.PlanningGroupIds ||
                    this.PlanningGroupIds != null &&
                    this.PlanningGroupIds.SequenceEqual(other.PlanningGroupIds)
                ) &&
                (
                    this.IntervalLengthMinutes == other.IntervalLengthMinutes ||
                    this.IntervalLengthMinutes != null &&
                    this.IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
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
                if (this.BusinessUnitDate != null)
                    hash = hash * 59 + this.BusinessUnitDate.GetHashCode();

                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();

                if (this.PlanningGroupIds != null)
                    hash = hash * 59 + this.PlanningGroupIds.GetHashCode();

                if (this.IntervalLengthMinutes != null)
                    hash = hash * 59 + this.IntervalLengthMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
