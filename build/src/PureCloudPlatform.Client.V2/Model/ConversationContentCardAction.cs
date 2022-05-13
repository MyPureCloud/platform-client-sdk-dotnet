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
    /// CardAction Object
    /// </summary>
    [DataContract]
    public partial class ConversationContentCardAction :  IEquatable<ConversationContentCardAction>
    {
        /// <summary>
        /// Describes the type of action.
        /// </summary>
        /// <value>Describes the type of action.</value>
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
            /// Enum Link for "Link"
            /// </summary>
            [EnumMember(Value = "Link")]
            Link,
            
            /// <summary>
            /// Enum Postback for "Postback"
            /// </summary>
            [EnumMember(Value = "Postback")]
            Postback,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Describes the type of action.
        /// </summary>
        /// <value>Describes the type of action.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentCardAction" /> class.
        /// </summary>
        /// <param name="Type">Describes the type of action..</param>
        /// <param name="Text">The response text from the button click..</param>
        /// <param name="Payload">Text to be returned as the payload from a ButtonResponse when a button is clicked..</param>
        /// <param name="Url">A URL of a web page to direct the user to..</param>
        public ConversationContentCardAction(TypeEnum? Type = null, string Text = null, string Payload = null, string Url = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Payload = Payload;
            this.Url = Url;
            
        }
        




        /// <summary>
        /// The response text from the button click.
        /// </summary>
        /// <value>The response text from the button click.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Text to be returned as the payload from a ButtonResponse when a button is clicked.
        /// </summary>
        /// <value>Text to be returned as the payload from a ButtonResponse when a button is clicked.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }



        /// <summary>
        /// A URL of a web page to direct the user to.
        /// </summary>
        /// <value>A URL of a web page to direct the user to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentCardAction {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as ConversationContentCardAction);
        }

        /// <summary>
        /// Returns true if ConversationContentCardAction instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentCardAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentCardAction other)
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
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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

                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                return hash;
            }
        }
    }

}
