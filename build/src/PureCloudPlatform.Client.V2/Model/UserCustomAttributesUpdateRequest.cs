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
    /// UserCustomAttributesUpdateRequest
    /// </summary>
    [DataContract]
    public partial class UserCustomAttributesUpdateRequest :  IEquatable<UserCustomAttributesUpdateRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCustomAttributesUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCustomAttributesUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCustomAttributesUpdateRequest" /> class.
        /// </summary>
        /// <param name="SchemaId">The id of the schema that dictates which attributes can be included..</param>
        /// <param name="SchemaVersion">The version of the schema..</param>
        /// <param name="Attributes">The map of attribute values. (required).</param>
        public UserCustomAttributesUpdateRequest(string SchemaId = null, int? SchemaVersion = null, Dictionary<string, Object> Attributes = null)
        {
            this.SchemaId = SchemaId;
            this.SchemaVersion = SchemaVersion;
            this.Attributes = Attributes;
            
        }
        


        /// <summary>
        /// The id of the schema that dictates which attributes can be included.
        /// </summary>
        /// <value>The id of the schema that dictates which attributes can be included.</value>
        [DataMember(Name="schemaId", EmitDefaultValue=false)]
        public string SchemaId { get; set; }



        /// <summary>
        /// The version of the schema.
        /// </summary>
        /// <value>The version of the schema.</value>
        [DataMember(Name="schemaVersion", EmitDefaultValue=false)]
        public int? SchemaVersion { get; set; }



        /// <summary>
        /// The map of attribute values.
        /// </summary>
        /// <value>The map of attribute values.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> Attributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCustomAttributesUpdateRequest {\n");

            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as UserCustomAttributesUpdateRequest);
        }

        /// <summary>
        /// Returns true if UserCustomAttributesUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserCustomAttributesUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCustomAttributesUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SchemaId == other.SchemaId ||
                    this.SchemaId != null &&
                    this.SchemaId.Equals(other.SchemaId)
                ) &&
                (
                    this.SchemaVersion == other.SchemaVersion ||
                    this.SchemaVersion != null &&
                    this.SchemaVersion.Equals(other.SchemaVersion)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
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
                if (this.SchemaId != null)
                    hash = hash * 59 + this.SchemaId.GetHashCode();

                if (this.SchemaVersion != null)
                    hash = hash * 59 + this.SchemaVersion.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                return hash;
            }
        }
    }

}
