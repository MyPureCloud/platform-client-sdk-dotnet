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
    /// DecisionTableRowParameterValue
    /// </summary>
    [DataContract]
    public partial class DecisionTableRowParameterValue :  IEquatable<DecisionTableRowParameterValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableRowParameterValue" /> class.
        /// </summary>
        /// <param name="Literal">A literal parameter value.</param>
        public DecisionTableRowParameterValue(Literal Literal = null)
        {
            this.Literal = Literal;
            
        }
        


        /// <summary>
        /// A literal parameter value
        /// </summary>
        /// <value>A literal parameter value</value>
        [DataMember(Name="literal", EmitDefaultValue=false)]
        public Literal Literal { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableRowParameterValue {\n");

            sb.Append("  Literal: ").Append(Literal).Append("\n");
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
            return this.Equals(obj as DecisionTableRowParameterValue);
        }

        /// <summary>
        /// Returns true if DecisionTableRowParameterValue instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableRowParameterValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableRowParameterValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Literal == other.Literal ||
                    this.Literal != null &&
                    this.Literal.Equals(other.Literal)
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
                if (this.Literal != null)
                    hash = hash * 59 + this.Literal.GetHashCode();

                return hash;
            }
        }
    }

}
