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
    /// MediaEndpointStatistics
    /// </summary>
    [DataContract]
    public partial class MediaEndpointStatistics :  IEquatable<MediaEndpointStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEndpointStatistics" /> class.
        /// </summary>
        /// <param name="Trunk">Trunk information utilized when creating the media endpoint.</param>
        /// <param name="Station">Station information associated with media endpoint.</param>
        /// <param name="User">User information associated media endpoint.</param>
        /// <param name="Ice">The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245.</param>
        /// <param name="Rtp">Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550.</param>
        /// <param name="ReconnectAttemptCount">Media reconnect attempt count.</param>
        public MediaEndpointStatistics(MediaStatisticsTrunkInfo Trunk = null, NamedEntity Station = null, NamedEntity User = null, MediaIceStatistics Ice = null, MediaRtpStatistics Rtp = null, int? ReconnectAttemptCount = null)
        {
            this.Trunk = Trunk;
            this.Station = Station;
            this.User = User;
            this.Ice = Ice;
            this.Rtp = Rtp;
            this.ReconnectAttemptCount = ReconnectAttemptCount;
            
        }
        


        /// <summary>
        /// Trunk information utilized when creating the media endpoint
        /// </summary>
        /// <value>Trunk information utilized when creating the media endpoint</value>
        [DataMember(Name="trunk", EmitDefaultValue=false)]
        public MediaStatisticsTrunkInfo Trunk { get; set; }



        /// <summary>
        /// Station information associated with media endpoint
        /// </summary>
        /// <value>Station information associated with media endpoint</value>
        [DataMember(Name="station", EmitDefaultValue=false)]
        public NamedEntity Station { get; set; }



        /// <summary>
        /// User information associated media endpoint
        /// </summary>
        /// <value>User information associated media endpoint</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public NamedEntity User { get; set; }



        /// <summary>
        /// The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245
        /// </summary>
        /// <value>The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245</value>
        [DataMember(Name="ice", EmitDefaultValue=false)]
        public MediaIceStatistics Ice { get; set; }



        /// <summary>
        /// Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550
        /// </summary>
        /// <value>Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550</value>
        [DataMember(Name="rtp", EmitDefaultValue=false)]
        public MediaRtpStatistics Rtp { get; set; }



        /// <summary>
        /// Media reconnect attempt count
        /// </summary>
        /// <value>Media reconnect attempt count</value>
        [DataMember(Name="reconnectAttemptCount", EmitDefaultValue=false)]
        public int? ReconnectAttemptCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaEndpointStatistics {\n");

            sb.Append("  Trunk: ").Append(Trunk).Append("\n");
            sb.Append("  Station: ").Append(Station).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Ice: ").Append(Ice).Append("\n");
            sb.Append("  Rtp: ").Append(Rtp).Append("\n");
            sb.Append("  ReconnectAttemptCount: ").Append(ReconnectAttemptCount).Append("\n");
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
            return this.Equals(obj as MediaEndpointStatistics);
        }

        /// <summary>
        /// Returns true if MediaEndpointStatistics instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaEndpointStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaEndpointStatistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Trunk == other.Trunk ||
                    this.Trunk != null &&
                    this.Trunk.Equals(other.Trunk)
                ) &&
                (
                    this.Station == other.Station ||
                    this.Station != null &&
                    this.Station.Equals(other.Station)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Ice == other.Ice ||
                    this.Ice != null &&
                    this.Ice.Equals(other.Ice)
                ) &&
                (
                    this.Rtp == other.Rtp ||
                    this.Rtp != null &&
                    this.Rtp.Equals(other.Rtp)
                ) &&
                (
                    this.ReconnectAttemptCount == other.ReconnectAttemptCount ||
                    this.ReconnectAttemptCount != null &&
                    this.ReconnectAttemptCount.Equals(other.ReconnectAttemptCount)
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
                if (this.Trunk != null)
                    hash = hash * 59 + this.Trunk.GetHashCode();

                if (this.Station != null)
                    hash = hash * 59 + this.Station.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Ice != null)
                    hash = hash * 59 + this.Ice.GetHashCode();

                if (this.Rtp != null)
                    hash = hash * 59 + this.Rtp.GetHashCode();

                if (this.ReconnectAttemptCount != null)
                    hash = hash * 59 + this.ReconnectAttemptCount.GetHashCode();

                return hash;
            }
        }
    }

}
