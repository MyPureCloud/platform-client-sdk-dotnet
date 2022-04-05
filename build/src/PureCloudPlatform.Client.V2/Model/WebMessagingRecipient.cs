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
    /// Information about the recipient the message is sent to or received from.
    /// </summary>
    [DataContract]
    public partial class WebMessagingRecipient :  IEquatable<WebMessagingRecipient>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebMessagingRecipient" /> class.
        /// </summary>
        public WebMessagingRecipient()
        {
            
        }
        
        
        
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
        /// Nickname or display name of the recipient.
        /// </summary>
        /// <value>Nickname or display name of the recipient.</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; private set; }
        
        
        
        /// <summary>
        /// List of recipient additional identifiers
        /// </summary>
        /// <value>List of recipient additional identifiers</value>
        [DataMember(Name="additionalIds", EmitDefaultValue=false)]
        public List<RecipientAdditionalIdentifier> AdditionalIds { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebMessagingRecipient {\n");
            
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
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
            return this.Equals(obj as WebMessagingRecipient);
        }

        /// <summary>
        /// Returns true if WebMessagingRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of WebMessagingRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebMessagingRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Nickname == other.Nickname ||
                    this.Nickname != null &&
                    this.Nickname.Equals(other.Nickname)
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
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Nickname != null)
                    hash = hash * 59 + this.Nickname.GetHashCode();
                
                if (this.AdditionalIds != null)
                    hash = hash * 59 + this.AdditionalIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
