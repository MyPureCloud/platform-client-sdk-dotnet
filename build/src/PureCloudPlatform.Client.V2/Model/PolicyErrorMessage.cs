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
    /// PolicyErrorMessage
    /// </summary>
    [DataContract]
    public partial class PolicyErrorMessage :  IEquatable<PolicyErrorMessage>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyErrorMessage" /> class.
        /// </summary>
        
        
        /// <param name="StatusCode">StatusCode.</param>
        
        
        
        /// <param name="UserMessage">UserMessage.</param>
        
        
        
        /// <param name="UserParamsMessage">UserParamsMessage.</param>
        
        
        
        /// <param name="ErrorCode">ErrorCode.</param>
        
        
        
        /// <param name="CorrelationId">CorrelationId.</param>
        
        
        
        /// <param name="UserParams">UserParams.</param>
        
        
        
        /// <param name="InsertDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        public PolicyErrorMessage(int? StatusCode = null, Object UserMessage = null, string UserParamsMessage = null, string ErrorCode = null, string CorrelationId = null, List<UserParam> UserParams = null, DateTime? InsertDate = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.StatusCode = StatusCode;
            
            
            
            
            
            
            
            
this.UserMessage = UserMessage;
            
            
            
            
            
            
            
            
this.UserParamsMessage = UserParamsMessage;
            
            
            
            
            
            
            
            
this.ErrorCode = ErrorCode;
            
            
            
            
            
            
            
            
this.CorrelationId = CorrelationId;
            
            
            
            
            
            
            
            
this.UserParams = UserParams;
            
            
            
            
            
            
            
            
this.InsertDate = InsertDate;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserMessage
        /// </summary>
        [DataMember(Name="userMessage", EmitDefaultValue=false)]
        public Object UserMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserParamsMessage
        /// </summary>
        [DataMember(Name="userParamsMessage", EmitDefaultValue=false)]
        public string UserParamsMessage { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserParams
        /// </summary>
        [DataMember(Name="userParams", EmitDefaultValue=false)]
        public List<UserParam> UserParams { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="insertDate", EmitDefaultValue=false)]
        public DateTime? InsertDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyErrorMessage {\n");
            
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            
            sb.Append("  UserParamsMessage: ").Append(UserParamsMessage).Append("\n");
            
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            
            sb.Append("  UserParams: ").Append(UserParams).Append("\n");
            
            sb.Append("  InsertDate: ").Append(InsertDate).Append("\n");
            
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
            return this.Equals(obj as PolicyErrorMessage);
        }

        /// <summary>
        /// Returns true if PolicyErrorMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyErrorMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyErrorMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
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
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.UserParams == other.UserParams ||
                    this.UserParams != null &&
                    this.UserParams.SequenceEqual(other.UserParams)
                ) &&
                (
                    this.InsertDate == other.InsertDate ||
                    this.InsertDate != null &&
                    this.InsertDate.Equals(other.InsertDate)
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
                
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                
                if (this.UserMessage != null)
                    hash = hash * 59 + this.UserMessage.GetHashCode();
                
                if (this.UserParamsMessage != null)
                    hash = hash * 59 + this.UserParamsMessage.GetHashCode();
                
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                
                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();
                
                if (this.UserParams != null)
                    hash = hash * 59 + this.UserParams.GetHashCode();
                
                if (this.InsertDate != null)
                    hash = hash * 59 + this.InsertDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
