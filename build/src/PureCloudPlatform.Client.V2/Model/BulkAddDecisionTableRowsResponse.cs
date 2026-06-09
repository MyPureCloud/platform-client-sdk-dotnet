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
    /// BulkAddDecisionTableRowsResponse
    /// </summary>
    [DataContract]
    public partial class BulkAddDecisionTableRowsResponse :  IEquatable<BulkAddDecisionTableRowsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddDecisionTableRowsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkAddDecisionTableRowsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddDecisionTableRowsResponse" /> class.
        /// </summary>
        /// <param name="TotalCreated">The total number of rows successfully created (required).</param>
        /// <param name="Rows">The list of created decision table rows (required).</param>
        public BulkAddDecisionTableRowsResponse(int? TotalCreated = null, List<DecisionTableRow> Rows = null)
        {
            this.TotalCreated = TotalCreated;
            this.Rows = Rows;
            
        }
        


        /// <summary>
        /// The total number of rows successfully created
        /// </summary>
        /// <value>The total number of rows successfully created</value>
        [DataMember(Name="totalCreated", EmitDefaultValue=false)]
        public int? TotalCreated { get; set; }



        /// <summary>
        /// The list of created decision table rows
        /// </summary>
        /// <value>The list of created decision table rows</value>
        [DataMember(Name="rows", EmitDefaultValue=false)]
        public List<DecisionTableRow> Rows { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkAddDecisionTableRowsResponse {\n");

            sb.Append("  TotalCreated: ").Append(TotalCreated).Append("\n");
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
            return this.Equals(obj as BulkAddDecisionTableRowsResponse);
        }

        /// <summary>
        /// Returns true if BulkAddDecisionTableRowsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkAddDecisionTableRowsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkAddDecisionTableRowsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalCreated == other.TotalCreated ||
                    this.TotalCreated != null &&
                    this.TotalCreated.Equals(other.TotalCreated)
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
                if (this.TotalCreated != null)
                    hash = hash * 59 + this.TotalCreated.GetHashCode();

                if (this.Rows != null)
                    hash = hash * 59 + this.Rows.GetHashCode();

                return hash;
            }
        }
    }

}
