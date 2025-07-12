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
    /// CreateDecisionTableRowRequest
    /// </summary>
    [DataContract]
    public partial class CreateDecisionTableRowRequest :  IEquatable<CreateDecisionTableRowRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionTableRowRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDecisionTableRowRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionTableRowRequest" /> class.
        /// </summary>
        /// <param name="RowIndex">The absolute position of this row in the decision table. Must be an integerstarting from 1, must be positive and less than or equal to the size of the table. If not provided row will be append to the end of the table. .</param>
        /// <param name="Inputs">The input values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity (required).</param>
        /// <param name="Outputs">The output values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity (required).</param>
        public CreateDecisionTableRowRequest(int? RowIndex = null, Dictionary<string, DecisionTableRowParameterValue> Inputs = null, Dictionary<string, DecisionTableRowParameterValue> Outputs = null)
        {
            this.RowIndex = RowIndex;
            this.Inputs = Inputs;
            this.Outputs = Outputs;
            
        }
        


        /// <summary>
        /// The absolute position of this row in the decision table. Must be an integerstarting from 1, must be positive and less than or equal to the size of the table. If not provided row will be append to the end of the table. 
        /// </summary>
        /// <value>The absolute position of this row in the decision table. Must be an integerstarting from 1, must be positive and less than or equal to the size of the table. If not provided row will be append to the end of the table. </value>
        [DataMember(Name="rowIndex", EmitDefaultValue=false)]
        public int? RowIndex { get; set; }



        /// <summary>
        /// The input values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity
        /// </summary>
        /// <value>The input values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public Dictionary<string, DecisionTableRowParameterValue> Inputs { get; set; }



        /// <summary>
        /// The output values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity
        /// </summary>
        /// <value>The output values of the row. The key for this map is the column ID the row value relates. Column IDs are available from the decision table entity</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public Dictionary<string, DecisionTableRowParameterValue> Outputs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDecisionTableRowRequest {\n");

            sb.Append("  RowIndex: ").Append(RowIndex).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(obj as CreateDecisionTableRowRequest);
        }

        /// <summary>
        /// Returns true if CreateDecisionTableRowRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateDecisionTableRowRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDecisionTableRowRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RowIndex == other.RowIndex ||
                    this.RowIndex != null &&
                    this.RowIndex.Equals(other.RowIndex)
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
                if (this.RowIndex != null)
                    hash = hash * 59 + this.RowIndex.GetHashCode();

                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();

                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();

                return hash;
            }
        }
    }

}
