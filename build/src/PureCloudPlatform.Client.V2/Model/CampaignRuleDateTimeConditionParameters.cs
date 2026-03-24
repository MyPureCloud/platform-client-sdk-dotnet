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
    /// CampaignRuleDateTimeConditionParameters
    /// </summary>
    [DataContract]
    public partial class CampaignRuleDateTimeConditionParameters :  IEquatable<CampaignRuleDateTimeConditionParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleDateTimeConditionParameters" /> class.
        /// </summary>
        /// <param name="Inverted">If true, inverts the result of evaluating this sub-condition. Default is false.</param>
        /// <param name="TimeOfDay">Parameters for \&quot;timeOfDay\&quot; conditionType.</param>
        /// <param name="DayOfWeek">Parameters for \&quot;dayOfWeek\&quot; conditionType.</param>
        /// <param name="DayOfMonth">Parameters for \&quot;dayOfMonth\&quot; conditionType.</param>
        /// <param name="SpecificDate">Parameters for \&quot;specificDate\&quot; conditionType.</param>
        /// <param name="WeekDayOfMonth">Parameters for \&quot;weekDayOfMonth\&quot; conditionType.</param>
        public CampaignRuleDateTimeConditionParameters(bool? Inverted = null, CampaignRuleTimeOfDayParameters TimeOfDay = null, CampaignRuleDayOfWeekParameters DayOfWeek = null, CampaignRuleDayOfMonthParameters DayOfMonth = null, CampaignRuleSpecificDateParameters SpecificDate = null, CampaignRuleWeekDayOfMonthParameters WeekDayOfMonth = null)
        {
            this.Inverted = Inverted;
            this.TimeOfDay = TimeOfDay;
            this.DayOfWeek = DayOfWeek;
            this.DayOfMonth = DayOfMonth;
            this.SpecificDate = SpecificDate;
            this.WeekDayOfMonth = WeekDayOfMonth;
            
        }
        


        /// <summary>
        /// If true, inverts the result of evaluating this sub-condition. Default is false
        /// </summary>
        /// <value>If true, inverts the result of evaluating this sub-condition. Default is false</value>
        [DataMember(Name="inverted", EmitDefaultValue=false)]
        public bool? Inverted { get; set; }



        /// <summary>
        /// Parameters for \&quot;timeOfDay\&quot; conditionType
        /// </summary>
        /// <value>Parameters for \&quot;timeOfDay\&quot; conditionType</value>
        [DataMember(Name="timeOfDay", EmitDefaultValue=false)]
        public CampaignRuleTimeOfDayParameters TimeOfDay { get; set; }



        /// <summary>
        /// Parameters for \&quot;dayOfWeek\&quot; conditionType
        /// </summary>
        /// <value>Parameters for \&quot;dayOfWeek\&quot; conditionType</value>
        [DataMember(Name="dayOfWeek", EmitDefaultValue=false)]
        public CampaignRuleDayOfWeekParameters DayOfWeek { get; set; }



        /// <summary>
        /// Parameters for \&quot;dayOfMonth\&quot; conditionType
        /// </summary>
        /// <value>Parameters for \&quot;dayOfMonth\&quot; conditionType</value>
        [DataMember(Name="dayOfMonth", EmitDefaultValue=false)]
        public CampaignRuleDayOfMonthParameters DayOfMonth { get; set; }



        /// <summary>
        /// Parameters for \&quot;specificDate\&quot; conditionType
        /// </summary>
        /// <value>Parameters for \&quot;specificDate\&quot; conditionType</value>
        [DataMember(Name="specificDate", EmitDefaultValue=false)]
        public CampaignRuleSpecificDateParameters SpecificDate { get; set; }



        /// <summary>
        /// Parameters for \&quot;weekDayOfMonth\&quot; conditionType
        /// </summary>
        /// <value>Parameters for \&quot;weekDayOfMonth\&quot; conditionType</value>
        [DataMember(Name="weekDayOfMonth", EmitDefaultValue=false)]
        public CampaignRuleWeekDayOfMonthParameters WeekDayOfMonth { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleDateTimeConditionParameters {\n");

            sb.Append("  Inverted: ").Append(Inverted).Append("\n");
            sb.Append("  TimeOfDay: ").Append(TimeOfDay).Append("\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  DayOfMonth: ").Append(DayOfMonth).Append("\n");
            sb.Append("  SpecificDate: ").Append(SpecificDate).Append("\n");
            sb.Append("  WeekDayOfMonth: ").Append(WeekDayOfMonth).Append("\n");
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
            return this.Equals(obj as CampaignRuleDateTimeConditionParameters);
        }

        /// <summary>
        /// Returns true if CampaignRuleDateTimeConditionParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleDateTimeConditionParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleDateTimeConditionParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Inverted == other.Inverted ||
                    this.Inverted != null &&
                    this.Inverted.Equals(other.Inverted)
                ) &&
                (
                    this.TimeOfDay == other.TimeOfDay ||
                    this.TimeOfDay != null &&
                    this.TimeOfDay.Equals(other.TimeOfDay)
                ) &&
                (
                    this.DayOfWeek == other.DayOfWeek ||
                    this.DayOfWeek != null &&
                    this.DayOfWeek.Equals(other.DayOfWeek)
                ) &&
                (
                    this.DayOfMonth == other.DayOfMonth ||
                    this.DayOfMonth != null &&
                    this.DayOfMonth.Equals(other.DayOfMonth)
                ) &&
                (
                    this.SpecificDate == other.SpecificDate ||
                    this.SpecificDate != null &&
                    this.SpecificDate.Equals(other.SpecificDate)
                ) &&
                (
                    this.WeekDayOfMonth == other.WeekDayOfMonth ||
                    this.WeekDayOfMonth != null &&
                    this.WeekDayOfMonth.Equals(other.WeekDayOfMonth)
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
                if (this.Inverted != null)
                    hash = hash * 59 + this.Inverted.GetHashCode();

                if (this.TimeOfDay != null)
                    hash = hash * 59 + this.TimeOfDay.GetHashCode();

                if (this.DayOfWeek != null)
                    hash = hash * 59 + this.DayOfWeek.GetHashCode();

                if (this.DayOfMonth != null)
                    hash = hash * 59 + this.DayOfMonth.GetHashCode();

                if (this.SpecificDate != null)
                    hash = hash * 59 + this.SpecificDate.GetHashCode();

                if (this.WeekDayOfMonth != null)
                    hash = hash * 59 + this.WeekDayOfMonth.GetHashCode();

                return hash;
            }
        }
    }

}
