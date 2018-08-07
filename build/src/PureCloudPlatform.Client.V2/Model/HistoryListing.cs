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
    /// HistoryListing
    /// </summary>
    [DataContract]
    public partial class HistoryListing :  IEquatable<HistoryListing>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Action name
        /// </summary>
        /// <value>Action name</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Create for "CREATE"
            /// </summary>
            [EnumMember(Value = "CREATE")]
            Create,
            
            /// <summary>
            /// Enum Checkin for "CHECKIN"
            /// </summary>
            [EnumMember(Value = "CHECKIN")]
            Checkin,
            
            /// <summary>
            /// Enum Debug for "DEBUG"
            /// </summary>
            [EnumMember(Value = "DEBUG")]
            Debug,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete,
            
            /// <summary>
            /// Enum History for "HISTORY"
            /// </summary>
            [EnumMember(Value = "HISTORY")]
            History,
            
            /// <summary>
            /// Enum Publish for "PUBLISH"
            /// </summary>
            [EnumMember(Value = "PUBLISH")]
            Publish,
            
            /// <summary>
            /// Enum StateChange for "STATE_CHANGE"
            /// </summary>
            [EnumMember(Value = "STATE_CHANGE")]
            StateChange,
            
            /// <summary>
            /// Enum Update for "UPDATE"
            /// </summary>
            [EnumMember(Value = "UPDATE")]
            Update,
            
            /// <summary>
            /// Enum Validate for "VALIDATE"
            /// </summary>
            [EnumMember(Value = "VALIDATE")]
            Validate
        }
        
        
        
        
        /// <summary>
        /// Action status
        /// </summary>
        /// <value>Action status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Locked for "LOCKED"
            /// </summary>
            [EnumMember(Value = "LOCKED")]
            Locked,
            
            /// <summary>
            /// Enum Unlocked for "UNLOCKED"
            /// </summary>
            [EnumMember(Value = "UNLOCKED")]
            Unlocked,
            
            /// <summary>
            /// Enum Started for "STARTED"
            /// </summary>
            [EnumMember(Value = "STARTED")]
            Started,
            
            /// <summary>
            /// Enum PendingGeneration for "PENDING_GENERATION"
            /// </summary>
            [EnumMember(Value = "PENDING_GENERATION")]
            PendingGeneration,
            
            /// <summary>
            /// Enum PendingBackendNotification for "PENDING_BACKEND_NOTIFICATION"
            /// </summary>
            [EnumMember(Value = "PENDING_BACKEND_NOTIFICATION")]
            PendingBackendNotification,
            
            /// <summary>
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Failure for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            Failure
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Action name
        /// </summary>
        /// <value>Action name</value>
        [DataMember(Name="actionName", EmitDefaultValue=false)]
        public ActionNameEnum? ActionName { get; set; }
        
        
        
        /// <summary>
        /// Action status
        /// </summary>
        /// <value>Action status</value>
        [DataMember(Name="actionStatus", EmitDefaultValue=false)]
        public ActionStatusEnum? ActionStatus { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryListing" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Complete">Complete.</param>
        /// <param name="User">User.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="ErrorMessageParams">ErrorMessageParams.</param>
        /// <param name="ActionName">Action name.</param>
        /// <param name="ActionStatus">Action status.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="System">System.</param>
        /// <param name="Started">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Completed">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public HistoryListing(string Id = null, bool? Complete = null, User User = null, string ErrorMessage = null, string ErrorCode = null, List<Detail> ErrorDetails = null, Dictionary<string, string> ErrorMessageParams = null, ActionNameEnum? ActionName = null, ActionStatusEnum? ActionStatus = null, string Name = null, string Description = null, bool? System = null, DateTime? Started = null, DateTime? Completed = null)
        {
            this.Id = Id;
            this.Complete = Complete;
            this.User = User;
            this.ErrorMessage = ErrorMessage;
            this.ErrorCode = ErrorCode;
            this.ErrorDetails = ErrorDetails;
            this.ErrorMessageParams = ErrorMessageParams;
            this.ActionName = ActionName;
            this.ActionStatus = ActionStatus;
            this.Name = Name;
            this.Description = Description;
            this.System = System;
            this.Started = Started;
            this.Completed = Completed;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name="complete", EmitDefaultValue=false)]
        public bool? Complete { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public List<Detail> ErrorDetails { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorMessageParams
        /// </summary>
        [DataMember(Name="errorMessageParams", EmitDefaultValue=false)]
        public Dictionary<string, string> ErrorMessageParams { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public bool? System { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="started", EmitDefaultValue=false)]
        public DateTime? Started { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public DateTime? Completed { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryListing {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ErrorMessageParams: ").Append(ErrorMessageParams).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  ActionStatus: ").Append(ActionStatus).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
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
            return this.Equals(obj as HistoryListing);
        }

        /// <summary>
        /// Returns true if HistoryListing instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoryListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryListing other)
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
                    this.Complete == other.Complete ||
                    this.Complete != null &&
                    this.Complete.Equals(other.Complete)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(other.ErrorDetails)
                ) &&
                (
                    this.ErrorMessageParams == other.ErrorMessageParams ||
                    this.ErrorMessageParams != null &&
                    this.ErrorMessageParams.SequenceEqual(other.ErrorMessageParams)
                ) &&
                (
                    this.ActionName == other.ActionName ||
                    this.ActionName != null &&
                    this.ActionName.Equals(other.ActionName)
                ) &&
                (
                    this.ActionStatus == other.ActionStatus ||
                    this.ActionStatus != null &&
                    this.ActionStatus.Equals(other.ActionStatus)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.System == other.System ||
                    this.System != null &&
                    this.System.Equals(other.System)
                ) &&
                (
                    this.Started == other.Started ||
                    this.Started != null &&
                    this.Started.Equals(other.Started)
                ) &&
                (
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
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
                
                if (this.Complete != null)
                    hash = hash * 59 + this.Complete.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                
                if (this.ErrorMessageParams != null)
                    hash = hash * 59 + this.ErrorMessageParams.GetHashCode();
                
                if (this.ActionName != null)
                    hash = hash * 59 + this.ActionName.GetHashCode();
                
                if (this.ActionStatus != null)
                    hash = hash * 59 + this.ActionStatus.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.System != null)
                    hash = hash * 59 + this.System.GetHashCode();
                
                if (this.Started != null)
                    hash = hash * 59 + this.Started.GetHashCode();
                
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
                
                return hash;
            }
        }
    }

}
