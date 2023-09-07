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
    /// WfmHistoricalAdherenceBulkUserResult
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalAdherenceBulkUserResult :  IEquatable<WfmHistoricalAdherenceBulkUserResult>
    {
        /// <summary>
        /// The impact of the current adherence state for this user
        /// </summary>
        /// <value>The impact of the current adherence state for this user</value>
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
            Neutral,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The impact of the current adherence state for this user
        /// </summary>
        /// <value>The impact of the current adherence state for this user</value>
        [DataMember(Name="impact", EmitDefaultValue=false)]
        public ImpactEnum? Impact { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkUserResult" /> class.
        /// </summary>
        /// <param name="UserId">The ID of the user for whom the adherence is queried.</param>
        /// <param name="AdherencePercentage">Adherence percentage for this user, in the scale of 0 - 100.</param>
        /// <param name="ConformancePercentage">Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period..</param>
        /// <param name="Impact">The impact of the current adherence state for this user.</param>
        /// <param name="ExceptionInfo">List of adherence exceptions for this user.</param>
        /// <param name="Actuals">List of adherence actuals for this user.</param>
        /// <param name="DayMetrics">Adherence and conformance metrics for days in query range.</param>
        public WfmHistoricalAdherenceBulkUserResult(string UserId = null, double? AdherencePercentage = null, double? ConformancePercentage = null, ImpactEnum? Impact = null, List<HistoricalAdherenceExceptionInfo> ExceptionInfo = null, List<HistoricalAdherenceActuals> Actuals = null, List<WfmHistoricalAdherenceBulkUserDayMetrics> DayMetrics = null)
        {
            this.UserId = UserId;
            this.AdherencePercentage = AdherencePercentage;
            this.ConformancePercentage = ConformancePercentage;
            this.Impact = Impact;
            this.ExceptionInfo = ExceptionInfo;
            this.Actuals = Actuals;
            this.DayMetrics = DayMetrics;
            
        }
        


        /// <summary>
        /// The ID of the user for whom the adherence is queried
        /// </summary>
        /// <value>The ID of the user for whom the adherence is queried</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Adherence percentage for this user, in the scale of 0 - 100
        /// </summary>
        /// <value>Adherence percentage for this user, in the scale of 0 - 100</value>
        [DataMember(Name="adherencePercentage", EmitDefaultValue=false)]
        public double? AdherencePercentage { get; set; }



        /// <summary>
        /// Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.
        /// </summary>
        /// <value>Conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.</value>
        [DataMember(Name="conformancePercentage", EmitDefaultValue=false)]
        public double? ConformancePercentage { get; set; }





        /// <summary>
        /// List of adherence exceptions for this user
        /// </summary>
        /// <value>List of adherence exceptions for this user</value>
        [DataMember(Name="exceptionInfo", EmitDefaultValue=false)]
        public List<HistoricalAdherenceExceptionInfo> ExceptionInfo { get; set; }



        /// <summary>
        /// List of adherence actuals for this user
        /// </summary>
        /// <value>List of adherence actuals for this user</value>
        [DataMember(Name="actuals", EmitDefaultValue=false)]
        public List<HistoricalAdherenceActuals> Actuals { get; set; }



        /// <summary>
        /// Adherence and conformance metrics for days in query range
        /// </summary>
        /// <value>Adherence and conformance metrics for days in query range</value>
        [DataMember(Name="dayMetrics", EmitDefaultValue=false)]
        public List<WfmHistoricalAdherenceBulkUserDayMetrics> DayMetrics { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalAdherenceBulkUserResult {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AdherencePercentage: ").Append(AdherencePercentage).Append("\n");
            sb.Append("  ConformancePercentage: ").Append(ConformancePercentage).Append("\n");
            sb.Append("  Impact: ").Append(Impact).Append("\n");
            sb.Append("  ExceptionInfo: ").Append(ExceptionInfo).Append("\n");
            sb.Append("  Actuals: ").Append(Actuals).Append("\n");
            sb.Append("  DayMetrics: ").Append(DayMetrics).Append("\n");
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
            return this.Equals(obj as WfmHistoricalAdherenceBulkUserResult);
        }

        /// <summary>
        /// Returns true if WfmHistoricalAdherenceBulkUserResult instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalAdherenceBulkUserResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalAdherenceBulkUserResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                    this.Actuals == other.Actuals ||
                    this.Actuals != null &&
                    this.Actuals.SequenceEqual(other.Actuals)
                ) &&
                (
                    this.DayMetrics == other.DayMetrics ||
                    this.DayMetrics != null &&
                    this.DayMetrics.SequenceEqual(other.DayMetrics)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.AdherencePercentage != null)
                    hash = hash * 59 + this.AdherencePercentage.GetHashCode();

                if (this.ConformancePercentage != null)
                    hash = hash * 59 + this.ConformancePercentage.GetHashCode();

                if (this.Impact != null)
                    hash = hash * 59 + this.Impact.GetHashCode();

                if (this.ExceptionInfo != null)
                    hash = hash * 59 + this.ExceptionInfo.GetHashCode();

                if (this.Actuals != null)
                    hash = hash * 59 + this.Actuals.GetHashCode();

                if (this.DayMetrics != null)
                    hash = hash * 59 + this.DayMetrics.GetHashCode();

                return hash;
            }
        }
    }

}
