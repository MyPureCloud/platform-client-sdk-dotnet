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
    /// EstimateAvailableTimeOffResponse
    /// </summary>
    [DataContract]
    public partial class EstimateAvailableTimeOffResponse :  IEquatable<EstimateAvailableTimeOffResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailableTimeOffResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimateAvailableTimeOffResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateAvailableTimeOffResponse" /> class.
        /// </summary>
        /// <param name="FullDayDates">Full day dates. partialDayDates must be empty if this field is populated.</param>
        /// <param name="PartialDayDates">Partial day dates. fullDayDates must be empty if this field is populated.</param>
        /// <param name="User">The user to whom the time off request belongs (required).</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category (required).</param>
        /// <param name="Paid">Whether this estimate is for a paid time off request (required).</param>
        public EstimateAvailableTimeOffResponse(List<EstimateAvailableFullDayTimeOffResponse> FullDayDates = null, List<EstimateAvailablePartialDayTimeOffResponse> PartialDayDates = null, UserReference User = null, string ActivityCodeId = null, bool? Paid = null)
        {
            this.FullDayDates = FullDayDates;
            this.PartialDayDates = PartialDayDates;
            this.User = User;
            this.ActivityCodeId = ActivityCodeId;
            this.Paid = Paid;
            
        }
        


        /// <summary>
        /// Full day dates. partialDayDates must be empty if this field is populated
        /// </summary>
        /// <value>Full day dates. partialDayDates must be empty if this field is populated</value>
        [DataMember(Name="fullDayDates", EmitDefaultValue=false)]
        public List<EstimateAvailableFullDayTimeOffResponse> FullDayDates { get; set; }



        /// <summary>
        /// Partial day dates. fullDayDates must be empty if this field is populated
        /// </summary>
        /// <value>Partial day dates. fullDayDates must be empty if this field is populated</value>
        [DataMember(Name="partialDayDates", EmitDefaultValue=false)]
        public List<EstimateAvailablePartialDayTimeOffResponse> PartialDayDates { get; set; }



        /// <summary>
        /// The user to whom the time off request belongs
        /// </summary>
        /// <value>The user to whom the time off request belongs</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category
        /// </summary>
        /// <value>The ID of the activity code associated with the time off request. Activity code must be of the TimeOff category</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Whether this estimate is for a paid time off request
        /// </summary>
        /// <value>Whether this estimate is for a paid time off request</value>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateAvailableTimeOffResponse {\n");

            sb.Append("  FullDayDates: ").Append(FullDayDates).Append("\n");
            sb.Append("  PartialDayDates: ").Append(PartialDayDates).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as EstimateAvailableTimeOffResponse);
        }

        /// <summary>
        /// Returns true if EstimateAvailableTimeOffResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EstimateAvailableTimeOffResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateAvailableTimeOffResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FullDayDates == other.FullDayDates ||
                    this.FullDayDates != null &&
                    this.FullDayDates.SequenceEqual(other.FullDayDates)
                ) &&
                (
                    this.PartialDayDates == other.PartialDayDates ||
                    this.PartialDayDates != null &&
                    this.PartialDayDates.SequenceEqual(other.PartialDayDates)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.FullDayDates != null)
                    hash = hash * 59 + this.FullDayDates.GetHashCode();

                if (this.PartialDayDates != null)
                    hash = hash * 59 + this.PartialDayDates.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();

                return hash;
            }
        }
    }

}
