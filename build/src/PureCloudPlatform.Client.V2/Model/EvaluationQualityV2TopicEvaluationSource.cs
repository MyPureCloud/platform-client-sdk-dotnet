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
    /// EvaluationQualityV2TopicEvaluationSource
    /// </summary>
    [DataContract]
    public partial class EvaluationQualityV2TopicEvaluationSource :  IEquatable<EvaluationQualityV2TopicEvaluationSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationQualityV2TopicEvaluationSource" /> class.
        /// </summary>
        /// <param name="EvaluationSourceType">EvaluationSourceType.</param>
        /// <param name="EvaluationSourceId">EvaluationSourceId.</param>
        /// <param name="EvaluationSourceName">EvaluationSourceName.</param>
        public EvaluationQualityV2TopicEvaluationSource(string EvaluationSourceType = null, string EvaluationSourceId = null, string EvaluationSourceName = null)
        {
            this.EvaluationSourceType = EvaluationSourceType;
            this.EvaluationSourceId = EvaluationSourceId;
            this.EvaluationSourceName = EvaluationSourceName;
            
        }
        


        /// <summary>
        /// Gets or Sets EvaluationSourceType
        /// </summary>
        [DataMember(Name="evaluationSourceType", EmitDefaultValue=false)]
        public string EvaluationSourceType { get; set; }



        /// <summary>
        /// Gets or Sets EvaluationSourceId
        /// </summary>
        [DataMember(Name="evaluationSourceId", EmitDefaultValue=false)]
        public string EvaluationSourceId { get; set; }



        /// <summary>
        /// Gets or Sets EvaluationSourceName
        /// </summary>
        [DataMember(Name="evaluationSourceName", EmitDefaultValue=false)]
        public string EvaluationSourceName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationQualityV2TopicEvaluationSource {\n");

            sb.Append("  EvaluationSourceType: ").Append(EvaluationSourceType).Append("\n");
            sb.Append("  EvaluationSourceId: ").Append(EvaluationSourceId).Append("\n");
            sb.Append("  EvaluationSourceName: ").Append(EvaluationSourceName).Append("\n");
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
            return this.Equals(obj as EvaluationQualityV2TopicEvaluationSource);
        }

        /// <summary>
        /// Returns true if EvaluationQualityV2TopicEvaluationSource instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationQualityV2TopicEvaluationSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationQualityV2TopicEvaluationSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EvaluationSourceType == other.EvaluationSourceType ||
                    this.EvaluationSourceType != null &&
                    this.EvaluationSourceType.Equals(other.EvaluationSourceType)
                ) &&
                (
                    this.EvaluationSourceId == other.EvaluationSourceId ||
                    this.EvaluationSourceId != null &&
                    this.EvaluationSourceId.Equals(other.EvaluationSourceId)
                ) &&
                (
                    this.EvaluationSourceName == other.EvaluationSourceName ||
                    this.EvaluationSourceName != null &&
                    this.EvaluationSourceName.Equals(other.EvaluationSourceName)
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
                if (this.EvaluationSourceType != null)
                    hash = hash * 59 + this.EvaluationSourceType.GetHashCode();

                if (this.EvaluationSourceId != null)
                    hash = hash * 59 + this.EvaluationSourceId.GetHashCode();

                if (this.EvaluationSourceName != null)
                    hash = hash * 59 + this.EvaluationSourceName.GetHashCode();

                return hash;
            }
        }
    }

}
