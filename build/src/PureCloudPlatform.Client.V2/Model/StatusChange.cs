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
    /// StatusChange
    /// </summary>
    [DataContract]
    public partial class StatusChange :  IEquatable<StatusChange>
    {
        
        
        
        
        
        /// <summary>
        /// The status the change request transitioned to
        /// </summary>
        /// <value>The status the change request transitioned to</value>
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
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Implementingchange for "ImplementingChange"
            /// </summary>
            [EnumMember(Value = "ImplementingChange")]
            Implementingchange,
            
            /// <summary>
            /// Enum Changeimplemented for "ChangeImplemented"
            /// </summary>
            [EnumMember(Value = "ChangeImplemented")]
            Changeimplemented,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Rollback for "Rollback"
            /// </summary>
            [EnumMember(Value = "Rollback")]
            Rollback,
            
            /// <summary>
            /// Enum Implementingrollback for "ImplementingRollback"
            /// </summary>
            [EnumMember(Value = "ImplementingRollback")]
            Implementingrollback,
            
            /// <summary>
            /// Enum Rollbackimplemented for "RollbackImplemented"
            /// </summary>
            [EnumMember(Value = "RollbackImplemented")]
            Rollbackimplemented
        }
        
        
        
        
        /// <summary>
        /// The status the change request transitioned from
        /// </summary>
        /// <value>The status the change request transitioned from</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PreviousStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Implementingchange for "ImplementingChange"
            /// </summary>
            [EnumMember(Value = "ImplementingChange")]
            Implementingchange,
            
            /// <summary>
            /// Enum Changeimplemented for "ChangeImplemented"
            /// </summary>
            [EnumMember(Value = "ChangeImplemented")]
            Changeimplemented,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Rollback for "Rollback"
            /// </summary>
            [EnumMember(Value = "Rollback")]
            Rollback,
            
            /// <summary>
            /// Enum Implementingrollback for "ImplementingRollback"
            /// </summary>
            [EnumMember(Value = "ImplementingRollback")]
            Implementingrollback,
            
            /// <summary>
            /// Enum Rollbackimplemented for "RollbackImplemented"
            /// </summary>
            [EnumMember(Value = "RollbackImplemented")]
            Rollbackimplemented
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The reason for rejecting the limit override request
        /// </summary>
        /// <value>The reason for rejecting the limit override request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RejectReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alternativeexists for "AlternativeExists"
            /// </summary>
            [EnumMember(Value = "AlternativeExists")]
            Alternativeexists,
            
            /// <summary>
            /// Enum Increasenotrequired for "IncreaseNotRequired"
            /// </summary>
            [EnumMember(Value = "IncreaseNotRequired")]
            Increasenotrequired,
            
            /// <summary>
            /// Enum Platformmisuse for "PlatformMisuse"
            /// </summary>
            [EnumMember(Value = "PlatformMisuse")]
            Platformmisuse,
            
            /// <summary>
            /// Enum Platformstability for "PlatformStability"
            /// </summary>
            [EnumMember(Value = "PlatformStability")]
            Platformstability,
            
            /// <summary>
            /// Enum Otherreason for "OtherReason"
            /// </summary>
            [EnumMember(Value = "OtherReason")]
            Otherreason
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The status the change request transitioned to
        /// </summary>
        /// <value>The status the change request transitioned to</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        /// <summary>
        /// The status the change request transitioned from
        /// </summary>
        /// <value>The status the change request transitioned from</value>
        [DataMember(Name="previousStatus", EmitDefaultValue=false)]
        public PreviousStatusEnum? PreviousStatus { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// The reason for rejecting the limit override request
        /// </summary>
        /// <value>The reason for rejecting the limit override request</value>
        [DataMember(Name="rejectReason", EmitDefaultValue=false)]
        public RejectReasonEnum? RejectReason { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusChange" /> class.
        /// </summary>
        public StatusChange()
        {
            
        }
        
        
        
        /// <summary>
        /// The date of this status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of this status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStatusChanged", EmitDefaultValue=false)]
        public DateTime? DateStatusChanged { get; private set; }
        
        
        
        
        
        
        
        /// <summary>
        /// A short message describing the status change
        /// </summary>
        /// <value>A short message describing the status change</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }
        
        
        
        /// <summary>
        /// If applicable, the user who updated the change request to this status
        /// </summary>
        /// <value>If applicable, the user who updated the change request to this status</value>
        [DataMember(Name="changedBy", EmitDefaultValue=false)]
        public string ChangedBy { get; private set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusChange {\n");
            
            sb.Append("  DateStatusChanged: ").Append(DateStatusChanged).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PreviousStatus: ").Append(PreviousStatus).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ChangedBy: ").Append(ChangedBy).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
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
            return this.Equals(obj as StatusChange);
        }

        /// <summary>
        /// Returns true if StatusChange instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateStatusChanged == other.DateStatusChanged ||
                    this.DateStatusChanged != null &&
                    this.DateStatusChanged.Equals(other.DateStatusChanged)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.PreviousStatus == other.PreviousStatus ||
                    this.PreviousStatus != null &&
                    this.PreviousStatus.Equals(other.PreviousStatus)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.ChangedBy == other.ChangedBy ||
                    this.ChangedBy != null &&
                    this.ChangedBy.Equals(other.ChangedBy)
                ) &&
                (
                    this.RejectReason == other.RejectReason ||
                    this.RejectReason != null &&
                    this.RejectReason.Equals(other.RejectReason)
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
                
                if (this.DateStatusChanged != null)
                    hash = hash * 59 + this.DateStatusChanged.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.PreviousStatus != null)
                    hash = hash * 59 + this.PreviousStatus.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.ChangedBy != null)
                    hash = hash * 59 + this.ChangedBy.GetHashCode();
                
                if (this.RejectReason != null)
                    hash = hash * 59 + this.RejectReason.GetHashCode();
                
                return hash;
            }
        }
    }

}
