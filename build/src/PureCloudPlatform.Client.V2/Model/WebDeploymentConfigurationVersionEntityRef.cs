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
    /// WebDeploymentConfigurationVersionEntityRef
    /// </summary>
    [DataContract]
    public partial class WebDeploymentConfigurationVersionEntityRef :  IEquatable<WebDeploymentConfigurationVersionEntityRef>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersionEntityRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebDeploymentConfigurationVersionEntityRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentConfigurationVersionEntityRef" /> class.
        /// </summary>
        /// <param name="Id">The configuration version ID (required).</param>
        /// <param name="Name">The configuration version name.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="Version">The version of the configuration (required).</param>
        public WebDeploymentConfigurationVersionEntityRef(string Id = null, string Name = null, string SelfUri = null, string Version = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SelfUri = SelfUri;
            this.Version = Version;
            
        }
        


        /// <summary>
        /// The configuration version ID
        /// </summary>
        /// <value>The configuration version ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The configuration version name
        /// </summary>
        /// <value>The configuration version name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// The version of the configuration
        /// </summary>
        /// <value>The version of the configuration</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentConfigurationVersionEntityRef {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as WebDeploymentConfigurationVersionEntityRef);
        }

        /// <summary>
        /// Returns true if WebDeploymentConfigurationVersionEntityRef instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentConfigurationVersionEntityRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentConfigurationVersionEntityRef other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                return hash;
            }
        }
    }

}
