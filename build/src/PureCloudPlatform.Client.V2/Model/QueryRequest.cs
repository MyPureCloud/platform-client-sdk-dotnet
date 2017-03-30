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
    /// QueryRequest
    /// </summary>
    [DataContract]
    public partial class QueryRequest :  IEquatable<QueryRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequest" /> class.
        /// </summary>
        /// <param name="QueryPhrase">QueryPhrase.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="FacetNameRequests">FacetNameRequests.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="Filters">Filters.</param>
        /// <param name="AttributeFilters">AttributeFilters.</param>
        /// <param name="IncludeShares">IncludeShares.</param>
        public QueryRequest(string QueryPhrase = null, int? PageNumber = null, int? PageSize = null, List<string> FacetNameRequests = null, List<SortItem> Sort = null, List<ContentFilterItem> Filters = null, List<AttributeFilterItem> AttributeFilters = null, bool? IncludeShares = null)
        {
            this.QueryPhrase = QueryPhrase;
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.FacetNameRequests = FacetNameRequests;
            this.Sort = Sort;
            this.Filters = Filters;
            this.AttributeFilters = AttributeFilters;
            this.IncludeShares = IncludeShares;
        }
        
        /// <summary>
        /// Gets or Sets QueryPhrase
        /// </summary>
        [DataMember(Name="queryPhrase", EmitDefaultValue=false)]
        public string QueryPhrase { get; set; }
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        /// <summary>
        /// Gets or Sets FacetNameRequests
        /// </summary>
        [DataMember(Name="facetNameRequests", EmitDefaultValue=false)]
        public List<string> FacetNameRequests { get; set; }
        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<SortItem> Sort { get; set; }
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<ContentFilterItem> Filters { get; set; }
        /// <summary>
        /// Gets or Sets AttributeFilters
        /// </summary>
        [DataMember(Name="attributeFilters", EmitDefaultValue=false)]
        public List<AttributeFilterItem> AttributeFilters { get; set; }
        /// <summary>
        /// Gets or Sets IncludeShares
        /// </summary>
        [DataMember(Name="includeShares", EmitDefaultValue=false)]
        public bool? IncludeShares { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRequest {\n");
            sb.Append("  QueryPhrase: ").Append(QueryPhrase).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  FacetNameRequests: ").Append(FacetNameRequests).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  AttributeFilters: ").Append(AttributeFilters).Append("\n");
            sb.Append("  IncludeShares: ").Append(IncludeShares).Append("\n");
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
            return this.Equals(obj as QueryRequest);
        }

        /// <summary>
        /// Returns true if QueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRequest other)
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
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.FacetNameRequests == other.FacetNameRequests ||
                    this.FacetNameRequests != null &&
                    this.FacetNameRequests.SequenceEqual(other.FacetNameRequests)
                ) &&
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.AttributeFilters == other.AttributeFilters ||
                    this.AttributeFilters != null &&
                    this.AttributeFilters.SequenceEqual(other.AttributeFilters)
                ) &&
                (
                    this.IncludeShares == other.IncludeShares ||
                    this.IncludeShares != null &&
                    this.IncludeShares.Equals(other.IncludeShares)
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
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.FacetNameRequests != null)
                    hash = hash * 59 + this.FacetNameRequests.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.AttributeFilters != null)
                    hash = hash * 59 + this.AttributeFilters.GetHashCode();
                if (this.IncludeShares != null)
                    hash = hash * 59 + this.IncludeShares.GetHashCode();
                return hash;
            }
        }
    }

}
