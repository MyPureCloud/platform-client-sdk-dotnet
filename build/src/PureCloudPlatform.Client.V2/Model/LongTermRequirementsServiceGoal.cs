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
    /// LongTermRequirementsServiceGoal
    /// </summary>
    [DataContract]
    public partial class LongTermRequirementsServiceGoal :  IEquatable<LongTermRequirementsServiceGoal>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirementsServiceGoal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LongTermRequirementsServiceGoal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LongTermRequirementsServiceGoal" /> class.
        /// </summary>
        /// <param name="UseAsaTarget">Toggle for target average speed of answer from service goals (required).</param>
        /// <param name="TargetAsaSec">Value of target average speed of answer from service goals (required).</param>
        /// <param name="UseServiceLevelTarget">Toggle for service level objective from service goals (required).</param>
        /// <param name="ServiceLevelObjectiveSeconds">Value of service level objective seconds from service goals (required).</param>
        /// <param name="ServiceLevelGoalPercent">Value of service level objective percent from service goals (required).</param>
        /// <param name="UseAbandonRateGoal">Toggle for abandon rate from service goals (required).</param>
        /// <param name="AbandonRateGoalPercent">Value of abandon rate objective (required).</param>
        public LongTermRequirementsServiceGoal(bool? UseAsaTarget = null, double? TargetAsaSec = null, bool? UseServiceLevelTarget = null, double? ServiceLevelObjectiveSeconds = null, double? ServiceLevelGoalPercent = null, bool? UseAbandonRateGoal = null, double? AbandonRateGoalPercent = null)
        {
            this.UseAsaTarget = UseAsaTarget;
            this.TargetAsaSec = TargetAsaSec;
            this.UseServiceLevelTarget = UseServiceLevelTarget;
            this.ServiceLevelObjectiveSeconds = ServiceLevelObjectiveSeconds;
            this.ServiceLevelGoalPercent = ServiceLevelGoalPercent;
            this.UseAbandonRateGoal = UseAbandonRateGoal;
            this.AbandonRateGoalPercent = AbandonRateGoalPercent;
            
        }
        


        /// <summary>
        /// Toggle for target average speed of answer from service goals
        /// </summary>
        /// <value>Toggle for target average speed of answer from service goals</value>
        [DataMember(Name="useAsaTarget", EmitDefaultValue=false)]
        public bool? UseAsaTarget { get; set; }



        /// <summary>
        /// Value of target average speed of answer from service goals
        /// </summary>
        /// <value>Value of target average speed of answer from service goals</value>
        [DataMember(Name="targetAsaSec", EmitDefaultValue=false)]
        public double? TargetAsaSec { get; set; }



        /// <summary>
        /// Toggle for service level objective from service goals
        /// </summary>
        /// <value>Toggle for service level objective from service goals</value>
        [DataMember(Name="useServiceLevelTarget", EmitDefaultValue=false)]
        public bool? UseServiceLevelTarget { get; set; }



        /// <summary>
        /// Value of service level objective seconds from service goals
        /// </summary>
        /// <value>Value of service level objective seconds from service goals</value>
        [DataMember(Name="serviceLevelObjectiveSeconds", EmitDefaultValue=false)]
        public double? ServiceLevelObjectiveSeconds { get; set; }



        /// <summary>
        /// Value of service level objective percent from service goals
        /// </summary>
        /// <value>Value of service level objective percent from service goals</value>
        [DataMember(Name="serviceLevelGoalPercent", EmitDefaultValue=false)]
        public double? ServiceLevelGoalPercent { get; set; }



        /// <summary>
        /// Toggle for abandon rate from service goals
        /// </summary>
        /// <value>Toggle for abandon rate from service goals</value>
        [DataMember(Name="useAbandonRateGoal", EmitDefaultValue=false)]
        public bool? UseAbandonRateGoal { get; set; }



        /// <summary>
        /// Value of abandon rate objective
        /// </summary>
        /// <value>Value of abandon rate objective</value>
        [DataMember(Name="abandonRateGoalPercent", EmitDefaultValue=false)]
        public double? AbandonRateGoalPercent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LongTermRequirementsServiceGoal {\n");

            sb.Append("  UseAsaTarget: ").Append(UseAsaTarget).Append("\n");
            sb.Append("  TargetAsaSec: ").Append(TargetAsaSec).Append("\n");
            sb.Append("  UseServiceLevelTarget: ").Append(UseServiceLevelTarget).Append("\n");
            sb.Append("  ServiceLevelObjectiveSeconds: ").Append(ServiceLevelObjectiveSeconds).Append("\n");
            sb.Append("  ServiceLevelGoalPercent: ").Append(ServiceLevelGoalPercent).Append("\n");
            sb.Append("  UseAbandonRateGoal: ").Append(UseAbandonRateGoal).Append("\n");
            sb.Append("  AbandonRateGoalPercent: ").Append(AbandonRateGoalPercent).Append("\n");
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
            return this.Equals(obj as LongTermRequirementsServiceGoal);
        }

        /// <summary>
        /// Returns true if LongTermRequirementsServiceGoal instances are equal
        /// </summary>
        /// <param name="other">Instance of LongTermRequirementsServiceGoal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LongTermRequirementsServiceGoal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UseAsaTarget == other.UseAsaTarget ||
                    this.UseAsaTarget != null &&
                    this.UseAsaTarget.Equals(other.UseAsaTarget)
                ) &&
                (
                    this.TargetAsaSec == other.TargetAsaSec ||
                    this.TargetAsaSec != null &&
                    this.TargetAsaSec.Equals(other.TargetAsaSec)
                ) &&
                (
                    this.UseServiceLevelTarget == other.UseServiceLevelTarget ||
                    this.UseServiceLevelTarget != null &&
                    this.UseServiceLevelTarget.Equals(other.UseServiceLevelTarget)
                ) &&
                (
                    this.ServiceLevelObjectiveSeconds == other.ServiceLevelObjectiveSeconds ||
                    this.ServiceLevelObjectiveSeconds != null &&
                    this.ServiceLevelObjectiveSeconds.Equals(other.ServiceLevelObjectiveSeconds)
                ) &&
                (
                    this.ServiceLevelGoalPercent == other.ServiceLevelGoalPercent ||
                    this.ServiceLevelGoalPercent != null &&
                    this.ServiceLevelGoalPercent.Equals(other.ServiceLevelGoalPercent)
                ) &&
                (
                    this.UseAbandonRateGoal == other.UseAbandonRateGoal ||
                    this.UseAbandonRateGoal != null &&
                    this.UseAbandonRateGoal.Equals(other.UseAbandonRateGoal)
                ) &&
                (
                    this.AbandonRateGoalPercent == other.AbandonRateGoalPercent ||
                    this.AbandonRateGoalPercent != null &&
                    this.AbandonRateGoalPercent.Equals(other.AbandonRateGoalPercent)
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
                if (this.UseAsaTarget != null)
                    hash = hash * 59 + this.UseAsaTarget.GetHashCode();

                if (this.TargetAsaSec != null)
                    hash = hash * 59 + this.TargetAsaSec.GetHashCode();

                if (this.UseServiceLevelTarget != null)
                    hash = hash * 59 + this.UseServiceLevelTarget.GetHashCode();

                if (this.ServiceLevelObjectiveSeconds != null)
                    hash = hash * 59 + this.ServiceLevelObjectiveSeconds.GetHashCode();

                if (this.ServiceLevelGoalPercent != null)
                    hash = hash * 59 + this.ServiceLevelGoalPercent.GetHashCode();

                if (this.UseAbandonRateGoal != null)
                    hash = hash * 59 + this.UseAbandonRateGoal.GetHashCode();

                if (this.AbandonRateGoalPercent != null)
                    hash = hash * 59 + this.AbandonRateGoalPercent.GetHashCode();

                return hash;
            }
        }
    }

}
