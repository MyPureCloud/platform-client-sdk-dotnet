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
    /// QuickReply
    /// </summary>
    [DataContract]
    public partial class QuickReply :  IEquatable<QuickReply>
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
        /// Initializes a new instance of the <see cref="QuickReply" /> class.
        /// </summary>
        /// <param name="Id">An ID assigned to the quick reply..</param>
        /// <param name="Text">Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply..</param>
        /// <param name="Payload">Content of the textback payload after clicking a quick reply.</param>
        /// <param name="Url">The location of the image file associated with quick reply.</param>
        /// <param name="Action">Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \&quot;Message\&quot; which sends a message using the quick reply text..</param>
        /// <param name="IsSelected">Indicates if the quick reply option is selected by end customer.</param>
        public QuickReply(string Id = null, string Text = null, string Payload = null, string Url = null, ActionEnum? Action = null, bool? IsSelected = null)
        {
            this.Id = Id;
            this.Text = Text;
            this.Payload = Payload;
            this.Url = Url;
            this.Action = Action;
            this.IsSelected = IsSelected;
            
        }
        
        
        
        /// <summary>
        /// An ID assigned to the quick reply.
        /// </summary>
        /// <value>An ID assigned to the quick reply.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.
        /// </summary>
        /// <value>Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Content of the textback payload after clicking a quick reply
        /// </summary>
        /// <value>Content of the textback payload after clicking a quick reply</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
        
        
        
        /// <summary>
        /// The location of the image file associated with quick reply
        /// </summary>
        /// <value>The location of the image file associated with quick reply</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        
        
        /// <summary>
        /// Indicates if the quick reply option is selected by end customer
        /// </summary>
        /// <value>Indicates if the quick reply option is selected by end customer</value>
        [DataMember(Name="isSelected", EmitDefaultValue=false)]
        public bool? IsSelected { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickReply {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
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
            return this.Equals(obj as QuickReply);
        }

        /// <summary>
        /// Returns true if QuickReply instances are equal
        /// </summary>
        /// <param name="other">Instance of QuickReply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickReply other)
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
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.IsSelected == other.IsSelected ||
                    this.IsSelected != null &&
                    this.IsSelected.Equals(other.IsSelected)
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
                
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.IsSelected != null)
                    hash = hash * 59 + this.IsSelected.GetHashCode();
                
                return hash;
            }
        }
    }

}
