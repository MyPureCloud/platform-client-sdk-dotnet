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
    /// Channel information relevant to a bot flow.
    /// </summary>
    [DataContract]
    public partial class BotChannel :  IEquatable<BotChannel>
    {
        /// <summary>
        /// The name of the channel.
        /// </summary>
        /// <value>The name of the channel.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Messaging for "Messaging"
            /// </summary>
            [EnumMember(Value = "Messaging")]
            Messaging
        }
        /// <summary>
        /// Gets or Sets InputModes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InputModesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Dtmf for "DTMF"
            /// </summary>
            [EnumMember(Value = "DTMF")]
            Dtmf
        }
        /// <summary>
        /// Gets or Sets OutputModes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OutputModesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice
        }
        /// <summary>
        /// The name of the channel.
        /// </summary>
        /// <value>The name of the channel.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotChannel" /> class.
        /// </summary>
        /// <param name="Name">The name of the channel. (required).</param>
        /// <param name="InputModes">The input modes for the channel. (required).</param>
        /// <param name="OutputModes">The output modes for the channel. (required).</param>
        /// <param name="UserAgent">Information about the end user agent calling the bot flow. (required).</param>
        public BotChannel(NameEnum? Name = null, List<InputModesEnum> InputModes = null, List<OutputModesEnum> OutputModes = null, TextBotUserAgent UserAgent = null)
        {
            this.Name = Name;
            this.InputModes = InputModes;
            this.OutputModes = OutputModes;
            this.UserAgent = UserAgent;
            
        }
        




        /// <summary>
        /// The input modes for the channel.
        /// </summary>
        /// <value>The input modes for the channel.</value>
        [DataMember(Name="inputModes", EmitDefaultValue=false)]
        public List<InputModesEnum> InputModes { get; set; }



        /// <summary>
        /// The output modes for the channel.
        /// </summary>
        /// <value>The output modes for the channel.</value>
        [DataMember(Name="outputModes", EmitDefaultValue=false)]
        public List<OutputModesEnum> OutputModes { get; set; }



        /// <summary>
        /// Information about the end user agent calling the bot flow.
        /// </summary>
        /// <value>Information about the end user agent calling the bot flow.</value>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public TextBotUserAgent UserAgent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotChannel {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InputModes: ").Append(InputModes).Append("\n");
            sb.Append("  OutputModes: ").Append(OutputModes).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(obj as BotChannel);
        }

        /// <summary>
        /// Returns true if BotChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of BotChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotChannel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.InputModes == other.InputModes ||
                    this.InputModes != null &&
                    this.InputModes.SequenceEqual(other.InputModes)
                ) &&
                (
                    this.OutputModes == other.OutputModes ||
                    this.OutputModes != null &&
                    this.OutputModes.SequenceEqual(other.OutputModes)
                ) &&
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.InputModes != null)
                    hash = hash * 59 + this.InputModes.GetHashCode();

                if (this.OutputModes != null)
                    hash = hash * 59 + this.OutputModes.GetHashCode();

                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();

                return hash;
            }
        }
    }

}
