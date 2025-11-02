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
    /// CoachingScheduleSlotsJobResponse
    /// </summary>
    [DataContract]
    public partial class CoachingScheduleSlotsJobResponse :  IEquatable<CoachingScheduleSlotsJobResponse>
    {
        /// <summary>
        /// The type of slots fetched in the job.
        /// </summary>
        /// <value>The type of slots fetched in the job.</value>
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
        /// The type of slots fetched in the job.
        /// </summary>
        /// <value>The type of slots fetched in the job.</value>
        [DataMember(Name="slotsType", EmitDefaultValue=false)]
        public SlotsTypeEnum? SlotsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingScheduleSlotsJobResponse" /> class.
        /// </summary>
        /// <param name="AttendeeIds">The attendee IDs to fetch the slots for..</param>
        /// <param name="FacilitatorIds">The facilitator IDs to fetch the slots for..</param>
        /// <param name="LengthInMinutes">The length in minutes of the slots..</param>
        /// <param name="BusinessUnitId">The Business Unit Id of the users..</param>
        /// <param name="ActivityCodeId">The Activity Code Id of the slots..</param>
        /// <param name="Results">The results of the job..</param>
        /// <param name="SlotsType">The type of slots fetched in the job..</param>
        public CoachingScheduleSlotsJobResponse(List<string> AttendeeIds = null, List<string> FacilitatorIds = null, int? LengthInMinutes = null, string BusinessUnitId = null, string ActivityCodeId = null, List<CoachingScheduleSlotsJobResult> Results = null, SlotsTypeEnum? SlotsType = null)
        {
            this.AttendeeIds = AttendeeIds;
            this.FacilitatorIds = FacilitatorIds;
            this.LengthInMinutes = LengthInMinutes;
            this.BusinessUnitId = BusinessUnitId;
            this.ActivityCodeId = ActivityCodeId;
            this.Results = Results;
            this.SlotsType = SlotsType;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



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
        /// The length in minutes of the slots.
        /// </summary>
        /// <value>The length in minutes of the slots.</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }



        /// <summary>
        /// The Business Unit Id of the users.
        /// </summary>
        /// <value>The Business Unit Id of the users.</value>
        [DataMember(Name="businessUnitId", EmitDefaultValue=false)]
        public string BusinessUnitId { get; set; }



        /// <summary>
        /// The Activity Code Id of the slots.
        /// </summary>
        /// <value>The Activity Code Id of the slots.</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// The results of the job.
        /// </summary>
        /// <value>The results of the job.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<CoachingScheduleSlotsJobResult> Results { get; set; }





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
            sb.Append("class CoachingScheduleSlotsJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttendeeIds: ").Append(AttendeeIds).Append("\n");
            sb.Append("  FacilitatorIds: ").Append(FacilitatorIds).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  BusinessUnitId: ").Append(BusinessUnitId).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  SlotsType: ").Append(SlotsType).Append("\n");
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
            return this.Equals(obj as CoachingScheduleSlotsJobResponse);
        }

        /// <summary>
        /// Returns true if CoachingScheduleSlotsJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CoachingScheduleSlotsJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoachingScheduleSlotsJobResponse other)
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
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) &&
                (
                    this.SlotsType == other.SlotsType ||
                    this.SlotsType != null &&
                    this.SlotsType.Equals(other.SlotsType)
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

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.SlotsType != null)
                    hash = hash * 59 + this.SlotsType.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
