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
    /// RichMedia Input to the bot.
    /// </summary>
    [DataContract]
    public partial class TextBotsRichMediaInputEvent :  IEquatable<TextBotsRichMediaInputEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotsRichMediaInputEvent" /> class.
        /// </summary>
        /// <param name="Inputs">The Rich Media content inputs..</param>
        /// <param name="Messages">The Rich Media message events..</param>
        public TextBotsRichMediaInputEvent(List<ConversationMessageContent> Inputs = null, List<ConversationMessageEvent> Messages = null)
        {
            this.Inputs = Inputs;
            this.Messages = Messages;
            
        }
        


        /// <summary>
        /// The Rich Media content inputs.
        /// </summary>
        /// <value>The Rich Media content inputs.</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<ConversationMessageContent> Inputs { get; set; }



        /// <summary>
        /// The Rich Media message events.
        /// </summary>
        /// <value>The Rich Media message events.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<ConversationMessageEvent> Messages { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotsRichMediaInputEvent {\n");

            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
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
            return this.Equals(obj as TextBotsRichMediaInputEvent);
        }

        /// <summary>
        /// Returns true if TextBotsRichMediaInputEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotsRichMediaInputEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotsRichMediaInputEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Inputs == other.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(other.Inputs)
                ) &&
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
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
                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();

                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();

                return hash;
            }
        }
    }

}
