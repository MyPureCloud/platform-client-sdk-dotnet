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
    /// Room
    /// </summary>
    [DataContract]
    public partial class Room :  IEquatable<Room>
    {
        /// <summary>
        /// The type of room
        /// </summary>
        /// <value>The type of room</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RoomTypeEnum
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
        /// The type of room
        /// </summary>
        /// <value>The type of room</value>
        [DataMember(Name="roomType", EmitDefaultValue=false)]
        public RoomTypeEnum? RoomType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">Room's created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="RoomType">The type of room.</param>
        /// <param name="Description">Room's description.</param>
        /// <param name="Subject">Room's subject.</param>
        /// <param name="ParticipantLimit">Room's size limit.</param>
        /// <param name="Owners">Room's owners.</param>
        /// <param name="PinnedMessages">Room's pinned messages.</param>
        /// <param name="Jid">The jid of the room.</param>
        public Room(string Name = null, DateTime? DateCreated = null, RoomTypeEnum? RoomType = null, string Description = null, string Subject = null, int? ParticipantLimit = null, List<UserReference> Owners = null, List<AddressableEntityRef> PinnedMessages = null, string Jid = null)
        {
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.RoomType = RoomType;
            this.Description = Description;
            this.Subject = Subject;
            this.ParticipantLimit = ParticipantLimit;
            this.Owners = Owners;
            this.PinnedMessages = PinnedMessages;
            this.Jid = Jid;
            
        }
        


        /// <summary>
        /// The jid of the room if adhoc, the id of the group for group rooms
        /// </summary>
        /// <value>The jid of the room if adhoc, the id of the group for group rooms</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Room's created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Room's created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }





        /// <summary>
        /// Room's description
        /// </summary>
        /// <value>Room's description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Room's subject
        /// </summary>
        /// <value>Room's subject</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// Room's size limit
        /// </summary>
        /// <value>Room's size limit</value>
        [DataMember(Name="participantLimit", EmitDefaultValue=false)]
        public int? ParticipantLimit { get; set; }



        /// <summary>
        /// Room's owners
        /// </summary>
        /// <value>Room's owners</value>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<UserReference> Owners { get; set; }



        /// <summary>
        /// Room's pinned messages
        /// </summary>
        /// <value>Room's pinned messages</value>
        [DataMember(Name="pinnedMessages", EmitDefaultValue=false)]
        public List<AddressableEntityRef> PinnedMessages { get; set; }



        /// <summary>
        /// The jid of the room
        /// </summary>
        /// <value>The jid of the room</value>
        [DataMember(Name="jid", EmitDefaultValue=false)]
        public string Jid { get; set; }



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
            sb.Append("class Room {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ParticipantLimit: ").Append(ParticipantLimit).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  PinnedMessages: ").Append(PinnedMessages).Append("\n");
            sb.Append("  Jid: ").Append(Jid).Append("\n");
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
            return this.Equals(obj as Room);
        }

        /// <summary>
        /// Returns true if Room instances are equal
        /// </summary>
        /// <param name="other">Instance of Room to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room other)
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.RoomType == other.RoomType ||
                    this.RoomType != null &&
                    this.RoomType.Equals(other.RoomType)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) &&
                (
                    this.ParticipantLimit == other.ParticipantLimit ||
                    this.ParticipantLimit != null &&
                    this.ParticipantLimit.Equals(other.ParticipantLimit)
                ) &&
                (
                    this.Owners == other.Owners ||
                    this.Owners != null &&
                    this.Owners.SequenceEqual(other.Owners)
                ) &&
                (
                    this.PinnedMessages == other.PinnedMessages ||
                    this.PinnedMessages != null &&
                    this.PinnedMessages.SequenceEqual(other.PinnedMessages)
                ) &&
                (
                    this.Jid == other.Jid ||
                    this.Jid != null &&
                    this.Jid.Equals(other.Jid)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.RoomType != null)
                    hash = hash * 59 + this.RoomType.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();

                if (this.ParticipantLimit != null)
                    hash = hash * 59 + this.ParticipantLimit.GetHashCode();

                if (this.Owners != null)
                    hash = hash * 59 + this.Owners.GetHashCode();

                if (this.PinnedMessages != null)
                    hash = hash * 59 + this.PinnedMessages.GetHashCode();

                if (this.Jid != null)
                    hash = hash * 59 + this.Jid.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
