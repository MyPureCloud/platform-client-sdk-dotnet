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
    /// IgnoreTopic
    /// </summary>
    [DataContract]
    public partial class IgnoreTopic :  IEquatable<IgnoreTopic>
    {
        /// <summary>
        /// Type of participant
        /// </summary>
        /// <value>Type of participant</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ParticipantEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer,
            
            /// <summary>
            /// Enum Agent for "Agent"
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent,
            
            /// <summary>
            /// Enum Both for "Both"
            /// </summary>
            [EnumMember(Value = "Both")]
            Both
        }
        /// <summary>
        /// Media Type for the entity (Optional)
        /// </summary>
        /// <value>Media Type for the entity (Optional)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email
        }
        /// <summary>
        /// Type of participant
        /// </summary>
        /// <value>Type of participant</value>
        [DataMember(Name="participant", EmitDefaultValue=false)]
        public ParticipantEnum? Participant { get; set; }
        /// <summary>
        /// Media Type for the entity (Optional)
        /// </summary>
        /// <value>Media Type for the entity (Optional)</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IgnoreTopic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IgnoreTopic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IgnoreTopic" /> class.
        /// </summary>
        /// <param name="Text">Text of the topic to be ignored (required).</param>
        /// <param name="Participant">Type of participant (required).</param>
        /// <param name="MediaType">Media Type for the entity (Optional).</param>
        public IgnoreTopic(string Text = null, ParticipantEnum? Participant = null, MediaTypeEnum? MediaType = null)
        {
            this.Text = Text;
            this.Participant = Participant;
            this.MediaType = MediaType;
            
        }
        


        /// <summary>
        /// Text of the topic to be ignored
        /// </summary>
        /// <value>Text of the topic to be ignored</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IgnoreTopic {\n");

            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Participant: ").Append(Participant).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
            return this.Equals(obj as IgnoreTopic);
        }

        /// <summary>
        /// Returns true if IgnoreTopic instances are equal
        /// </summary>
        /// <param name="other">Instance of IgnoreTopic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IgnoreTopic other)
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
                    this.Participant == other.Participant ||
                    this.Participant != null &&
                    this.Participant.Equals(other.Participant)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
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

                if (this.Participant != null)
                    hash = hash * 59 + this.Participant.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                return hash;
            }
        }
    }

}
