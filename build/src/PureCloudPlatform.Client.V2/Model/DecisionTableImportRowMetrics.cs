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
    /// Progress metrics for a decision table import job
    /// </summary>
    [DataContract]
    public partial class DecisionTableImportRowMetrics :  IEquatable<DecisionTableImportRowMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableImportRowMetrics" /> class.
        /// </summary>
        /// <param name="TotalRows">Total number of rows in the import file (set after parsing completes).</param>
        /// <param name="RowsParsed">Number of rows successfully parsed so far.</param>
        /// <param name="RowParseFailed">Number of rows that failed to parse.</param>
        /// <param name="RowsCreated">Number of rows successfully created so far.</param>
        /// <param name="RowsUpdated">Number of rows successfully updated so far.</param>
        /// <param name="RowsDeleted">Number of rows deleted (Replace mode only).</param>
        /// <param name="RowCreateFailed">Number of rows that failed during batch create.</param>
        /// <param name="RowUpdateFailed">Number of rows that failed during batch update.</param>
        /// <param name="RowDeleteFailed">Number of rows that failed during delete.</param>
        public DecisionTableImportRowMetrics(int? TotalRows = null, int? RowsParsed = null, int? RowParseFailed = null, int? RowsCreated = null, int? RowsUpdated = null, int? RowsDeleted = null, int? RowCreateFailed = null, int? RowUpdateFailed = null, int? RowDeleteFailed = null)
        {
            this.TotalRows = TotalRows;
            this.RowsParsed = RowsParsed;
            this.RowParseFailed = RowParseFailed;
            this.RowsCreated = RowsCreated;
            this.RowsUpdated = RowsUpdated;
            this.RowsDeleted = RowsDeleted;
            this.RowCreateFailed = RowCreateFailed;
            this.RowUpdateFailed = RowUpdateFailed;
            this.RowDeleteFailed = RowDeleteFailed;
            
        }
        


        /// <summary>
        /// Total number of rows in the import file (set after parsing completes)
        /// </summary>
        /// <value>Total number of rows in the import file (set after parsing completes)</value>
        [DataMember(Name="totalRows", EmitDefaultValue=false)]
        public int? TotalRows { get; set; }



        /// <summary>
        /// Number of rows successfully parsed so far
        /// </summary>
        /// <value>Number of rows successfully parsed so far</value>
        [DataMember(Name="rowsParsed", EmitDefaultValue=false)]
        public int? RowsParsed { get; set; }



        /// <summary>
        /// Number of rows that failed to parse
        /// </summary>
        /// <value>Number of rows that failed to parse</value>
        [DataMember(Name="rowParseFailed", EmitDefaultValue=false)]
        public int? RowParseFailed { get; set; }



        /// <summary>
        /// Number of rows successfully created so far
        /// </summary>
        /// <value>Number of rows successfully created so far</value>
        [DataMember(Name="rowsCreated", EmitDefaultValue=false)]
        public int? RowsCreated { get; set; }



        /// <summary>
        /// Number of rows successfully updated so far
        /// </summary>
        /// <value>Number of rows successfully updated so far</value>
        [DataMember(Name="rowsUpdated", EmitDefaultValue=false)]
        public int? RowsUpdated { get; set; }



        /// <summary>
        /// Number of rows deleted (Replace mode only)
        /// </summary>
        /// <value>Number of rows deleted (Replace mode only)</value>
        [DataMember(Name="rowsDeleted", EmitDefaultValue=false)]
        public int? RowsDeleted { get; set; }



        /// <summary>
        /// Number of rows that failed during batch create
        /// </summary>
        /// <value>Number of rows that failed during batch create</value>
        [DataMember(Name="rowCreateFailed", EmitDefaultValue=false)]
        public int? RowCreateFailed { get; set; }



        /// <summary>
        /// Number of rows that failed during batch update
        /// </summary>
        /// <value>Number of rows that failed during batch update</value>
        [DataMember(Name="rowUpdateFailed", EmitDefaultValue=false)]
        public int? RowUpdateFailed { get; set; }



        /// <summary>
        /// Number of rows that failed during delete
        /// </summary>
        /// <value>Number of rows that failed during delete</value>
        [DataMember(Name="rowDeleteFailed", EmitDefaultValue=false)]
        public int? RowDeleteFailed { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableImportRowMetrics {\n");

            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  RowsParsed: ").Append(RowsParsed).Append("\n");
            sb.Append("  RowParseFailed: ").Append(RowParseFailed).Append("\n");
            sb.Append("  RowsCreated: ").Append(RowsCreated).Append("\n");
            sb.Append("  RowsUpdated: ").Append(RowsUpdated).Append("\n");
            sb.Append("  RowsDeleted: ").Append(RowsDeleted).Append("\n");
            sb.Append("  RowCreateFailed: ").Append(RowCreateFailed).Append("\n");
            sb.Append("  RowUpdateFailed: ").Append(RowUpdateFailed).Append("\n");
            sb.Append("  RowDeleteFailed: ").Append(RowDeleteFailed).Append("\n");
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
            return this.Equals(obj as DecisionTableImportRowMetrics);
        }

        /// <summary>
        /// Returns true if DecisionTableImportRowMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableImportRowMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableImportRowMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TotalRows == other.TotalRows ||
                    this.TotalRows != null &&
                    this.TotalRows.Equals(other.TotalRows)
                ) &&
                (
                    this.RowsParsed == other.RowsParsed ||
                    this.RowsParsed != null &&
                    this.RowsParsed.Equals(other.RowsParsed)
                ) &&
                (
                    this.RowParseFailed == other.RowParseFailed ||
                    this.RowParseFailed != null &&
                    this.RowParseFailed.Equals(other.RowParseFailed)
                ) &&
                (
                    this.RowsCreated == other.RowsCreated ||
                    this.RowsCreated != null &&
                    this.RowsCreated.Equals(other.RowsCreated)
                ) &&
                (
                    this.RowsUpdated == other.RowsUpdated ||
                    this.RowsUpdated != null &&
                    this.RowsUpdated.Equals(other.RowsUpdated)
                ) &&
                (
                    this.RowsDeleted == other.RowsDeleted ||
                    this.RowsDeleted != null &&
                    this.RowsDeleted.Equals(other.RowsDeleted)
                ) &&
                (
                    this.RowCreateFailed == other.RowCreateFailed ||
                    this.RowCreateFailed != null &&
                    this.RowCreateFailed.Equals(other.RowCreateFailed)
                ) &&
                (
                    this.RowUpdateFailed == other.RowUpdateFailed ||
                    this.RowUpdateFailed != null &&
                    this.RowUpdateFailed.Equals(other.RowUpdateFailed)
                ) &&
                (
                    this.RowDeleteFailed == other.RowDeleteFailed ||
                    this.RowDeleteFailed != null &&
                    this.RowDeleteFailed.Equals(other.RowDeleteFailed)
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
                if (this.TotalRows != null)
                    hash = hash * 59 + this.TotalRows.GetHashCode();

                if (this.RowsParsed != null)
                    hash = hash * 59 + this.RowsParsed.GetHashCode();

                if (this.RowParseFailed != null)
                    hash = hash * 59 + this.RowParseFailed.GetHashCode();

                if (this.RowsCreated != null)
                    hash = hash * 59 + this.RowsCreated.GetHashCode();

                if (this.RowsUpdated != null)
                    hash = hash * 59 + this.RowsUpdated.GetHashCode();

                if (this.RowsDeleted != null)
                    hash = hash * 59 + this.RowsDeleted.GetHashCode();

                if (this.RowCreateFailed != null)
                    hash = hash * 59 + this.RowCreateFailed.GetHashCode();

                if (this.RowUpdateFailed != null)
                    hash = hash * 59 + this.RowUpdateFailed.GetHashCode();

                if (this.RowDeleteFailed != null)
                    hash = hash * 59 + this.RowDeleteFailed.GetHashCode();

                return hash;
            }
        }
    }

}
