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
    /// TranscriptionSettings
    /// </summary>
    [DataContract]
    public partial class TranscriptionSettings :  IEquatable<TranscriptionSettings>
    {
        /// <summary>
        /// Setting to enable/disable transcription capability
        /// </summary>
        /// <value>Setting to enable/disable transcription capability</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TranscriptionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Disabled for "Disabled"
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled,
            
            /// <summary>
            /// Enum Enabledglobally for "EnabledGlobally"
            /// </summary>
            [EnumMember(Value = "EnabledGlobally")]
            Enabledglobally,
            
            /// <summary>
            /// Enum Enabledqueueflow for "EnabledQueueFlow"
            /// </summary>
            [EnumMember(Value = "EnabledQueueFlow")]
            Enabledqueueflow
        }
        /// <summary>
        /// Setting to enable/disable transcription capability
        /// </summary>
        /// <value>Setting to enable/disable transcription capability</value>
        [DataMember(Name="transcription", EmitDefaultValue=false)]
        public TranscriptionEnum? Transcription { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TranscriptionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSettings" /> class.
        /// </summary>
        /// <param name="Transcription">Setting to enable/disable transcription capability (required).</param>
        /// <param name="TranscriptionConfidenceThreshold">Configure confidence threshold. The possible values are from 1 to 100. (required).</param>
        /// <param name="LowLatencyTranscriptionEnabled">Boolean flag indicating whether low latency transcription via Notification API is enabled.</param>
        /// <param name="ContentSearchEnabled">Setting to enable/disable content search.</param>
        public TranscriptionSettings(TranscriptionEnum? Transcription = null, int? TranscriptionConfidenceThreshold = null, bool? LowLatencyTranscriptionEnabled = null, bool? ContentSearchEnabled = null)
        {
            this.Transcription = Transcription;
            this.TranscriptionConfidenceThreshold = TranscriptionConfidenceThreshold;
            this.LowLatencyTranscriptionEnabled = LowLatencyTranscriptionEnabled;
            this.ContentSearchEnabled = ContentSearchEnabled;
            
        }
        




        /// <summary>
        /// Configure confidence threshold. The possible values are from 1 to 100.
        /// </summary>
        /// <value>Configure confidence threshold. The possible values are from 1 to 100.</value>
        [DataMember(Name="transcriptionConfidenceThreshold", EmitDefaultValue=false)]
        public int? TranscriptionConfidenceThreshold { get; set; }



        /// <summary>
        /// Boolean flag indicating whether low latency transcription via Notification API is enabled
        /// </summary>
        /// <value>Boolean flag indicating whether low latency transcription via Notification API is enabled</value>
        [DataMember(Name="lowLatencyTranscriptionEnabled", EmitDefaultValue=false)]
        public bool? LowLatencyTranscriptionEnabled { get; set; }



        /// <summary>
        /// Setting to enable/disable content search
        /// </summary>
        /// <value>Setting to enable/disable content search</value>
        [DataMember(Name="contentSearchEnabled", EmitDefaultValue=false)]
        public bool? ContentSearchEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionSettings {\n");

            sb.Append("  Transcription: ").Append(Transcription).Append("\n");
            sb.Append("  TranscriptionConfidenceThreshold: ").Append(TranscriptionConfidenceThreshold).Append("\n");
            sb.Append("  LowLatencyTranscriptionEnabled: ").Append(LowLatencyTranscriptionEnabled).Append("\n");
            sb.Append("  ContentSearchEnabled: ").Append(ContentSearchEnabled).Append("\n");
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
            return this.Equals(obj as TranscriptionSettings);
        }

        /// <summary>
        /// Returns true if TranscriptionSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Transcription == other.Transcription ||
                    this.Transcription != null &&
                    this.Transcription.Equals(other.Transcription)
                ) &&
                (
                    this.TranscriptionConfidenceThreshold == other.TranscriptionConfidenceThreshold ||
                    this.TranscriptionConfidenceThreshold != null &&
                    this.TranscriptionConfidenceThreshold.Equals(other.TranscriptionConfidenceThreshold)
                ) &&
                (
                    this.LowLatencyTranscriptionEnabled == other.LowLatencyTranscriptionEnabled ||
                    this.LowLatencyTranscriptionEnabled != null &&
                    this.LowLatencyTranscriptionEnabled.Equals(other.LowLatencyTranscriptionEnabled)
                ) &&
                (
                    this.ContentSearchEnabled == other.ContentSearchEnabled ||
                    this.ContentSearchEnabled != null &&
                    this.ContentSearchEnabled.Equals(other.ContentSearchEnabled)
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
                if (this.Transcription != null)
                    hash = hash * 59 + this.Transcription.GetHashCode();

                if (this.TranscriptionConfidenceThreshold != null)
                    hash = hash * 59 + this.TranscriptionConfidenceThreshold.GetHashCode();

                if (this.LowLatencyTranscriptionEnabled != null)
                    hash = hash * 59 + this.LowLatencyTranscriptionEnabled.GetHashCode();

                if (this.ContentSearchEnabled != null)
                    hash = hash * 59 + this.ContentSearchEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
