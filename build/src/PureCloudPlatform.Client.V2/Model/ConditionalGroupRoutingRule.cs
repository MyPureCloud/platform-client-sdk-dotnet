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
    /// ConditionalGroupRoutingRule
    /// </summary>
    [DataContract]
    public partial class ConditionalGroupRoutingRule :  IEquatable<ConditionalGroupRoutingRule>
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
        /// Initializes a new instance of the <see cref="ConditionalGroupRoutingRule" /> class.
        /// </summary>
        /// <param name="Queue">The queue being evaluated for this rule.  For rule 1, this is always the current queue, so should not be specified..</param>
        /// <param name="Metric">The queue metric being evaluated.</param>
        /// <param name="Operator">The operator that compares the actual value against the condition value.</param>
        /// <param name="ConditionValue">The limit value, beyond which a rule evaluates as true.</param>
        /// <param name="Groups">The group(s) to activate if the rule evaluates as true.</param>
        /// <param name="WaitSeconds">The number of seconds to wait in this rule, if it evaluates as true, before evaluating the next rule.  For the final rule, this is ignored, so need not be specified..</param>
        public ConditionalGroupRoutingRule(DomainEntityRef Queue = null, MetricEnum? Metric = null, OperatorEnum? Operator = null, double? ConditionValue = null, List<MemberGroup> Groups = null, int? WaitSeconds = null)
        {
            this.Queue = Queue;
            this.Metric = Metric;
            this.Operator = Operator;
            this.ConditionValue = ConditionValue;
            this.Groups = Groups;
            this.WaitSeconds = WaitSeconds;
            
        }
        


        /// <summary>
        /// The queue being evaluated for this rule.  For rule 1, this is always the current queue, so should not be specified.
        /// </summary>
        /// <value>The queue being evaluated for this rule.  For rule 1, this is always the current queue, so should not be specified.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public DomainEntityRef Queue { get; set; }







        /// <summary>
        /// The limit value, beyond which a rule evaluates as true
        /// </summary>
        /// <value>The limit value, beyond which a rule evaluates as true</value>
        [DataMember(Name="conditionValue", EmitDefaultValue=false)]
        public double? ConditionValue { get; set; }



        /// <summary>
        /// The group(s) to activate if the rule evaluates as true
        /// </summary>
        /// <value>The group(s) to activate if the rule evaluates as true</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<MemberGroup> Groups { get; set; }



        /// <summary>
        /// The number of seconds to wait in this rule, if it evaluates as true, before evaluating the next rule.  For the final rule, this is ignored, so need not be specified.
        /// </summary>
        /// <value>The number of seconds to wait in this rule, if it evaluates as true, before evaluating the next rule.  For the final rule, this is ignored, so need not be specified.</value>
        [DataMember(Name="waitSeconds", EmitDefaultValue=false)]
        public int? WaitSeconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalGroupRoutingRule {\n");

            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  ConditionValue: ").Append(ConditionValue).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  WaitSeconds: ").Append(WaitSeconds).Append("\n");
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
            return this.Equals(obj as ConditionalGroupRoutingRule);
        }

        /// <summary>
        /// Returns true if ConditionalGroupRoutingRule instances are equal
        /// </summary>
        /// <param name="other">Instance of ConditionalGroupRoutingRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionalGroupRoutingRule other)
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
                    this.ConditionValue == other.ConditionValue ||
                    this.ConditionValue != null &&
                    this.ConditionValue.Equals(other.ConditionValue)
                ) &&
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) &&
                (
                    this.WaitSeconds == other.WaitSeconds ||
                    this.WaitSeconds != null &&
                    this.WaitSeconds.Equals(other.WaitSeconds)
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

                if (this.ConditionValue != null)
                    hash = hash * 59 + this.ConditionValue.GetHashCode();

                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();

                if (this.WaitSeconds != null)
                    hash = hash * 59 + this.WaitSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
