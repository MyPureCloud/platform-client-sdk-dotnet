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
    /// ConditionalGroupRoutingCondition
    /// </summary>
    [DataContract]
    public partial class ConditionalGroupRoutingCondition :  IEquatable<ConditionalGroupRoutingCondition>
    {
        /// <summary>
        /// The queue metric being evaluated
        /// </summary>
        /// <value>The queue metric being evaluated</value>
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
            /// Enum Estimatedwaittime for "EstimatedWaitTime"
            /// </summary>
            [EnumMember(Value = "EstimatedWaitTime")]
            Estimatedwaittime,
            
            /// <summary>
            /// Enum Servicelevel for "ServiceLevel"
            /// </summary>
            [EnumMember(Value = "ServiceLevel")]
            Servicelevel
        }
        /// <summary>
        /// The operator that compares the actual value against the condition value
        /// </summary>
        /// <value>The operator that compares the actual value against the condition value</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Greaterthan for "GreaterThan"
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            Greaterthan,
            
            /// <summary>
            /// Enum Greaterthanorequalto for "GreaterThanOrEqualTo"
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqualTo")]
            Greaterthanorequalto,
            
            /// <summary>
            /// Enum Lessthan for "LessThan"
            /// </summary>
            [EnumMember(Value = "LessThan")]
            Lessthan,
            
            /// <summary>
            /// Enum Lessthanorequalto for "LessThanOrEqualTo"
            /// </summary>
            [EnumMember(Value = "LessThanOrEqualTo")]
            Lessthanorequalto
        }
        /// <summary>
        /// The queue metric being evaluated
        /// </summary>
        /// <value>The queue metric being evaluated</value>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public MetricEnum? Metric { get; set; }
        /// <summary>
        /// The operator that compares the actual value against the condition value
        /// </summary>
        /// <value>The operator that compares the actual value against the condition value</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalGroupRoutingCondition" /> class.
        /// </summary>
        /// <param name="Queue">The queue being evaluated for this rule.  If null, the current queue will be used..</param>
        /// <param name="Metric">The queue metric being evaluated.</param>
        /// <param name="Operator">The operator that compares the actual value against the condition value.</param>
        /// <param name="Value">The limit value, beyond which a rule evaluates as true.</param>
        public ConditionalGroupRoutingCondition(DomainEntityRef Queue = null, MetricEnum? Metric = null, OperatorEnum? Operator = null, double? Value = null)
        {
            this.Queue = Queue;
            this.Metric = Metric;
            this.Operator = Operator;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The queue being evaluated for this rule.  If null, the current queue will be used.
        /// </summary>
        /// <value>The queue being evaluated for this rule.  If null, the current queue will be used.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public DomainEntityRef Queue { get; set; }







        /// <summary>
        /// The limit value, beyond which a rule evaluates as true
        /// </summary>
        /// <value>The limit value, beyond which a rule evaluates as true</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalGroupRoutingCondition {\n");

            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as ConditionalGroupRoutingCondition);
        }

        /// <summary>
        /// Returns true if ConditionalGroupRoutingCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of ConditionalGroupRoutingCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionalGroupRoutingCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
