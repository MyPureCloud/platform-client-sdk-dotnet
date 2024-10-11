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
    /// CampaignRuleExecutionSettings
    /// </summary>
    [DataContract]
    public partial class CampaignRuleExecutionSettings :  IEquatable<CampaignRuleExecutionSettings>
    {
        /// <summary>
        /// Execution control frequency
        /// </summary>
        /// <value>Execution control frequency</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FrequencyEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Oneachtrigger for "onEachTrigger"
            /// </summary>
            [EnumMember(Value = "onEachTrigger")]
            Oneachtrigger,
            
            /// <summary>
            /// Enum Onceperday for "oncePerDay"
            /// </summary>
            [EnumMember(Value = "oncePerDay")]
            Onceperday
        }
        /// <summary>
        /// Execution control frequency
        /// </summary>
        /// <value>Execution control frequency</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum? Frequency { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleExecutionSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignRuleExecutionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRuleExecutionSettings" /> class.
        /// </summary>
        /// <param name="Frequency">Execution control frequency (required).</param>
        /// <param name="TimeZoneId">The time zone for the execution control frequency=\"oncePerDay\"; for example, Africa/Abidjan. This property is ignored when frequency is not \"oncePerDay\".</param>
        public CampaignRuleExecutionSettings(FrequencyEnum? Frequency = null, string TimeZoneId = null)
        {
            this.Frequency = Frequency;
            this.TimeZoneId = TimeZoneId;
            
        }
        




        /// <summary>
        /// The time zone for the execution control frequency=\"oncePerDay\"; for example, Africa/Abidjan. This property is ignored when frequency is not \"oncePerDay\"
        /// </summary>
        /// <value>The time zone for the execution control frequency=\"oncePerDay\"; for example, Africa/Abidjan. This property is ignored when frequency is not \"oncePerDay\"</value>
        [DataMember(Name="timeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRuleExecutionSettings {\n");

            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
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
            return this.Equals(obj as CampaignRuleExecutionSettings);
        }

        /// <summary>
        /// Returns true if CampaignRuleExecutionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignRuleExecutionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRuleExecutionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Frequency == other.Frequency ||
                    this.Frequency != null &&
                    this.Frequency.Equals(other.Frequency)
                ) &&
                (
                    this.TimeZoneId == other.TimeZoneId ||
                    this.TimeZoneId != null &&
                    this.TimeZoneId.Equals(other.TimeZoneId)
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
                if (this.Frequency != null)
                    hash = hash * 59 + this.Frequency.GetHashCode();

                if (this.TimeZoneId != null)
                    hash = hash * 59 + this.TimeZoneId.GetHashCode();

                return hash;
            }
        }
    }

}
