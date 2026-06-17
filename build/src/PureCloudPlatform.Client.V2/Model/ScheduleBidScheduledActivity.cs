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
    /// ScheduleBidScheduledActivity
    /// </summary>
    [DataContract]
    public partial class ScheduleBidScheduledActivity :  IEquatable<ScheduleBidScheduledActivity>
    {
        /// <summary>
        /// The activity code's category
        /// </summary>
        /// <value>The activity code's category</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActivityCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable
        }
        /// <summary>
        /// The activity code's category
        /// </summary>
        /// <value>The activity code's category</value>
        [DataMember(Name="activityCategory", EmitDefaultValue=false)]
        public ActivityCategoryEnum? ActivityCategory { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidScheduledActivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleBidScheduledActivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleBidScheduledActivity" /> class.
        /// </summary>
        /// <param name="StartDate">The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="LengthMinutes">The length of this activity in minutes (required).</param>
        /// <param name="Description">The description of this activity (required).</param>
        /// <param name="ActivityCategory">The activity code&#39;s category (required).</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with this activity (required).</param>
        /// <param name="Paid">Whether this activity is paid.</param>
        public ScheduleBidScheduledActivity(DateTime? StartDate = null, int? LengthMinutes = null, string Description = null, ActivityCategoryEnum? ActivityCategory = null, string ActivityCodeId = null, bool? Paid = null)
        {
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.Description = Description;
            this.ActivityCategory = ActivityCategory;
            this.ActivityCodeId = ActivityCodeId;
            this.Paid = Paid;
            
        }
        


        /// <summary>
        /// The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The length of this activity in minutes
        /// </summary>
        /// <value>The length of this activity in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The description of this activity
        /// </summary>
        /// <value>The description of this activity</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// The ID of the activity code associated with this activity
        /// </summary>
        /// <value>The ID of the activity code associated with this activity</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Whether this activity is paid
        /// </summary>
        /// <value>Whether this activity is paid</value>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleBidScheduledActivity {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
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
            return this.Equals(obj as ScheduleBidScheduledActivity);
        }

        /// <summary>
        /// Returns true if ScheduleBidScheduledActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleBidScheduledActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleBidScheduledActivity other)
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
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ActivityCategory == other.ActivityCategory ||
                    this.ActivityCategory != null &&
                    this.ActivityCategory.Equals(other.ActivityCategory)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
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

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ActivityCategory != null)
                    hash = hash * 59 + this.ActivityCategory.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();

                return hash;
            }
        }
    }

}
