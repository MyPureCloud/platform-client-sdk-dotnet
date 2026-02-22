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
    /// Copilot
    /// </summary>
    [DataContract]
    public partial class Copilot :  IEquatable<Copilot>
    {
        /// <summary>
        /// Language understanding engine type.
        /// </summary>
        /// <value>Language understanding engine type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NluEngineTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Nluv3 for "NluV3"
            /// </summary>
            [EnumMember(Value = "NluV3")]
            Nluv3
        }
        /// <summary>
        /// Language understanding engine type.
        /// </summary>
        /// <value>Language understanding engine type.</value>
        [DataMember(Name="nluEngineType", EmitDefaultValue=false)]
        public NluEngineTypeEnum? NluEngineType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Copilot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Copilot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Copilot" /> class.
        /// </summary>
        /// <param name="LiveOnQueue">Copilot is live on selected queue. (required).</param>
        /// <param name="DefaultLanguage">Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified. (required).</param>
        /// <param name="KnowledgeAnswerConfig">Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead..</param>
        /// <param name="SummaryGenerationConfig">Copilot generated summary configuration..</param>
        /// <param name="WrapupCodePredictionConfig">Copilot generated wrapup code prediction configuration..</param>
        /// <param name="AnswerGenerationConfig">Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead..</param>
        /// <param name="NluEngineType">Language understanding engine type..</param>
        /// <param name="NluConfig">NLU configuration..</param>
        /// <param name="RuleEngineConfig">Rule engine configuration..</param>
        /// <param name="AutoSearchConfig">Auto search configuration..</param>
        /// <param name="ManualSearchConfig">Manual Search configuration..</param>
        public Copilot(bool? LiveOnQueue = null, string DefaultLanguage = null, KnowledgeAnswerConfig KnowledgeAnswerConfig = null, SummaryGenerationConfig SummaryGenerationConfig = null, WrapupCodePredictionConfig WrapupCodePredictionConfig = null, AnswerGenerationConfig AnswerGenerationConfig = null, NluEngineTypeEnum? NluEngineType = null, NluConfig NluConfig = null, RuleEngineConfig RuleEngineConfig = null, AutoSearchConfig AutoSearchConfig = null, ManualSearchConfig ManualSearchConfig = null)
        {
            this.LiveOnQueue = LiveOnQueue;
            this.DefaultLanguage = DefaultLanguage;
            this.KnowledgeAnswerConfig = KnowledgeAnswerConfig;
            this.SummaryGenerationConfig = SummaryGenerationConfig;
            this.WrapupCodePredictionConfig = WrapupCodePredictionConfig;
            this.AnswerGenerationConfig = AnswerGenerationConfig;
            this.NluEngineType = NluEngineType;
            this.NluConfig = NluConfig;
            this.RuleEngineConfig = RuleEngineConfig;
            this.AutoSearchConfig = AutoSearchConfig;
            this.ManualSearchConfig = ManualSearchConfig;
            
        }
        


        /// <summary>
        /// Copilot is enabled.
        /// </summary>
        /// <value>Copilot is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; private set; }



        /// <summary>
        /// Copilot is live on selected queue.
        /// </summary>
        /// <value>Copilot is live on selected queue.</value>
        [DataMember(Name="liveOnQueue", EmitDefaultValue=false)]
        public bool? LiveOnQueue { get; set; }



        /// <summary>
        /// Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified.
        /// </summary>
        /// <value>Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified.</value>
        [DataMember(Name="defaultLanguage", EmitDefaultValue=false)]
        public string DefaultLanguage { get; set; }



        /// <summary>
        /// Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead.
        /// </summary>
        /// <value>Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead.</value>
        [DataMember(Name="knowledgeAnswerConfig", EmitDefaultValue=false)]
        public KnowledgeAnswerConfig KnowledgeAnswerConfig { get; set; }



        /// <summary>
        /// Copilot generated summary configuration.
        /// </summary>
        /// <value>Copilot generated summary configuration.</value>
        [DataMember(Name="summaryGenerationConfig", EmitDefaultValue=false)]
        public SummaryGenerationConfig SummaryGenerationConfig { get; set; }



        /// <summary>
        /// Copilot generated wrapup code prediction configuration.
        /// </summary>
        /// <value>Copilot generated wrapup code prediction configuration.</value>
        [DataMember(Name="wrapupCodePredictionConfig", EmitDefaultValue=false)]
        public WrapupCodePredictionConfig WrapupCodePredictionConfig { get; set; }



        /// <summary>
        /// Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead.
        /// </summary>
        /// <value>Deprecated: Please use AutoSearchConfig and ManualSearchConfig fields instead.</value>
        [DataMember(Name="answerGenerationConfig", EmitDefaultValue=false)]
        public AnswerGenerationConfig AnswerGenerationConfig { get; set; }





        /// <summary>
        /// NLU configuration.
        /// </summary>
        /// <value>NLU configuration.</value>
        [DataMember(Name="nluConfig", EmitDefaultValue=false)]
        public NluConfig NluConfig { get; set; }



        /// <summary>
        /// Rule engine configuration.
        /// </summary>
        /// <value>Rule engine configuration.</value>
        [DataMember(Name="ruleEngineConfig", EmitDefaultValue=false)]
        public RuleEngineConfig RuleEngineConfig { get; set; }



        /// <summary>
        /// Auto search configuration.
        /// </summary>
        /// <value>Auto search configuration.</value>
        [DataMember(Name="autoSearchConfig", EmitDefaultValue=false)]
        public AutoSearchConfig AutoSearchConfig { get; set; }



        /// <summary>
        /// Manual Search configuration.
        /// </summary>
        /// <value>Manual Search configuration.</value>
        [DataMember(Name="manualSearchConfig", EmitDefaultValue=false)]
        public ManualSearchConfig ManualSearchConfig { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Copilot {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  LiveOnQueue: ").Append(LiveOnQueue).Append("\n");
            sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
            sb.Append("  KnowledgeAnswerConfig: ").Append(KnowledgeAnswerConfig).Append("\n");
            sb.Append("  SummaryGenerationConfig: ").Append(SummaryGenerationConfig).Append("\n");
            sb.Append("  WrapupCodePredictionConfig: ").Append(WrapupCodePredictionConfig).Append("\n");
            sb.Append("  AnswerGenerationConfig: ").Append(AnswerGenerationConfig).Append("\n");
            sb.Append("  NluEngineType: ").Append(NluEngineType).Append("\n");
            sb.Append("  NluConfig: ").Append(NluConfig).Append("\n");
            sb.Append("  RuleEngineConfig: ").Append(RuleEngineConfig).Append("\n");
            sb.Append("  AutoSearchConfig: ").Append(AutoSearchConfig).Append("\n");
            sb.Append("  ManualSearchConfig: ").Append(ManualSearchConfig).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Copilot);
        }

        /// <summary>
        /// Returns true if Copilot instances are equal
        /// </summary>
        /// <param name="other">Instance of Copilot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Copilot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.LiveOnQueue == other.LiveOnQueue ||
                    this.LiveOnQueue != null &&
                    this.LiveOnQueue.Equals(other.LiveOnQueue)
                ) &&
                (
                    this.DefaultLanguage == other.DefaultLanguage ||
                    this.DefaultLanguage != null &&
                    this.DefaultLanguage.Equals(other.DefaultLanguage)
                ) &&
                (
                    this.KnowledgeAnswerConfig == other.KnowledgeAnswerConfig ||
                    this.KnowledgeAnswerConfig != null &&
                    this.KnowledgeAnswerConfig.Equals(other.KnowledgeAnswerConfig)
                ) &&
                (
                    this.SummaryGenerationConfig == other.SummaryGenerationConfig ||
                    this.SummaryGenerationConfig != null &&
                    this.SummaryGenerationConfig.Equals(other.SummaryGenerationConfig)
                ) &&
                (
                    this.WrapupCodePredictionConfig == other.WrapupCodePredictionConfig ||
                    this.WrapupCodePredictionConfig != null &&
                    this.WrapupCodePredictionConfig.Equals(other.WrapupCodePredictionConfig)
                ) &&
                (
                    this.AnswerGenerationConfig == other.AnswerGenerationConfig ||
                    this.AnswerGenerationConfig != null &&
                    this.AnswerGenerationConfig.Equals(other.AnswerGenerationConfig)
                ) &&
                (
                    this.NluEngineType == other.NluEngineType ||
                    this.NluEngineType != null &&
                    this.NluEngineType.Equals(other.NluEngineType)
                ) &&
                (
                    this.NluConfig == other.NluConfig ||
                    this.NluConfig != null &&
                    this.NluConfig.Equals(other.NluConfig)
                ) &&
                (
                    this.RuleEngineConfig == other.RuleEngineConfig ||
                    this.RuleEngineConfig != null &&
                    this.RuleEngineConfig.Equals(other.RuleEngineConfig)
                ) &&
                (
                    this.AutoSearchConfig == other.AutoSearchConfig ||
                    this.AutoSearchConfig != null &&
                    this.AutoSearchConfig.Equals(other.AutoSearchConfig)
                ) &&
                (
                    this.ManualSearchConfig == other.ManualSearchConfig ||
                    this.ManualSearchConfig != null &&
                    this.ManualSearchConfig.Equals(other.ManualSearchConfig)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.LiveOnQueue != null)
                    hash = hash * 59 + this.LiveOnQueue.GetHashCode();

                if (this.DefaultLanguage != null)
                    hash = hash * 59 + this.DefaultLanguage.GetHashCode();

                if (this.KnowledgeAnswerConfig != null)
                    hash = hash * 59 + this.KnowledgeAnswerConfig.GetHashCode();

                if (this.SummaryGenerationConfig != null)
                    hash = hash * 59 + this.SummaryGenerationConfig.GetHashCode();

                if (this.WrapupCodePredictionConfig != null)
                    hash = hash * 59 + this.WrapupCodePredictionConfig.GetHashCode();

                if (this.AnswerGenerationConfig != null)
                    hash = hash * 59 + this.AnswerGenerationConfig.GetHashCode();

                if (this.NluEngineType != null)
                    hash = hash * 59 + this.NluEngineType.GetHashCode();

                if (this.NluConfig != null)
                    hash = hash * 59 + this.NluConfig.GetHashCode();

                if (this.RuleEngineConfig != null)
                    hash = hash * 59 + this.RuleEngineConfig.GetHashCode();

                if (this.AutoSearchConfig != null)
                    hash = hash * 59 + this.AutoSearchConfig.GetHashCode();

                if (this.ManualSearchConfig != null)
                    hash = hash * 59 + this.ManualSearchConfig.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
