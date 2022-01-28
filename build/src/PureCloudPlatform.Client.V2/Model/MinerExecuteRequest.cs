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
    /// MinerExecuteRequest
    /// </summary>
    [DataContract]
    public partial class MinerExecuteRequest :  IEquatable<MinerExecuteRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Media type for filtering conversations.
        /// </summary>
        /// <value>Media type for filtering conversations.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Media type for filtering conversations.
        /// </summary>
        /// <value>Media type for filtering conversations.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MinerExecuteRequest" /> class.
        /// </summary>
        /// <param name="DateStart">Start date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="DateEnd">End date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="UploadKey">Location of input conversations..</param>
        /// <param name="MediaType">Media type for filtering conversations..</param>
        /// <param name="QueueIds">List of queue IDs for filtering conversations..</param>
        public MinerExecuteRequest(String DateStart = null, String DateEnd = null, string UploadKey = null, MediaTypeEnum? MediaType = null, List<string> QueueIds = null)
        {
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.UploadKey = UploadKey;
            this.MediaType = MediaType;
            this.QueueIds = QueueIds;
            
        }
        
        
        
        /// <summary>
        /// Start date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>Start date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public String DateStart { get; set; }
        
        
        
        /// <summary>
        /// End date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>End date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public String DateEnd { get; set; }
        
        
        
        /// <summary>
        /// Location of input conversations.
        /// </summary>
        /// <value>Location of input conversations.</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }
        
        
        
        
        
        /// <summary>
        /// List of queue IDs for filtering conversations.
        /// </summary>
        /// <value>List of queue IDs for filtering conversations.</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MinerExecuteRequest {\n");
            
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
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
            return this.Equals(obj as MinerExecuteRequest);
        }

        /// <summary>
        /// Returns true if MinerExecuteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MinerExecuteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinerExecuteRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
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
                
                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();
                
                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();
                
                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
