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
    /// EvaluatorActivity
    /// </summary>
    [DataContract]
    public partial class EvaluatorActivity :  IEquatable<EvaluatorActivity>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorActivity" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="Evaluator">Evaluator.</param>
        
        
        
        /// <param name="NumEvaluationsAssigned">NumEvaluationsAssigned.</param>
        
        
        
        /// <param name="NumEvaluationsStarted">NumEvaluationsStarted.</param>
        
        
        
        /// <param name="NumEvaluationsCompleted">NumEvaluationsCompleted.</param>
        
        
        
        /// <param name="NumCalibrationsAssigned">NumCalibrationsAssigned.</param>
        
        
        
        /// <param name="NumCalibrationsStarted">NumCalibrationsStarted.</param>
        
        
        
        /// <param name="NumCalibrationsCompleted">NumCalibrationsCompleted.</param>
        
        
        
        
        public EvaluatorActivity(string Name = null, User Evaluator = null, int? NumEvaluationsAssigned = null, int? NumEvaluationsStarted = null, int? NumEvaluationsCompleted = null, int? NumCalibrationsAssigned = null, int? NumCalibrationsStarted = null, int? NumCalibrationsCompleted = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.Evaluator = Evaluator;
            
            
            
            
            
            
            
            
this.NumEvaluationsAssigned = NumEvaluationsAssigned;
            
            
            
            
            
            
            
            
this.NumEvaluationsStarted = NumEvaluationsStarted;
            
            
            
            
            
            
            
            
this.NumEvaluationsCompleted = NumEvaluationsCompleted;
            
            
            
            
            
            
            
            
this.NumCalibrationsAssigned = NumCalibrationsAssigned;
            
            
            
            
            
            
            
            
this.NumCalibrationsStarted = NumCalibrationsStarted;
            
            
            
            
            
            
            
            
this.NumCalibrationsCompleted = NumCalibrationsCompleted;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Evaluator
        /// </summary>
        [DataMember(Name="evaluator", EmitDefaultValue=false)]
        public User Evaluator { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumEvaluationsAssigned
        /// </summary>
        [DataMember(Name="numEvaluationsAssigned", EmitDefaultValue=false)]
        public int? NumEvaluationsAssigned { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumEvaluationsStarted
        /// </summary>
        [DataMember(Name="numEvaluationsStarted", EmitDefaultValue=false)]
        public int? NumEvaluationsStarted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumEvaluationsCompleted
        /// </summary>
        [DataMember(Name="numEvaluationsCompleted", EmitDefaultValue=false)]
        public int? NumEvaluationsCompleted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumCalibrationsAssigned
        /// </summary>
        [DataMember(Name="numCalibrationsAssigned", EmitDefaultValue=false)]
        public int? NumCalibrationsAssigned { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumCalibrationsStarted
        /// </summary>
        [DataMember(Name="numCalibrationsStarted", EmitDefaultValue=false)]
        public int? NumCalibrationsStarted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumCalibrationsCompleted
        /// </summary>
        [DataMember(Name="numCalibrationsCompleted", EmitDefaultValue=false)]
        public int? NumCalibrationsCompleted { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluatorActivity {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
            
            sb.Append("  NumEvaluationsAssigned: ").Append(NumEvaluationsAssigned).Append("\n");
            
            sb.Append("  NumEvaluationsStarted: ").Append(NumEvaluationsStarted).Append("\n");
            
            sb.Append("  NumEvaluationsCompleted: ").Append(NumEvaluationsCompleted).Append("\n");
            
            sb.Append("  NumCalibrationsAssigned: ").Append(NumCalibrationsAssigned).Append("\n");
            
            sb.Append("  NumCalibrationsStarted: ").Append(NumCalibrationsStarted).Append("\n");
            
            sb.Append("  NumCalibrationsCompleted: ").Append(NumCalibrationsCompleted).Append("\n");
            
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
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
            return this.Equals(obj as EvaluatorActivity);
        }

        /// <summary>
        /// Returns true if EvaluatorActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluatorActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluatorActivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Evaluator == other.Evaluator ||
                    this.Evaluator != null &&
                    this.Evaluator.Equals(other.Evaluator)
                ) &&
                (
                    this.NumEvaluationsAssigned == other.NumEvaluationsAssigned ||
                    this.NumEvaluationsAssigned != null &&
                    this.NumEvaluationsAssigned.Equals(other.NumEvaluationsAssigned)
                ) &&
                (
                    this.NumEvaluationsStarted == other.NumEvaluationsStarted ||
                    this.NumEvaluationsStarted != null &&
                    this.NumEvaluationsStarted.Equals(other.NumEvaluationsStarted)
                ) &&
                (
                    this.NumEvaluationsCompleted == other.NumEvaluationsCompleted ||
                    this.NumEvaluationsCompleted != null &&
                    this.NumEvaluationsCompleted.Equals(other.NumEvaluationsCompleted)
                ) &&
                (
                    this.NumCalibrationsAssigned == other.NumCalibrationsAssigned ||
                    this.NumCalibrationsAssigned != null &&
                    this.NumCalibrationsAssigned.Equals(other.NumCalibrationsAssigned)
                ) &&
                (
                    this.NumCalibrationsStarted == other.NumCalibrationsStarted ||
                    this.NumCalibrationsStarted != null &&
                    this.NumCalibrationsStarted.Equals(other.NumCalibrationsStarted)
                ) &&
                (
                    this.NumCalibrationsCompleted == other.NumCalibrationsCompleted ||
                    this.NumCalibrationsCompleted != null &&
                    this.NumCalibrationsCompleted.Equals(other.NumCalibrationsCompleted)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Evaluator != null)
                    hash = hash * 59 + this.Evaluator.GetHashCode();
                
                if (this.NumEvaluationsAssigned != null)
                    hash = hash * 59 + this.NumEvaluationsAssigned.GetHashCode();
                
                if (this.NumEvaluationsStarted != null)
                    hash = hash * 59 + this.NumEvaluationsStarted.GetHashCode();
                
                if (this.NumEvaluationsCompleted != null)
                    hash = hash * 59 + this.NumEvaluationsCompleted.GetHashCode();
                
                if (this.NumCalibrationsAssigned != null)
                    hash = hash * 59 + this.NumCalibrationsAssigned.GetHashCode();
                
                if (this.NumCalibrationsStarted != null)
                    hash = hash * 59 + this.NumCalibrationsStarted.GetHashCode();
                
                if (this.NumCalibrationsCompleted != null)
                    hash = hash * 59 + this.NumCalibrationsCompleted.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
