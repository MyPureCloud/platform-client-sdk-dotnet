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
    /// Contract definition.
    /// </summary>
    [DataContract]
    public partial class ActionContractInput :  IEquatable<ActionContractInput>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionContractInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionContractInput() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionContractInput" /> class.
        /// </summary>
        /// <param name="Input">Execution input contract (required).</param>
        /// <param name="Output">Execution output contract (required).</param>
        public ActionContractInput(PostInputContract Input = null, PostOutputContract Output = null)
        {
            
        }
        
        
        
        /// <summary>
        /// Execution input contract
        /// </summary>
        /// <value>Execution input contract</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public PostInputContract Input { get; set; }
        
        
        
        /// <summary>
        /// Execution output contract
        /// </summary>
        /// <value>Execution output contract</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public PostOutputContract Output { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionContractInput {\n");
            
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ActionContractInput);
        }

        /// <summary>
        /// Returns true if ActionContractInput instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionContractInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionContractInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
                ) &&
                (
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.Equals(other.Output)
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
                
                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();
                
                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();
                
                return hash;
            }
        }
    }

}
