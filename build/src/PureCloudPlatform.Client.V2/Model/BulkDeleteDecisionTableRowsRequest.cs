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
    /// BulkDeleteDecisionTableRowsRequest
    /// </summary>
    [DataContract]
    public partial class BulkDeleteDecisionTableRowsRequest :  IEquatable<BulkDeleteDecisionTableRowsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteDecisionTableRowsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkDeleteDecisionTableRowsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteDecisionTableRowsRequest" /> class.
        /// </summary>
        /// <param name="RowIds">The set of unique row IDs to be deleted. Maximum 49 rows per request. (required).</param>
        public BulkDeleteDecisionTableRowsRequest(List<string> RowIds = null)
        {
            this.RowIds = RowIds;
            
        }
        


        /// <summary>
        /// The set of unique row IDs to be deleted. Maximum 49 rows per request.
        /// </summary>
        /// <value>The set of unique row IDs to be deleted. Maximum 49 rows per request.</value>
        [DataMember(Name="rowIds", EmitDefaultValue=false)]
        public List<string> RowIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkDeleteDecisionTableRowsRequest {\n");

            sb.Append("  RowIds: ").Append(RowIds).Append("\n");
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
            return this.Equals(obj as BulkDeleteDecisionTableRowsRequest);
        }

        /// <summary>
        /// Returns true if BulkDeleteDecisionTableRowsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkDeleteDecisionTableRowsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkDeleteDecisionTableRowsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RowIds == other.RowIds ||
                    this.RowIds != null &&
                    this.RowIds.SequenceEqual(other.RowIds)
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
                if (this.RowIds != null)
                    hash = hash * 59 + this.RowIds.GetHashCode();

                return hash;
            }
        }
    }

}
