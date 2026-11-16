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
    /// V2QueueAnomalyEventConsensusAnalysis
    /// </summary>
    [DataContract]
    public partial class V2QueueAnomalyEventConsensusAnalysis :  IEquatable<V2QueueAnomalyEventConsensusAnalysis>
    {
        /// <summary>
        /// Gets or Sets ConsensusType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ConsensusTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Chronos for "Chronos"
            /// </summary>
            [EnumMember(Value = "Chronos")]
            Chronos,
            
            /// <summary>
            /// Enum Isolationforest for "IsolationForest"
            /// </summary>
            [EnumMember(Value = "IsolationForest")]
            Isolationforest,
            
            /// <summary>
            /// Enum Zscore for "ZScore"
            /// </summary>
            [EnumMember(Value = "ZScore")]
            Zscore
        }
        /// <summary>
        /// Gets or Sets ConsensusType
        /// </summary>
        [DataMember(Name="consensusType", EmitDefaultValue=false)]
        public ConsensusTypeEnum? ConsensusType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2QueueAnomalyEventConsensusAnalysis" /> class.
        /// </summary>
        /// <param name="ConsensusType">ConsensusType.</param>
        /// <param name="Anomalous">Anomalous.</param>
        /// <param name="LowerBound">LowerBound.</param>
        /// <param name="UpperBound">UpperBound.</param>
        /// <param name="ExpectedValue">ExpectedValue.</param>
        /// <param name="Deviation">Deviation.</param>
        public V2QueueAnomalyEventConsensusAnalysis(ConsensusTypeEnum? ConsensusType = null, bool? Anomalous = null, double? LowerBound = null, double? UpperBound = null, double? ExpectedValue = null, double? Deviation = null)
        {
            this.ConsensusType = ConsensusType;
            this.Anomalous = Anomalous;
            this.LowerBound = LowerBound;
            this.UpperBound = UpperBound;
            this.ExpectedValue = ExpectedValue;
            this.Deviation = Deviation;
            
        }
        




        /// <summary>
        /// Gets or Sets Anomalous
        /// </summary>
        [DataMember(Name="anomalous", EmitDefaultValue=false)]
        public bool? Anomalous { get; set; }



        /// <summary>
        /// Gets or Sets LowerBound
        /// </summary>
        [DataMember(Name="lowerBound", EmitDefaultValue=false)]
        public double? LowerBound { get; set; }



        /// <summary>
        /// Gets or Sets UpperBound
        /// </summary>
        [DataMember(Name="upperBound", EmitDefaultValue=false)]
        public double? UpperBound { get; set; }



        /// <summary>
        /// Gets or Sets ExpectedValue
        /// </summary>
        [DataMember(Name="expectedValue", EmitDefaultValue=false)]
        public double? ExpectedValue { get; set; }



        /// <summary>
        /// Gets or Sets Deviation
        /// </summary>
        [DataMember(Name="deviation", EmitDefaultValue=false)]
        public double? Deviation { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2QueueAnomalyEventConsensusAnalysis {\n");

            sb.Append("  ConsensusType: ").Append(ConsensusType).Append("\n");
            sb.Append("  Anomalous: ").Append(Anomalous).Append("\n");
            sb.Append("  LowerBound: ").Append(LowerBound).Append("\n");
            sb.Append("  UpperBound: ").Append(UpperBound).Append("\n");
            sb.Append("  ExpectedValue: ").Append(ExpectedValue).Append("\n");
            sb.Append("  Deviation: ").Append(Deviation).Append("\n");
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
            return this.Equals(obj as V2QueueAnomalyEventConsensusAnalysis);
        }

        /// <summary>
        /// Returns true if V2QueueAnomalyEventConsensusAnalysis instances are equal
        /// </summary>
        /// <param name="other">Instance of V2QueueAnomalyEventConsensusAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2QueueAnomalyEventConsensusAnalysis other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConsensusType == other.ConsensusType ||
                    this.ConsensusType != null &&
                    this.ConsensusType.Equals(other.ConsensusType)
                ) &&
                (
                    this.Anomalous == other.Anomalous ||
                    this.Anomalous != null &&
                    this.Anomalous.Equals(other.Anomalous)
                ) &&
                (
                    this.LowerBound == other.LowerBound ||
                    this.LowerBound != null &&
                    this.LowerBound.Equals(other.LowerBound)
                ) &&
                (
                    this.UpperBound == other.UpperBound ||
                    this.UpperBound != null &&
                    this.UpperBound.Equals(other.UpperBound)
                ) &&
                (
                    this.ExpectedValue == other.ExpectedValue ||
                    this.ExpectedValue != null &&
                    this.ExpectedValue.Equals(other.ExpectedValue)
                ) &&
                (
                    this.Deviation == other.Deviation ||
                    this.Deviation != null &&
                    this.Deviation.Equals(other.Deviation)
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
                if (this.ConsensusType != null)
                    hash = hash * 59 + this.ConsensusType.GetHashCode();

                if (this.Anomalous != null)
                    hash = hash * 59 + this.Anomalous.GetHashCode();

                if (this.LowerBound != null)
                    hash = hash * 59 + this.LowerBound.GetHashCode();

                if (this.UpperBound != null)
                    hash = hash * 59 + this.UpperBound.GetHashCode();

                if (this.ExpectedValue != null)
                    hash = hash * 59 + this.ExpectedValue.GetHashCode();

                if (this.Deviation != null)
                    hash = hash * 59 + this.Deviation.GetHashCode();

                return hash;
            }
        }
    }

}
