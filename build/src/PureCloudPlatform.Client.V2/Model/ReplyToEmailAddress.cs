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
    /// ReplyToEmailAddress
    /// </summary>
    [DataContract]
    public partial class ReplyToEmailAddress :  IEquatable<ReplyToEmailAddress>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyToEmailAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReplyToEmailAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyToEmailAddress" /> class.
        /// </summary>
        /// <param name="Domain">The InboundDomain used for the email address. (required).</param>
        /// <param name="Route">The InboundRoute used for the email address. (required).</param>
        public ReplyToEmailAddress(DomainEntityRef Domain = null, DomainEntityRef Route = null)
        {
            this.Domain = Domain;
            this.Route = Route;
            
        }
        


        /// <summary>
        /// The InboundDomain used for the email address.
        /// </summary>
        /// <value>The InboundDomain used for the email address.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public DomainEntityRef Domain { get; set; }



        /// <summary>
        /// The InboundRoute used for the email address.
        /// </summary>
        /// <value>The InboundRoute used for the email address.</value>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public DomainEntityRef Route { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplyToEmailAddress {\n");

            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
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
            return this.Equals(obj as ReplyToEmailAddress);
        }

        /// <summary>
        /// Returns true if ReplyToEmailAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ReplyToEmailAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplyToEmailAddress other)
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
                    this.Route == other.Route ||
                    this.Route != null &&
                    this.Route.Equals(other.Route)
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

                if (this.Route != null)
                    hash = hash * 59 + this.Route.GetHashCode();

                return hash;
            }
        }
    }

}
