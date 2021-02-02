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
    /// EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate
    /// </summary>
    [DataContract]
    public partial class EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate :  IEquatable<EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate>
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
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None,
            
            /// <summary>
            /// Enum Init for "INIT"
            /// </summary>
            [EnumMember(Value = "INIT")]
            Init,
            
            /// <summary>
            /// Enum InProgress for "IN_PROGRESS"
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            
            /// <summary>
            /// Enum Expired for "EXPIRED"
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            Expired,
            
            /// <summary>
            /// Enum Exception for "EXCEPTION"
            /// </summary>
            [EnumMember(Value = "EXCEPTION")]
            Exception,
            
            /// <summary>
            /// Enum Aborted for "ABORTED"
            /// </summary>
            [EnumMember(Value = "ABORTED")]
            Aborted,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed,
            
            /// <summary>
            /// Enum Succeeded for "SUCCEEDED"
            /// </summary>
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Status">Status.</param>
        /// <param name="DownloadStartTime">DownloadStartTime.</param>
        /// <param name="ExecuteStartTime">ExecuteStartTime.</param>
        /// <param name="ExecuteStopTime">ExecuteStopTime.</param>
        public EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate(string Id = null, StatusEnum? Status = null, DateTime? DownloadStartTime = null, DateTime? ExecuteStartTime = null, DateTime? ExecuteStopTime = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.DownloadStartTime = DownloadStartTime;
            this.ExecuteStartTime = ExecuteStartTime;
            this.ExecuteStopTime = ExecuteStopTime;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DownloadStartTime
        /// </summary>
        [DataMember(Name="downloadStartTime", EmitDefaultValue=false)]
        public DateTime? DownloadStartTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExecuteStartTime
        /// </summary>
        [DataMember(Name="executeStartTime", EmitDefaultValue=false)]
        public DateTime? ExecuteStartTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExecuteStopTime
        /// </summary>
        [DataMember(Name="executeStopTime", EmitDefaultValue=false)]
        public DateTime? ExecuteStopTime { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DownloadStartTime: ").Append(DownloadStartTime).Append("\n");
            sb.Append("  ExecuteStartTime: ").Append(ExecuteStartTime).Append("\n");
            sb.Append("  ExecuteStopTime: ").Append(ExecuteStopTime).Append("\n");
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
            return this.Equals(obj as EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate);
        }

        /// <summary>
        /// Returns true if EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.DownloadStartTime == other.DownloadStartTime ||
                    this.DownloadStartTime != null &&
                    this.DownloadStartTime.Equals(other.DownloadStartTime)
                ) &&
                (
                    this.ExecuteStartTime == other.ExecuteStartTime ||
                    this.ExecuteStartTime != null &&
                    this.ExecuteStartTime.Equals(other.ExecuteStartTime)
                ) &&
                (
                    this.ExecuteStopTime == other.ExecuteStopTime ||
                    this.ExecuteStopTime != null &&
                    this.ExecuteStopTime.Equals(other.ExecuteStopTime)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.DownloadStartTime != null)
                    hash = hash * 59 + this.DownloadStartTime.GetHashCode();
                
                if (this.ExecuteStartTime != null)
                    hash = hash * 59 + this.ExecuteStartTime.GetHashCode();
                
                if (this.ExecuteStopTime != null)
                    hash = hash * 59 + this.ExecuteStopTime.GetHashCode();
                
                return hash;
            }
        }
    }

}
