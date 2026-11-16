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
    /// DeleteVerifierResponse
    /// </summary>
    [DataContract]
    public partial class DeleteVerifierResponse :  IEquatable<DeleteVerifierResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVerifierResponse" /> class.
        /// </summary>
        /// <param name="DefaultVerifier">The verifier that is now the default, or null if no default verifier remains..</param>
        public DeleteVerifierResponse(Verifier DefaultVerifier = null)
        {
            this.DefaultVerifier = DefaultVerifier;
            
        }
        


        /// <summary>
        /// The verifier that is now the default, or null if no default verifier remains.
        /// </summary>
        /// <value>The verifier that is now the default, or null if no default verifier remains.</value>
        [DataMember(Name="defaultVerifier", EmitDefaultValue=false)]
        public Verifier DefaultVerifier { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteVerifierResponse {\n");

            sb.Append("  DefaultVerifier: ").Append(DefaultVerifier).Append("\n");
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
            return this.Equals(obj as DeleteVerifierResponse);
        }

        /// <summary>
        /// Returns true if DeleteVerifierResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteVerifierResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteVerifierResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DefaultVerifier == other.DefaultVerifier ||
                    this.DefaultVerifier != null &&
                    this.DefaultVerifier.Equals(other.DefaultVerifier)
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
                if (this.DefaultVerifier != null)
                    hash = hash * 59 + this.DefaultVerifier.GetHashCode();

                return hash;
            }
        }
    }

}
