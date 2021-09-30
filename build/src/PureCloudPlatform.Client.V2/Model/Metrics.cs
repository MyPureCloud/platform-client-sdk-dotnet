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
    /// Metrics
    /// </summary>
    [DataContract]
    public partial class Metrics :  IEquatable<Metrics>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Corresponding unit type for this metric
        /// </summary>
        /// <value>Corresponding unit type for this metric</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UnitTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Percent for "Percent"
            /// </summary>
            [EnumMember(Value = "Percent")]
            Percent,
            
            /// <summary>
            /// Enum Currency for "Currency"
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency,
            
            /// <summary>
            /// Enum Seconds for "Seconds"
            /// </summary>
            [EnumMember(Value = "Seconds")]
            Seconds,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,
            
            /// <summary>
            /// Enum Attendancestatus for "AttendanceStatus"
            /// </summary>
            [EnumMember(Value = "AttendanceStatus")]
            Attendancestatus,
            
            /// <summary>
            /// Enum Unit for "Unit"
            /// </summary>
            [EnumMember(Value = "Unit")]
            Unit
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Corresponding unit type for this metric
        /// </summary>
        /// <value>Corresponding unit type for this metric</value>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public UnitTypeEnum? UnitType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Metrics" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Order">The order of metric within a performance profile.</param>
        /// <param name="MetricDefinitionName">The name of associated metric definition.</param>
        /// <param name="MetricDefinitionId">The id of associated metric definition.</param>
        /// <param name="ExternalMetricDefinitionId">The id of associated external metric definition.</param>
        /// <param name="UnitType">Corresponding unit type for this metric.</param>
        /// <param name="Enabled">A flag for whether this metric is enabled for a performance profile.</param>
        /// <param name="TemplateName">The name of associated objective template.</param>
        /// <param name="MaxPoints">Achievable maximum points for this metric.</param>
        /// <param name="PerformanceProfileId">Performance profile id of this metric.</param>
        public Metrics(string Name = null, int? Order = null, string MetricDefinitionName = null, string MetricDefinitionId = null, string ExternalMetricDefinitionId = null, UnitTypeEnum? UnitType = null, bool? Enabled = null, string TemplateName = null, int? MaxPoints = null, string PerformanceProfileId = null)
        {
            this.Name = Name;
            this.Order = Order;
            this.MetricDefinitionName = MetricDefinitionName;
            this.MetricDefinitionId = MetricDefinitionId;
            this.ExternalMetricDefinitionId = ExternalMetricDefinitionId;
            this.UnitType = UnitType;
            this.Enabled = Enabled;
            this.TemplateName = TemplateName;
            this.MaxPoints = MaxPoints;
            this.PerformanceProfileId = PerformanceProfileId;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The order of metric within a performance profile
        /// </summary>
        /// <value>The order of metric within a performance profile</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }
        
        
        
        /// <summary>
        /// The name of associated metric definition
        /// </summary>
        /// <value>The name of associated metric definition</value>
        [DataMember(Name="metricDefinitionName", EmitDefaultValue=false)]
        public string MetricDefinitionName { get; set; }
        
        
        
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
        /// A flag for whether this metric is enabled for a performance profile
        /// </summary>
        /// <value>A flag for whether this metric is enabled for a performance profile</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The name of associated objective template
        /// </summary>
        /// <value>The name of associated objective template</value>
        [DataMember(Name="templateName", EmitDefaultValue=false)]
        public string TemplateName { get; set; }
        
        
        
        /// <summary>
        /// Achievable maximum points for this metric
        /// </summary>
        /// <value>Achievable maximum points for this metric</value>
        [DataMember(Name="maxPoints", EmitDefaultValue=false)]
        public int? MaxPoints { get; set; }
        
        
        
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
        public AddressableEntityRef LinkedMetric { get; private set; }
        
        
        
        /// <summary>
        /// The created date of this metric
        /// </summary>
        /// <value>The created date of this metric</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public long? DateCreated { get; private set; }
        
        
        
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
        public PerformanceProfile SourcePerformanceProfile { get; private set; }
        
        
        
        /// <summary>
        /// Unit definition of linked external metric
        /// </summary>
        /// <value>Unit definition of linked external metric</value>
        [DataMember(Name="unitDefinition", EmitDefaultValue=false)]
        public string UnitDefinition { get; private set; }
        
        
        
        /// <summary>
        /// Precision of linked external metric
        /// </summary>
        /// <value>Precision of linked external metric</value>
        [DataMember(Name="precision", EmitDefaultValue=false)]
        public int? Precision { get; private set; }
        
        
        
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
            sb.Append("class Metrics {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  MetricDefinitionName: ").Append(MetricDefinitionName).Append("\n");
            sb.Append("  MetricDefinitionId: ").Append(MetricDefinitionId).Append("\n");
            sb.Append("  ExternalMetricDefinitionId: ").Append(ExternalMetricDefinitionId).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
            sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
            sb.Append("  LinkedMetric: ").Append(LinkedMetric).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUnlinked: ").Append(DateUnlinked).Append("\n");
            sb.Append("  SourcePerformanceProfile: ").Append(SourcePerformanceProfile).Append("\n");
            sb.Append("  UnitDefinition: ").Append(UnitDefinition).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
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
            return this.Equals(obj as Metrics);
        }

        /// <summary>
        /// Returns true if Metrics instances are equal
        /// </summary>
        /// <param name="other">Instance of Metrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Metrics other)
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
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) &&
                (
                    this.MetricDefinitionName == other.MetricDefinitionName ||
                    this.MetricDefinitionName != null &&
                    this.MetricDefinitionName.Equals(other.MetricDefinitionName)
                ) &&
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
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.TemplateName == other.TemplateName ||
                    this.TemplateName != null &&
                    this.TemplateName.Equals(other.TemplateName)
                ) &&
                (
                    this.MaxPoints == other.MaxPoints ||
                    this.MaxPoints != null &&
                    this.MaxPoints.Equals(other.MaxPoints)
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
                    this.UnitDefinition == other.UnitDefinition ||
                    this.UnitDefinition != null &&
                    this.UnitDefinition.Equals(other.UnitDefinition)
                ) &&
                (
                    this.Precision == other.Precision ||
                    this.Precision != null &&
                    this.Precision.Equals(other.Precision)
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
                
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                
                if (this.MetricDefinitionName != null)
                    hash = hash * 59 + this.MetricDefinitionName.GetHashCode();
                
                if (this.MetricDefinitionId != null)
                    hash = hash * 59 + this.MetricDefinitionId.GetHashCode();
                
                if (this.ExternalMetricDefinitionId != null)
                    hash = hash * 59 + this.ExternalMetricDefinitionId.GetHashCode();
                
                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.TemplateName != null)
                    hash = hash * 59 + this.TemplateName.GetHashCode();
                
                if (this.MaxPoints != null)
                    hash = hash * 59 + this.MaxPoints.GetHashCode();
                
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
                
                if (this.UnitDefinition != null)
                    hash = hash * 59 + this.UnitDefinition.GetHashCode();
                
                if (this.Precision != null)
                    hash = hash * 59 + this.Precision.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
