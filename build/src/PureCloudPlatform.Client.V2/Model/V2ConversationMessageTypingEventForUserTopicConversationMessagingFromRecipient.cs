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
    /// V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient :  IEquatable<V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient>
    {
        /// <summary>
        /// Gets or Sets IdType
        /// </summary>
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
        /// Gets or Sets IdType
        /// </summary>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public IdTypeEnum? IdType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient" /> class.
        /// </summary>
        /// <param name="Nickname">Nickname.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IdType">IdType.</param>
        /// <param name="Image">Image.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Email">Email.</param>
        /// <param name="AdditionalIds">AdditionalIds.</param>
        public V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient(string Nickname = null, string Id = null, IdTypeEnum? IdType = null, string Image = null, string FirstName = null, string LastName = null, string Email = null, List<V2ConversationMessageTypingEventForUserTopicConversationRecipientAdditionalIdentifier> AdditionalIds = null)
        {
            this.Nickname = Nickname;
            this.Id = Id;
            this.IdType = IdType;
            this.Image = Image;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.AdditionalIds = AdditionalIds;
            
        }
        


        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }



        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }



        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }



        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }



        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalIds
        /// </summary>
        [DataMember(Name="additionalIds", EmitDefaultValue=false)]
        public List<V2ConversationMessageTypingEventForUserTopicConversationRecipientAdditionalIdentifier> AdditionalIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient {\n");

            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient other)
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

                if (this.AdditionalIds != null)
                    hash = hash * 59 + this.AdditionalIds.GetHashCode();

                return hash;
            }
        }
    }

}
