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
    /// ScheduleReferenceWithBusinessUnit
    /// </summary>
    [DataContract]
    public partial class ScheduleReferenceWithBusinessUnit :  IEquatable<ScheduleReferenceWithBusinessUnit>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleReferenceWithBusinessUnit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleReferenceWithBusinessUnit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleReferenceWithBusinessUnit" /> class.
        /// </summary>
        /// <param name="Id">The unique identifier of the schedule (required).</param>
        /// <param name="WeekDate">The start date for this schedule in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="BusinessUnit">The reference of the associated business unit (required).</param>
        public ScheduleReferenceWithBusinessUnit(string Id = null, String WeekDate = null, BusinessUnitReference BusinessUnit = null)
        {
            this.Id = Id;
            this.WeekDate = WeekDate;
            this.BusinessUnit = BusinessUnit;
            
        }
        


        /// <summary>
        /// The unique identifier of the schedule
        /// </summary>
        /// <value>The unique identifier of the schedule</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The start date for this schedule in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start date for this schedule in the business unit time zone (yyyy-MM-dd format). Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }



        /// <summary>
        /// The reference of the associated business unit
        /// </summary>
        /// <value>The reference of the associated business unit</value>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public BusinessUnitReference BusinessUnit { get; set; }



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
            sb.Append("class ScheduleReferenceWithBusinessUnit {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
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
            return this.Equals(obj as ScheduleReferenceWithBusinessUnit);
        }

        /// <summary>
        /// Returns true if ScheduleReferenceWithBusinessUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleReferenceWithBusinessUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleReferenceWithBusinessUnit other)
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
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
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

                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
