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
    /// CampaignRuleDayOfMonthInterval
    /// </summary>
    [DataContract]
    public partial class CampaignRuleDayOfMonthInterval :  IEquatable<CampaignRuleDayOfMonthInterval>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleDayOfMonthInterval" /> class.
        /// </summary>
        /// <param name="Min">The minimal day of month (exact day: 1-31) for the \&quot;between\&quot; operator.</param>
        /// <param name="Max">The maximum value of month (exact day: 1-31 or \&quot;LAST_DAY\&quot;) for the \&quot;between\&quot; operator.</param>
        public CampaignRuleDayOfMonthInterval(string Min = null, string Max = null)
        {
            this.Min = Min;
            this.Max = Max;
            
        }
        


        /// <summary>
        /// The minimal day of month (exact day: 1-31) for the \&quot;between\&quot; operator
        /// </summary>
        /// <value>The minimal day of month (exact day: 1-31) for the \&quot;between\&quot; operator</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public string Min { get; set; }



        /// <summary>
        /// The maximum value of month (exact day: 1-31 or \&quot;LAST_DAY\&quot;) for the \&quot;between\&quot; operator
        /// </summary>
        /// <value>The maximum value of month (exact day: 1-31 or \&quot;LAST_DAY\&quot;) for the \&quot;between\&quot; operator</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public string Max { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleDayOfMonthInterval {\n");

            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
            return this.Equals(obj as CampaignRuleDayOfMonthInterval);
        }

        /// <summary>
        /// Returns true if CampaignRuleDayOfMonthInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleDayOfMonthInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleDayOfMonthInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Min == other.Min ||
                    this.Min != null &&
                    this.Min.Equals(other.Min)
                ) &&
                (
                    this.Max == other.Max ||
                    this.Max != null &&
                    this.Max.Equals(other.Max)
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
                if (this.Min != null)
                    hash = hash * 59 + this.Min.GetHashCode();

                if (this.Max != null)
                    hash = hash * 59 + this.Max.GetHashCode();

                return hash;
            }
        }
    }

}
