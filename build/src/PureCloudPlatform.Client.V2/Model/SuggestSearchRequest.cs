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
    /// SuggestSearchRequest
    /// </summary>
    [DataContract]
    public partial class SuggestSearchRequest :  IEquatable<SuggestSearchRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestSearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SuggestSearchRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestSearchRequest" /> class.
        /// </summary>
        /// <param name="Expand">Provides more details about a specified resource.</param>
        /// <param name="Types">Resource domain type to search (required).</param>
        /// <param name="Query">Suggest query (required).</param>
        public SuggestSearchRequest(List<string> Expand = null, List<string> Types = null, List<SuggestSearchCriteria> Query = null)
        {
            this.Expand = Expand;
            this.Types = Types;
            this.Query = Query;
            
        }
        
        
        
        /// <summary>
        /// Provides more details about a specified resource
        /// </summary>
        /// <value>Provides more details about a specified resource</value>
        [DataMember(Name="expand", EmitDefaultValue=false)]
        public List<string> Expand { get; set; }
        
        
        
        /// <summary>
        /// Resource domain type to search
        /// </summary>
        /// <value>Resource domain type to search</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
        
        
        
        /// <summary>
        /// Suggest query
        /// </summary>
        /// <value>Suggest query</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public List<SuggestSearchCriteria> Query { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuggestSearchRequest {\n");
            
            sb.Append("  Expand: ").Append(Expand).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(obj as SuggestSearchRequest);
        }

        /// <summary>
        /// Returns true if SuggestSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SuggestSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuggestSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Expand == other.Expand ||
                    this.Expand != null &&
                    this.Expand.SequenceEqual(other.Expand)
                ) &&
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.SequenceEqual(other.Query)
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
                
                if (this.Expand != null)
                    hash = hash * 59 + this.Expand.GetHashCode();
                
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                
                return hash;
            }
        }
    }

}
