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
    /// MessageMediaData
    /// </summary>
    [DataContract]
    public partial class MessageMediaData :  IEquatable<MessageMediaData>
    {
        /// <summary>
        /// The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid
        /// </summary>
        /// <value>The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Uploading for "uploading"
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading,
            
            /// <summary>
            /// Enum Valid for "valid"
            /// </summary>
            [EnumMember(Value = "valid")]
            Valid,
            
            /// <summary>
            /// Enum Invalid for "invalid"
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid
        }
        /// <summary>
        /// The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid
        /// </summary>
        /// <value>The status of the media, indicates if the media is in the process of uploading. If the upload fails, the media becomes invalid</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMediaData" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Url">The location of the media, useful for retrieving it.</param>
        /// <param name="MediaType">The detected internet media type of the the media object.  If null then the media type should be dictated by the url..</param>
        /// <param name="ContentLengthBytes">The optional content length of the the media object, in bytes..</param>
        /// <param name="UploadUrl">The URL returned to upload an attachment.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="CommunicationId">CommunicationId.</param>
        public MessageMediaData(string Name = null, string Url = null, string MediaType = null, int? ContentLengthBytes = null, string UploadUrl = null, string ConversationId = null, string CommunicationId = null)
        {
            this.Name = Name;
            this.Url = Url;
            this.MediaType = MediaType;
            this.ContentLengthBytes = ContentLengthBytes;
            this.UploadUrl = UploadUrl;
            this.ConversationId = ConversationId;
            this.CommunicationId = CommunicationId;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The location of the media, useful for retrieving it
        /// </summary>
        /// <value>The location of the media, useful for retrieving it</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// The detected internet media type of the the media object.  If null then the media type should be dictated by the url.
        /// </summary>
        /// <value>The detected internet media type of the the media object.  If null then the media type should be dictated by the url.</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public string MediaType { get; set; }



        /// <summary>
        /// The optional content length of the the media object, in bytes.
        /// </summary>
        /// <value>The optional content length of the the media object, in bytes.</value>
        [DataMember(Name="contentLengthBytes", EmitDefaultValue=false)]
        public int? ContentLengthBytes { get; set; }



        /// <summary>
        /// The URL returned to upload an attachment
        /// </summary>
        /// <value>The URL returned to upload an attachment</value>
        [DataMember(Name="uploadUrl", EmitDefaultValue=false)]
        public string UploadUrl { get; set; }





        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }



        /// <summary>
        /// Gets or Sets CommunicationId
        /// </summary>
        [DataMember(Name="communicationId", EmitDefaultValue=false)]
        public string CommunicationId { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageMediaData {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  ContentLengthBytes: ").Append(ContentLengthBytes).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as MessageMediaData);
        }

        /// <summary>
        /// Returns true if MessageMediaData instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageMediaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageMediaData other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.ContentLengthBytes == other.ContentLengthBytes ||
                    this.ContentLengthBytes != null &&
                    this.ContentLengthBytes.Equals(other.ContentLengthBytes)
                ) &&
                (
                    this.UploadUrl == other.UploadUrl ||
                    this.UploadUrl != null &&
                    this.UploadUrl.Equals(other.UploadUrl)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.CommunicationId == other.CommunicationId ||
                    this.CommunicationId != null &&
                    this.CommunicationId.Equals(other.CommunicationId)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.ContentLengthBytes != null)
                    hash = hash * 59 + this.ContentLengthBytes.GetHashCode();

                if (this.UploadUrl != null)
                    hash = hash * 59 + this.UploadUrl.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.CommunicationId != null)
                    hash = hash * 59 + this.CommunicationId.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
