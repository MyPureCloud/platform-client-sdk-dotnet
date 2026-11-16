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
    /// AuthenticationExtensionsPRFOutputs
    /// </summary>
    [DataContract]
    public partial class AuthenticationExtensionsPRFOutputs :  IEquatable<AuthenticationExtensionsPRFOutputs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationExtensionsPRFOutputs" /> class.
        /// </summary>
        /// <param name="Enabled">Whether the PRF extension was enabled for this ceremony..</param>
        /// <param name="Results">PRF evaluation results keyed by input name (values are base64url-encoded octets)..</param>
        public AuthenticationExtensionsPRFOutputs(bool? Enabled = null, Dictionary<string, string> Results = null)
        {
            this.Enabled = Enabled;
            this.Results = Results;
            
        }
        


        /// <summary>
        /// Whether the PRF extension was enabled for this ceremony.
        /// </summary>
        /// <value>Whether the PRF extension was enabled for this ceremony.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// PRF evaluation results keyed by input name (values are base64url-encoded octets).
        /// </summary>
        /// <value>PRF evaluation results keyed by input name (values are base64url-encoded octets).</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public Dictionary<string, string> Results { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationExtensionsPRFOutputs {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as AuthenticationExtensionsPRFOutputs);
        }

        /// <summary>
        /// Returns true if AuthenticationExtensionsPRFOutputs instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticationExtensionsPRFOutputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationExtensionsPRFOutputs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                return hash;
            }
        }
    }

}
