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
    /// DecisionTableContract
    /// </summary>
    [DataContract]
    public partial class DecisionTableContract :  IEquatable<DecisionTableContract>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableContract" /> class.
        /// </summary>
        /// <param name="ParentSchema">DSS schema entity defining source properties for the decision table contract schemas.</param>
        /// <param name="RowAuthoringSchema">JSON schema describing required value types for each column in every row in a decision table.</param>
        /// <param name="ExecutionInputSchema">JSON schema for execution input data for a decision table.</param>
        /// <param name="ExecutionOutputSchema">JSON schema for execution output data for a decision table.</param>
        public DecisionTableContract(DomainEntityRef ParentSchema = null, ContractJsonSchema RowAuthoringSchema = null, ContractJsonSchema ExecutionInputSchema = null, ContractJsonSchema ExecutionOutputSchema = null)
        {
            this.ParentSchema = ParentSchema;
            this.RowAuthoringSchema = RowAuthoringSchema;
            this.ExecutionInputSchema = ExecutionInputSchema;
            this.ExecutionOutputSchema = ExecutionOutputSchema;
            
        }
        


        /// <summary>
        /// DSS schema entity defining source properties for the decision table contract schemas
        /// </summary>
        /// <value>DSS schema entity defining source properties for the decision table contract schemas</value>
        [DataMember(Name="parentSchema", EmitDefaultValue=false)]
        public DomainEntityRef ParentSchema { get; set; }



        /// <summary>
        /// JSON schema describing required value types for each column in every row in a decision table
        /// </summary>
        /// <value>JSON schema describing required value types for each column in every row in a decision table</value>
        [DataMember(Name="rowAuthoringSchema", EmitDefaultValue=false)]
        public ContractJsonSchema RowAuthoringSchema { get; set; }



        /// <summary>
        /// JSON schema for execution input data for a decision table
        /// </summary>
        /// <value>JSON schema for execution input data for a decision table</value>
        [DataMember(Name="executionInputSchema", EmitDefaultValue=false)]
        public ContractJsonSchema ExecutionInputSchema { get; set; }



        /// <summary>
        /// JSON schema for execution output data for a decision table
        /// </summary>
        /// <value>JSON schema for execution output data for a decision table</value>
        [DataMember(Name="executionOutputSchema", EmitDefaultValue=false)]
        public ContractJsonSchema ExecutionOutputSchema { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableContract {\n");

            sb.Append("  ParentSchema: ").Append(ParentSchema).Append("\n");
            sb.Append("  RowAuthoringSchema: ").Append(RowAuthoringSchema).Append("\n");
            sb.Append("  ExecutionInputSchema: ").Append(ExecutionInputSchema).Append("\n");
            sb.Append("  ExecutionOutputSchema: ").Append(ExecutionOutputSchema).Append("\n");
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
            return this.Equals(obj as DecisionTableContract);
        }

        /// <summary>
        /// Returns true if DecisionTableContract instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableContract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ParentSchema == other.ParentSchema ||
                    this.ParentSchema != null &&
                    this.ParentSchema.Equals(other.ParentSchema)
                ) &&
                (
                    this.RowAuthoringSchema == other.RowAuthoringSchema ||
                    this.RowAuthoringSchema != null &&
                    this.RowAuthoringSchema.Equals(other.RowAuthoringSchema)
                ) &&
                (
                    this.ExecutionInputSchema == other.ExecutionInputSchema ||
                    this.ExecutionInputSchema != null &&
                    this.ExecutionInputSchema.Equals(other.ExecutionInputSchema)
                ) &&
                (
                    this.ExecutionOutputSchema == other.ExecutionOutputSchema ||
                    this.ExecutionOutputSchema != null &&
                    this.ExecutionOutputSchema.Equals(other.ExecutionOutputSchema)
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
                if (this.ParentSchema != null)
                    hash = hash * 59 + this.ParentSchema.GetHashCode();

                if (this.RowAuthoringSchema != null)
                    hash = hash * 59 + this.RowAuthoringSchema.GetHashCode();

                if (this.ExecutionInputSchema != null)
                    hash = hash * 59 + this.ExecutionInputSchema.GetHashCode();

                if (this.ExecutionOutputSchema != null)
                    hash = hash * 59 + this.ExecutionOutputSchema.GetHashCode();

                return hash;
            }
        }
    }

}
