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
    /// ResponseAssetEntityListing
    /// </summary>
    [DataContract]
    public partial class ResponseAssetEntityListing :  IEquatable<ResponseAssetEntityListing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAssetEntityListing" /> class.
        /// </summary>
        /// <param name="Entities">List of response assets.</param>
        /// <param name="NotFound">Asset IDs not found.</param>
        public ResponseAssetEntityListing(List<ResponseAsset> Entities = null, List<string> NotFound = null)
        {
            this.Entities = Entities;
            this.NotFound = NotFound;
            
        }
        


        /// <summary>
        /// List of response assets
        /// </summary>
        /// <value>List of response assets</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<ResponseAsset> Entities { get; set; }



        /// <summary>
        /// Asset IDs not found
        /// </summary>
        /// <value>Asset IDs not found</value>
        [DataMember(Name="notFound", EmitDefaultValue=false)]
        public List<string> NotFound { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAssetEntityListing {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  NotFound: ").Append(NotFound).Append("\n");
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
            return this.Equals(obj as ResponseAssetEntityListing);
        }

        /// <summary>
        /// Returns true if ResponseAssetEntityListing instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseAssetEntityListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAssetEntityListing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.NotFound == other.NotFound ||
                    this.NotFound != null &&
                    this.NotFound.SequenceEqual(other.NotFound)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.NotFound != null)
                    hash = hash * 59 + this.NotFound.GetHashCode();

                return hash;
            }
        }
    }

}
