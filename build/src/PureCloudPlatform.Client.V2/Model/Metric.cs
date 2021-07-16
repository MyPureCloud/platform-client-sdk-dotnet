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
    /// Metric
    /// </summary>
    [DataContract]
    public partial class Metric :  IEquatable<Metric>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Metric" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Metric() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Metric" /> class.
        /// </summary>
        /// <param name="Name">The name of this metric (required).</param>
        /// <param name="MetricDefinitionId">The id of associated metric definition.</param>
        /// <param name="Objective">Associated objective for this metric.</param>
        /// <param name="PerformanceProfileId">Performance profile id of this metric.</param>
        /// <param name="LinkedMetric">The linked metric entity reference.</param>
        /// <param name="SourcePerformanceProfile">The source performance profile when this metric is linked.</param>
        public Metric(string Name = null, string MetricDefinitionId = null, Objective Objective = null, string PerformanceProfileId = null, AddressableEntityRef LinkedMetric = null, PerformanceProfile SourcePerformanceProfile = null)
        {
            this.Name = Name;
            this.MetricDefinitionId = MetricDefinitionId;
            this.Objective = Objective;
            this.PerformanceProfileId = PerformanceProfileId;
            this.LinkedMetric = LinkedMetric;
            this.SourcePerformanceProfile = SourcePerformanceProfile;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of this metric
        /// </summary>
        /// <value>The name of this metric</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The id of associated metric definition
        /// </summary>
        /// <value>The id of associated metric definition</value>
        [DataMember(Name="metricDefinitionId", EmitDefaultValue=false)]
        public string MetricDefinitionId { get; set; }
        
        
        
        /// <summary>
        /// Associated objective for this metric
        /// </summary>
        /// <value>Associated objective for this metric</value>
        [DataMember(Name="objective", EmitDefaultValue=false)]
        public Objective Objective { get; set; }
        
        
        
        /// <summary>
        /// Performance profile id of this metric
        /// </summary>
        /// <value>Performance profile id of this metric</value>
        [DataMember(Name="performanceProfileId", EmitDefaultValue=false)]
        public string PerformanceProfileId { get; set; }
        
        
        
        /// <summary>
        /// The linked metric entity reference
        /// </summary>
        /// <value>The linked metric entity reference</value>
        [DataMember(Name="linkedMetric", EmitDefaultValue=false)]
        public AddressableEntityRef LinkedMetric { get; set; }
        
        
        
        /// <summary>
        /// The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateUnlinked", EmitDefaultValue=false)]
        public String DateUnlinked { get; private set; }
        
        
        
        /// <summary>
        /// The source performance profile when this metric is linked
        /// </summary>
        /// <value>The source performance profile when this metric is linked</value>
        [DataMember(Name="sourcePerformanceProfile", EmitDefaultValue=false)]
        public PerformanceProfile SourcePerformanceProfile { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metric {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MetricDefinitionId: ").Append(MetricDefinitionId).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
            sb.Append("  LinkedMetric: ").Append(LinkedMetric).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUnlinked: ").Append(DateUnlinked).Append("\n");
            sb.Append("  SourcePerformanceProfile: ").Append(SourcePerformanceProfile).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Metric);
        }

        /// <summary>
        /// Returns true if Metric instances are equal
        /// </summary>
        /// <param name="other">Instance of Metric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Metric other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.MetricDefinitionId == other.MetricDefinitionId ||
                    this.MetricDefinitionId != null &&
                    this.MetricDefinitionId.Equals(other.MetricDefinitionId)
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
                    this.LinkedMetric == other.LinkedMetric ||
                    this.LinkedMetric != null &&
                    this.LinkedMetric.Equals(other.LinkedMetric)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateUnlinked == other.DateUnlinked ||
                    this.DateUnlinked != null &&
                    this.DateUnlinked.Equals(other.DateUnlinked)
                ) &&
                (
                    this.SourcePerformanceProfile == other.SourcePerformanceProfile ||
                    this.SourcePerformanceProfile != null &&
                    this.SourcePerformanceProfile.Equals(other.SourcePerformanceProfile)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.MetricDefinitionId != null)
                    hash = hash * 59 + this.MetricDefinitionId.GetHashCode();
                
                if (this.Objective != null)
                    hash = hash * 59 + this.Objective.GetHashCode();
                
                if (this.PerformanceProfileId != null)
                    hash = hash * 59 + this.PerformanceProfileId.GetHashCode();
                
                if (this.LinkedMetric != null)
                    hash = hash * 59 + this.LinkedMetric.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateUnlinked != null)
                    hash = hash * 59 + this.DateUnlinked.GetHashCode();
                
                if (this.SourcePerformanceProfile != null)
                    hash = hash * 59 + this.SourcePerformanceProfile.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
