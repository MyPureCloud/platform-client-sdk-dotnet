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
    /// ChatMessageResponse
    /// </summary>
    [DataContract]
    public partial class ChatMessageResponse :  IEquatable<ChatMessageResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatMessageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageResponse" /> class.
        /// </summary>
        /// <param name="Id">The id of the message (required).</param>
        /// <param name="DateCreated">Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="DateModified">Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ToJid">Jid of message&#39;s recipient (roomJid or userJid) (required).</param>
        /// <param name="Jid">Jid of message&#39;s sender (userJid) (required).</param>
        /// <param name="Body">Message&#39;s body (required).</param>
        /// <param name="Mentions">Message&#39;s mentions.</param>
        /// <param name="Edited">If message was edited.</param>
        /// <param name="AttachmentDeleted">If message&#39;s attachment was deleted.</param>
        /// <param name="FileUri">URI of file attachment.</param>
        /// <param name="Thread">The id for a thread this message corresponds to (required).</param>
        /// <param name="ParentThread">Parent thread id for thread replies.</param>
        /// <param name="User">The user who sent the message.</param>
        /// <param name="ToUser">The receiving user of the message.</param>
        /// <param name="Reactions">The emoji reactions to this message.</param>
        public ChatMessageResponse(string Id = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ToJid = null, string Jid = null, string Body = null, Dictionary<string, string> Mentions = null, bool? Edited = null, bool? AttachmentDeleted = null, string FileUri = null, Entity Thread = null, Entity ParentThread = null, AddressableEntityRef User = null, AddressableEntityRef ToUser = null, List<ChatReaction> Reactions = null)
        {
            this.Id = Id;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ToJid = ToJid;
            this.Jid = Jid;
            this.Body = Body;
            this.Mentions = Mentions;
            this.Edited = Edited;
            this.AttachmentDeleted = AttachmentDeleted;
            this.FileUri = FileUri;
            this.Thread = Thread;
            this.ParentThread = ParentThread;
            this.User = User;
            this.ToUser = ToUser;
            this.Reactions = Reactions;
            
        }
        


        /// <summary>
        /// The id of the message
        /// </summary>
        /// <value>The id of the message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Message&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Message&#39;s last updated time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Jid of message&#39;s recipient (roomJid or userJid)
        /// </summary>
        /// <value>Jid of message&#39;s recipient (roomJid or userJid)</value>
        [DataMember(Name="toJid", EmitDefaultValue=false)]
        public string ToJid { get; set; }



        /// <summary>
        /// Jid of message&#39;s sender (userJid)
        /// </summary>
        /// <value>Jid of message&#39;s sender (userJid)</value>
        [DataMember(Name="jid", EmitDefaultValue=false)]
        public string Jid { get; set; }



        /// <summary>
        /// Message&#39;s body
        /// </summary>
        /// <value>Message&#39;s body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }



        /// <summary>
        /// Message&#39;s mentions
        /// </summary>
        /// <value>Message&#39;s mentions</value>
        [DataMember(Name="mentions", EmitDefaultValue=false)]
        public Dictionary<string, string> Mentions { get; set; }



        /// <summary>
        /// If message was edited
        /// </summary>
        /// <value>If message was edited</value>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public bool? Edited { get; set; }



        /// <summary>
        /// If message&#39;s attachment was deleted
        /// </summary>
        /// <value>If message&#39;s attachment was deleted</value>
        [DataMember(Name="attachmentDeleted", EmitDefaultValue=false)]
        public bool? AttachmentDeleted { get; set; }



        /// <summary>
        /// URI of file attachment
        /// </summary>
        /// <value>URI of file attachment</value>
        [DataMember(Name="fileUri", EmitDefaultValue=false)]
        public string FileUri { get; set; }



        /// <summary>
        /// The id for a thread this message corresponds to
        /// </summary>
        /// <value>The id for a thread this message corresponds to</value>
        [DataMember(Name="thread", EmitDefaultValue=false)]
        public Entity Thread { get; set; }



        /// <summary>
        /// Parent thread id for thread replies
        /// </summary>
        /// <value>Parent thread id for thread replies</value>
        [DataMember(Name="parentThread", EmitDefaultValue=false)]
        public Entity ParentThread { get; set; }



        /// <summary>
        /// The user who sent the message
        /// </summary>
        /// <value>The user who sent the message</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AddressableEntityRef User { get; set; }



        /// <summary>
        /// The receiving user of the message
        /// </summary>
        /// <value>The receiving user of the message</value>
        [DataMember(Name="toUser", EmitDefaultValue=false)]
        public AddressableEntityRef ToUser { get; set; }



        /// <summary>
        /// The emoji reactions to this message
        /// </summary>
        /// <value>The emoji reactions to this message</value>
        [DataMember(Name="reactions", EmitDefaultValue=false)]
        public List<ChatReaction> Reactions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatMessageResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ToJid: ").Append(ToJid).Append("\n");
            sb.Append("  Jid: ").Append(Jid).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Mentions: ").Append(Mentions).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  AttachmentDeleted: ").Append(AttachmentDeleted).Append("\n");
            sb.Append("  FileUri: ").Append(FileUri).Append("\n");
            sb.Append("  Thread: ").Append(Thread).Append("\n");
            sb.Append("  ParentThread: ").Append(ParentThread).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ToUser: ").Append(ToUser).Append("\n");
            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
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
            return this.Equals(obj as ChatMessageResponse);
        }

        /// <summary>
        /// Returns true if ChatMessageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatMessageResponse other)
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ToJid == other.ToJid ||
                    this.ToJid != null &&
                    this.ToJid.Equals(other.ToJid)
                ) &&
                (
                    this.Jid == other.Jid ||
                    this.Jid != null &&
                    this.Jid.Equals(other.Jid)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.Mentions == other.Mentions ||
                    this.Mentions != null &&
                    this.Mentions.SequenceEqual(other.Mentions)
                ) &&
                (
                    this.Edited == other.Edited ||
                    this.Edited != null &&
                    this.Edited.Equals(other.Edited)
                ) &&
                (
                    this.AttachmentDeleted == other.AttachmentDeleted ||
                    this.AttachmentDeleted != null &&
                    this.AttachmentDeleted.Equals(other.AttachmentDeleted)
                ) &&
                (
                    this.FileUri == other.FileUri ||
                    this.FileUri != null &&
                    this.FileUri.Equals(other.FileUri)
                ) &&
                (
                    this.Thread == other.Thread ||
                    this.Thread != null &&
                    this.Thread.Equals(other.Thread)
                ) &&
                (
                    this.ParentThread == other.ParentThread ||
                    this.ParentThread != null &&
                    this.ParentThread.Equals(other.ParentThread)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ToUser == other.ToUser ||
                    this.ToUser != null &&
                    this.ToUser.Equals(other.ToUser)
                ) &&
                (
                    this.Reactions == other.Reactions ||
                    this.Reactions != null &&
                    this.Reactions.SequenceEqual(other.Reactions)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.ToJid != null)
                    hash = hash * 59 + this.ToJid.GetHashCode();

                if (this.Jid != null)
                    hash = hash * 59 + this.Jid.GetHashCode();

                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                if (this.Mentions != null)
                    hash = hash * 59 + this.Mentions.GetHashCode();

                if (this.Edited != null)
                    hash = hash * 59 + this.Edited.GetHashCode();

                if (this.AttachmentDeleted != null)
                    hash = hash * 59 + this.AttachmentDeleted.GetHashCode();

                if (this.FileUri != null)
                    hash = hash * 59 + this.FileUri.GetHashCode();

                if (this.Thread != null)
                    hash = hash * 59 + this.Thread.GetHashCode();

                if (this.ParentThread != null)
                    hash = hash * 59 + this.ParentThread.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.ToUser != null)
                    hash = hash * 59 + this.ToUser.GetHashCode();

                if (this.Reactions != null)
                    hash = hash * 59 + this.Reactions.GetHashCode();

                return hash;
            }
        }
    }

}
