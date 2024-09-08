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
    /// AssistantQueue
    /// </summary>
    [DataContract]
    public partial class AssistantQueue :  IEquatable<AssistantQueue>
    {
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Message for "Message"
            /// </summary>
            [EnumMember(Value = "Message")]
            Message
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantQueue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssistantQueue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantQueue" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the queue. (required).</param>
        /// <param name="MediaTypes">List of media Types in which the assistant is activated for this queue. (required).</param>
        public AssistantQueue(string Id = null, List<MediaTypesEnum> MediaTypes = null)
        {
            this.Id = Id;
            this.MediaTypes = MediaTypes;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the queue.
        /// </summary>
        /// <value>The globally unique identifier for the queue.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// List of media Types in which the assistant is activated for this queue.
        /// </summary>
        /// <value>List of media Types in which the assistant is activated for this queue.</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }



        /// <summary>
        /// Assistant to which the queue is assigned.
        /// </summary>
        /// <value>Assistant to which the queue is assigned.</value>
        [DataMember(Name="assistant", EmitDefaultValue=false)]
        public Assistant Assistant { get; private set; }



        /// <summary>
        /// Date when the assistant queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the assistant queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Date when the assistant queue was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the assistant queue was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistantQueue {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  Assistant: ").Append(Assistant).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as AssistantQueue);
        }

        /// <summary>
        /// Returns true if AssistantQueue instances are equal
        /// </summary>
        /// <param name="other">Instance of AssistantQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssistantQueue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.Assistant == other.Assistant ||
                    this.Assistant != null &&
                    this.Assistant.Equals(other.Assistant)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();

                if (this.Assistant != null)
                    hash = hash * 59 + this.Assistant.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
