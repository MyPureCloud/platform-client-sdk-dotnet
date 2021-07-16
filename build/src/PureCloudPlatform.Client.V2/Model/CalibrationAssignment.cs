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
    /// CalibrationAssignment
    /// </summary>
    [DataContract]
    public partial class CalibrationAssignment :  IEquatable<CalibrationAssignment>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CalibrationAssignment" /> class.
        /// </summary>
        /// <param name="Calibrator">Calibrator.</param>
        /// <param name="Evaluators">Evaluators.</param>
        /// <param name="EvaluationForm">EvaluationForm.</param>
        /// <param name="ExpertEvaluator">ExpertEvaluator.</param>
        public CalibrationAssignment(User Calibrator = null, List<User> Evaluators = null, EvaluationForm EvaluationForm = null, User ExpertEvaluator = null)
        {
            this.Calibrator = Calibrator;
            this.Evaluators = Evaluators;
            this.EvaluationForm = EvaluationForm;
            this.ExpertEvaluator = ExpertEvaluator;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Calibrator
        /// </summary>
        [DataMember(Name="calibrator", EmitDefaultValue=false)]
        public User Calibrator { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Evaluators
        /// </summary>
        [DataMember(Name="evaluators", EmitDefaultValue=false)]
        public List<User> Evaluators { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EvaluationForm
        /// </summary>
        [DataMember(Name="evaluationForm", EmitDefaultValue=false)]
        public EvaluationForm EvaluationForm { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExpertEvaluator
        /// </summary>
        [DataMember(Name="expertEvaluator", EmitDefaultValue=false)]
        public User ExpertEvaluator { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalibrationAssignment {\n");
            
            sb.Append("  Calibrator: ").Append(Calibrator).Append("\n");
            sb.Append("  Evaluators: ").Append(Evaluators).Append("\n");
            sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
            sb.Append("  ExpertEvaluator: ").Append(ExpertEvaluator).Append("\n");
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
            return this.Equals(obj as CalibrationAssignment);
        }

        /// <summary>
        /// Returns true if CalibrationAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of CalibrationAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalibrationAssignment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Calibrator == other.Calibrator ||
                    this.Calibrator != null &&
                    this.Calibrator.Equals(other.Calibrator)
                ) &&
                (
                    this.Evaluators == other.Evaluators ||
                    this.Evaluators != null &&
                    this.Evaluators.SequenceEqual(other.Evaluators)
                ) &&
                (
                    this.EvaluationForm == other.EvaluationForm ||
                    this.EvaluationForm != null &&
                    this.EvaluationForm.Equals(other.EvaluationForm)
                ) &&
                (
                    this.ExpertEvaluator == other.ExpertEvaluator ||
                    this.ExpertEvaluator != null &&
                    this.ExpertEvaluator.Equals(other.ExpertEvaluator)
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
                
                if (this.Calibrator != null)
                    hash = hash * 59 + this.Calibrator.GetHashCode();
                
                if (this.Evaluators != null)
                    hash = hash * 59 + this.Evaluators.GetHashCode();
                
                if (this.EvaluationForm != null)
                    hash = hash * 59 + this.EvaluationForm.GetHashCode();
                
                if (this.ExpertEvaluator != null)
                    hash = hash * 59 + this.ExpertEvaluator.GetHashCode();
                
                return hash;
            }
        }
    }

}
