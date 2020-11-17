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
    /// The postback object result of a user clicking in a button
    /// </summary>
    [DataContract]
    public partial class ContentPostback :  IEquatable<ContentPostback>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPostback" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentPostback() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPostback" /> class.
        /// </summary>
        /// <param name="Id">An ID assigned to the postback reply. Each object inside the content array has a unique ID..</param>
        /// <param name="Text">The text inside the button clicked (in the structured message template).</param>
        /// <param name="Payload">Content of the textback payload after clicking a quick reply (required).</param>
        public ContentPostback(string Id = null, string Text = null, string Payload = null)
        {
            this.Id = Id;
            this.Text = Text;
            this.Payload = Payload;
            
        }
        
        
        
        /// <summary>
        /// An ID assigned to the postback reply. Each object inside the content array has a unique ID.
        /// </summary>
        /// <value>An ID assigned to the postback reply. Each object inside the content array has a unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The text inside the button clicked (in the structured message template)
        /// </summary>
        /// <value>The text inside the button clicked (in the structured message template)</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Content of the textback payload after clicking a quick reply
        /// </summary>
        /// <value>Content of the textback payload after clicking a quick reply</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentPostback {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as ContentPostback);
        }

        /// <summary>
        /// Returns true if ContentPostback instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentPostback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentPostback other)
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
                
                return hash;
            }
        }
    }

}
