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
    /// V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation
    /// </summary>
    [DataContract]
    public partial class V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation :  IEquatable<V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation" /> class.
        /// </summary>
        /// <param name="Url">Url.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Latitude">Latitude.</param>
        /// <param name="Longitude">Longitude.</param>
        public V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation(string Url = null, string Address = null, string Text = null, double? Latitude = null, double? Longitude = null)
        {
            this.Url = Url;
            this.Address = Address;
            this.Text = Text;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            
        }
        


        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }



        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation);
        }

        /// <summary>
        /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicConversationContentLocation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) &&
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();

                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();

                return hash;
            }
        }
    }

}
