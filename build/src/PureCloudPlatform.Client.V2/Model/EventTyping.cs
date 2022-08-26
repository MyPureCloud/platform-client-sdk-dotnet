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
    /// A Typing event.
    /// </summary>
    [DataContract]
    public partial class EventTyping :  IEquatable<EventTyping>
    {
        /// <summary>
        /// Describes the type of Typing event.
        /// </summary>
        /// <value>Describes the type of Typing event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum On for "On"
            /// </summary>
            [EnumMember(Value = "On")]
            On
        }
        /// <summary>
        /// Describes the type of Typing event.
        /// </summary>
        /// <value>Describes the type of Typing event.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventTyping" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventTyping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventTyping" /> class.
        /// </summary>
        /// <param name="Type">Describes the type of Typing event. (required).</param>
        public EventTyping(TypeEnum? Type = null)
        {
            this.Type = Type;
            
        }
        




        /// <summary>
        /// The duration of the Typing event in milliseconds.
        /// </summary>
        /// <value>The duration of the Typing event in milliseconds.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventTyping {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(obj as EventTyping);
        }

        /// <summary>
        /// Returns true if EventTyping instances are equal
        /// </summary>
        /// <param name="other">Instance of EventTyping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventTyping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();

                return hash;
            }
        }
    }

}
