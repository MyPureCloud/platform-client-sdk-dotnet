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
    /// Expanded audio format metadata for Architect prompt resources.
    /// </summary>
    [DataContract]
    public partial class ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat :  IEquatable<ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat>
    {
        /// <summary>
        /// Audio encoding format.
        /// </summary>
        /// <value>Audio encoding format.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EncodingEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ulaw for "ULAW"
            /// </summary>
            [EnumMember(Value = "ULAW")]
            Ulaw,
            
            /// <summary>
            /// Enum Alaw for "ALAW"
            /// </summary>
            [EnumMember(Value = "ALAW")]
            Alaw,
            
            /// <summary>
            /// Enum Pcm for "PCM"
            /// </summary>
            [EnumMember(Value = "PCM")]
            Pcm
        }
        /// <summary>
        /// Audio encoding format.
        /// </summary>
        /// <value>Audio encoding format.</value>
        [DataMember(Name="encoding", EmitDefaultValue=false)]
        public EncodingEnum? Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat" /> class.
        /// </summary>
        /// <param name="Channels">Number of audio channels (for example, 1 for mono or 2 for stereo)..</param>
        /// <param name="BitsPerSample">Number of bits used to represent each audio sample (for example, 8 or 16)..</param>
        /// <param name="SampleRate">Sample rate in hertz (Hz), for example 8000 or 16000..</param>
        /// <param name="Encoding">Audio encoding format..</param>
        public ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat(long? Channels = null, long? BitsPerSample = null, long? SampleRate = null, EncodingEnum? Encoding = null)
        {
            this.Channels = Channels;
            this.BitsPerSample = BitsPerSample;
            this.SampleRate = SampleRate;
            this.Encoding = Encoding;
            
        }
        


        /// <summary>
        /// Number of audio channels (for example, 1 for mono or 2 for stereo).
        /// </summary>
        /// <value>Number of audio channels (for example, 1 for mono or 2 for stereo).</value>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public long? Channels { get; set; }



        /// <summary>
        /// Number of bits used to represent each audio sample (for example, 8 or 16).
        /// </summary>
        /// <value>Number of bits used to represent each audio sample (for example, 8 or 16).</value>
        [DataMember(Name="bitsPerSample", EmitDefaultValue=false)]
        public long? BitsPerSample { get; set; }



        /// <summary>
        /// Sample rate in hertz (Hz), for example 8000 or 16000.
        /// </summary>
        /// <value>Sample rate in hertz (Hz), for example 8000 or 16000.</value>
        [DataMember(Name="sampleRate", EmitDefaultValue=false)]
        public long? SampleRate { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat {\n");

            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  BitsPerSample: ").Append(BitsPerSample).Append("\n");
            sb.Append("  SampleRate: ").Append(SampleRate).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
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
            return this.Equals(obj as ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat);
        }

        /// <summary>
        /// Returns true if ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectSystemPromptResourceNotificationPromptResourceAudioFormat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Channels == other.Channels ||
                    this.Channels != null &&
                    this.Channels.Equals(other.Channels)
                ) &&
                (
                    this.BitsPerSample == other.BitsPerSample ||
                    this.BitsPerSample != null &&
                    this.BitsPerSample.Equals(other.BitsPerSample)
                ) &&
                (
                    this.SampleRate == other.SampleRate ||
                    this.SampleRate != null &&
                    this.SampleRate.Equals(other.SampleRate)
                ) &&
                (
                    this.Encoding == other.Encoding ||
                    this.Encoding != null &&
                    this.Encoding.Equals(other.Encoding)
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
                if (this.Channels != null)
                    hash = hash * 59 + this.Channels.GetHashCode();

                if (this.BitsPerSample != null)
                    hash = hash * 59 + this.BitsPerSample.GetHashCode();

                if (this.SampleRate != null)
                    hash = hash * 59 + this.SampleRate.GetHashCode();

                if (this.Encoding != null)
                    hash = hash * 59 + this.Encoding.GetHashCode();

                return hash;
            }
        }
    }

}
