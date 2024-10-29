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
    /// ContentFileResponse
    /// </summary>
    [DataContract]
    public partial class ContentFileResponse :  IEquatable<ContentFileResponse>
    {
        /// <summary>
        /// The file format
        /// </summary>
        /// <value>The file format</value>
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
            /// Enum Pdf for "Pdf"
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf,
            
            /// <summary>
            /// Enum Docx for "Docx"
            /// </summary>
            [EnumMember(Value = "Docx")]
            Docx,
            
            /// <summary>
            /// Enum Doc for "Doc"
            /// </summary>
            [EnumMember(Value = "Doc")]
            Doc
        }
        /// <summary>
        /// The file format
        /// </summary>
        /// <value>The file format</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFileResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentFileResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFileResponse" /> class.
        /// </summary>
        /// <param name="Name">The name of the file (required).</param>
        /// <param name="Type">The file format (required).</param>
        /// <param name="Checksum">The checksum of the file (required).</param>
        /// <param name="Size">The size of the file in bytes (required).</param>
        public ContentFileResponse(string Name = null, TypeEnum? Type = null, string Checksum = null, long? Size = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.Checksum = Checksum;
            this.Size = Size;
            
        }
        


        /// <summary>
        /// The name of the file
        /// </summary>
        /// <value>The name of the file</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// The checksum of the file
        /// </summary>
        /// <value>The checksum of the file</value>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }



        /// <summary>
        /// The size of the file in bytes
        /// </summary>
        /// <value>The size of the file in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentFileResponse {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(obj as ContentFileResponse);
        }

        /// <summary>
        /// Returns true if ContentFileResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentFileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentFileResponse other)
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
                    this.Checksum == other.Checksum ||
                    this.Checksum != null &&
                    this.Checksum.Equals(other.Checksum)
                ) &&
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
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

                if (this.Checksum != null)
                    hash = hash * 59 + this.Checksum.GetHashCode();

                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();

                return hash;
            }
        }
    }

}
