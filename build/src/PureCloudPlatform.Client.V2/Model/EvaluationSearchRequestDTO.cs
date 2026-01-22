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
    /// EvaluationSearchRequestDTO
    /// </summary>
    [DataContract]
    public partial class EvaluationSearchRequestDTO :  IEquatable<EvaluationSearchRequestDTO>
    {
        /// <summary>
        /// The sort order for results. Include with sortBy.
        /// </summary>
        /// <value>The sort order for results. Include with sortBy.</value>
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
            Desc
        }
        /// <summary>
        /// The field in the resource that you want to sort the results by. Include with sortOrder.
        /// </summary>
        /// <value>The field in the resource that you want to sort the results by. Include with sortOrder.</value>
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
            /// Enum Conversationdate for "conversationDate"
            /// </summary>
            [EnumMember(Value = "conversationDate")]
            Conversationdate,
            
            /// <summary>
            /// Enum Createddate for "createdDate"
            /// </summary>
            [EnumMember(Value = "createdDate")]
            Createddate,
            
            /// <summary>
            /// Enum Submitteddate for "submittedDate"
            /// </summary>
            [EnumMember(Value = "submittedDate")]
            Submitteddate,
            
            /// <summary>
            /// Enum Releasedate for "releaseDate"
            /// </summary>
            [EnumMember(Value = "releaseDate")]
            Releasedate
        }
        /// <summary>
        /// The sort order for results. Include with sortBy.
        /// </summary>
        /// <value>The sort order for results. Include with sortBy.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// The field in the resource that you want to sort the results by. Include with sortOrder.
        /// </summary>
        /// <value>The field in the resource that you want to sort the results by. Include with sortOrder.</value>
        [DataMember(Name="sortBy", EmitDefaultValue=false)]
        public SortByEnum? SortBy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchRequestDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationSearchRequestDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSearchRequestDTO" /> class.
        /// </summary>
        /// <param name="Query">Query (required).</param>
        /// <param name="Aggregations">Aggregations to compute on the search results.</param>
        /// <param name="PageSize">The number of results per page. For aggregation requests, must be omitted or 0..</param>
        /// <param name="PageNumber">The page of resources you want to retrieve (required).</param>
        /// <param name="SortOrder">The sort order for results. Include with sortBy..</param>
        /// <param name="SortBy">The field in the resource that you want to sort the results by. Include with sortOrder..</param>
        /// <param name="SystemSubmitted">Filter for automated evaluations submitted by virtual supervisor. Defaults to false..</param>
        public EvaluationSearchRequestDTO(List<EvaluationSearchCriteriaDTO> Query = null, List<EvaluationSearchAggregationDTO> Aggregations = null, int? PageSize = null, int? PageNumber = null, SortOrderEnum? SortOrder = null, SortByEnum? SortBy = null, bool? SystemSubmitted = null)
        {
            this.Query = Query;
            this.Aggregations = Aggregations;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.SortOrder = SortOrder;
            this.SortBy = SortBy;
            this.SystemSubmitted = SystemSubmitted;
            
        }
        


        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public List<EvaluationSearchCriteriaDTO> Query { get; set; }



        /// <summary>
        /// Aggregations to compute on the search results
        /// </summary>
        /// <value>Aggregations to compute on the search results</value>
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public List<EvaluationSearchAggregationDTO> Aggregations { get; set; }



        /// <summary>
        /// The number of results per page. For aggregation requests, must be omitted or 0.
        /// </summary>
        /// <value>The number of results per page. For aggregation requests, must be omitted or 0.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// The page of resources you want to retrieve
        /// </summary>
        /// <value>The page of resources you want to retrieve</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }







        /// <summary>
        /// Filter for automated evaluations submitted by virtual supervisor. Defaults to false.
        /// </summary>
        /// <value>Filter for automated evaluations submitted by virtual supervisor. Defaults to false.</value>
        [DataMember(Name="systemSubmitted", EmitDefaultValue=false)]
        public bool? SystemSubmitted { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationSearchRequestDTO {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SystemSubmitted: ").Append(SystemSubmitted).Append("\n");
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
            return this.Equals(obj as EvaluationSearchRequestDTO);
        }

        /// <summary>
        /// Returns true if EvaluationSearchRequestDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationSearchRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationSearchRequestDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.SequenceEqual(other.Query)
                ) &&
                (
                    this.Aggregations == other.Aggregations ||
                    this.Aggregations != null &&
                    this.Aggregations.SequenceEqual(other.Aggregations)
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
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) &&
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
                ) &&
                (
                    this.SystemSubmitted == other.SystemSubmitted ||
                    this.SystemSubmitted != null &&
                    this.SystemSubmitted.Equals(other.SystemSubmitted)
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

                if (this.Aggregations != null)
                    hash = hash * 59 + this.Aggregations.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();

                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();

                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();

                if (this.SystemSubmitted != null)
                    hash = hash * 59 + this.SystemSubmitted.GetHashCode();

                return hash;
            }
        }
    }

}
