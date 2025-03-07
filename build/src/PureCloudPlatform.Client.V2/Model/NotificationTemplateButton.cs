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
    /// Template button object
    /// </summary>
    [DataContract]
    public partial class NotificationTemplateButton :  IEquatable<NotificationTemplateButton>
    {
        /// <summary>
        /// Specifies the type of the button.
        /// </summary>
        /// <value>Specifies the type of the button.</value>
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
        /// Specifies the type of the button.
        /// </summary>
        /// <value>Specifies the type of the button.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTemplateButton" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationTemplateButton() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationTemplateButton" /> class.
        /// </summary>
        /// <param name="Type">Specifies the type of the button. (required).</param>
        /// <param name="Text">Button text message..</param>
        /// <param name="Index">index of the button in the list. (required).</param>
        /// <param name="PhoneNumber">Button phone number..</param>
        /// <param name="Url">Button URL link..</param>
        /// <param name="Parameters">Template parameters for placeholders in the button..</param>
        public NotificationTemplateButton(TypeEnum? Type = null, string Text = null, long? Index = null, string PhoneNumber = null, string Url = null, List<NotificationTemplateParameter> Parameters = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Index = Index;
            this.PhoneNumber = PhoneNumber;
            this.Url = Url;
            this.Parameters = Parameters;
            
        }
        




        /// <summary>
        /// Button text message.
        /// </summary>
        /// <value>Button text message.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// index of the button in the list.
        /// </summary>
        /// <value>index of the button in the list.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public long? Index { get; set; }



        /// <summary>
        /// Button phone number.
        /// </summary>
        /// <value>Button phone number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }



        /// <summary>
        /// Button URL link.
        /// </summary>
        /// <value>Button URL link.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Template parameters for placeholders in the button.
        /// </summary>
        /// <value>Template parameters for placeholders in the button.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<NotificationTemplateParameter> Parameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationTemplateButton {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as NotificationTemplateButton);
        }

        /// <summary>
        /// Returns true if NotificationTemplateButton instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationTemplateButton to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationTemplateButton other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();

                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                return hash;
            }
        }
    }

}
