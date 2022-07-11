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
    /// AvailableTimeOffRange
    /// </summary>
    [DataContract]
    public partial class AvailableTimeOffRange :  IEquatable<AvailableTimeOffRange>
    {
        /// <summary>
        /// Granularity choice for time off limit
        /// </summary>
        /// <value>Granularity choice for time off limit</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GranularityEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Daily for "Daily"
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily
        }
        /// <summary>
        /// Granularity choice for time off limit
        /// </summary>
        /// <value>Granularity choice for time off limit</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableTimeOffRange" /> class.
        /// </summary>
        /// <param name="TimeOffLimit">The time off limit.</param>
        /// <param name="StartDate">Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="Granularity">Granularity choice for time off limit.</param>
        /// <param name="AvailableMinutesPerInterval">The list of available time off values in minutes per granularity interval.</param>
        /// <param name="WaitlistedRequestsPerInterval">The current number of waitlisted time off requests for every interval per granularity.</param>
        /// <param name="WaitlistEnabled">Whether the time off request can be waitlisted.</param>
        public AvailableTimeOffRange(TimeOffLimitReference TimeOffLimit = null, String StartDate = null, GranularityEnum? Granularity = null, List<int?> AvailableMinutesPerInterval = null, List<int?> WaitlistedRequestsPerInterval = null, bool? WaitlistEnabled = null)
        {
            this.TimeOffLimit = TimeOffLimit;
            this.StartDate = StartDate;
            this.Granularity = Granularity;
            this.AvailableMinutesPerInterval = AvailableMinutesPerInterval;
            this.WaitlistedRequestsPerInterval = WaitlistedRequestsPerInterval;
            this.WaitlistEnabled = WaitlistEnabled;
            
        }
        


        /// <summary>
        /// The time off limit
        /// </summary>
        /// <value>The time off limit</value>
        [DataMember(Name="timeOffLimit", EmitDefaultValue=false)]
        public TimeOffLimitReference TimeOffLimit { get; set; }



        /// <summary>
        /// Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Start date of the requested date range. The end date is determined by the size of interval list. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public String StartDate { get; set; }





        /// <summary>
        /// The list of available time off values in minutes per granularity interval
        /// </summary>
        /// <value>The list of available time off values in minutes per granularity interval</value>
        [DataMember(Name="availableMinutesPerInterval", EmitDefaultValue=false)]
        public List<int?> AvailableMinutesPerInterval { get; set; }



        /// <summary>
        /// The current number of waitlisted time off requests for every interval per granularity
        /// </summary>
        /// <value>The current number of waitlisted time off requests for every interval per granularity</value>
        [DataMember(Name="waitlistedRequestsPerInterval", EmitDefaultValue=false)]
        public List<int?> WaitlistedRequestsPerInterval { get; set; }



        /// <summary>
        /// Whether the time off request can be waitlisted
        /// </summary>
        /// <value>Whether the time off request can be waitlisted</value>
        [DataMember(Name="waitlistEnabled", EmitDefaultValue=false)]
        public bool? WaitlistEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableTimeOffRange {\n");

            sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  AvailableMinutesPerInterval: ").Append(AvailableMinutesPerInterval).Append("\n");
            sb.Append("  WaitlistedRequestsPerInterval: ").Append(WaitlistedRequestsPerInterval).Append("\n");
            sb.Append("  WaitlistEnabled: ").Append(WaitlistEnabled).Append("\n");
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
            return this.Equals(obj as AvailableTimeOffRange);
        }

        /// <summary>
        /// Returns true if AvailableTimeOffRange instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableTimeOffRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableTimeOffRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeOffLimit == other.TimeOffLimit ||
                    this.TimeOffLimit != null &&
                    this.TimeOffLimit.Equals(other.TimeOffLimit)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.AvailableMinutesPerInterval == other.AvailableMinutesPerInterval ||
                    this.AvailableMinutesPerInterval != null &&
                    this.AvailableMinutesPerInterval.SequenceEqual(other.AvailableMinutesPerInterval)
                ) &&
                (
                    this.WaitlistedRequestsPerInterval == other.WaitlistedRequestsPerInterval ||
                    this.WaitlistedRequestsPerInterval != null &&
                    this.WaitlistedRequestsPerInterval.SequenceEqual(other.WaitlistedRequestsPerInterval)
                ) &&
                (
                    this.WaitlistEnabled == other.WaitlistEnabled ||
                    this.WaitlistEnabled != null &&
                    this.WaitlistEnabled.Equals(other.WaitlistEnabled)
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
                if (this.TimeOffLimit != null)
                    hash = hash * 59 + this.TimeOffLimit.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.AvailableMinutesPerInterval != null)
                    hash = hash * 59 + this.AvailableMinutesPerInterval.GetHashCode();

                if (this.WaitlistedRequestsPerInterval != null)
                    hash = hash * 59 + this.WaitlistedRequestsPerInterval.GetHashCode();

                if (this.WaitlistEnabled != null)
                    hash = hash * 59 + this.WaitlistEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
