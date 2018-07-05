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
    /// ReportRunEntry
    /// </summary>
    [DataContract]
    public partial class ReportRunEntry :  IEquatable<ReportRunEntry>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets RunStatus
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RunStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Running for "RUNNING"
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            Running,
            
            /// <summary>
            /// Enum Completed for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            Completed,
            
            /// <summary>
            /// Enum CompletedWithErrors for "COMPLETED_WITH_ERRORS"
            /// </summary>
            [EnumMember(Value = "COMPLETED_WITH_ERRORS")]
            CompletedWithErrors,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed,
            
            /// <summary>
            /// Enum FailedTimeout for "FAILED_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "FAILED_TIMEOUT")]
            FailedTimeout,
            
            /// <summary>
            /// Enum FailedDatalimit for "FAILED_DATALIMIT"
            /// </summary>
            [EnumMember(Value = "FAILED_DATALIMIT")]
            FailedDatalimit
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets RunStatus
        /// </summary>
        [DataMember(Name="runStatus", EmitDefaultValue=false)]
        public RunStatusEnum? RunStatus { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRunEntry" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ReportId">ReportId.</param>
        /// <param name="RunTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="RunStatus">RunStatus.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="RunDurationMsec">RunDurationMsec.</param>
        /// <param name="ReportUrl">ReportUrl.</param>
        /// <param name="ReportFormat">ReportFormat.</param>
        /// <param name="ScheduleUri">ScheduleUri.</param>
        public ReportRunEntry(string Name = null, string ReportId = null, DateTime? RunTime = null, RunStatusEnum? RunStatus = null, string ErrorMessage = null, long? RunDurationMsec = null, string ReportUrl = null, string ReportFormat = null, string ScheduleUri = null)
        {
            this.Name = Name;
            this.ReportId = ReportId;
            this.RunTime = RunTime;
            this.RunStatus = RunStatus;
            this.ErrorMessage = ErrorMessage;
            this.RunDurationMsec = RunDurationMsec;
            this.ReportUrl = ReportUrl;
            this.ReportFormat = ReportFormat;
            this.ScheduleUri = ScheduleUri;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public string ReportId { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="runTime", EmitDefaultValue=false)]
        public DateTime? RunTime { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets RunDurationMsec
        /// </summary>
        [DataMember(Name="runDurationMsec", EmitDefaultValue=false)]
        public long? RunDurationMsec { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReportUrl
        /// </summary>
        [DataMember(Name="reportUrl", EmitDefaultValue=false)]
        public string ReportUrl { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ReportFormat
        /// </summary>
        [DataMember(Name="reportFormat", EmitDefaultValue=false)]
        public string ReportFormat { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ScheduleUri
        /// </summary>
        [DataMember(Name="scheduleUri", EmitDefaultValue=false)]
        public string ScheduleUri { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportRunEntry {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  RunTime: ").Append(RunTime).Append("\n");
            sb.Append("  RunStatus: ").Append(RunStatus).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  RunDurationMsec: ").Append(RunDurationMsec).Append("\n");
            sb.Append("  ReportUrl: ").Append(ReportUrl).Append("\n");
            sb.Append("  ReportFormat: ").Append(ReportFormat).Append("\n");
            sb.Append("  ScheduleUri: ").Append(ScheduleUri).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ReportRunEntry);
        }

        /// <summary>
        /// Returns true if ReportRunEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportRunEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportRunEntry other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ReportId == other.ReportId ||
                    this.ReportId != null &&
                    this.ReportId.Equals(other.ReportId)
                ) &&
                (
                    this.RunTime == other.RunTime ||
                    this.RunTime != null &&
                    this.RunTime.Equals(other.RunTime)
                ) &&
                (
                    this.RunStatus == other.RunStatus ||
                    this.RunStatus != null &&
                    this.RunStatus.Equals(other.RunStatus)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.RunDurationMsec == other.RunDurationMsec ||
                    this.RunDurationMsec != null &&
                    this.RunDurationMsec.Equals(other.RunDurationMsec)
                ) &&
                (
                    this.ReportUrl == other.ReportUrl ||
                    this.ReportUrl != null &&
                    this.ReportUrl.Equals(other.ReportUrl)
                ) &&
                (
                    this.ReportFormat == other.ReportFormat ||
                    this.ReportFormat != null &&
                    this.ReportFormat.Equals(other.ReportFormat)
                ) &&
                (
                    this.ScheduleUri == other.ScheduleUri ||
                    this.ScheduleUri != null &&
                    this.ScheduleUri.Equals(other.ScheduleUri)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ReportId != null)
                    hash = hash * 59 + this.ReportId.GetHashCode();
                
                if (this.RunTime != null)
                    hash = hash * 59 + this.RunTime.GetHashCode();
                
                if (this.RunStatus != null)
                    hash = hash * 59 + this.RunStatus.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                if (this.RunDurationMsec != null)
                    hash = hash * 59 + this.RunDurationMsec.GetHashCode();
                
                if (this.ReportUrl != null)
                    hash = hash * 59 + this.ReportUrl.GetHashCode();
                
                if (this.ReportFormat != null)
                    hash = hash * 59 + this.ReportFormat.GetHashCode();
                
                if (this.ScheduleUri != null)
                    hash = hash * 59 + this.ScheduleUri.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
