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
    /// An ephemeral story.
    /// </summary>
    [DataContract]
    public partial class ContentStory :  IEquatable<ContentStory>
    {
        /// <summary>
        /// Type of ephemeral story attachment.
        /// </summary>
        /// <value>Type of ephemeral story attachment.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Mention for "Mention"
            /// </summary>
            [EnumMember(Value = "Mention")]
            Mention,
            
            /// <summary>
            /// Enum Reply for "Reply"
            /// </summary>
            [EnumMember(Value = "Reply")]
            Reply
        }
        /// <summary>
        /// Type of ephemeral story attachment.
        /// </summary>
        /// <value>Type of ephemeral story attachment.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentStory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentStory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentStory" /> class.
        /// </summary>
        /// <param name="Type">Type of ephemeral story attachment. (required).</param>
        /// <param name="Url">URL to the ephemeral story. (required).</param>
        /// <param name="ReplyToId">ID of the ephemeral story being replied to..</param>
        public ContentStory(TypeEnum? Type = null, string Url = null, string ReplyToId = null)
        {
            this.Type = Type;
            this.Url = Url;
            this.ReplyToId = ReplyToId;
            
        }
        




        /// <summary>
        /// URL to the ephemeral story.
        /// </summary>
        /// <value>URL to the ephemeral story.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// ID of the ephemeral story being replied to.
        /// </summary>
        /// <value>ID of the ephemeral story being replied to.</value>
        [DataMember(Name="replyToId", EmitDefaultValue=false)]
        public string ReplyToId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentStory {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
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
            return this.Equals(obj as ContentStory);
        }

        /// <summary>
        /// Returns true if ContentStory instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentStory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentStory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.ReplyToId == other.ReplyToId ||
                    this.ReplyToId != null &&
                    this.ReplyToId.Equals(other.ReplyToId)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.ReplyToId != null)
                    hash = hash * 59 + this.ReplyToId.GetHashCode();

                return hash;
            }
        }
    }

}
