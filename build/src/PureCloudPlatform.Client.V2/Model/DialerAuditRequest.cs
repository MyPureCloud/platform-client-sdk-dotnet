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
    /// DialerAuditRequest
    /// </summary>
    [DataContract]
    public partial class DialerAuditRequest :  IEquatable<DialerAuditRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAuditRequest" /> class.
        /// </summary>
        
        
        /// <param name="QueryPhrase">The word or words to search for..</param>
        
        
        
        /// <param name="QueryFields">The fields in which to search for the queryPhrase..</param>
        
        
        
        /// <param name="Facets">The fields to facet on..</param>
        
        
        
        /// <param name="Filters">The fields to filter on..</param>
        
        
        public DialerAuditRequest(string QueryPhrase = null, List<string> QueryFields = null, List<AuditFacet> Facets = null, List<AuditFilter> Filters = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.QueryPhrase = QueryPhrase;
            
            
            
            
            
            
            
            
this.QueryFields = QueryFields;
            
            
            
            
            
            
            
            
this.Facets = Facets;
            
            
            
            
            
            
            
            
this.Filters = Filters;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The word or words to search for.
        /// </summary>
        /// <value>The word or words to search for.</value>
        [DataMember(Name="queryPhrase", EmitDefaultValue=false)]
        public string QueryPhrase { get; set; }
        
        
        
        /// <summary>
        /// The fields in which to search for the queryPhrase.
        /// </summary>
        /// <value>The fields in which to search for the queryPhrase.</value>
        [DataMember(Name="queryFields", EmitDefaultValue=false)]
        public List<string> QueryFields { get; set; }
        
        
        
        /// <summary>
        /// The fields to facet on.
        /// </summary>
        /// <value>The fields to facet on.</value>
        [DataMember(Name="facets", EmitDefaultValue=false)]
        public List<AuditFacet> Facets { get; set; }
        
        
        
        /// <summary>
        /// The fields to filter on.
        /// </summary>
        /// <value>The fields to filter on.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<AuditFilter> Filters { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerAuditRequest {\n");
            
            sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
            
            sb.Append("  QueryFields: ").Append(QueryFields).Append("\n");
            
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            
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
            return this.Equals(obj as DialerAuditRequest);
        }

        /// <summary>
        /// Returns true if DialerAuditRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerAuditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerAuditRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueryPhrase == other.QueryPhrase ||
                    this.QueryPhrase != null &&
                    this.QueryPhrase.Equals(other.QueryPhrase)
                ) &&
                (
                    this.QueryFields == other.QueryFields ||
                    this.QueryFields != null &&
                    this.QueryFields.SequenceEqual(other.QueryFields)
                ) &&
                (
                    this.Facets == other.Facets ||
                    this.Facets != null &&
                    this.Facets.SequenceEqual(other.Facets)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
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
                
                if (this.QueryPhrase != null)
                    hash = hash * 59 + this.QueryPhrase.GetHashCode();
                
                if (this.QueryFields != null)
                    hash = hash * 59 + this.QueryFields.GetHashCode();
                
                if (this.Facets != null)
                    hash = hash * 59 + this.Facets.GetHashCode();
                
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                
                return hash;
            }
        }
    }

}
