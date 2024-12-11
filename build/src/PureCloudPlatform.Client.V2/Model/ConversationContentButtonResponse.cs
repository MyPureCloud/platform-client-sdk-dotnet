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
    /// Button response object representing the click of a structured message button, such as a quick reply.
    /// </summary>
    [DataContract]
    public partial class ConversationContentButtonResponse :  IEquatable<ConversationContentButtonResponse>
    {
        /// <summary>
        /// Describes the button that resulted in the Button Response.
        /// </summary>
        /// <value>Describes the button that resulted in the Button Response.</value>
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
            /// Enum Button for "Button"
            /// </summary>
            [EnumMember(Value = "Button")]
            Button,
            
            /// <summary>
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply,
            
            /// <summary>
            /// Enum Datepicker for "DatePicker"
            /// </summary>
            [EnumMember(Value = "DatePicker")]
            Datepicker
        }
        /// <summary>
        /// Describes the button that resulted in the Button Response.
        /// </summary>
        /// <value>Describes the button that resulted in the Button Response.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentButtonResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentButtonResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentButtonResponse" /> class.
        /// </summary>
        /// <param name="Type">Describes the button that resulted in the Button Response..</param>
        /// <param name="Text">The response text from the button click. (required).</param>
        /// <param name="Payload">The response payload associated with the clicked button. (required).</param>
        public ConversationContentButtonResponse(TypeEnum? Type = null, string Text = null, string Payload = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Payload = Payload;
            
        }
        




        /// <summary>
        /// The response text from the button click.
        /// </summary>
        /// <value>The response text from the button click.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// The response payload associated with the clicked button.
        /// </summary>
        /// <value>The response payload associated with the clicked button.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentButtonResponse {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(obj as ConversationContentButtonResponse);
        }

        /// <summary>
        /// Returns true if ConversationContentButtonResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentButtonResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentButtonResponse other)
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

                return hash;
            }
        }
    }

}
