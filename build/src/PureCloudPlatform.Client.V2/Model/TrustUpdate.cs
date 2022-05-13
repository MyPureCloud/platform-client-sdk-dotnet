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
    /// TrustUpdate
    /// </summary>
    [DataContract]
    public partial class TrustUpdate :  IEquatable<TrustUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TrustUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrustUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustUpdate" /> class.
        /// </summary>
        /// <param name="Enabled">If disabled no trustee user will have access, even if they were previously added. (required).</param>
        /// <param name="DateExpired">The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public TrustUpdate(bool? Enabled = null, DateTime? DateExpired = null)
        {
            this.Enabled = Enabled;
            this.DateExpired = DateExpired;
            
        }
        


        /// <summary>
        /// If disabled no trustee user will have access, even if they were previously added.
        /// </summary>
        /// <value>If disabled no trustee user will have access, even if they were previously added.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateExpired", EmitDefaultValue=false)]
        public DateTime? DateExpired { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustUpdate {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
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
            return this.Equals(obj as TrustUpdate);
        }

        /// <summary>
        /// Returns true if TrustUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TrustUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrustUpdate other)
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
                    this.DateExpired == other.DateExpired ||
                    this.DateExpired != null &&
                    this.DateExpired.Equals(other.DateExpired)
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

                if (this.DateExpired != null)
                    hash = hash * 59 + this.DateExpired.GetHashCode();

                return hash;
            }
        }
    }

}
