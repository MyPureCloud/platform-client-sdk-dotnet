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
    /// CallConversationNotificationErrorInfo
    /// </summary>
    [DataContract]
    public partial class CallConversationNotificationErrorInfo :  IEquatable<CallConversationNotificationErrorInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallConversationNotificationErrorInfo" /> class.
        /// </summary>
        
        
        /// <param name="Status">Status.</param>
        
        
        
        /// <param name="Code">Code.</param>
        
        
        
        /// <param name="EntityId">EntityId.</param>
        
        
        
        /// <param name="EntityName">EntityName.</param>
        
        
        
        /// <param name="Message">Message.</param>
        
        
        
        /// <param name="MessageWithParams">MessageWithParams.</param>
        
        
        
        /// <param name="MessageParams">MessageParams.</param>
        
        
        
        /// <param name="ContextId">ContextId.</param>
        
        
        
        /// <param name="Details">Details.</param>
        
        
        
        /// <param name="Errors">Errors.</param>
        
        
        public CallConversationNotificationErrorInfo(int? Status = null, string Code = null, string EntityId = null, string EntityName = null, string Message = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null, string ContextId = null, List<CallbackConversationNotificationErrorInfoDetails> Details = null, List<CallConversationNotificationErrorBody> Errors = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Status = Status;
            
            
            
            
            
            
            
            
this.Code = Code;
            
            
            
            
            
            
            
            
this.EntityId = EntityId;
            
            
            
            
            
            
            
            
this.EntityName = EntityName;
            
            
            
            
            
            
            
            
this.Message = Message;
            
            
            
            
            
            
            
            
this.MessageWithParams = MessageWithParams;
            
            
            
            
            
            
            
            
this.MessageParams = MessageParams;
            
            
            
            
            
            
            
            
this.ContextId = ContextId;
            
            
            
            
            
            
            
            
this.Details = Details;
            
            
            
            
            
            
            
            
this.Errors = Errors;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageWithParams
        /// </summary>
        [DataMember(Name="messageWithParams", EmitDefaultValue=false)]
        public string MessageWithParams { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MessageParams
        /// </summary>
        [DataMember(Name="messageParams", EmitDefaultValue=false)]
        public Dictionary<string, string> MessageParams { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<CallbackConversationNotificationErrorInfoDetails> Details { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<CallConversationNotificationErrorBody> Errors { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallConversationNotificationErrorInfo {\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            
            sb.Append("  Code: ").Append(Code).Append("\n");
            
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            
            sb.Append("  Message: ").Append(Message).Append("\n");
            
            sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
            
            sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
            
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            
            sb.Append("  Details: ").Append(Details).Append("\n");
            
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            
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
            return this.Equals(obj as CallConversationNotificationErrorInfo);
        }

        /// <summary>
        /// Returns true if CallConversationNotificationErrorInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of CallConversationNotificationErrorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallConversationNotificationErrorInfo other)
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
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
                ) &&
                (
                    this.EntityName == other.EntityName ||
                    this.EntityName != null &&
                    this.EntityName.Equals(other.EntityName)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.MessageWithParams == other.MessageWithParams ||
                    this.MessageWithParams != null &&
                    this.MessageWithParams.Equals(other.MessageWithParams)
                ) &&
                (
                    this.MessageParams == other.MessageParams ||
                    this.MessageParams != null &&
                    this.MessageParams.SequenceEqual(other.MessageParams)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                
                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();
                
                if (this.EntityName != null)
                    hash = hash * 59 + this.EntityName.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.MessageWithParams != null)
                    hash = hash * 59 + this.MessageWithParams.GetHashCode();
                
                if (this.MessageParams != null)
                    hash = hash * 59 + this.MessageParams.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                
                return hash;
            }
        }
    }

}
