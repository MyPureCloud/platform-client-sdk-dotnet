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
    /// Attributes on an element in a journey view
    /// </summary>
    [DataContract]
    public partial class JourneyViewElementAttributes :  IEquatable<JourneyViewElementAttributes>
    {
        /// <summary>
        /// The type of the element (e.g. Event)
        /// </summary>
        /// <value>The type of the element (e.g. Event)</value>
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
            /// Enum Event for "Event"
            /// </summary>
            [EnumMember(Value = "Event")]
            Event
        }
        /// <summary>
        /// The type of the element (e.g. Event)
        /// </summary>
        /// <value>The type of the element (e.g. Event)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElementAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyViewElementAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyViewElementAttributes" /> class.
        /// </summary>
        /// <param name="Type">The type of the element (e.g. Event) (required).</param>
        /// <param name="Id">The identifier for the element based on its type.</param>
        /// <param name="Source">The source for the element (e.g. IVR, Voice, Chat). Used for informational purposes only.</param>
        public JourneyViewElementAttributes(TypeEnum? Type = null, string Id = null, string Source = null)
        {
            this.Type = Type;
            this.Id = Id;
            this.Source = Source;
            
        }
        




        /// <summary>
        /// The identifier for the element based on its type
        /// </summary>
        /// <value>The identifier for the element based on its type</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The source for the element (e.g. IVR, Voice, Chat). Used for informational purposes only
        /// </summary>
        /// <value>The source for the element (e.g. IVR, Voice, Chat). Used for informational purposes only</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyViewElementAttributes {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as JourneyViewElementAttributes);
        }

        /// <summary>
        /// Returns true if JourneyViewElementAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyViewElementAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyViewElementAttributes other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                return hash;
            }
        }
    }

}
