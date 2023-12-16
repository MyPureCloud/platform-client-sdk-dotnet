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
    /// MetricDefinition
    /// </summary>
    [DataContract]
    public partial class MetricDefinition :  IEquatable<MetricDefinition>
    {
        /// <summary>
        /// The type of associated metric unit
        /// </summary>
        /// <value>The type of associated metric unit</value>
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
        /// The type of associated metric unit
        /// </summary>
        /// <value>The type of associated metric unit</value>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public UnitTypeEnum? UnitType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricDefinition" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="UnitType">The type of associated metric unit.</param>
        /// <param name="ShortName">An alternate name for this metric definition, often abbreviation.</param>
        /// <param name="DividendMetrics">Metric names used as dividend.</param>
        /// <param name="DivisorMetrics">Metric names used as divisor.</param>
        /// <param name="DefaultObjective">A predefined default objective for this metric.</param>
        /// <param name="LockTemplateId">An optional field to specify if this metric definition is locked to certain template. e.g. punctuality.</param>
        /// <param name="MediaTypeFilteringAllowed">Flag to indicate if this metricDefinition allows filter based on media types.</param>
        /// <param name="InitialDirectionFilteringAllowed">Flag to indicate if this metricDefinition allows filter based on initial direction.</param>
        /// <param name="QueueFilteringAllowed">Flag to indicate if this metricDefinition allows filter based on queues.</param>
        public MetricDefinition(string Name = null, UnitTypeEnum? UnitType = null, string ShortName = null, List<string> DividendMetrics = null, List<string> DivisorMetrics = null, DefaultObjective DefaultObjective = null, string LockTemplateId = null, bool? MediaTypeFilteringAllowed = null, bool? InitialDirectionFilteringAllowed = null, bool? QueueFilteringAllowed = null)
        {
            this.Name = Name;
            this.UnitType = UnitType;
            this.ShortName = ShortName;
            this.DividendMetrics = DividendMetrics;
            this.DivisorMetrics = DivisorMetrics;
            this.DefaultObjective = DefaultObjective;
            this.LockTemplateId = LockTemplateId;
            this.MediaTypeFilteringAllowed = MediaTypeFilteringAllowed;
            this.InitialDirectionFilteringAllowed = InitialDirectionFilteringAllowed;
            this.QueueFilteringAllowed = QueueFilteringAllowed;
            
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
        /// An alternate name for this metric definition, often abbreviation
        /// </summary>
        /// <value>An alternate name for this metric definition, often abbreviation</value>
        [DataMember(Name="shortName", EmitDefaultValue=false)]
        public string ShortName { get; set; }



        /// <summary>
        /// Metric names used as dividend
        /// </summary>
        /// <value>Metric names used as dividend</value>
        [DataMember(Name="dividendMetrics", EmitDefaultValue=false)]
        public List<string> DividendMetrics { get; set; }



        /// <summary>
        /// Metric names used as divisor
        /// </summary>
        /// <value>Metric names used as divisor</value>
        [DataMember(Name="divisorMetrics", EmitDefaultValue=false)]
        public List<string> DivisorMetrics { get; set; }



        /// <summary>
        /// A predefined default objective for this metric
        /// </summary>
        /// <value>A predefined default objective for this metric</value>
        [DataMember(Name="defaultObjective", EmitDefaultValue=false)]
        public DefaultObjective DefaultObjective { get; set; }



        /// <summary>
        /// An optional field to specify if this metric definition is locked to certain template. e.g. punctuality
        /// </summary>
        /// <value>An optional field to specify if this metric definition is locked to certain template. e.g. punctuality</value>
        [DataMember(Name="lockTemplateId", EmitDefaultValue=false)]
        public string LockTemplateId { get; set; }



        /// <summary>
        /// Flag to indicate if this metricDefinition allows filter based on media types
        /// </summary>
        /// <value>Flag to indicate if this metricDefinition allows filter based on media types</value>
        [DataMember(Name="mediaTypeFilteringAllowed", EmitDefaultValue=false)]
        public bool? MediaTypeFilteringAllowed { get; set; }



        /// <summary>
        /// Flag to indicate if this metricDefinition allows filter based on initial direction
        /// </summary>
        /// <value>Flag to indicate if this metricDefinition allows filter based on initial direction</value>
        [DataMember(Name="initialDirectionFilteringAllowed", EmitDefaultValue=false)]
        public bool? InitialDirectionFilteringAllowed { get; set; }



        /// <summary>
        /// Flag to indicate if this metricDefinition allows filter based on queues
        /// </summary>
        /// <value>Flag to indicate if this metricDefinition allows filter based on queues</value>
        [DataMember(Name="queueFilteringAllowed", EmitDefaultValue=false)]
        public bool? QueueFilteringAllowed { get; set; }



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
            sb.Append("class MetricDefinition {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  DividendMetrics: ").Append(DividendMetrics).Append("\n");
            sb.Append("  DivisorMetrics: ").Append(DivisorMetrics).Append("\n");
            sb.Append("  DefaultObjective: ").Append(DefaultObjective).Append("\n");
            sb.Append("  LockTemplateId: ").Append(LockTemplateId).Append("\n");
            sb.Append("  MediaTypeFilteringAllowed: ").Append(MediaTypeFilteringAllowed).Append("\n");
            sb.Append("  InitialDirectionFilteringAllowed: ").Append(InitialDirectionFilteringAllowed).Append("\n");
            sb.Append("  QueueFilteringAllowed: ").Append(QueueFilteringAllowed).Append("\n");
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
            return this.Equals(obj as MetricDefinition);
        }

        /// <summary>
        /// Returns true if MetricDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of MetricDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricDefinition other)
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
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
                ) &&
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) &&
                (
                    this.DividendMetrics == other.DividendMetrics ||
                    this.DividendMetrics != null &&
                    this.DividendMetrics.SequenceEqual(other.DividendMetrics)
                ) &&
                (
                    this.DivisorMetrics == other.DivisorMetrics ||
                    this.DivisorMetrics != null &&
                    this.DivisorMetrics.SequenceEqual(other.DivisorMetrics)
                ) &&
                (
                    this.DefaultObjective == other.DefaultObjective ||
                    this.DefaultObjective != null &&
                    this.DefaultObjective.Equals(other.DefaultObjective)
                ) &&
                (
                    this.LockTemplateId == other.LockTemplateId ||
                    this.LockTemplateId != null &&
                    this.LockTemplateId.Equals(other.LockTemplateId)
                ) &&
                (
                    this.MediaTypeFilteringAllowed == other.MediaTypeFilteringAllowed ||
                    this.MediaTypeFilteringAllowed != null &&
                    this.MediaTypeFilteringAllowed.Equals(other.MediaTypeFilteringAllowed)
                ) &&
                (
                    this.InitialDirectionFilteringAllowed == other.InitialDirectionFilteringAllowed ||
                    this.InitialDirectionFilteringAllowed != null &&
                    this.InitialDirectionFilteringAllowed.Equals(other.InitialDirectionFilteringAllowed)
                ) &&
                (
                    this.QueueFilteringAllowed == other.QueueFilteringAllowed ||
                    this.QueueFilteringAllowed != null &&
                    this.QueueFilteringAllowed.Equals(other.QueueFilteringAllowed)
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

                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();

                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();

                if (this.DividendMetrics != null)
                    hash = hash * 59 + this.DividendMetrics.GetHashCode();

                if (this.DivisorMetrics != null)
                    hash = hash * 59 + this.DivisorMetrics.GetHashCode();

                if (this.DefaultObjective != null)
                    hash = hash * 59 + this.DefaultObjective.GetHashCode();

                if (this.LockTemplateId != null)
                    hash = hash * 59 + this.LockTemplateId.GetHashCode();

                if (this.MediaTypeFilteringAllowed != null)
                    hash = hash * 59 + this.MediaTypeFilteringAllowed.GetHashCode();

                if (this.InitialDirectionFilteringAllowed != null)
                    hash = hash * 59 + this.InitialDirectionFilteringAllowed.GetHashCode();

                if (this.QueueFilteringAllowed != null)
                    hash = hash * 59 + this.QueueFilteringAllowed.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
