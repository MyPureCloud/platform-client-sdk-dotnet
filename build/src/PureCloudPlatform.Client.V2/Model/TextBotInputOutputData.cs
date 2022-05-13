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
    /// Input/Output data related to a bot flow which is exiting gracefully.
    /// </summary>
    [DataContract]
    public partial class TextBotInputOutputData :  IEquatable<TextBotInputOutputData>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotInputOutputData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotInputOutputData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotInputOutputData" /> class.
        /// </summary>
        /// <param name="Variables">The input/output variables using the format as appropriate for the variable data type in the flow definition. (required).</param>
        public TextBotInputOutputData(Dictionary<string, Object> Variables = null)
        {
            this.Variables = Variables;
            
        }
        


        /// <summary>
        /// The input/output variables using the format as appropriate for the variable data type in the flow definition.
        /// </summary>
        /// <value>The input/output variables using the format as appropriate for the variable data type in the flow definition.</value>
        [DataMember(Name="variables", EmitDefaultValue=false)]
        public Dictionary<string, Object> Variables { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotInputOutputData {\n");

            sb.Append("  Variables: ").Append(Variables).Append("\n");
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
            return this.Equals(obj as TextBotInputOutputData);
        }

        /// <summary>
        /// Returns true if TextBotInputOutputData instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotInputOutputData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotInputOutputData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Variables == other.Variables ||
                    this.Variables != null &&
                    this.Variables.SequenceEqual(other.Variables)
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
                if (this.Variables != null)
                    hash = hash * 59 + this.Variables.GetHashCode();

                return hash;
            }
        }
    }

}
