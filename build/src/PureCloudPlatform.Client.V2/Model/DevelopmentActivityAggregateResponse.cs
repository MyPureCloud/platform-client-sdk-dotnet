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
    /// DevelopmentActivityAggregateResponse
    /// </summary>
    [DataContract]
    public partial class DevelopmentActivityAggregateResponse :  IEquatable<DevelopmentActivityAggregateResponse>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopmentActivityAggregateResponse" /> class.
        /// </summary>
        /// <param name="Results">The results of the query.</param>
        public DevelopmentActivityAggregateResponse(List<DevelopmentActivityAggregateQueryResponseGroupedData> Results = null)
        {
            this.Results = Results;
            
        }
        
        
        
        /// <summary>
        /// The results of the query
        /// </summary>
        /// <value>The results of the query</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<DevelopmentActivityAggregateQueryResponseGroupedData> Results { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevelopmentActivityAggregateResponse {\n");
            
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as DevelopmentActivityAggregateResponse);
        }

        /// <summary>
        /// Returns true if DevelopmentActivityAggregateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DevelopmentActivityAggregateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DevelopmentActivityAggregateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                
                return hash;
            }
        }
    }

}
