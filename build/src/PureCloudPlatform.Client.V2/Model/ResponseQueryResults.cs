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
    /// Used to return response query results
    /// </summary>
    [DataContract]
    public partial class ResponseQueryResults :  IEquatable<ResponseQueryResults>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueryResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseQueryResults() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQueryResults" /> class.
        /// </summary>
        /// <param name="Results">Contains the query results (required).</param>
        public ResponseQueryResults(ResponseEntityList Results = null)
        {
            this.Results = Results;
            
        }
        
        
        
        /// <summary>
        /// Contains the query results
        /// </summary>
        /// <value>Contains the query results</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public ResponseEntityList Results { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseQueryResults {\n");
            
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
            return this.Equals(obj as ResponseQueryResults);
        }

        /// <summary>
        /// Returns true if ResponseQueryResults instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseQueryResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseQueryResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.Equals(other.Results)
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
