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
    /// HistoricalShrinkageActivityCodeResponse
    /// </summary>
    [DataContract]
    public partial class HistoricalShrinkageActivityCodeResponse :  IEquatable<HistoricalShrinkageActivityCodeResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalShrinkageActivityCodeResponse" /> class.
        /// </summary>
        /// <param name="ActivityCodeId">The ID of the activity code for which shrinkage data is provided.</param>
        /// <param name="ShrinkageForActivityCode">Aggregated shrinkage data for the activity code.</param>
        public HistoricalShrinkageActivityCodeResponse(string ActivityCodeId = null, HistoricalShrinkageAggregateResponse ShrinkageForActivityCode = null)
        {
            this.ActivityCodeId = ActivityCodeId;
            this.ShrinkageForActivityCode = ShrinkageForActivityCode;
            
        }
        


        /// <summary>
        /// The ID of the activity code for which shrinkage data is provided
        /// </summary>
        /// <value>The ID of the activity code for which shrinkage data is provided</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Aggregated shrinkage data for the activity code
        /// </summary>
        /// <value>Aggregated shrinkage data for the activity code</value>
        [DataMember(Name="shrinkageForActivityCode", EmitDefaultValue=false)]
        public HistoricalShrinkageAggregateResponse ShrinkageForActivityCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricalShrinkageActivityCodeResponse {\n");

            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  ShrinkageForActivityCode: ").Append(ShrinkageForActivityCode).Append("\n");
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
            return this.Equals(obj as HistoricalShrinkageActivityCodeResponse);
        }

        /// <summary>
        /// Returns true if HistoricalShrinkageActivityCodeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricalShrinkageActivityCodeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalShrinkageActivityCodeResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.ShrinkageForActivityCode == other.ShrinkageForActivityCode ||
                    this.ShrinkageForActivityCode != null &&
                    this.ShrinkageForActivityCode.Equals(other.ShrinkageForActivityCode)
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
                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.ShrinkageForActivityCode != null)
                    hash = hash * 59 + this.ShrinkageForActivityCode.GetHashCode();

                return hash;
            }
        }
    }

}
