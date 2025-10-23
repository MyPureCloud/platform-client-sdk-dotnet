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
    /// CampaignPerformanceDataProgress
    /// </summary>
    [DataContract]
    public partial class CampaignPerformanceDataProgress :  IEquatable<CampaignPerformanceDataProgress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPerformanceDataProgress" /> class.
        /// </summary>
        /// <param name="Percentage">Percentage of contacts processed during the campaign.</param>
        public CampaignPerformanceDataProgress(double? Percentage = null)
        {
            this.Percentage = Percentage;
            
        }
        


        /// <summary>
        /// Percentage of contacts processed during the campaign
        /// </summary>
        /// <value>Percentage of contacts processed during the campaign</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public double? Percentage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignPerformanceDataProgress {\n");

            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(obj as CampaignPerformanceDataProgress);
        }

        /// <summary>
        /// Returns true if CampaignPerformanceDataProgress instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignPerformanceDataProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignPerformanceDataProgress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
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
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();

                return hash;
            }
        }
    }

}
