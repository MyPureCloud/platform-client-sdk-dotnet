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
    /// WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate
    /// </summary>
    [DataContract]
    public partial class WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate :  IEquatable<WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate>
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
            /// Enum Initiated for "Initiated"
            /// </summary>
            [EnumMember(Value = "Initiated")]
            Initiated,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Purged for "Purged"
            /// </summary>
            [EnumMember(Value = "Purged")]
            Purged
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate" /> class.
        /// </summary>
        /// <param name="RequestId">RequestId.</param>
        /// <param name="DateImportStarted">DateImportStarted.</param>
        /// <param name="DateImportEnded">DateImportEnded.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Error">Error.</param>
        /// <param name="Active">Active.</param>
        public WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate(string RequestId = null, WfmHistoricalDataUploadRequestStatusTopicDateTime DateImportStarted = null, WfmHistoricalDataUploadRequestStatusTopicDateTime DateImportEnded = null, WfmHistoricalDataUploadRequestStatusTopicDateTime DateCreated = null, WfmHistoricalDataUploadRequestStatusTopicDateTime DateModified = null, StatusEnum? Status = null, string Error = null, bool? Active = null)
        {
            this.RequestId = RequestId;
            this.DateImportStarted = DateImportStarted;
            this.DateImportEnded = DateImportEnded;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Status = Status;
            this.Error = Error;
            this.Active = Active;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateImportStarted
        /// </summary>
        [DataMember(Name="dateImportStarted", EmitDefaultValue=false)]
        public WfmHistoricalDataUploadRequestStatusTopicDateTime DateImportStarted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateImportEnded
        /// </summary>
        [DataMember(Name="dateImportEnded", EmitDefaultValue=false)]
        public WfmHistoricalDataUploadRequestStatusTopicDateTime DateImportEnded { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public WfmHistoricalDataUploadRequestStatusTopicDateTime DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public WfmHistoricalDataUploadRequestStatusTopicDateTime DateModified { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate {\n");
            
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  DateImportStarted: ").Append(DateImportStarted).Append("\n");
            sb.Append("  DateImportEnded: ").Append(DateImportEnded).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(obj as WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate);
        }

        /// <summary>
        /// Returns true if WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) &&
                (
                    this.DateImportStarted == other.DateImportStarted ||
                    this.DateImportStarted != null &&
                    this.DateImportStarted.Equals(other.DateImportStarted)
                ) &&
                (
                    this.DateImportEnded == other.DateImportEnded ||
                    this.DateImportEnded != null &&
                    this.DateImportEnded.Equals(other.DateImportEnded)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
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
                
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                
                if (this.DateImportStarted != null)
                    hash = hash * 59 + this.DateImportStarted.GetHashCode();
                
                if (this.DateImportEnded != null)
                    hash = hash * 59 + this.DateImportEnded.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                return hash;
            }
        }
    }

}
