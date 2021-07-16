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
    /// GroupsSearchResponse
    /// </summary>
    [DataContract]
    public partial class GroupsSearchResponse :  IEquatable<GroupsSearchResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupsSearchResponse() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsSearchResponse" /> class.
        /// </summary>
        /// <param name="Total">The total number of results found (required).</param>
        /// <param name="PageCount">The total number of pages (required).</param>
        /// <param name="PageSize">The current page size (required).</param>
        /// <param name="PageNumber">The current page number (required).</param>
        /// <param name="PreviousPage">Q64 value for the previous page of results.</param>
        /// <param name="CurrentPage">Q64 value for the current page of results.</param>
        /// <param name="NextPage">Q64 value for the next page of results.</param>
        /// <param name="Types">Resource types the search was performed against (required).</param>
        /// <param name="Results">Search results (required).</param>
        public GroupsSearchResponse(long? Total = null, int? PageCount = null, int? PageSize = null, int? PageNumber = null, string PreviousPage = null, string CurrentPage = null, string NextPage = null, List<string> Types = null, List<Group> Results = null)
        {
            this.Total = Total;
            this.PageCount = PageCount;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.PreviousPage = PreviousPage;
            this.CurrentPage = CurrentPage;
            this.NextPage = NextPage;
            this.Types = Types;
            this.Results = Results;
            
        }
        
        
        
        /// <summary>
        /// The total number of results found
        /// </summary>
        /// <value>The total number of results found</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }
        
        
        
        /// <summary>
        /// The total number of pages
        /// </summary>
        /// <value>The total number of pages</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
        
        
        
        /// <summary>
        /// The current page size
        /// </summary>
        /// <value>The current page size</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        
        /// <summary>
        /// The current page number
        /// </summary>
        /// <value>The current page number</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        
        
        
        /// <summary>
        /// Q64 value for the previous page of results
        /// </summary>
        /// <value>Q64 value for the previous page of results</value>
        [DataMember(Name="previousPage", EmitDefaultValue=false)]
        public string PreviousPage { get; set; }
        
        
        
        /// <summary>
        /// Q64 value for the current page of results
        /// </summary>
        /// <value>Q64 value for the current page of results</value>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public string CurrentPage { get; set; }
        
        
        
        /// <summary>
        /// Q64 value for the next page of results
        /// </summary>
        /// <value>Q64 value for the next page of results</value>
        [DataMember(Name="nextPage", EmitDefaultValue=false)]
        public string NextPage { get; set; }
        
        
        
        /// <summary>
        /// Resource types the search was performed against
        /// </summary>
        /// <value>Resource types the search was performed against</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
        
        
        
        /// <summary>
        /// Search results
        /// </summary>
        /// <value>Search results</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<Group> Results { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsSearchResponse {\n");
            
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(obj as GroupsSearchResponse);
        }

        /// <summary>
        /// Returns true if GroupsSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupsSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) &&
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
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
                ) &&
                (
                    this.PreviousPage == other.PreviousPage ||
                    this.PreviousPage != null &&
                    this.PreviousPage.Equals(other.PreviousPage)
                ) &&
                (
                    this.CurrentPage == other.CurrentPage ||
                    this.CurrentPage != null &&
                    this.CurrentPage.Equals(other.CurrentPage)
                ) &&
                (
                    this.NextPage == other.NextPage ||
                    this.NextPage != null &&
                    this.NextPage.Equals(other.NextPage)
                ) &&
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) &&
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
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                if (this.PreviousPage != null)
                    hash = hash * 59 + this.PreviousPage.GetHashCode();
                
                if (this.CurrentPage != null)
                    hash = hash * 59 + this.CurrentPage.GetHashCode();
                
                if (this.NextPage != null)
                    hash = hash * 59 + this.NextPage.GetHashCode();
                
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                
                return hash;
            }
        }
    }

}
