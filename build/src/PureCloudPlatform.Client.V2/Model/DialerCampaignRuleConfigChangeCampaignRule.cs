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
    /// DialerCampaignRuleConfigChangeCampaignRule
    /// </summary>
    [DataContract]
    public partial class DialerCampaignRuleConfigChangeCampaignRule :  IEquatable<DialerCampaignRuleConfigChangeCampaignRule>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignRuleConfigChangeCampaignRule" /> class.
        /// </summary>
        /// <param name="CampaignRuleEntities">CampaignRuleEntities.</param>
        /// <param name="CampaignRuleConditions">The list of conditions that will trigger this Campaign Rule.</param>
        /// <param name="CampaignRuleActions">The list of actions that will be taken when this Campaign Rule&#39;s conditions are met.</param>
        /// <param name="MatchAnyConditions">Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL).</param>
        /// <param name="Enabled">Whether this campaign rule is enabled.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        public DialerCampaignRuleConfigChangeCampaignRule(DialerCampaignRuleConfigChangeCampaignRuleEntities CampaignRuleEntities = null, List<DialerCampaignRuleConfigChangeCampaignRuleCondition> CampaignRuleConditions = null, List<DialerCampaignRuleConfigChangeCampaignRuleAction> CampaignRuleActions = null, bool? MatchAnyConditions = null, bool? Enabled = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null)
        {
            this.CampaignRuleEntities = CampaignRuleEntities;
            this.CampaignRuleConditions = CampaignRuleConditions;
            this.CampaignRuleActions = CampaignRuleActions;
            this.MatchAnyConditions = MatchAnyConditions;
            this.Enabled = Enabled;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets CampaignRuleEntities
        /// </summary>
        [DataMember(Name="campaignRuleEntities", EmitDefaultValue=false)]
        public DialerCampaignRuleConfigChangeCampaignRuleEntities CampaignRuleEntities { get; set; }
        
        
        
        /// <summary>
        /// The list of conditions that will trigger this Campaign Rule
        /// </summary>
        /// <value>The list of conditions that will trigger this Campaign Rule</value>
        [DataMember(Name="campaignRuleConditions", EmitDefaultValue=false)]
        public List<DialerCampaignRuleConfigChangeCampaignRuleCondition> CampaignRuleConditions { get; set; }
        
        
        
        /// <summary>
        /// The list of actions that will be taken when this Campaign Rule&#39;s conditions are met
        /// </summary>
        /// <value>The list of actions that will be taken when this Campaign Rule&#39;s conditions are met</value>
        [DataMember(Name="campaignRuleActions", EmitDefaultValue=false)]
        public List<DialerCampaignRuleConfigChangeCampaignRuleAction> CampaignRuleActions { get; set; }
        
        
        
        /// <summary>
        /// Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL)
        /// </summary>
        /// <value>Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL)</value>
        [DataMember(Name="matchAnyConditions", EmitDefaultValue=false)]
        public bool? MatchAnyConditions { get; set; }
        
        
        
        /// <summary>
        /// Whether this campaign rule is enabled
        /// </summary>
        /// <value>Whether this campaign rule is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignRuleConfigChangeCampaignRule {\n");
            
            sb.Append("  CampaignRuleEntities: ").Append(CampaignRuleEntities).Append("\n");
            sb.Append("  CampaignRuleConditions: ").Append(CampaignRuleConditions).Append("\n");
            sb.Append("  CampaignRuleActions: ").Append(CampaignRuleActions).Append("\n");
            sb.Append("  MatchAnyConditions: ").Append(MatchAnyConditions).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as DialerCampaignRuleConfigChangeCampaignRule);
        }

        /// <summary>
        /// Returns true if DialerCampaignRuleConfigChangeCampaignRule instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignRuleConfigChangeCampaignRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignRuleConfigChangeCampaignRule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                
                return hash;
            }
        }
    }

}
