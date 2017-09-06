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
    /// TestExecutionOperationResult
    /// </summary>
    [DataContract]
    public partial class TestExecutionOperationResult :  IEquatable<TestExecutionOperationResult>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TestExecutionOperationResult" /> class.
        /// </summary>
        
        
        /// <param name="Step">The step number to indicate the order in which the operation was performed.</param>
        
        
        
        /// <param name="Name">Name of the operation performed.</param>
        
        
        
        /// <param name="Success">Indicated whether or not the operation was successful.</param>
        
        
        
        /// <param name="Result">The result of the operation.</param>
        
        
        
        /// <param name="Error">Error that occurred during the operation.</param>
        
        
        public TestExecutionOperationResult(int? Step = null, string Name = null, bool? Success = null, Object Result = null, ErrorBody Error = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Step = Step;
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.Success = Success;
            
            
            
            
            
            
            
            
this.Result = Result;
            
            
            
            
            
            
            
            
this.Error = Error;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The step number to indicate the order in which the operation was performed
        /// </summary>
        /// <value>The step number to indicate the order in which the operation was performed</value>
        [DataMember(Name="step", EmitDefaultValue=false)]
        public int? Step { get; set; }
        
        
        
        /// <summary>
        /// Name of the operation performed
        /// </summary>
        /// <value>Name of the operation performed</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Indicated whether or not the operation was successful
        /// </summary>
        /// <value>Indicated whether or not the operation was successful</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }
        
        
        
        /// <summary>
        /// The result of the operation
        /// </summary>
        /// <value>The result of the operation</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public Object Result { get; set; }
        
        
        
        /// <summary>
        /// Error that occurred during the operation
        /// </summary>
        /// <value>Error that occurred during the operation</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestExecutionOperationResult {\n");
            
            sb.Append("  Step: ").Append(Step).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Success: ").Append(Success).Append("\n");
            
            sb.Append("  Result: ").Append(Result).Append("\n");
            
            sb.Append("  Error: ").Append(Error).Append("\n");
            
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
            return this.Equals(obj as TestExecutionOperationResult);
        }

        /// <summary>
        /// Returns true if TestExecutionOperationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TestExecutionOperationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestExecutionOperationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Step == other.Step ||
                    this.Step != null &&
                    this.Step.Equals(other.Step)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) &&
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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
                
                if (this.Step != null)
                    hash = hash * 59 + this.Step.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                return hash;
            }
        }
    }

}
