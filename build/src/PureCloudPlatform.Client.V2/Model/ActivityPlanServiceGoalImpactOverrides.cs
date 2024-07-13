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
    /// ActivityPlanServiceGoalImpactOverrides
    /// </summary>
    [DataContract]
    public partial class ActivityPlanServiceGoalImpactOverrides :  IEquatable<ActivityPlanServiceGoalImpactOverrides>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanServiceGoalImpactOverrides" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanServiceGoalImpactOverrides() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanServiceGoalImpactOverrides" /> class.
        /// </summary>
        /// <param name="AbandonRate">Abandon rate service goal override for the associated activity plan (required).</param>
        /// <param name="ServiceLevel">Service level goal override for the associated activity plan (required).</param>
        /// <param name="AverageSpeedOfAnswer">Average speed of answer service goal override for the associated activity plan (required).</param>
        public ActivityPlanServiceGoalImpactOverrides(ActivityPlanAbandonRateImpactOverride AbandonRate = null, ActivityPlanServiceLevelImpactOverride ServiceLevel = null, ActivityPlanAsaImpactOverride AverageSpeedOfAnswer = null)
        {
            this.AbandonRate = AbandonRate;
            this.ServiceLevel = ServiceLevel;
            this.AverageSpeedOfAnswer = AverageSpeedOfAnswer;
            
        }
        


        /// <summary>
        /// Abandon rate service goal override for the associated activity plan
        /// </summary>
        /// <value>Abandon rate service goal override for the associated activity plan</value>
        [DataMember(Name="abandonRate", EmitDefaultValue=false)]
        public ActivityPlanAbandonRateImpactOverride AbandonRate { get; set; }



        /// <summary>
        /// Service level goal override for the associated activity plan
        /// </summary>
        /// <value>Service level goal override for the associated activity plan</value>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public ActivityPlanServiceLevelImpactOverride ServiceLevel { get; set; }



        /// <summary>
        /// Average speed of answer service goal override for the associated activity plan
        /// </summary>
        /// <value>Average speed of answer service goal override for the associated activity plan</value>
        [DataMember(Name="averageSpeedOfAnswer", EmitDefaultValue=false)]
        public ActivityPlanAsaImpactOverride AverageSpeedOfAnswer { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanServiceGoalImpactOverrides {\n");

            sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  AverageSpeedOfAnswer: ").Append(AverageSpeedOfAnswer).Append("\n");
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
            return this.Equals(obj as ActivityPlanServiceGoalImpactOverrides);
        }

        /// <summary>
        /// Returns true if ActivityPlanServiceGoalImpactOverrides instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanServiceGoalImpactOverrides to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanServiceGoalImpactOverrides other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AbandonRate == other.AbandonRate ||
                    this.AbandonRate != null &&
                    this.AbandonRate.Equals(other.AbandonRate)
                ) &&
                (
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
                ) &&
                (
                    this.AverageSpeedOfAnswer == other.AverageSpeedOfAnswer ||
                    this.AverageSpeedOfAnswer != null &&
                    this.AverageSpeedOfAnswer.Equals(other.AverageSpeedOfAnswer)
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
                if (this.AbandonRate != null)
                    hash = hash * 59 + this.AbandonRate.GetHashCode();

                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();

                if (this.AverageSpeedOfAnswer != null)
                    hash = hash * 59 + this.AverageSpeedOfAnswer.GetHashCode();

                return hash;
            }
        }
    }

}
