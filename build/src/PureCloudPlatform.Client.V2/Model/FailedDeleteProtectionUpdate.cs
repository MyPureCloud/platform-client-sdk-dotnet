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
    /// FailedDeleteProtectionUpdate
    /// </summary>
    [DataContract]
    public partial class FailedDeleteProtectionUpdate :  IEquatable<FailedDeleteProtectionUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FailedDeleteProtectionUpdate" /> class.
        /// </summary>
        /// <param name="Conversation">Conversation.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        public FailedDeleteProtectionUpdate(ConversationReference Conversation = null, string ErrorMessage = null, string ErrorCode = null)
        {
            this.Conversation = Conversation;
            this.ErrorMessage = ErrorMessage;
            this.ErrorCode = ErrorCode;
            
        }
        


        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationReference Conversation { get; set; }



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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailedDeleteProtectionUpdate {\n");

            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(obj as FailedDeleteProtectionUpdate);
        }

        /// <summary>
        /// Returns true if FailedDeleteProtectionUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of FailedDeleteProtectionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FailedDeleteProtectionUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
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
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();

                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                return hash;
            }
        }
    }

}
