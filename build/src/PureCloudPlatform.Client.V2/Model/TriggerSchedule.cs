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
    /// Schedule configuration for a scheduled trigger
    /// </summary>
    [DataContract]
    public partial class TriggerSchedule :  IEquatable<TriggerSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSchedule" /> class.
        /// </summary>
        /// <param name="Minutes">Minutes on which the trigger should fire. Coma separated list of up to 2 values 0-59.</param>
        /// <param name="Hours">Hours on which the trigger should fire. 0-23 or &#39;*&#39; for every hour..</param>
        /// <param name="DaysOfMonth">Days of month on which the trigger should fire. 1-31 or &#39;*&#39; for every or &#39;?&#39; for any.</param>
        /// <param name="Months">Months on which the trigger should fire. 1-12 or &#39;*&#39; for every.</param>
        /// <param name="DaysOfWeek">Days of week on which the trigger should fire. 1-7 or &#39;*&#39; for every or &#39;?&#39; for any.</param>
        /// <param name="Timezone">Timezone for the trigger schedule.</param>
        public TriggerSchedule(string Minutes = null, string Hours = null, string DaysOfMonth = null, string Months = null, string DaysOfWeek = null, string Timezone = null)
        {
            this.Minutes = Minutes;
            this.Hours = Hours;
            this.DaysOfMonth = DaysOfMonth;
            this.Months = Months;
            this.DaysOfWeek = DaysOfWeek;
            this.Timezone = Timezone;
            
        }
        


        /// <summary>
        /// Minutes on which the trigger should fire. Coma separated list of up to 2 values 0-59
        /// </summary>
        /// <value>Minutes on which the trigger should fire. Coma separated list of up to 2 values 0-59</value>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public string Minutes { get; set; }



        /// <summary>
        /// Hours on which the trigger should fire. 0-23 or &#39;*&#39; for every hour.
        /// </summary>
        /// <value>Hours on which the trigger should fire. 0-23 or &#39;*&#39; for every hour.</value>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public string Hours { get; set; }



        /// <summary>
        /// Days of month on which the trigger should fire. 1-31 or &#39;*&#39; for every or &#39;?&#39; for any
        /// </summary>
        /// <value>Days of month on which the trigger should fire. 1-31 or &#39;*&#39; for every or &#39;?&#39; for any</value>
        [DataMember(Name="daysOfMonth", EmitDefaultValue=false)]
        public string DaysOfMonth { get; set; }



        /// <summary>
        /// Months on which the trigger should fire. 1-12 or &#39;*&#39; for every
        /// </summary>
        /// <value>Months on which the trigger should fire. 1-12 or &#39;*&#39; for every</value>
        [DataMember(Name="months", EmitDefaultValue=false)]
        public string Months { get; set; }



        /// <summary>
        /// Days of week on which the trigger should fire. 1-7 or &#39;*&#39; for every or &#39;?&#39; for any
        /// </summary>
        /// <value>Days of week on which the trigger should fire. 1-7 or &#39;*&#39; for every or &#39;?&#39; for any</value>
        [DataMember(Name="daysOfWeek", EmitDefaultValue=false)]
        public string DaysOfWeek { get; set; }



        /// <summary>
        /// Timezone for the trigger schedule
        /// </summary>
        /// <value>Timezone for the trigger schedule</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerSchedule {\n");

            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  DaysOfMonth: ").Append(DaysOfMonth).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
            sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as TriggerSchedule);
        }

        /// <summary>
        /// Returns true if TriggerSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of TriggerSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggerSchedule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Minutes == other.Minutes ||
                    this.Minutes != null &&
                    this.Minutes.Equals(other.Minutes)
                ) &&
                (
                    this.Hours == other.Hours ||
                    this.Hours != null &&
                    this.Hours.Equals(other.Hours)
                ) &&
                (
                    this.DaysOfMonth == other.DaysOfMonth ||
                    this.DaysOfMonth != null &&
                    this.DaysOfMonth.Equals(other.DaysOfMonth)
                ) &&
                (
                    this.Months == other.Months ||
                    this.Months != null &&
                    this.Months.Equals(other.Months)
                ) &&
                (
                    this.DaysOfWeek == other.DaysOfWeek ||
                    this.DaysOfWeek != null &&
                    this.DaysOfWeek.Equals(other.DaysOfWeek)
                ) &&
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                if (this.Minutes != null)
                    hash = hash * 59 + this.Minutes.GetHashCode();

                if (this.Hours != null)
                    hash = hash * 59 + this.Hours.GetHashCode();

                if (this.DaysOfMonth != null)
                    hash = hash * 59 + this.DaysOfMonth.GetHashCode();

                if (this.Months != null)
                    hash = hash * 59 + this.Months.GetHashCode();

                if (this.DaysOfWeek != null)
                    hash = hash * 59 + this.DaysOfWeek.GetHashCode();

                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();

                return hash;
            }
        }
    }

}
