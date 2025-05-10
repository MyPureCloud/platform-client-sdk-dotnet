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
    /// DecisionTableExecutionResponse
    /// </summary>
    [DataContract]
    public partial class DecisionTableExecutionResponse :  IEquatable<DecisionTableExecutionResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableExecutionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionTableExecutionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableExecutionResponse" /> class.
        /// </summary>
        /// <param name="Table">The decision table version entity that was executed. (required).</param>
        /// <param name="RowExecutionOutputs">The output data for each executed row for which output is collected.  (required).</param>
        public DecisionTableExecutionResponse(DecisionTableVersionEntity Table = null, List<DecisionTableRowExecutionOutput> RowExecutionOutputs = null)
        {
            this.Table = Table;
            this.RowExecutionOutputs = RowExecutionOutputs;
            
        }
        


        /// <summary>
        /// The decision table version entity that was executed.
        /// </summary>
        /// <value>The decision table version entity that was executed.</value>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public DecisionTableVersionEntity Table { get; set; }



        /// <summary>
        /// The output data for each executed row for which output is collected. 
        /// </summary>
        /// <value>The output data for each executed row for which output is collected. </value>
        [DataMember(Name="rowExecutionOutputs", EmitDefaultValue=false)]
        public List<DecisionTableRowExecutionOutput> RowExecutionOutputs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableExecutionResponse {\n");

            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  RowExecutionOutputs: ").Append(RowExecutionOutputs).Append("\n");
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
            return this.Equals(obj as DecisionTableExecutionResponse);
        }

        /// <summary>
        /// Returns true if DecisionTableExecutionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableExecutionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableExecutionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
                ) &&
                (
                    this.RowExecutionOutputs == other.RowExecutionOutputs ||
                    this.RowExecutionOutputs != null &&
                    this.RowExecutionOutputs.SequenceEqual(other.RowExecutionOutputs)
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
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();

                if (this.RowExecutionOutputs != null)
                    hash = hash * 59 + this.RowExecutionOutputs.GetHashCode();

                return hash;
            }
        }
    }

}
