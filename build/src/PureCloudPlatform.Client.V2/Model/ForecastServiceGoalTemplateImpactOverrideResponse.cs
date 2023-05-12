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
    /// ForecastServiceGoalTemplateImpactOverrideResponse
    /// </summary>
    [DataContract]
    public partial class ForecastServiceGoalTemplateImpactOverrideResponse :  IEquatable<ForecastServiceGoalTemplateImpactOverrideResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastServiceGoalTemplateImpactOverrideResponse" /> class.
        /// </summary>
        /// <param name="ServiceLevel">Allowed service level percent increase and decrease; undefined if the goal is not enabled.</param>
        /// <param name="AverageSpeedOfAnswer">Allowed average speed of answer percent increase and decrease; undefined if the goal is not enabled.</param>
        /// <param name="AbandonRate">Allowed abandon rate percent increase and decrease; undefined if the goal is not enabled.</param>
        public ForecastServiceGoalTemplateImpactOverrideResponse(WfmServiceGoalImpact ServiceLevel = null, WfmServiceGoalImpact AverageSpeedOfAnswer = null, WfmServiceGoalImpact AbandonRate = null)
        {
            this.ServiceLevel = ServiceLevel;
            this.AverageSpeedOfAnswer = AverageSpeedOfAnswer;
            this.AbandonRate = AbandonRate;
            
        }
        


        /// <summary>
        /// Allowed service level percent increase and decrease; undefined if the goal is not enabled
        /// </summary>
        /// <value>Allowed service level percent increase and decrease; undefined if the goal is not enabled</value>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public WfmServiceGoalImpact ServiceLevel { get; set; }



        /// <summary>
        /// Allowed average speed of answer percent increase and decrease; undefined if the goal is not enabled
        /// </summary>
        /// <value>Allowed average speed of answer percent increase and decrease; undefined if the goal is not enabled</value>
        [DataMember(Name="averageSpeedOfAnswer", EmitDefaultValue=false)]
        public WfmServiceGoalImpact AverageSpeedOfAnswer { get; set; }



        /// <summary>
        /// Allowed abandon rate percent increase and decrease; undefined if the goal is not enabled
        /// </summary>
        /// <value>Allowed abandon rate percent increase and decrease; undefined if the goal is not enabled</value>
        [DataMember(Name="abandonRate", EmitDefaultValue=false)]
        public WfmServiceGoalImpact AbandonRate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastServiceGoalTemplateImpactOverrideResponse {\n");

            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  AverageSpeedOfAnswer: ").Append(AverageSpeedOfAnswer).Append("\n");
            sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
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
            return this.Equals(obj as ForecastServiceGoalTemplateImpactOverrideResponse);
        }

        /// <summary>
        /// Returns true if ForecastServiceGoalTemplateImpactOverrideResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastServiceGoalTemplateImpactOverrideResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastServiceGoalTemplateImpactOverrideResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
                ) &&
                (
                    this.AverageSpeedOfAnswer == other.AverageSpeedOfAnswer ||
                    this.AverageSpeedOfAnswer != null &&
                    this.AverageSpeedOfAnswer.Equals(other.AverageSpeedOfAnswer)
                ) &&
                (
                    this.AbandonRate == other.AbandonRate ||
                    this.AbandonRate != null &&
                    this.AbandonRate.Equals(other.AbandonRate)
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
                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();

                if (this.AverageSpeedOfAnswer != null)
                    hash = hash * 59 + this.AverageSpeedOfAnswer.GetHashCode();

                if (this.AbandonRate != null)
                    hash = hash * 59 + this.AbandonRate.GetHashCode();

                return hash;
            }
        }
    }

}
