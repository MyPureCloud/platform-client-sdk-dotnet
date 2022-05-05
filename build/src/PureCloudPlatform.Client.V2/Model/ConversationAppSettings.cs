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
        /// <param name="ShowAgentTypingIndicator">The toggle to enable or disable typing indicator for messenger.</param>
        /// <param name="ShowUserTypingIndicator">The toggle to enable or disable typing indicator for messenger.</param>
        /// <param name="AutoStartType">Deprecated. The auto start type for the messenger conversation.</param>
        /// <param name="AutoStart">The auto start for the messenger conversation.</param>
        public ConversationAppSettings(bool? ShowAgentTypingIndicator = null, bool? ShowUserTypingIndicator = null, AutoStartTypeEnum? AutoStartType = null, AutoStart AutoStart = null)
        {
            this.ShowAgentTypingIndicator = ShowAgentTypingIndicator;
            this.ShowUserTypingIndicator = ShowUserTypingIndicator;
            this.AutoStartType = AutoStartType;
            this.AutoStart = AutoStart;
            
        }
        
        
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAppSettings {\n");
            
            sb.Append("  ShowAgentTypingIndicator: ").Append(ShowAgentTypingIndicator).Append("\n");
            sb.Append("  ShowUserTypingIndicator: ").Append(ShowUserTypingIndicator).Append("\n");
            sb.Append("  AutoStartType: ").Append(AutoStartType).Append("\n");
            sb.Append("  AutoStart: ").Append(AutoStart).Append("\n");
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
                
                if (this.ShowAgentTypingIndicator != null)
                    hash = hash * 59 + this.ShowAgentTypingIndicator.GetHashCode();
                
                if (this.ShowUserTypingIndicator != null)
                    hash = hash * 59 + this.ShowUserTypingIndicator.GetHashCode();
                
                if (this.AutoStartType != null)
                    hash = hash * 59 + this.AutoStartType.GetHashCode();
                
                if (this.AutoStart != null)
                    hash = hash * 59 + this.AutoStart.GetHashCode();
                
                return hash;
            }
        }
    }

}
