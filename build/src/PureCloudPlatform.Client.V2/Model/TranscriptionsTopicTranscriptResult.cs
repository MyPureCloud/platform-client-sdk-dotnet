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
    /// TranscriptionsTopicTranscriptResult
    /// </summary>
    [DataContract]
    public partial class TranscriptionsTopicTranscriptResult :  IEquatable<TranscriptionsTopicTranscriptResult>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ChannelEnum
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
            /// Enum Internal for "INTERNAL"
            /// </summary>
            [EnumMember(Value = "INTERNAL")]
            Internal,
            
            /// <summary>
            /// Enum External for "EXTERNAL"
            /// </summary>
            [EnumMember(Value = "EXTERNAL")]
            External,
            
            /// <summary>
            /// Enum Both for "BOTH"
            /// </summary>
            [EnumMember(Value = "BOTH")]
            Both
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum? Channel { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionsTopicTranscriptResult" /> class.
        /// </summary>
        /// <param name="UtteranceId">UtteranceId.</param>
        /// <param name="IsFinal">IsFinal.</param>
        /// <param name="Channel">Channel.</param>
        /// <param name="Alternatives">Alternatives.</param>
        /// <param name="AgentAssistantId">AgentAssistantId.</param>
        /// <param name="EngineId">EngineId.</param>
        /// <param name="Dialect">Dialect.</param>
        /// <param name="SpeechTextAnalyticsProgramId">SpeechTextAnalyticsProgramId.</param>
        /// <param name="StartTimeMs">StartTimeMs.</param>
        /// <param name="OffsetMs">OffsetMs.</param>
        /// <param name="DurationMs">DurationMs.</param>
        /// <param name="AgentAssistEnabled">AgentAssistEnabled.</param>
        /// <param name="VoiceTranscriptionEnabled">VoiceTranscriptionEnabled.</param>
        public TranscriptionsTopicTranscriptResult(string UtteranceId = null, bool? IsFinal = null, ChannelEnum? Channel = null, List<TranscriptionsTopicTranscriptAlternative> Alternatives = null, string AgentAssistantId = null, string EngineId = null, string Dialect = null, string SpeechTextAnalyticsProgramId = null, int? StartTimeMs = null, int? OffsetMs = null, int? DurationMs = null, bool? AgentAssistEnabled = null, bool? VoiceTranscriptionEnabled = null)
        {
            this.UtteranceId = UtteranceId;
            this.IsFinal = IsFinal;
            this.Channel = Channel;
            this.Alternatives = Alternatives;
            this.AgentAssistantId = AgentAssistantId;
            this.EngineId = EngineId;
            this.Dialect = Dialect;
            this.SpeechTextAnalyticsProgramId = SpeechTextAnalyticsProgramId;
            this.StartTimeMs = StartTimeMs;
            this.OffsetMs = OffsetMs;
            this.DurationMs = DurationMs;
            this.AgentAssistEnabled = AgentAssistEnabled;
            this.VoiceTranscriptionEnabled = VoiceTranscriptionEnabled;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets UtteranceId
        /// </summary>
        [DataMember(Name="utteranceId", EmitDefaultValue=false)]
        public string UtteranceId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IsFinal
        /// </summary>
        [DataMember(Name="isFinal", EmitDefaultValue=false)]
        public bool? IsFinal { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Alternatives
        /// </summary>
        [DataMember(Name="alternatives", EmitDefaultValue=false)]
        public List<TranscriptionsTopicTranscriptAlternative> Alternatives { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AgentAssistantId
        /// </summary>
        [DataMember(Name="agentAssistantId", EmitDefaultValue=false)]
        public string AgentAssistantId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EngineId
        /// </summary>
        [DataMember(Name="engineId", EmitDefaultValue=false)]
        public string EngineId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Dialect
        /// </summary>
        [DataMember(Name="dialect", EmitDefaultValue=false)]
        public string Dialect { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SpeechTextAnalyticsProgramId
        /// </summary>
        [DataMember(Name="speechTextAnalyticsProgramId", EmitDefaultValue=false)]
        public string SpeechTextAnalyticsProgramId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets StartTimeMs
        /// </summary>
        [DataMember(Name="startTimeMs", EmitDefaultValue=false)]
        public int? StartTimeMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OffsetMs
        /// </summary>
        [DataMember(Name="offsetMs", EmitDefaultValue=false)]
        public int? OffsetMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DurationMs
        /// </summary>
        [DataMember(Name="durationMs", EmitDefaultValue=false)]
        public int? DurationMs { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AgentAssistEnabled
        /// </summary>
        [DataMember(Name="agentAssistEnabled", EmitDefaultValue=false)]
        public bool? AgentAssistEnabled { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets VoiceTranscriptionEnabled
        /// </summary>
        [DataMember(Name="voiceTranscriptionEnabled", EmitDefaultValue=false)]
        public bool? VoiceTranscriptionEnabled { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionsTopicTranscriptResult {\n");
            
            sb.Append("  UtteranceId: ").Append(UtteranceId).Append("\n");
            sb.Append("  IsFinal: ").Append(IsFinal).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
            sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
            sb.Append("  EngineId: ").Append(EngineId).Append("\n");
            sb.Append("  Dialect: ").Append(Dialect).Append("\n");
            sb.Append("  SpeechTextAnalyticsProgramId: ").Append(SpeechTextAnalyticsProgramId).Append("\n");
            sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
            sb.Append("  OffsetMs: ").Append(OffsetMs).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  AgentAssistEnabled: ").Append(AgentAssistEnabled).Append("\n");
            sb.Append("  VoiceTranscriptionEnabled: ").Append(VoiceTranscriptionEnabled).Append("\n");
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
            return this.Equals(obj as TranscriptionsTopicTranscriptResult);
        }

        /// <summary>
        /// Returns true if TranscriptionsTopicTranscriptResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionsTopicTranscriptResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionsTopicTranscriptResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UtteranceId == other.UtteranceId ||
                    this.UtteranceId != null &&
                    this.UtteranceId.Equals(other.UtteranceId)
                ) &&
                (
                    this.IsFinal == other.IsFinal ||
                    this.IsFinal != null &&
                    this.IsFinal.Equals(other.IsFinal)
                ) &&
                (
                    this.Channel == other.Channel ||
                    this.Channel != null &&
                    this.Channel.Equals(other.Channel)
                ) &&
                (
                    this.Alternatives == other.Alternatives ||
                    this.Alternatives != null &&
                    this.Alternatives.SequenceEqual(other.Alternatives)
                ) &&
                (
                    this.AgentAssistantId == other.AgentAssistantId ||
                    this.AgentAssistantId != null &&
                    this.AgentAssistantId.Equals(other.AgentAssistantId)
                ) &&
                (
                    this.EngineId == other.EngineId ||
                    this.EngineId != null &&
                    this.EngineId.Equals(other.EngineId)
                ) &&
                (
                    this.Dialect == other.Dialect ||
                    this.Dialect != null &&
                    this.Dialect.Equals(other.Dialect)
                ) &&
                (
                    this.SpeechTextAnalyticsProgramId == other.SpeechTextAnalyticsProgramId ||
                    this.SpeechTextAnalyticsProgramId != null &&
                    this.SpeechTextAnalyticsProgramId.Equals(other.SpeechTextAnalyticsProgramId)
                ) &&
                (
                    this.StartTimeMs == other.StartTimeMs ||
                    this.StartTimeMs != null &&
                    this.StartTimeMs.Equals(other.StartTimeMs)
                ) &&
                (
                    this.OffsetMs == other.OffsetMs ||
                    this.OffsetMs != null &&
                    this.OffsetMs.Equals(other.OffsetMs)
                ) &&
                (
                    this.DurationMs == other.DurationMs ||
                    this.DurationMs != null &&
                    this.DurationMs.Equals(other.DurationMs)
                ) &&
                (
                    this.AgentAssistEnabled == other.AgentAssistEnabled ||
                    this.AgentAssistEnabled != null &&
                    this.AgentAssistEnabled.Equals(other.AgentAssistEnabled)
                ) &&
                (
                    this.VoiceTranscriptionEnabled == other.VoiceTranscriptionEnabled ||
                    this.VoiceTranscriptionEnabled != null &&
                    this.VoiceTranscriptionEnabled.Equals(other.VoiceTranscriptionEnabled)
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
                
                if (this.UtteranceId != null)
                    hash = hash * 59 + this.UtteranceId.GetHashCode();
                
                if (this.IsFinal != null)
                    hash = hash * 59 + this.IsFinal.GetHashCode();
                
                if (this.Channel != null)
                    hash = hash * 59 + this.Channel.GetHashCode();
                
                if (this.Alternatives != null)
                    hash = hash * 59 + this.Alternatives.GetHashCode();
                
                if (this.AgentAssistantId != null)
                    hash = hash * 59 + this.AgentAssistantId.GetHashCode();
                
                if (this.EngineId != null)
                    hash = hash * 59 + this.EngineId.GetHashCode();
                
                if (this.Dialect != null)
                    hash = hash * 59 + this.Dialect.GetHashCode();
                
                if (this.SpeechTextAnalyticsProgramId != null)
                    hash = hash * 59 + this.SpeechTextAnalyticsProgramId.GetHashCode();
                
                if (this.StartTimeMs != null)
                    hash = hash * 59 + this.StartTimeMs.GetHashCode();
                
                if (this.OffsetMs != null)
                    hash = hash * 59 + this.OffsetMs.GetHashCode();
                
                if (this.DurationMs != null)
                    hash = hash * 59 + this.DurationMs.GetHashCode();
                
                if (this.AgentAssistEnabled != null)
                    hash = hash * 59 + this.AgentAssistEnabled.GetHashCode();
                
                if (this.VoiceTranscriptionEnabled != null)
                    hash = hash * 59 + this.VoiceTranscriptionEnabled.GetHashCode();
                
                return hash;
            }
        }
    }

}
