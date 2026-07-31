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
    /// CredentialDescriptor
    /// </summary>
    [DataContract]
    public partial class CredentialDescriptor :  IEquatable<CredentialDescriptor>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CredentialDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialDescriptor" /> class.
        /// </summary>
        /// <param name="Type">The credential type (e.g., &#39;public-key&#39;). (required).</param>
        /// <param name="Id">The credential identifier (base64url-encoded). (required).</param>
        /// <param name="Transports">Hints regarding which transports the credential supports..</param>
        public CredentialDescriptor(string Type = null, string Id = null, List<string> Transports = null)
        {
            this.Type = Type;
            this.Id = Id;
            this.Transports = Transports;
            
        }
        


        /// <summary>
        /// The credential type (e.g., &#39;public-key&#39;).
        /// </summary>
        /// <value>The credential type (e.g., &#39;public-key&#39;).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// The credential identifier (base64url-encoded).
        /// </summary>
        /// <value>The credential identifier (base64url-encoded).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Hints regarding which transports the credential supports.
        /// </summary>
        /// <value>Hints regarding which transports the credential supports.</value>
        [DataMember(Name="transports", EmitDefaultValue=false)]
        public List<string> Transports { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialDescriptor {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Transports: ").Append(Transports).Append("\n");
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
            return this.Equals(obj as CredentialDescriptor);
        }

        /// <summary>
        /// Returns true if CredentialDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of CredentialDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialDescriptor other)
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
                    this.Transports == other.Transports ||
                    this.Transports != null &&
                    this.Transports.SequenceEqual(other.Transports)
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

                if (this.Transports != null)
                    hash = hash * 59 + this.Transports.GetHashCode();

                return hash;
            }
        }
    }

}
