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
    /// RecordingEventMediaResult
    /// </summary>
    [DataContract]
    public partial class RecordingEventMediaResult :  IEquatable<RecordingEventMediaResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingEventMediaResult" /> class.
        /// </summary>
        /// <param name="ChannelId">ChannelId.</param>
        /// <param name="WaveUri">WaveUri.</param>
        /// <param name="MediaUri">MediaUri.</param>
        /// <param name="WaveformData">WaveformData.</param>
        public RecordingEventMediaResult(string ChannelId = null, string WaveUri = null, string MediaUri = null, List<double?> WaveformData = null)
        {
            this.ChannelId = ChannelId;
            this.WaveUri = WaveUri;
            this.MediaUri = MediaUri;
            this.WaveformData = WaveformData;
            
        }
        


        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public string ChannelId { get; set; }



        /// <summary>
        /// Gets or Sets WaveUri
        /// </summary>
        [DataMember(Name="waveUri", EmitDefaultValue=false)]
        public string WaveUri { get; set; }



        /// <summary>
        /// Gets or Sets MediaUri
        /// </summary>
        [DataMember(Name="mediaUri", EmitDefaultValue=false)]
        public string MediaUri { get; set; }



        /// <summary>
        /// Gets or Sets WaveformData
        /// </summary>
        [DataMember(Name="waveformData", EmitDefaultValue=false)]
        public List<double?> WaveformData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingEventMediaResult {\n");

            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  WaveUri: ").Append(WaveUri).Append("\n");
            sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
            sb.Append("  WaveformData: ").Append(WaveformData).Append("\n");
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
            return this.Equals(obj as RecordingEventMediaResult);
        }

        /// <summary>
        /// Returns true if RecordingEventMediaResult instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingEventMediaResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingEventMediaResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) &&
                (
                    this.WaveUri == other.WaveUri ||
                    this.WaveUri != null &&
                    this.WaveUri.Equals(other.WaveUri)
                ) &&
                (
                    this.MediaUri == other.MediaUri ||
                    this.MediaUri != null &&
                    this.MediaUri.Equals(other.MediaUri)
                ) &&
                (
                    this.WaveformData == other.WaveformData ||
                    this.WaveformData != null &&
                    this.WaveformData.SequenceEqual(other.WaveformData)
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
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();

                if (this.WaveUri != null)
                    hash = hash * 59 + this.WaveUri.GetHashCode();

                if (this.MediaUri != null)
                    hash = hash * 59 + this.MediaUri.GetHashCode();

                if (this.WaveformData != null)
                    hash = hash * 59 + this.WaveformData.GetHashCode();

                return hash;
            }
        }
    }

}
