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
    /// Quick reply object
    /// </summary>
    [DataContract]
    public partial class ContentQuickReply :  IEquatable<ContentQuickReply>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.
        /// </summary>
        /// <value>Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
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
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.
        /// </summary>
        /// <value>Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentQuickReply" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentQuickReply() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentQuickReply" /> class.
        /// </summary>
        /// <param name="Id">An ID assigned to the quick reply. Each object inside the content array has a unique ID..</param>
        /// <param name="Text">Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply. (required).</param>
        /// <param name="Image">Image associated with quick reply.</param>
        /// <param name="Action">Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \&quot;Message\&quot; which sends a message using the quick reply text..</param>
        /// <param name="Payload">Payload content for the quick reply..</param>
        public ContentQuickReply(string Id = null, string Text = null, string Image = null, ActionEnum? Action = null, string Payload = null)
        {
            this.Id = Id;
            this.Text = Text;
            this.Image = Image;
            this.Action = Action;
            this.Payload = Payload;
            
        }
        
        
        
        /// <summary>
        /// An ID assigned to the quick reply. Each object inside the content array has a unique ID.
        /// </summary>
        /// <value>An ID assigned to the quick reply. Each object inside the content array has a unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.
        /// </summary>
        /// <value>Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Image associated with quick reply
        /// </summary>
        /// <value>Image associated with quick reply</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        
        
        
        
        
        /// <summary>
        /// Payload content for the quick reply.
        /// </summary>
        /// <value>Payload content for the quick reply.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentQuickReply {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(obj as ContentQuickReply);
        }

        /// <summary>
        /// Returns true if ContentQuickReply instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentQuickReply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentQuickReply other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
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
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                
                return hash;
            }
        }
    }

}
