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
    /// Reference to supported content profile associated with the integration
    /// </summary>
    [DataContract]
    public partial class SupportedContentReference :  IEquatable<SupportedContentReference>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedContentReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportedContentReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedContentReference" /> class.
        /// </summary>
        /// <param name="Id">The SupportedContent unique identifier associated with this integration (required).</param>
        public SupportedContentReference(string Id = null)
        {
            this.Id = Id;
            
        }
        


        /// <summary>
        /// The SupportedContent unique identifier associated with this integration
        /// </summary>
        /// <value>The SupportedContent unique identifier associated with this integration</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The SupportedContent profile name
        /// </summary>
        /// <value>The SupportedContent profile name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }



        /// <summary>
        /// The SupportedContent profile URI
        /// </summary>
        /// <value>The SupportedContent profile URI</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// Media types definition for the supported content
        /// </summary>
        /// <value>Media types definition for the supported content</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public MediaTypes MediaTypes { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportedContentReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
            return this.Equals(obj as SupportedContentReference);
        }

        /// <summary>
        /// Returns true if SupportedContentReference instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportedContentReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedContentReference other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.Equals(other.MediaTypes)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();

                return hash;
            }
        }
    }

}
