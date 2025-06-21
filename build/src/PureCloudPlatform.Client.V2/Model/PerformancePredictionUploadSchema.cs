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
    /// PerformancePredictionUploadSchema
    /// </summary>
    [DataContract]
    public partial class PerformancePredictionUploadSchema :  IEquatable<PerformancePredictionUploadSchema>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformancePredictionUploadSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerformancePredictionUploadSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformancePredictionUploadSchema" /> class.
        /// </summary>
        /// <param name="CalculationStartDate">Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results (required).</param>
        /// <param name="OnQueueTimes">List of agent on-queue times by management unit (required).</param>
        public PerformancePredictionUploadSchema(DateTime? CalculationStartDate = null, List<MuAgentQueueTimeRequest> OnQueueTimes = null)
        {
            this.CalculationStartDate = CalculationStartDate;
            this.OnQueueTimes = OnQueueTimes;
            
        }
        


        /// <summary>
        /// Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results
        /// </summary>
        /// <value>Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results</value>
        [DataMember(Name="calculationStartDate", EmitDefaultValue=false)]
        public DateTime? CalculationStartDate { get; set; }



        /// <summary>
        /// List of agent on-queue times by management unit
        /// </summary>
        /// <value>List of agent on-queue times by management unit</value>
        [DataMember(Name="onQueueTimes", EmitDefaultValue=false)]
        public List<MuAgentQueueTimeRequest> OnQueueTimes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformancePredictionUploadSchema {\n");

            sb.Append("  CalculationStartDate: ").Append(CalculationStartDate).Append("\n");
            sb.Append("  OnQueueTimes: ").Append(OnQueueTimes).Append("\n");
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
            return this.Equals(obj as PerformancePredictionUploadSchema);
        }

        /// <summary>
        /// Returns true if PerformancePredictionUploadSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of PerformancePredictionUploadSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformancePredictionUploadSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CalculationStartDate == other.CalculationStartDate ||
                    this.CalculationStartDate != null &&
                    this.CalculationStartDate.Equals(other.CalculationStartDate)
                ) &&
                (
                    this.OnQueueTimes == other.OnQueueTimes ||
                    this.OnQueueTimes != null &&
                    this.OnQueueTimes.SequenceEqual(other.OnQueueTimes)
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
                if (this.CalculationStartDate != null)
                    hash = hash * 59 + this.CalculationStartDate.GetHashCode();

                if (this.OnQueueTimes != null)
                    hash = hash * 59 + this.OnQueueTimes.GetHashCode();

                return hash;
            }
        }
    }

}
