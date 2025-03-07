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
    /// WebChatRoutingTarget
    /// </summary>
    [DataContract]
    public partial class WebChatRoutingTarget :  IEquatable<WebChatRoutingTarget>
    {
        /// <summary>
        /// The target type of the routing target, such as 'QUEUE'.
        /// </summary>
        /// <value>The target type of the routing target, such as 'QUEUE'.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TargetTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queue for "QUEUE"
            /// </summary>
            [EnumMember(Value = "QUEUE")]
            Queue
        }
        /// <summary>
        /// The target type of the routing target, such as 'QUEUE'.
        /// </summary>
        /// <value>The target type of the routing target, such as 'QUEUE'.</value>
        [DataMember(Name="targetType", EmitDefaultValue=false)]
        public TargetTypeEnum? TargetType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatRoutingTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebChatRoutingTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebChatRoutingTarget" /> class.
        /// </summary>
        /// <param name="TargetType">The target type of the routing target, such as &#39;QUEUE&#39;. (required).</param>
        /// <param name="TargetAddress">The target of the route, in the format appropriate given the &#39;targetType&#39;. (required).</param>
        /// <param name="Skills">The list of skill names to use for routing..</param>
        /// <param name="Language">The language name to use for routing..</param>
        /// <param name="Priority">The priority to assign to the conversation for routing..</param>
        public WebChatRoutingTarget(TargetTypeEnum? TargetType = null, string TargetAddress = null, List<string> Skills = null, string Language = null, long? Priority = null)
        {
            this.TargetType = TargetType;
            this.TargetAddress = TargetAddress;
            this.Skills = Skills;
            this.Language = Language;
            this.Priority = Priority;
            
        }
        




        /// <summary>
        /// The target of the route, in the format appropriate given the &#39;targetType&#39;.
        /// </summary>
        /// <value>The target of the route, in the format appropriate given the &#39;targetType&#39;.</value>
        [DataMember(Name="targetAddress", EmitDefaultValue=false)]
        public string TargetAddress { get; set; }



        /// <summary>
        /// The list of skill names to use for routing.
        /// </summary>
        /// <value>The list of skill names to use for routing.</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<string> Skills { get; set; }



        /// <summary>
        /// The language name to use for routing.
        /// </summary>
        /// <value>The language name to use for routing.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// The priority to assign to the conversation for routing.
        /// </summary>
        /// <value>The priority to assign to the conversation for routing.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public long? Priority { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebChatRoutingTarget {\n");

            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  TargetAddress: ").Append(TargetAddress).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(obj as WebChatRoutingTarget);
        }

        /// <summary>
        /// Returns true if WebChatRoutingTarget instances are equal
        /// </summary>
        /// <param name="other">Instance of WebChatRoutingTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebChatRoutingTarget other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TargetType == other.TargetType ||
                    this.TargetType != null &&
                    this.TargetType.Equals(other.TargetType)
                ) &&
                (
                    this.TargetAddress == other.TargetAddress ||
                    this.TargetAddress != null &&
                    this.TargetAddress.Equals(other.TargetAddress)
                ) &&
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
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
                if (this.TargetType != null)
                    hash = hash * 59 + this.TargetType.GetHashCode();

                if (this.TargetAddress != null)
                    hash = hash * 59 + this.TargetAddress.GetHashCode();

                if (this.Skills != null)
                    hash = hash * 59 + this.Skills.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                return hash;
            }
        }
    }

}
