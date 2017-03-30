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
    /// CampaignRuleNotification
    /// </summary>
    [DataContract]
    public partial class CampaignRuleNotification :  IEquatable<CampaignRuleNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Version">Version.</param>
        /// <param name="CampaignRuleEntities">CampaignRuleEntities.</param>
        /// <param name="CampaignRuleConditions">CampaignRuleConditions.</param>
        /// <param name="CampaignRuleActions">CampaignRuleActions.</param>
        /// <param name="MatchAnyConditions">MatchAnyConditions.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public CampaignRuleNotification(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, CampaignRuleNotificationCampaignRuleEntities CampaignRuleEntities = null, List<CampaignRuleNotificationCampaignRuleConditions> CampaignRuleConditions = null, List<CampaignRuleNotificationCampaignRuleActions> CampaignRuleActions = null, bool? MatchAnyConditions = null, bool? Enabled = null, Object AdditionalProperties = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.CampaignRuleEntities = CampaignRuleEntities;
            this.CampaignRuleConditions = CampaignRuleConditions;
            this.CampaignRuleActions = CampaignRuleActions;
            this.MatchAnyConditions = MatchAnyConditions;
            this.Enabled = Enabled;
            this.AdditionalProperties = AdditionalProperties;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Gets or Sets CampaignRuleEntities
        /// </summary>
        [DataMember(Name="campaignRuleEntities", EmitDefaultValue=false)]
        public CampaignRuleNotificationCampaignRuleEntities CampaignRuleEntities { get; set; }
        /// <summary>
        /// Gets or Sets CampaignRuleConditions
        /// </summary>
        [DataMember(Name="campaignRuleConditions", EmitDefaultValue=false)]
        public List<CampaignRuleNotificationCampaignRuleConditions> CampaignRuleConditions { get; set; }
        /// <summary>
        /// Gets or Sets CampaignRuleActions
        /// </summary>
        [DataMember(Name="campaignRuleActions", EmitDefaultValue=false)]
        public List<CampaignRuleNotificationCampaignRuleActions> CampaignRuleActions { get; set; }
        /// <summary>
        /// Gets or Sets MatchAnyConditions
        /// </summary>
        [DataMember(Name="matchAnyConditions", EmitDefaultValue=false)]
        public bool? MatchAnyConditions { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleNotification {\n");
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
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as CampaignRuleNotification);
        }

        /// <summary>
        /// Returns true if CampaignRuleNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleNotification other)
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
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                return hash;
            }
        }
    }

}
