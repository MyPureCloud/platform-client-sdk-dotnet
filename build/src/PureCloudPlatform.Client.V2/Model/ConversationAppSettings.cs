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
    /// Conversation settings that handles chats within the messenger
    /// </summary>
    [DataContract]
    public partial class ConversationAppSettings :  IEquatable<ConversationAppSettings>
    {
        /// <summary>
        /// Deprecated. The auto start type for the messenger conversation
        /// </summary>
        /// <value>Deprecated. The auto start type for the messenger conversation</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AutoStartTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Automatic for "Automatic"
            /// </summary>
            [EnumMember(Value = "Automatic")]
            Automatic
        }
        /// <summary>
        /// Deprecated. The auto start type for the messenger conversation
        /// </summary>
        /// <value>Deprecated. The auto start type for the messenger conversation</value>
        [DataMember(Name="autoStartType", EmitDefaultValue=false)]
        public AutoStartTypeEnum? AutoStartType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAppSettings" /> class.
        /// </summary>
        /// <param name="Enabled">The toggle to enable or disable conversations.</param>
        /// <param name="ShowAgentTypingIndicator">The toggle to enable or disable typing indicator for messenger.</param>
        /// <param name="ShowUserTypingIndicator">The toggle to enable or disable typing indicator for messenger.</param>
        /// <param name="AutoStartType">Deprecated. The auto start type for the messenger conversation.</param>
        /// <param name="AutoStart">The auto start for the messenger conversation.</param>
        /// <param name="Markdown">The markdown for the messenger app.</param>
        /// <param name="ConversationDisconnect">The conversation disconnect settings for the messenger app.</param>
        /// <param name="ConversationClear">The conversation clear settings for the messenger app.</param>
        /// <param name="Humanize">The humanize conversations settings for the messenger app.</param>
        public ConversationAppSettings(bool? Enabled = null, bool? ShowAgentTypingIndicator = null, bool? ShowUserTypingIndicator = null, AutoStartTypeEnum? AutoStartType = null, AutoStart AutoStart = null, Markdown Markdown = null, ConversationDisconnectSettings ConversationDisconnect = null, ConversationClearSettings ConversationClear = null, Humanize Humanize = null)
        {
            this.Enabled = Enabled;
            this.ShowAgentTypingIndicator = ShowAgentTypingIndicator;
            this.ShowUserTypingIndicator = ShowUserTypingIndicator;
            this.AutoStartType = AutoStartType;
            this.AutoStart = AutoStart;
            this.Markdown = Markdown;
            this.ConversationDisconnect = ConversationDisconnect;
            this.ConversationClear = ConversationClear;
            this.Humanize = Humanize;
            
        }
        


        /// <summary>
        /// The toggle to enable or disable conversations
        /// </summary>
        /// <value>The toggle to enable or disable conversations</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The toggle to enable or disable typing indicator for messenger
        /// </summary>
        /// <value>The toggle to enable or disable typing indicator for messenger</value>
        [DataMember(Name="showAgentTypingIndicator", EmitDefaultValue=false)]
        public bool? ShowAgentTypingIndicator { get; set; }



        /// <summary>
        /// The toggle to enable or disable typing indicator for messenger
        /// </summary>
        /// <value>The toggle to enable or disable typing indicator for messenger</value>
        [DataMember(Name="showUserTypingIndicator", EmitDefaultValue=false)]
        public bool? ShowUserTypingIndicator { get; set; }





        /// <summary>
        /// The auto start for the messenger conversation
        /// </summary>
        /// <value>The auto start for the messenger conversation</value>
        [DataMember(Name="autoStart", EmitDefaultValue=false)]
        public AutoStart AutoStart { get; set; }



        /// <summary>
        /// The markdown for the messenger app
        /// </summary>
        /// <value>The markdown for the messenger app</value>
        [DataMember(Name="markdown", EmitDefaultValue=false)]
        public Markdown Markdown { get; set; }



        /// <summary>
        /// The conversation disconnect settings for the messenger app
        /// </summary>
        /// <value>The conversation disconnect settings for the messenger app</value>
        [DataMember(Name="conversationDisconnect", EmitDefaultValue=false)]
        public ConversationDisconnectSettings ConversationDisconnect { get; set; }



        /// <summary>
        /// The conversation clear settings for the messenger app
        /// </summary>
        /// <value>The conversation clear settings for the messenger app</value>
        [DataMember(Name="conversationClear", EmitDefaultValue=false)]
        public ConversationClearSettings ConversationClear { get; set; }



        /// <summary>
        /// The humanize conversations settings for the messenger app
        /// </summary>
        /// <value>The humanize conversations settings for the messenger app</value>
        [DataMember(Name="humanize", EmitDefaultValue=false)]
        public Humanize Humanize { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAppSettings {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ShowAgentTypingIndicator: ").Append(ShowAgentTypingIndicator).Append("\n");
            sb.Append("  ShowUserTypingIndicator: ").Append(ShowUserTypingIndicator).Append("\n");
            sb.Append("  AutoStartType: ").Append(AutoStartType).Append("\n");
            sb.Append("  AutoStart: ").Append(AutoStart).Append("\n");
            sb.Append("  Markdown: ").Append(Markdown).Append("\n");
            sb.Append("  ConversationDisconnect: ").Append(ConversationDisconnect).Append("\n");
            sb.Append("  ConversationClear: ").Append(ConversationClear).Append("\n");
            sb.Append("  Humanize: ").Append(Humanize).Append("\n");
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
            return this.Equals(obj as ConversationAppSettings);
        }

        /// <summary>
        /// Returns true if ConversationAppSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAppSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAppSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.ShowAgentTypingIndicator == other.ShowAgentTypingIndicator ||
                    this.ShowAgentTypingIndicator != null &&
                    this.ShowAgentTypingIndicator.Equals(other.ShowAgentTypingIndicator)
                ) &&
                (
                    this.ShowUserTypingIndicator == other.ShowUserTypingIndicator ||
                    this.ShowUserTypingIndicator != null &&
                    this.ShowUserTypingIndicator.Equals(other.ShowUserTypingIndicator)
                ) &&
                (
                    this.AutoStartType == other.AutoStartType ||
                    this.AutoStartType != null &&
                    this.AutoStartType.Equals(other.AutoStartType)
                ) &&
                (
                    this.AutoStart == other.AutoStart ||
                    this.AutoStart != null &&
                    this.AutoStart.Equals(other.AutoStart)
                ) &&
                (
                    this.Markdown == other.Markdown ||
                    this.Markdown != null &&
                    this.Markdown.Equals(other.Markdown)
                ) &&
                (
                    this.ConversationDisconnect == other.ConversationDisconnect ||
                    this.ConversationDisconnect != null &&
                    this.ConversationDisconnect.Equals(other.ConversationDisconnect)
                ) &&
                (
                    this.ConversationClear == other.ConversationClear ||
                    this.ConversationClear != null &&
                    this.ConversationClear.Equals(other.ConversationClear)
                ) &&
                (
                    this.Humanize == other.Humanize ||
                    this.Humanize != null &&
                    this.Humanize.Equals(other.Humanize)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.ShowAgentTypingIndicator != null)
                    hash = hash * 59 + this.ShowAgentTypingIndicator.GetHashCode();

                if (this.ShowUserTypingIndicator != null)
                    hash = hash * 59 + this.ShowUserTypingIndicator.GetHashCode();

                if (this.AutoStartType != null)
                    hash = hash * 59 + this.AutoStartType.GetHashCode();

                if (this.AutoStart != null)
                    hash = hash * 59 + this.AutoStart.GetHashCode();

                if (this.Markdown != null)
                    hash = hash * 59 + this.Markdown.GetHashCode();

                if (this.ConversationDisconnect != null)
                    hash = hash * 59 + this.ConversationDisconnect.GetHashCode();

                if (this.ConversationClear != null)
                    hash = hash * 59 + this.ConversationClear.GetHashCode();

                if (this.Humanize != null)
                    hash = hash * 59 + this.Humanize.GetHashCode();

                return hash;
            }
        }
    }

}
