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
    /// CampaignRuleDayOfMonthParameters
    /// </summary>
    [DataContract]
    public partial class CampaignRuleDayOfMonthParameters :  IEquatable<CampaignRuleDayOfMonthParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleDayOfMonthParameters" /> class.
        /// </summary>
        /// <param name="ThresholdValue">The operand for the \&quot;before\&quot; and \&quot;after\&quot; operators, can be either exact day (1-31) or \&quot;LAST_DAY\&quot;.</param>
        /// <param name="InSet">The operand for the \&quot;in\&quot; operator, each element can be either exact day (1,31) or \&quot;LAST_DAY\&quot;, \&quot;EVEN_DAY\&quot;, \&quot;ODD_DAY\&quot;.</param>
        /// <param name="Interval">The interval operand for the \&quot;between\&quot; operator.</param>
        public CampaignRuleDayOfMonthParameters(string ThresholdValue = null, List<string> InSet = null, CampaignRuleDayOfMonthInterval Interval = null)
        {
            this.ThresholdValue = ThresholdValue;
            this.InSet = InSet;
            this.Interval = Interval;
            
        }
        


        /// <summary>
        /// The operand for the \&quot;before\&quot; and \&quot;after\&quot; operators, can be either exact day (1-31) or \&quot;LAST_DAY\&quot;
        /// </summary>
        /// <value>The operand for the \&quot;before\&quot; and \&quot;after\&quot; operators, can be either exact day (1-31) or \&quot;LAST_DAY\&quot;</value>
        [DataMember(Name="thresholdValue", EmitDefaultValue=false)]
        public string ThresholdValue { get; set; }



        /// <summary>
        /// The operand for the \&quot;in\&quot; operator, each element can be either exact day (1,31) or \&quot;LAST_DAY\&quot;, \&quot;EVEN_DAY\&quot;, \&quot;ODD_DAY\&quot;
        /// </summary>
        /// <value>The operand for the \&quot;in\&quot; operator, each element can be either exact day (1,31) or \&quot;LAST_DAY\&quot;, \&quot;EVEN_DAY\&quot;, \&quot;ODD_DAY\&quot;</value>
        [DataMember(Name="inSet", EmitDefaultValue=false)]
        public List<string> InSet { get; set; }



        /// <summary>
        /// The interval operand for the \&quot;between\&quot; operator
        /// </summary>
        /// <value>The interval operand for the \&quot;between\&quot; operator</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public CampaignRuleDayOfMonthInterval Interval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleDayOfMonthParameters {\n");

            sb.Append("  ThresholdValue: ").Append(ThresholdValue).Append("\n");
            sb.Append("  InSet: ").Append(InSet).Append("\n");
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
            return this.Equals(obj as CampaignRuleDayOfMonthParameters);
        }

        /// <summary>
        /// Returns true if CampaignRuleDayOfMonthParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleDayOfMonthParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleDayOfMonthParameters other)
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
                    this.InSet == other.InSet ||
                    this.InSet != null &&
                    this.InSet.SequenceEqual(other.InSet)
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

                if (this.InSet != null)
                    hash = hash * 59 + this.InSet.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                return hash;
            }
        }
    }

}
