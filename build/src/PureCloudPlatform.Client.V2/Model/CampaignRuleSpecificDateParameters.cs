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
    /// CampaignRuleSpecificDateParameters
    /// </summary>
    [DataContract]
    public partial class CampaignRuleSpecificDateParameters :  IEquatable<CampaignRuleSpecificDateParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleSpecificDateParameters" /> class.
        /// </summary>
        /// <param name="IncludeYear">If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true. .</param>
        /// <param name="ThresholdValue">The operand for the \&quot;equals\&quot;, \&quot;after\&quot; and \&quot;before\&quot; operators in yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false) format..</param>
        /// <param name="Interval">The operand for the \&quot;between\&quot; operator.</param>
        public CampaignRuleSpecificDateParameters(bool? IncludeYear = null, string ThresholdValue = null, CampaignRuleSpecificDateInterval Interval = null)
        {
            this.IncludeYear = IncludeYear;
            this.ThresholdValue = ThresholdValue;
            this.Interval = Interval;
            
        }
        


        /// <summary>
        /// If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true. 
        /// </summary>
        /// <value>If true, includes year in date comparison for specificDate type. When false, only month and day are compared. Default is true. </value>
        [DataMember(Name="includeYear", EmitDefaultValue=false)]
        public bool? IncludeYear { get; set; }



        /// <summary>
        /// The operand for the \&quot;equals\&quot;, \&quot;after\&quot; and \&quot;before\&quot; operators in yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false) format.
        /// </summary>
        /// <value>The operand for the \&quot;equals\&quot;, \&quot;after\&quot; and \&quot;before\&quot; operators in yyyy-MM-dd (if includeYear&#x3D;true) or MM-dd (if includeYear&#x3D;false) format.</value>
        [DataMember(Name="thresholdValue", EmitDefaultValue=false)]
        public string ThresholdValue { get; set; }



        /// <summary>
        /// The operand for the \&quot;between\&quot; operator
        /// </summary>
        /// <value>The operand for the \&quot;between\&quot; operator</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public CampaignRuleSpecificDateInterval Interval { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleSpecificDateParameters {\n");

            sb.Append("  IncludeYear: ").Append(IncludeYear).Append("\n");
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
            return this.Equals(obj as CampaignRuleSpecificDateParameters);
        }

        /// <summary>
        /// Returns true if CampaignRuleSpecificDateParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleSpecificDateParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleSpecificDateParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IncludeYear == other.IncludeYear ||
                    this.IncludeYear != null &&
                    this.IncludeYear.Equals(other.IncludeYear)
                ) &&
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
                if (this.IncludeYear != null)
                    hash = hash * 59 + this.IncludeYear.GetHashCode();

                if (this.ThresholdValue != null)
                    hash = hash * 59 + this.ThresholdValue.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                return hash;
            }
        }
    }

}
