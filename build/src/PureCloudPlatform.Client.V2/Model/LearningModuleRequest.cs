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
    /// Learning module request
    /// </summary>
    [DataContract]
    public partial class LearningModuleRequest :  IEquatable<LearningModuleRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningModuleRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModuleRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of learning module (required).</param>
        /// <param name="Description">The description of learning module.</param>
        /// <param name="CompletionTimeInDays">The completion time of learning module in days (required).</param>
        /// <param name="InformSteps">The list of inform steps in a learning module.</param>
        public LearningModuleRequest(string Name = null, string Description = null, int? CompletionTimeInDays = null, List<LearningModuleInformStepRequest> InformSteps = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.CompletionTimeInDays = CompletionTimeInDays;
            this.InformSteps = InformSteps;
            
        }
        
        
        
        /// <summary>
        /// The name of learning module
        /// </summary>
        /// <value>The name of learning module</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The description of learning module
        /// </summary>
        /// <value>The description of learning module</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The completion time of learning module in days
        /// </summary>
        /// <value>The completion time of learning module in days</value>
        [DataMember(Name="completionTimeInDays", EmitDefaultValue=false)]
        public int? CompletionTimeInDays { get; set; }
        
        
        
        /// <summary>
        /// The list of inform steps in a learning module
        /// </summary>
        /// <value>The list of inform steps in a learning module</value>
        [DataMember(Name="informSteps", EmitDefaultValue=false)]
        public List<LearningModuleInformStepRequest> InformSteps { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningModuleRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CompletionTimeInDays: ").Append(CompletionTimeInDays).Append("\n");
            sb.Append("  InformSteps: ").Append(InformSteps).Append("\n");
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
            return this.Equals(obj as LearningModuleRequest);
        }

        /// <summary>
        /// Returns true if LearningModuleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModuleRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.CompletionTimeInDays == other.CompletionTimeInDays ||
                    this.CompletionTimeInDays != null &&
                    this.CompletionTimeInDays.Equals(other.CompletionTimeInDays)
                ) &&
                (
                    this.InformSteps == other.InformSteps ||
                    this.InformSteps != null &&
                    this.InformSteps.SequenceEqual(other.InformSteps)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.CompletionTimeInDays != null)
                    hash = hash * 59 + this.CompletionTimeInDays.GetHashCode();
                
                if (this.InformSteps != null)
                    hash = hash * 59 + this.InformSteps.GetHashCode();
                
                return hash;
            }
        }
    }

}
