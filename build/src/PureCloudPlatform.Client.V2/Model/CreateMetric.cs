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
    /// CreateMetric
    /// </summary>
    [DataContract]
    public partial class CreateMetric :  IEquatable<CreateMetric>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetric" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateMetric() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetric" /> class.
        /// </summary>
        /// <param name="MetricDefinitionId">The id of associated metric definition.</param>
        /// <param name="ExternalMetricDefinitionId">The id of associated external metric definition.</param>
        /// <param name="Objective">Associated objective for this metric.</param>
        /// <param name="PerformanceProfileId">Performance profile id of this metric.</param>
        /// <param name="Name">The name of this metric (required).</param>
        public CreateMetric(string MetricDefinitionId = null, string ExternalMetricDefinitionId = null, CreateObjective Objective = null, string PerformanceProfileId = null, string Name = null)
        {
            this.MetricDefinitionId = MetricDefinitionId;
            this.ExternalMetricDefinitionId = ExternalMetricDefinitionId;
            this.Objective = Objective;
            this.PerformanceProfileId = PerformanceProfileId;
            this.Name = Name;
            
        }
        


        /// <summary>
        /// The id of associated metric definition
        /// </summary>
        /// <value>The id of associated metric definition</value>
        [DataMember(Name="metricDefinitionId", EmitDefaultValue=false)]
        public string MetricDefinitionId { get; set; }



        /// <summary>
        /// The id of associated external metric definition
        /// </summary>
        /// <value>The id of associated external metric definition</value>
        [DataMember(Name="externalMetricDefinitionId", EmitDefaultValue=false)]
        public string ExternalMetricDefinitionId { get; set; }



        /// <summary>
        /// Associated objective for this metric
        /// </summary>
        /// <value>Associated objective for this metric</value>
        [DataMember(Name="objective", EmitDefaultValue=false)]
        public CreateObjective Objective { get; set; }



        /// <summary>
        /// Performance profile id of this metric
        /// </summary>
        /// <value>Performance profile id of this metric</value>
        [DataMember(Name="performanceProfileId", EmitDefaultValue=false)]
        public string PerformanceProfileId { get; set; }



        /// <summary>
        /// The name of this metric
        /// </summary>
        /// <value>The name of this metric</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMetric {\n");

            sb.Append("  MetricDefinitionId: ").Append(MetricDefinitionId).Append("\n");
            sb.Append("  ExternalMetricDefinitionId: ").Append(ExternalMetricDefinitionId).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as CreateMetric);
        }

        /// <summary>
        /// Returns true if CreateMetric instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMetric other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MetricDefinitionId == other.MetricDefinitionId ||
                    this.MetricDefinitionId != null &&
                    this.MetricDefinitionId.Equals(other.MetricDefinitionId)
                ) &&
                (
                    this.ExternalMetricDefinitionId == other.ExternalMetricDefinitionId ||
                    this.ExternalMetricDefinitionId != null &&
                    this.ExternalMetricDefinitionId.Equals(other.ExternalMetricDefinitionId)
                ) &&
                (
                    this.Objective == other.Objective ||
                    this.Objective != null &&
                    this.Objective.Equals(other.Objective)
                ) &&
                (
                    this.PerformanceProfileId == other.PerformanceProfileId ||
                    this.PerformanceProfileId != null &&
                    this.PerformanceProfileId.Equals(other.PerformanceProfileId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.MetricDefinitionId != null)
                    hash = hash * 59 + this.MetricDefinitionId.GetHashCode();

                if (this.ExternalMetricDefinitionId != null)
                    hash = hash * 59 + this.ExternalMetricDefinitionId.GetHashCode();

                if (this.Objective != null)
                    hash = hash * 59 + this.Objective.GetHashCode();

                if (this.PerformanceProfileId != null)
                    hash = hash * 59 + this.PerformanceProfileId.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                return hash;
            }
        }
    }

}
