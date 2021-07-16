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
    /// Planning Group
    /// </summary>
    [DataContract]
    public partial class PlanningGroup :  IEquatable<PlanningGroup>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanningGroup" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ServiceGoalTemplate">The ID of the service goal template associated with this planning group.</param>
        /// <param name="RoutePaths">Set of route paths associated with the planning group.</param>
        /// <param name="Metadata">Version metadata for the planning group.</param>
        public PlanningGroup(string Name = null, ServiceGoalTemplateReference ServiceGoalTemplate = null, List<RoutePathResponse> RoutePaths = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Name = Name;
            this.ServiceGoalTemplate = ServiceGoalTemplate;
            this.RoutePaths = RoutePaths;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The ID of the service goal template associated with this planning group
        /// </summary>
        /// <value>The ID of the service goal template associated with this planning group</value>
        [DataMember(Name="serviceGoalTemplate", EmitDefaultValue=false)]
        public ServiceGoalTemplateReference ServiceGoalTemplate { get; set; }
        
        
        
        /// <summary>
        /// Set of route paths associated with the planning group
        /// </summary>
        /// <value>Set of route paths associated with the planning group</value>
        [DataMember(Name="routePaths", EmitDefaultValue=false)]
        public List<RoutePathResponse> RoutePaths { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for the planning group
        /// </summary>
        /// <value>Version metadata for the planning group</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        
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
            sb.Append("class PlanningGroup {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ServiceGoalTemplate: ").Append(ServiceGoalTemplate).Append("\n");
            sb.Append("  RoutePaths: ").Append(RoutePaths).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as PlanningGroup);
        }

        /// <summary>
        /// Returns true if PlanningGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanningGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanningGroup other)
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
                    this.ServiceGoalTemplate == other.ServiceGoalTemplate ||
                    this.ServiceGoalTemplate != null &&
                    this.ServiceGoalTemplate.Equals(other.ServiceGoalTemplate)
                ) &&
                (
                    this.RoutePaths == other.RoutePaths ||
                    this.RoutePaths != null &&
                    this.RoutePaths.SequenceEqual(other.RoutePaths)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.ServiceGoalTemplate != null)
                    hash = hash * 59 + this.ServiceGoalTemplate.GetHashCode();
                
                if (this.RoutePaths != null)
                    hash = hash * 59 + this.RoutePaths.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
