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
        /// Source type of media endpoint
        /// </summary>
        /// <value>Source type of media endpoint</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Client for "Client"
            /// </summary>
            [EnumMember(Value = "Client")]
            Client,
            
            /// <summary>
            /// Enum Server for "Server"
            /// </summary>
            [EnumMember(Value = "Server")]
            Server
        }
        /// <summary>
        /// Source type of media endpoint
        /// </summary>
        /// <value>Source type of media endpoint</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEndpointStatistics" /> class.
        /// </summary>
        /// <param name="Trunk">Trunk information utilized when creating the media endpoint.</param>
        /// <param name="Station">Station information associated with media endpoint.</param>
        /// <param name="User">User information associated media endpoint.</param>
        /// <param name="Ice">The ICE protocol statistics and details. Reference: https://www.rfc-editor.org/rfc/rfc5245.</param>
        /// <param name="Rtp">Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550.</param>
        /// <param name="ReconnectAttempts">Media reconnect attempt count.</param>
        /// <param name="SourceType">Source type of media endpoint.</param>
        /// <param name="ClientInfo">Client information associated with media endpoint.</param>
        /// <param name="DateCreated">Media endpoint statistics creation time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateProcessed">Media endpoint statistics processed time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public MediaEndpointStatistics(MediaStatisticsTrunkInfo Trunk = null, NamedEntity Station = null, NamedEntity User = null, MediaIceStatistics Ice = null, MediaRtpStatistics Rtp = null, int? ReconnectAttempts = null, SourceTypeEnum? SourceType = null, MediaStatisticsClientInfo ClientInfo = null, DateTime? DateCreated = null, DateTime? DateProcessed = null)
        {
            this.Trunk = Trunk;
            this.Station = Station;
            this.User = User;
            this.Ice = Ice;
            this.Rtp = Rtp;
            this.ReconnectAttempts = ReconnectAttempts;
            this.SourceType = SourceType;
            this.ClientInfo = ClientInfo;
            this.DateCreated = DateCreated;
            this.DateProcessed = DateProcessed;
            
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
        [DataMember(Name="reconnectAttempts", EmitDefaultValue=false)]
        public int? ReconnectAttempts { get; set; }





        /// <summary>
        /// Client information associated with media endpoint
        /// </summary>
        /// <value>Client information associated with media endpoint</value>
        [DataMember(Name="clientInfo", EmitDefaultValue=false)]
        public MediaStatisticsClientInfo ClientInfo { get; set; }



        /// <summary>
        /// Media endpoint statistics creation time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Media endpoint statistics creation time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Media endpoint statistics processed time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Media endpoint statistics processed time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateProcessed", EmitDefaultValue=false)]
        public DateTime? DateProcessed { get; set; }


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
            sb.Append("  ReconnectAttempts: ").Append(ReconnectAttempts).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  ClientInfo: ").Append(ClientInfo).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateProcessed: ").Append(DateProcessed).Append("\n");
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
                    this.ReconnectAttempts == other.ReconnectAttempts ||
                    this.ReconnectAttempts != null &&
                    this.ReconnectAttempts.Equals(other.ReconnectAttempts)
                ) &&
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
                ) &&
                (
                    this.ClientInfo == other.ClientInfo ||
                    this.ClientInfo != null &&
                    this.ClientInfo.Equals(other.ClientInfo)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateProcessed == other.DateProcessed ||
                    this.DateProcessed != null &&
                    this.DateProcessed.Equals(other.DateProcessed)
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

                if (this.ReconnectAttempts != null)
                    hash = hash * 59 + this.ReconnectAttempts.GetHashCode();

                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();

                if (this.ClientInfo != null)
                    hash = hash * 59 + this.ClientInfo.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateProcessed != null)
                    hash = hash * 59 + this.DateProcessed.GetHashCode();

                return hash;
            }
        }
    }

}
