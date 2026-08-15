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
    /// ArchitectJobMessage
    /// </summary>
    [DataContract]
    public partial class ArchitectJobMessage :  IEquatable<ArchitectJobMessage>
    {
        /// <summary>
        /// The message type.
        /// </summary>
        /// <value>The message type.</value>
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
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Warning for "Warning"
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The message type.
        /// </summary>
        /// <value>The message type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectJobMessage" /> class.
        /// </summary>
        public ArchitectJobMessage()
        {
            
        }
        


        /// <summary>
        /// The DateTime when the message was generated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The DateTime when the message was generated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime? DateTime { get; private set; }





        /// <summary>
        /// The text of the message.
        /// </summary>
        /// <value>The text of the message.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; private set; }



        /// <summary>
        /// Structured information about the message, absent from the large majority of messages. Populated only by publish jobs, and only on errors raised when a Genesys Cloud entity reference in the flow definition could not be resolved. Export and validate jobs resolve an existing flow by id rather than processing a flow definition, so they never return it. Holds one entry per request captured within the failing lookup, ordered oldest request first, and more than one entry is normal. Entries for requests that succeeded are included alongside the request that failed. A lookup failure usually also produces a separate message with similar text and no details.
        /// </summary>
        /// <value>Structured information about the message, absent from the large majority of messages. Populated only by publish jobs, and only on errors raised when a Genesys Cloud entity reference in the flow definition could not be resolved. Export and validate jobs resolve an existing flow by id rather than processing a flow definition, so they never return it. Holds one entry per request captured within the failing lookup, ordered oldest request first, and more than one entry is normal. Entries for requests that succeeded are included alongside the request that failed. A lookup failure usually also produces a separate message with similar text and no details.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<ArchitectJobMessageDetail> Details { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectJobMessage {\n");

            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as ArchitectJobMessage);
        }

        /// <summary>
        /// Returns true if ArchitectJobMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectJobMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectJobMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                return hash;
            }
        }
    }

}
