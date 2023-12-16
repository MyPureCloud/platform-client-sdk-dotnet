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
    /// ChatReaction
    /// </summary>
    [DataContract]
    public partial class ChatReaction :  IEquatable<ChatReaction>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatReaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatReaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatReaction" /> class.
        /// </summary>
        /// <param name="Emoji">The emoji string for the reaction (required).</param>
        /// <param name="Users">The users that reacted with an emoji (required).</param>
        public ChatReaction(string Emoji = null, List<AddressableEntityRef> Users = null)
        {
            this.Emoji = Emoji;
            this.Users = Users;
            
        }
        


        /// <summary>
        /// The emoji string for the reaction
        /// </summary>
        /// <value>The emoji string for the reaction</value>
        [DataMember(Name="emoji", EmitDefaultValue=false)]
        public string Emoji { get; set; }



        /// <summary>
        /// The users that reacted with an emoji
        /// </summary>
        /// <value>The users that reacted with an emoji</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Users { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatReaction {\n");

            sb.Append("  Emoji: ").Append(Emoji).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as ChatReaction);
        }

        /// <summary>
        /// Returns true if ChatReaction instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatReaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatReaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Emoji == other.Emoji ||
                    this.Emoji != null &&
                    this.Emoji.Equals(other.Emoji)
                ) &&
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Emoji != null)
                    hash = hash * 59 + this.Emoji.GetHashCode();

                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();

                return hash;
            }
        }
    }

}
