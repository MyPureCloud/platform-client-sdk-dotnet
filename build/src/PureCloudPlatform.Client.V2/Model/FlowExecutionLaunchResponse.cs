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
    /// Response object from launching a flow.
    /// </summary>
    [DataContract]
    public partial class FlowExecutionLaunchResponse :  IEquatable<FlowExecutionLaunchResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowExecutionLaunchResponse" /> class.
        /// </summary>
        /// <param name="Id">The flow execution ID.</param>
        /// <param name="Name">The flow execution name..</param>
        /// <param name="FlowVersion">The version of the flow that launched.</param>
        public FlowExecutionLaunchResponse(string Id = null, string Name = null, DomainEntityRef FlowVersion = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.FlowVersion = FlowVersion;
            
        }
        
        
        
        /// <summary>
        /// The flow execution ID
        /// </summary>
        /// <value>The flow execution ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The flow execution name.
        /// </summary>
        /// <value>The flow execution name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The version of the flow that launched
        /// </summary>
        /// <value>The version of the flow that launched</value>
        [DataMember(Name="flowVersion", EmitDefaultValue=false)]
        public DomainEntityRef FlowVersion { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowExecutionLaunchResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as FlowExecutionLaunchResponse);
        }

        /// <summary>
        /// Returns true if FlowExecutionLaunchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowExecutionLaunchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowExecutionLaunchResponse other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.FlowVersion == other.FlowVersion ||
                    this.FlowVersion != null &&
                    this.FlowVersion.Equals(other.FlowVersion)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.FlowVersion != null)
                    hash = hash * 59 + this.FlowVersion.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
