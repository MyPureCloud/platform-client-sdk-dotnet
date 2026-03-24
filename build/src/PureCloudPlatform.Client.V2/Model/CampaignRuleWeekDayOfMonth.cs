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
    /// CampaignRuleWeekDayOfMonth
    /// </summary>
    [DataContract]
    public partial class CampaignRuleWeekDayOfMonth :  IEquatable<CampaignRuleWeekDayOfMonth>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleWeekDayOfMonth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignRuleWeekDayOfMonth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleWeekDayOfMonth" /> class.
        /// </summary>
        /// <param name="DayOfWeek">Day of week (1-7) (required).</param>
        /// <param name="Month">Month (1-12).</param>
        /// <param name="Occurrence">Occurrence 1-4, -1 (last).</param>
        public CampaignRuleWeekDayOfMonth(int? DayOfWeek = null, int? Month = null, int? Occurrence = null)
        {
            this.DayOfWeek = DayOfWeek;
            this.Month = Month;
            this.Occurrence = Occurrence;
            
        }
        


        /// <summary>
        /// Day of week (1-7)
        /// </summary>
        /// <value>Day of week (1-7)</value>
        [DataMember(Name="dayOfWeek", EmitDefaultValue=false)]
        public int? DayOfWeek { get; set; }



        /// <summary>
        /// Month (1-12)
        /// </summary>
        /// <value>Month (1-12)</value>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int? Month { get; set; }



        /// <summary>
        /// Occurrence 1-4, -1 (last)
        /// </summary>
        /// <value>Occurrence 1-4, -1 (last)</value>
        [DataMember(Name="occurrence", EmitDefaultValue=false)]
        public int? Occurrence { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleWeekDayOfMonth {\n");

            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Occurrence: ").Append(Occurrence).Append("\n");
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
            return this.Equals(obj as CampaignRuleWeekDayOfMonth);
        }

        /// <summary>
        /// Returns true if CampaignRuleWeekDayOfMonth instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleWeekDayOfMonth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleWeekDayOfMonth other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DayOfWeek == other.DayOfWeek ||
                    this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(other.DayOfWeek)
                ) &&
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
                ) &&
                (
                    this.Occurrence == other.Occurrence ||
                    this.Occurrence != null &&
                    this.Occurrence.Equals(other.Occurrence)
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
                if (this.DayOfWeek != null)
                    hash = hash * 59 + this.DayOfWeek.GetHashCode();

                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();

                if (this.Occurrence != null)
                    hash = hash * 59 + this.Occurrence.GetHashCode();

                return hash;
            }
        }
    }

}
