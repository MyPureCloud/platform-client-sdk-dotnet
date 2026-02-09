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
    /// TaskManagementObservationDataContainer
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationDataContainer :  IEquatable<TaskManagementObservationDataContainer>
    {
        /// <summary>
        /// The metric for this data point
        /// </summary>
        /// <value>The metric for this data point</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oworkitemsunassigned for "oWorkitemsUnassigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemsUnassigned")]
            Oworkitemsunassigned,
            
            /// <summary>
            /// Enum Oworkitemsassigned for "oWorkitemsAssigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemsAssigned")]
            Oworkitemsassigned,
            
            /// <summary>
            /// Enum Oworkitemsconnected for "oWorkitemsConnected"
            /// </summary>
            [EnumMember(Value = "oWorkitemsConnected")]
            Oworkitemsconnected,
            
            /// <summary>
            /// Enum Oworkitemsparked for "oWorkitemsParked"
            /// </summary>
            [EnumMember(Value = "oWorkitemsParked")]
            Oworkitemsparked,
            
            /// <summary>
            /// Enum Oworkitemsheld for "oWorkitemsHeld"
            /// </summary>
            [EnumMember(Value = "oWorkitemsHeld")]
            Oworkitemsheld,
            
            /// <summary>
            /// Enum Oworkitemsacdstarted for "oWorkitemsAcdStarted"
            /// </summary>
            [EnumMember(Value = "oWorkitemsAcdStarted")]
            Oworkitemsacdstarted,
            
            /// <summary>
            /// Enum Oworkitemsdeclined for "oWorkitemsDeclined"
            /// </summary>
            [EnumMember(Value = "oWorkitemsDeclined")]
            Oworkitemsdeclined,
            
            /// <summary>
            /// Enum Oworkitemsidle for "oWorkitemsIdle"
            /// </summary>
            [EnumMember(Value = "oWorkitemsIdle")]
            Oworkitemsidle,
            
            /// <summary>
            /// Enum Oworkitemsdisconnected for "oWorkitemsDisconnected"
            /// </summary>
            [EnumMember(Value = "oWorkitemsDisconnected")]
            Oworkitemsdisconnected,
            
            /// <summary>
            /// Enum Oworkitemsacdexpired for "oWorkitemsAcdExpired"
            /// </summary>
            [EnumMember(Value = "oWorkitemsAcdExpired")]
            Oworkitemsacdexpired,
            
            /// <summary>
            /// Enum Oworkitemsdue for "oWorkitemsDue"
            /// </summary>
            [EnumMember(Value = "oWorkitemsDue")]
            Oworkitemsdue,
            
            /// <summary>
            /// Enum Oworkitemsoverdue for "oWorkitemsOverDue"
            /// </summary>
            [EnumMember(Value = "oWorkitemsOverDue")]
            Oworkitemsoverdue,
            
            /// <summary>
            /// Enum Oworkitemoldestunassigned for "oWorkitemOldestUnassigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemOldestUnassigned")]
            Oworkitemoldestunassigned,
            
            /// <summary>
            /// Enum Oworkitemoldestassigned for "oWorkitemOldestAssigned"
            /// </summary>
            [EnumMember(Value = "oWorkitemOldestAssigned")]
            Oworkitemoldestassigned
        }
        /// <summary>
        /// Qualifier for duration based metrics.
        /// </summary>
        /// <value>Qualifier for duration based metrics.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QualifierEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hours24 for "Hours24"
            /// </summary>
            [EnumMember(Value = "Hours24")]
            Hours24,
            
            /// <summary>
            /// Enum Hours72 for "Hours72"
            /// </summary>
            [EnumMember(Value = "Hours72")]
            Hours72
        }
        /// <summary>
        /// The metric for this data point
        /// </summary>
        /// <value>The metric for this data point</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// Qualifier for duration based metrics.
        /// </summary>
        /// <value>Qualifier for duration based metrics.</value>
        [DataMember(Name="qualifier", EmitDefaultValue=false)]
        public QualifierEnum? Qualifier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationDataContainer" /> class.
        /// </summary>
        /// <param name="Metric">The metric for this data point.</param>
        /// <param name="Stats">The observed statistics for this metric.</param>
        /// <param name="Qualifier">Qualifier for duration based metrics..</param>
        public TaskManagementObservationDataContainer(MetricEnum? Metric = null, TaskManagementObservationMetricStats Stats = null, QualifierEnum? Qualifier = null)
        {
            this.Metric = Metric;
            this.Stats = Stats;
            this.Qualifier = Qualifier;
            
        }
        




        /// <summary>
        /// The observed statistics for this metric
        /// </summary>
        /// <value>The observed statistics for this metric</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public TaskManagementObservationMetricStats Stats { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationDataContainer {\n");

            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationDataContainer);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationDataContainer instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationDataContainer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationDataContainer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Stats == other.Stats ||
                    this.Stats != null &&
                    this.Stats.Equals(other.Stats)
                ) &&
                (
                    this.Qualifier == other.Qualifier ||
                    this.Qualifier != null &&
                    this.Qualifier.Equals(other.Qualifier)
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
                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.Stats != null)
                    hash = hash * 59 + this.Stats.GetHashCode();

                if (this.Qualifier != null)
                    hash = hash * 59 + this.Qualifier.GetHashCode();

                return hash;
            }
        }
    }

}
