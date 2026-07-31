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
    /// UserEntity
    /// </summary>
    [DataContract]
    public partial class UserEntity :  IEquatable<UserEntity>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEntity" /> class.
        /// </summary>
        /// <param name="Id">The user handle for the account being registered (base64url-encoded binary). (required).</param>
        /// <param name="Name">A human-palatable identifier for the account (e.g., username or email). (required).</param>
        /// <param name="DisplayName">A human-friendly display name for the account. (required).</param>
        public UserEntity(string Id = null, string Name = null, string DisplayName = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DisplayName = DisplayName;
            
        }
        


        /// <summary>
        /// The user handle for the account being registered (base64url-encoded binary).
        /// </summary>
        /// <value>The user handle for the account being registered (base64url-encoded binary).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// A human-palatable identifier for the account (e.g., username or email).
        /// </summary>
        /// <value>A human-palatable identifier for the account (e.g., username or email).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// A human-friendly display name for the account.
        /// </summary>
        /// <value>A human-friendly display name for the account.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(obj as UserEntity);
        }

        /// <summary>
        /// Returns true if UserEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of UserEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                return hash;
            }
        }
    }

}
