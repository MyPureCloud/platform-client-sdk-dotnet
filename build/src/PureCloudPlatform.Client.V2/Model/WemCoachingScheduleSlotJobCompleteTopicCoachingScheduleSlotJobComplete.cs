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
    /// WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete
    /// </summary>
    [DataContract]
    public partial class WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete :  IEquatable<WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete>
    {
        /// <summary>
        /// Gets or Sets SlotsType
        /// </summary>
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
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Besttime for "BestTime"
            /// </summary>
            [EnumMember(Value = "BestTime")]
            Besttime
        }
        /// <summary>
        /// Gets or Sets SlotsType
        /// </summary>
        [DataMember(Name="slotsType", EmitDefaultValue=false)]
        public SlotsTypeEnum? SlotsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="AttendeeIds">AttendeeIds.</param>
        /// <param name="FacilitatorIds">FacilitatorIds.</param>
        /// <param name="LengthInMinutes">LengthInMinutes.</param>
        /// <param name="BusinessUnitId">BusinessUnitId.</param>
        /// <param name="ActivityCodeId">ActivityCodeId.</param>
        /// <param name="SlotsType">SlotsType.</param>
        /// <param name="Results">Results.</param>
        public WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete(string Id = null, List<string> AttendeeIds = null, List<string> FacilitatorIds = null, long? LengthInMinutes = null, string BusinessUnitId = null, string ActivityCodeId = null, SlotsTypeEnum? SlotsType = null, List<WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults> Results = null)
        {
            this.Id = Id;
            this.AttendeeIds = AttendeeIds;
            this.FacilitatorIds = FacilitatorIds;
            this.LengthInMinutes = LengthInMinutes;
            this.BusinessUnitId = BusinessUnitId;
            this.ActivityCodeId = ActivityCodeId;
            this.SlotsType = SlotsType;
            this.Results = Results;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets AttendeeIds
        /// </summary>
        [DataMember(Name="attendeeIds", EmitDefaultValue=false)]
        public List<string> AttendeeIds { get; set; }



        /// <summary>
        /// Gets or Sets FacilitatorIds
        /// </summary>
        [DataMember(Name="facilitatorIds", EmitDefaultValue=false)]
        public List<string> FacilitatorIds { get; set; }



        /// <summary>
        /// Gets or Sets LengthInMinutes
        /// </summary>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public long? LengthInMinutes { get; set; }



        /// <summary>
        /// Gets or Sets BusinessUnitId
        /// </summary>
        [DataMember(Name="businessUnitId", EmitDefaultValue=false)]
        public string BusinessUnitId { get; set; }



        /// <summary>
        /// Gets or Sets ActivityCodeId
        /// </summary>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }





        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobResults> Results { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttendeeIds: ").Append(AttendeeIds).Append("\n");
            sb.Append("  FacilitatorIds: ").Append(FacilitatorIds).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  SlotsType: ").Append(SlotsType).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete);
        }

        /// <summary>
        /// Returns true if WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete instances are equal
        /// </summary>
        /// <param name="other">Instance of WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WemCoachingScheduleSlotJobCompleteTopicCoachingScheduleSlotJobComplete other)
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
                    this.BusinessUnitId == other.BusinessUnitId ||
                    this.BusinessUnitId != null &&
                    this.BusinessUnitId.Equals(other.BusinessUnitId)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.SlotsType == other.SlotsType ||
                    this.SlotsType != null &&
                    this.SlotsType.Equals(other.SlotsType)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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

                if (this.AttendeeIds != null)
                    hash = hash * 59 + this.AttendeeIds.GetHashCode();

                if (this.FacilitatorIds != null)
                    hash = hash * 59 + this.FacilitatorIds.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                if (this.BusinessUnitId != null)
                    hash = hash * 59 + this.BusinessUnitId.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.SlotsType != null)
                    hash = hash * 59 + this.SlotsType.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                return hash;
            }
        }
    }

}
