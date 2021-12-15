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
    /// The voicemail data to be used when this callback is an ACD voicemail.
    /// </summary>
    [DataContract]
    public partial class ConversationEventTopicVoicemail :  IEquatable<ConversationEventTopicVoicemail>
    {
        
        
        
        
        
        /// <summary>
        /// current state of the voicemail upload
        /// </summary>
        /// <value>current state of the voicemail upload</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum UploadStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
            /// <summary>
            /// Enum Timeout for "timeout"
            /// </summary>
            [EnumMember(Value = "timeout")]
            Timeout,
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None
        }
        
        
        
        
        
        
        
        /// <summary>
        /// current state of the voicemail upload
        /// </summary>
        /// <value>current state of the voicemail upload</value>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public UploadStatusEnum? UploadStatus { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventTopicVoicemail" /> class.
        /// </summary>
        /// <param name="Id">The voicemail id.</param>
        /// <param name="UploadStatus">current state of the voicemail upload.</param>
        public ConversationEventTopicVoicemail(string Id = null, UploadStatusEnum? UploadStatus = null)
        {
            this.Id = Id;
            this.UploadStatus = UploadStatus;
            
        }
        
        
        
        /// <summary>
        /// The voicemail id
        /// </summary>
        /// <value>The voicemail id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventTopicVoicemail {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
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
            return this.Equals(obj as ConversationEventTopicVoicemail);
        }

        /// <summary>
        /// Returns true if ConversationEventTopicVoicemail instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationEventTopicVoicemail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventTopicVoicemail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();
                
                return hash;
            }
        }
    }

}
