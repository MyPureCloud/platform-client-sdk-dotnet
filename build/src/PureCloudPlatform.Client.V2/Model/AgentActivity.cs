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
    /// AgentActivity
    /// </summary>
    [DataContract]
    public partial class AgentActivity :  IEquatable<AgentActivity>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentActivity" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Agent">Agent.</param>
        /// <param name="NumEvaluations">NumEvaluations.</param>
        /// <param name="AverageEvaluationScore">AverageEvaluationScore.</param>
        /// <param name="NumCriticalEvaluations">NumCriticalEvaluations.</param>
        /// <param name="AverageCriticalScore">AverageCriticalScore.</param>
        /// <param name="HighestEvaluationScore">HighestEvaluationScore.</param>
        /// <param name="LowestEvaluationScore">LowestEvaluationScore.</param>
        /// <param name="HighestCriticalScore">HighestCriticalScore.</param>
        /// <param name="LowestCriticalScore">LowestCriticalScore.</param>
        /// <param name="AgentEvaluatorActivityList">AgentEvaluatorActivityList.</param>
        /// <param name="NumEvaluationsWithoutViewPermission">NumEvaluationsWithoutViewPermission.</param>
        public AgentActivity(string Name = null, User Agent = null, int? NumEvaluations = null, int? AverageEvaluationScore = null, int? NumCriticalEvaluations = null, float? AverageCriticalScore = null, float? HighestEvaluationScore = null, float? LowestEvaluationScore = null, float? HighestCriticalScore = null, float? LowestCriticalScore = null, List<AgentEvaluatorActivity> AgentEvaluatorActivityList = null, int? NumEvaluationsWithoutViewPermission = null)
        {
            this.Name = Name;
            this.Agent = Agent;
            this.NumEvaluations = NumEvaluations;
            this.AverageEvaluationScore = AverageEvaluationScore;
            this.NumCriticalEvaluations = NumCriticalEvaluations;
            this.AverageCriticalScore = AverageCriticalScore;
            this.HighestEvaluationScore = HighestEvaluationScore;
            this.LowestEvaluationScore = LowestEvaluationScore;
            this.HighestCriticalScore = HighestCriticalScore;
            this.LowestCriticalScore = LowestCriticalScore;
            this.AgentEvaluatorActivityList = AgentEvaluatorActivityList;
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
        /// Gets or Sets NumCriticalEvaluations
        /// </summary>
        [DataMember(Name="numCriticalEvaluations", EmitDefaultValue=false)]
        public int? NumCriticalEvaluations { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AverageCriticalScore
        /// </summary>
        [DataMember(Name="averageCriticalScore", EmitDefaultValue=false)]
        public float? AverageCriticalScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets HighestEvaluationScore
        /// </summary>
        [DataMember(Name="highestEvaluationScore", EmitDefaultValue=false)]
        public float? HighestEvaluationScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LowestEvaluationScore
        /// </summary>
        [DataMember(Name="lowestEvaluationScore", EmitDefaultValue=false)]
        public float? LowestEvaluationScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets HighestCriticalScore
        /// </summary>
        [DataMember(Name="highestCriticalScore", EmitDefaultValue=false)]
        public float? HighestCriticalScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LowestCriticalScore
        /// </summary>
        [DataMember(Name="lowestCriticalScore", EmitDefaultValue=false)]
        public float? LowestCriticalScore { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AgentEvaluatorActivityList
        /// </summary>
        [DataMember(Name="agentEvaluatorActivityList", EmitDefaultValue=false)]
        public List<AgentEvaluatorActivity> AgentEvaluatorActivityList { get; set; }
        
        
        
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
            sb.Append("class AgentActivity {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  NumEvaluations: ").Append(NumEvaluations).Append("\n");
            sb.Append("  AverageEvaluationScore: ").Append(AverageEvaluationScore).Append("\n");
            sb.Append("  NumCriticalEvaluations: ").Append(NumCriticalEvaluations).Append("\n");
            sb.Append("  AverageCriticalScore: ").Append(AverageCriticalScore).Append("\n");
            sb.Append("  HighestEvaluationScore: ").Append(HighestEvaluationScore).Append("\n");
            sb.Append("  LowestEvaluationScore: ").Append(LowestEvaluationScore).Append("\n");
            sb.Append("  HighestCriticalScore: ").Append(HighestCriticalScore).Append("\n");
            sb.Append("  LowestCriticalScore: ").Append(LowestCriticalScore).Append("\n");
            sb.Append("  AgentEvaluatorActivityList: ").Append(AgentEvaluatorActivityList).Append("\n");
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
            return this.Equals(obj as AgentActivity);
        }

        /// <summary>
        /// Returns true if AgentActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentActivity other)
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
                    this.NumCriticalEvaluations == other.NumCriticalEvaluations ||
                    this.NumCriticalEvaluations != null &&
                    this.NumCriticalEvaluations.Equals(other.NumCriticalEvaluations)
                ) &&
                (
                    this.AverageCriticalScore == other.AverageCriticalScore ||
                    this.AverageCriticalScore != null &&
                    this.AverageCriticalScore.Equals(other.AverageCriticalScore)
                ) &&
                (
                    this.HighestEvaluationScore == other.HighestEvaluationScore ||
                    this.HighestEvaluationScore != null &&
                    this.HighestEvaluationScore.Equals(other.HighestEvaluationScore)
                ) &&
                (
                    this.LowestEvaluationScore == other.LowestEvaluationScore ||
                    this.LowestEvaluationScore != null &&
                    this.LowestEvaluationScore.Equals(other.LowestEvaluationScore)
                ) &&
                (
                    this.HighestCriticalScore == other.HighestCriticalScore ||
                    this.HighestCriticalScore != null &&
                    this.HighestCriticalScore.Equals(other.HighestCriticalScore)
                ) &&
                (
                    this.LowestCriticalScore == other.LowestCriticalScore ||
                    this.LowestCriticalScore != null &&
                    this.LowestCriticalScore.Equals(other.LowestCriticalScore)
                ) &&
                (
                    this.AgentEvaluatorActivityList == other.AgentEvaluatorActivityList ||
                    this.AgentEvaluatorActivityList != null &&
                    this.AgentEvaluatorActivityList.SequenceEqual(other.AgentEvaluatorActivityList)
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
                
                if (this.NumEvaluations != null)
                    hash = hash * 59 + this.NumEvaluations.GetHashCode();
                
                if (this.AverageEvaluationScore != null)
                    hash = hash * 59 + this.AverageEvaluationScore.GetHashCode();
                
                if (this.NumCriticalEvaluations != null)
                    hash = hash * 59 + this.NumCriticalEvaluations.GetHashCode();
                
                if (this.AverageCriticalScore != null)
                    hash = hash * 59 + this.AverageCriticalScore.GetHashCode();
                
                if (this.HighestEvaluationScore != null)
                    hash = hash * 59 + this.HighestEvaluationScore.GetHashCode();
                
                if (this.LowestEvaluationScore != null)
                    hash = hash * 59 + this.LowestEvaluationScore.GetHashCode();
                
                if (this.HighestCriticalScore != null)
                    hash = hash * 59 + this.HighestCriticalScore.GetHashCode();
                
                if (this.LowestCriticalScore != null)
                    hash = hash * 59 + this.LowestCriticalScore.GetHashCode();
                
                if (this.AgentEvaluatorActivityList != null)
                    hash = hash * 59 + this.AgentEvaluatorActivityList.GetHashCode();
                
                if (this.NumEvaluationsWithoutViewPermission != null)
                    hash = hash * 59 + this.NumEvaluationsWithoutViewPermission.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
