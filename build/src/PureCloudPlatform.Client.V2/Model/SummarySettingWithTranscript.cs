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
    /// SummarySettingWithTranscript
    /// </summary>
    [DataContract]
    public partial class SummarySettingWithTranscript :  IEquatable<SummarySettingWithTranscript>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySettingWithTranscript" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SummarySettingWithTranscript() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySettingWithTranscript" /> class.
        /// </summary>
        /// <param name="Transcript">Example transcript to preview with the setting. (required).</param>
        /// <param name="SummarySetting">Summary setting to preview on the transcript. (required).</param>
        /// <param name="SummaryPreviewSessionId">Session identifier of the summary preview. (required).</param>
        public SummarySettingWithTranscript(string Transcript = null, SummarySetting SummarySetting = null, string SummaryPreviewSessionId = null)
        {
            this.Transcript = Transcript;
            this.SummarySetting = SummarySetting;
            this.SummaryPreviewSessionId = SummaryPreviewSessionId;
            
        }
        


        /// <summary>
        /// Example transcript to preview with the setting.
        /// </summary>
        /// <value>Example transcript to preview with the setting.</value>
        [DataMember(Name="transcript", EmitDefaultValue=false)]
        public string Transcript { get; set; }



        /// <summary>
        /// Summary setting to preview on the transcript.
        /// </summary>
        /// <value>Summary setting to preview on the transcript.</value>
        [DataMember(Name="summarySetting", EmitDefaultValue=false)]
        public SummarySetting SummarySetting { get; set; }



        /// <summary>
        /// Session identifier of the summary preview.
        /// </summary>
        /// <value>Session identifier of the summary preview.</value>
        [DataMember(Name="summaryPreviewSessionId", EmitDefaultValue=false)]
        public string SummaryPreviewSessionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummarySettingWithTranscript {\n");

            sb.Append("  Transcript: ").Append(Transcript).Append("\n");
            sb.Append("  SummarySetting: ").Append(SummarySetting).Append("\n");
            sb.Append("  SummaryPreviewSessionId: ").Append(SummaryPreviewSessionId).Append("\n");
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
            return this.Equals(obj as SummarySettingWithTranscript);
        }

        /// <summary>
        /// Returns true if SummarySettingWithTranscript instances are equal
        /// </summary>
        /// <param name="other">Instance of SummarySettingWithTranscript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummarySettingWithTranscript other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Transcript == other.Transcript ||
                    this.Transcript != null &&
                    this.Transcript.Equals(other.Transcript)
                ) &&
                (
                    this.SummarySetting == other.SummarySetting ||
                    this.SummarySetting != null &&
                    this.SummarySetting.Equals(other.SummarySetting)
                ) &&
                (
                    this.SummaryPreviewSessionId == other.SummaryPreviewSessionId ||
                    this.SummaryPreviewSessionId != null &&
                    this.SummaryPreviewSessionId.Equals(other.SummaryPreviewSessionId)
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
                if (this.Transcript != null)
                    hash = hash * 59 + this.Transcript.GetHashCode();

                if (this.SummarySetting != null)
                    hash = hash * 59 + this.SummarySetting.GetHashCode();

                if (this.SummaryPreviewSessionId != null)
                    hash = hash * 59 + this.SummaryPreviewSessionId.GetHashCode();

                return hash;
            }
        }
    }

}
