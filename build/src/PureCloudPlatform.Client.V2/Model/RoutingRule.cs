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
    /// RoutingRule
    /// </summary>
    [DataContract]
    public partial class RoutingRule :  IEquatable<RoutingRule>
    {
        /// <summary>
        /// matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule's threshold.  ANY matches all specified agents, regardless of score.
        /// </summary>
        /// <value>matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule's threshold.  ANY matches all specified agents, regardless of score.</value>
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
            /// Enum MeetsThreshold for "MEETS_THRESHOLD"
            /// </summary>
            [EnumMember(Value = "MEETS_THRESHOLD")]
            MeetsThreshold,
            
            /// <summary>
            /// Enum Any for "ANY"
            /// </summary>
            [EnumMember(Value = "ANY")]
            Any
        }
        /// <summary>
        /// matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule's threshold.  ANY matches all specified agents, regardless of score.
        /// </summary>
        /// <value>matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule's threshold.  ANY matches all specified agents, regardless of score.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingRule" /> class.
        /// </summary>
        /// <param name="Operator">matching operator.  MEETS_THRESHOLD matches any agent with a score at or above the rule&#39;s threshold.  ANY matches all specified agents, regardless of score..</param>
        /// <param name="Threshold">threshold required for routing attempt (generally an agent score).  may be null for operator ANY..</param>
        /// <param name="WaitSeconds">seconds to wait in this rule before moving to the next.</param>
        public RoutingRule(OperatorEnum? Operator = null, int? Threshold = null, double? WaitSeconds = null)
        {
            this.Operator = Operator;
            this.Threshold = Threshold;
            this.WaitSeconds = WaitSeconds;
            
        }
        




        /// <summary>
        /// threshold required for routing attempt (generally an agent score).  may be null for operator ANY.
        /// </summary>
        /// <value>threshold required for routing attempt (generally an agent score).  may be null for operator ANY.</value>
        [DataMember(Name="threshold", EmitDefaultValue=false)]
        public int? Threshold { get; set; }



        /// <summary>
        /// seconds to wait in this rule before moving to the next
        /// </summary>
        /// <value>seconds to wait in this rule before moving to the next</value>
        [DataMember(Name="waitSeconds", EmitDefaultValue=false)]
        public double? WaitSeconds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingRule {\n");

            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
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
            return this.Equals(obj as RoutingRule);
        }

        /// <summary>
        /// Returns true if RoutingRule instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutingRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingRule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) &&
                (
                    this.Threshold == other.Threshold ||
                    this.Threshold != null &&
                    this.Threshold.Equals(other.Threshold)
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
                if (this.Operator != null)
                    hash = hash * 59 + this.Operator.GetHashCode();

                if (this.Threshold != null)
                    hash = hash * 59 + this.Threshold.GetHashCode();

                if (this.WaitSeconds != null)
                    hash = hash * 59 + this.WaitSeconds.GetHashCode();

                return hash;
            }
        }
    }

}
