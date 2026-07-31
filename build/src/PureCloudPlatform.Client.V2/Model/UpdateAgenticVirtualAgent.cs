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
    /// UpdateAgenticVirtualAgent
    /// </summary>
    [DataContract]
    public partial class UpdateAgenticVirtualAgent :  IEquatable<UpdateAgenticVirtualAgent>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgenticVirtualAgent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAgenticVirtualAgent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgenticVirtualAgent" /> class.
        /// </summary>
        /// <param name="Name">The name of the virtual agent. (required).</param>
        /// <param name="ImageUri">The URI of the image for the virtual agent..</param>
        public UpdateAgenticVirtualAgent(string Name = null, string ImageUri = null)
        {
            this.Name = Name;
            this.ImageUri = ImageUri;
            
        }
        


        /// <summary>
        /// The name of the virtual agent.
        /// </summary>
        /// <value>The name of the virtual agent.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The URI of the image for the virtual agent.
        /// </summary>
        /// <value>The URI of the image for the virtual agent.</value>
        [DataMember(Name="imageUri", EmitDefaultValue=false)]
        public string ImageUri { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgenticVirtualAgent {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
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
            return this.Equals(obj as UpdateAgenticVirtualAgent);
        }

        /// <summary>
        /// Returns true if UpdateAgenticVirtualAgent instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAgenticVirtualAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAgenticVirtualAgent other)
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
                    this.ImageUri == other.ImageUri ||
                    this.ImageUri != null &&
                    this.ImageUri.Equals(other.ImageUri)
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

                if (this.ImageUri != null)
                    hash = hash * 59 + this.ImageUri.GetHashCode();

                return hash;
            }
        }
    }

}
