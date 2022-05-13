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
    /// BulkCallbackPatchRequest
    /// </summary>
    [DataContract]
    public partial class BulkCallbackPatchRequest :  IEquatable<BulkCallbackPatchRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCallbackPatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkCallbackPatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCallbackPatchRequest" /> class.
        /// </summary>
        /// <param name="PatchCallbackRequests">The list of requests to update callbacks in bulk (required).</param>
        public BulkCallbackPatchRequest(List<PatchCallbackRequest> PatchCallbackRequests = null)
        {
            this.PatchCallbackRequests = PatchCallbackRequests;
            
        }
        


        /// <summary>
        /// The list of requests to update callbacks in bulk
        /// </summary>
        /// <value>The list of requests to update callbacks in bulk</value>
        [DataMember(Name="patchCallbackRequests", EmitDefaultValue=false)]
        public List<PatchCallbackRequest> PatchCallbackRequests { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkCallbackPatchRequest {\n");

            sb.Append("  PatchCallbackRequests: ").Append(PatchCallbackRequests).Append("\n");
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
            return this.Equals(obj as BulkCallbackPatchRequest);
        }

        /// <summary>
        /// Returns true if BulkCallbackPatchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkCallbackPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkCallbackPatchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PatchCallbackRequests == other.PatchCallbackRequests ||
                    this.PatchCallbackRequests != null &&
                    this.PatchCallbackRequests.SequenceEqual(other.PatchCallbackRequests)
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
                if (this.PatchCallbackRequests != null)
                    hash = hash * 59 + this.PatchCallbackRequests.GetHashCode();

                return hash;
            }
        }
    }

}
