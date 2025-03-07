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
    /// Button
    /// </summary>
    [DataContract]
    public partial class Button :  IEquatable<Button>
    {
        /// <summary>
        /// Type of button to include in whatsApp template
        /// </summary>
        /// <value>Type of button to include in whatsApp template</value>
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
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply,
            
            /// <summary>
            /// Enum Phonenumber for "PhoneNumber"
            /// </summary>
            [EnumMember(Value = "PhoneNumber")]
            Phonenumber,
            
            /// <summary>
            /// Enum Url for "Url"
            /// </summary>
            [EnumMember(Value = "Url")]
            Url
        }
        /// <summary>
        /// Type of button to include in whatsApp template
        /// </summary>
        /// <value>Type of button to include in whatsApp template</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Button" /> class.
        /// </summary>
        /// <param name="Type">Type of button to include in whatsApp template.</param>
        /// <param name="Content">Content of the button. Use for &#39;Url&#39; or &#39;PhoneNumber&#39; button type.</param>
        /// <param name="ContentText">The text label that will be displayed on the button.</param>
        public Button(TypeEnum? Type = null, string Content = null, string ContentText = null)
        {
            this.Type = Type;
            this.Content = Content;
            this.ContentText = ContentText;
            
        }
        




        /// <summary>
        /// Content of the button. Use for &#39;Url&#39; or &#39;PhoneNumber&#39; button type
        /// </summary>
        /// <value>Content of the button. Use for &#39;Url&#39; or &#39;PhoneNumber&#39; button type</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }



        /// <summary>
        /// The text label that will be displayed on the button
        /// </summary>
        /// <value>The text label that will be displayed on the button</value>
        [DataMember(Name="contentText", EmitDefaultValue=false)]
        public string ContentText { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Button {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentText: ").Append(ContentText).Append("\n");
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
            return this.Equals(obj as Button);
        }

        /// <summary>
        /// Returns true if Button instances are equal
        /// </summary>
        /// <param name="other">Instance of Button to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Button other)
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
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.ContentText == other.ContentText ||
                    this.ContentText != null &&
                    this.ContentText.Equals(other.ContentText)
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

                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                if (this.ContentText != null)
                    hash = hash * 59 + this.ContentText.GetHashCode();

                return hash;
            }
        }
    }

}
