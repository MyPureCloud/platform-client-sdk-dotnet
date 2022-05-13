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
    /// FlowMetricsTopicFlowOutcome
    /// </summary>
    [DataContract]
    public partial class FlowMetricsTopicFlowOutcome :  IEquatable<FlowMetricsTopicFlowOutcome>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowMetricsTopicFlowOutcome" /> class.
        /// </summary>
        /// <param name="FlowOutcome">Combination of unique flow outcome identifier and its value separated by colon.</param>
        /// <param name="FlowOutcomeId">Unique identifier of a flow outcome.</param>
        /// <param name="FlowOutcomeValue">Flow outcome value, e.g. SUCCESS.</param>
        public FlowMetricsTopicFlowOutcome(string FlowOutcome = null, string FlowOutcomeId = null, string FlowOutcomeValue = null)
        {
            this.FlowOutcome = FlowOutcome;
            this.FlowOutcomeId = FlowOutcomeId;
            this.FlowOutcomeValue = FlowOutcomeValue;
            
        }
        


        /// <summary>
        /// Combination of unique flow outcome identifier and its value separated by colon
        /// </summary>
        /// <value>Combination of unique flow outcome identifier and its value separated by colon</value>
        [DataMember(Name="flowOutcome", EmitDefaultValue=false)]
        public string FlowOutcome { get; set; }



        /// <summary>
        /// Unique identifier of a flow outcome
        /// </summary>
        /// <value>Unique identifier of a flow outcome</value>
        [DataMember(Name="flowOutcomeId", EmitDefaultValue=false)]
        public string FlowOutcomeId { get; set; }



        /// <summary>
        /// Flow outcome value, e.g. SUCCESS
        /// </summary>
        /// <value>Flow outcome value, e.g. SUCCESS</value>
        [DataMember(Name="flowOutcomeValue", EmitDefaultValue=false)]
        public string FlowOutcomeValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowMetricsTopicFlowOutcome {\n");

            sb.Append("  FlowOutcome: ").Append(FlowOutcome).Append("\n");
            sb.Append("  FlowOutcomeId: ").Append(FlowOutcomeId).Append("\n");
            sb.Append("  FlowOutcomeValue: ").Append(FlowOutcomeValue).Append("\n");
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
            return this.Equals(obj as FlowMetricsTopicFlowOutcome);
        }

        /// <summary>
        /// Returns true if FlowMetricsTopicFlowOutcome instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowMetricsTopicFlowOutcome to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowMetricsTopicFlowOutcome other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FlowOutcome == other.FlowOutcome ||
                    this.FlowOutcome != null &&
                    this.FlowOutcome.Equals(other.FlowOutcome)
                ) &&
                (
                    this.FlowOutcomeId == other.FlowOutcomeId ||
                    this.FlowOutcomeId != null &&
                    this.FlowOutcomeId.Equals(other.FlowOutcomeId)
                ) &&
                (
                    this.FlowOutcomeValue == other.FlowOutcomeValue ||
                    this.FlowOutcomeValue != null &&
                    this.FlowOutcomeValue.Equals(other.FlowOutcomeValue)
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
                if (this.FlowOutcome != null)
                    hash = hash * 59 + this.FlowOutcome.GetHashCode();

                if (this.FlowOutcomeId != null)
                    hash = hash * 59 + this.FlowOutcomeId.GetHashCode();

                if (this.FlowOutcomeValue != null)
                    hash = hash * 59 + this.FlowOutcomeValue.GetHashCode();

                return hash;
            }
        }
    }

}
