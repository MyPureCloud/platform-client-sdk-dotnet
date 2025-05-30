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
    /// A Presence event.
    /// </summary>
    [DataContract]
    public partial class ConversationEventPresence :  IEquatable<ConversationEventPresence>
    {
        /// <summary>
        /// Describes the type of Presence event.
        /// </summary>
        /// <value>Describes the type of Presence event.</value>
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
            /// Enum Join for "Join"
            /// </summary>
            [EnumMember(Value = "Join")]
            Join,
            
            /// <summary>
            /// Enum Disconnect for "Disconnect"
            /// </summary>
            [EnumMember(Value = "Disconnect")]
            Disconnect,
            
            /// <summary>
            /// Enum Clear for "Clear"
            /// </summary>
            [EnumMember(Value = "Clear")]
            Clear,
            
            /// <summary>
            /// Enum Signin for "SignIn"
            /// </summary>
            [EnumMember(Value = "SignIn")]
            Signin,
            
            /// <summary>
            /// Enum Sessionexpired for "SessionExpired"
            /// </summary>
            [EnumMember(Value = "SessionExpired")]
            Sessionexpired,
            
            /// <summary>
            /// Enum Authenticate for "Authenticate"
            /// </summary>
            [EnumMember(Value = "Authenticate")]
            Authenticate,
            
            /// <summary>
            /// Enum Authenticatefailure for "AuthenticateFailure"
            /// </summary>
            [EnumMember(Value = "AuthenticateFailure")]
            Authenticatefailure,
            
            /// <summary>
            /// Enum Authenticatecancel for "AuthenticateCancel"
            /// </summary>
            [EnumMember(Value = "AuthenticateCancel")]
            Authenticatecancel
        }
        /// <summary>
        /// Describes the type of Presence event.
        /// </summary>
        /// <value>Describes the type of Presence event.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventPresence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationEventPresence() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEventPresence" /> class.
        /// </summary>
        /// <param name="Type">Describes the type of Presence event. (required).</param>
        /// <param name="ReceivedMessage">A sign in prompt message for when the authenticate event is received..</param>
        /// <param name="ReplyMessage">A reply message on authentication success..</param>
        public ConversationEventPresence(TypeEnum? Type = null, ConversationContentReceivedReplyMessage ReceivedMessage = null, ConversationContentReceivedReplyMessage ReplyMessage = null)
        {
            this.Type = Type;
            this.ReceivedMessage = ReceivedMessage;
            this.ReplyMessage = ReplyMessage;
            
        }
        




        /// <summary>
        /// A sign in prompt message for when the authenticate event is received.
        /// </summary>
        /// <value>A sign in prompt message for when the authenticate event is received.</value>
        [DataMember(Name="receivedMessage", EmitDefaultValue=false)]
        public ConversationContentReceivedReplyMessage ReceivedMessage { get; set; }



        /// <summary>
        /// A reply message on authentication success.
        /// </summary>
        /// <value>A reply message on authentication success.</value>
        [DataMember(Name="replyMessage", EmitDefaultValue=false)]
        public ConversationContentReceivedReplyMessage ReplyMessage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationEventPresence {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReceivedMessage: ").Append(ReceivedMessage).Append("\n");
            sb.Append("  ReplyMessage: ").Append(ReplyMessage).Append("\n");
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
            return this.Equals(obj as ConversationEventPresence);
        }

        /// <summary>
        /// Returns true if ConversationEventPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationEventPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationEventPresence other)
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
                    this.ReceivedMessage == other.ReceivedMessage ||
                    this.ReceivedMessage != null &&
                    this.ReceivedMessage.Equals(other.ReceivedMessage)
                ) &&
                (
                    this.ReplyMessage == other.ReplyMessage ||
                    this.ReplyMessage != null &&
                    this.ReplyMessage.Equals(other.ReplyMessage)
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

                if (this.ReceivedMessage != null)
                    hash = hash * 59 + this.ReceivedMessage.GetHashCode();

                if (this.ReplyMessage != null)
                    hash = hash * 59 + this.ReplyMessage.GetHashCode();

                return hash;
            }
        }
    }

}
