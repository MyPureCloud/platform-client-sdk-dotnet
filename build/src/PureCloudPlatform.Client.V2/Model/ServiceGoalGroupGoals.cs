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
    /// Goals defined for the service goal group
    /// </summary>
    [DataContract]
    public partial class ServiceGoalGroupGoals :  IEquatable<ServiceGoalGroupGoals>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceGoalGroupGoals" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceGoalGroupGoals() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceGoalGroupGoals" /> class.
        /// </summary>
        /// <param name="ServiceLevel">Service level targets for this service goal group (required).</param>
        /// <param name="AverageSpeedOfAnswer">Average speed of answer targets for this service goal group (required).</param>
        public ServiceGoalGroupGoals(WfmServiceLevel ServiceLevel = null, WfmAverageSpeedOfAnswer AverageSpeedOfAnswer = null)
        {
            this.ServiceLevel = ServiceLevel;
            this.AverageSpeedOfAnswer = AverageSpeedOfAnswer;
            
        }
        
        
        
        /// <summary>
        /// Service level targets for this service goal group
        /// </summary>
        /// <value>Service level targets for this service goal group</value>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public WfmServiceLevel ServiceLevel { get; set; }
        
        
        
        /// <summary>
        /// Average speed of answer targets for this service goal group
        /// </summary>
        /// <value>Average speed of answer targets for this service goal group</value>
        [DataMember(Name="averageSpeedOfAnswer", EmitDefaultValue=false)]
        public WfmAverageSpeedOfAnswer AverageSpeedOfAnswer { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceGoalGroupGoals {\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ServiceGoalGroupGoals);
        }

        /// <summary>
        /// Returns true if ServiceGoalGroupGoals instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceGoalGroupGoals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceGoalGroupGoals other)
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
                
                return hash;
            }
        }
    }

}
