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
    /// SuggestionContext
    /// </summary>
    [DataContract]
    public partial class SuggestionContext :  IEquatable<SuggestionContext>
    {
        /// <summary>
        /// The media type of the conversation in which the suggestion event was raised.
        /// </summary>
        /// <value>The media type of the conversation in which the suggestion event was raised.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The media type of the conversation in which the suggestion event was raised.
        /// </summary>
        /// <value>The media type of the conversation in which the suggestion event was raised.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestionContext" /> class.
        /// </summary>
        public SuggestionContext()
        {
            
        }
        


        /// <summary>
        /// The queue used to assign the interaction to the user, if any.
        /// </summary>
        /// <value>The queue used to assign the interaction to the user, if any.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public AddressableEntityRef Queue { get; private set; }





        /// <summary>
        /// The agent participant who received the raised suggestion, if any.
        /// </summary>
        /// <value>The agent participant who received the raised suggestion, if any.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; private set; }



        /// <summary>
        /// The external contact of the end-user participant, if any.
        /// </summary>
        /// <value>The external contact of the end-user participant, if any.</value>
        [DataMember(Name="externalContact", EmitDefaultValue=false)]
        public AddressableEntityRef ExternalContact { get; private set; }



        /// <summary>
        /// The utterance in the voice conversation, after which the suggestion was raised, if any.
        /// </summary>
        /// <value>The utterance in the voice conversation, after which the suggestion was raised, if any.</value>
        [DataMember(Name="utterance", EmitDefaultValue=false)]
        public Entity Utterance { get; private set; }



        /// <summary>
        /// The message in the digital conversation, after which the suggestion was raised, if any.
        /// </summary>
        /// <value>The message in the digital conversation, after which the suggestion was raised, if any.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public AddressableEntityRef Message { get; private set; }



        /// <summary>
        /// The query statement used when generating the suggestion, if any.
        /// </summary>
        /// <value>The query statement used when generating the suggestion, if any.</value>
        [DataMember(Name="queryStatement", EmitDefaultValue=false)]
        public string QueryStatement { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestionContext {\n");

            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
            sb.Append("  Utterance: ").Append(Utterance).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  QueryStatement: ").Append(QueryStatement).Append("\n");
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
            return this.Equals(obj as SuggestionContext);
        }

        /// <summary>
        /// Returns true if SuggestionContext instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestionContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestionContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ExternalContact == other.ExternalContact ||
                    this.ExternalContact != null &&
                    this.ExternalContact.Equals(other.ExternalContact)
                ) &&
                (
                    this.Utterance == other.Utterance ||
                    this.Utterance != null &&
                    this.Utterance.Equals(other.Utterance)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.QueryStatement == other.QueryStatement ||
                    this.QueryStatement != null &&
                    this.QueryStatement.Equals(other.QueryStatement)
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
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.ExternalContact != null)
                    hash = hash * 59 + this.ExternalContact.GetHashCode();

                if (this.Utterance != null)
                    hash = hash * 59 + this.Utterance.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.QueryStatement != null)
                    hash = hash * 59 + this.QueryStatement.GetHashCode();

                return hash;
            }
        }
    }

}
