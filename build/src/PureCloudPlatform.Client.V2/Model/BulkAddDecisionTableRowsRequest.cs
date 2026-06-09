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
    /// BulkAddDecisionTableRowsRequest
    /// </summary>
    [DataContract]
    public partial class BulkAddDecisionTableRowsRequest :  IEquatable<BulkAddDecisionTableRowsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddDecisionTableRowsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkAddDecisionTableRowsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddDecisionTableRowsRequest" /> class.
        /// </summary>
        /// <param name="Rows">The list of rows to create. Maximum 15 rows per request. RowIndex is not supported for bulk add - all rows will be appended to the end of the table in the order provided. (required).</param>
        public BulkAddDecisionTableRowsRequest(List<CreateDecisionTableRowRequest> Rows = null)
        {
            this.Rows = Rows;
            
        }
        


        /// <summary>
        /// The list of rows to create. Maximum 15 rows per request. RowIndex is not supported for bulk add - all rows will be appended to the end of the table in the order provided.
        /// </summary>
        /// <value>The list of rows to create. Maximum 15 rows per request. RowIndex is not supported for bulk add - all rows will be appended to the end of the table in the order provided.</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<CreateDecisionTableRowRequest> Rows { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkAddDecisionTableRowsRequest {\n");

            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return this.Equals(obj as BulkAddDecisionTableRowsRequest);
        }

        /// <summary>
        /// Returns true if BulkAddDecisionTableRowsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkAddDecisionTableRowsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkAddDecisionTableRowsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Rows == other.Rows ||
                    this.Rows != null &&
                    this.Rows.SequenceEqual(other.Rows)
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
                if (this.Rows != null)
                    hash = hash * 59 + this.Rows.GetHashCode();

                return hash;
            }
        }
    }

}
