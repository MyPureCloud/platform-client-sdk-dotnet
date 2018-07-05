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
    /// CampaignRule
    /// </summary>
    [DataContract]
    public partial class CampaignRule :  IEquatable<CampaignRule>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignRule() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRule" /> class.
        /// </summary>
        /// <param name="Name">The name of the CampaignRule. (required).</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="CampaignRuleEntities">The list of entities that this CampaignRule monitors. (required).</param>
        /// <param name="CampaignRuleConditions">The list of conditions that are evaluated on the entities. (required).</param>
        /// <param name="CampaignRuleActions">The list of actions that are executed if the conditions are satisfied. (required).</param>
        /// <param name="MatchAnyConditions">MatchAnyConditions.</param>
        /// <param name="Enabled">Whether or not this CampaignRule is currently enabled. Required on updates..</param>
        public CampaignRule(string Name = null, int? Version = null, CampaignRuleEntities CampaignRuleEntities = null, List<CampaignRuleCondition> CampaignRuleConditions = null, List<CampaignRuleAction> CampaignRuleActions = null, bool? MatchAnyConditions = null, bool? Enabled = null)
        {
            this.Version = Version;
            this.MatchAnyConditions = MatchAnyConditions;
            this.Enabled = Enabled;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the CampaignRule.
        /// </summary>
        /// <value>The name of the CampaignRule.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The list of entities that this CampaignRule monitors.
        /// </summary>
        /// <value>The list of entities that this CampaignRule monitors.</value>
        [DataMember(Name="campaignRuleEntities", EmitDefaultValue=false)]
        public CampaignRuleEntities CampaignRuleEntities { get; set; }
        
        
        
        /// <summary>
        /// The list of conditions that are evaluated on the entities.
        /// </summary>
        /// <value>The list of conditions that are evaluated on the entities.</value>
        [DataMember(Name="campaignRuleConditions", EmitDefaultValue=false)]
        public List<CampaignRuleCondition> CampaignRuleConditions { get; set; }
        
        
        
        /// <summary>
        /// The list of actions that are executed if the conditions are satisfied.
        /// </summary>
        /// <value>The list of actions that are executed if the conditions are satisfied.</value>
        [DataMember(Name="campaignRuleActions", EmitDefaultValue=false)]
        public List<CampaignRuleAction> CampaignRuleActions { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MatchAnyConditions
        /// </summary>
        [DataMember(Name="matchAnyConditions", EmitDefaultValue=false)]
        public bool? MatchAnyConditions { get; set; }
        
        
        
        /// <summary>
        /// Whether or not this CampaignRule is currently enabled. Required on updates.
        /// </summary>
        /// <value>Whether or not this CampaignRule is currently enabled. Required on updates.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
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
            sb.Append("class CampaignRule {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CampaignRuleEntities: ").Append(CampaignRuleEntities).Append("\n");
            sb.Append("  CampaignRuleConditions: ").Append(CampaignRuleConditions).Append("\n");
            sb.Append("  CampaignRuleActions: ").Append(CampaignRuleActions).Append("\n");
            sb.Append("  MatchAnyConditions: ").Append(MatchAnyConditions).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(obj as CampaignRule);
        }

        /// <summary>
        /// Returns true if CampaignRule instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRule other)
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.CampaignRuleEntities == other.CampaignRuleEntities ||
                    this.CampaignRuleEntities != null &&
                    this.CampaignRuleEntities.Equals(other.CampaignRuleEntities)
                ) &&
                (
                    this.CampaignRuleConditions == other.CampaignRuleConditions ||
                    this.CampaignRuleConditions != null &&
                    this.CampaignRuleConditions.SequenceEqual(other.CampaignRuleConditions)
                ) &&
                (
                    this.CampaignRuleActions == other.CampaignRuleActions ||
                    this.CampaignRuleActions != null &&
                    this.CampaignRuleActions.SequenceEqual(other.CampaignRuleActions)
                ) &&
                (
                    this.MatchAnyConditions == other.MatchAnyConditions ||
                    this.MatchAnyConditions != null &&
                    this.MatchAnyConditions.Equals(other.MatchAnyConditions)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.CampaignRuleEntities != null)
                    hash = hash * 59 + this.CampaignRuleEntities.GetHashCode();
                
                if (this.CampaignRuleConditions != null)
                    hash = hash * 59 + this.CampaignRuleConditions.GetHashCode();
                
                if (this.CampaignRuleActions != null)
                    hash = hash * 59 + this.CampaignRuleActions.GetHashCode();
                
                if (this.MatchAnyConditions != null)
                    hash = hash * 59 + this.MatchAnyConditions.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
