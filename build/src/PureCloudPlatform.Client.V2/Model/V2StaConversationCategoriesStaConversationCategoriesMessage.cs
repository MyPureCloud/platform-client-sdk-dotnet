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
    /// V2StaConversationCategoriesStaConversationCategoriesMessage
    /// </summary>
    [DataContract]
    public partial class V2StaConversationCategoriesStaConversationCategoriesMessage :  IEquatable<V2StaConversationCategoriesStaConversationCategoriesMessage>
    {
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
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
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Call for "call"
            /// </summary>
            [EnumMember(Value = "call")]
            Call,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message
        }
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2StaConversationCategoriesStaConversationCategoriesMessage" /> class.
        /// </summary>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="TranscriptIds">TranscriptIds.</param>
        /// <param name="CategoryIds">CategoryIds.</param>
        public V2StaConversationCategoriesStaConversationCategoriesMessage(string OrganizationId = null, Guid? ConversationId = null, MediaTypeEnum? MediaType = null, List<string> TranscriptIds = null, List<Guid?> CategoryIds = null)
        {
            this.OrganizationId = OrganizationId;
            this.ConversationId = ConversationId;
            this.MediaType = MediaType;
            this.TranscriptIds = TranscriptIds;
            this.CategoryIds = CategoryIds;
            
        }
        


        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public Guid? ConversationId { get; set; }





        /// <summary>
        /// Gets or Sets TranscriptIds
        /// </summary>
        [DataMember(Name="transcriptIds", EmitDefaultValue=false)]
        public List<string> TranscriptIds { get; set; }



        /// <summary>
        /// Gets or Sets CategoryIds
        /// </summary>
        [DataMember(Name="categoryIds", EmitDefaultValue=false)]
        public List<Guid?> CategoryIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2StaConversationCategoriesStaConversationCategoriesMessage {\n");

            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  TranscriptIds: ").Append(TranscriptIds).Append("\n");
            sb.Append("  CategoryIds: ").Append(CategoryIds).Append("\n");
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
            return this.Equals(obj as V2StaConversationCategoriesStaConversationCategoriesMessage);
        }

        /// <summary>
        /// Returns true if V2StaConversationCategoriesStaConversationCategoriesMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of V2StaConversationCategoriesStaConversationCategoriesMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2StaConversationCategoriesStaConversationCategoriesMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.TranscriptIds == other.TranscriptIds ||
                    this.TranscriptIds != null &&
                    this.TranscriptIds.SequenceEqual(other.TranscriptIds)
                ) &&
                (
                    this.CategoryIds == other.CategoryIds ||
                    this.CategoryIds != null &&
                    this.CategoryIds.SequenceEqual(other.CategoryIds)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();

                if (this.TranscriptIds != null)
                    hash = hash * 59 + this.TranscriptIds.GetHashCode();

                if (this.CategoryIds != null)
                    hash = hash * 59 + this.CategoryIds.GetHashCode();

                return hash;
            }
        }
    }

}
