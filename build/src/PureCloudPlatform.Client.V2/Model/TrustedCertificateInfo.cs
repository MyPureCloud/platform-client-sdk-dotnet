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
    /// TrustedCertificateInfo
    /// </summary>
    [DataContract]
    public partial class TrustedCertificateInfo :  IEquatable<TrustedCertificateInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedCertificateInfo" /> class.
        /// </summary>
        /// <param name="Description">The description of the certificate.</param>
        /// <param name="SerialNumber">The serial number of the certificate.</param>
        /// <param name="Signature">The signature of the certificate.</param>
        public TrustedCertificateInfo(string Description = null, string SerialNumber = null, string Signature = null)
        {
            this.Description = Description;
            this.SerialNumber = SerialNumber;
            this.Signature = Signature;
            
        }
        


        /// <summary>
        /// The description of the certificate
        /// </summary>
        /// <value>The description of the certificate</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The serial number of the certificate
        /// </summary>
        /// <value>The serial number of the certificate</value>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }



        /// <summary>
        /// The signature of the certificate
        /// </summary>
        /// <value>The signature of the certificate</value>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustedCertificateInfo {\n");

            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(obj as TrustedCertificateInfo);
        }

        /// <summary>
        /// Returns true if TrustedCertificateInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustedCertificateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustedCertificateInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.SerialNumber == other.SerialNumber ||
                    this.SerialNumber != null &&
                    this.SerialNumber.Equals(other.SerialNumber)
                ) &&
                (
                    this.Signature == other.Signature ||
                    this.Signature != null &&
                    this.Signature.Equals(other.Signature)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.SerialNumber != null)
                    hash = hash * 59 + this.SerialNumber.GetHashCode();

                if (this.Signature != null)
                    hash = hash * 59 + this.Signature.GetHashCode();

                return hash;
            }
        }
    }

}
