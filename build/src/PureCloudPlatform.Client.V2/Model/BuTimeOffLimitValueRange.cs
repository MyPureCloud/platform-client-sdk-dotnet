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
    /// BuTimeOffLimitValueRange
    /// </summary>
    [DataContract]
    public partial class BuTimeOffLimitValueRange :  IEquatable<BuTimeOffLimitValueRange>
    {
        /// <summary>
        /// Granularity choice for time-off limit
        /// </summary>
        /// <value>Granularity choice for time-off limit</value>
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
            Daily,
            
            /// <summary>
            /// Enum Fifteenminutes for "FifteenMinutes"
            /// </summary>
            [EnumMember(Value = "FifteenMinutes")]
            Fifteenminutes
        }
        /// <summary>
        /// Granularity choice for time-off limit
        /// </summary>
        /// <value>Granularity choice for time-off limit</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public GranularityEnum? Granularity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuTimeOffLimitValueRange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuTimeOffLimitValueRange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuTimeOffLimitValueRange" /> class.
        /// </summary>
        /// <param name="TimeOffLimit">The ID of the time-off limit (required).</param>
        /// <param name="StartDate">Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists (required).</param>
        /// <param name="Granularity">Granularity choice for time-off limit (required).</param>
        /// <param name="LimitMinutesPerInterval">A list of time-off limit values in minutes per granularity interval (required).</param>
        /// <param name="AllocatedMinutesPerInterval">A list of allocated time-off minutes per granularity interval (required).</param>
        /// <param name="WaitlistedMinutesPerInterval">A list of waitlisted time-off minutes per granularity interval (required).</param>
        /// <param name="WaitlistedRequestsPerInterval">The current number of waitlisted time-off requests for every interval per granularity (required).</param>
        /// <param name="Metadata">Version metadata for the time-off limit (required).</param>
        public BuTimeOffLimitValueRange(BuTimeOffLimitReference TimeOffLimit = null, String StartDate = null, GranularityEnum? Granularity = null, List<int?> LimitMinutesPerInterval = null, List<int?> AllocatedMinutesPerInterval = null, List<int?> WaitlistedMinutesPerInterval = null, List<int?> WaitlistedRequestsPerInterval = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.TimeOffLimit = TimeOffLimit;
            this.StartDate = StartDate;
            this.Granularity = Granularity;
            this.LimitMinutesPerInterval = LimitMinutesPerInterval;
            this.AllocatedMinutesPerInterval = AllocatedMinutesPerInterval;
            this.WaitlistedMinutesPerInterval = WaitlistedMinutesPerInterval;
            this.WaitlistedRequestsPerInterval = WaitlistedRequestsPerInterval;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The ID of the time-off limit
        /// </summary>
        /// <value>The ID of the time-off limit</value>
        [DataMember(Name="timeOffLimit", EmitDefaultValue=false)]
        public BuTimeOffLimitReference TimeOffLimit { get; set; }



        /// <summary>
        /// Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists
        /// </summary>
        /// <value>Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public String StartDate { get; set; }





        /// <summary>
        /// A list of time-off limit values in minutes per granularity interval
        /// </summary>
        /// <value>A list of time-off limit values in minutes per granularity interval</value>
        [DataMember(Name="limitMinutesPerInterval", EmitDefaultValue=false)]
        public List<int?> LimitMinutesPerInterval { get; set; }



        /// <summary>
        /// A list of allocated time-off minutes per granularity interval
        /// </summary>
        /// <value>A list of allocated time-off minutes per granularity interval</value>
        [DataMember(Name="allocatedMinutesPerInterval", EmitDefaultValue=false)]
        public List<int?> AllocatedMinutesPerInterval { get; set; }



        /// <summary>
        /// A list of waitlisted time-off minutes per granularity interval
        /// </summary>
        /// <value>A list of waitlisted time-off minutes per granularity interval</value>
        [DataMember(Name="waitlistedMinutesPerInterval", EmitDefaultValue=false)]
        public List<int?> WaitlistedMinutesPerInterval { get; set; }



        /// <summary>
        /// The current number of waitlisted time-off requests for every interval per granularity
        /// </summary>
        /// <value>The current number of waitlisted time-off requests for every interval per granularity</value>
        [DataMember(Name="waitlistedRequestsPerInterval", EmitDefaultValue=false)]
        public List<int?> WaitlistedRequestsPerInterval { get; set; }



        /// <summary>
        /// Version metadata for the time-off limit
        /// </summary>
        /// <value>Version metadata for the time-off limit</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuTimeOffLimitValueRange {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TimeOffLimit: ").Append(TimeOffLimit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  LimitMinutesPerInterval: ").Append(LimitMinutesPerInterval).Append("\n");
            sb.Append("  AllocatedMinutesPerInterval: ").Append(AllocatedMinutesPerInterval).Append("\n");
            sb.Append("  WaitlistedMinutesPerInterval: ").Append(WaitlistedMinutesPerInterval).Append("\n");
            sb.Append("  WaitlistedRequestsPerInterval: ").Append(WaitlistedRequestsPerInterval).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as BuTimeOffLimitValueRange);
        }

        /// <summary>
        /// Returns true if BuTimeOffLimitValueRange instances are equal
        /// </summary>
        /// <param name="other">Instance of BuTimeOffLimitValueRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuTimeOffLimitValueRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
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
                    this.LimitMinutesPerInterval == other.LimitMinutesPerInterval ||
                    this.LimitMinutesPerInterval != null &&
                    this.LimitMinutesPerInterval.SequenceEqual(other.LimitMinutesPerInterval)
                ) &&
                (
                    this.AllocatedMinutesPerInterval == other.AllocatedMinutesPerInterval ||
                    this.AllocatedMinutesPerInterval != null &&
                    this.AllocatedMinutesPerInterval.SequenceEqual(other.AllocatedMinutesPerInterval)
                ) &&
                (
                    this.WaitlistedMinutesPerInterval == other.WaitlistedMinutesPerInterval ||
                    this.WaitlistedMinutesPerInterval != null &&
                    this.WaitlistedMinutesPerInterval.SequenceEqual(other.WaitlistedMinutesPerInterval)
                ) &&
                (
                    this.WaitlistedRequestsPerInterval == other.WaitlistedRequestsPerInterval ||
                    this.WaitlistedRequestsPerInterval != null &&
                    this.WaitlistedRequestsPerInterval.SequenceEqual(other.WaitlistedRequestsPerInterval)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.TimeOffLimit != null)
                    hash = hash * 59 + this.TimeOffLimit.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.LimitMinutesPerInterval != null)
                    hash = hash * 59 + this.LimitMinutesPerInterval.GetHashCode();

                if (this.AllocatedMinutesPerInterval != null)
                    hash = hash * 59 + this.AllocatedMinutesPerInterval.GetHashCode();

                if (this.WaitlistedMinutesPerInterval != null)
                    hash = hash * 59 + this.WaitlistedMinutesPerInterval.GetHashCode();

                if (this.WaitlistedRequestsPerInterval != null)
                    hash = hash * 59 + this.WaitlistedRequestsPerInterval.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
