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
    /// Message content element.
    /// </summary>
    [DataContract]
    public partial class ConversationMessageContent :  IEquatable<ConversationMessageContent>
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
            Buttonresponse
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
        /// </summary>
        /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationMessageContent() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessageContent" /> class.
        /// </summary>
        /// <param name="ContentType">Type of this content element. If contentType = \&quot;Attachment\&quot; only one item is allowed. (required).</param>
        /// <param name="Attachment">Attachment content..</param>
        /// <param name="QuickReply">Quick reply content..</param>
        /// <param name="Template">Template notification content..</param>
        /// <param name="ButtonResponse">Button response content..</param>
        public ConversationMessageContent(ContentTypeEnum? ContentType = null, ConversationContentAttachment Attachment = null, ConversationContentQuickReply QuickReply = null, ConversationContentNotificationTemplate Template = null, ConversationContentButtonResponse ButtonResponse = null)
        {
            this.ContentType = ContentType;
            this.Attachment = Attachment;
            this.QuickReply = QuickReply;
            this.Template = Template;
            this.ButtonResponse = ButtonResponse;
            
        }
        
        
        
        
        
        /// <summary>
        /// Attachment content.
        /// </summary>
        /// <value>Attachment content.</value>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public ConversationContentAttachment Attachment { get; set; }
        
        
        
        /// <summary>
        /// Quick reply content.
        /// </summary>
        /// <value>Quick reply content.</value>
        [DataMember(Name="quickReply", EmitDefaultValue=false)]
        public ConversationContentQuickReply QuickReply { get; set; }
        
        
        
        /// <summary>
        /// Template notification content.
        /// </summary>
        /// <value>Template notification content.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public ConversationContentNotificationTemplate Template { get; set; }
        
        
        
        /// <summary>
        /// Button response content.
        /// </summary>
        /// <value>Button response content.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ConversationContentButtonResponse ButtonResponse { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationMessageContent {\n");
            
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
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
            return this.Equals(obj as ConversationMessageContent);
        }

        /// <summary>
        /// Returns true if ConversationMessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationMessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationMessageContent other)
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
                
                if (this.Attachment != null)
                    hash = hash * 59 + this.Attachment.GetHashCode();
                
                if (this.QuickReply != null)
                    hash = hash * 59 + this.QuickReply.GetHashCode();
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();
                
                return hash;
            }
        }
    }

}
