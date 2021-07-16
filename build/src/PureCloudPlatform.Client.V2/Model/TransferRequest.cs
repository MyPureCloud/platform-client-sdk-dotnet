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
    /// TransferRequest
    /// </summary>
    [DataContract]
    public partial class TransferRequest :  IEquatable<TransferRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRequest" /> class.
        /// </summary>
        /// <param name="UserId">The user ID of the transfer target..</param>
        /// <param name="Address">The phone number or address of the transfer target..</param>
        /// <param name="UserName">The user name of the transfer target..</param>
        /// <param name="QueueId">The queue ID of the transfer target..</param>
        /// <param name="Voicemail">If true, transfer to the voicemail inbox of the participant that is being replaced..</param>
        public TransferRequest(string UserId = null, string Address = null, string UserName = null, string QueueId = null, bool? Voicemail = null)
        {
            this.UserId = UserId;
            this.Address = Address;
            this.UserName = UserName;
            this.QueueId = QueueId;
            this.Voicemail = Voicemail;
            
        }
        
        
        
        /// <summary>
        /// The user ID of the transfer target.
        /// </summary>
        /// <value>The user ID of the transfer target.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        
        
        
        /// <summary>
        /// The phone number or address of the transfer target.
        /// </summary>
        /// <value>The phone number or address of the transfer target.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        
        
        
        /// <summary>
        /// The user name of the transfer target.
        /// </summary>
        /// <value>The user name of the transfer target.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        
        
        
        /// <summary>
        /// The queue ID of the transfer target.
        /// </summary>
        /// <value>The queue ID of the transfer target.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        
        
        
        /// <summary>
        /// If true, transfer to the voicemail inbox of the participant that is being replaced.
        /// </summary>
        /// <value>If true, transfer to the voicemail inbox of the participant that is being replaced.</value>
        [DataMember(Name="voicemail", EmitDefaultValue=false)]
        public bool? Voicemail { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferRequest {\n");
            
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
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
            return this.Equals(obj as TransferRequest);
        }

        /// <summary>
        /// Returns true if TransferRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.Voicemail == other.Voicemail ||
                    this.Voicemail != null &&
                    this.Voicemail.Equals(other.Voicemail)
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
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                
                if (this.Voicemail != null)
                    hash = hash * 59 + this.Voicemail.GetHashCode();
                
                return hash;
            }
        }
    }

}
