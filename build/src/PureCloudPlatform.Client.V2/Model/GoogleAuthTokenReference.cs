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
    /// GoogleAuthTokenReference
    /// </summary>
    [DataContract]
    public partial class GoogleAuthTokenReference :  IEquatable<GoogleAuthTokenReference>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthTokenReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GoogleAuthTokenReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthTokenReference" /> class.
        /// </summary>
        /// <param name="Id">ID of the Google OAuth 2 access token. The token cannot be accessed via Genesys API, only referenced by this property. When the token is not referenced by any integration, it is deleted after 24 hours. (required).</param>
        public GoogleAuthTokenReference(string Id = null)
        {
            this.Id = Id;
            
        }
        


        /// <summary>
        /// ID of the Google OAuth 2 access token. The token cannot be accessed via Genesys API, only referenced by this property. When the token is not referenced by any integration, it is deleted after 24 hours.
        /// </summary>
        /// <value>ID of the Google OAuth 2 access token. The token cannot be accessed via Genesys API, only referenced by this property. When the token is not referenced by any integration, it is deleted after 24 hours.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleAuthTokenReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as GoogleAuthTokenReference);
        }

        /// <summary>
        /// Returns true if GoogleAuthTokenReference instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleAuthTokenReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleAuthTokenReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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

                return hash;
            }
        }
    }

}
