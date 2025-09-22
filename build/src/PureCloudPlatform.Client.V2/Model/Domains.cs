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
    /// The domain list settings.
    /// </summary>
    [DataContract]
    public partial class Domains :  IEquatable<Domains>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Domains" /> class.
        /// </summary>
        /// <param name="AuthorizedDomains">The authorized domains settings for email processing..</param>
        public Domains(AuthorizedDomains AuthorizedDomains = null)
        {
            this.AuthorizedDomains = AuthorizedDomains;
            
        }
        


        /// <summary>
        /// The authorized domains settings for email processing.
        /// </summary>
        /// <value>The authorized domains settings for email processing.</value>
        [DataMember(Name="authorizedDomains", EmitDefaultValue=false)]
        public AuthorizedDomains AuthorizedDomains { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Domains {\n");

            sb.Append("  AuthorizedDomains: ").Append(AuthorizedDomains).Append("\n");
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
            return this.Equals(obj as Domains);
        }

        /// <summary>
        /// Returns true if Domains instances are equal
        /// </summary>
        /// <param name="other">Instance of Domains to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Domains other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AuthorizedDomains == other.AuthorizedDomains ||
                    this.AuthorizedDomains != null &&
                    this.AuthorizedDomains.Equals(other.AuthorizedDomains)
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
                if (this.AuthorizedDomains != null)
                    hash = hash * 59 + this.AuthorizedDomains.GetHashCode();

                return hash;
            }
        }
    }

}
