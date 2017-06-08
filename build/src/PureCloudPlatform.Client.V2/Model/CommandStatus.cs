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
    /// CommandStatus
    /// </summary>
    [DataContract]
    public partial class CommandStatus :  IEquatable<CommandStatus>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inprogress for "INPROGRESS"
            /// </summary>
            [EnumMember(Value = "INPROGRESS")]
            Inprogress,
            
            /// <summary>
            /// Enum Complete for "COMPLETE"
            /// </summary>
            [EnumMember(Value = "COMPLETE")]
            Complete,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Canceling for "CANCELING"
            /// </summary>
            [EnumMember(Value = "CANCELING")]
            Canceling,
            
            /// <summary>
            /// Enum Canceled for "CANCELED"
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            Canceled
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets CommandType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CommandTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Upload for "UPLOAD"
            /// </summary>
            [EnumMember(Value = "UPLOAD")]
            Upload,
            
            /// <summary>
            /// Enum Copydocument for "COPYDOCUMENT"
            /// </summary>
            [EnumMember(Value = "COPYDOCUMENT")]
            Copydocument,
            
            /// <summary>
            /// Enum Movedocument for "MOVEDOCUMENT"
            /// </summary>
            [EnumMember(Value = "MOVEDOCUMENT")]
            Movedocument,
            
            /// <summary>
            /// Enum Deleteworkspace for "DELETEWORKSPACE"
            /// </summary>
            [EnumMember(Value = "DELETEWORKSPACE")]
            Deleteworkspace,
            
            /// <summary>
            /// Enum Deletedocument for "DELETEDOCUMENT"
            /// </summary>
            [EnumMember(Value = "DELETEDOCUMENT")]
            Deletedocument,
            
            /// <summary>
            /// Enum Deletetag for "DELETETAG"
            /// </summary>
            [EnumMember(Value = "DELETETAG")]
            Deletetag,
            
            /// <summary>
            /// Enum Updatetag for "UPDATETAG"
            /// </summary>
            [EnumMember(Value = "UPDATETAG")]
            Updatetag,
            
            /// <summary>
            /// Enum Reindex for "REINDEX"
            /// </summary>
            [EnumMember(Value = "REINDEX")]
            Reindex,
            
            /// <summary>
            /// Enum Cleanup for "CLEANUP"
            /// </summary>
            [EnumMember(Value = "CLEANUP")]
            Cleanup,
            
            /// <summary>
            /// Enum Replacedocument for "REPLACEDOCUMENT"
            /// </summary>
            [EnumMember(Value = "REPLACEDOCUMENT")]
            Replacedocument
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public StatusCodeEnum? StatusCode { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CommandType
        /// </summary>
        [DataMember(Name="commandType", EmitDefaultValue=false)]
        public CommandTypeEnum? CommandType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandStatus" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="Expiration">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="UserId">UserId.</param>
        
        
        
        /// <param name="StatusCode">StatusCode.</param>
        
        
        
        /// <param name="CommandType">CommandType.</param>
        
        
        
        /// <param name="Document">Document.</param>
        
        
        
        
        public CommandStatus(string Name = null, DateTime? Expiration = null, string UserId = null, StatusCodeEnum? StatusCode = null, CommandTypeEnum? CommandType = null, Document Document = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.Expiration = Expiration;
            
            
            
            
            
            
            
            
this.UserId = UserId;
            
            
            
            
            
            
            
            
this.StatusCode = StatusCode;
            
            
            
            
            
            
            
            
this.CommandType = CommandType;
            
            
            
            
            
            
            
            
this.Document = Document;
            
            
            
            
            
            
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
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }
        
        
        
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
            sb.Append("class CommandStatus {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            
            sb.Append("  CommandType: ").Append(CommandType).Append("\n");
            
            sb.Append("  Document: ").Append(Document).Append("\n");
            
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
            return this.Equals(obj as CommandStatus);
        }

        /// <summary>
        /// Returns true if CommandStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of CommandStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommandStatus other)
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
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) &&
                (
                    this.CommandType == other.CommandType ||
                    this.CommandType != null &&
                    this.CommandType.Equals(other.CommandType)
                ) &&
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
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
                
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                
                if (this.CommandType != null)
                    hash = hash * 59 + this.CommandType.GetHashCode();
                
                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
