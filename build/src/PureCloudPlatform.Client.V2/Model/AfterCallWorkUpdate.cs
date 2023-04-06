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
    /// AfterCallWorkUpdate
    /// </summary>
    [DataContract]
    public partial class AfterCallWorkUpdate :  IEquatable<AfterCallWorkUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AfterCallWorkUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AfterCallWorkUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AfterCallWorkUpdate" /> class.
        /// </summary>
        /// <param name="AfterCallWorkRequired">Indicates whether or not after-call work must be completed for the communication. Can only be updated for connected communications. (required).</param>
        public AfterCallWorkUpdate(bool? AfterCallWorkRequired = null)
        {
            this.AfterCallWorkRequired = AfterCallWorkRequired;
            
        }
        


        /// <summary>
        /// Indicates whether or not after-call work must be completed for the communication. Can only be updated for connected communications.
        /// </summary>
        /// <value>Indicates whether or not after-call work must be completed for the communication. Can only be updated for connected communications.</value>
        [DataMember(Name="afterCallWorkRequired", EmitDefaultValue=false)]
        public bool? AfterCallWorkRequired { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AfterCallWorkUpdate {\n");

            sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
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
            return this.Equals(obj as AfterCallWorkUpdate);
        }

        /// <summary>
        /// Returns true if AfterCallWorkUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AfterCallWorkUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AfterCallWorkUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AfterCallWorkRequired == other.AfterCallWorkRequired ||
                    this.AfterCallWorkRequired != null &&
                    this.AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
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
                if (this.AfterCallWorkRequired != null)
                    hash = hash * 59 + this.AfterCallWorkRequired.GetHashCode();

                return hash;
            }
        }
    }

}
