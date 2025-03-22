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
    /// ConversationSummaryTopicTriggerSource
    /// </summary>
    [DataContract]
    public partial class ConversationSummaryTopicTriggerSource :  IEquatable<ConversationSummaryTopicTriggerSource>
    {
        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum AgentAssistant for "AGENT_ASSISTANT"
            /// </summary>
            [EnumMember(Value = "AGENT_ASSISTANT")]
            AgentAssistant,
            
            /// <summary>
            /// Enum Program for "PROGRAM"
            /// </summary>
            [EnumMember(Value = "PROGRAM")]
            Program,
            
            /// <summary>
            /// Enum Flow for "FLOW"
            /// </summary>
            [EnumMember(Value = "FLOW")]
            Flow,
            
            /// <summary>
            /// Enum Copilot for "COPILOT"
            /// </summary>
            [EnumMember(Value = "COPILOT")]
            Copilot
        }
        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummaryTopicTriggerSource" /> class.
        /// </summary>
        /// <param name="SourceType">SourceType.</param>
        /// <param name="SourceId">SourceId.</param>
        public ConversationSummaryTopicTriggerSource(SourceTypeEnum? SourceType = null, string SourceId = null)
        {
            this.SourceType = SourceType;
            this.SourceId = SourceId;
            
        }
        




        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationSummaryTopicTriggerSource {\n");

            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
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
            return this.Equals(obj as ConversationSummaryTopicTriggerSource);
        }

        /// <summary>
        /// Returns true if ConversationSummaryTopicTriggerSource instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationSummaryTopicTriggerSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationSummaryTopicTriggerSource other)
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

                return hash;
            }
        }
    }

}
