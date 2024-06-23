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
    /// CampaignBusinessCategoryMetrics
    /// </summary>
    [DataContract]
    public partial class CampaignBusinessCategoryMetrics :  IEquatable<CampaignBusinessCategoryMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignBusinessCategoryMetrics" /> class.
        /// </summary>
        /// <param name="SuccessCount">Number of calls categorized as business success.</param>
        /// <param name="NeutralCount">Number of calls categorized as business neutral.</param>
        /// <param name="FailureCount">Number of calls categorized as business failure.</param>
        public CampaignBusinessCategoryMetrics(int? SuccessCount = null, int? NeutralCount = null, int? FailureCount = null)
        {
            this.SuccessCount = SuccessCount;
            this.NeutralCount = NeutralCount;
            this.FailureCount = FailureCount;
            
        }
        


        /// <summary>
        /// Number of calls categorized as business success
        /// </summary>
        /// <value>Number of calls categorized as business success</value>
        [DataMember(Name="successCount", EmitDefaultValue=false)]
        public int? SuccessCount { get; set; }



        /// <summary>
        /// Number of calls categorized as business neutral
        /// </summary>
        /// <value>Number of calls categorized as business neutral</value>
        [DataMember(Name="neutralCount", EmitDefaultValue=false)]
        public int? NeutralCount { get; set; }



        /// <summary>
        /// Number of calls categorized as business failure
        /// </summary>
        /// <value>Number of calls categorized as business failure</value>
        [DataMember(Name="failureCount", EmitDefaultValue=false)]
        public int? FailureCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignBusinessCategoryMetrics {\n");

            sb.Append("  SuccessCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  NeutralCount: ").Append(NeutralCount).Append("\n");
            sb.Append("  FailureCount: ").Append(FailureCount).Append("\n");
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
            return this.Equals(obj as CampaignBusinessCategoryMetrics);
        }

        /// <summary>
        /// Returns true if CampaignBusinessCategoryMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignBusinessCategoryMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignBusinessCategoryMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SuccessCount == other.SuccessCount ||
                    this.SuccessCount != null &&
                    this.SuccessCount.Equals(other.SuccessCount)
                ) &&
                (
                    this.NeutralCount == other.NeutralCount ||
                    this.NeutralCount != null &&
                    this.NeutralCount.Equals(other.NeutralCount)
                ) &&
                (
                    this.FailureCount == other.FailureCount ||
                    this.FailureCount != null &&
                    this.FailureCount.Equals(other.FailureCount)
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
                if (this.SuccessCount != null)
                    hash = hash * 59 + this.SuccessCount.GetHashCode();

                if (this.NeutralCount != null)
                    hash = hash * 59 + this.NeutralCount.GetHashCode();

                if (this.FailureCount != null)
                    hash = hash * 59 + this.FailureCount.GetHashCode();

                return hash;
            }
        }
    }

}
