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
    /// A card action that a user can take.
    /// </summary>
    [DataContract]
    public partial class CardAction :  IEquatable<CardAction>
    {
        
        
        /// <summary>
        /// Describes the type of action.
        /// </summary>
        /// <value>Describes the type of action.</value>
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
            /// Enum Link for "Link"
            /// </summary>
            [EnumMember(Value = "Link")]
            Link,
            
            /// <summary>
            /// Enum Postback for "Postback"
            /// </summary>
            [EnumMember(Value = "Postback")]
            Postback
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Describes the type of action.
        /// </summary>
        /// <value>Describes the type of action.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CardAction" /> class.
        /// </summary>
        /// <param name="Type">Describes the type of action..</param>
        /// <param name="Text">The response text from the button click..</param>
        /// <param name="Payload">Content of the textback payload after clicking a button..</param>
        /// <param name="Url">The location of the image file associated with action..</param>
        /// <param name="IsSelected">Indicates if the card option is selected by end customer..</param>
        public CardAction(TypeEnum? Type = null, string Text = null, string Payload = null, string Url = null, bool? IsSelected = null)
        {
            this.Type = Type;
            this.Text = Text;
            this.Payload = Payload;
            this.Url = Url;
            this.IsSelected = IsSelected;
            
        }
        
        
        
        
        
        /// <summary>
        /// The response text from the button click.
        /// </summary>
        /// <value>The response text from the button click.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Content of the textback payload after clicking a button.
        /// </summary>
        /// <value>Content of the textback payload after clicking a button.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
        
        
        
        /// <summary>
        /// The location of the image file associated with action.
        /// </summary>
        /// <value>The location of the image file associated with action.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        
        
        
        /// <summary>
        /// Indicates if the card option is selected by end customer.
        /// </summary>
        /// <value>Indicates if the card option is selected by end customer.</value>
        [DataMember(Name="isSelected", EmitDefaultValue=false)]
        public bool? IsSelected { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardAction {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as CardAction);
        }

        /// <summary>
        /// Returns true if CardAction instances are equal
        /// </summary>
        /// <param name="other">Instance of CardAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardAction other)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.IsSelected != null)
                    hash = hash * 59 + this.IsSelected.GetHashCode();
                
                return hash;
            }
        }
    }

}
