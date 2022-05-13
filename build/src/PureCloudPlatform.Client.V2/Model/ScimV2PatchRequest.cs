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
    /// Defines a SCIM PATCH request. See section 3.5.2 \&quot;Modifying with PATCH\&quot; in RFC 7644 for details.
    /// </summary>
    [DataContract]
    public partial class ScimV2PatchRequest :  IEquatable<ScimV2PatchRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2PatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScimV2PatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2PatchRequest" /> class.
        /// </summary>
        /// <param name="Schemas">The list of schemas used in the PATCH request. (required).</param>
        /// <param name="Operations">The list of operations to perform for the PATCH request..</param>
        public ScimV2PatchRequest(List<string> Schemas = null, List<ScimV2PatchOperation> Operations = null)
        {
            this.Schemas = Schemas;
            this.Operations = Operations;
            
        }
        


        /// <summary>
        /// The list of schemas used in the PATCH request.
        /// </summary>
        /// <value>The list of schemas used in the PATCH request.</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }



        /// <summary>
        /// The list of operations to perform for the PATCH request.
        /// </summary>
        /// <value>The list of operations to perform for the PATCH request.</value>
        [DataMember(Name="Operations", EmitDefaultValue=false)]
        public List<ScimV2PatchOperation> Operations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2PatchRequest {\n");

            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
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
            return this.Equals(obj as ScimV2PatchRequest);
        }

        /// <summary>
        /// Returns true if ScimV2PatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2PatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2PatchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
                ) &&
                (
                    this.Operations == other.Operations ||
                    this.Operations != null &&
                    this.Operations.SequenceEqual(other.Operations)
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
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();

                if (this.Operations != null)
                    hash = hash * 59 + this.Operations.GetHashCode();

                return hash;
            }
        }
    }

}
