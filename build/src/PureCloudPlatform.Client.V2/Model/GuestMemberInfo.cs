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
    /// GuestMemberInfo
    /// </summary>
    [DataContract]
    public partial class GuestMemberInfo :  IEquatable<GuestMemberInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestMemberInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuestMemberInfo() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestMemberInfo" /> class.
        /// </summary>
        /// <param name="DisplayName">The display name to use for the guest member in the conversation. (required).</param>
        /// <param name="FirstName">The first name to use for the guest member in the conversation..</param>
        /// <param name="LastName">The last name to use for the guest member in the conversation..</param>
        /// <param name="Email">The email address to use for the guest member in the conversation..</param>
        /// <param name="PhoneNumber">The phone number to use for the guest member in the conversation..</param>
        /// <param name="AvatarImageUrl">The URL to the avatar image to use for the guest member in the conversation, if any..</param>
        /// <param name="CustomFields">Any custom fields of information, in key-value format, to attach to the guest member in the conversation..</param>
        public GuestMemberInfo(string DisplayName = null, string FirstName = null, string LastName = null, string Email = null, string PhoneNumber = null, string AvatarImageUrl = null, Dictionary<string, string> CustomFields = null)
        {
            this.DisplayName = DisplayName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.AvatarImageUrl = AvatarImageUrl;
            this.CustomFields = CustomFields;
            
        }
        
        
        
        /// <summary>
        /// The display name to use for the guest member in the conversation.
        /// </summary>
        /// <value>The display name to use for the guest member in the conversation.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        
        
        
        /// <summary>
        /// The first name to use for the guest member in the conversation.
        /// </summary>
        /// <value>The first name to use for the guest member in the conversation.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        
        
        
        /// <summary>
        /// The last name to use for the guest member in the conversation.
        /// </summary>
        /// <value>The last name to use for the guest member in the conversation.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        
        
        
        /// <summary>
        /// The email address to use for the guest member in the conversation.
        /// </summary>
        /// <value>The email address to use for the guest member in the conversation.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        
        
        
        /// <summary>
        /// The phone number to use for the guest member in the conversation.
        /// </summary>
        /// <value>The phone number to use for the guest member in the conversation.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// The URL to the avatar image to use for the guest member in the conversation, if any.
        /// </summary>
        /// <value>The URL to the avatar image to use for the guest member in the conversation, if any.</value>
        [DataMember(Name="avatarImageUrl", EmitDefaultValue=false)]
        public string AvatarImageUrl { get; set; }
        
        
        
        /// <summary>
        /// Any custom fields of information, in key-value format, to attach to the guest member in the conversation.
        /// </summary>
        /// <value>Any custom fields of information, in key-value format, to attach to the guest member in the conversation.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomFields { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuestMemberInfo {\n");
            
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  AvatarImageUrl: ").Append(AvatarImageUrl).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(obj as GuestMemberInfo);
        }

        /// <summary>
        /// Returns true if GuestMemberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of GuestMemberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuestMemberInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
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
                ) &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.AvatarImageUrl == other.AvatarImageUrl ||
                    this.AvatarImageUrl != null &&
                    this.AvatarImageUrl.Equals(other.AvatarImageUrl)
                ) &&
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
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
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.AvatarImageUrl != null)
                    hash = hash * 59 + this.AvatarImageUrl.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }
    }

}
