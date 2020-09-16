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
    /// AuditRealtimeQueryRequest
    /// </summary>
    [DataContract]
    public partial class AuditRealtimeQueryRequest :  IEquatable<AuditRealtimeQueryRequest>
    {
        
        
        
        
        
        /// <summary>
        /// Name of the service to query audits for.
        /// </summary>
        /// <value>Name of the service to query audits for.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ServiceNameEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Contactcenter for "ContactCenter"
            /// </summary>
            [EnumMember(Value = "ContactCenter")]
            Contactcenter,
            
            /// <summary>
            /// Enum Contentmanagement for "ContentManagement"
            /// </summary>
            [EnumMember(Value = "ContentManagement")]
            Contentmanagement,
            
            /// <summary>
            /// Enum Peoplepermissions for "PeoplePermissions"
            /// </summary>
            [EnumMember(Value = "PeoplePermissions")]
            Peoplepermissions,
            
            /// <summary>
            /// Enum Quality for "Quality"
            /// </summary>
            [EnumMember(Value = "Quality")]
            Quality,
            
            /// <summary>
            /// Enum Languageunderstanding for "LanguageUnderstanding"
            /// </summary>
            [EnumMember(Value = "LanguageUnderstanding")]
            Languageunderstanding,
            
            /// <summary>
            /// Enum Topicsdefinitions for "TopicsDefinitions"
            /// </summary>
            [EnumMember(Value = "TopicsDefinitions")]
            Topicsdefinitions,
            
            /// <summary>
            /// Enum Predictiveengagement for "PredictiveEngagement"
            /// </summary>
            [EnumMember(Value = "PredictiveEngagement")]
            Predictiveengagement,
            
            /// <summary>
            /// Enum Workforcemanagement for "WorkforceManagement"
            /// </summary>
            [EnumMember(Value = "WorkforceManagement")]
            Workforcemanagement,
            
            /// <summary>
            /// Enum Triggers for "Triggers"
            /// </summary>
            [EnumMember(Value = "Triggers")]
            Triggers,
            
            /// <summary>
            /// Enum Responsemanagement for "ResponseManagement"
            /// </summary>
            [EnumMember(Value = "ResponseManagement")]
            Responsemanagement
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Name of the service to query audits for.
        /// </summary>
        /// <value>Name of the service to query audits for.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public ServiceNameEnum? ServiceName { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditRealtimeQueryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditRealtimeQueryRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditRealtimeQueryRequest" /> class.
        /// </summary>
        /// <param name="Interval">Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="ServiceName">Name of the service to query audits for. (required).</param>
        /// <param name="Filters">Additional filters for the query..</param>
        /// <param name="Sort">Sort parameter for the query..</param>
        /// <param name="PageNumber">Page number.</param>
        /// <param name="PageSize">Page size.</param>
        public AuditRealtimeQueryRequest(string Interval = null, ServiceNameEnum? ServiceName = null, List<AuditQueryFilter> Filters = null, List<AuditQuerySort> Sort = null, int? PageNumber = null, int? PageSize = null)
        {
            this.Interval = Interval;
            this.ServiceName = ServiceName;
            this.Filters = Filters;
            this.Sort = Sort;
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            
        }
        
        
        
        /// <summary>
        /// Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Date and time range of data to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
        
        
        
        
        
        /// <summary>
        /// Additional filters for the query.
        /// </summary>
        /// <value>Additional filters for the query.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<AuditQueryFilter> Filters { get; set; }
        
        
        
        /// <summary>
        /// Sort parameter for the query.
        /// </summary>
        /// <value>Sort parameter for the query.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<AuditQuerySort> Sort { get; set; }
        
        
        
        /// <summary>
        /// Page number
        /// </summary>
        /// <value>Page number</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
        
        
        
        /// <summary>
        /// Page size
        /// </summary>
        /// <value>Page size</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditRealtimeQueryRequest {\n");
            
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(obj as AuditRealtimeQueryRequest);
        }

        /// <summary>
        /// Returns true if AuditRealtimeQueryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditRealtimeQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditRealtimeQueryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) &&
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
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
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                
                return hash;
            }
        }
    }

}
