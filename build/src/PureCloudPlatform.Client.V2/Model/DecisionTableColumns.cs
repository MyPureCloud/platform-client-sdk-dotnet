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
    /// DecisionTableColumns
    /// </summary>
    [DataContract]
    public partial class DecisionTableColumns :  IEquatable<DecisionTableColumns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableColumns" /> class.
        /// </summary>
        /// <param name="Inputs">The input columns of the decision table..</param>
        /// <param name="Outputs">The output columns of the decision table..</param>
        public DecisionTableColumns(List<DecisionTableInputColumn> Inputs = null, List<DecisionTableOutputColumn> Outputs = null)
        {
            this.Inputs = Inputs;
            this.Outputs = Outputs;
            
        }
        


        /// <summary>
        /// The input columns of the decision table.
        /// </summary>
        /// <value>The input columns of the decision table.</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<DecisionTableInputColumn> Inputs { get; set; }



        /// <summary>
        /// The output columns of the decision table.
        /// </summary>
        /// <value>The output columns of the decision table.</value>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<DecisionTableOutputColumn> Outputs { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableColumns {\n");

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
            return this.Equals(obj as DecisionTableColumns);
        }

        /// <summary>
        /// Returns true if DecisionTableColumns instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableColumns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableColumns other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();

                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();

                return hash;
            }
        }
    }

}
