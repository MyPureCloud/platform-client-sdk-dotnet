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
    /// Operation
    /// </summary>
    [DataContract]
    public partial class Operation :  IEquatable<Operation>
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
        /// Initializes a new instance of the <see cref="Operation" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Complete">Complete.</param>
        /// <param name="User">User.</param>
        /// <param name="Client">Client.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="ErrorMessageParams">ErrorMessageParams.</param>
        /// <param name="ActionName">Action name.</param>
        /// <param name="ActionStatus">Action status.</param>
        public Operation(string Id = null, bool? Complete = null, User User = null, DomainEntityRef Client = null, string ErrorMessage = null, string ErrorCode = null, List<Detail> ErrorDetails = null, Dictionary<string, string> ErrorMessageParams = null, ActionNameEnum? ActionName = null, ActionStatusEnum? ActionStatus = null)
        {
            this.Id = Id;
            this.Complete = Complete;
            this.User = User;
            this.Client = Client;
            this.ErrorMessage = ErrorMessage;
            this.ErrorCode = ErrorCode;
            this.ErrorDetails = ErrorDetails;
            this.ErrorMessageParams = ErrorMessageParams;
            this.ActionName = ActionName;
            this.ActionStatus = ActionStatus;
            
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
        /// Gets or Sets Client
        /// </summary>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public DomainEntityRef Client { get; set; }
        
        
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ErrorMessageParams: ").Append(ErrorMessageParams).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  ActionStatus: ").Append(ActionStatus).Append("\n");
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
            return this.Equals(obj as Operation);
        }

        /// <summary>
        /// Returns true if Operation instances are equal
        /// </summary>
        /// <param name="other">Instance of Operation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operation other)
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
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
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
                
                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();
                
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
                
                return hash;
            }
        }
    }

}
