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
    /// RoutingActivityMetricValue
    /// </summary>
    [DataContract]
    public partial class RoutingActivityMetricValue :  IEquatable<RoutingActivityMetricValue>
    {
        /// <summary>
        /// Metric
        /// </summary>
        /// <value>Metric</value>
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
            /// Enum Oactiveusers for "oActiveUsers"
            /// </summary>
            [EnumMember(Value = "oActiveUsers")]
            Oactiveusers,
            
            /// <summary>
            /// Enum Omemberusers for "oMemberUsers"
            /// </summary>
            [EnumMember(Value = "oMemberUsers")]
            Omemberusers,
            
            /// <summary>
            /// Enum Ooffqueueusers for "oOffQueueUsers"
            /// </summary>
            [EnumMember(Value = "oOffQueueUsers")]
            Ooffqueueusers,
            
            /// <summary>
            /// Enum Oonqueueusers for "oOnQueueUsers"
            /// </summary>
            [EnumMember(Value = "oOnQueueUsers")]
            Oonqueueusers,
            
            /// <summary>
            /// Enum Ouserpresences for "oUserPresences"
            /// </summary>
            [EnumMember(Value = "oUserPresences")]
            Ouserpresences,
            
            /// <summary>
            /// Enum Ouserroutingstatuses for "oUserRoutingStatuses"
            /// </summary>
            [EnumMember(Value = "oUserRoutingStatuses")]
            Ouserroutingstatuses
        }
        /// <summary>
        /// Metric
        /// </summary>
        /// <value>Metric</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingActivityMetricValue" /> class.
        /// </summary>
        /// <param name="Metric">Metric.</param>
        /// <param name="Qualifier">Metric qualifier.</param>
        /// <param name="SecondaryQualifier">Secondary metric qualifier.</param>
        /// <param name="EntityIds">Entity ids for matching entities if details were requested.</param>
        /// <param name="Count">Metric count.</param>
        public RoutingActivityMetricValue(MetricEnum? Metric = null, string Qualifier = null, string SecondaryQualifier = null, List<string> EntityIds = null, int? Count = null)
        {
            this.Metric = Metric;
            this.Qualifier = Qualifier;
            this.SecondaryQualifier = SecondaryQualifier;
            this.EntityIds = EntityIds;
            this.Count = Count;
            
        }
        




        /// <summary>
        /// Metric qualifier
        /// </summary>
        /// <value>Metric qualifier</value>
        [DataMember(Name="qualifier", EmitDefaultValue=false)]
        public string Qualifier { get; set; }



        /// <summary>
        /// Secondary metric qualifier
        /// </summary>
        /// <value>Secondary metric qualifier</value>
        [DataMember(Name="secondaryQualifier", EmitDefaultValue=false)]
        public string SecondaryQualifier { get; set; }



        /// <summary>
        /// Entity ids for matching entities if details were requested
        /// </summary>
        /// <value>Entity ids for matching entities if details were requested</value>
        [DataMember(Name="entityIds", EmitDefaultValue=false)]
        public List<string> EntityIds { get; set; }



        /// <summary>
        /// Metric count
        /// </summary>
        /// <value>Metric count</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingActivityMetricValue {\n");

            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Qualifier: ").Append(Qualifier).Append("\n");
            sb.Append("  SecondaryQualifier: ").Append(SecondaryQualifier).Append("\n");
            sb.Append("  EntityIds: ").Append(EntityIds).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as RoutingActivityMetricValue);
        }

        /// <summary>
        /// Returns true if RoutingActivityMetricValue instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingActivityMetricValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingActivityMetricValue other)
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
                    this.Qualifier == other.Qualifier ||
                    this.Qualifier != null &&
                    this.Qualifier.Equals(other.Qualifier)
                ) &&
                (
                    this.SecondaryQualifier == other.SecondaryQualifier ||
                    this.SecondaryQualifier != null &&
                    this.SecondaryQualifier.Equals(other.SecondaryQualifier)
                ) &&
                (
                    this.EntityIds == other.EntityIds ||
                    this.EntityIds != null &&
                    this.EntityIds.SequenceEqual(other.EntityIds)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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

                if (this.Qualifier != null)
                    hash = hash * 59 + this.Qualifier.GetHashCode();

                if (this.SecondaryQualifier != null)
                    hash = hash * 59 + this.SecondaryQualifier.GetHashCode();

                if (this.EntityIds != null)
                    hash = hash * 59 + this.EntityIds.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
