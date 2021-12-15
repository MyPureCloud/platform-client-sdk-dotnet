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
    /// DialerCampaignRuleConfigChangeCampaignRuleAction
    /// </summary>
    [DataContract]
    public partial class DialerCampaignRuleConfigChangeCampaignRuleAction :  IEquatable<DialerCampaignRuleConfigChangeCampaignRuleAction>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this action
        /// </summary>
        /// <value>The type of this action</value>
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
            /// Enum Turnoncampaign for "turnOnCampaign"
            /// </summary>
            [EnumMember(Value = "turnOnCampaign")]
            Turnoncampaign,
            
            /// <summary>
            /// Enum Turnoffcampaign for "turnOffCampaign"
            /// </summary>
            [EnumMember(Value = "turnOffCampaign")]
            Turnoffcampaign,
            
            /// <summary>
            /// Enum Turnonsequence for "turnOnSequence"
            /// </summary>
            [EnumMember(Value = "turnOnSequence")]
            Turnonsequence,
            
            /// <summary>
            /// Enum Turnoffsequence for "turnOffSequence"
            /// </summary>
            [EnumMember(Value = "turnOffSequence")]
            Turnoffsequence,
            
            /// <summary>
            /// Enum Setcampaignpriority for "setCampaignPriority"
            /// </summary>
            [EnumMember(Value = "setCampaignPriority")]
            Setcampaignpriority,
            
            /// <summary>
            /// Enum Recyclecampaign for "recycleCampaign"
            /// </summary>
            [EnumMember(Value = "recycleCampaign")]
            Recyclecampaign
        }
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of this action
        /// </summary>
        /// <value>The type of this action</value>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignRuleConfigChangeCampaignRuleAction" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the action.</param>
        /// <param name="Parameters">The parameters to match this action.</param>
        /// <param name="ActionType">The type of this action.</param>
        /// <param name="CampaignRuleActionEntities">CampaignRuleActionEntities.</param>
        public DialerCampaignRuleConfigChangeCampaignRuleAction(string Id = null, Dictionary<string, string> Parameters = null, ActionTypeEnum? ActionType = null, DialerCampaignRuleConfigChangeCampaignRuleActionEntities CampaignRuleActionEntities = null)
        {
            this.Id = Id;
            this.Parameters = Parameters;
            this.ActionType = ActionType;
            this.CampaignRuleActionEntities = CampaignRuleActionEntities;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the action
        /// </summary>
        /// <value>The globally unique identifier for the action</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The parameters to match this action
        /// </summary>
        /// <value>The parameters to match this action</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets CampaignRuleActionEntities
        /// </summary>
        [DataMember(Name="campaignRuleActionEntities", EmitDefaultValue=false)]
        public DialerCampaignRuleConfigChangeCampaignRuleActionEntities CampaignRuleActionEntities { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignRuleConfigChangeCampaignRuleAction {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  CampaignRuleActionEntities: ").Append(CampaignRuleActionEntities).Append("\n");
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
            return this.Equals(obj as DialerCampaignRuleConfigChangeCampaignRuleAction);
        }

        /// <summary>
        /// Returns true if DialerCampaignRuleConfigChangeCampaignRuleAction instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignRuleConfigChangeCampaignRuleAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignRuleConfigChangeCampaignRuleAction other)
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
                
                return hash;
            }
        }
    }

}
