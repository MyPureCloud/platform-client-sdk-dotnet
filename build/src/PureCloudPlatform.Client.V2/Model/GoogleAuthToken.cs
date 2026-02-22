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
    /// GoogleAuthToken
    /// </summary>
    [DataContract]
    public partial class GoogleAuthToken :  IEquatable<GoogleAuthToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthToken" /> class.
        /// </summary>
        public GoogleAuthToken()
        {
            
        }
        


        /// <summary>
        /// ID of the Google OAuth 2 access token. The token cannot be accessed via Genesys API, only referenced by this property. When the token is not referenced by any integration, it is deleted after 24 hours.
        /// </summary>
        /// <value>ID of the Google OAuth 2 access token. The token cannot be accessed via Genesys API, only referenced by this property. When the token is not referenced by any integration, it is deleted after 24 hours.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// ID of the Genesys-owned Google API client
        /// </summary>
        /// <value>ID of the Genesys-owned Google API client</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; private set; }



        /// <summary>
        /// Google API authorization scopes that have been granted to the Genesys-owned Google API client
        /// </summary>
        /// <value>Google API authorization scopes that have been granted to the Genesys-owned Google API client</value>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public List<string> Scopes { get; private set; }



        /// <summary>
        /// Date this token was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date this token was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// User reference that created this Integration
        /// </summary>
        /// <value>User reference that created this Integration</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public DomainEntityRef CreatedBy { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleAuthToken {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(obj as GoogleAuthToken);
        }

        /// <summary>
        /// Returns true if GoogleAuthToken instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleAuthToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleAuthToken other)
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
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) &&
                (
                    this.Scopes == other.Scopes ||
                    this.Scopes != null &&
                    this.Scopes.SequenceEqual(other.Scopes)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
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

                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();

                if (this.Scopes != null)
                    hash = hash * 59 + this.Scopes.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                return hash;
            }
        }
    }

}
