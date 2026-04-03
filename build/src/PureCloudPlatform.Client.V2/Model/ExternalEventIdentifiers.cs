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
    /// ExternalEventIdentifiers
    /// </summary>
    [DataContract]
    public partial class ExternalEventIdentifiers :  IEquatable<ExternalEventIdentifiers>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventIdentifiers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalEventIdentifiers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalEventIdentifiers" /> class.
        /// </summary>
        /// <param name="ExternalIds">The list of identifiers of the contact (required).</param>
        public ExternalEventIdentifiers(List<ExternalEventExternalId> ExternalIds = null)
        {
            this.ExternalIds = ExternalIds;
            
        }
        


        /// <summary>
        /// The list of identifiers of the contact
        /// </summary>
        /// <value>The list of identifiers of the contact</value>
        [DataMember(Name="externalIds", EmitDefaultValue=false)]
        public List<ExternalEventExternalId> ExternalIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalEventIdentifiers {\n");

            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
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
            return this.Equals(obj as ExternalEventIdentifiers);
        }

        /// <summary>
        /// Returns true if ExternalEventIdentifiers instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalEventIdentifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalEventIdentifiers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExternalIds == other.ExternalIds ||
                    this.ExternalIds != null &&
                    this.ExternalIds.SequenceEqual(other.ExternalIds)
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
                if (this.ExternalIds != null)
                    hash = hash * 59 + this.ExternalIds.GetHashCode();

                return hash;
            }
        }
    }

}
