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
    /// KnowledgeDocumentQuery
    /// </summary>
    [DataContract]
    public partial class KnowledgeDocumentQuery :  IEquatable<KnowledgeDocumentQuery>
    {
        /// <summary>
        /// Indicates which document variations to include in returned documents. All: all variations regardless of the filter expression; AllMatching: all variations that match the filter expression; SingleMostRelevant: single variation that matches the filter expression and has the highest priority. The default is All.
        /// </summary>
        /// <value>Indicates which document variations to include in returned documents. All: all variations regardless of the filter expression; AllMatching: all variations that match the filter expression; SingleMostRelevant: single variation that matches the filter expression and has the highest priority. The default is All.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IncludeVariationsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Allmatching for "AllMatching"
            /// </summary>
            [EnumMember(Value = "AllMatching")]
            Allmatching,
            
            /// <summary>
            /// Enum Singlemostrelevant for "SingleMostRelevant"
            /// </summary>
            [EnumMember(Value = "SingleMostRelevant")]
            Singlemostrelevant
        }
        /// <summary>
        /// The sort order for results.
        /// </summary>
        /// <value>The sort order for results.</value>
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
            /// Enum Asc for "Asc"
            /// </summary>
            [EnumMember(Value = "Asc")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "Desc"
            /// </summary>
            [EnumMember(Value = "Desc")]
            Desc
        }
        /// <summary>
        /// The field in the documents that you want to sort the results by.
        /// </summary>
        /// <value>The field in the documents that you want to sort the results by.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SortByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Datecreated for "DateCreated"
            /// </summary>
            [EnumMember(Value = "DateCreated")]
            Datecreated,
            
            /// <summary>
            /// Enum Datemodified for "DateModified"
            /// </summary>
            [EnumMember(Value = "DateModified")]
            Datemodified,
            
            /// <summary>
            /// Enum Categoryname for "CategoryName"
            /// </summary>
            [EnumMember(Value = "CategoryName")]
            Categoryname,
            
            /// <summary>
            /// Enum Labelname for "LabelName"
            /// </summary>
            [EnumMember(Value = "LabelName")]
            Labelname,
            
            /// <summary>
            /// Enum Viewcount for "ViewCount"
            /// </summary>
            [EnumMember(Value = "ViewCount")]
            Viewcount
        }
        /// <summary>
        /// Indicates which document variations to include in returned documents. All: all variations regardless of the filter expression; AllMatching: all variations that match the filter expression; SingleMostRelevant: single variation that matches the filter expression and has the highest priority. The default is All.
        /// </summary>
        /// <value>Indicates which document variations to include in returned documents. All: all variations regardless of the filter expression; AllMatching: all variations that match the filter expression; SingleMostRelevant: single variation that matches the filter expression and has the highest priority. The default is All.</value>
        [DataMember(Name="includeVariations", EmitDefaultValue=false)]
        public IncludeVariationsEnum? IncludeVariations { get; set; }
        /// <summary>
        /// The sort order for results.
        /// </summary>
        /// <value>The sort order for results.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// The field in the documents that you want to sort the results by.
        /// </summary>
        /// <value>The field in the documents that you want to sort the results by.</value>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public SortByEnum? SortBy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeDocumentQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeDocumentQuery" /> class.
        /// </summary>
        /// <param name="PageSize">Page size of the returned results..</param>
        /// <param name="PageNumber">Page number of the returned results..</param>
        /// <param name="IncludeDraftDocuments">Indicates whether the results would also include draft documents..</param>
        /// <param name="Interval">Retrieves the documents created/modified/published in specified date and time range..</param>
        /// <param name="Filter">Filter for the document query. (required).</param>
        /// <param name="IncludeVariations">Indicates which document variations to include in returned documents. All: all variations regardless of the filter expression; AllMatching: all variations that match the filter expression; SingleMostRelevant: single variation that matches the filter expression and has the highest priority. The default is All..</param>
        /// <param name="SortOrder">The sort order for results..</param>
        /// <param name="SortBy">The field in the documents that you want to sort the results by..</param>
        public KnowledgeDocumentQuery(int? PageSize = null, int? PageNumber = null, bool? IncludeDraftDocuments = null, DocumentQueryInterval Interval = null, DocumentQuery Filter = null, IncludeVariationsEnum? IncludeVariations = null, SortOrderEnum? SortOrder = null, SortByEnum? SortBy = null)
        {
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.IncludeDraftDocuments = IncludeDraftDocuments;
            this.Interval = Interval;
            this.Filter = Filter;
            this.IncludeVariations = IncludeVariations;
            this.SortOrder = SortOrder;
            this.SortBy = SortBy;
            
        }
        


        /// <summary>
        /// Page size of the returned results.
        /// </summary>
        /// <value>Page size of the returned results.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Page number of the returned results.
        /// </summary>
        /// <value>Page number of the returned results.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// Indicates whether the results would also include draft documents.
        /// </summary>
        /// <value>Indicates whether the results would also include draft documents.</value>
        [DataMember(Name="includeDraftDocuments", EmitDefaultValue=false)]
        public bool? IncludeDraftDocuments { get; set; }



        /// <summary>
        /// Retrieves the documents created/modified/published in specified date and time range.
        /// </summary>
        /// <value>Retrieves the documents created/modified/published in specified date and time range.</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public DocumentQueryInterval Interval { get; set; }



        /// <summary>
        /// Filter for the document query.
        /// </summary>
        /// <value>Filter for the document query.</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public DocumentQuery Filter { get; set; }








        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeDocumentQuery {\n");

            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  IncludeDraftDocuments: ").Append(IncludeDraftDocuments).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  IncludeVariations: ").Append(IncludeVariations).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
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
            return this.Equals(obj as KnowledgeDocumentQuery);
        }

        /// <summary>
        /// Returns true if KnowledgeDocumentQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeDocumentQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeDocumentQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.IncludeDraftDocuments == other.IncludeDraftDocuments ||
                    this.IncludeDraftDocuments != null &&
                    this.IncludeDraftDocuments.Equals(other.IncludeDraftDocuments)
                ) &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.IncludeVariations == other.IncludeVariations ||
                    this.IncludeVariations != null &&
                    this.IncludeVariations.Equals(other.IncludeVariations)
                ) &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
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
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.IncludeDraftDocuments != null)
                    hash = hash * 59 + this.IncludeDraftDocuments.GetHashCode();

                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.IncludeVariations != null)
                    hash = hash * 59 + this.IncludeVariations.GetHashCode();

                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();

                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();

                return hash;
            }
        }
    }

}
