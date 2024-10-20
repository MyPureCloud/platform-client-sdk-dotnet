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
    /// WorkitemQueryJobCreate
    /// </summary>
    [DataContract]
    public partial class WorkitemQueryJobCreate :  IEquatable<WorkitemQueryJobCreate>
    {
        /// <summary>
        /// Gets or Sets Expands
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExpandsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Type for "type"
            /// </summary>
            [EnumMember(Value = "type")]
            Type,
            
            /// <summary>
            /// Enum Workbin for "workbin"
            /// </summary>
            [EnumMember(Value = "workbin")]
            Workbin,
            
            /// <summary>
            /// Enum Status for "status"
            /// </summary>
            [EnumMember(Value = "status")]
            Status,
            
            /// <summary>
            /// Enum Assignee for "assignee"
            /// </summary>
            [EnumMember(Value = "assignee")]
            Assignee,
            
            /// <summary>
            /// Enum Reporter for "reporter"
            /// </summary>
            [EnumMember(Value = "reporter")]
            Reporter,
            
            /// <summary>
            /// Enum Queue for "queue"
            /// </summary>
            [EnumMember(Value = "queue")]
            Queue
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryJobCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemQueryJobCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemQueryJobCreate" /> class.
        /// </summary>
        /// <param name="PageSize">The total page size requested. Default 25.</param>
        /// <param name="PageNumber">The page number requested.</param>
        /// <param name="Filters">List of filter objects to be used in the search. (required).</param>
        /// <param name="QueryFilters">Query filters for nested attributes..</param>
        /// <param name="Expands">List of entity attributes to be expanded in the result..</param>
        /// <param name="Attributes">List of entity attributes to be retrieved in the result..</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="DateIntervalStart">Interval start date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateIntervalEnd">Interval end date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public WorkitemQueryJobCreate(int? PageSize = null, int? PageNumber = null, List<WorkitemQueryJobFilter> Filters = null, List<WorkitemQueryJobQueryFilters> QueryFilters = null, List<ExpandsEnum> Expands = null, List<string> Attributes = null, WorkitemQueryJobSort Sort = null, DateTime? DateIntervalStart = null, DateTime? DateIntervalEnd = null)
        {
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
            this.Filters = Filters;
            this.QueryFilters = QueryFilters;
            this.Expands = Expands;
            this.Attributes = Attributes;
            this.Sort = Sort;
            this.DateIntervalStart = DateIntervalStart;
            this.DateIntervalEnd = DateIntervalEnd;
            
        }
        


        /// <summary>
        /// The total page size requested. Default 25
        /// </summary>
        /// <value>The total page size requested. Default 25</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// The page number requested
        /// </summary>
        /// <value>The page number requested</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }



        /// <summary>
        /// List of filter objects to be used in the search.
        /// </summary>
        /// <value>List of filter objects to be used in the search.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<WorkitemQueryJobFilter> Filters { get; set; }



        /// <summary>
        /// Query filters for nested attributes.
        /// </summary>
        /// <value>Query filters for nested attributes.</value>
        [DataMember(Name="queryFilters", EmitDefaultValue=false)]
        public List<WorkitemQueryJobQueryFilters> QueryFilters { get; set; }



        /// <summary>
        /// List of entity attributes to be expanded in the result.
        /// </summary>
        /// <value>List of entity attributes to be expanded in the result.</value>
        [DataMember(Name="expands", EmitDefaultValue=false)]
        public List<ExpandsEnum> Expands { get; set; }



        /// <summary>
        /// List of entity attributes to be retrieved in the result.
        /// </summary>
        /// <value>List of entity attributes to be retrieved in the result.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<string> Attributes { get; set; }



        /// <summary>
        /// Sort
        /// </summary>
        /// <value>Sort</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public WorkitemQueryJobSort Sort { get; set; }



        /// <summary>
        /// Interval start date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Interval start date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateIntervalStart", EmitDefaultValue=false)]
        public DateTime? DateIntervalStart { get; set; }



        /// <summary>
        /// Interval end date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Interval end date to use to filter results based on create date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateIntervalEnd", EmitDefaultValue=false)]
        public DateTime? DateIntervalEnd { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemQueryJobCreate {\n");

            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  QueryFilters: ").Append(QueryFilters).Append("\n");
            sb.Append("  Expands: ").Append(Expands).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  DateIntervalStart: ").Append(DateIntervalStart).Append("\n");
            sb.Append("  DateIntervalEnd: ").Append(DateIntervalEnd).Append("\n");
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
            return this.Equals(obj as WorkitemQueryJobCreate);
        }

        /// <summary>
        /// Returns true if WorkitemQueryJobCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemQueryJobCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemQueryJobCreate other)
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
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.QueryFilters == other.QueryFilters ||
                    this.QueryFilters != null &&
                    this.QueryFilters.SequenceEqual(other.QueryFilters)
                ) &&
                (
                    this.Expands == other.Expands ||
                    this.Expands != null &&
                    this.Expands.SequenceEqual(other.Expands)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) &&
                (
                    this.DateIntervalStart == other.DateIntervalStart ||
                    this.DateIntervalStart != null &&
                    this.DateIntervalStart.Equals(other.DateIntervalStart)
                ) &&
                (
                    this.DateIntervalEnd == other.DateIntervalEnd ||
                    this.DateIntervalEnd != null &&
                    this.DateIntervalEnd.Equals(other.DateIntervalEnd)
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

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                if (this.QueryFilters != null)
                    hash = hash * 59 + this.QueryFilters.GetHashCode();

                if (this.Expands != null)
                    hash = hash * 59 + this.Expands.GetHashCode();

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();

                if (this.DateIntervalStart != null)
                    hash = hash * 59 + this.DateIntervalStart.GetHashCode();

                if (this.DateIntervalEnd != null)
                    hash = hash * 59 + this.DateIntervalEnd.GetHashCode();

                return hash;
            }
        }
    }

}
