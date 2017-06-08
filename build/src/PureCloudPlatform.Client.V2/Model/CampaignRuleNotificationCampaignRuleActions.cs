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
    /// CampaignRuleNotificationCampaignRuleActions
    /// </summary>
    [DataContract]
    public partial class CampaignRuleNotificationCampaignRuleActions :  IEquatable<CampaignRuleNotificationCampaignRuleActions>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum TurnOnCampaign for "TURN_ON_CAMPAIGN"
            /// </summary>
            [EnumMember(Value = "TURN_ON_CAMPAIGN")]
            TurnOnCampaign,
            
            /// <summary>
            /// Enum TurnOffCampaign for "TURN_OFF_CAMPAIGN"
            /// </summary>
            [EnumMember(Value = "TURN_OFF_CAMPAIGN")]
            TurnOffCampaign,
            
            /// <summary>
            /// Enum TurnOnSequence for "TURN_ON_SEQUENCE"
            /// </summary>
            [EnumMember(Value = "TURN_ON_SEQUENCE")]
            TurnOnSequence,
            
            /// <summary>
            /// Enum TurnOffSequence for "TURN_OFF_SEQUENCE"
            /// </summary>
            [EnumMember(Value = "TURN_OFF_SEQUENCE")]
            TurnOffSequence,
            
            /// <summary>
            /// Enum SetCampaignPriority for "SET_CAMPAIGN_PRIORITY"
            /// </summary>
            [EnumMember(Value = "SET_CAMPAIGN_PRIORITY")]
            SetCampaignPriority,
            
            /// <summary>
            /// Enum RecycleCampaign for "RECYCLE_CAMPAIGN"
            /// </summary>
            [EnumMember(Value = "RECYCLE_CAMPAIGN")]
            RecycleCampaign
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleNotificationCampaignRuleActions" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="Parameters">Parameters.</param>
        
        
        
        /// <param name="ActionType">ActionType.</param>
        
        
        
        /// <param name="CampaignRuleActionEntities">CampaignRuleActionEntities.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public CampaignRuleNotificationCampaignRuleActions(string Id = null, Dictionary<string, string> Parameters = null, ActionTypeEnum? ActionType = null, CampaignRuleNotificationCampaignRuleActionEntities CampaignRuleActionEntities = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Parameters = Parameters;
            
            
            
            
            
            
            
            
this.ActionType = ActionType;
            
            
            
            
            
            
            
            
this.CampaignRuleActionEntities = CampaignRuleActionEntities;
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets CampaignRuleActionEntities
        /// </summary>
        [DataMember(Name="campaignRuleActionEntities", EmitDefaultValue=false)]
        public CampaignRuleNotificationCampaignRuleActionEntities CampaignRuleActionEntities { get; set; }
        
        
        
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
            sb.Append("class CampaignRuleNotificationCampaignRuleActions {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            
            sb.Append("  CampaignRuleActionEntities: ").Append(CampaignRuleActionEntities).Append("\n");
            
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
            return this.Equals(obj as CampaignRuleNotificationCampaignRuleActions);
        }

        /// <summary>
        /// Returns true if CampaignRuleNotificationCampaignRuleActions instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleNotificationCampaignRuleActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleNotificationCampaignRuleActions other)
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
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) &&
                (
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
                ) &&
                (
                    this.CampaignRuleActionEntities == other.CampaignRuleActionEntities ||
                    this.CampaignRuleActionEntities != null &&
                    this.CampaignRuleActionEntities.Equals(other.CampaignRuleActionEntities)
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
                
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                
                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();
                
                if (this.CampaignRuleActionEntities != null)
                    hash = hash * 59 + this.CampaignRuleActionEntities.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
