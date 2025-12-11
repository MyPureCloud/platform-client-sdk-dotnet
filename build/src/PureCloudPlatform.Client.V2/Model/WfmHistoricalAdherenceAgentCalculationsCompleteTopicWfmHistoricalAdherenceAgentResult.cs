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
    /// WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult :  IEquatable<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult>
    {
        /// <summary>
        /// Gets or Sets Impact
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ImpactEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Positive for "Positive"
            /// </summary>
            [EnumMember(Value = "Positive")]
            Positive,
            
            /// <summary>
            /// Enum Negative for "Negative"
            /// </summary>
            [EnumMember(Value = "Negative")]
            Negative,
            
            /// <summary>
            /// Enum Neutral for "Neutral"
            /// </summary>
            [EnumMember(Value = "Neutral")]
            Neutral
        }
        /// <summary>
        /// Gets or Sets Impact
        /// </summary>
        [DataMember(Name="impact", EmitDefaultValue=false)]
        public ImpactEnum? Impact { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="CalculationsCompletedDate">CalculationsCompletedDate.</param>
        /// <param name="TargetAdherencePercentage">TargetAdherencePercentage.</param>
        /// <param name="AdherencePercentage">AdherencePercentage.</param>
        /// <param name="ConformancePercentage">ConformancePercentage.</param>
        /// <param name="Impact">Impact.</param>
        /// <param name="ExceptionInfo">ExceptionInfo.</param>
        /// <param name="DayMetrics">DayMetrics.</param>
        /// <param name="Actuals">Actuals.</param>
        /// <param name="ScheduledActivities">ScheduledActivities.</param>
        /// <param name="SecondaryPresenceLookupItems">SecondaryPresenceLookupItems.</param>
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult(WfmHistoricalAdherenceAgentCalculationsCompleteTopicUserReference User = null, DateTime? StartDate = null, DateTime? EndDate = null, DateTime? CalculationsCompletedDate = null, double? TargetAdherencePercentage = null, double? AdherencePercentage = null, double? ConformancePercentage = null, ImpactEnum? Impact = null, List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceExceptionInfo> ExceptionInfo = null, List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics> DayMetrics = null, List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals> Actuals = null, List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity> ScheduledActivities = null, List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem> SecondaryPresenceLookupItems = null)
        {
            this.User = User;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.CalculationsCompletedDate = CalculationsCompletedDate;
            this.TargetAdherencePercentage = TargetAdherencePercentage;
            this.AdherencePercentage = AdherencePercentage;
            this.ConformancePercentage = ConformancePercentage;
            this.Impact = Impact;
            this.ExceptionInfo = ExceptionInfo;
            this.DayMetrics = DayMetrics;
            this.Actuals = Actuals;
            this.ScheduledActivities = ScheduledActivities;
            this.SecondaryPresenceLookupItems = SecondaryPresenceLookupItems;
            
        }
        


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmHistoricalAdherenceAgentCalculationsCompleteTopicUserReference User { get; set; }



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
        /// Gets or Sets CalculationsCompletedDate
        /// </summary>
        [DataMember(Name="calculationsCompletedDate", EmitDefaultValue=false)]
        public DateTime? CalculationsCompletedDate { get; set; }



        /// <summary>
        /// Gets or Sets TargetAdherencePercentage
        /// </summary>
        [DataMember(Name="targetAdherencePercentage", EmitDefaultValue=false)]
        public double? TargetAdherencePercentage { get; set; }



        /// <summary>
        /// Gets or Sets AdherencePercentage
        /// </summary>
        [DataMember(Name="adherencePercentage", EmitDefaultValue=false)]
        public double? AdherencePercentage { get; set; }



        /// <summary>
        /// Gets or Sets ConformancePercentage
        /// </summary>
        [DataMember(Name="conformancePercentage", EmitDefaultValue=false)]
        public double? ConformancePercentage { get; set; }





        /// <summary>
        /// Gets or Sets ExceptionInfo
        /// </summary>
        [DataMember(Name="exceptionInfo", EmitDefaultValue=false)]
        public List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceExceptionInfo> ExceptionInfo { get; set; }



        /// <summary>
        /// Gets or Sets DayMetrics
        /// </summary>
        [DataMember(Name="dayMetrics", EmitDefaultValue=false)]
        public List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentDayMetrics> DayMetrics { get; set; }



        /// <summary>
        /// Gets or Sets Actuals
        /// </summary>
        [DataMember(Name="actuals", EmitDefaultValue=false)]
        public List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceActuals> Actuals { get; set; }



        /// <summary>
        /// Gets or Sets ScheduledActivities
        /// </summary>
        [DataMember(Name="scheduledActivities", EmitDefaultValue=false)]
        public List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceScheduledActivity> ScheduledActivities { get; set; }



        /// <summary>
        /// Gets or Sets SecondaryPresenceLookupItems
        /// </summary>
        [DataMember(Name="secondaryPresenceLookupItems", EmitDefaultValue=false)]
        public List<WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmSecondaryPresenceLookupItem> SecondaryPresenceLookupItems { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  CalculationsCompletedDate: ").Append(CalculationsCompletedDate).Append("\n");
            sb.Append("  TargetAdherencePercentage: ").Append(TargetAdherencePercentage).Append("\n");
            sb.Append("  AdherencePercentage: ").Append(AdherencePercentage).Append("\n");
            sb.Append("  ConformancePercentage: ").Append(ConformancePercentage).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
            sb.Append("  ExceptionInfo: ").Append(ExceptionInfo).Append("\n");
            sb.Append("  DayMetrics: ").Append(DayMetrics).Append("\n");
            sb.Append("  Actuals: ").Append(Actuals).Append("\n");
            sb.Append("  ScheduledActivities: ").Append(ScheduledActivities).Append("\n");
            sb.Append("  SecondaryPresenceLookupItems: ").Append(SecondaryPresenceLookupItems).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceAgentCalculationsCompleteTopicWfmHistoricalAdherenceAgentResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
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
                    this.CalculationsCompletedDate == other.CalculationsCompletedDate ||
                    this.CalculationsCompletedDate != null &&
                    this.CalculationsCompletedDate.Equals(other.CalculationsCompletedDate)
                ) &&
                (
                    this.TargetAdherencePercentage == other.TargetAdherencePercentage ||
                    this.TargetAdherencePercentage != null &&
                    this.TargetAdherencePercentage.Equals(other.TargetAdherencePercentage)
                ) &&
                (
                    this.AdherencePercentage == other.AdherencePercentage ||
                    this.AdherencePercentage != null &&
                    this.AdherencePercentage.Equals(other.AdherencePercentage)
                ) &&
                (
                    this.ConformancePercentage == other.ConformancePercentage ||
                    this.ConformancePercentage != null &&
                    this.ConformancePercentage.Equals(other.ConformancePercentage)
                ) &&
                (
                    this.Impact == other.Impact ||
                    this.Impact != null &&
                    this.Impact.Equals(other.Impact)
                ) &&
                (
                    this.ExceptionInfo == other.ExceptionInfo ||
                    this.ExceptionInfo != null &&
                    this.ExceptionInfo.SequenceEqual(other.ExceptionInfo)
                ) &&
                (
                    this.DayMetrics == other.DayMetrics ||
                    this.DayMetrics != null &&
                    this.DayMetrics.SequenceEqual(other.DayMetrics)
                ) &&
                (
                    this.Actuals == other.Actuals ||
                    this.Actuals != null &&
                    this.Actuals.SequenceEqual(other.Actuals)
                ) &&
                (
                    this.ScheduledActivities == other.ScheduledActivities ||
                    this.ScheduledActivities != null &&
                    this.ScheduledActivities.SequenceEqual(other.ScheduledActivities)
                ) &&
                (
                    this.SecondaryPresenceLookupItems == other.SecondaryPresenceLookupItems ||
                    this.SecondaryPresenceLookupItems != null &&
                    this.SecondaryPresenceLookupItems.SequenceEqual(other.SecondaryPresenceLookupItems)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.CalculationsCompletedDate != null)
                    hash = hash * 59 + this.CalculationsCompletedDate.GetHashCode();

                if (this.TargetAdherencePercentage != null)
                    hash = hash * 59 + this.TargetAdherencePercentage.GetHashCode();

                if (this.AdherencePercentage != null)
                    hash = hash * 59 + this.AdherencePercentage.GetHashCode();

                if (this.ConformancePercentage != null)
                    hash = hash * 59 + this.ConformancePercentage.GetHashCode();

                if (this.Impact != null)
                    hash = hash * 59 + this.Impact.GetHashCode();

                if (this.ExceptionInfo != null)
                    hash = hash * 59 + this.ExceptionInfo.GetHashCode();

                if (this.DayMetrics != null)
                    hash = hash * 59 + this.DayMetrics.GetHashCode();

                if (this.Actuals != null)
                    hash = hash * 59 + this.Actuals.GetHashCode();

                if (this.ScheduledActivities != null)
                    hash = hash * 59 + this.ScheduledActivities.GetHashCode();

                if (this.SecondaryPresenceLookupItems != null)
                    hash = hash * 59 + this.SecondaryPresenceLookupItems.GetHashCode();

                return hash;
            }
        }
    }

}
