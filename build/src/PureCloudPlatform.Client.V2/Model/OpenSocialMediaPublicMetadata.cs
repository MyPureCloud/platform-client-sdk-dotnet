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
    /// Information about a public message.
    /// </summary>
    [DataContract]
    public partial class OpenSocialMediaPublicMetadata :  IEquatable<OpenSocialMediaPublicMetadata>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSocialMediaPublicMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenSocialMediaPublicMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSocialMediaPublicMetadata" /> class.
        /// </summary>
        /// <param name="RootId">The id of the root public message. (required).</param>
        /// <param name="ReplyToId">The id of the message this public message is replying to..</param>
        /// <param name="Source">The source of the public message. Useful when there could be more than location. Channel specific, e.g., for Facebook it&#39;s a source page..</param>
        /// <param name="Url">The URL of the social post on the native platform..</param>
        /// <param name="MentionIds">IDs of accounts referenced by name within the message text or caption (for example &#39;@brandpage&#39; in a post body or comment). A &#39;mention&#39; here uses the same convention as Meta (Facebook, Instagram) and LinkedIn, where it denotes a textual reference to an account. Distinct from tagIds, which represent explicit associations with the message. Null or absent when no accounts are referenced in the text..</param>
        /// <param name="TagIds">IDs of accounts attached to the message itself, independent of the text (for example a person tagged in an Instagram photo so their profile is linked from the image). A &#39;tag&#39; here uses the same convention as Meta (Facebook, Instagram) and LinkedIn, where it denotes an explicit association with content rather than a textual reference. Distinct from mentionIds, which represent in-text/caption references. Null or absent when no accounts are tagged on the message..</param>
        public OpenSocialMediaPublicMetadata(string RootId = null, string ReplyToId = null, string Source = null, string Url = null, List<string> MentionIds = null, List<string> TagIds = null)
        {
            this.RootId = RootId;
            this.ReplyToId = ReplyToId;
            this.Source = Source;
            this.Url = Url;
            this.MentionIds = MentionIds;
            this.TagIds = TagIds;
            
        }
        


        /// <summary>
        /// The id of the root public message.
        /// </summary>
        /// <value>The id of the root public message.</value>
        [DataMember(Name="rootId", EmitDefaultValue=false)]
        public string RootId { get; set; }



        /// <summary>
        /// The id of the message this public message is replying to.
        /// </summary>
        /// <value>The id of the message this public message is replying to.</value>
        [DataMember(Name="replyToId", EmitDefaultValue=false)]
        public string ReplyToId { get; set; }



        /// <summary>
        /// The source of the public message. Useful when there could be more than location. Channel specific, e.g., for Facebook it&#39;s a source page.
        /// </summary>
        /// <value>The source of the public message. Useful when there could be more than location. Channel specific, e.g., for Facebook it&#39;s a source page.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// The URL of the social post on the native platform.
        /// </summary>
        /// <value>The URL of the social post on the native platform.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// IDs of accounts referenced by name within the message text or caption (for example &#39;@brandpage&#39; in a post body or comment). A &#39;mention&#39; here uses the same convention as Meta (Facebook, Instagram) and LinkedIn, where it denotes a textual reference to an account. Distinct from tagIds, which represent explicit associations with the message. Null or absent when no accounts are referenced in the text.
        /// </summary>
        /// <value>IDs of accounts referenced by name within the message text or caption (for example &#39;@brandpage&#39; in a post body or comment). A &#39;mention&#39; here uses the same convention as Meta (Facebook, Instagram) and LinkedIn, where it denotes a textual reference to an account. Distinct from tagIds, which represent explicit associations with the message. Null or absent when no accounts are referenced in the text.</value>
        [DataMember(Name="mentionIds", EmitDefaultValue=false)]
        public List<string> MentionIds { get; set; }



        /// <summary>
        /// IDs of accounts attached to the message itself, independent of the text (for example a person tagged in an Instagram photo so their profile is linked from the image). A &#39;tag&#39; here uses the same convention as Meta (Facebook, Instagram) and LinkedIn, where it denotes an explicit association with content rather than a textual reference. Distinct from mentionIds, which represent in-text/caption references. Null or absent when no accounts are tagged on the message.
        /// </summary>
        /// <value>IDs of accounts attached to the message itself, independent of the text (for example a person tagged in an Instagram photo so their profile is linked from the image). A &#39;tag&#39; here uses the same convention as Meta (Facebook, Instagram) and LinkedIn, where it denotes an explicit association with content rather than a textual reference. Distinct from mentionIds, which represent in-text/caption references. Null or absent when no accounts are tagged on the message.</value>
        [DataMember(Name="tagIds", EmitDefaultValue=false)]
        public List<string> TagIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenSocialMediaPublicMetadata {\n");

            sb.Append("  RootId: ").Append(RootId).Append("\n");
            sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  MentionIds: ").Append(MentionIds).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
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
            return this.Equals(obj as OpenSocialMediaPublicMetadata);
        }

        /// <summary>
        /// Returns true if OpenSocialMediaPublicMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenSocialMediaPublicMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenSocialMediaPublicMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RootId == other.RootId ||
                    this.RootId != null &&
                    this.RootId.Equals(other.RootId)
                ) &&
                (
                    this.ReplyToId == other.ReplyToId ||
                    this.ReplyToId != null &&
                    this.ReplyToId.Equals(other.ReplyToId)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.MentionIds == other.MentionIds ||
                    this.MentionIds != null &&
                    this.MentionIds.SequenceEqual(other.MentionIds)
                ) &&
                (
                    this.TagIds == other.TagIds ||
                    this.TagIds != null &&
                    this.TagIds.SequenceEqual(other.TagIds)
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
                if (this.RootId != null)
                    hash = hash * 59 + this.RootId.GetHashCode();

                if (this.ReplyToId != null)
                    hash = hash * 59 + this.ReplyToId.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.MentionIds != null)
                    hash = hash * 59 + this.MentionIds.GetHashCode();

                if (this.TagIds != null)
                    hash = hash * 59 + this.TagIds.GetHashCode();

                return hash;
            }
        }
    }

}
