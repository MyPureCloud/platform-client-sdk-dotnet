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
    /// UserObservationQuery
    /// </summary>
    [DataContract]
    public partial class UserObservationQuery :  IEquatable<UserObservationQuery>
    {
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oactivequeues for "oActiveQueues"
            /// </summary>
            [EnumMember(Value = "oActiveQueues")]
            Oactivequeues,
            
            /// <summary>
            /// Enum Omemberqueues for "oMemberQueues"
            /// </summary>
            [EnumMember(Value = "oMemberQueues")]
            Omemberqueues
        }
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DetailMetrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DetailMetricsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oactivequeues for "oActiveQueues"
            /// </summary>
            [EnumMember(Value = "oActiveQueues")]
            Oactivequeues,
            
            /// <summary>
            /// Enum Omemberqueues for "oMemberQueues"
            /// </summary>
            [EnumMember(Value = "oMemberQueues")]
            Omemberqueues
        }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserObservationQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserObservationQuery() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserObservationQuery" /> class.
        /// </summary>
        /// <param name="Filter">Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters (required).</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
        /// <param name="DetailMetrics">Metrics for which to include additional detailed observations.</param>
        public UserObservationQuery(UserObservationQueryFilter Filter = null, List<MetricsEnum> Metrics = null, List<DetailMetricsEnum> DetailMetrics = null)
        {
            this.Filter = Filter;
            this.Metrics = Metrics;
            this.DetailMetrics = DetailMetrics;
            
        }
        
        
        
        /// <summary>
        /// Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters
        /// </summary>
        /// <value>Filter to return a subset of observations. Expresses boolean logical predicates as well as dimensional filters</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public UserObservationQueryFilter Filter { get; set; }
        
        
        
        /// <summary>
        /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }
        
        
        
        /// <summary>
        /// Metrics for which to include additional detailed observations
        /// </summary>
        /// <value>Metrics for which to include additional detailed observations</value>
        [DataMember(Name="detailMetrics", EmitDefaultValue=false)]
        public List<DetailMetricsEnum> DetailMetrics { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserObservationQuery {\n");
            
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  DetailMetrics: ").Append(DetailMetrics).Append("\n");
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
            return this.Equals(obj as UserObservationQuery);
        }

        /// <summary>
        /// Returns true if UserObservationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of UserObservationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserObservationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.DetailMetrics == other.DetailMetrics ||
                    this.DetailMetrics != null &&
                    this.DetailMetrics.SequenceEqual(other.DetailMetrics)
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
                
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                
                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();
                
                if (this.DetailMetrics != null)
                    hash = hash * 59 + this.DetailMetrics.GetHashCode();
                
                return hash;
            }
        }
    }

}
