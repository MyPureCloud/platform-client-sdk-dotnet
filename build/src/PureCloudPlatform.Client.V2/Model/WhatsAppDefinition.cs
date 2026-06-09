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
    /// A WhatsApp messaging template definition as defined in the WhatsApp Business Manager
    /// </summary>
    [DataContract]
    public partial class WhatsAppDefinition :  IEquatable<WhatsAppDefinition>
    {
        /// <summary>
        /// Category of whatsApp carousels template.
        /// </summary>
        /// <value>Category of whatsApp carousels template.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Marketing for "marketing"
            /// </summary>
            [EnumMember(Value = "marketing")]
            Marketing
        }
        /// <summary>
        /// Category of whatsApp carousels template.
        /// </summary>
        /// <value>Category of whatsApp carousels template.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppDefinition" /> class.
        /// </summary>
        /// <param name="Name">The messaging template name. (required).</param>
        /// <param name="Namespace">The messaging template namespace..</param>
        /// <param name="Language">The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39; (required).</param>
        /// <param name="Buttons">List of buttons to be included in the standard WhatsApp messages channel.</param>
        /// <param name="MessageFooter">Footer for the message in the standard WhatsApp messages channel.</param>
        /// <param name="Header">Header for the message in the standard WhatsApp messages channel.</param>
        /// <param name="IntegrationId">WhatsApp integration ID for whatsApp carousels.</param>
        /// <param name="Category">Category of whatsApp carousels template..</param>
        /// <param name="Carousel">Definition for whatsApp carousels template..</param>
        public WhatsAppDefinition(string Name = null, string Namespace = null, string Language = null, List<Button> Buttons = null, MessageFooter MessageFooter = null, MessageHeader Header = null, string IntegrationId = null, CategoryEnum? Category = null, Carousel Carousel = null)
        {
            this.Name = Name;
            this.Namespace = Namespace;
            this.Language = Language;
            this.Buttons = Buttons;
            this.MessageFooter = MessageFooter;
            this.Header = Header;
            this.IntegrationId = IntegrationId;
            this.Category = Category;
            this.Carousel = Carousel;
            
        }
        


        /// <summary>
        /// The messaging template name.
        /// </summary>
        /// <value>The messaging template name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The messaging template namespace.
        /// </summary>
        /// <value>The messaging template namespace.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }



        /// <summary>
        /// The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39;
        /// </summary>
        /// <value>The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39;</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// List of buttons to be included in the standard WhatsApp messages channel
        /// </summary>
        /// <value>List of buttons to be included in the standard WhatsApp messages channel</value>
        [DataMember(Name="buttons", EmitDefaultValue=false)]
        public List<Button> Buttons { get; set; }



        /// <summary>
        /// Footer for the message in the standard WhatsApp messages channel
        /// </summary>
        /// <value>Footer for the message in the standard WhatsApp messages channel</value>
        [DataMember(Name="messageFooter", EmitDefaultValue=false)]
        public MessageFooter MessageFooter { get; set; }



        /// <summary>
        /// Header for the message in the standard WhatsApp messages channel
        /// </summary>
        /// <value>Header for the message in the standard WhatsApp messages channel</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public MessageHeader Header { get; set; }



        /// <summary>
        /// WhatsApp integration ID for whatsApp carousels
        /// </summary>
        /// <value>WhatsApp integration ID for whatsApp carousels</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }





        /// <summary>
        /// Template status of whatsApp carousels template.
        /// </summary>
        /// <value>Template status of whatsApp carousels template.</value>
        [DataMember(Name="templateStatus", EmitDefaultValue=false)]
        public string TemplateStatus { get; private set; }



        /// <summary>
        /// Status information about the template
        /// </summary>
        /// <value>Status information about the template</value>
        [DataMember(Name="statusInfo", EmitDefaultValue=false)]
        public StatusInfo StatusInfo { get; private set; }



        /// <summary>
        /// Definition for whatsApp carousels template.
        /// </summary>
        /// <value>Definition for whatsApp carousels template.</value>
        [DataMember(Name="carousel", EmitDefaultValue=false)]
        public Carousel Carousel { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppDefinition {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Buttons: ").Append(Buttons).Append("\n");
            sb.Append("  MessageFooter: ").Append(MessageFooter).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  TemplateStatus: ").Append(TemplateStatus).Append("\n");
            sb.Append("  StatusInfo: ").Append(StatusInfo).Append("\n");
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
            return this.Equals(obj as WhatsAppDefinition);
        }

        /// <summary>
        /// Returns true if WhatsAppDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Namespace == other.Namespace ||
                    this.Namespace != null &&
                    this.Namespace.Equals(other.Namespace)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Buttons == other.Buttons ||
                    this.Buttons != null &&
                    this.Buttons.SequenceEqual(other.Buttons)
                ) &&
                (
                    this.MessageFooter == other.MessageFooter ||
                    this.MessageFooter != null &&
                    this.MessageFooter.Equals(other.MessageFooter)
                ) &&
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.Equals(other.Header)
                ) &&
                (
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.TemplateStatus == other.TemplateStatus ||
                    this.TemplateStatus != null &&
                    this.TemplateStatus.Equals(other.TemplateStatus)
                ) &&
                (
                    this.StatusInfo == other.StatusInfo ||
                    this.StatusInfo != null &&
                    this.StatusInfo.Equals(other.StatusInfo)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Namespace != null)
                    hash = hash * 59 + this.Namespace.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Buttons != null)
                    hash = hash * 59 + this.Buttons.GetHashCode();

                if (this.MessageFooter != null)
                    hash = hash * 59 + this.MessageFooter.GetHashCode();

                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.TemplateStatus != null)
                    hash = hash * 59 + this.TemplateStatus.GetHashCode();

                if (this.StatusInfo != null)
                    hash = hash * 59 + this.StatusInfo.GetHashCode();

                if (this.Carousel != null)
                    hash = hash * 59 + this.Carousel.GetHashCode();

                return hash;
            }
        }
    }

}
