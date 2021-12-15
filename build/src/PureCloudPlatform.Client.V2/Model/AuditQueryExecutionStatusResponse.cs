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
    /// AuditQueryExecutionStatusResponse
    /// </summary>
    [DataContract]
    public partial class AuditQueryExecutionStatusResponse :  IEquatable<AuditQueryExecutionStatusResponse>
    {
        
        
        
        
        
        /// <summary>
        /// Status of the audit query execution request.
        /// </summary>
        /// <value>Status of the audit query execution request.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Queued for "Queued"
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued,
            
            /// <summary>
            /// Enum Running for "Running"
            /// </summary>
            [EnumMember(Value = "Running")]
            Running,
            
            /// <summary>
            /// Enum Succeeded for "Succeeded"
            /// </summary>
            [EnumMember(Value = "Succeeded")]
            Succeeded,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Service name for the audit query.
        /// </summary>
        /// <value>Service name for the audit query.</value>
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
            /// Enum Analyticsreporting for "AnalyticsReporting"
            /// </summary>
            [EnumMember(Value = "AnalyticsReporting")]
            Analyticsreporting,
            
            /// <summary>
            /// Enum Architect for "Architect"
            /// </summary>
            [EnumMember(Value = "Architect")]
            Architect,
            
            /// <summary>
            /// Enum Coaching for "Coaching"
            /// </summary>
            [EnumMember(Value = "Coaching")]
            Coaching,
            
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
            /// Enum Datatables for "Datatables"
            /// </summary>
            [EnumMember(Value = "Datatables")]
            Datatables,
            
            /// <summary>
            /// Enum Directory for "Directory"
            /// </summary>
            [EnumMember(Value = "Directory")]
            Directory,
            
            /// <summary>
            /// Enum Dynamicschema for "DynamicSchema"
            /// </summary>
            [EnumMember(Value = "DynamicSchema")]
            Dynamicschema,
            
            /// <summary>
            /// Enum Gamification for "Gamification"
            /// </summary>
            [EnumMember(Value = "Gamification")]
            Gamification,
            
            /// <summary>
            /// Enum Groups for "Groups"
            /// </summary>
            [EnumMember(Value = "Groups")]
            Groups,
            
            /// <summary>
            /// Enum Integrations for "Integrations"
            /// </summary>
            [EnumMember(Value = "Integrations")]
            Integrations,
            
            /// <summary>
            /// Enum Knowledge for "Knowledge"
            /// </summary>
            [EnumMember(Value = "Knowledge")]
            Knowledge,
            
            /// <summary>
            /// Enum Languageunderstanding for "LanguageUnderstanding"
            /// </summary>
            [EnumMember(Value = "LanguageUnderstanding")]
            Languageunderstanding,
            
            /// <summary>
            /// Enum Learning for "Learning"
            /// </summary>
            [EnumMember(Value = "Learning")]
            Learning,
            
            /// <summary>
            /// Enum Limits for "Limits"
            /// </summary>
            [EnumMember(Value = "Limits")]
            Limits,
            
            /// <summary>
            /// Enum Outbound for "Outbound"
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Peoplepermissions for "PeoplePermissions"
            /// </summary>
            [EnumMember(Value = "PeoplePermissions")]
            Peoplepermissions,
            
            /// <summary>
            /// Enum Employeeperformance for "EmployeePerformance"
            /// </summary>
            [EnumMember(Value = "EmployeePerformance")]
            Employeeperformance,
            
            /// <summary>
            /// Enum Predictiveengagement for "PredictiveEngagement"
            /// </summary>
            [EnumMember(Value = "PredictiveEngagement")]
            Predictiveengagement,
            
            /// <summary>
            /// Enum Presence for "Presence"
            /// </summary>
            [EnumMember(Value = "Presence")]
            Presence,
            
            /// <summary>
            /// Enum Quality for "Quality"
            /// </summary>
            [EnumMember(Value = "Quality")]
            Quality,
            
            /// <summary>
            /// Enum Responsemanagement for "ResponseManagement"
            /// </summary>
            [EnumMember(Value = "ResponseManagement")]
            Responsemanagement,
            
            /// <summary>
            /// Enum Routing for "Routing"
            /// </summary>
            [EnumMember(Value = "Routing")]
            Routing,
            
            /// <summary>
            /// Enum Speechandtextanalytics for "SpeechAndTextAnalytics"
            /// </summary>
            [EnumMember(Value = "SpeechAndTextAnalytics")]
            Speechandtextanalytics,
            
            /// <summary>
            /// Enum Telephony for "Telephony"
            /// </summary>
            [EnumMember(Value = "Telephony")]
            Telephony,
            
            /// <summary>
            /// Enum Topicsdefinitions for "TopicsDefinitions"
            /// </summary>
            [EnumMember(Value = "TopicsDefinitions")]
            Topicsdefinitions,
            
            /// <summary>
            /// Enum Triggers for "Triggers"
            /// </summary>
            [EnumMember(Value = "Triggers")]
            Triggers,
            
            /// <summary>
            /// Enum Processautomation for "ProcessAutomation"
            /// </summary>
            [EnumMember(Value = "ProcessAutomation")]
            Processautomation,
            
            /// <summary>
            /// Enum Webdeployments for "WebDeployments"
            /// </summary>
            [EnumMember(Value = "WebDeployments")]
            Webdeployments,
            
            /// <summary>
            /// Enum Webhooks for "Webhooks"
            /// </summary>
            [EnumMember(Value = "Webhooks")]
            Webhooks,
            
            /// <summary>
            /// Enum Workforcemanagement for "WorkforceManagement"
            /// </summary>
            [EnumMember(Value = "WorkforceManagement")]
            Workforcemanagement,
            
            /// <summary>
            /// Enum Messaging for "Messaging"
            /// </summary>
            [EnumMember(Value = "Messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Supportability for "Supportability"
            /// </summary>
            [EnumMember(Value = "Supportability")]
            Supportability,
            
            /// <summary>
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
            /// <summary>
            /// Enum Workitems for "Workitems"
            /// </summary>
            [EnumMember(Value = "Workitems")]
            Workitems
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Status of the audit query execution request.
        /// </summary>
        /// <value>Status of the audit query execution request.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Service name for the audit query.
        /// </summary>
        /// <value>Service name for the audit query.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public ServiceNameEnum? ServiceName { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditQueryExecutionStatusResponse" /> class.
        /// </summary>
        /// <param name="Id">Id of the audit query execution request..</param>
        /// <param name="State">Status of the audit query execution request..</param>
        /// <param name="StartDate">Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Interval">Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="ServiceName">Service name for the audit query..</param>
        /// <param name="Filters">Filters for the audit query..</param>
        /// <param name="Sort">Sort parameter for the audit query..</param>
        public AuditQueryExecutionStatusResponse(string Id = null, StateEnum? State = null, DateTime? StartDate = null, string Interval = null, ServiceNameEnum? ServiceName = null, List<AuditQueryFilter> Filters = null, List<AuditQuerySort> Sort = null)
        {
            this.Id = Id;
            this.State = State;
            this.StartDate = StartDate;
            this.Interval = Interval;
            this.ServiceName = ServiceName;
            this.Filters = Filters;
            this.Sort = Sort;
            
        }
        
        
        
        /// <summary>
        /// Id of the audit query execution request.
        /// </summary>
        /// <value>Id of the audit query execution request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        
        
        /// <summary>
        /// Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Start date and time of the audit query execution. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Interval for the audit query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
        
        
        
        
        
        /// <summary>
        /// Filters for the audit query.
        /// </summary>
        /// <value>Filters for the audit query.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<AuditQueryFilter> Filters { get; set; }
        
        
        
        /// <summary>
        /// Sort parameter for the audit query.
        /// </summary>
        /// <value>Sort parameter for the audit query.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<AuditQuerySort> Sort { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditQueryExecutionStatusResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return this.Equals(obj as AuditQueryExecutionStatusResponse);
        }

        /// <summary>
        /// Returns true if AuditQueryExecutionStatusResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditQueryExecutionStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditQueryExecutionStatusResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                
                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                
                return hash;
            }
        }
    }

}
