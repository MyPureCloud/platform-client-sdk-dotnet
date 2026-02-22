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
    /// GoogleOAuthSettingsResponse
    /// </summary>
    [DataContract]
    public partial class GoogleOAuthSettingsResponse :  IEquatable<GoogleOAuthSettingsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleOAuthSettingsResponse" /> class.
        /// </summary>
        public GoogleOAuthSettingsResponse()
        {
            
        }
        


        /// <summary>
        /// ID of the Genesys-owned Google API client
        /// </summary>
        /// <value>ID of the Genesys-owned Google API client</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; private set; }



        /// <summary>
        /// Google API authorization scopes that must be granted to the Genesys-owned Google API client
        /// </summary>
        /// <value>Google API authorization scopes that must be granted to the Genesys-owned Google API client</value>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public List<string> Scopes { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GoogleOAuthSettingsResponse {\n");

            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(obj as GoogleOAuthSettingsResponse);
        }

        /// <summary>
        /// Returns true if GoogleOAuthSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GoogleOAuthSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoogleOAuthSettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) &&
                (
                    this.Scopes == other.Scopes ||
                    this.Scopes != null &&
                    this.Scopes.SequenceEqual(other.Scopes)
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
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();

                if (this.Scopes != null)
                    hash = hash * 59 + this.Scopes.GetHashCode();

                return hash;
            }
        }
    }

}
