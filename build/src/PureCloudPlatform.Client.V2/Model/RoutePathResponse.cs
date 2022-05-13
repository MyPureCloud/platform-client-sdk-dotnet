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
    /// RoutePathResponse
    /// </summary>
    [DataContract]
    public partial class RoutePathResponse :  IEquatable<RoutePathResponse>
    {
        /// <summary>
        /// The media type of the given queue associated with the route path
        /// </summary>
        /// <value>The media type of the given queue associated with the route path</value>
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
        /// The media type of the given queue associated with the route path
        /// </summary>
        /// <value>The media type of the given queue associated with the route path</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutePathResponse" /> class.
        /// </summary>
        /// <param name="Queue">The ID of the queue associated with the route path.</param>
        /// <param name="MediaType">The media type of the given queue associated with the route path.</param>
        /// <param name="Language">The ID of the language associated with the route path.</param>
        /// <param name="Skills">The set of skills associated with the route path.</param>
        public RoutePathResponse(QueueReference Queue = null, MediaTypeEnum? MediaType = null, LanguageReference Language = null, List<RoutingSkillReference> Skills = null)
        {
            this.Queue = Queue;
            this.MediaType = MediaType;
            this.Language = Language;
            this.Skills = Skills;
            
        }
        


        /// <summary>
        /// The ID of the queue associated with the route path
        /// </summary>
        /// <value>The ID of the queue associated with the route path</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public QueueReference Queue { get; set; }





        /// <summary>
        /// The ID of the language associated with the route path
        /// </summary>
        /// <value>The ID of the language associated with the route path</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageReference Language { get; set; }



        /// <summary>
        /// The set of skills associated with the route path
        /// </summary>
        /// <value>The set of skills associated with the route path</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<RoutingSkillReference> Skills { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutePathResponse {\n");

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
            return this.Equals(obj as RoutePathResponse);
        }

        /// <summary>
        /// Returns true if RoutePathResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RoutePathResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutePathResponse other)
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
