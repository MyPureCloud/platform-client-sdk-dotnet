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
    /// DecisionTableRow
    /// </summary>
    [DataContract]
    public partial class DecisionTableRow :  IEquatable<DecisionTableRow>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableRow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionTableRow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableRow" /> class.
        /// </summary>
        /// <param name="Table">The decision table to which this row belongs (required).</param>
        /// <param name="RowIndex">The absolute index of this row in the decision table, starting at 1.</param>
        /// <param name="DateCreated">The date when this row was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The date when this row was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Inputs">The map input values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates.</param>
        /// <param name="Outputs">The map output values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates.</param>
        public DecisionTableRow(DecisionTableVersionEntity Table = null, int? RowIndex = null, DateTime? DateCreated = null, DateTime? DateModified = null, Dictionary<string, DecisionTableRowParameterValue> Inputs = null, Dictionary<string, DecisionTableRowParameterValue> Outputs = null)
        {
            this.Table = Table;
            this.RowIndex = RowIndex;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Inputs = Inputs;
            this.Outputs = Outputs;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The decision table to which this row belongs
        /// </summary>
        /// <value>The decision table to which this row belongs</value>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public DecisionTableVersionEntity Table { get; set; }



        /// <summary>
        /// The absolute index of this row in the decision table, starting at 1
        /// </summary>
        /// <value>The absolute index of this row in the decision table, starting at 1</value>
        [DataMember(Name="rowIndex", EmitDefaultValue=false)]
        public int? RowIndex { get; set; }



        /// <summary>
        /// The date when this row was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date when this row was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The date when this row was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date when this row was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The map input values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates
        /// </summary>
        /// <value>The map input values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public Dictionary<string, DecisionTableRowParameterValue> Inputs { get; set; }



        /// <summary>
        /// The map output values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates
        /// </summary>
        /// <value>The map output values of the row being created. At least one value must be provided. The key for this map is the column ID the row value relates</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public Dictionary<string, DecisionTableRowParameterValue> Outputs { get; set; }



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
            sb.Append("class DecisionTableRow {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(obj as DecisionTableRow);
        }

        /// <summary>
        /// Returns true if DecisionTableRow instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableRow other)
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
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
                ) &&
                (
                    this.RowIndex == other.RowIndex ||
                    this.RowIndex != null &&
                    this.RowIndex.Equals(other.RowIndex)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Inputs == other.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(other.Inputs)
                ) &&
                (
                    this.Outputs == other.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.SequenceEqual(other.Outputs)
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

                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();

                if (this.RowIndex != null)
                    hash = hash * 59 + this.RowIndex.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();

                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
