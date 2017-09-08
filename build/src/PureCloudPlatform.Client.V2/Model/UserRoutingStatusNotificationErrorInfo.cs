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
    /// UserRoutingStatusNotificationErrorInfo
    /// </summary>
    [DataContract]
    public partial class UserRoutingStatusNotificationErrorInfo :  IEquatable<UserRoutingStatusNotificationErrorInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoutingStatusNotificationErrorInfo" /> class.
        /// </summary>
        
        
        /// <param name="ErrorCode">ErrorCode.</param>
        
        
        
        /// <param name="Status">Status.</param>
        
        
        
        /// <param name="CorrelationId">CorrelationId.</param>
        
        
        
        /// <param name="UserMessage">UserMessage.</param>
        
        
        
        /// <param name="UserParamsMessage">UserParamsMessage.</param>
        
        
        
        /// <param name="UserParams">UserParams.</param>
        
        
        public UserRoutingStatusNotificationErrorInfo(string ErrorCode = null, int? Status = null, string CorrelationId = null, string UserMessage = null, string UserParamsMessage = null, List<UserRoutingStatusNotificationErrorInfoUserParams> UserParams = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.ErrorCode = ErrorCode;
            
            
            
            
            
            
            
            
this.Status = Status;
            
            
            
            
            
            
            
            
this.CorrelationId = CorrelationId;
            
            
            
            
            
            
            
            
this.UserMessage = UserMessage;
            
            
            
            
            
            
            
            
this.UserParamsMessage = UserParamsMessage;
            
            
            
            
            
            
            
            
this.UserParams = UserParams;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserMessage
        /// </summary>
        [DataMember(Name="userMessage", EmitDefaultValue=false)]
        public string UserMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserParamsMessage
        /// </summary>
        [DataMember(Name="userParamsMessage", EmitDefaultValue=false)]
        public string UserParamsMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserParams
        /// </summary>
        [DataMember(Name="userParams", EmitDefaultValue=false)]
        public List<UserRoutingStatusNotificationErrorInfoUserParams> UserParams { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserRoutingStatusNotificationErrorInfo {\n");
            
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            
            sb.Append("  UserParamsMessage: ").Append(UserParamsMessage).Append("\n");
            
            sb.Append("  UserParams: ").Append(UserParams).Append("\n");
            
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
            return this.Equals(obj as UserRoutingStatusNotificationErrorInfo);
        }

        /// <summary>
        /// Returns true if UserRoutingStatusNotificationErrorInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserRoutingStatusNotificationErrorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserRoutingStatusNotificationErrorInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.UserMessage == other.UserMessage ||
                    this.UserMessage != null &&
                    this.UserMessage.Equals(other.UserMessage)
                ) &&
                (
                    this.UserParamsMessage == other.UserParamsMessage ||
                    this.UserParamsMessage != null &&
                    this.UserParamsMessage.Equals(other.UserParamsMessage)
                ) &&
                (
                    this.UserParams == other.UserParams ||
                    this.UserParams != null &&
                    this.UserParams.SequenceEqual(other.UserParams)
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
                
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                
                if (this.UserMessage != null)
                    hash = hash * 59 + this.UserMessage.GetHashCode();
                
                if (this.UserParamsMessage != null)
                    hash = hash * 59 + this.UserParamsMessage.GetHashCode();
                
                if (this.UserParams != null)
                    hash = hash * 59 + this.UserParams.GetHashCode();
                
                return hash;
            }
        }
    }

}
