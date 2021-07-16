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
    /// WfmScheduleTopicWfmScheduleNotification
    /// </summary>
    [DataContract]
    public partial class WfmScheduleTopicWfmScheduleNotification :  IEquatable<WfmScheduleTopicWfmScheduleNotification>
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Import for "Import"
            /// </summary>
            [EnumMember(Value = "Import")]
            Import,
            
            /// <summary>
            /// Enum Copy for "Copy"
            /// </summary>
            [EnumMember(Value = "Copy")]
            Copy,
            
            /// <summary>
            /// Enum Generate for "Generate"
            /// </summary>
            [EnumMember(Value = "Generate")]
            Generate,
            
            /// <summary>
            /// Enum Reschedule for "Reschedule"
            /// </summary>
            [EnumMember(Value = "Reschedule")]
            Reschedule
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmScheduleTopicWfmScheduleNotification" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="OperationId">OperationId.</param>
        /// <param name="DownloadUrl">DownloadUrl.</param>
        /// <param name="PercentComplete">PercentComplete.</param>
        /// <param name="EventType">EventType.</param>
        public WfmScheduleTopicWfmScheduleNotification(StatusEnum? Status = null, string OperationId = null, string DownloadUrl = null, int? PercentComplete = null, EventTypeEnum? EventType = null)
        {
            this.Status = Status;
            this.OperationId = OperationId;
            this.DownloadUrl = DownloadUrl;
            this.PercentComplete = PercentComplete;
            this.EventType = EventType;
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public string OperationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PercentComplete
        /// </summary>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public int? PercentComplete { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmScheduleTopicWfmScheduleNotification {\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(obj as WfmScheduleTopicWfmScheduleNotification);
        }

        /// <summary>
        /// Returns true if WfmScheduleTopicWfmScheduleNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmScheduleTopicWfmScheduleNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmScheduleTopicWfmScheduleNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.PercentComplete == other.PercentComplete ||
                    this.PercentComplete != null &&
                    this.PercentComplete.Equals(other.PercentComplete)
                ) &&
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();
                
                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();
                
                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();
                
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                
                return hash;
            }
        }
    }

}
