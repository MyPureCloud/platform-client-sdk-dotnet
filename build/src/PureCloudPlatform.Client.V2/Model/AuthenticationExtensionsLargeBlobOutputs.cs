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
    /// AuthenticationExtensionsLargeBlobOutputs
    /// </summary>
    [DataContract]
    public partial class AuthenticationExtensionsLargeBlobOutputs :  IEquatable<AuthenticationExtensionsLargeBlobOutputs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExtensionsLargeBlobOutputs" /> class.
        /// </summary>
        /// <param name="Supported">Whether large blob support was negotiated for this credential..</param>
        /// <param name="Blob">Whether a large blob was read or written during the ceremony..</param>
        public AuthenticationExtensionsLargeBlobOutputs(bool? Supported = null, bool? Blob = null)
        {
            this.Supported = Supported;
            this.Blob = Blob;
            
        }
        


        /// <summary>
        /// Whether large blob support was negotiated for this credential.
        /// </summary>
        /// <value>Whether large blob support was negotiated for this credential.</value>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public bool? Supported { get; set; }



        /// <summary>
        /// Whether a large blob was read or written during the ceremony.
        /// </summary>
        /// <value>Whether a large blob was read or written during the ceremony.</value>
        [DataMember(Name="blob", EmitDefaultValue=false)]
        public bool? Blob { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationExtensionsLargeBlobOutputs {\n");

            sb.Append("  Supported: ").Append(Supported).Append("\n");
            sb.Append("  Blob: ").Append(Blob).Append("\n");
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
            return this.Equals(obj as AuthenticationExtensionsLargeBlobOutputs);
        }

        /// <summary>
        /// Returns true if AuthenticationExtensionsLargeBlobOutputs instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticationExtensionsLargeBlobOutputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationExtensionsLargeBlobOutputs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Supported == other.Supported ||
                    this.Supported != null &&
                    this.Supported.Equals(other.Supported)
                ) &&
                (
                    this.Blob == other.Blob ||
                    this.Blob != null &&
                    this.Blob.Equals(other.Blob)
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
                if (this.Supported != null)
                    hash = hash * 59 + this.Supported.GetHashCode();

                if (this.Blob != null)
                    hash = hash * 59 + this.Blob.GetHashCode();

                return hash;
            }
        }
    }

}
