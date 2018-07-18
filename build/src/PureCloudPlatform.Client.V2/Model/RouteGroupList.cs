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
    /// RouteGroupList
    /// </summary>
    [DataContract]
    public partial class RouteGroupList :  IEquatable<RouteGroupList>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteGroupList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RouteGroupList() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteGroupList" /> class.
        /// </summary>
        /// <param name="RouteGroups">The route group data for this forecast (required).</param>
        public RouteGroupList(List<RouteGroup> RouteGroups = null)
        {
            this.RouteGroups = RouteGroups;
            
        }
        
        
        
        /// <summary>
        /// The reference start date for the route group arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The reference start date for the route group arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; private set; }
        
        
        
        /// <summary>
        /// The route group data for this forecast
        /// </summary>
        /// <value>The route group data for this forecast</value>
        [DataMember(Name="routeGroups", EmitDefaultValue=false)]
        public List<RouteGroup> RouteGroups { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteGroupList {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  RouteGroups: ").Append(RouteGroups).Append("\n");
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
            return this.Equals(obj as RouteGroupList);
        }

        /// <summary>
        /// Returns true if RouteGroupList instances are equal
        /// </summary>
        /// <param name="other">Instance of RouteGroupList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteGroupList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.RouteGroups == other.RouteGroups ||
                    this.RouteGroups != null &&
                    this.RouteGroups.SequenceEqual(other.RouteGroups)
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
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.RouteGroups != null)
                    hash = hash * 59 + this.RouteGroups.GetHashCode();
                
                return hash;
            }
        }
    }

}
