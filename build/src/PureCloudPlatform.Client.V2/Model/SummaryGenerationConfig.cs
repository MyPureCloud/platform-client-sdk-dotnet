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
    /// SummaryGenerationConfig
    /// </summary>
    [DataContract]
    public partial class SummaryGenerationConfig :  IEquatable<SummaryGenerationConfig>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryGenerationConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SummaryGenerationConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryGenerationConfig" /> class.
        /// </summary>
        /// <param name="Enabled">Copilot generated summary is enabled. (required).</param>
        /// <param name="SummarySetting">Configured summary setting object..</param>
        /// <param name="RetentionSeconds">Summary retention time in seconds. Can only be modified on the parent assistant..</param>
        /// <param name="OnDemandSummaryConfig">On-demand summary configuration..</param>
        /// <param name="ModelConfig">Model configuration for summarization..</param>
        public SummaryGenerationConfig(bool? Enabled = null, SummarySettingEntity SummarySetting = null, int? RetentionSeconds = null, OnDemandSummaryConfig OnDemandSummaryConfig = null, ModelConfig ModelConfig = null)
        {
            this.Enabled = Enabled;
            this.SummarySetting = SummarySetting;
            this.RetentionSeconds = RetentionSeconds;
            this.OnDemandSummaryConfig = OnDemandSummaryConfig;
            this.ModelConfig = ModelConfig;
            
        }
        


        /// <summary>
        /// Copilot generated summary is enabled.
        /// </summary>
        /// <value>Copilot generated summary is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Configured summary setting object.
        /// </summary>
        /// <value>Configured summary setting object.</value>
        [DataMember(Name="summarySetting", EmitDefaultValue=false)]
        public SummarySettingEntity SummarySetting { get; set; }



        /// <summary>
        /// Summary retention time in seconds. Can only be modified on the parent assistant.
        /// </summary>
        /// <value>Summary retention time in seconds. Can only be modified on the parent assistant.</value>
        [DataMember(Name="retentionSeconds", EmitDefaultValue=false)]
        public int? RetentionSeconds { get; set; }



        /// <summary>
        /// On-demand summary configuration.
        /// </summary>
        /// <value>On-demand summary configuration.</value>
        [DataMember(Name="onDemandSummaryConfig", EmitDefaultValue=false)]
        public OnDemandSummaryConfig OnDemandSummaryConfig { get; set; }



        /// <summary>
        /// Model configuration for summarization.
        /// </summary>
        /// <value>Model configuration for summarization.</value>
        [DataMember(Name="modelConfig", EmitDefaultValue=false)]
        public ModelConfig ModelConfig { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryGenerationConfig {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SummarySetting: ").Append(SummarySetting).Append("\n");
            sb.Append("  RetentionSeconds: ").Append(RetentionSeconds).Append("\n");
            sb.Append("  OnDemandSummaryConfig: ").Append(OnDemandSummaryConfig).Append("\n");
            sb.Append("  ModelConfig: ").Append(ModelConfig).Append("\n");
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
            return this.Equals(obj as SummaryGenerationConfig);
        }

        /// <summary>
        /// Returns true if SummaryGenerationConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of SummaryGenerationConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryGenerationConfig other)
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
                    this.SummarySetting == other.SummarySetting ||
                    this.SummarySetting != null &&
                    this.SummarySetting.Equals(other.SummarySetting)
                ) &&
                (
                    this.RetentionSeconds == other.RetentionSeconds ||
                    this.RetentionSeconds != null &&
                    this.RetentionSeconds.Equals(other.RetentionSeconds)
                ) &&
                (
                    this.OnDemandSummaryConfig == other.OnDemandSummaryConfig ||
                    this.OnDemandSummaryConfig != null &&
                    this.OnDemandSummaryConfig.Equals(other.OnDemandSummaryConfig)
                ) &&
                (
                    this.ModelConfig == other.ModelConfig ||
                    this.ModelConfig != null &&
                    this.ModelConfig.Equals(other.ModelConfig)
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

                if (this.SummarySetting != null)
                    hash = hash * 59 + this.SummarySetting.GetHashCode();

                if (this.RetentionSeconds != null)
                    hash = hash * 59 + this.RetentionSeconds.GetHashCode();

                if (this.OnDemandSummaryConfig != null)
                    hash = hash * 59 + this.OnDemandSummaryConfig.GetHashCode();

                if (this.ModelConfig != null)
                    hash = hash * 59 + this.ModelConfig.GetHashCode();

                return hash;
            }
        }
    }

}
