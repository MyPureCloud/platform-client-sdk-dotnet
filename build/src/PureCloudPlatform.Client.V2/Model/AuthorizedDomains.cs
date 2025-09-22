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
    /// Domains authorized for email processing.
    /// </summary>
    [DataContract]
    public partial class AuthorizedDomains :  IEquatable<AuthorizedDomains>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedDomains" /> class.
        /// </summary>
        /// <param name="Outbound">List of authorized domains for outbound send..</param>
        public AuthorizedDomains(List<string> Outbound = null)
        {
            this.Outbound = Outbound;
            
        }
        


        /// <summary>
        /// List of authorized domains for outbound send.
        /// </summary>
        /// <value>List of authorized domains for outbound send.</value>
        [DataMember(Name="outbound", EmitDefaultValue=false)]
        public List<string> Outbound { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizedDomains {\n");

            sb.Append("  Outbound: ").Append(Outbound).Append("\n");
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
            return this.Equals(obj as AuthorizedDomains);
        }

        /// <summary>
        /// Returns true if AuthorizedDomains instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthorizedDomains to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizedDomains other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Outbound == other.Outbound ||
                    this.Outbound != null &&
                    this.Outbound.SequenceEqual(other.Outbound)
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
                if (this.Outbound != null)
                    hash = hash * 59 + this.Outbound.GetHashCode();

                return hash;
            }
        }
    }

}
