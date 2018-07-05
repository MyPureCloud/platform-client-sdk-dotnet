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
    /// Used to query for attributes
    /// </summary>
    [DataContract]
    public partial class AttributeQueryRequest :  IEquatable<AttributeQueryRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeQueryRequest" /> class.
        /// </summary>
        /// <param name="Query">Query phrase to search attribute by name. If not set will match all..</param>
        /// <param name="PageSize">The maximum number of hits to return. Default: 25, Maximum: 500..</param>
        /// <param name="PageNumber">The page number to start at. The first page is number 1..</param>
        public AttributeQueryRequest(string Query = null, int? PageSize = null, int? PageNumber = null)
        {
            this.Query = Query;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            
        }
        
        
        
        /// <summary>
        /// Query phrase to search attribute by name. If not set will match all.
        /// </summary>
        /// <value>Query phrase to search attribute by name. If not set will match all.</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
        
        
        
        /// <summary>
        /// The maximum number of hits to return. Default: 25, Maximum: 500.
        /// </summary>
        /// <value>The maximum number of hits to return. Default: 25, Maximum: 500.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        
        /// <summary>
        /// The page number to start at. The first page is number 1.
        /// </summary>
        /// <value>The page number to start at. The first page is number 1.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeQueryRequest {\n");
            
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
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
            return this.Equals(obj as AttributeQueryRequest);
        }

        /// <summary>
        /// Returns true if AttributeQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AttributeQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
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
                
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                return hash;
            }
        }
    }

}
