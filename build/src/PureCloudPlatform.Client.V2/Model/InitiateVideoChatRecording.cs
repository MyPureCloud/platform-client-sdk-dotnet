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
    /// InitiateVideoChatRecording
    /// </summary>
    [DataContract]
    public partial class InitiateVideoChatRecording :  IEquatable<InitiateVideoChatRecording>
    {
        /// <summary>
        /// The type of video recording to capture.
        /// </summary>
        /// <value>The type of video recording to capture.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VideoChatRecordingCaptureTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Audiovideo for "AudioVideo"
            /// </summary>
            [EnumMember(Value = "AudioVideo")]
            Audiovideo,
            
            /// <summary>
            /// Enum Audioonly for "AudioOnly"
            /// </summary>
            [EnumMember(Value = "AudioOnly")]
            Audioonly
        }
        /// <summary>
        /// The type of video recording to capture.
        /// </summary>
        /// <value>The type of video recording to capture.</value>
        [DataMember(Name="videoChatRecordingCaptureType", EmitDefaultValue=false)]
        public VideoChatRecordingCaptureTypeEnum? VideoChatRecordingCaptureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateVideoChatRecording" /> class.
        /// </summary>
        /// <param name="VideoChatRecordingCaptureType">The type of video recording to capture..</param>
        /// <param name="ArchiveRetention">Archive retention settings for the initiated video chat recording..</param>
        /// <param name="DeleteRetention">Delete retention settings for the initiated video chat recording..</param>
        public InitiateVideoChatRecording(VideoChatRecordingCaptureTypeEnum? VideoChatRecordingCaptureType = null, ArchiveRetention ArchiveRetention = null, DeleteRetention DeleteRetention = null)
        {
            this.VideoChatRecordingCaptureType = VideoChatRecordingCaptureType;
            this.ArchiveRetention = ArchiveRetention;
            this.DeleteRetention = DeleteRetention;
            
        }
        




        /// <summary>
        /// Archive retention settings for the initiated video chat recording.
        /// </summary>
        /// <value>Archive retention settings for the initiated video chat recording.</value>
        [DataMember(Name="archiveRetention", EmitDefaultValue=false)]
        public ArchiveRetention ArchiveRetention { get; set; }



        /// <summary>
        /// Delete retention settings for the initiated video chat recording.
        /// </summary>
        /// <value>Delete retention settings for the initiated video chat recording.</value>
        [DataMember(Name="deleteRetention", EmitDefaultValue=false)]
        public DeleteRetention DeleteRetention { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateVideoChatRecording {\n");

            sb.Append("  VideoChatRecordingCaptureType: ").Append(VideoChatRecordingCaptureType).Append("\n");
            sb.Append("  ArchiveRetention: ").Append(ArchiveRetention).Append("\n");
            sb.Append("  DeleteRetention: ").Append(DeleteRetention).Append("\n");
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
            return this.Equals(obj as InitiateVideoChatRecording);
        }

        /// <summary>
        /// Returns true if InitiateVideoChatRecording instances are equal
        /// </summary>
        /// <param name="other">Instance of InitiateVideoChatRecording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateVideoChatRecording other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.VideoChatRecordingCaptureType == other.VideoChatRecordingCaptureType ||
                    this.VideoChatRecordingCaptureType != null &&
                    this.VideoChatRecordingCaptureType.Equals(other.VideoChatRecordingCaptureType)
                ) &&
                (
                    this.ArchiveRetention == other.ArchiveRetention ||
                    this.ArchiveRetention != null &&
                    this.ArchiveRetention.Equals(other.ArchiveRetention)
                ) &&
                (
                    this.DeleteRetention == other.DeleteRetention ||
                    this.DeleteRetention != null &&
                    this.DeleteRetention.Equals(other.DeleteRetention)
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
                if (this.VideoChatRecordingCaptureType != null)
                    hash = hash * 59 + this.VideoChatRecordingCaptureType.GetHashCode();

                if (this.ArchiveRetention != null)
                    hash = hash * 59 + this.ArchiveRetention.GetHashCode();

                if (this.DeleteRetention != null)
                    hash = hash * 59 + this.DeleteRetention.GetHashCode();

                return hash;
            }
        }
    }

}
