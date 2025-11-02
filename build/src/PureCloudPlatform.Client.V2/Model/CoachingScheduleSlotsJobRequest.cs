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
    /// CoachingScheduleSlotsJobRequest
    /// </summary>
    [DataContract]
    public partial class CoachingScheduleSlotsJobRequest :  IEquatable<CoachingScheduleSlotsJobRequest>
    {
        /// <summary>
        /// The type of slots to fetch in the job.
        /// </summary>
        /// <value>The type of slots to fetch in the job.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SlotsTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Besttime for "BestTime"
            /// </summary>
            [EnumMember(Value = "BestTime")]
            Besttime
        }
        /// <summary>
        /// The type of slots to fetch in the job.
        /// </summary>
        /// <value>The type of slots to fetch in the job.</value>
        [DataMember(Name="slotsType", EmitDefaultValue=false)]
        public SlotsTypeEnum? SlotsType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingScheduleSlotsJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoachingScheduleSlotsJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingScheduleSlotsJobRequest" /> class.
        /// </summary>
        /// <param name="AttendeeIds">The attendee IDs to fetch the slots for. (required).</param>
        /// <param name="FacilitatorIds">The facilitator IDs to fetch the slots for..</param>
        /// <param name="LengthInMinutes">The length in minutes of the slots, in 15 minutes granularity. (required).</param>
        /// <param name="ActivityCodeId">The Activity Code Id of the slots. (required).</param>
        /// <param name="Intervals">The intervals to fetch the slots for. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="SlotsType">The type of slots to fetch in the job. (required).</param>
        public CoachingScheduleSlotsJobRequest(List<string> AttendeeIds = null, List<string> FacilitatorIds = null, int? LengthInMinutes = null, string ActivityCodeId = null, List<string> Intervals = null, SlotsTypeEnum? SlotsType = null)
        {
            this.AttendeeIds = AttendeeIds;
            this.FacilitatorIds = FacilitatorIds;
            this.LengthInMinutes = LengthInMinutes;
            this.ActivityCodeId = ActivityCodeId;
            this.Intervals = Intervals;
            this.SlotsType = SlotsType;
            
        }
        


        /// <summary>
        /// The attendee IDs to fetch the slots for.
        /// </summary>
        /// <value>The attendee IDs to fetch the slots for.</value>
        [DataMember(Name="attendeeIds", EmitDefaultValue=false)]
        public List<string> AttendeeIds { get; set; }



        /// <summary>
        /// The facilitator IDs to fetch the slots for.
        /// </summary>
        /// <value>The facilitator IDs to fetch the slots for.</value>
        [DataMember(Name="facilitatorIds", EmitDefaultValue=false)]
        public List<string> FacilitatorIds { get; set; }



        /// <summary>
        /// The length in minutes of the slots, in 15 minutes granularity.
        /// </summary>
        /// <value>The length in minutes of the slots, in 15 minutes granularity.</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }



        /// <summary>
        /// The Activity Code Id of the slots.
        /// </summary>
        /// <value>The Activity Code Id of the slots.</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// The intervals to fetch the slots for. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The intervals to fetch the slots for. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<string> Intervals { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoachingScheduleSlotsJobRequest {\n");

            sb.Append("  AttendeeIds: ").Append(AttendeeIds).Append("\n");
            sb.Append("  FacilitatorIds: ").Append(FacilitatorIds).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            sb.Append("  SlotsType: ").Append(SlotsType).Append("\n");
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
            return this.Equals(obj as CoachingScheduleSlotsJobRequest);
        }

        /// <summary>
        /// Returns true if CoachingScheduleSlotsJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CoachingScheduleSlotsJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoachingScheduleSlotsJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AttendeeIds == other.AttendeeIds ||
                    this.AttendeeIds != null &&
                    this.AttendeeIds.SequenceEqual(other.AttendeeIds)
                ) &&
                (
                    this.FacilitatorIds == other.FacilitatorIds ||
                    this.FacilitatorIds != null &&
                    this.FacilitatorIds.SequenceEqual(other.FacilitatorIds)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Intervals == other.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(other.Intervals)
                ) &&
                (
                    this.SlotsType == other.SlotsType ||
                    this.SlotsType != null &&
                    this.SlotsType.Equals(other.SlotsType)
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
                if (this.AttendeeIds != null)
                    hash = hash * 59 + this.AttendeeIds.GetHashCode();

                if (this.FacilitatorIds != null)
                    hash = hash * 59 + this.FacilitatorIds.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.Intervals != null)
                    hash = hash * 59 + this.Intervals.GetHashCode();

                if (this.SlotsType != null)
                    hash = hash * 59 + this.SlotsType.GetHashCode();

                return hash;
            }
        }
    }

}
