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
    /// Represents the parsed certificate information.
    /// </summary>
    [DataContract]
    public partial class ParsedCertificate :  IEquatable<ParsedCertificate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParsedCertificate" /> class.
        /// </summary>
        /// <param name="CertificateDetails">The details of the certificates that were parsed correctly..</param>
        public ParsedCertificate(List<CertificateDetails> CertificateDetails = null)
        {
            this.CertificateDetails = CertificateDetails;
            
        }
        


        /// <summary>
        /// The details of the certificates that were parsed correctly.
        /// </summary>
        /// <value>The details of the certificates that were parsed correctly.</value>
        [DataMember(Name="certificateDetails", EmitDefaultValue=false)]
        public List<CertificateDetails> CertificateDetails { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParsedCertificate {\n");

            sb.Append("  CertificateDetails: ").Append(CertificateDetails).Append("\n");
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
            return this.Equals(obj as ParsedCertificate);
        }

        /// <summary>
        /// Returns true if ParsedCertificate instances are equal
        /// </summary>
        /// <param name="other">Instance of ParsedCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParsedCertificate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CertificateDetails == other.CertificateDetails ||
                    this.CertificateDetails != null &&
                    this.CertificateDetails.SequenceEqual(other.CertificateDetails)
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
                if (this.CertificateDetails != null)
                    hash = hash * 59 + this.CertificateDetails.GetHashCode();

                return hash;
            }
        }
    }

}
