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
    /// ResponseAssetBulkRequest
    /// </summary>
    [DataContract]
    public partial class ResponseAssetBulkRequest :  IEquatable<ResponseAssetBulkRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAssetBulkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseAssetBulkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAssetBulkRequest" /> class.
        /// </summary>
        /// <param name="AssetIds">List of Response Asset IDs (max 50) (required).</param>
        public ResponseAssetBulkRequest(List<string> AssetIds = null)
        {
            this.AssetIds = AssetIds;
            
        }
        


        /// <summary>
        /// List of Response Asset IDs (max 50)
        /// </summary>
        /// <value>List of Response Asset IDs (max 50)</value>
        [DataMember(Name="assetIds", EmitDefaultValue=false)]
        public List<string> AssetIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseAssetBulkRequest {\n");

            sb.Append("  AssetIds: ").Append(AssetIds).Append("\n");
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
            return this.Equals(obj as ResponseAssetBulkRequest);
        }

        /// <summary>
        /// Returns true if ResponseAssetBulkRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseAssetBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAssetBulkRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AssetIds == other.AssetIds ||
                    this.AssetIds != null &&
                    this.AssetIds.SequenceEqual(other.AssetIds)
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
                if (this.AssetIds != null)
                    hash = hash * 59 + this.AssetIds.GetHashCode();

                return hash;
            }
        }
    }

}
