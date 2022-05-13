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
    public partial class WebMessagingContent :  IEquatable<WebMessagingContent>
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
            /// Enum Buttonresponse for "ButtonResponse"
            /// </summary>
            [EnumMember(Value = "ButtonResponse")]
            Buttonresponse,
            
            /// <summary>
            /// Enum Generictemplate for "GenericTemplate"
            /// </summary>
            [EnumMember(Value = "GenericTemplate")]
            Generictemplate,
            
            /// <summary>
            /// Enum Card for "Card"
            /// </summary>
            [EnumMember(Value = "Card")]
            Card,
            
            /// <summary>
            /// Enum Carousel for "Carousel"
            /// </summary>
            [EnumMember(Value = "Carousel")]
            Carousel
        }
        /// <summary>
        /// Type of this content element. If contentType = \"Attachment\" only one item is allowed.
        /// </summary>
        /// <value>Type of this content element. If contentType = \"Attachment\" only one item is allowed.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebMessagingContent" /> class.
        /// </summary>
        /// <param name="QuickReply">Quick reply content..</param>
        /// <param name="ButtonResponse">Button response content..</param>
        /// <param name="Generic">Generic content..</param>
        /// <param name="Card">Card content.</param>
        /// <param name="Carousel">Carousel content.</param>
        public WebMessagingContent(WebMessagingQuickReply QuickReply = null, WebMessagingButtonResponse ButtonResponse = null, WebMessagingGeneric Generic = null, ContentCard Card = null, ContentCarousel Carousel = null)
        {
            this.QuickReply = QuickReply;
            this.ButtonResponse = ButtonResponse;
            this.Generic = Generic;
            this.Card = Card;
            this.Carousel = Carousel;
            
        }
        




        /// <summary>
        /// Attachment content.
        /// </summary>
        /// <value>Attachment content.</value>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public WebMessagingAttachment Attachment { get; private set; }



        /// <summary>
        /// Quick reply content.
        /// </summary>
        /// <value>Quick reply content.</value>
        [DataMember(Name="quickReply", EmitDefaultValue=false)]
        public WebMessagingQuickReply QuickReply { get; set; }



        /// <summary>
        /// Button response content.
        /// </summary>
        /// <value>Button response content.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public WebMessagingButtonResponse ButtonResponse { get; set; }



        /// <summary>
        /// Generic content.
        /// </summary>
        /// <value>Generic content.</value>
        [DataMember(Name="generic", EmitDefaultValue=false)]
        public WebMessagingGeneric Generic { get; set; }



        /// <summary>
        /// Card content
        /// </summary>
        /// <value>Card content</value>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public ContentCard Card { get; set; }



        /// <summary>
        /// Carousel content
        /// </summary>
        /// <value>Carousel content</value>
        [DataMember(Name="carousel", EmitDefaultValue=false)]
        public ContentCarousel Carousel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebMessagingContent {\n");

            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  QuickReply: ").Append(QuickReply).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  Carousel: ").Append(Carousel).Append("\n");
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
            return this.Equals(obj as WebMessagingContent);
        }

        /// <summary>
        /// Returns true if WebMessagingContent instances are equal
        /// </summary>
        /// <param name="other">Instance of WebMessagingContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebMessagingContent other)
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
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) &&
                (
                    this.Carousel == other.Carousel ||
                    this.Carousel != null &&
                    this.Carousel.Equals(other.Carousel)
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

                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();

                if (this.Generic != null)
                    hash = hash * 59 + this.Generic.GetHashCode();

                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();

                if (this.Carousel != null)
                    hash = hash * 59 + this.Carousel.GetHashCode();

                return hash;
            }
        }
    }

}
