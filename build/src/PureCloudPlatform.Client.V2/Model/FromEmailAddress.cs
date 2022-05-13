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
    /// FromEmailAddress
    /// </summary>
    [DataContract]
    public partial class FromEmailAddress :  IEquatable<FromEmailAddress>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FromEmailAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FromEmailAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FromEmailAddress" /> class.
        /// </summary>
        /// <param name="Domain">The OutboundDomain used for the email address. (required).</param>
        /// <param name="FriendlyName">The friendly name of the email address..</param>
        /// <param name="LocalPart">The local part of the email address..</param>
        public FromEmailAddress(DomainEntityRef Domain = null, string FriendlyName = null, string LocalPart = null)
        {
            this.Domain = Domain;
            this.FriendlyName = FriendlyName;
            this.LocalPart = LocalPart;
            
        }
        


        /// <summary>
        /// The OutboundDomain used for the email address.
        /// </summary>
        /// <value>The OutboundDomain used for the email address.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public DomainEntityRef Domain { get; set; }



        /// <summary>
        /// The friendly name of the email address.
        /// </summary>
        /// <value>The friendly name of the email address.</value>
        [DataMember(Name="friendlyName", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }



        /// <summary>
        /// The local part of the email address.
        /// </summary>
        /// <value>The local part of the email address.</value>
        [DataMember(Name="localPart", EmitDefaultValue=false)]
        public string LocalPart { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FromEmailAddress {\n");

            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  LocalPart: ").Append(LocalPart).Append("\n");
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
            return this.Equals(obj as FromEmailAddress);
        }

        /// <summary>
        /// Returns true if FromEmailAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of FromEmailAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FromEmailAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.FriendlyName == other.FriendlyName ||
                    this.FriendlyName != null &&
                    this.FriendlyName.Equals(other.FriendlyName)
                ) &&
                (
                    this.LocalPart == other.LocalPart ||
                    this.LocalPart != null &&
                    this.LocalPart.Equals(other.LocalPart)
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
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();

                if (this.FriendlyName != null)
                    hash = hash * 59 + this.FriendlyName.GetHashCode();

                if (this.LocalPart != null)
                    hash = hash * 59 + this.LocalPart.GetHashCode();

                return hash;
            }
        }
    }

}
