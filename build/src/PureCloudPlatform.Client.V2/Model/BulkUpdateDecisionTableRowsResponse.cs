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
    /// BulkUpdateDecisionTableRowsResponse
    /// </summary>
    [DataContract]
    public partial class BulkUpdateDecisionTableRowsResponse :  IEquatable<BulkUpdateDecisionTableRowsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDecisionTableRowsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkUpdateDecisionTableRowsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateDecisionTableRowsResponse" /> class.
        /// </summary>
        /// <param name="TotalUpdated">The total number of rows successfully updated (required).</param>
        /// <param name="Rows">The list of updated decision table rows (required).</param>
        public BulkUpdateDecisionTableRowsResponse(int? TotalUpdated = null, List<DecisionTableRow> Rows = null)
        {
            this.TotalUpdated = TotalUpdated;
            this.Rows = Rows;
            
        }
        


        /// <summary>
        /// The total number of rows successfully updated
        /// </summary>
        /// <value>The total number of rows successfully updated</value>
        [DataMember(Name="totalUpdated", EmitDefaultValue=false)]
        public int? TotalUpdated { get; set; }



        /// <summary>
        /// The list of updated decision table rows
        /// </summary>
        /// <value>The list of updated decision table rows</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<DecisionTableRow> Rows { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpdateDecisionTableRowsResponse {\n");

            sb.Append("  TotalUpdated: ").Append(TotalUpdated).Append("\n");
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
            return this.Equals(obj as BulkUpdateDecisionTableRowsResponse);
        }

        /// <summary>
        /// Returns true if BulkUpdateDecisionTableRowsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkUpdateDecisionTableRowsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkUpdateDecisionTableRowsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalUpdated == other.TotalUpdated ||
                    this.TotalUpdated != null &&
                    this.TotalUpdated.Equals(other.TotalUpdated)
                ) &&
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
                if (this.TotalUpdated != null)
                    hash = hash * 59 + this.TotalUpdated.GetHashCode();

                if (this.Rows != null)
                    hash = hash * 59 + this.Rows.GetHashCode();

                return hash;
            }
        }
    }

}
