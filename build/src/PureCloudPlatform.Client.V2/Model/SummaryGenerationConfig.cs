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
        public SummaryGenerationConfig(bool? Enabled = null, SummarySettingEntity SummarySetting = null)
        {
            this.Enabled = Enabled;
            this.SummarySetting = SummarySetting;
            
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryGenerationConfig {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SummarySetting: ").Append(SummarySetting).Append("\n");
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

                return hash;
            }
        }
    }

}
