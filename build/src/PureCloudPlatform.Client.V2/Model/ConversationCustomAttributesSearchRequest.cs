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
    /// ConversationCustomAttributesSearchRequest
    /// </summary>
    [DataContract]
    public partial class ConversationCustomAttributesSearchRequest :  IEquatable<ConversationCustomAttributesSearchRequest>
    {
        /// <summary>
        /// The sort order for results
        /// </summary>
        /// <value>The sort order for results</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SortOrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Asc for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            Desc,
            
            /// <summary>
            /// Enum Score for "SCORE"
            /// </summary>
            [EnumMember(Value = "SCORE")]
            Score
        }
        /// <summary>
        /// The sort order for results
        /// </summary>
        /// <value>The sort order for results</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCustomAttributesSearchRequest" /> class.
        /// </summary>
        /// <param name="Expand">Expand your search with bulk lookups.</param>
        /// <param name="PageSize">The number of results per page.</param>
        /// <param name="PageNumber">The page of resources you want to retrieve.</param>
        /// <param name="Sort">Multi-value sort order, list of multiple sort values.</param>
        /// <param name="SortBy">The field in the resource that you want to sort the results by.</param>
        /// <param name="SortOrder">The sort order for results.</param>
        public ConversationCustomAttributesSearchRequest(List<string> Expand = null, int? PageSize = null, int? PageNumber = null, List<SearchSort> Sort = null, string SortBy = null, SortOrderEnum? SortOrder = null)
        {
            this.Expand = Expand;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.Sort = Sort;
            this.SortBy = SortBy;
            this.SortOrder = SortOrder;
            
        }
        


        /// <summary>
        /// Expand your search with bulk lookups
        /// </summary>
        /// <value>Expand your search with bulk lookups</value>
        [DataMember(Name="expand", EmitDefaultValue=false)]
        public List<string> Expand { get; set; }



        /// <summary>
        /// The number of results per page
        /// </summary>
        /// <value>The number of results per page</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// The page of resources you want to retrieve
        /// </summary>
        /// <value>The page of resources you want to retrieve</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// Multi-value sort order, list of multiple sort values
        /// </summary>
        /// <value>Multi-value sort order, list of multiple sort values</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<SearchSort> Sort { get; set; }



        /// <summary>
        /// The field in the resource that you want to sort the results by
        /// </summary>
        /// <value>The field in the resource that you want to sort the results by</value>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public string SortBy { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationCustomAttributesSearchRequest {\n");

            sb.Append("  Expand: ").Append(Expand).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(obj as ConversationCustomAttributesSearchRequest);
        }

        /// <summary>
        /// Returns true if ConversationCustomAttributesSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationCustomAttributesSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationCustomAttributesSearchRequest other)
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
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
                ) &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
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

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();

                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();

                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();

                return hash;
            }
        }
    }

}
