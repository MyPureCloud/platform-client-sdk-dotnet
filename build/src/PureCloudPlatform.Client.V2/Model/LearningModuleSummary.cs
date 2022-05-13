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
    /// Learning module summary data
    /// </summary>
    [DataContract]
    public partial class LearningModuleSummary :  IEquatable<LearningModuleSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleSummary" /> class.
        /// </summary>
        /// <param name="AssignedCount">The total number of assignments assigned for a learning module.</param>
        /// <param name="CompletedCount">The number of assignments completed for a learning module.</param>
        /// <param name="PassedCount">The number of assignments passed for a learning module.</param>
        /// <param name="CompletedSum">The sum of assignment scores for a learning module.</param>
        public LearningModuleSummary(int? AssignedCount = null, int? CompletedCount = null, int? PassedCount = null, float? CompletedSum = null)
        {
            this.AssignedCount = AssignedCount;
            this.CompletedCount = CompletedCount;
            this.PassedCount = PassedCount;
            this.CompletedSum = CompletedSum;
            
        }
        


        /// <summary>
        /// The total number of assignments assigned for a learning module
        /// </summary>
        /// <value>The total number of assignments assigned for a learning module</value>
        [DataMember(Name="assignedCount", EmitDefaultValue=false)]
        public int? AssignedCount { get; set; }



        /// <summary>
        /// The number of assignments completed for a learning module
        /// </summary>
        /// <value>The number of assignments completed for a learning module</value>
        [DataMember(Name="completedCount", EmitDefaultValue=false)]
        public int? CompletedCount { get; set; }



        /// <summary>
        /// The number of assignments passed for a learning module
        /// </summary>
        /// <value>The number of assignments passed for a learning module</value>
        [DataMember(Name="passedCount", EmitDefaultValue=false)]
        public int? PassedCount { get; set; }



        /// <summary>
        /// The sum of assignment scores for a learning module
        /// </summary>
        /// <value>The sum of assignment scores for a learning module</value>
        [DataMember(Name="completedSum", EmitDefaultValue=false)]
        public float? CompletedSum { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModuleSummary {\n");

            sb.Append("  AssignedCount: ").Append(AssignedCount).Append("\n");
            sb.Append("  CompletedCount: ").Append(CompletedCount).Append("\n");
            sb.Append("  PassedCount: ").Append(PassedCount).Append("\n");
            sb.Append("  CompletedSum: ").Append(CompletedSum).Append("\n");
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
            return this.Equals(obj as LearningModuleSummary);
        }

        /// <summary>
        /// Returns true if LearningModuleSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModuleSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModuleSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AssignedCount == other.AssignedCount ||
                    this.AssignedCount != null &&
                    this.AssignedCount.Equals(other.AssignedCount)
                ) &&
                (
                    this.CompletedCount == other.CompletedCount ||
                    this.CompletedCount != null &&
                    this.CompletedCount.Equals(other.CompletedCount)
                ) &&
                (
                    this.PassedCount == other.PassedCount ||
                    this.PassedCount != null &&
                    this.PassedCount.Equals(other.PassedCount)
                ) &&
                (
                    this.CompletedSum == other.CompletedSum ||
                    this.CompletedSum != null &&
                    this.CompletedSum.Equals(other.CompletedSum)
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
                if (this.AssignedCount != null)
                    hash = hash * 59 + this.AssignedCount.GetHashCode();

                if (this.CompletedCount != null)
                    hash = hash * 59 + this.CompletedCount.GetHashCode();

                if (this.PassedCount != null)
                    hash = hash * 59 + this.PassedCount.GetHashCode();

                if (this.CompletedSum != null)
                    hash = hash * 59 + this.CompletedSum.GetHashCode();

                return hash;
            }
        }
    }

}
