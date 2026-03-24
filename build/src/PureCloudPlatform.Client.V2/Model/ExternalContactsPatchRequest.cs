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
    /// ExternalContactsPatchRequest
    /// </summary>
    [DataContract]
    public partial class ExternalContactsPatchRequest :  IEquatable<ExternalContactsPatchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsPatchRequest" /> class.
        /// </summary>
        /// <param name="Changes">A list of changes to apply to the provided contact entity.</param>
        public ExternalContactsPatchRequest(List<ContactsPatchChange> Changes = null)
        {
            this.Changes = Changes;
            
        }
        


        /// <summary>
        /// A list of changes to apply to the provided contact entity
        /// </summary>
        /// <value>A list of changes to apply to the provided contact entity</value>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<ContactsPatchChange> Changes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsPatchRequest {\n");

            sb.Append("  Changes: ").Append(Changes).Append("\n");
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
            return this.Equals(obj as ExternalContactsPatchRequest);
        }

        /// <summary>
        /// Returns true if ExternalContactsPatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsPatchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
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
                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();

                return hash;
            }
        }
    }

}
