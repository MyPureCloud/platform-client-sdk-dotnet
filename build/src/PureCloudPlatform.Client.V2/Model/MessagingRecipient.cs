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
    /// This is used to identify who the message is sent to, as well as who it was sent from. This information is channel specific - depends on capabilities to describe party by the platform
    /// </summary>
    [DataContract]
    public partial class MessagingRecipient :  IEquatable<MessagingRecipient>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// The recipient identifier type. This is used to indicate the format used by the recipient identifier.
        /// </summary>
        /// <value>The recipient identifier type. This is used to indicate the format used by the recipient identifier.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IdTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Opaque for "Opaque"
            /// </summary>
            [EnumMember(Value = "Opaque")]
            Opaque
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The recipient identifier type. This is used to indicate the format used by the recipient identifier.
        /// </summary>
        /// <value>The recipient identifier type. This is used to indicate the format used by the recipient identifier.</value>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public IdTypeEnum? IdType { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingRecipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingRecipient() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingRecipient" /> class.
        /// </summary>
        /// <param name="Id">The recipient identifier specific for particular channel/integration. This is required when sending a message. (required).</param>
        /// <param name="IdType">The recipient identifier type. This is used to indicate the format used by the recipient identifier..</param>
        public MessagingRecipient(string Id = null, IdTypeEnum? IdType = null)
        {
            this.Id = Id;
            this.IdType = IdType;
            
        }
        
        
        
        /// <summary>
        /// Nickname/user name
        /// </summary>
        /// <value>Nickname/user name</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; private set; }
        
        
        
        /// <summary>
        /// The recipient identifier specific for particular channel/integration. This is required when sending a message.
        /// </summary>
        /// <value>The recipient identifier specific for particular channel/integration. This is required when sending a message.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// Avatar image
        /// </summary>
        /// <value>Avatar image</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; private set; }
        
        
        
        /// <summary>
        /// Sender&#39;s first name
        /// </summary>
        /// <value>Sender&#39;s first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; private set; }
        
        
        
        /// <summary>
        /// Sender&#39;s last name
        /// </summary>
        /// <value>Sender&#39;s last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; private set; }
        
        
        
        /// <summary>
        /// Sender&#39;s email address
        /// </summary>
        /// <value>Sender&#39;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingRecipient {\n");
            
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(obj as MessagingRecipient);
        }

        /// <summary>
        /// Returns true if MessagingRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Nickname == other.Nickname ||
                    this.Nickname != null &&
                    this.Nickname.Equals(other.Nickname)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.IdType == other.IdType ||
                    this.IdType != null &&
                    this.IdType.Equals(other.IdType)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) &&
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) &&
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                
                if (this.Nickname != null)
                    hash = hash * 59 + this.Nickname.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdType != null)
                    hash = hash * 59 + this.IdType.GetHashCode();
                
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                return hash;
            }
        }
    }

}
