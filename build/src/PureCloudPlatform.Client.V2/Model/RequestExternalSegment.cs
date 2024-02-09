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
    /// RequestExternalSegment
    /// </summary>
    [DataContract]
    public partial class RequestExternalSegment :  IEquatable<RequestExternalSegment>
    {
        /// <summary>
        /// The external system where the segment originates from.
        /// </summary>
        /// <value>The external system where the segment originates from.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Adobeexperienceplatform for "AdobeExperiencePlatform"
            /// </summary>
            [EnumMember(Value = "AdobeExperiencePlatform")]
            Adobeexperienceplatform,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom
        }
        /// <summary>
        /// The external system where the segment originates from.
        /// </summary>
        /// <value>The external system where the segment originates from.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestExternalSegment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestExternalSegment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestExternalSegment" /> class.
        /// </summary>
        /// <param name="Id">Identifier for the external segment in the system where it originates from. (required).</param>
        /// <param name="Name">Name for the external segment in the system where it originates from. (required).</param>
        /// <param name="Source">The external system where the segment originates from..</param>
        public RequestExternalSegment(string Id = null, string Name = null, SourceEnum? Source = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Source = Source;
            
        }
        


        /// <summary>
        /// Identifier for the external segment in the system where it originates from.
        /// </summary>
        /// <value>Identifier for the external segment in the system where it originates from.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Name for the external segment in the system where it originates from.
        /// </summary>
        /// <value>Name for the external segment in the system where it originates from.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestExternalSegment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as RequestExternalSegment);
        }

        /// <summary>
        /// Returns true if RequestExternalSegment instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestExternalSegment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestExternalSegment other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                return hash;
            }
        }
    }

}
