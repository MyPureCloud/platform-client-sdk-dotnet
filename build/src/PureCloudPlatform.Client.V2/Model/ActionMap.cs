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
    /// ActionMap
    /// </summary>
    [DataContract]
    public partial class ActionMap :  IEquatable<ActionMap>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionMap() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMap" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">The version of the action map..</param>
        /// <param name="IsActive">Whether the action map is active..</param>
        /// <param name="DisplayName">Display name of the action map. (required).</param>
        /// <param name="TriggerWithSegments">Trigger action map if any segment in the list is assigned to a given customer. (required).</param>
        /// <param name="TriggerWithEventConditions">List of event conditions that must be satisfied to trigger the action map..</param>
        /// <param name="TriggerWithOutcomeProbabilityConditions">Probability conditions for outcomes that must be satisfied to trigger the action map..</param>
        /// <param name="PageUrlConditions">URL conditions that a page must match for web actions to be displayable. (required).</param>
        /// <param name="Activation">Type of activation..</param>
        /// <param name="Weight">Weight of the action map with higher number denoting higher weight..</param>
        /// <param name="Action">The action that will be executed if this action map is triggered..</param>
        /// <param name="EstimatedWaitTimeLimit">The estimated wait time limit above which actions will not be offered..</param>
        /// <param name="CreatedDate">Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedDate">Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="StartDate">Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="EndDate">Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public ActionMap(string Name = null, int? Version = null, bool? IsActive = null, string DisplayName = null, List<string> TriggerWithSegments = null, List<EventCondition> TriggerWithEventConditions = null, List<OutcomeProbabilityCondition> TriggerWithOutcomeProbabilityConditions = null, List<UrlCondition> PageUrlConditions = null, Activation Activation = null, int? Weight = null, ActionMapAction Action = null, int? EstimatedWaitTimeLimit = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null, DateTime? StartDate = null, DateTime? EndDate = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.IsActive = IsActive;
            this.DisplayName = DisplayName;
            this.TriggerWithSegments = TriggerWithSegments;
            this.TriggerWithEventConditions = TriggerWithEventConditions;
            this.TriggerWithOutcomeProbabilityConditions = TriggerWithOutcomeProbabilityConditions;
            this.PageUrlConditions = PageUrlConditions;
            this.Activation = Activation;
            this.Weight = Weight;
            this.Action = Action;
            this.EstimatedWaitTimeLimit = EstimatedWaitTimeLimit;
            this.CreatedDate = CreatedDate;
            this.ModifiedDate = ModifiedDate;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            
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
        /// The version of the action map.
        /// </summary>
        /// <value>The version of the action map.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// Whether the action map is active.
        /// </summary>
        /// <value>Whether the action map is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
        
        
        
        /// <summary>
        /// Display name of the action map.
        /// </summary>
        /// <value>Display name of the action map.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        
        /// <summary>
        /// Trigger action map if any segment in the list is assigned to a given customer.
        /// </summary>
        /// <value>Trigger action map if any segment in the list is assigned to a given customer.</value>
        [DataMember(Name="triggerWithSegments", EmitDefaultValue=false)]
        public List<string> TriggerWithSegments { get; set; }
        
        
        
        /// <summary>
        /// List of event conditions that must be satisfied to trigger the action map.
        /// </summary>
        /// <value>List of event conditions that must be satisfied to trigger the action map.</value>
        [DataMember(Name="triggerWithEventConditions", EmitDefaultValue=false)]
        public List<EventCondition> TriggerWithEventConditions { get; set; }
        
        
        
        /// <summary>
        /// Probability conditions for outcomes that must be satisfied to trigger the action map.
        /// </summary>
        /// <value>Probability conditions for outcomes that must be satisfied to trigger the action map.</value>
        [DataMember(Name="triggerWithOutcomeProbabilityConditions", EmitDefaultValue=false)]
        public List<OutcomeProbabilityCondition> TriggerWithOutcomeProbabilityConditions { get; set; }
        
        
        
        /// <summary>
        /// URL conditions that a page must match for web actions to be displayable.
        /// </summary>
        /// <value>URL conditions that a page must match for web actions to be displayable.</value>
        [DataMember(Name="pageUrlConditions", EmitDefaultValue=false)]
        public List<UrlCondition> PageUrlConditions { get; set; }
        
        
        
        /// <summary>
        /// Type of activation.
        /// </summary>
        /// <value>Type of activation.</value>
        [DataMember(Name="activation", EmitDefaultValue=false)]
        public Activation Activation { get; set; }
        
        
        
        /// <summary>
        /// Weight of the action map with higher number denoting higher weight.
        /// </summary>
        /// <value>Weight of the action map with higher number denoting higher weight.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }
        
        
        
        /// <summary>
        /// The action that will be executed if this action map is triggered.
        /// </summary>
        /// <value>The action that will be executed if this action map is triggered.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionMapAction Action { get; set; }
        
        
        
        /// <summary>
        /// The estimated wait time limit above which actions will not be offered.
        /// </summary>
        /// <value>The estimated wait time limit above which actions will not be offered.</value>
        [DataMember(Name="estimatedWaitTimeLimit", EmitDefaultValue=false)]
        public int? EstimatedWaitTimeLimit { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        
        
        
        /// <summary>
        /// Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        
        /// <summary>
        /// Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionMap {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  TriggerWithSegments: ").Append(TriggerWithSegments).Append("\n");
            sb.Append("  TriggerWithEventConditions: ").Append(TriggerWithEventConditions).Append("\n");
            sb.Append("  TriggerWithOutcomeProbabilityConditions: ").Append(TriggerWithOutcomeProbabilityConditions).Append("\n");
            sb.Append("  PageUrlConditions: ").Append(PageUrlConditions).Append("\n");
            sb.Append("  Activation: ").Append(Activation).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  EstimatedWaitTimeLimit: ").Append(EstimatedWaitTimeLimit).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as ActionMap);
        }

        /// <summary>
        /// Returns true if ActionMap instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionMap other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.TriggerWithSegments == other.TriggerWithSegments ||
                    this.TriggerWithSegments != null &&
                    this.TriggerWithSegments.SequenceEqual(other.TriggerWithSegments)
                ) &&
                (
                    this.TriggerWithEventConditions == other.TriggerWithEventConditions ||
                    this.TriggerWithEventConditions != null &&
                    this.TriggerWithEventConditions.SequenceEqual(other.TriggerWithEventConditions)
                ) &&
                (
                    this.TriggerWithOutcomeProbabilityConditions == other.TriggerWithOutcomeProbabilityConditions ||
                    this.TriggerWithOutcomeProbabilityConditions != null &&
                    this.TriggerWithOutcomeProbabilityConditions.SequenceEqual(other.TriggerWithOutcomeProbabilityConditions)
                ) &&
                (
                    this.PageUrlConditions == other.PageUrlConditions ||
                    this.PageUrlConditions != null &&
                    this.PageUrlConditions.SequenceEqual(other.PageUrlConditions)
                ) &&
                (
                    this.Activation == other.Activation ||
                    this.Activation != null &&
                    this.Activation.Equals(other.Activation)
                ) &&
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.EstimatedWaitTimeLimit == other.EstimatedWaitTimeLimit ||
                    this.EstimatedWaitTimeLimit != null &&
                    this.EstimatedWaitTimeLimit.Equals(other.EstimatedWaitTimeLimit)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.TriggerWithSegments != null)
                    hash = hash * 59 + this.TriggerWithSegments.GetHashCode();
                
                if (this.TriggerWithEventConditions != null)
                    hash = hash * 59 + this.TriggerWithEventConditions.GetHashCode();
                
                if (this.TriggerWithOutcomeProbabilityConditions != null)
                    hash = hash * 59 + this.TriggerWithOutcomeProbabilityConditions.GetHashCode();
                
                if (this.PageUrlConditions != null)
                    hash = hash * 59 + this.PageUrlConditions.GetHashCode();
                
                if (this.Activation != null)
                    hash = hash * 59 + this.Activation.GetHashCode();
                
                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.EstimatedWaitTimeLimit != null)
                    hash = hash * 59 + this.EstimatedWaitTimeLimit.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
