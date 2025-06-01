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
    /// Channel-specific information that describes the message and the message channel/provider.
    /// </summary>
    [DataContract]
    public partial class OpenSocialMediaChannel :  IEquatable<OpenSocialMediaChannel>
    {
        /// <summary>
        /// The provider type.
        /// </summary>
        /// <value>The provider type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open
        }
        /// <summary>
        /// Specifies if this message is part of a private or public conversation.
        /// </summary>
        /// <value>Specifies if this message is part of a private or public conversation.</value>
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
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public
        }
        /// <summary>
        /// The provider type.
        /// </summary>
        /// <value>The provider type.</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum? Platform { get; private set; }
        /// <summary>
        /// Specifies if this message is part of a private or public conversation.
        /// </summary>
        /// <value>Specifies if this message is part of a private or public conversation.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSocialMediaChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenSocialMediaChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSocialMediaChannel" /> class.
        /// </summary>
        /// <param name="MessageId">Unique provider ID of the message such as a Facebook message ID. (required).</param>
        /// <param name="To">Information about the recipient the message is sent to..</param>
        /// <param name="From">Information about the recipient the message is received from. (required).</param>
        /// <param name="Time">Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="Metadata">Information about the channel..</param>
        /// <param name="PublicMetadata">Meta data of this public post. For example, used to define where in the thread the post exists. (required).</param>
        public OpenSocialMediaChannel(string MessageId = null, OpenSocialMediaRecipient To = null, OpenSocialMediaRecipient From = null, DateTime? Time = null, Object Metadata = null, OpenSocialMediaPublicMetadata PublicMetadata = null)
        {
            this.MessageId = MessageId;
            this.To = To;
            this.From = From;
            this.Time = Time;
            this.Metadata = Metadata;
            this.PublicMetadata = PublicMetadata;
            
        }
        


        /// <summary>
        /// The topic ID.
        /// </summary>
        /// <value>The topic ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }







        /// <summary>
        /// Unique provider ID of the message such as a Facebook message ID.
        /// </summary>
        /// <value>Unique provider ID of the message such as a Facebook message ID.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }



        /// <summary>
        /// Information about the recipient the message is sent to.
        /// </summary>
        /// <value>Information about the recipient the message is sent to.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public OpenSocialMediaRecipient To { get; set; }



        /// <summary>
        /// Information about the recipient the message is received from.
        /// </summary>
        /// <value>Information about the recipient the message is received from.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public OpenSocialMediaRecipient From { get; set; }



        /// <summary>
        /// Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Original time of the event. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }



        /// <summary>
        /// Information about the channel.
        /// </summary>
        /// <value>Information about the channel.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }



        /// <summary>
        /// Meta data of this public post. For example, used to define where in the thread the post exists.
        /// </summary>
        /// <value>Meta data of this public post. For example, used to define where in the thread the post exists.</value>
        [DataMember(Name="publicMetadata", EmitDefaultValue=false)]
        public OpenSocialMediaPublicMetadata PublicMetadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenSocialMediaChannel {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PublicMetadata: ").Append(PublicMetadata).Append("\n");
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
            return this.Equals(obj as OpenSocialMediaChannel);
        }

        /// <summary>
        /// Returns true if OpenSocialMediaChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenSocialMediaChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenSocialMediaChannel other)
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
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) &&
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) &&
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) &&
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) &&
                (
                    this.PublicMetadata == other.PublicMetadata ||
                    this.PublicMetadata != null &&
                    this.PublicMetadata.Equals(other.PublicMetadata)
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

                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();

                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();

                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();

                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.PublicMetadata != null)
                    hash = hash * 59 + this.PublicMetadata.GetHashCode();

                return hash;
            }
        }
    }

}
