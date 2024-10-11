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
    /// Information about the recipient the message is sent to.
    /// </summary>
    [DataContract]
    public partial class ConversationMessagingToRecipient :  IEquatable<ConversationMessagingToRecipient>
    {
        /// <summary>
        /// The recipient ID type. This is used to indicate the format used for the ID.
        /// </summary>
        /// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
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
            Opaque,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic
        }
        /// <summary>
        /// The recipient ID type. This is used to indicate the format used for the ID.
        /// </summary>
        /// <value>The recipient ID type. This is used to indicate the format used for the ID.</value>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public IdTypeEnum? IdType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessagingToRecipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationMessagingToRecipient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessagingToRecipient" /> class.
        /// </summary>
        /// <param name="Id">The recipient ID specific to the provider. (required).</param>
        /// <param name="ExternalContactId">The identifier of the external contact..</param>
        public ConversationMessagingToRecipient(string Id = null, string ExternalContactId = null)
        {
            this.Id = Id;
            this.ExternalContactId = ExternalContactId;
            
        }
        


        /// <summary>
        /// Nickname or display name of the recipient.
        /// </summary>
        /// <value>Nickname or display name of the recipient.</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; private set; }



        /// <summary>
        /// The recipient ID specific to the provider.
        /// </summary>
        /// <value>The recipient ID specific to the provider.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// URL of an image that represents the recipient.
        /// </summary>
        /// <value>URL of an image that represents the recipient.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; private set; }



        /// <summary>
        /// First name of the recipient.
        /// </summary>
        /// <value>First name of the recipient.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; private set; }



        /// <summary>
        /// Last name of the recipient.
        /// </summary>
        /// <value>Last name of the recipient.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; private set; }



        /// <summary>
        /// E-mail address of the recipient.
        /// </summary>
        /// <value>E-mail address of the recipient.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; private set; }



        /// <summary>
        /// The identifier of the external contact.
        /// </summary>
        /// <value>The identifier of the external contact.</value>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }



        /// <summary>
        /// List of recipient additional identifiers
        /// </summary>
        /// <value>List of recipient additional identifiers</value>
        [DataMember(Name="additionalIds", EmitDefaultValue=false)]
        public List<ConversationRecipientAdditionalIdentifier> AdditionalIds { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMessagingToRecipient {\n");

            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  AdditionalIds: ").Append(AdditionalIds).Append("\n");
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
            return this.Equals(obj as ConversationMessagingToRecipient);
        }

        /// <summary>
        /// Returns true if ConversationMessagingToRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationMessagingToRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMessagingToRecipient other)
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
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.AdditionalIds == other.AdditionalIds ||
                    this.AdditionalIds != null &&
                    this.AdditionalIds.SequenceEqual(other.AdditionalIds)
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

                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();

                if (this.AdditionalIds != null)
                    hash = hash * 59 + this.AdditionalIds.GetHashCode();

                return hash;
            }
        }
    }

}
