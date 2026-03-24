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
    /// CampaignRuleCampaignWaitTimeSettings
    /// </summary>
    [DataContract]
    public partial class CampaignRuleCampaignWaitTimeSettings :  IEquatable<CampaignRuleCampaignWaitTimeSettings>
    {
        /// <summary>
        /// Campaign wait type
        /// </summary>
        /// <value>Campaign wait type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum WaitTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Waitingforagents for "WaitingForAgents"
            /// </summary>
            [EnumMember(Value = "WaitingForAgents")]
            Waitingforagents,
            
            /// <summary>
            /// Enum Waitingforcontacts for "WaitingForContacts"
            /// </summary>
            [EnumMember(Value = "WaitingForContacts")]
            Waitingforcontacts,
            
            /// <summary>
            /// Enum Waitingforlines for "WaitingForLines"
            /// </summary>
            [EnumMember(Value = "WaitingForLines")]
            Waitingforlines
        }
        /// <summary>
        /// Campaign wait type
        /// </summary>
        /// <value>Campaign wait type</value>
        [DataMember(Name="waitType", EmitDefaultValue=false)]
        public WaitTypeEnum? WaitType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleCampaignWaitTimeSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignRuleCampaignWaitTimeSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleCampaignWaitTimeSettings" /> class.
        /// </summary>
        /// <param name="WaitType">Campaign wait type (required).</param>
        public CampaignRuleCampaignWaitTimeSettings(WaitTypeEnum? WaitType = null)
        {
            this.WaitType = WaitType;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleCampaignWaitTimeSettings {\n");

            sb.Append("  WaitType: ").Append(WaitType).Append("\n");
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
            return this.Equals(obj as CampaignRuleCampaignWaitTimeSettings);
        }

        /// <summary>
        /// Returns true if CampaignRuleCampaignWaitTimeSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleCampaignWaitTimeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleCampaignWaitTimeSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WaitType == other.WaitType ||
                    this.WaitType != null &&
                    this.WaitType.Equals(other.WaitType)
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
                if (this.WaitType != null)
                    hash = hash * 59 + this.WaitType.GetHashCode();

                return hash;
            }
        }
    }

}
