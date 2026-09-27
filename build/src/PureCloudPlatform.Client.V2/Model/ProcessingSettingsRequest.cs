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
    /// ProcessingSettingsRequest
    /// </summary>
    [DataContract]
    public partial class ProcessingSettingsRequest :  IEquatable<ProcessingSettingsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingSettingsRequest" /> class.
        /// </summary>
        /// <param name="SentimentAnalysisEnabled">Whether sentiment analysis is enabled for the program.</param>
        /// <param name="AgentEmpathyAnalysisEnabled">Whether agent empathy analysis is enabled for the program.</param>
        public ProcessingSettingsRequest(bool? SentimentAnalysisEnabled = null, bool? AgentEmpathyAnalysisEnabled = null)
        {
            this.SentimentAnalysisEnabled = SentimentAnalysisEnabled;
            this.AgentEmpathyAnalysisEnabled = AgentEmpathyAnalysisEnabled;
            
        }
        


        /// <summary>
        /// Whether sentiment analysis is enabled for the program
        /// </summary>
        /// <value>Whether sentiment analysis is enabled for the program</value>
        [DataMember(Name="sentimentAnalysisEnabled", EmitDefaultValue=false)]
        public bool? SentimentAnalysisEnabled { get; set; }



        /// <summary>
        /// Whether agent empathy analysis is enabled for the program
        /// </summary>
        /// <value>Whether agent empathy analysis is enabled for the program</value>
        [DataMember(Name="agentEmpathyAnalysisEnabled", EmitDefaultValue=false)]
        public bool? AgentEmpathyAnalysisEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessingSettingsRequest {\n");

            sb.Append("  SentimentAnalysisEnabled: ").Append(SentimentAnalysisEnabled).Append("\n");
            sb.Append("  AgentEmpathyAnalysisEnabled: ").Append(AgentEmpathyAnalysisEnabled).Append("\n");
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
            return this.Equals(obj as ProcessingSettingsRequest);
        }

        /// <summary>
        /// Returns true if ProcessingSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ProcessingSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessingSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SentimentAnalysisEnabled == other.SentimentAnalysisEnabled ||
                    this.SentimentAnalysisEnabled != null &&
                    this.SentimentAnalysisEnabled.Equals(other.SentimentAnalysisEnabled)
                ) &&
                (
                    this.AgentEmpathyAnalysisEnabled == other.AgentEmpathyAnalysisEnabled ||
                    this.AgentEmpathyAnalysisEnabled != null &&
                    this.AgentEmpathyAnalysisEnabled.Equals(other.AgentEmpathyAnalysisEnabled)
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
                if (this.SentimentAnalysisEnabled != null)
                    hash = hash * 59 + this.SentimentAnalysisEnabled.GetHashCode();

                if (this.AgentEmpathyAnalysisEnabled != null)
                    hash = hash * 59 + this.AgentEmpathyAnalysisEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
