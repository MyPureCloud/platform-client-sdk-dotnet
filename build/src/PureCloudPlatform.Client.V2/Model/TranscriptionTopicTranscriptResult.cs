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
    /// TranscriptionTopicTranscriptResult
    /// </summary>
    [DataContract]
    public partial class TranscriptionTopicTranscriptResult :  IEquatable<TranscriptionTopicTranscriptResult>
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
        /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptResult" /> class.
        /// </summary>
        /// <param name="UtteranceId">UtteranceId.</param>
        /// <param name="IsFinal">IsFinal.</param>
        /// <param name="Channel">Channel.</param>
        /// <param name="Alternatives">Alternatives.</param>
        /// <param name="AgentAssistantId">AgentAssistantId.</param>
        /// <param name="EngineProvider">EngineProvider.</param>
        /// <param name="EngineId">EngineId.</param>
        /// <param name="EngineName">EngineName.</param>
        /// <param name="Dialect">Dialect.</param>
        /// <param name="SpeechTextAnalyticsProgramId">SpeechTextAnalyticsProgramId.</param>
        /// <param name="AgentAssistEnabled">AgentAssistEnabled.</param>
        /// <param name="VoiceTranscriptionEnabled">VoiceTranscriptionEnabled.</param>
        public TranscriptionTopicTranscriptResult(string UtteranceId = null, bool? IsFinal = null, ChannelEnum? Channel = null, List<TranscriptionTopicTranscriptAlternative> Alternatives = null, string AgentAssistantId = null, string EngineProvider = null, string EngineId = null, string EngineName = null, string Dialect = null, string SpeechTextAnalyticsProgramId = null, bool? AgentAssistEnabled = null, bool? VoiceTranscriptionEnabled = null)
        {
            this.UtteranceId = UtteranceId;
            this.IsFinal = IsFinal;
            this.Channel = Channel;
            this.Alternatives = Alternatives;
            this.AgentAssistantId = AgentAssistantId;
            this.EngineProvider = EngineProvider;
            this.EngineId = EngineId;
            this.EngineName = EngineName;
            this.Dialect = Dialect;
            this.SpeechTextAnalyticsProgramId = SpeechTextAnalyticsProgramId;
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
        public List<TranscriptionTopicTranscriptAlternative> Alternatives { get; set; }



        /// <summary>
        /// Gets or Sets AgentAssistantId
        /// </summary>
        [DataMember(Name="agentAssistantId", EmitDefaultValue=false)]
        public string AgentAssistantId { get; set; }



        /// <summary>
        /// Gets or Sets EngineProvider
        /// </summary>
        [DataMember(Name="engineProvider", EmitDefaultValue=false)]
        public string EngineProvider { get; set; }



        /// <summary>
        /// Gets or Sets EngineId
        /// </summary>
        [DataMember(Name="engineId", EmitDefaultValue=false)]
        public string EngineId { get; set; }



        /// <summary>
        /// Gets or Sets EngineName
        /// </summary>
        [DataMember(Name="engineName", EmitDefaultValue=false)]
        public string EngineName { get; set; }



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
            sb.Append("class TranscriptionTopicTranscriptResult {\n");

            sb.Append("  UtteranceId: ").Append(UtteranceId).Append("\n");
            sb.Append("  IsFinal: ").Append(IsFinal).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
            sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
            sb.Append("  EngineProvider: ").Append(EngineProvider).Append("\n");
            sb.Append("  EngineId: ").Append(EngineId).Append("\n");
            sb.Append("  EngineName: ").Append(EngineName).Append("\n");
            sb.Append("  Dialect: ").Append(Dialect).Append("\n");
            sb.Append("  SpeechTextAnalyticsProgramId: ").Append(SpeechTextAnalyticsProgramId).Append("\n");
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
            return this.Equals(obj as TranscriptionTopicTranscriptResult);
        }

        /// <summary>
        /// Returns true if TranscriptionTopicTranscriptResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionTopicTranscriptResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionTopicTranscriptResult other)
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
                    this.EngineProvider == other.EngineProvider ||
                    this.EngineProvider != null &&
                    this.EngineProvider.Equals(other.EngineProvider)
                ) &&
                (
                    this.EngineId == other.EngineId ||
                    this.EngineId != null &&
                    this.EngineId.Equals(other.EngineId)
                ) &&
                (
                    this.EngineName == other.EngineName ||
                    this.EngineName != null &&
                    this.EngineName.Equals(other.EngineName)
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

                if (this.EngineProvider != null)
                    hash = hash * 59 + this.EngineProvider.GetHashCode();

                if (this.EngineId != null)
                    hash = hash * 59 + this.EngineId.GetHashCode();

                if (this.EngineName != null)
                    hash = hash * 59 + this.EngineName.GetHashCode();

                if (this.Dialect != null)
                    hash = hash * 59 + this.Dialect.GetHashCode();

                if (this.SpeechTextAnalyticsProgramId != null)
                    hash = hash * 59 + this.SpeechTextAnalyticsProgramId.GetHashCode();

                if (this.AgentAssistEnabled != null)
                    hash = hash * 59 + this.AgentAssistEnabled.GetHashCode();

                if (this.VoiceTranscriptionEnabled != null)
                    hash = hash * 59 + this.VoiceTranscriptionEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
