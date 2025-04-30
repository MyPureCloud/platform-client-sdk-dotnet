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
    /// UserSettingsForChat
    /// </summary>
    [DataContract]
    public partial class UserSettingsForChat :  IEquatable<UserSettingsForChat>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSettingsForChat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSettingsForChat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSettingsForChat" /> class.
        /// </summary>
        /// <param name="Muted">Whether or not to enable muting notifications.</param>
        /// <param name="MentionsOnly">Whether or not to enable notifications for mentions only.</param>
        /// <param name="NotifyOnReactions">Whether or not to enable notifications for reactions on a user&#39;s own messages.</param>
        /// <param name="Mobile">Settings for mobile devices (required).</param>
        public UserSettingsForChat(bool? Muted = null, bool? MentionsOnly = null, bool? NotifyOnReactions = null, MobileSettings Mobile = null)
        {
            this.Muted = Muted;
            this.MentionsOnly = MentionsOnly;
            this.NotifyOnReactions = NotifyOnReactions;
            this.Mobile = Mobile;
            
        }
        


        /// <summary>
        /// Whether or not to enable muting notifications
        /// </summary>
        /// <value>Whether or not to enable muting notifications</value>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool? Muted { get; set; }



        /// <summary>
        /// Whether or not to enable notifications for mentions only
        /// </summary>
        /// <value>Whether or not to enable notifications for mentions only</value>
        [DataMember(Name="mentionsOnly", EmitDefaultValue=false)]
        public bool? MentionsOnly { get; set; }



        /// <summary>
        /// Whether or not to enable notifications for reactions on a user&#39;s own messages
        /// </summary>
        /// <value>Whether or not to enable notifications for reactions on a user&#39;s own messages</value>
        [DataMember(Name="notifyOnReactions", EmitDefaultValue=false)]
        public bool? NotifyOnReactions { get; set; }



        /// <summary>
        /// Settings for mobile devices
        /// </summary>
        /// <value>Settings for mobile devices</value>
        [DataMember(Name="mobile", EmitDefaultValue=false)]
        public MobileSettings Mobile { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSettingsForChat {\n");

            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  MentionsOnly: ").Append(MentionsOnly).Append("\n");
            sb.Append("  NotifyOnReactions: ").Append(NotifyOnReactions).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
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
            return this.Equals(obj as UserSettingsForChat);
        }

        /// <summary>
        /// Returns true if UserSettingsForChat instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSettingsForChat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSettingsForChat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Muted == other.Muted ||
                    this.Muted != null &&
                    this.Muted.Equals(other.Muted)
                ) &&
                (
                    this.MentionsOnly == other.MentionsOnly ||
                    this.MentionsOnly != null &&
                    this.MentionsOnly.Equals(other.MentionsOnly)
                ) &&
                (
                    this.NotifyOnReactions == other.NotifyOnReactions ||
                    this.NotifyOnReactions != null &&
                    this.NotifyOnReactions.Equals(other.NotifyOnReactions)
                ) &&
                (
                    this.Mobile == other.Mobile ||
                    this.Mobile != null &&
                    this.Mobile.Equals(other.Mobile)
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
                if (this.Muted != null)
                    hash = hash * 59 + this.Muted.GetHashCode();

                if (this.MentionsOnly != null)
                    hash = hash * 59 + this.MentionsOnly.GetHashCode();

                if (this.NotifyOnReactions != null)
                    hash = hash * 59 + this.NotifyOnReactions.GetHashCode();

                if (this.Mobile != null)
                    hash = hash * 59 + this.Mobile.GetHashCode();

                return hash;
            }
        }
    }

}
