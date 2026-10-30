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
    /// SimilarCustomerIntentsRequest
    /// </summary>
    [DataContract]
    public partial class SimilarCustomerIntentsRequest :  IEquatable<SimilarCustomerIntentsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarCustomerIntentsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimilarCustomerIntentsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarCustomerIntentsRequest" /> class.
        /// </summary>
        /// <param name="Name">Name to find similar customer intents for (required).</param>
        /// <param name="Description">Description to find similar customer intents for (required).</param>
        /// <param name="CategoryId">Optional category ID to scope the similarity search.</param>
        public SimilarCustomerIntentsRequest(string Name = null, string Description = null, string CategoryId = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.CategoryId = CategoryId;
            
        }
        


        /// <summary>
        /// Name to find similar customer intents for
        /// </summary>
        /// <value>Name to find similar customer intents for</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Description to find similar customer intents for
        /// </summary>
        /// <value>Description to find similar customer intents for</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Optional category ID to scope the similarity search
        /// </summary>
        /// <value>Optional category ID to scope the similarity search</value>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimilarCustomerIntentsRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
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
            return this.Equals(obj as SimilarCustomerIntentsRequest);
        }

        /// <summary>
        /// Returns true if SimilarCustomerIntentsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SimilarCustomerIntentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimilarCustomerIntentsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();

                return hash;
            }
        }
    }

}
