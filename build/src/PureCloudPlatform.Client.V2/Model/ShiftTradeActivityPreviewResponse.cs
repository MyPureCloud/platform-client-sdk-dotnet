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
    /// ShiftTradeActivityPreviewResponse
    /// </summary>
    [DataContract]
    public partial class ShiftTradeActivityPreviewResponse :  IEquatable<ShiftTradeActivityPreviewResponse>
    {
        /// <summary>
        /// The type of the external activity associated with this activity, if applicable
        /// </summary>
        /// <value>The type of the external activity associated with this activity, if applicable</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExternalActivityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Activityplan for "ActivityPlan"
            /// </summary>
            [EnumMember(Value = "ActivityPlan")]
            Activityplan,
            
            /// <summary>
            /// Enum Coaching for "Coaching"
            /// </summary>
            [EnumMember(Value = "Coaching")]
            Coaching,
            
            /// <summary>
            /// Enum Learning for "Learning"
            /// </summary>
            [EnumMember(Value = "Learning")]
            Learning
        }
        /// <summary>
        /// The type of the external activity associated with this activity, if applicable
        /// </summary>
        /// <value>The type of the external activity associated with this activity, if applicable</value>
        [DataMember(Name="externalActivityType", EmitDefaultValue=false)]
        public ExternalActivityTypeEnum? ExternalActivityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeActivityPreviewResponse" /> class.
        /// </summary>
        /// <param name="StartDate">The start date and time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LengthMinutes">The length in minutes of this activity.</param>
        /// <param name="ActivityCodeId">The ID of the activity code for this activity.</param>
        /// <param name="CountsAsPaidTime">Whether this activity counts as paid time.</param>
        /// <param name="PayableMinutes">Payable minutes for this activity.</param>
        /// <param name="ExternalActivityType">The type of the external activity associated with this activity, if applicable.</param>
        /// <param name="ExternalActivityId">The ID of the external activity associated with this activity, if applicable.</param>
        public ShiftTradeActivityPreviewResponse(DateTime? StartDate = null, int? LengthMinutes = null, string ActivityCodeId = null, bool? CountsAsPaidTime = null, int? PayableMinutes = null, ExternalActivityTypeEnum? ExternalActivityType = null, string ExternalActivityId = null)
        {
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.ActivityCodeId = ActivityCodeId;
            this.CountsAsPaidTime = CountsAsPaidTime;
            this.PayableMinutes = PayableMinutes;
            this.ExternalActivityType = ExternalActivityType;
            this.ExternalActivityId = ExternalActivityId;
            
        }
        


        /// <summary>
        /// The start date and time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start date and time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The length in minutes of this activity
        /// </summary>
        /// <value>The length in minutes of this activity</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The ID of the activity code for this activity
        /// </summary>
        /// <value>The ID of the activity code for this activity</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Whether this activity counts as paid time
        /// </summary>
        /// <value>Whether this activity counts as paid time</value>
        [DataMember(Name="countsAsPaidTime", EmitDefaultValue=false)]
        public bool? CountsAsPaidTime { get; set; }



        /// <summary>
        /// Payable minutes for this activity
        /// </summary>
        /// <value>Payable minutes for this activity</value>
        [DataMember(Name="payableMinutes", EmitDefaultValue=false)]
        public int? PayableMinutes { get; set; }





        /// <summary>
        /// The ID of the external activity associated with this activity, if applicable
        /// </summary>
        /// <value>The ID of the external activity associated with this activity, if applicable</value>
        [DataMember(Name="externalActivityId", EmitDefaultValue=false)]
        public string ExternalActivityId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeActivityPreviewResponse {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
            sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
            sb.Append("  ExternalActivityType: ").Append(ExternalActivityType).Append("\n");
            sb.Append("  ExternalActivityId: ").Append(ExternalActivityId).Append("\n");
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
            return this.Equals(obj as ShiftTradeActivityPreviewResponse);
        }

        /// <summary>
        /// Returns true if ShiftTradeActivityPreviewResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeActivityPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeActivityPreviewResponse other)
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
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.CountsAsPaidTime == other.CountsAsPaidTime ||
                    this.CountsAsPaidTime != null &&
                    this.CountsAsPaidTime.Equals(other.CountsAsPaidTime)
                ) &&
                (
                    this.PayableMinutes == other.PayableMinutes ||
                    this.PayableMinutes != null &&
                    this.PayableMinutes.Equals(other.PayableMinutes)
                ) &&
                (
                    this.ExternalActivityType == other.ExternalActivityType ||
                    this.ExternalActivityType != null &&
                    this.ExternalActivityType.Equals(other.ExternalActivityType)
                ) &&
                (
                    this.ExternalActivityId == other.ExternalActivityId ||
                    this.ExternalActivityId != null &&
                    this.ExternalActivityId.Equals(other.ExternalActivityId)
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

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.CountsAsPaidTime != null)
                    hash = hash * 59 + this.CountsAsPaidTime.GetHashCode();

                if (this.PayableMinutes != null)
                    hash = hash * 59 + this.PayableMinutes.GetHashCode();

                if (this.ExternalActivityType != null)
                    hash = hash * 59 + this.ExternalActivityType.GetHashCode();

                if (this.ExternalActivityId != null)
                    hash = hash * 59 + this.ExternalActivityId.GetHashCode();

                return hash;
            }
        }
    }

}
