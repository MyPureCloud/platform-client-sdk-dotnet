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
    /// SimilarCustomerIntentResult
    /// </summary>
    [DataContract]
    public partial class SimilarCustomerIntentResult :  IEquatable<SimilarCustomerIntentResult>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarCustomerIntentResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimilarCustomerIntentResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarCustomerIntentResult" /> class.
        /// </summary>
        /// <param name="Name">Name of the customer intent (required).</param>
        /// <param name="Description">Description of the customer intent (required).</param>
        /// <param name="ExpiryTime">Expiry time in hours of the customer intent (required).</param>
        /// <param name="Distance">The distance score indicating similarity (lower is more similar).</param>
        /// <param name="Category">The category of the similar customer intent.</param>
        /// <param name="DateCreated">Creation date of the customer intent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public SimilarCustomerIntentResult(string Name = null, string Description = null, int? ExpiryTime = null, double? Distance = null, SimilarEntityRef Category = null, DateTime? DateCreated = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.ExpiryTime = ExpiryTime;
            this.Distance = Distance;
            this.Category = Category;
            this.DateCreated = DateCreated;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Name of the customer intent
        /// </summary>
        /// <value>Name of the customer intent</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Description of the customer intent
        /// </summary>
        /// <value>Description of the customer intent</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Expiry time in hours of the customer intent
        /// </summary>
        /// <value>Expiry time in hours of the customer intent</value>
        [DataMember(Name="expiryTime", EmitDefaultValue=false)]
        public int? ExpiryTime { get; set; }



        /// <summary>
        /// The distance score indicating similarity (lower is more similar)
        /// </summary>
        /// <value>The distance score indicating similarity (lower is more similar)</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public double? Distance { get; set; }



        /// <summary>
        /// The category of the similar customer intent
        /// </summary>
        /// <value>The category of the similar customer intent</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public SimilarEntityRef Category { get; set; }



        /// <summary>
        /// Creation date of the customer intent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation date of the customer intent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimilarCustomerIntentResult {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpiryTime: ").Append(ExpiryTime).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as SimilarCustomerIntentResult);
        }

        /// <summary>
        /// Returns true if SimilarCustomerIntentResult instances are equal
        /// </summary>
        /// <param name="other">Instance of SimilarCustomerIntentResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimilarCustomerIntentResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
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
                    this.ExpiryTime == other.ExpiryTime ||
                    this.ExpiryTime != null &&
                    this.ExpiryTime.Equals(other.ExpiryTime)
                ) &&
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ExpiryTime != null)
                    hash = hash * 59 + this.ExpiryTime.GetHashCode();

                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
