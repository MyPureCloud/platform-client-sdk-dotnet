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
    /// A message in the conversation history provided to a guide session turn.
    /// </summary>
    [DataContract]
    public partial class GuideSessionMessage :  IEquatable<GuideSessionMessage>
    {
        /// <summary>
        /// The role of the message author.
        /// </summary>
        /// <value>The role of the message author.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Assistant for "Assistant"
            /// </summary>
            [EnumMember(Value = "Assistant")]
            Assistant
        }
        /// <summary>
        /// The role of the message author.
        /// </summary>
        /// <value>The role of the message author.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum? Role { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuideSessionMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuideSessionMessage" /> class.
        /// </summary>
        /// <param name="Role">The role of the message author. (required).</param>
        /// <param name="Content">The content of the message. (required).</param>
        public GuideSessionMessage(RoleEnum? Role = null, string Content = null)
        {
            this.Role = Role;
            this.Content = Content;
            
        }
        




        /// <summary>
        /// The content of the message.
        /// </summary>
        /// <value>The content of the message.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuideSessionMessage {\n");

            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as GuideSessionMessage);
        }

        /// <summary>
        /// Returns true if GuideSessionMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of GuideSessionMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuideSessionMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
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
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();

                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                return hash;
            }
        }
    }

}
