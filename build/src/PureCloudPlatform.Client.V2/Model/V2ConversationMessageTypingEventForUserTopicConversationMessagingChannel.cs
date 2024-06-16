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
    /// V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel :  IEquatable<V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel>
    {
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Twitter for "Twitter"
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Facebook for "Facebook"
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook,
            
            /// <summary>
            /// Enum Instagram for "Instagram"
            /// </summary>
            [EnumMember(Value = "Instagram")]
            Instagram,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Whatsapp for "Whatsapp"
            /// </summary>
            [EnumMember(Value = "Whatsapp")]
            Whatsapp,
            
            /// <summary>
            /// Enum Webmessaging for "WebMessaging"
            /// </summary>
            [EnumMember(Value = "WebMessaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms
        }
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum? Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Platform">Platform.</param>
        /// <param name="To">To.</param>
        /// <param name="From">From.</param>
        /// <param name="Time">Time.</param>
        public V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel(string Id = null, PlatformEnum? Platform = null, V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient To = null, V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient From = null, DateTime? Time = null)
        {
            this.Id = Id;
            this.Platform = Platform;
            this.To = To;
            this.From = From;
            this.Time = Time;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationMessagingToRecipient To { get; set; }



        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationMessagingFromRecipient From { get; set; }



        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationMessagingChannel other)
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
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
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

                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();

                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();

                return hash;
            }
        }
    }

}
