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
    /// InternalMessageRequest
    /// </summary>
    [DataContract]
    public partial class InternalMessageRequest :  IEquatable<InternalMessageRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InternalMessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMessageRequest" /> class.
        /// </summary>
        /// <param name="Text">The body of the text message. (required).</param>
        public InternalMessageRequest(string Text = null)
        {
            this.Text = Text;
            
        }
        


        /// <summary>
        /// The body of the text message.
        /// </summary>
        /// <value>The body of the text message.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InternalMessageRequest {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as InternalMessageRequest);
        }

        /// <summary>
        /// Returns true if InternalMessageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of InternalMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalMessageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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

                return hash;
            }
        }
    }

}
