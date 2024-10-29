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
    /// ChatItem
    /// </summary>
    [DataContract]
    public partial class ChatItem :  IEquatable<ChatItem>
    {
        /// <summary>
        /// The type of chat
        /// </summary>
        /// <value>The type of chat</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ChatTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Adhoc for "adhoc"
            /// </summary>
            [EnumMember(Value = "adhoc")]
            Adhoc,
            
            /// <summary>
            /// Enum Acd for "acd"
            /// </summary>
            [EnumMember(Value = "acd")]
            Acd,
            
            /// <summary>
            /// Enum Group for "group"
            /// </summary>
            [EnumMember(Value = "group")]
            Group,
            
            /// <summary>
            /// Enum Oneonone for "oneOnOne"
            /// </summary>
            [EnumMember(Value = "oneOnOne")]
            Oneonone,
            
            /// <summary>
            /// Enum Supervisorassistance for "supervisorAssistance"
            /// </summary>
            [EnumMember(Value = "supervisorAssistance")]
            Supervisorassistance
        }
        /// <summary>
        /// The type of chat
        /// </summary>
        /// <value>The type of chat</value>
        [DataMember(Name="chatType", EmitDefaultValue=false)]
        public ChatTypeEnum? ChatType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatItem" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Open">If the chat is open (required).</param>
        /// <param name="Favorite">The favorite entity for the chat, only appears if the chat is favorited.</param>
        /// <param name="Images">Avatar images for the chat.</param>
        /// <param name="DateLastMessage">The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateClosed">The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="User">The other 1on1 user.</param>
        /// <param name="Room">The room of the chat.</param>
        /// <param name="ChatType">The type of chat (required).</param>
        public ChatItem(string Name = null, bool? Open = null, ChatFavorite Favorite = null, List<Image> Images = null, DateTime? DateLastMessage = null, DateTime? DateClosed = null, ChatUserRef User = null, Room Room = null, ChatTypeEnum? ChatType = null)
        {
            this.Name = Name;
            this.Open = Open;
            this.Favorite = Favorite;
            this.Images = Images;
            this.DateLastMessage = DateLastMessage;
            this.DateClosed = DateClosed;
            this.User = User;
            this.Room = Room;
            this.ChatType = ChatType;
            
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
        /// If the chat is open
        /// </summary>
        /// <value>If the chat is open</value>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public bool? Open { get; set; }



        /// <summary>
        /// The favorite entity for the chat, only appears if the chat is favorited
        /// </summary>
        /// <value>The favorite entity for the chat, only appears if the chat is favorited</value>
        [DataMember(Name="favorite", EmitDefaultValue=false)]
        public ChatFavorite Favorite { get; set; }



        /// <summary>
        /// Avatar images for the chat
        /// </summary>
        /// <value>Avatar images for the chat</value>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<Image> Images { get; set; }



        /// <summary>
        /// The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateLastMessage", EmitDefaultValue=false)]
        public DateTime? DateLastMessage { get; set; }



        /// <summary>
        /// The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateClosed", EmitDefaultValue=false)]
        public DateTime? DateClosed { get; set; }



        /// <summary>
        /// The other 1on1 user
        /// </summary>
        /// <value>The other 1on1 user</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public ChatUserRef User { get; set; }



        /// <summary>
        /// The room of the chat
        /// </summary>
        /// <value>The room of the chat</value>
        [DataMember(Name="room", EmitDefaultValue=false)]
        public Room Room { get; set; }





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
            sb.Append("class ChatItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Favorite: ").Append(Favorite).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  DateLastMessage: ").Append(DateLastMessage).Append("\n");
            sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Room: ").Append(Room).Append("\n");
            sb.Append("  ChatType: ").Append(ChatType).Append("\n");
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
            return this.Equals(obj as ChatItem);
        }

        /// <summary>
        /// Returns true if ChatItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ChatItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatItem other)
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
                    this.Open == other.Open ||
                    this.Open != null &&
                    this.Open.Equals(other.Open)
                ) &&
                (
                    this.Favorite == other.Favorite ||
                    this.Favorite != null &&
                    this.Favorite.Equals(other.Favorite)
                ) &&
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) &&
                (
                    this.DateLastMessage == other.DateLastMessage ||
                    this.DateLastMessage != null &&
                    this.DateLastMessage.Equals(other.DateLastMessage)
                ) &&
                (
                    this.DateClosed == other.DateClosed ||
                    this.DateClosed != null &&
                    this.DateClosed.Equals(other.DateClosed)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Room == other.Room ||
                    this.Room != null &&
                    this.Room.Equals(other.Room)
                ) &&
                (
                    this.ChatType == other.ChatType ||
                    this.ChatType != null &&
                    this.ChatType.Equals(other.ChatType)
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

                if (this.Open != null)
                    hash = hash * 59 + this.Open.GetHashCode();

                if (this.Favorite != null)
                    hash = hash * 59 + this.Favorite.GetHashCode();

                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();

                if (this.DateLastMessage != null)
                    hash = hash * 59 + this.DateLastMessage.GetHashCode();

                if (this.DateClosed != null)
                    hash = hash * 59 + this.DateClosed.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Room != null)
                    hash = hash * 59 + this.Room.GetHashCode();

                if (this.ChatType != null)
                    hash = hash * 59 + this.ChatType.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
