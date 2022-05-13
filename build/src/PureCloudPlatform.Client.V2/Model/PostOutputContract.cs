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
    /// The schemas defining all of the expected responses/outputs.
    /// </summary>
    [DataContract]
    public partial class PostOutputContract :  IEquatable<PostOutputContract>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOutputContract" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostOutputContract() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostOutputContract" /> class.
        /// </summary>
        /// <param name="SuccessSchema">JSON schema that defines the transformed, successful result that will be sent back to the caller. (required).</param>
        public PostOutputContract(JsonSchemaDocument SuccessSchema = null)
        {
            this.SuccessSchema = SuccessSchema;
            
        }
        


        /// <summary>
        /// JSON schema that defines the transformed, successful result that will be sent back to the caller.
        /// </summary>
        /// <value>JSON schema that defines the transformed, successful result that will be sent back to the caller.</value>
        [DataMember(Name="successSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument SuccessSchema { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostOutputContract {\n");

            sb.Append("  SuccessSchema: ").Append(SuccessSchema).Append("\n");
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
            return this.Equals(obj as PostOutputContract);
        }

        /// <summary>
        /// Returns true if PostOutputContract instances are equal
        /// </summary>
        /// <param name="other">Instance of PostOutputContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostOutputContract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SuccessSchema == other.SuccessSchema ||
                    this.SuccessSchema != null &&
                    this.SuccessSchema.Equals(other.SuccessSchema)
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
                if (this.SuccessSchema != null)
                    hash = hash * 59 + this.SuccessSchema.GetHashCode();

                return hash;
            }
        }
    }

}
