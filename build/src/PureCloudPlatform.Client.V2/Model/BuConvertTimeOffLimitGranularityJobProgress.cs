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
    /// BuConvertTimeOffLimitGranularityJobProgress
    /// </summary>
    [DataContract]
    public partial class BuConvertTimeOffLimitGranularityJobProgress :  IEquatable<BuConvertTimeOffLimitGranularityJobProgress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuConvertTimeOffLimitGranularityJobProgress" /> class.
        /// </summary>
        /// <param name="DateEarliestComplete">Earliest date completed for time-off limit granularity conversion. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateLatestComplete">Latest date completed for time-off limit granularity conversion. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="NumberOfDaysComplete">Number of days completed for time-off limit granularity conversion.</param>
        /// <param name="PercentageComplete">Percentage completed for time-off limit granularity conversion.</param>
        public BuConvertTimeOffLimitGranularityJobProgress(String DateEarliestComplete = null, String DateLatestComplete = null, int? NumberOfDaysComplete = null, int? PercentageComplete = null)
        {
            this.DateEarliestComplete = DateEarliestComplete;
            this.DateLatestComplete = DateLatestComplete;
            this.NumberOfDaysComplete = NumberOfDaysComplete;
            this.PercentageComplete = PercentageComplete;
            
        }
        


        /// <summary>
        /// Earliest date completed for time-off limit granularity conversion. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Earliest date completed for time-off limit granularity conversion. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEarliestComplete", EmitDefaultValue=false)]
        public String DateEarliestComplete { get; set; }



        /// <summary>
        /// Latest date completed for time-off limit granularity conversion. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Latest date completed for time-off limit granularity conversion. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateLatestComplete", EmitDefaultValue=false)]
        public String DateLatestComplete { get; set; }



        /// <summary>
        /// Number of days completed for time-off limit granularity conversion
        /// </summary>
        /// <value>Number of days completed for time-off limit granularity conversion</value>
        [DataMember(Name="numberOfDaysComplete", EmitDefaultValue=false)]
        public int? NumberOfDaysComplete { get; set; }



        /// <summary>
        /// Percentage completed for time-off limit granularity conversion
        /// </summary>
        /// <value>Percentage completed for time-off limit granularity conversion</value>
        [DataMember(Name="percentageComplete", EmitDefaultValue=false)]
        public int? PercentageComplete { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuConvertTimeOffLimitGranularityJobProgress {\n");

            sb.Append("  DateEarliestComplete: ").Append(DateEarliestComplete).Append("\n");
            sb.Append("  DateLatestComplete: ").Append(DateLatestComplete).Append("\n");
            sb.Append("  NumberOfDaysComplete: ").Append(NumberOfDaysComplete).Append("\n");
            sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
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
            return this.Equals(obj as BuConvertTimeOffLimitGranularityJobProgress);
        }

        /// <summary>
        /// Returns true if BuConvertTimeOffLimitGranularityJobProgress instances are equal
        /// </summary>
        /// <param name="other">Instance of BuConvertTimeOffLimitGranularityJobProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuConvertTimeOffLimitGranularityJobProgress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateEarliestComplete == other.DateEarliestComplete ||
                    this.DateEarliestComplete != null &&
                    this.DateEarliestComplete.Equals(other.DateEarliestComplete)
                ) &&
                (
                    this.DateLatestComplete == other.DateLatestComplete ||
                    this.DateLatestComplete != null &&
                    this.DateLatestComplete.Equals(other.DateLatestComplete)
                ) &&
                (
                    this.NumberOfDaysComplete == other.NumberOfDaysComplete ||
                    this.NumberOfDaysComplete != null &&
                    this.NumberOfDaysComplete.Equals(other.NumberOfDaysComplete)
                ) &&
                (
                    this.PercentageComplete == other.PercentageComplete ||
                    this.PercentageComplete != null &&
                    this.PercentageComplete.Equals(other.PercentageComplete)
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
                if (this.DateEarliestComplete != null)
                    hash = hash * 59 + this.DateEarliestComplete.GetHashCode();

                if (this.DateLatestComplete != null)
                    hash = hash * 59 + this.DateLatestComplete.GetHashCode();

                if (this.NumberOfDaysComplete != null)
                    hash = hash * 59 + this.NumberOfDaysComplete.GetHashCode();

                if (this.PercentageComplete != null)
                    hash = hash * 59 + this.PercentageComplete.GetHashCode();

                return hash;
            }
        }
    }

}
