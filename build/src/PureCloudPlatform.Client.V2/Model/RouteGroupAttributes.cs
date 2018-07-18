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
    /// Attributes for the associated route group
    /// </summary>
    [DataContract]
    public partial class RouteGroupAttributes :  IEquatable<RouteGroupAttributes>
    {
        
        
        
        
        
        /// <summary>
        /// The media type to which the associated route group applies
        /// </summary>
        /// <value>The media type to which the associated route group applies</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "Chat"
            /// </summary>
            [EnumMember(Value = "Chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The media type to which the associated route group applies
        /// </summary>
        /// <value>The media type to which the associated route group applies</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteGroupAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteGroupAttributes() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteGroupAttributes" /> class.
        /// </summary>
        /// <param name="Queue">The queue to which the associated route group applies (required).</param>
        /// <param name="MediaType">The media type to which the associated route group applies (required).</param>
        /// <param name="Language">The language to which the associated route group applies.</param>
        /// <param name="Skills">The skill set to which the associated route group applies.</param>
        public RouteGroupAttributes(QueueReference Queue = null, MediaTypeEnum? MediaType = null, LanguageReference Language = null, List<RoutingSkillReference> Skills = null)
        {
            this.Queue = Queue;
            this.MediaType = MediaType;
            this.Language = Language;
            this.Skills = Skills;
            
        }
        
        
        
        /// <summary>
        /// The queue to which the associated route group applies
        /// </summary>
        /// <value>The queue to which the associated route group applies</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public QueueReference Queue { get; set; }
        
        
        
        
        
        /// <summary>
        /// The language to which the associated route group applies
        /// </summary>
        /// <value>The language to which the associated route group applies</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageReference Language { get; set; }
        
        
        
        /// <summary>
        /// The skill set to which the associated route group applies
        /// </summary>
        /// <value>The skill set to which the associated route group applies</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<RoutingSkillReference> Skills { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteGroupAttributes {\n");
            
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RouteGroupAttributes);
        }

        /// <summary>
        /// Returns true if RouteGroupAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of RouteGroupAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteGroupAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
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
                
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                
                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();
                
                return hash;
            }
        }
    }

}
