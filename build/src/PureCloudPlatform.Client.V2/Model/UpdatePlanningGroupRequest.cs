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
    /// UpdatePlanningGroupRequest
    /// </summary>
    [DataContract]
    public partial class UpdatePlanningGroupRequest :  IEquatable<UpdatePlanningGroupRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlanningGroupRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePlanningGroupRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlanningGroupRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the planning group.</param>
        /// <param name="RoutePaths">Set of route paths to associate with the planning group.</param>
        /// <param name="ServiceGoalTemplateId">The ID of the service goal template to associate with this planning group.</param>
        /// <param name="Metadata">Version metadata for the planning group (required).</param>
        public UpdatePlanningGroupRequest(string Name = null, SetWrapperRoutePathRequest RoutePaths = null, string ServiceGoalTemplateId = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Name = Name;
            this.RoutePaths = RoutePaths;
            this.ServiceGoalTemplateId = ServiceGoalTemplateId;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The name of the planning group
        /// </summary>
        /// <value>The name of the planning group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Set of route paths to associate with the planning group
        /// </summary>
        /// <value>Set of route paths to associate with the planning group</value>
        [DataMember(Name="routePaths", EmitDefaultValue=false)]
        public SetWrapperRoutePathRequest RoutePaths { get; set; }
        
        
        
        /// <summary>
        /// The ID of the service goal template to associate with this planning group
        /// </summary>
        /// <value>The ID of the service goal template to associate with this planning group</value>
        [DataMember(Name="serviceGoalTemplateId", EmitDefaultValue=false)]
        public string ServiceGoalTemplateId { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for the planning group
        /// </summary>
        /// <value>Version metadata for the planning group</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePlanningGroupRequest {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RoutePaths: ").Append(RoutePaths).Append("\n");
            sb.Append("  ServiceGoalTemplateId: ").Append(ServiceGoalTemplateId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as UpdatePlanningGroupRequest);
        }

        /// <summary>
        /// Returns true if UpdatePlanningGroupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdatePlanningGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePlanningGroupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.RoutePaths == other.RoutePaths ||
                    this.RoutePaths != null &&
                    this.RoutePaths.Equals(other.RoutePaths)
                ) &&
                (
                    this.ServiceGoalTemplateId == other.ServiceGoalTemplateId ||
                    this.ServiceGoalTemplateId != null &&
                    this.ServiceGoalTemplateId.Equals(other.ServiceGoalTemplateId)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.RoutePaths != null)
                    hash = hash * 59 + this.RoutePaths.GetHashCode();
                
                if (this.ServiceGoalTemplateId != null)
                    hash = hash * 59 + this.ServiceGoalTemplateId.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                return hash;
            }
        }
    }

}
