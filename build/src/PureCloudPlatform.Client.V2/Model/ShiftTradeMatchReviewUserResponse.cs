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
    /// ShiftTradeMatchReviewUserResponse
    /// </summary>
    [DataContract]
    public partial class ShiftTradeMatchReviewUserResponse :  IEquatable<ShiftTradeMatchReviewUserResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeMatchReviewUserResponse" /> class.
        /// </summary>
        /// <param name="WeeklyMinimumPaidMinutes">The minimum weekly paid minutes for this user per the work plan tied to the agent schedule.</param>
        /// <param name="WeeklyMaximumPaidMinutes">The maximum weekly paid minutes for this user per the work plan tied to the agent schedule.</param>
        /// <param name="PreTradeSchedulePaidMinutes">The paid minutes on the week schedule for this user prior to the shift trade.</param>
        /// <param name="PostTradeSchedulePaidMinutes">The paid minutes on the week schedule for this user if the shift trade is approved.</param>
        /// <param name="PostTradeNewShift">Preview of what the shift will look like for the opposite side of this trade after the match is approved.</param>
        public ShiftTradeMatchReviewUserResponse(int? WeeklyMinimumPaidMinutes = null, int? WeeklyMaximumPaidMinutes = null, int? PreTradeSchedulePaidMinutes = null, int? PostTradeSchedulePaidMinutes = null, ShiftTradePreviewResponse PostTradeNewShift = null)
        {
            this.WeeklyMinimumPaidMinutes = WeeklyMinimumPaidMinutes;
            this.WeeklyMaximumPaidMinutes = WeeklyMaximumPaidMinutes;
            this.PreTradeSchedulePaidMinutes = PreTradeSchedulePaidMinutes;
            this.PostTradeSchedulePaidMinutes = PostTradeSchedulePaidMinutes;
            this.PostTradeNewShift = PostTradeNewShift;
            
        }
        


        /// <summary>
        /// The minimum weekly paid minutes for this user per the work plan tied to the agent schedule
        /// </summary>
        /// <value>The minimum weekly paid minutes for this user per the work plan tied to the agent schedule</value>
        [DataMember(Name="weeklyMinimumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMinimumPaidMinutes { get; set; }



        /// <summary>
        /// The maximum weekly paid minutes for this user per the work plan tied to the agent schedule
        /// </summary>
        /// <value>The maximum weekly paid minutes for this user per the work plan tied to the agent schedule</value>
        [DataMember(Name="weeklyMaximumPaidMinutes", EmitDefaultValue=false)]
        public int? WeeklyMaximumPaidMinutes { get; set; }



        /// <summary>
        /// The paid minutes on the week schedule for this user prior to the shift trade
        /// </summary>
        /// <value>The paid minutes on the week schedule for this user prior to the shift trade</value>
        [DataMember(Name="preTradeSchedulePaidMinutes", EmitDefaultValue=false)]
        public int? PreTradeSchedulePaidMinutes { get; set; }



        /// <summary>
        /// The paid minutes on the week schedule for this user if the shift trade is approved
        /// </summary>
        /// <value>The paid minutes on the week schedule for this user if the shift trade is approved</value>
        [DataMember(Name="postTradeSchedulePaidMinutes", EmitDefaultValue=false)]
        public int? PostTradeSchedulePaidMinutes { get; set; }



        /// <summary>
        /// Preview of what the shift will look like for the opposite side of this trade after the match is approved
        /// </summary>
        /// <value>Preview of what the shift will look like for the opposite side of this trade after the match is approved</value>
        [DataMember(Name="postTradeNewShift", EmitDefaultValue=false)]
        public ShiftTradePreviewResponse PostTradeNewShift { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeMatchReviewUserResponse {\n");

            sb.Append("  WeeklyMinimumPaidMinutes: ").Append(WeeklyMinimumPaidMinutes).Append("\n");
            sb.Append("  WeeklyMaximumPaidMinutes: ").Append(WeeklyMaximumPaidMinutes).Append("\n");
            sb.Append("  PreTradeSchedulePaidMinutes: ").Append(PreTradeSchedulePaidMinutes).Append("\n");
            sb.Append("  PostTradeSchedulePaidMinutes: ").Append(PostTradeSchedulePaidMinutes).Append("\n");
            sb.Append("  PostTradeNewShift: ").Append(PostTradeNewShift).Append("\n");
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
            return this.Equals(obj as ShiftTradeMatchReviewUserResponse);
        }

        /// <summary>
        /// Returns true if ShiftTradeMatchReviewUserResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeMatchReviewUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeMatchReviewUserResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeeklyMinimumPaidMinutes == other.WeeklyMinimumPaidMinutes ||
                    this.WeeklyMinimumPaidMinutes != null &&
                    this.WeeklyMinimumPaidMinutes.Equals(other.WeeklyMinimumPaidMinutes)
                ) &&
                (
                    this.WeeklyMaximumPaidMinutes == other.WeeklyMaximumPaidMinutes ||
                    this.WeeklyMaximumPaidMinutes != null &&
                    this.WeeklyMaximumPaidMinutes.Equals(other.WeeklyMaximumPaidMinutes)
                ) &&
                (
                    this.PreTradeSchedulePaidMinutes == other.PreTradeSchedulePaidMinutes ||
                    this.PreTradeSchedulePaidMinutes != null &&
                    this.PreTradeSchedulePaidMinutes.Equals(other.PreTradeSchedulePaidMinutes)
                ) &&
                (
                    this.PostTradeSchedulePaidMinutes == other.PostTradeSchedulePaidMinutes ||
                    this.PostTradeSchedulePaidMinutes != null &&
                    this.PostTradeSchedulePaidMinutes.Equals(other.PostTradeSchedulePaidMinutes)
                ) &&
                (
                    this.PostTradeNewShift == other.PostTradeNewShift ||
                    this.PostTradeNewShift != null &&
                    this.PostTradeNewShift.Equals(other.PostTradeNewShift)
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
                if (this.WeeklyMinimumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMinimumPaidMinutes.GetHashCode();

                if (this.WeeklyMaximumPaidMinutes != null)
                    hash = hash * 59 + this.WeeklyMaximumPaidMinutes.GetHashCode();

                if (this.PreTradeSchedulePaidMinutes != null)
                    hash = hash * 59 + this.PreTradeSchedulePaidMinutes.GetHashCode();

                if (this.PostTradeSchedulePaidMinutes != null)
                    hash = hash * 59 + this.PostTradeSchedulePaidMinutes.GetHashCode();

                if (this.PostTradeNewShift != null)
                    hash = hash * 59 + this.PostTradeNewShift.GetHashCode();

                return hash;
            }
        }
    }

}
