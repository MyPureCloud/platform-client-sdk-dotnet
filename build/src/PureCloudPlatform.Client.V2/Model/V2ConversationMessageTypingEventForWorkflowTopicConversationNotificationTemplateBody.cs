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
    /// V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody :  IEquatable<V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody" /> class.
        /// </summary>
        /// <param name="Text">Text.</param>
        /// <param name="Parameters">Parameters.</param>
        public V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody(string Text = null, List<V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateParameter> Parameters = null)
        {
            this.Text = Text;
            this.Parameters = Parameters;
            
        }
        


        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



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
            sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicConversationNotificationTemplateBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                return hash;
            }
        }
    }

}
