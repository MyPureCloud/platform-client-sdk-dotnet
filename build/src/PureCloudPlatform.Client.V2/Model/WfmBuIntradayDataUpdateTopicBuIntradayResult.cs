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
    /// WfmBuIntradayDataUpdateTopicBuIntradayResult
    /// </summary>
    [DataContract]
    public partial class WfmBuIntradayDataUpdateTopicBuIntradayResult :  IEquatable<WfmBuIntradayDataUpdateTopicBuIntradayResult>
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
        /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuIntradayResult" /> class.
        /// </summary>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="IntervalLengthMinutes">IntervalLengthMinutes.</param>
        /// <param name="IntradayDataGroupings">IntradayDataGroupings.</param>
        /// <param name="Categories">Categories.</param>
        /// <param name="NoDataReason">NoDataReason.</param>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="ShortTermForecast">ShortTermForecast.</param>
        public WfmBuIntradayDataUpdateTopicBuIntradayResult(DateTime? StartDate = null, DateTime? EndDate = null, long? IntervalLengthMinutes = null, List<WfmBuIntradayDataUpdateTopicBuIntradayDataGroup> IntradayDataGroupings = null, List<CategoriesEnum> Categories = null, string NoDataReason = null, WfmBuIntradayDataUpdateTopicBuScheduleReference Schedule = null, WfmBuIntradayDataUpdateTopicBuShortTermForecastReference ShortTermForecast = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IntervalLengthMinutes = IntervalLengthMinutes;
            this.IntradayDataGroupings = IntradayDataGroupings;
            this.Categories = Categories;
            this.NoDataReason = NoDataReason;
            this.Schedule = Schedule;
            this.ShortTermForecast = ShortTermForecast;
            
        }
        


        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// Gets or Sets IntervalLengthMinutes
        /// </summary>
        [DataMember(Name="intervalLengthMinutes", EmitDefaultValue=false)]
        public long? IntervalLengthMinutes { get; set; }



        /// <summary>
        /// Gets or Sets IntradayDataGroupings
        /// </summary>
        [DataMember(Name="intradayDataGroupings", EmitDefaultValue=false)]
        public List<WfmBuIntradayDataUpdateTopicBuIntradayDataGroup> IntradayDataGroupings { get; set; }



        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<CategoriesEnum> Categories { get; set; }



        /// <summary>
        /// Gets or Sets NoDataReason
        /// </summary>
        [DataMember(Name="noDataReason", EmitDefaultValue=false)]
        public string NoDataReason { get; set; }



        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public WfmBuIntradayDataUpdateTopicBuScheduleReference Schedule { get; set; }



        /// <summary>
        /// Gets or Sets ShortTermForecast
        /// </summary>
        [DataMember(Name="shortTermForecast", EmitDefaultValue=false)]
        public WfmBuIntradayDataUpdateTopicBuShortTermForecastReference ShortTermForecast { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmBuIntradayDataUpdateTopicBuIntradayResult {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
            sb.Append("  IntradayDataGroupings: ").Append(IntradayDataGroupings).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  NoDataReason: ").Append(NoDataReason).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
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
            return this.Equals(obj as WfmBuIntradayDataUpdateTopicBuIntradayResult);
        }

        /// <summary>
        /// Returns true if WfmBuIntradayDataUpdateTopicBuIntradayResult instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuIntradayResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmBuIntradayDataUpdateTopicBuIntradayResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.IntervalLengthMinutes == other.IntervalLengthMinutes ||
                    this.IntervalLengthMinutes != null &&
                    this.IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
                ) &&
                (
                    this.IntradayDataGroupings == other.IntradayDataGroupings ||
                    this.IntradayDataGroupings != null &&
                    this.IntradayDataGroupings.SequenceEqual(other.IntradayDataGroupings)
                ) &&
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) &&
                (
                    this.NoDataReason == other.NoDataReason ||
                    this.NoDataReason != null &&
                    this.NoDataReason.Equals(other.NoDataReason)
                ) &&
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.ShortTermForecast == other.ShortTermForecast ||
                    this.ShortTermForecast != null &&
                    this.ShortTermForecast.Equals(other.ShortTermForecast)
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
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.IntervalLengthMinutes != null)
                    hash = hash * 59 + this.IntervalLengthMinutes.GetHashCode();

                if (this.IntradayDataGroupings != null)
                    hash = hash * 59 + this.IntradayDataGroupings.GetHashCode();

                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();

                if (this.NoDataReason != null)
                    hash = hash * 59 + this.NoDataReason.GetHashCode();

                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();

                if (this.ShortTermForecast != null)
                    hash = hash * 59 + this.ShortTermForecast.GetHashCode();

                return hash;
            }
        }
    }

}
