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
    /// MessageEvaluation
    /// </summary>
    [DataContract]
    public partial class MessageEvaluation :  IEquatable<MessageEvaluation>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageEvaluation" /> class.
        /// </summary>
        /// <param name="ContactColumn">ContactColumn.</param>
        /// <param name="ContactAddress">ContactAddress.</param>
        /// <param name="WrapupCodeId">WrapupCodeId.</param>
        /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public MessageEvaluation(string ContactColumn = null, string ContactAddress = null, string WrapupCodeId = null, DateTime? Timestamp = null)
        {
            this.ContactColumn = ContactColumn;
            this.ContactAddress = ContactAddress;
            this.WrapupCodeId = WrapupCodeId;
            this.Timestamp = Timestamp;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets ContactColumn
        /// </summary>
        [DataMember(Name="contactColumn", EmitDefaultValue=false)]
        public string ContactColumn { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContactAddress
        /// </summary>
        [DataMember(Name="contactAddress", EmitDefaultValue=false)]
        public string ContactAddress { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WrapupCodeId
        /// </summary>
        [DataMember(Name="wrapupCodeId", EmitDefaultValue=false)]
        public string WrapupCodeId { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageEvaluation {\n");
            
            sb.Append("  ContactColumn: ").Append(ContactColumn).Append("\n");
            sb.Append("  ContactAddress: ").Append(ContactAddress).Append("\n");
            sb.Append("  WrapupCodeId: ").Append(WrapupCodeId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as MessageEvaluation);
        }

        /// <summary>
        /// Returns true if MessageEvaluation instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageEvaluation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageEvaluation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactColumn == other.ContactColumn ||
                    this.ContactColumn != null &&
                    this.ContactColumn.Equals(other.ContactColumn)
                ) &&
                (
                    this.ContactAddress == other.ContactAddress ||
                    this.ContactAddress != null &&
                    this.ContactAddress.Equals(other.ContactAddress)
                ) &&
                (
                    this.WrapupCodeId == other.WrapupCodeId ||
                    this.WrapupCodeId != null &&
                    this.WrapupCodeId.Equals(other.WrapupCodeId)
                ) &&
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                
                if (this.ContactColumn != null)
                    hash = hash * 59 + this.ContactColumn.GetHashCode();
                
                if (this.ContactAddress != null)
                    hash = hash * 59 + this.ContactAddress.GetHashCode();
                
                if (this.WrapupCodeId != null)
                    hash = hash * 59 + this.WrapupCodeId.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                
                return hash;
            }
        }
    }

}
