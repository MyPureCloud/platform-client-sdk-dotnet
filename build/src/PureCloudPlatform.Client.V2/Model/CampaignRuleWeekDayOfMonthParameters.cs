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
    /// CampaignRuleWeekDayOfMonthParameters
    /// </summary>
    [DataContract]
    public partial class CampaignRuleWeekDayOfMonthParameters :  IEquatable<CampaignRuleWeekDayOfMonthParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleWeekDayOfMonthParameters" /> class.
        /// </summary>
        /// <param name="ThresholdValue">The operand for the \&quot;equals\&quot;, \&quot;before\&quot; and \&quot;after\&quot; operators.</param>
        /// <param name="Interval">The operand for the \&quot;between\&quot; operator.</param>
        public CampaignRuleWeekDayOfMonthParameters(CampaignRuleWeekDayOfMonth ThresholdValue = null, CampaignRuleWeekDayOfMonthInterval Interval = null)
        {
            this.ThresholdValue = ThresholdValue;
            this.Interval = Interval;
            
        }
        


        /// <summary>
        /// The operand for the \&quot;equals\&quot;, \&quot;before\&quot; and \&quot;after\&quot; operators
        /// </summary>
        /// <value>The operand for the \&quot;equals\&quot;, \&quot;before\&quot; and \&quot;after\&quot; operators</value>
        [DataMember(Name="thresholdValue", EmitDefaultValue=false)]
        public CampaignRuleWeekDayOfMonth ThresholdValue { get; set; }



        /// <summary>
        /// The operand for the \&quot;between\&quot; operator
        /// </summary>
        /// <value>The operand for the \&quot;between\&quot; operator</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public CampaignRuleWeekDayOfMonthInterval Interval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleWeekDayOfMonthParameters {\n");

            sb.Append("  ThresholdValue: ").Append(ThresholdValue).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
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
            return this.Equals(obj as CampaignRuleWeekDayOfMonthParameters);
        }

        /// <summary>
        /// Returns true if CampaignRuleWeekDayOfMonthParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleWeekDayOfMonthParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleWeekDayOfMonthParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ThresholdValue == other.ThresholdValue ||
                    this.ThresholdValue != null &&
                    this.ThresholdValue.Equals(other.ThresholdValue)
                ) &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
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
                if (this.ThresholdValue != null)
                    hash = hash * 59 + this.ThresholdValue.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                return hash;
            }
        }
    }

}
