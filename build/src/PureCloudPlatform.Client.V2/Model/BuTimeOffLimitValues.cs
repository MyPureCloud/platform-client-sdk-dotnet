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
    /// BuTimeOffLimitValues
    /// </summary>
    [DataContract]
    public partial class BuTimeOffLimitValues :  IEquatable<BuTimeOffLimitValues>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuTimeOffLimitValues" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuTimeOffLimitValues() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuTimeOffLimitValues" /> class.
        /// </summary>
        /// <param name="StartDate">Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists (required).</param>
        /// <param name="ValuesPerDay">Time-off limit values specified in per day granularity. Set only if granularity is &#39;Daily&#39;.</param>
        /// <param name="ValuesPerFifteenMinutes">Time-off limit values specified in per fifteen minutes granularity. Set only if granularity is &#39;FifteenMinutes&#39;.</param>
        public BuTimeOffLimitValues(String StartDate = null, TimeOffLimitValues ValuesPerDay = null, TimeOffLimitValues ValuesPerFifteenMinutes = null)
        {
            this.StartDate = StartDate;
            this.ValuesPerDay = ValuesPerDay;
            this.ValuesPerFifteenMinutes = ValuesPerFifteenMinutes;
            
        }
        


        /// <summary>
        /// Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists
        /// </summary>
        /// <value>Start date of the requested date range, in ISO-8601 format. The end date is determined by the size of interval lists</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public String StartDate { get; set; }



        /// <summary>
        /// Time-off limit values specified in per day granularity. Set only if granularity is &#39;Daily&#39;
        /// </summary>
        /// <value>Time-off limit values specified in per day granularity. Set only if granularity is &#39;Daily&#39;</value>
        [DataMember(Name="valuesPerDay", EmitDefaultValue=false)]
        public TimeOffLimitValues ValuesPerDay { get; set; }



        /// <summary>
        /// Time-off limit values specified in per fifteen minutes granularity. Set only if granularity is &#39;FifteenMinutes&#39;
        /// </summary>
        /// <value>Time-off limit values specified in per fifteen minutes granularity. Set only if granularity is &#39;FifteenMinutes&#39;</value>
        [DataMember(Name="valuesPerFifteenMinutes", EmitDefaultValue=false)]
        public TimeOffLimitValues ValuesPerFifteenMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuTimeOffLimitValues {\n");

            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ValuesPerDay: ").Append(ValuesPerDay).Append("\n");
            sb.Append("  ValuesPerFifteenMinutes: ").Append(ValuesPerFifteenMinutes).Append("\n");
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
            return this.Equals(obj as BuTimeOffLimitValues);
        }

        /// <summary>
        /// Returns true if BuTimeOffLimitValues instances are equal
        /// </summary>
        /// <param name="other">Instance of BuTimeOffLimitValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuTimeOffLimitValues other)
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
                    this.ValuesPerDay == other.ValuesPerDay ||
                    this.ValuesPerDay != null &&
                    this.ValuesPerDay.Equals(other.ValuesPerDay)
                ) &&
                (
                    this.ValuesPerFifteenMinutes == other.ValuesPerFifteenMinutes ||
                    this.ValuesPerFifteenMinutes != null &&
                    this.ValuesPerFifteenMinutes.Equals(other.ValuesPerFifteenMinutes)
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

                if (this.ValuesPerDay != null)
                    hash = hash * 59 + this.ValuesPerDay.GetHashCode();

                if (this.ValuesPerFifteenMinutes != null)
                    hash = hash * 59 + this.ValuesPerFifteenMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
