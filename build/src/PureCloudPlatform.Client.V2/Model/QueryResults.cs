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
    /// QueryResults
    /// </summary>
    [DataContract]
    public partial class QueryResults :  IEquatable<QueryResults>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResults" /> class.
        /// </summary>
        
        
        /// <param name="Results">Results.</param>
        
        
        
        /// <param name="FacetInfo">FacetInfo.</param>
        
        
        public QueryResults(DomainEntityListingQueryResult Results = null, QueryFacetInfo FacetInfo = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Results = Results;
            
            
            
            
            
            
            
            
this.FacetInfo = FacetInfo;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public DomainEntityListingQueryResult Results { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FacetInfo
        /// </summary>
        [DataMember(Name="facetInfo", EmitDefaultValue=false)]
        public QueryFacetInfo FacetInfo { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResults {\n");
            
            sb.Append("  Results: ").Append(Results).Append("\n");
            
            sb.Append("  FacetInfo: ").Append(FacetInfo).Append("\n");
            
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
            return this.Equals(obj as QueryResults);
        }

        /// <summary>
        /// Returns true if QueryResults instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.Equals(other.Results)
                ) &&
                (
                    this.FacetInfo == other.FacetInfo ||
                    this.FacetInfo != null &&
                    this.FacetInfo.Equals(other.FacetInfo)
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
                
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                
                if (this.FacetInfo != null)
                    hash = hash * 59 + this.FacetInfo.GetHashCode();
                
                return hash;
            }
        }
    }

}
