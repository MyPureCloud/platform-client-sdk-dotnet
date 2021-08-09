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
    /// Settings for an input event to the bot flow indicating user input is available.
    /// </summary>
    [DataContract]
    public partial class TextBotUserInputEvent :  IEquatable<TextBotUserInputEvent>
    {
        
        
        /// <summary>
        /// The input mode.
        /// </summary>
        /// <value>The input mode.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ModeEnum
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
            Text
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The input mode.
        /// </summary>
        /// <value>The input mode.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotUserInputEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotUserInputEvent() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotUserInputEvent" /> class.
        /// </summary>
        /// <param name="Mode">The input mode. (required).</param>
        /// <param name="Alternatives">The input alternatives..</param>
        public TextBotUserInputEvent(ModeEnum? Mode = null, List<TextBotUserInputAlternative> Alternatives = null)
        {
            this.Mode = Mode;
            this.Alternatives = Alternatives;
            
        }
        
        
        
        
        
        /// <summary>
        /// The input alternatives.
        /// </summary>
        /// <value>The input alternatives.</value>
        [DataMember(Name="alternatives", EmitDefaultValue=false)]
        public List<TextBotUserInputAlternative> Alternatives { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotUserInputEvent {\n");
            
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
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
            return this.Equals(obj as TextBotUserInputEvent);
        }

        /// <summary>
        /// Returns true if TextBotUserInputEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotUserInputEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotUserInputEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) &&
                (
                    this.Alternatives == other.Alternatives ||
                    this.Alternatives != null &&
                    this.Alternatives.SequenceEqual(other.Alternatives)
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
                
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                
                if (this.Alternatives != null)
                    hash = hash * 59 + this.Alternatives.GetHashCode();
                
                return hash;
            }
        }
    }

}
