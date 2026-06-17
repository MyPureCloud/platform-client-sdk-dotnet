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
    /// ConversationSummaryTriggerSource
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryTriggerSource :  IEquatable<ConversationSummaryTriggerSource>
    {
        /// <summary>
        /// The configuration entity for which summarization is triggered.
        /// </summary>
        /// <value>The configuration entity for which summarization is triggered.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Agentassistant for "AgentAssistant"
            /// </summary>
            [EnumMember(Value = "AgentAssistant")]
            Agentassistant,
            
            /// <summary>
            /// Enum Program for "Program"
            /// </summary>
            [EnumMember(Value = "Program")]
            Program,
            
            /// <summary>
            /// Enum Flow for "Flow"
            /// </summary>
            [EnumMember(Value = "Flow")]
            Flow,
            
            /// <summary>
            /// Enum Copilot for "Copilot"
            /// </summary>
            [EnumMember(Value = "Copilot")]
            Copilot
        }
        /// <summary>
        /// The reason a trigger source finished processing. Only applies to Flow trigger source types.
        /// </summary>
        /// <value>The reason a trigger source finished processing. Only applies to Flow trigger source types.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceOutcomeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Contained for "Contained"
            /// </summary>
            [EnumMember(Value = "Contained")]
            Contained,
            
            /// <summary>
            /// Enum Transfer for "Transfer"
            /// </summary>
            [EnumMember(Value = "Transfer")]
            Transfer
        }
        /// <summary>
        /// The configuration entity for which summarization is triggered.
        /// </summary>
        /// <value>The configuration entity for which summarization is triggered.</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// The reason a trigger source finished processing. Only applies to Flow trigger source types.
        /// </summary>
        /// <value>The reason a trigger source finished processing. Only applies to Flow trigger source types.</value>
        [DataMember(Name="sourceOutcome", EmitDefaultValue=false)]
        public SourceOutcomeEnum? SourceOutcome { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryTriggerSource" /> class.
        /// </summary>
        /// <param name="SourceType">The configuration entity for which summarization is triggered..</param>
        /// <param name="SourceId">The id value for the source type..</param>
        /// <param name="SourceOutcome">The reason a trigger source finished processing. Only applies to Flow trigger source types..</param>
        public ConversationSummaryTriggerSource(SourceTypeEnum? SourceType = null, string SourceId = null, SourceOutcomeEnum? SourceOutcome = null)
        {
            this.SourceType = SourceType;
            this.SourceId = SourceId;
            this.SourceOutcome = SourceOutcome;
            
        }
        




        /// <summary>
        /// The id value for the source type.
        /// </summary>
        /// <value>The id value for the source type.</value>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryTriggerSource {\n");

            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceOutcome: ").Append(SourceOutcome).Append("\n");
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
            return this.Equals(obj as ConversationSummaryTriggerSource);
        }

        /// <summary>
        /// Returns true if ConversationSummaryTriggerSource instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryTriggerSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryTriggerSource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
                ) &&
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) &&
                (
                    this.SourceOutcome == other.SourceOutcome ||
                    this.SourceOutcome != null &&
                    this.SourceOutcome.Equals(other.SourceOutcome)
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
                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();

                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();

                if (this.SourceOutcome != null)
                    hash = hash * 59 + this.SourceOutcome.GetHashCode();

                return hash;
            }
        }
    }

}
