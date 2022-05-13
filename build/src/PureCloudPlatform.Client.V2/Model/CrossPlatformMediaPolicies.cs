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
    /// CrossPlatformMediaPolicies
    /// </summary>
    [DataContract]
    public partial class CrossPlatformMediaPolicies :  IEquatable<CrossPlatformMediaPolicies>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossPlatformMediaPolicies" /> class.
        /// </summary>
        /// <param name="CallPolicy">Conditions and actions for calls.</param>
        /// <param name="ChatPolicy">Conditions and actions for chats.</param>
        /// <param name="EmailPolicy">Conditions and actions for emails.</param>
        /// <param name="MessagePolicy">Conditions and actions for messages.</param>
        public CrossPlatformMediaPolicies(CrossPlatformCallMediaPolicy CallPolicy = null, CrossPlatformChatMediaPolicy ChatPolicy = null, CrossPlatformEmailMediaPolicy EmailPolicy = null, CrossPlatformMessageMediaPolicy MessagePolicy = null)
        {
            this.CallPolicy = CallPolicy;
            this.ChatPolicy = ChatPolicy;
            this.EmailPolicy = EmailPolicy;
            this.MessagePolicy = MessagePolicy;
            
        }
        


        /// <summary>
        /// Conditions and actions for calls
        /// </summary>
        /// <value>Conditions and actions for calls</value>
        [DataMember(Name="callPolicy", EmitDefaultValue=false)]
        public CrossPlatformCallMediaPolicy CallPolicy { get; set; }



        /// <summary>
        /// Conditions and actions for chats
        /// </summary>
        /// <value>Conditions and actions for chats</value>
        [DataMember(Name="chatPolicy", EmitDefaultValue=false)]
        public CrossPlatformChatMediaPolicy ChatPolicy { get; set; }



        /// <summary>
        /// Conditions and actions for emails
        /// </summary>
        /// <value>Conditions and actions for emails</value>
        [DataMember(Name="emailPolicy", EmitDefaultValue=false)]
        public CrossPlatformEmailMediaPolicy EmailPolicy { get; set; }



        /// <summary>
        /// Conditions and actions for messages
        /// </summary>
        /// <value>Conditions and actions for messages</value>
        [DataMember(Name="messagePolicy", EmitDefaultValue=false)]
        public CrossPlatformMessageMediaPolicy MessagePolicy { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossPlatformMediaPolicies {\n");

            sb.Append("  CallPolicy: ").Append(CallPolicy).Append("\n");
            sb.Append("  ChatPolicy: ").Append(ChatPolicy).Append("\n");
            sb.Append("  EmailPolicy: ").Append(EmailPolicy).Append("\n");
            sb.Append("  MessagePolicy: ").Append(MessagePolicy).Append("\n");
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
            return this.Equals(obj as CrossPlatformMediaPolicies);
        }

        /// <summary>
        /// Returns true if CrossPlatformMediaPolicies instances are equal
        /// </summary>
        /// <param name="other">Instance of CrossPlatformMediaPolicies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossPlatformMediaPolicies other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CallPolicy == other.CallPolicy ||
                    this.CallPolicy != null &&
                    this.CallPolicy.Equals(other.CallPolicy)
                ) &&
                (
                    this.ChatPolicy == other.ChatPolicy ||
                    this.ChatPolicy != null &&
                    this.ChatPolicy.Equals(other.ChatPolicy)
                ) &&
                (
                    this.EmailPolicy == other.EmailPolicy ||
                    this.EmailPolicy != null &&
                    this.EmailPolicy.Equals(other.EmailPolicy)
                ) &&
                (
                    this.MessagePolicy == other.MessagePolicy ||
                    this.MessagePolicy != null &&
                    this.MessagePolicy.Equals(other.MessagePolicy)
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
                if (this.CallPolicy != null)
                    hash = hash * 59 + this.CallPolicy.GetHashCode();

                if (this.ChatPolicy != null)
                    hash = hash * 59 + this.ChatPolicy.GetHashCode();

                if (this.EmailPolicy != null)
                    hash = hash * 59 + this.EmailPolicy.GetHashCode();

                if (this.MessagePolicy != null)
                    hash = hash * 59 + this.MessagePolicy.GetHashCode();

                return hash;
            }
        }
    }

}
