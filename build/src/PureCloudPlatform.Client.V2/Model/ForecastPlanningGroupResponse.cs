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
    /// ForecastPlanningGroupResponse
    /// </summary>
    [DataContract]
    public partial class ForecastPlanningGroupResponse :  IEquatable<ForecastPlanningGroupResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastPlanningGroupResponse" /> class.
        /// </summary>
        /// <param name="Id">The ID of the planning group.</param>
        /// <param name="Name">The name of the planning group.</param>
        /// <param name="RoutePaths">Route path configuration for this planning group.</param>
        /// <param name="ServiceGoalTemplate">Service goals for this planning group.</param>
        public ForecastPlanningGroupResponse(string Id = null, string Name = null, List<RoutePathResponse> RoutePaths = null, ForecastServiceGoalTemplateResponse ServiceGoalTemplate = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.RoutePaths = RoutePaths;
            this.ServiceGoalTemplate = ServiceGoalTemplate;
            
        }
        
        
        
        /// <summary>
        /// The ID of the planning group
        /// </summary>
        /// <value>The ID of the planning group</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The name of the planning group
        /// </summary>
        /// <value>The name of the planning group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Route path configuration for this planning group
        /// </summary>
        /// <value>Route path configuration for this planning group</value>
        [DataMember(Name="routePaths", EmitDefaultValue=false)]
        public List<RoutePathResponse> RoutePaths { get; set; }
        
        
        
        /// <summary>
        /// Service goals for this planning group
        /// </summary>
        /// <value>Service goals for this planning group</value>
        [DataMember(Name="serviceGoalTemplate", EmitDefaultValue=false)]
        public ForecastServiceGoalTemplateResponse ServiceGoalTemplate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForecastPlanningGroupResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RoutePaths: ").Append(RoutePaths).Append("\n");
            sb.Append("  ServiceGoalTemplate: ").Append(ServiceGoalTemplate).Append("\n");
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
            return this.Equals(obj as ForecastPlanningGroupResponse);
        }

        /// <summary>
        /// Returns true if ForecastPlanningGroupResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ForecastPlanningGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForecastPlanningGroupResponse other)
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
                    this.RoutePaths == other.RoutePaths ||
                    this.RoutePaths != null &&
                    this.RoutePaths.SequenceEqual(other.RoutePaths)
                ) &&
                (
                    this.ServiceGoalTemplate == other.ServiceGoalTemplate ||
                    this.ServiceGoalTemplate != null &&
                    this.ServiceGoalTemplate.Equals(other.ServiceGoalTemplate)
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
                
                if (this.RoutePaths != null)
                    hash = hash * 59 + this.RoutePaths.GetHashCode();
                
                if (this.ServiceGoalTemplate != null)
                    hash = hash * 59 + this.ServiceGoalTemplate.GetHashCode();
                
                return hash;
            }
        }
    }

}
