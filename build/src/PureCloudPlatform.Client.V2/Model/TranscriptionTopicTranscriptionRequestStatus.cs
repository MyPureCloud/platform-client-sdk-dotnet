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
    /// TranscriptionTopicTranscriptionRequestStatus
    /// </summary>
    [DataContract]
    public partial class TranscriptionTopicTranscriptionRequestStatus :  IEquatable<TranscriptionTopicTranscriptionRequestStatus>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum SessionOngoing for "SESSION_ONGOING"
            /// </summary>
            [EnumMember(Value = "SESSION_ONGOING")]
            SessionOngoing,
            
            /// <summary>
            /// Enum SessionEnded for "SESSION_ENDED"
            /// </summary>
            [EnumMember(Value = "SESSION_ENDED")]
            SessionEnded
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptionRequestStatus" /> class.
        /// </summary>
        /// <param name="OffsetMs">OffsetMs.</param>
        /// <param name="Status">Status.</param>
        public TranscriptionTopicTranscriptionRequestStatus(int? OffsetMs = null, StatusEnum? Status = null)
        {
            this.OffsetMs = OffsetMs;
            this.Status = Status;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets OffsetMs
        /// </summary>
        [DataMember(Name="offsetMs", EmitDefaultValue=false)]
        public int? OffsetMs { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranscriptionTopicTranscriptionRequestStatus {\n");
            
            sb.Append("  OffsetMs: ").Append(OffsetMs).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TranscriptionTopicTranscriptionRequestStatus);
        }

        /// <summary>
        /// Returns true if TranscriptionTopicTranscriptionRequestStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of TranscriptionTopicTranscriptionRequestStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranscriptionTopicTranscriptionRequestStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OffsetMs == other.OffsetMs ||
                    this.OffsetMs != null &&
                    this.OffsetMs.Equals(other.OffsetMs)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.OffsetMs != null)
                    hash = hash * 59 + this.OffsetMs.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }
    }

}
