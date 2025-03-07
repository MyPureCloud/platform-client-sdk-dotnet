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
    /// Message event element.  Examples include: system messages, typing indicators, cobrowse offerings.
    /// </summary>
    [DataContract]
    public partial class MessageEvent :  IEquatable<MessageEvent>
    {
        /// <summary>
        /// Type of this event element
        /// </summary>
        /// <value>Type of this event element</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Cobrowse for "CoBrowse"
            /// </summary>
            [EnumMember(Value = "CoBrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Typing for "Typing"
            /// </summary>
            [EnumMember(Value = "Typing")]
            Typing,
            
            /// <summary>
            /// Enum Presence for "Presence"
            /// </summary>
            [EnumMember(Value = "Presence")]
            Presence,
            
            /// <summary>
            /// Enum Video for "Video"
            /// </summary>
            [EnumMember(Value = "Video")]
            Video,
            
            /// <summary>
            /// Enum Reactions for "Reactions"
            /// </summary>
            [EnumMember(Value = "Reactions")]
            Reactions
        }
        /// <summary>
        /// Type of this event element
        /// </summary>
        /// <value>Type of this event element</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageEvent" /> class.
        /// </summary>
        /// <param name="EventType">Type of this event element (required).</param>
        /// <param name="CoBrowse">CoBrowse event..</param>
        /// <param name="Typing">Typing event..</param>
        /// <param name="Presence">Presence event..</param>
        /// <param name="Video">Video event..</param>
        /// <param name="Reactions">A list of reactions to a message..</param>
        public MessageEvent(EventTypeEnum? EventType = null, EventCoBrowse CoBrowse = null, EventTyping Typing = null, EventPresence Presence = null, EventVideo Video = null, List<ContentReaction> Reactions = null)
        {
            this.EventType = EventType;
            this.CoBrowse = CoBrowse;
            this.Typing = Typing;
            this.Presence = Presence;
            this.Video = Video;
            this.Reactions = Reactions;
            
        }
        




        /// <summary>
        /// CoBrowse event.
        /// </summary>
        /// <value>CoBrowse event.</value>
        [DataMember(Name="coBrowse", EmitDefaultValue=false)]
        public EventCoBrowse CoBrowse { get; set; }



        /// <summary>
        /// Typing event.
        /// </summary>
        /// <value>Typing event.</value>
        [DataMember(Name="typing", EmitDefaultValue=false)]
        public EventTyping Typing { get; set; }



        /// <summary>
        /// Presence event.
        /// </summary>
        /// <value>Presence event.</value>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public EventPresence Presence { get; set; }



        /// <summary>
        /// Video event.
        /// </summary>
        /// <value>Video event.</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public EventVideo Video { get; set; }



        /// <summary>
        /// A list of reactions to a message.
        /// </summary>
        /// <value>A list of reactions to a message.</value>
        [DataMember(Name="reactions", EmitDefaultValue=false)]
        public List<ContentReaction> Reactions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageEvent {\n");

            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  CoBrowse: ").Append(CoBrowse).Append("\n");
            sb.Append("  Typing: ").Append(Typing).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
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
            return this.Equals(obj as MessageEvent);
        }

        /// <summary>
        /// Returns true if MessageEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) &&
                (
                    this.CoBrowse == other.CoBrowse ||
                    this.CoBrowse != null &&
                    this.CoBrowse.Equals(other.CoBrowse)
                ) &&
                (
                    this.Typing == other.Typing ||
                    this.Typing != null &&
                    this.Typing.Equals(other.Typing)
                ) &&
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) &&
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
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
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();

                if (this.CoBrowse != null)
                    hash = hash * 59 + this.CoBrowse.GetHashCode();

                if (this.Typing != null)
                    hash = hash * 59 + this.Typing.GetHashCode();

                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();

                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();

                if (this.Reactions != null)
                    hash = hash * 59 + this.Reactions.GetHashCode();

                return hash;
            }
        }
    }

}
