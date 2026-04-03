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
    /// ShiftTradeShiftResponseItem
    /// </summary>
    [DataContract]
    public partial class ShiftTradeShiftResponseItem :  IEquatable<ShiftTradeShiftResponseItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeShiftResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftTradeShiftResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeShiftResponseItem" /> class.
        /// </summary>
        /// <param name="Id">The ID of the shift (required).</param>
        /// <param name="StartDate">The start date/time for the shift in ISO-8601 format (required).</param>
        /// <param name="EndDate">The end date/time for the shift in ISO-8601 format (required).</param>
        /// <param name="WeekDate">The start week date of the user shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        public ShiftTradeShiftResponseItem(string Id = null, DateTime? StartDate = null, DateTime? EndDate = null, String WeekDate = null)
        {
            this.Id = Id;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.WeekDate = WeekDate;
            
        }
        


        /// <summary>
        /// The ID of the shift
        /// </summary>
        /// <value>The ID of the shift</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The start date/time for the shift in ISO-8601 format
        /// </summary>
        /// <value>The start date/time for the shift in ISO-8601 format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }



        /// <summary>
        /// The end date/time for the shift in ISO-8601 format
        /// </summary>
        /// <value>The end date/time for the shift in ISO-8601 format</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }



        /// <summary>
        /// The start week date of the user shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start week date of the user shift in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeShiftResponseItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
            return this.Equals(obj as ShiftTradeShiftResponseItem);
        }

        /// <summary>
        /// Returns true if ShiftTradeShiftResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeShiftResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeShiftResponseItem other)
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
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
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

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();

                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                return hash;
            }
        }
    }

}
