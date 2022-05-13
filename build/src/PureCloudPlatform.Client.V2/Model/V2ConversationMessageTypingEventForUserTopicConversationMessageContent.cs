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
    /// V2ConversationMessageTypingEventForUserTopicConversationMessageContent
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForUserTopicConversationMessageContent :  IEquatable<V2ConversationMessageTypingEventForUserTopicConversationMessageContent>
    {
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Attachment for "Attachment"
            /// </summary>
            [EnumMember(Value = "Attachment")]
            Attachment,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Story for "Story"
            /// </summary>
            [EnumMember(Value = "Story")]
            Story,
            
            /// <summary>
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply,
            
            /// <summary>
            /// Enum Notification for "Notification"
            /// </summary>
            [EnumMember(Value = "Notification")]
            Notification,
            
            /// <summary>
            /// Enum Buttonresponse for "ButtonResponse"
            /// </summary>
            [EnumMember(Value = "ButtonResponse")]
            Buttonresponse,
            
            /// <summary>
            /// Enum Generictemplate for "GenericTemplate"
            /// </summary>
            [EnumMember(Value = "GenericTemplate")]
            Generictemplate
        }
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForUserTopicConversationMessageContent" /> class.
        /// </summary>
        /// <param name="ContentType">ContentType.</param>
        /// <param name="Location">Location.</param>
        /// <param name="Story">Story.</param>
        /// <param name="Attachment">Attachment.</param>
        /// <param name="QuickReply">QuickReply.</param>
        /// <param name="Template">Template.</param>
        /// <param name="ButtonResponse">ButtonResponse.</param>
        /// <param name="Generic">Generic.</param>
        public V2ConversationMessageTypingEventForUserTopicConversationMessageContent(ContentTypeEnum? ContentType = null, V2ConversationMessageTypingEventForUserTopicConversationContentLocation Location = null, V2ConversationMessageTypingEventForUserTopicConversationContentStory Story = null, V2ConversationMessageTypingEventForUserTopicConversationContentAttachment Attachment = null, V2ConversationMessageTypingEventForUserTopicConversationContentQuickReply QuickReply = null, V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate Template = null, V2ConversationMessageTypingEventForUserTopicConversationContentButtonResponse ButtonResponse = null, V2ConversationMessageTypingEventForUserTopicConversationContentGeneric Generic = null)
        {
            this.ContentType = ContentType;
            this.Location = Location;
            this.Story = Story;
            this.Attachment = Attachment;
            this.QuickReply = QuickReply;
            this.Template = Template;
            this.ButtonResponse = ButtonResponse;
            this.Generic = Generic;
            
        }
        




        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationContentLocation Location { get; set; }



        /// <summary>
        /// Gets or Sets Story
        /// </summary>
        [DataMember(Name="story", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationContentStory Story { get; set; }



        /// <summary>
        /// Gets or Sets Attachment
        /// </summary>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationContentAttachment Attachment { get; set; }



        /// <summary>
        /// Gets or Sets QuickReply
        /// </summary>
        [DataMember(Name="quickReply", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationContentQuickReply QuickReply { get; set; }



        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationContentNotificationTemplate Template { get; set; }



        /// <summary>
        /// Gets or Sets ButtonResponse
        /// </summary>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationContentButtonResponse ButtonResponse { get; set; }



        /// <summary>
        /// Gets or Sets Generic
        /// </summary>
        [DataMember(Name="generic", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForUserTopicConversationContentGeneric Generic { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForUserTopicConversationMessageContent {\n");

            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Story: ").Append(Story).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForUserTopicConversationMessageContent);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForUserTopicConversationMessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForUserTopicConversationMessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForUserTopicConversationMessageContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.Story == other.Story ||
                    this.Story != null &&
                    this.Story.Equals(other.Story)
                ) &&
                (
                    this.Attachment == other.Attachment ||
                    this.Attachment != null &&
                    this.Attachment.Equals(other.Attachment)
                ) &&
                (
                    this.QuickReply == other.QuickReply ||
                    this.QuickReply != null &&
                    this.QuickReply.Equals(other.QuickReply)
                ) &&
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) &&
                (
                    this.ButtonResponse == other.ButtonResponse ||
                    this.ButtonResponse != null &&
                    this.ButtonResponse.Equals(other.ButtonResponse)
                ) &&
                (
                    this.Generic == other.Generic ||
                    this.Generic != null &&
                    this.Generic.Equals(other.Generic)
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
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.Story != null)
                    hash = hash * 59 + this.Story.GetHashCode();

                if (this.Attachment != null)
                    hash = hash * 59 + this.Attachment.GetHashCode();

                if (this.QuickReply != null)
                    hash = hash * 59 + this.QuickReply.GetHashCode();

                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();

                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();

                if (this.Generic != null)
                    hash = hash * 59 + this.Generic.GetHashCode();

                return hash;
            }
        }
    }

}
