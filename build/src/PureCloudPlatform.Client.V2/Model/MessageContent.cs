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
    /// Message content element
    /// </summary>
    [DataContract]
    public partial class MessageContent :  IEquatable<MessageContent>
    {
        
        
        /// <summary>
        /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
        /// </summary>
        /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
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
            /// Enum Quickreply for "QuickReply"
            /// </summary>
            [EnumMember(Value = "QuickReply")]
            Quickreply,
            
            /// <summary>
            /// Enum Buttonresponse for "ButtonResponse"
            /// </summary>
            [EnumMember(Value = "ButtonResponse")]
            Buttonresponse,
            
            /// <summary>
            /// Enum Notification for "Notification"
            /// </summary>
            [EnumMember(Value = "Notification")]
            Notification,
            
            /// <summary>
            /// Enum Generictemplate for "GenericTemplate"
            /// </summary>
            [EnumMember(Value = "GenericTemplate")]
            Generictemplate,
            
            /// <summary>
            /// Enum Listtemplate for "ListTemplate"
            /// </summary>
            [EnumMember(Value = "ListTemplate")]
            Listtemplate,
            
            /// <summary>
            /// Enum Postback for "Postback"
            /// </summary>
            [EnumMember(Value = "Postback")]
            Postback,
            
            /// <summary>
            /// Enum Reactions for "Reactions"
            /// </summary>
            [EnumMember(Value = "Reactions")]
            Reactions,
            
            /// <summary>
            /// Enum Mention for "Mention"
            /// </summary>
            [EnumMember(Value = "Mention")]
            Mention
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
        /// </summary>
        /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageContent() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContent" /> class.
        /// </summary>
        /// <param name="ContentType">Type of this content element. If contentType = \&quot;Attachment\&quot; only one item is allowed. (required).</param>
        /// <param name="Location">Location object.</param>
        /// <param name="Attachment">Attachment object.</param>
        /// <param name="QuickReply">Quick reply object.</param>
        /// <param name="ButtonResponse">Button response object.</param>
        /// <param name="Generic">Generic content object.</param>
        /// <param name="List">List content object.</param>
        /// <param name="Template">Template notification object.</param>
        /// <param name="Reactions">A list of reactions.</param>
        /// <param name="Mention">This is used to identify who the message is sent to, as well as who it was sent from. This information is channel specific - depends on capabilities to describe party by the platform.</param>
        /// <param name="Postback">The postback object result of a user clicking in a button.</param>
        public MessageContent(ContentTypeEnum? ContentType = null, ContentLocation Location = null, ContentAttachment Attachment = null, ContentQuickReply QuickReply = null, ContentButtonResponse ButtonResponse = null, ContentGeneric Generic = null, ContentList List = null, ContentNotificationTemplate Template = null, List<ContentReaction> Reactions = null, MessagingRecipient Mention = null, ContentPostback Postback = null)
        {
            this.ContentType = ContentType;
            this.Location = Location;
            this.Attachment = Attachment;
            this.QuickReply = QuickReply;
            this.ButtonResponse = ButtonResponse;
            this.Generic = Generic;
            this.List = List;
            this.Template = Template;
            this.Reactions = Reactions;
            this.Mention = Mention;
            this.Postback = Postback;
            
        }
        
        
        
        
        
        /// <summary>
        /// Location object
        /// </summary>
        /// <value>Location object</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public ContentLocation Location { get; set; }
        
        
        
        /// <summary>
        /// Attachment object
        /// </summary>
        /// <value>Attachment object</value>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public ContentAttachment Attachment { get; set; }
        
        
        
        /// <summary>
        /// Quick reply object
        /// </summary>
        /// <value>Quick reply object</value>
        [DataMember(Name="quickReply", EmitDefaultValue=false)]
        public ContentQuickReply QuickReply { get; set; }
        
        
        
        /// <summary>
        /// Button response object
        /// </summary>
        /// <value>Button response object</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ContentButtonResponse ButtonResponse { get; set; }
        
        
        
        /// <summary>
        /// Generic content object
        /// </summary>
        /// <value>Generic content object</value>
        [DataMember(Name="generic", EmitDefaultValue=false)]
        public ContentGeneric Generic { get; set; }
        
        
        
        /// <summary>
        /// List content object
        /// </summary>
        /// <value>List content object</value>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public ContentList List { get; set; }
        
        
        
        /// <summary>
        /// Template notification object
        /// </summary>
        /// <value>Template notification object</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public ContentNotificationTemplate Template { get; set; }
        
        
        
        /// <summary>
        /// A list of reactions
        /// </summary>
        /// <value>A list of reactions</value>
        [DataMember(Name="reactions", EmitDefaultValue=false)]
        public List<ContentReaction> Reactions { get; set; }
        
        
        
        /// <summary>
        /// This is used to identify who the message is sent to, as well as who it was sent from. This information is channel specific - depends on capabilities to describe party by the platform
        /// </summary>
        /// <value>This is used to identify who the message is sent to, as well as who it was sent from. This information is channel specific - depends on capabilities to describe party by the platform</value>
        [DataMember(Name="mention", EmitDefaultValue=false)]
        public MessagingRecipient Mention { get; set; }
        
        
        
        /// <summary>
        /// The postback object result of a user clicking in a button
        /// </summary>
        /// <value>The postback object result of a user clicking in a button</value>
        [DataMember(Name="postback", EmitDefaultValue=false)]
        public ContentPostback Postback { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageContent {\n");
            
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
            sb.Append("  Mention: ").Append(Mention).Append("\n");
            sb.Append("  Postback: ").Append(Postback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MessageContent);
        }

        /// <summary>
        /// Returns true if MessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageContent other)
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
                    this.ButtonResponse == other.ButtonResponse ||
                    this.ButtonResponse != null &&
                    this.ButtonResponse.Equals(other.ButtonResponse)
                ) &&
                (
                    this.Generic == other.Generic ||
                    this.Generic != null &&
                    this.Generic.Equals(other.Generic)
                ) &&
                (
                    this.List == other.List ||
                    this.List != null &&
                    this.List.Equals(other.List)
                ) &&
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) &&
                (
                    this.Reactions == other.Reactions ||
                    this.Reactions != null &&
                    this.Reactions.SequenceEqual(other.Reactions)
                ) &&
                (
                    this.Mention == other.Mention ||
                    this.Mention != null &&
                    this.Mention.Equals(other.Mention)
                ) &&
                (
                    this.Postback == other.Postback ||
                    this.Postback != null &&
                    this.Postback.Equals(other.Postback)
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
                
                if (this.Attachment != null)
                    hash = hash * 59 + this.Attachment.GetHashCode();
                
                if (this.QuickReply != null)
                    hash = hash * 59 + this.QuickReply.GetHashCode();
                
                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();
                
                if (this.Generic != null)
                    hash = hash * 59 + this.Generic.GetHashCode();
                
                if (this.List != null)
                    hash = hash * 59 + this.List.GetHashCode();
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                if (this.Reactions != null)
                    hash = hash * 59 + this.Reactions.GetHashCode();
                
                if (this.Mention != null)
                    hash = hash * 59 + this.Mention.GetHashCode();
                
                if (this.Postback != null)
                    hash = hash * 59 + this.Postback.GetHashCode();
                
                return hash;
            }
        }
    }

}
