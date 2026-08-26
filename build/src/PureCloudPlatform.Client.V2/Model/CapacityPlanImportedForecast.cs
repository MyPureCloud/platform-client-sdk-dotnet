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
    /// CapacityPlanImportedForecast
    /// </summary>
    [DataContract]
    public partial class CapacityPlanImportedForecast :  IEquatable<CapacityPlanImportedForecast>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanImportedForecast" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapacityPlanImportedForecast() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapacityPlanImportedForecast" /> class.
        /// </summary>
        /// <param name="WeekDate">The week date of the imported forecast, relative to the business unit time zone, in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="WeekCount">The number of weeks in the imported forecast (required).</param>
        public CapacityPlanImportedForecast(String WeekDate = null, int? WeekCount = null)
        {
            this.WeekDate = WeekDate;
            this.WeekCount = WeekCount;
            
        }
        


        /// <summary>
        /// The week date of the imported forecast, relative to the business unit time zone, in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The week date of the imported forecast, relative to the business unit time zone, in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="weekDate", EmitDefaultValue=false)]
        public String WeekDate { get; set; }



        /// <summary>
        /// The number of weeks in the imported forecast
        /// </summary>
        /// <value>The number of weeks in the imported forecast</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityPlanImportedForecast {\n");

            sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
            return this.Equals(obj as CapacityPlanImportedForecast);
        }

        /// <summary>
        /// Returns true if CapacityPlanImportedForecast instances are equal
        /// </summary>
        /// <param name="other">Instance of CapacityPlanImportedForecast to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapacityPlanImportedForecast other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WeekDate == other.WeekDate ||
                    this.WeekDate != null &&
                    this.WeekDate.Equals(other.WeekDate)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
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
                if (this.WeekDate != null)
                    hash = hash * 59 + this.WeekDate.GetHashCode();

                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();

                return hash;
            }
        }
    }

}
