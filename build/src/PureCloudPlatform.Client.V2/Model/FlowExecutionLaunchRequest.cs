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
    /// Parameters for launching a flow.
    /// </summary>
    [DataContract]
    public partial class FlowExecutionLaunchRequest :  IEquatable<FlowExecutionLaunchRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowExecutionLaunchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowExecutionLaunchRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowExecutionLaunchRequest" /> class.
        /// </summary>
        /// <param name="FlowId">ID of the flow to launch. (required).</param>
        /// <param name="FlowVersion">The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version..</param>
        /// <param name="InputData">Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema..</param>
        /// <param name="Name">A displayable name to assign to the new flow execution.</param>
        public FlowExecutionLaunchRequest(string FlowId = null, string FlowVersion = null, Dictionary<string, Object> InputData = null, string Name = null)
        {
            this.FlowId = FlowId;
            this.FlowVersion = FlowVersion;
            this.InputData = InputData;
            this.Name = Name;
            
        }
        
        
        
        /// <summary>
        /// ID of the flow to launch.
        /// </summary>
        /// <value>ID of the flow to launch.</value>
        [DataMember(Name="flowId", EmitDefaultValue=false)]
        public string FlowId { get; set; }
        
        
        
        /// <summary>
        /// The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version.
        /// </summary>
        /// <value>The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version.</value>
        [DataMember(Name="flowVersion", EmitDefaultValue=false)]
        public string FlowVersion { get; set; }
        
        
        
        /// <summary>
        /// Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema.
        /// </summary>
        /// <value>Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema.</value>
        [DataMember(Name="inputData", EmitDefaultValue=false)]
        public Dictionary<string, Object> InputData { get; set; }
        
        
        
        /// <summary>
        /// A displayable name to assign to the new flow execution
        /// </summary>
        /// <value>A displayable name to assign to the new flow execution</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowExecutionLaunchRequest {\n");
            
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  InputData: ").Append(InputData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as FlowExecutionLaunchRequest);
        }

        /// <summary>
        /// Returns true if FlowExecutionLaunchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowExecutionLaunchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowExecutionLaunchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FlowId == other.FlowId ||
                    this.FlowId != null &&
                    this.FlowId.Equals(other.FlowId)
                ) &&
                (
                    this.FlowVersion == other.FlowVersion ||
                    this.FlowVersion != null &&
                    this.FlowVersion.Equals(other.FlowVersion)
                ) &&
                (
                    this.InputData == other.InputData ||
                    this.InputData != null &&
                    this.InputData.SequenceEqual(other.InputData)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.FlowId != null)
                    hash = hash * 59 + this.FlowId.GetHashCode();
                
                if (this.FlowVersion != null)
                    hash = hash * 59 + this.FlowVersion.GetHashCode();
                
                if (this.InputData != null)
                    hash = hash * 59 + this.InputData.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }
    }

}
