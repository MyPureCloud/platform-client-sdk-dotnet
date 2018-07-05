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
    /// AuditSearchResult
    /// </summary>
    [DataContract]
    public partial class AuditSearchResult :  IEquatable<AuditSearchResult>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditSearchResult" /> class.
        /// </summary>
        /// <param name="PageNumber">Which page was returned..</param>
        /// <param name="PageSize">The number of results in a page..</param>
        /// <param name="Total">The total number of results..</param>
        /// <param name="PageCount">The number of pages of results..</param>
        /// <param name="FacetInfo">FacetInfo.</param>
        /// <param name="AuditMessages">AuditMessages.</param>
        public AuditSearchResult(int? PageNumber = null, int? PageSize = null, int? Total = null, int? PageCount = null, List<FacetInfo> FacetInfo = null, List<AuditMessage> AuditMessages = null)
        {
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.Total = Total;
            this.PageCount = PageCount;
            this.FacetInfo = FacetInfo;
            this.AuditMessages = AuditMessages;
            
        }
        
        
        
        /// <summary>
        /// Which page was returned.
        /// </summary>
        /// <value>Which page was returned.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        
        
        
        /// <summary>
        /// The number of results in a page.
        /// </summary>
        /// <value>The number of results in a page.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        
        /// <summary>
        /// The total number of results.
        /// </summary>
        /// <value>The total number of results.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
        
        
        
        /// <summary>
        /// The number of pages of results.
        /// </summary>
        /// <value>The number of pages of results.</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FacetInfo
        /// </summary>
        [DataMember(Name="facetInfo", EmitDefaultValue=false)]
        public List<FacetInfo> FacetInfo { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AuditMessages
        /// </summary>
        [DataMember(Name="auditMessages", EmitDefaultValue=false)]
        public List<AuditMessage> AuditMessages { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditSearchResult {\n");
            
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  FacetInfo: ").Append(FacetInfo).Append("\n");
            sb.Append("  AuditMessages: ").Append(AuditMessages).Append("\n");
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
            return this.Equals(obj as AuditSearchResult);
        }

        /// <summary>
        /// Returns true if AuditSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.FacetInfo == other.FacetInfo ||
                    this.FacetInfo != null &&
                    this.FacetInfo.SequenceEqual(other.FacetInfo)
                ) &&
                (
                    this.AuditMessages == other.AuditMessages ||
                    this.AuditMessages != null &&
                    this.AuditMessages.SequenceEqual(other.AuditMessages)
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
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                
                if (this.FacetInfo != null)
                    hash = hash * 59 + this.FacetInfo.GetHashCode();
                
                if (this.AuditMessages != null)
                    hash = hash * 59 + this.AuditMessages.GetHashCode();
                
                return hash;
            }
        }
    }

}
