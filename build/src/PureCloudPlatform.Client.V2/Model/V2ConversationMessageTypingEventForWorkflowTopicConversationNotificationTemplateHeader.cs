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
    /// V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader :  IEquatable<V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Media for "Media"
            /// </summary>
            [EnumMember(Value = "Media")]
            Media
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Media">Media.</param>
        /// <param name="Parameters">Parameters.</param>
        public V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader(TypeEnum? Type = null, string Text = null, V2ConversationMessageTypingEventForWorkflowTopicConversationContentAttachment Media = null, List<V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateParameter> Parameters = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Media = Media;
            this.Parameters = Parameters;
            
        }
        




        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public V2ConversationMessageTypingEventForWorkflowTopicConversationContentAttachment Media { get; set; }



        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateParameter> Parameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateHeader other)
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
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
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

                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                return hash;
            }
        }
    }

}
