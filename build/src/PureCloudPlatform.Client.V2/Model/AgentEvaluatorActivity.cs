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
    /// AgentEvaluatorActivity
    /// </summary>
    [DataContract]
    public partial class AgentEvaluatorActivity :  IEquatable<AgentEvaluatorActivity>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentEvaluatorActivity" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Agent">Agent.</param>
        /// <param name="Evaluator">Evaluator.</param>
        /// <param name="NumEvaluations">NumEvaluations.</param>
        /// <param name="AverageEvaluationScore">AverageEvaluationScore.</param>
        /// <param name="NumEvaluationsWithoutViewPermission">NumEvaluationsWithoutViewPermission.</param>
        public AgentEvaluatorActivity(string Name = null, User Agent = null, User Evaluator = null, int? NumEvaluations = null, int? AverageEvaluationScore = null, int? NumEvaluationsWithoutViewPermission = null)
        {
            this.Name = Name;
            this.Agent = Agent;
            this.Evaluator = Evaluator;
            this.NumEvaluations = NumEvaluations;
            this.AverageEvaluationScore = AverageEvaluationScore;
            this.NumEvaluationsWithoutViewPermission = NumEvaluationsWithoutViewPermission;
            
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
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public User Agent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Evaluator
        /// </summary>
        [DataMember(Name="evaluator", EmitDefaultValue=false)]
        public User Evaluator { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumEvaluations
        /// </summary>
        [DataMember(Name="numEvaluations", EmitDefaultValue=false)]
        public int? NumEvaluations { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AverageEvaluationScore
        /// </summary>
        [DataMember(Name="averageEvaluationScore", EmitDefaultValue=false)]
        public int? AverageEvaluationScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NumEvaluationsWithoutViewPermission
        /// </summary>
        [DataMember(Name="numEvaluationsWithoutViewPermission", EmitDefaultValue=false)]
        public int? NumEvaluationsWithoutViewPermission { get; set; }
        
        
        
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
            sb.Append("class AgentEvaluatorActivity {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Evaluator: ").Append(Evaluator).Append("\n");
            sb.Append("  NumEvaluations: ").Append(NumEvaluations).Append("\n");
            sb.Append("  AverageEvaluationScore: ").Append(AverageEvaluationScore).Append("\n");
            sb.Append("  NumEvaluationsWithoutViewPermission: ").Append(NumEvaluationsWithoutViewPermission).Append("\n");
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
            return this.Equals(obj as AgentEvaluatorActivity);
        }

        /// <summary>
        /// Returns true if AgentEvaluatorActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentEvaluatorActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentEvaluatorActivity other)
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
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.Evaluator == other.Evaluator ||
                    this.Evaluator != null &&
                    this.Evaluator.Equals(other.Evaluator)
                ) &&
                (
                    this.NumEvaluations == other.NumEvaluations ||
                    this.NumEvaluations != null &&
                    this.NumEvaluations.Equals(other.NumEvaluations)
                ) &&
                (
                    this.AverageEvaluationScore == other.AverageEvaluationScore ||
                    this.AverageEvaluationScore != null &&
                    this.AverageEvaluationScore.Equals(other.AverageEvaluationScore)
                ) &&
                (
                    this.NumEvaluationsWithoutViewPermission == other.NumEvaluationsWithoutViewPermission ||
                    this.NumEvaluationsWithoutViewPermission != null &&
                    this.NumEvaluationsWithoutViewPermission.Equals(other.NumEvaluationsWithoutViewPermission)
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
                
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                
                if (this.Evaluator != null)
                    hash = hash * 59 + this.Evaluator.GetHashCode();
                
                if (this.NumEvaluations != null)
                    hash = hash * 59 + this.NumEvaluations.GetHashCode();
                
                if (this.AverageEvaluationScore != null)
                    hash = hash * 59 + this.AverageEvaluationScore.GetHashCode();
                
                if (this.NumEvaluationsWithoutViewPermission != null)
                    hash = hash * 59 + this.NumEvaluationsWithoutViewPermission.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
