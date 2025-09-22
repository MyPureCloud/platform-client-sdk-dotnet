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
    /// MediaStatisticsPostRequest
    /// </summary>
    [DataContract]
    public partial class MediaStatisticsPostRequest :  IEquatable<MediaStatisticsPostRequest>
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
            Client
        }
        /// <summary>
        /// Source type of media endpoint
        /// </summary>
        /// <value>Source type of media endpoint</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaStatisticsPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaStatisticsPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaStatisticsPostRequest" /> class.
        /// </summary>
        /// <param name="SourceType">Source type of media endpoint (required).</param>
        /// <param name="ClientInfo">Client information associated with media endpoint.</param>
        /// <param name="Rtp">Statistics of sent and received RTP. Reference: https://www.rfc-editor.org/rfc/rfc3550 (required).</param>
        /// <param name="ReconnectAttempts">Media reconnect attempt count.</param>
        /// <param name="DateCreated">Media endpoint statistics creation time. Format: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public MediaStatisticsPostRequest(SourceTypeEnum? SourceType = null, MediaStatisticsClientInfo ClientInfo = null, MediaRtpStatistics Rtp = null, int? ReconnectAttempts = null, DateTime? DateCreated = null)
        {
            this.SourceType = SourceType;
            this.ClientInfo = ClientInfo;
            this.Rtp = Rtp;
            this.ReconnectAttempts = ReconnectAttempts;
            this.DateCreated = DateCreated;
            
        }
        




        /// <summary>
        /// Client information associated with media endpoint
        /// </summary>
        /// <value>Client information associated with media endpoint</value>
        [DataMember(Name="clientInfo", EmitDefaultValue=false)]
        public MediaStatisticsClientInfo ClientInfo { get; set; }



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
        /// Media endpoint statistics creation time. Format: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Media endpoint statistics creation time. Format: yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaStatisticsPostRequest {\n");

            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  ClientInfo: ").Append(ClientInfo).Append("\n");
            sb.Append("  Rtp: ").Append(Rtp).Append("\n");
            sb.Append("  ReconnectAttempts: ").Append(ReconnectAttempts).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
            return this.Equals(obj as MediaStatisticsPostRequest);
        }

        /// <summary>
        /// Returns true if MediaStatisticsPostRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaStatisticsPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaStatisticsPostRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
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
                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();

                if (this.ClientInfo != null)
                    hash = hash * 59 + this.ClientInfo.GetHashCode();

                if (this.Rtp != null)
                    hash = hash * 59 + this.Rtp.GetHashCode();

                if (this.ReconnectAttempts != null)
                    hash = hash * 59 + this.ReconnectAttempts.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                return hash;
            }
        }
    }

}
