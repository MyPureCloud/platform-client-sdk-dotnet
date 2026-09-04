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
    /// AllocationOutputsTemplate
    /// </summary>
    [DataContract]
    public partial class AllocationOutputsTemplate :  IEquatable<AllocationOutputsTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationOutputsTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllocationOutputsTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationOutputsTemplate" /> class.
        /// </summary>
        /// <param name="CalculationStartDate">The beginning of the allocation results, in ISO-8601 format (required).</param>
        /// <param name="CalculationIntervalLengthMinutes">Interval length of the response metrics (required).</param>
        /// <param name="PlanningGroupAllocationResults">Planning group level allocation results (required).</param>
        public AllocationOutputsTemplate(DateTime? CalculationStartDate = null, int? CalculationIntervalLengthMinutes = null, List<AllocationResultsTemplate> PlanningGroupAllocationResults = null)
        {
            this.CalculationStartDate = CalculationStartDate;
            this.CalculationIntervalLengthMinutes = CalculationIntervalLengthMinutes;
            this.PlanningGroupAllocationResults = PlanningGroupAllocationResults;
            
        }
        


        /// <summary>
        /// The beginning of the allocation results, in ISO-8601 format
        /// </summary>
        /// <value>The beginning of the allocation results, in ISO-8601 format</value>
        [DataMember(Name="calculationStartDate", EmitDefaultValue=false)]
        public DateTime? CalculationStartDate { get; set; }



        /// <summary>
        /// Interval length of the response metrics
        /// </summary>
        /// <value>Interval length of the response metrics</value>
        [DataMember(Name="calculationIntervalLengthMinutes", EmitDefaultValue=false)]
        public int? CalculationIntervalLengthMinutes { get; set; }



        /// <summary>
        /// Planning group level allocation results
        /// </summary>
        /// <value>Planning group level allocation results</value>
        [DataMember(Name="planningGroupAllocationResults", EmitDefaultValue=false)]
        public List<AllocationResultsTemplate> PlanningGroupAllocationResults { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllocationOutputsTemplate {\n");

            sb.Append("  CalculationStartDate: ").Append(CalculationStartDate).Append("\n");
            sb.Append("  CalculationIntervalLengthMinutes: ").Append(CalculationIntervalLengthMinutes).Append("\n");
            sb.Append("  PlanningGroupAllocationResults: ").Append(PlanningGroupAllocationResults).Append("\n");
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
            return this.Equals(obj as AllocationOutputsTemplate);
        }

        /// <summary>
        /// Returns true if AllocationOutputsTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of AllocationOutputsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllocationOutputsTemplate other)
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
                    this.CalculationIntervalLengthMinutes == other.CalculationIntervalLengthMinutes ||
                    this.CalculationIntervalLengthMinutes != null &&
                    this.CalculationIntervalLengthMinutes.Equals(other.CalculationIntervalLengthMinutes)
                ) &&
                (
                    this.PlanningGroupAllocationResults == other.PlanningGroupAllocationResults ||
                    this.PlanningGroupAllocationResults != null &&
                    this.PlanningGroupAllocationResults.SequenceEqual(other.PlanningGroupAllocationResults)
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

                if (this.CalculationIntervalLengthMinutes != null)
                    hash = hash * 59 + this.CalculationIntervalLengthMinutes.GetHashCode();

                if (this.PlanningGroupAllocationResults != null)
                    hash = hash * 59 + this.PlanningGroupAllocationResults.GetHashCode();

                return hash;
            }
        }
    }

}
