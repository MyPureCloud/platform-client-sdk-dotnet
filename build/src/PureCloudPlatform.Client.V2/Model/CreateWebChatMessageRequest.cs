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
    /// CreateWebChatMessageRequest
    /// </summary>
    [DataContract]
    public partial class CreateWebChatMessageRequest :  IEquatable<CreateWebChatMessageRequest>
    {
        
        
        
        
        
        /// <summary>
        /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
        /// </summary>
        /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum BodyTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Standard for "standard"
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard,
            
            /// <summary>
            /// Enum Notice for "notice"
            /// </summary>
            [EnumMember(Value = "notice")]
            Notice,
            
            /// <summary>
            /// Enum Memberjoin for "member-join"
            /// </summary>
            [EnumMember(Value = "member-join")]
            Memberjoin,
            
            /// <summary>
            /// Enum Memberleave for "member-leave"
            /// </summary>
            [EnumMember(Value = "member-leave")]
            Memberleave,
            
            /// <summary>
            /// Enum Mediarequest for "media-request"
            /// </summary>
            [EnumMember(Value = "media-request")]
            Mediarequest
        }
        
        
        
        
        
        
        
        /// <summary>
        /// The purpose of the message within the conversation, such as a standard text entry versus a greeting.
        /// </summary>
        /// <value>The purpose of the message within the conversation, such as a standard text entry versus a greeting.</value>
        [DataMember(Name="bodyType", EmitDefaultValue=false)]
        public BodyTypeEnum? BodyType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebChatMessageRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatMessageRequest" /> class.
        /// </summary>
        /// <param name="Body">The message body. Note that message bodies are limited to 4,000 characters. (required).</param>
        /// <param name="BodyType">The purpose of the message within the conversation, such as a standard text entry versus a greeting..</param>
        public CreateWebChatMessageRequest(string Body = null, BodyTypeEnum? BodyType = null)
        {
            this.Body = Body;
            this.BodyType = BodyType;
            
        }
        
        
        
        /// <summary>
        /// The message body. Note that message bodies are limited to 4,000 characters.
        /// </summary>
        /// <value>The message body. Note that message bodies are limited to 4,000 characters.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebChatMessageRequest {\n");
            
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyType: ").Append(BodyType).Append("\n");
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
            return this.Equals(obj as CreateWebChatMessageRequest);
        }

        /// <summary>
        /// Returns true if CreateWebChatMessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateWebChatMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebChatMessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.BodyType == other.BodyType ||
                    this.BodyType != null &&
                    this.BodyType.Equals(other.BodyType)
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
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                
                if (this.BodyType != null)
                    hash = hash * 59 + this.BodyType.GetHashCode();
                
                return hash;
            }
        }
    }

}
