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
    /// DecisionTableOutputColumn
    /// </summary>
    [DataContract]
    public partial class DecisionTableOutputColumn :  IEquatable<DecisionTableOutputColumn>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableOutputColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecisionTableOutputColumn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableOutputColumn" /> class.
        /// </summary>
        /// <param name="DefaultsTo">The default row value for this column that will be used for an output value where no value  is provided by a row..</param>
        /// <param name="Value">The output data of this column that will be provided by each row. (required).</param>
        public DecisionTableOutputColumn(DecisionTableColumnDefaultRowValue DefaultsTo = null, OutputValue Value = null)
        {
            this.DefaultsTo = DefaultsTo;
            this.Value = Value;
            
        }
        


        /// <summary>
        /// The id of the column.
        /// </summary>
        /// <value>The id of the column.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The default row value for this column that will be used for an output value where no value  is provided by a row.
        /// </summary>
        /// <value>The default row value for this column that will be used for an output value where no value  is provided by a row.</value>
        [DataMember(Name="defaultsTo", EmitDefaultValue=false)]
        public DecisionTableColumnDefaultRowValue DefaultsTo { get; set; }



        /// <summary>
        /// The output data of this column that will be provided by each row.
        /// </summary>
        /// <value>The output data of this column that will be provided by each row.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public OutputValue Value { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableOutputColumn {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DefaultsTo: ").Append(DefaultsTo).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as DecisionTableOutputColumn);
        }

        /// <summary>
        /// Returns true if DecisionTableOutputColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableOutputColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableOutputColumn other)
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
                    this.DefaultsTo == other.DefaultsTo ||
                    this.DefaultsTo != null &&
                    this.DefaultsTo.Equals(other.DefaultsTo)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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

                if (this.DefaultsTo != null)
                    hash = hash * 59 + this.DefaultsTo.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                return hash;
            }
        }
    }

}
