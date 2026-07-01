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
    /// EstimateAvailableFullDayTimeOffResponse
    /// </summary>
    [DataContract]
    public partial class EstimateAvailableFullDayTimeOffResponse :  IEquatable<EstimateAvailableFullDayTimeOffResponse>
    {
        /// <summary>
        /// The override date type, if the requested day is an override date
        /// </summary>
        /// <value>The override date type, if the requested day is an override date</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OverrideDateTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Blocked for "Blocked"
            /// </summary>
            [EnumMember(Value = "Blocked")]
            Blocked,
            
            /// <summary>
            /// Enum Manualreview for "ManualReview"
            /// </summary>
            [EnumMember(Value = "ManualReview")]
            Manualreview
        }
        /// <summary>
        /// The override date type, if the requested day is an override date
        /// </summary>
        /// <value>The override date type, if the requested day is an override date</value>
        [DataMember(Name="overrideDateType", EmitDefaultValue=false)]
        public OverrideDateTypeEnum? OverrideDateType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimateAvailableFullDayTimeOffResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailableFullDayTimeOffResponse" /> class.
        /// </summary>
        /// <param name="Date">Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="DurationMinutes">An estimation of time off request length in minutes (required).</param>
        /// <param name="PayableMinutes">An estimation of payable part of time off request in minutes (required).</param>
        /// <param name="Flexible">Whether there is flexibility for a user to choose different hours than the system estimated (required).</param>
        /// <param name="OverrideDateType">The override date type, if the requested day is an override date.</param>
        /// <param name="EarliestStartOffsetMinutes">Earliest start time in minutes from midnight for full day request. Value may be null when time-off estimation is disabled.</param>
        /// <param name="LatestEndOffsetMinutes">Latest end time in minutes from midnight for full day request. Value may be null when time-off estimation is disabled.</param>
        public EstimateAvailableFullDayTimeOffResponse(String Date = null, int? DurationMinutes = null, int? PayableMinutes = null, bool? Flexible = null, OverrideDateTypeEnum? OverrideDateType = null, int? EarliestStartOffsetMinutes = null, int? LatestEndOffsetMinutes = null)
        {
            this.Date = Date;
            this.DurationMinutes = DurationMinutes;
            this.PayableMinutes = PayableMinutes;
            this.Flexible = Flexible;
            this.OverrideDateType = OverrideDateType;
            this.EarliestStartOffsetMinutes = EarliestStartOffsetMinutes;
            this.LatestEndOffsetMinutes = LatestEndOffsetMinutes;
            
        }
        


        /// <summary>
        /// Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Date in yyyy-MM-dd format for full day request. Should be interpreted in the business unit&#39;s configured time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public String Date { get; set; }



        /// <summary>
        /// An estimation of time off request length in minutes
        /// </summary>
        /// <value>An estimation of time off request length in minutes</value>
        [DataMember(Name="durationMinutes", EmitDefaultValue=false)]
        public int? DurationMinutes { get; set; }



        /// <summary>
        /// An estimation of payable part of time off request in minutes
        /// </summary>
        /// <value>An estimation of payable part of time off request in minutes</value>
        [DataMember(Name="payableMinutes", EmitDefaultValue=false)]
        public int? PayableMinutes { get; set; }



        /// <summary>
        /// Whether there is flexibility for a user to choose different hours than the system estimated
        /// </summary>
        /// <value>Whether there is flexibility for a user to choose different hours than the system estimated</value>
        [DataMember(Name="flexible", EmitDefaultValue=false)]
        public bool? Flexible { get; set; }





        /// <summary>
        /// Earliest start time in minutes from midnight for full day request. Value may be null when time-off estimation is disabled
        /// </summary>
        /// <value>Earliest start time in minutes from midnight for full day request. Value may be null when time-off estimation is disabled</value>
        [DataMember(Name="earliestStartOffsetMinutes", EmitDefaultValue=false)]
        public int? EarliestStartOffsetMinutes { get; set; }



        /// <summary>
        /// Latest end time in minutes from midnight for full day request. Value may be null when time-off estimation is disabled
        /// </summary>
        /// <value>Latest end time in minutes from midnight for full day request. Value may be null when time-off estimation is disabled</value>
        [DataMember(Name="latestEndOffsetMinutes", EmitDefaultValue=false)]
        public int? LatestEndOffsetMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateAvailableFullDayTimeOffResponse {\n");

            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DurationMinutes: ").Append(DurationMinutes).Append("\n");
            sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
            sb.Append("  Flexible: ").Append(Flexible).Append("\n");
            sb.Append("  OverrideDateType: ").Append(OverrideDateType).Append("\n");
            sb.Append("  EarliestStartOffsetMinutes: ").Append(EarliestStartOffsetMinutes).Append("\n");
            sb.Append("  LatestEndOffsetMinutes: ").Append(LatestEndOffsetMinutes).Append("\n");
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
            return this.Equals(obj as EstimateAvailableFullDayTimeOffResponse);
        }

        /// <summary>
        /// Returns true if EstimateAvailableFullDayTimeOffResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EstimateAvailableFullDayTimeOffResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateAvailableFullDayTimeOffResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.DurationMinutes == other.DurationMinutes ||
                    this.DurationMinutes != null &&
                    this.DurationMinutes.Equals(other.DurationMinutes)
                ) &&
                (
                    this.PayableMinutes == other.PayableMinutes ||
                    this.PayableMinutes != null &&
                    this.PayableMinutes.Equals(other.PayableMinutes)
                ) &&
                (
                    this.Flexible == other.Flexible ||
                    this.Flexible != null &&
                    this.Flexible.Equals(other.Flexible)
                ) &&
                (
                    this.OverrideDateType == other.OverrideDateType ||
                    this.OverrideDateType != null &&
                    this.OverrideDateType.Equals(other.OverrideDateType)
                ) &&
                (
                    this.EarliestStartOffsetMinutes == other.EarliestStartOffsetMinutes ||
                    this.EarliestStartOffsetMinutes != null &&
                    this.EarliestStartOffsetMinutes.Equals(other.EarliestStartOffsetMinutes)
                ) &&
                (
                    this.LatestEndOffsetMinutes == other.LatestEndOffsetMinutes ||
                    this.LatestEndOffsetMinutes != null &&
                    this.LatestEndOffsetMinutes.Equals(other.LatestEndOffsetMinutes)
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
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                if (this.DurationMinutes != null)
                    hash = hash * 59 + this.DurationMinutes.GetHashCode();

                if (this.PayableMinutes != null)
                    hash = hash * 59 + this.PayableMinutes.GetHashCode();

                if (this.Flexible != null)
                    hash = hash * 59 + this.Flexible.GetHashCode();

                if (this.OverrideDateType != null)
                    hash = hash * 59 + this.OverrideDateType.GetHashCode();

                if (this.EarliestStartOffsetMinutes != null)
                    hash = hash * 59 + this.EarliestStartOffsetMinutes.GetHashCode();

                if (this.LatestEndOffsetMinutes != null)
                    hash = hash * 59 + this.LatestEndOffsetMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
