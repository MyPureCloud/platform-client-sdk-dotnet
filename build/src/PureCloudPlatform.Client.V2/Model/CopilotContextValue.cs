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
    /// CopilotContextValue
    /// </summary>
    [DataContract]
    public partial class CopilotContextValue :  IEquatable<CopilotContextValue>
    {
        /// <summary>
        /// Type of the context.
        /// </summary>
        /// <value>Type of the context.</value>
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
            /// Enum Participantdata for "ParticipantData"
            /// </summary>
            [EnumMember(Value = "ParticipantData")]
            Participantdata
        }
        /// <summary>
        /// Type of the context.
        /// </summary>
        /// <value>Type of the context.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotContextValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopilotContextValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotContextValue" /> class.
        /// </summary>
        /// <param name="Name">Name of the context. (required).</param>
        /// <param name="Type">Type of the context. (required).</param>
        /// <param name="ParticipantDataProperties">Participant data properties..</param>
        public CopilotContextValue(string Name = null, TypeEnum? Type = null, ParticipantDataProperties ParticipantDataProperties = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.ParticipantDataProperties = ParticipantDataProperties;
            
        }
        


        /// <summary>
        /// Name of the context.
        /// </summary>
        /// <value>Name of the context.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Participant data properties.
        /// </summary>
        /// <value>Participant data properties.</value>
        [DataMember(Name="participantDataProperties", EmitDefaultValue=false)]
        public ParticipantDataProperties ParticipantDataProperties { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopilotContextValue {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ParticipantDataProperties: ").Append(ParticipantDataProperties).Append("\n");
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
            return this.Equals(obj as CopilotContextValue);
        }

        /// <summary>
        /// Returns true if CopilotContextValue instances are equal
        /// </summary>
        /// <param name="other">Instance of CopilotContextValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopilotContextValue other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ParticipantDataProperties == other.ParticipantDataProperties ||
                    this.ParticipantDataProperties != null &&
                    this.ParticipantDataProperties.Equals(other.ParticipantDataProperties)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ParticipantDataProperties != null)
                    hash = hash * 59 + this.ParticipantDataProperties.GetHashCode();

                return hash;
            }
        }
    }

}
