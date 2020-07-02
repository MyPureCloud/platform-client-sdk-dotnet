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
    /// ReportingDataExportTopicDataExportNotification
    /// </summary>
    [DataContract]
    public partial class ReportingDataExportTopicDataExportNotification :  IEquatable<ReportingDataExportTopicDataExportNotification>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Submitted for "SUBMITTED"
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            Submitted,
            
            /// <summary>
            /// Enum Running for "RUNNING"
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            Running,
            
            /// <summary>
            /// Enum Cancelling for "CANCELLING"
            /// </summary>
            [EnumMember(Value = "CANCELLING")]
            Cancelling,
            
            /// <summary>
            /// Enum Cancelled for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            
            /// <summary>
            /// Enum Completed for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            Completed,
            
            /// <summary>
            /// Enum CompletedWithPartialResults for "COMPLETED_WITH_PARTIAL_RESULTS"
            /// </summary>
            [EnumMember(Value = "COMPLETED_WITH_PARTIAL_RESULTS")]
            CompletedWithPartialResults,
            
            /// <summary>
            /// Enum Failed for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            Failed
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets ExportFormat
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExportFormatEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Csv for "CSV"
            /// </summary>
            [EnumMember(Value = "CSV")]
            Csv,
            
            /// <summary>
            /// Enum Pdf for "PDF"
            /// </summary>
            [EnumMember(Value = "PDF")]
            Pdf
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ViewType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ViewTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum QueuePerformanceSummaryView for "QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            QueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum QueuePerformanceDetailView for "QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_DETAIL_VIEW")]
            QueuePerformanceDetailView,
            
            /// <summary>
            /// Enum InteractionSearchView for "INTERACTION_SEARCH_VIEW"
            /// </summary>
            [EnumMember(Value = "INTERACTION_SEARCH_VIEW")]
            InteractionSearchView,
            
            /// <summary>
            /// Enum AgentPerformanceSummaryView for "AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_SUMMARY_VIEW")]
            AgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentPerformanceDetailView for "AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_DETAIL_VIEW")]
            AgentPerformanceDetailView,
            
            /// <summary>
            /// Enum AgentStatusSummaryView for "AGENT_STATUS_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_SUMMARY_VIEW")]
            AgentStatusSummaryView,
            
            /// <summary>
            /// Enum AgentStatusDetailView for "AGENT_STATUS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_DETAIL_VIEW")]
            AgentStatusDetailView,
            
            /// <summary>
            /// Enum AgentEvaluationSummaryView for "AGENT_EVALUATION_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_SUMMARY_VIEW")]
            AgentEvaluationSummaryView,
            
            /// <summary>
            /// Enum AgentEvaluationDetailView for "AGENT_EVALUATION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_DETAIL_VIEW")]
            AgentEvaluationDetailView,
            
            /// <summary>
            /// Enum AgentQueueDetailView for "AGENT_QUEUE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_QUEUE_DETAIL_VIEW")]
            AgentQueueDetailView,
            
            /// <summary>
            /// Enum AgentInteractionDetailView for "AGENT_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_INTERACTION_DETAIL_VIEW")]
            AgentInteractionDetailView,
            
            /// <summary>
            /// Enum AbandonInsightsView for "ABANDON_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ABANDON_INSIGHTS_VIEW")]
            AbandonInsightsView,
            
            /// <summary>
            /// Enum SkillsPerformanceView for "SKILLS_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "SKILLS_PERFORMANCE_VIEW")]
            SkillsPerformanceView,
            
            /// <summary>
            /// Enum SurveyFormPerformanceSummaryView for "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW")]
            SurveyFormPerformanceSummaryView,
            
            /// <summary>
            /// Enum SurveyFormPerformanceDetailView for "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW")]
            SurveyFormPerformanceDetailView,
            
            /// <summary>
            /// Enum DnisPerformanceSummaryView for "DNIS_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "DNIS_PERFORMANCE_SUMMARY_VIEW")]
            DnisPerformanceSummaryView,
            
            /// <summary>
            /// Enum DnisPerformanceDetailView for "DNIS_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "DNIS_PERFORMANCE_DETAIL_VIEW")]
            DnisPerformanceDetailView,
            
            /// <summary>
            /// Enum WrapUpPerformanceSummaryView for "WRAP_UP_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "WRAP_UP_PERFORMANCE_SUMMARY_VIEW")]
            WrapUpPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentWrapUpPerformanceDetailView for "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW")]
            AgentWrapUpPerformanceDetailView,
            
            /// <summary>
            /// Enum QueueActivitySummaryView for "QUEUE_ACTIVITY_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ACTIVITY_SUMMARY_VIEW")]
            QueueActivitySummaryView,
            
            /// <summary>
            /// Enum QueueActivityDetailView for "QUEUE_ACTIVITY_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ACTIVITY_DETAIL_VIEW")]
            QueueActivityDetailView,
            
            /// <summary>
            /// Enum AgentQueueActivitySummaryView for "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW")]
            AgentQueueActivitySummaryView,
            
            /// <summary>
            /// Enum QueueAgentDetailView for "QUEUE_AGENT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_AGENT_DETAIL_VIEW")]
            QueueAgentDetailView,
            
            /// <summary>
            /// Enum QueueInteractionDetailView for "QUEUE_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_INTERACTION_DETAIL_VIEW")]
            QueueInteractionDetailView,
            
            /// <summary>
            /// Enum AgentScheduleDetailView for "AGENT_SCHEDULE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCHEDULE_DETAIL_VIEW")]
            AgentScheduleDetailView,
            
            /// <summary>
            /// Enum IvrPerformanceSummaryView for "IVR_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "IVR_PERFORMANCE_SUMMARY_VIEW")]
            IvrPerformanceSummaryView,
            
            /// <summary>
            /// Enum IvrPerformanceDetailView for "IVR_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "IVR_PERFORMANCE_DETAIL_VIEW")]
            IvrPerformanceDetailView,
            
            /// <summary>
            /// Enum AnswerInsightsView for "ANSWER_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ANSWER_INSIGHTS_VIEW")]
            AnswerInsightsView,
            
            /// <summary>
            /// Enum HandleInsightsView for "HANDLE_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "HANDLE_INSIGHTS_VIEW")]
            HandleInsightsView,
            
            /// <summary>
            /// Enum TalkInsightsView for "TALK_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "TALK_INSIGHTS_VIEW")]
            TalkInsightsView,
            
            /// <summary>
            /// Enum HoldInsightsView for "HOLD_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "HOLD_INSIGHTS_VIEW")]
            HoldInsightsView,
            
            /// <summary>
            /// Enum AcwInsightsView for "ACW_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ACW_INSIGHTS_VIEW")]
            AcwInsightsView,
            
            /// <summary>
            /// Enum WaitInsightsView for "WAIT_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "WAIT_INSIGHTS_VIEW")]
            WaitInsightsView,
            
            /// <summary>
            /// Enum AgentWrapUpPerformanceIntervalDetailView for "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            AgentWrapUpPerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum FlowOutcomeSummaryView for "FLOW_OUTCOME_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_SUMMARY_VIEW")]
            FlowOutcomeSummaryView,
            
            /// <summary>
            /// Enum FlowOutcomePerformanceDetailView for "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW")]
            FlowOutcomePerformanceDetailView,
            
            /// <summary>
            /// Enum FlowOutcomePerformanceIntervalDetailView for "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            FlowOutcomePerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum FlowDestinationSummaryView for "FLOW_DESTINATION_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_DESTINATION_SUMMARY_VIEW")]
            FlowDestinationSummaryView,
            
            /// <summary>
            /// Enum FlowDestinationDetailView for "FLOW_DESTINATION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_DESTINATION_DETAIL_VIEW")]
            FlowDestinationDetailView
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets ExportErrorMessagesType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExportErrorMessagesTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum FailedConvertingExportJob for "FAILED_CONVERTING_EXPORT_JOB"
            /// </summary>
            [EnumMember(Value = "FAILED_CONVERTING_EXPORT_JOB")]
            FailedConvertingExportJob,
            
            /// <summary>
            /// Enum FailedNoDataExportJobFound for "FAILED_NO_DATA_EXPORT_JOB_FOUND"
            /// </summary>
            [EnumMember(Value = "FAILED_NO_DATA_EXPORT_JOB_FOUND")]
            FailedNoDataExportJobFound,
            
            /// <summary>
            /// Enum FailedGettingDataFromService for "FAILED_GETTING_DATA_FROM_SERVICE"
            /// </summary>
            [EnumMember(Value = "FAILED_GETTING_DATA_FROM_SERVICE")]
            FailedGettingDataFromService,
            
            /// <summary>
            /// Enum FailedGeneratingTempFile for "FAILED_GENERATING_TEMP_FILE"
            /// </summary>
            [EnumMember(Value = "FAILED_GENERATING_TEMP_FILE")]
            FailedGeneratingTempFile,
            
            /// <summary>
            /// Enum FailedSavingFileToS3 for "FAILED_SAVING_FILE_TO_S3"
            /// </summary>
            [EnumMember(Value = "FAILED_SAVING_FILE_TO_S3")]
            FailedSavingFileToS3,
            
            /// <summary>
            /// Enum FailedNotifyingSkywalkerOfDownload for "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD"
            /// </summary>
            [EnumMember(Value = "FAILED_NOTIFYING_SKYWALKER_OF_DOWNLOAD")]
            FailedNotifyingSkywalkerOfDownload,
            
            /// <summary>
            /// Enum FailedBuildingDownloadUrlFromSkywalkerResponse for "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE"
            /// </summary>
            [EnumMember(Value = "FAILED_BUILDING_DOWNLOAD_URL_FROM_SKYWALKER_RESPONSE")]
            FailedBuildingDownloadUrlFromSkywalkerResponse,
            
            /// <summary>
            /// Enum ExportTypeNotImplemented for "EXPORT_TYPE_NOT_IMPLEMENTED"
            /// </summary>
            [EnumMember(Value = "EXPORT_TYPE_NOT_IMPLEMENTED")]
            ExportTypeNotImplemented,
            
            /// <summary>
            /// Enum ReachedMaximumAttemptOfRetry for "REACHED_MAXIMUM_ATTEMPT_OF_RETRY"
            /// </summary>
            [EnumMember(Value = "REACHED_MAXIMUM_ATTEMPT_OF_RETRY")]
            ReachedMaximumAttemptOfRetry,
            
            /// <summary>
            /// Enum FailedLongRunningExport for "FAILED_LONG_RUNNING_EXPORT"
            /// </summary>
            [EnumMember(Value = "FAILED_LONG_RUNNING_EXPORT")]
            FailedLongRunningExport,
            
            /// <summary>
            /// Enum TooManyRequestsFromAnOrganization for "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION"
            /// </summary>
            [EnumMember(Value = "TOO_MANY_REQUESTS_FROM_AN_ORGANIZATION")]
            TooManyRequestsFromAnOrganization
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Inner
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InnerEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sent for "Sent"
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExportFormat
        /// </summary>
        [DataMember(Name="exportFormat", EmitDefaultValue=false)]
        public ExportFormatEnum? ExportFormat { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ViewType
        /// </summary>
        [DataMember(Name="viewType", EmitDefaultValue=false)]
        public ViewTypeEnum? ViewType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExportErrorMessagesType
        /// </summary>
        [DataMember(Name="exportErrorMessagesType", EmitDefaultValue=false)]
        public ExportErrorMessagesTypeEnum? ExportErrorMessagesType { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDataExportTopicDataExportNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ExportFormat">ExportFormat.</param>
        /// <param name="DownloadUrl">DownloadUrl.</param>
        /// <param name="ViewType">ViewType.</param>
        /// <param name="ExportErrorMessagesType">ExportErrorMessagesType.</param>
        /// <param name="Read">Read.</param>
        /// <param name="CreatedDateTime">CreatedDateTime.</param>
        /// <param name="ModifiedDateTime">ModifiedDateTime.</param>
        /// <param name="PercentageComplete">PercentageComplete.</param>
        /// <param name="EmailStatuses">EmailStatuses.</param>
        public ReportingDataExportTopicDataExportNotification(string Id = null, string Name = null, StatusEnum? Status = null, ExportFormatEnum? ExportFormat = null, string DownloadUrl = null, ViewTypeEnum? ViewType = null, ExportErrorMessagesTypeEnum? ExportErrorMessagesType = null, bool? Read = null, DateTime? CreatedDateTime = null, DateTime? ModifiedDateTime = null, double? PercentageComplete = null, Dictionary<string, string> EmailStatuses = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Status = Status;
            this.ExportFormat = ExportFormat;
            this.DownloadUrl = DownloadUrl;
            this.ViewType = ViewType;
            this.ExportErrorMessagesType = ExportErrorMessagesType;
            this.Read = Read;
            this.CreatedDateTime = CreatedDateTime;
            this.ModifiedDateTime = ModifiedDateTime;
            this.PercentageComplete = PercentageComplete;
            this.EmailStatuses = EmailStatuses;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets DownloadUrl
        /// </summary>
        [DataMember(Name="downloadUrl", EmitDefaultValue=false)]
        public string DownloadUrl { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name="read", EmitDefaultValue=false)]
        public bool? Read { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public DateTime? CreatedDateTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ModifiedDateTime
        /// </summary>
        [DataMember(Name="modifiedDateTime", EmitDefaultValue=false)]
        public DateTime? ModifiedDateTime { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PercentageComplete
        /// </summary>
        [DataMember(Name="percentageComplete", EmitDefaultValue=false)]
        public double? PercentageComplete { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmailStatuses
        /// </summary>
        [DataMember(Name="emailStatuses", EmitDefaultValue=false)]
        public Dictionary<string, string> EmailStatuses { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingDataExportTopicDataExportNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExportFormat: ").Append(ExportFormat).Append("\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  ViewType: ").Append(ViewType).Append("\n");
            sb.Append("  ExportErrorMessagesType: ").Append(ExportErrorMessagesType).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  ModifiedDateTime: ").Append(ModifiedDateTime).Append("\n");
            sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
            sb.Append("  EmailStatuses: ").Append(EmailStatuses).Append("\n");
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
            return this.Equals(obj as ReportingDataExportTopicDataExportNotification);
        }

        /// <summary>
        /// Returns true if ReportingDataExportTopicDataExportNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingDataExportTopicDataExportNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingDataExportTopicDataExportNotification other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ExportFormat == other.ExportFormat ||
                    this.ExportFormat != null &&
                    this.ExportFormat.Equals(other.ExportFormat)
                ) &&
                (
                    this.DownloadUrl == other.DownloadUrl ||
                    this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(other.DownloadUrl)
                ) &&
                (
                    this.ViewType == other.ViewType ||
                    this.ViewType != null &&
                    this.ViewType.Equals(other.ViewType)
                ) &&
                (
                    this.ExportErrorMessagesType == other.ExportErrorMessagesType ||
                    this.ExportErrorMessagesType != null &&
                    this.ExportErrorMessagesType.Equals(other.ExportErrorMessagesType)
                ) &&
                (
                    this.Read == other.Read ||
                    this.Read != null &&
                    this.Read.Equals(other.Read)
                ) &&
                (
                    this.CreatedDateTime == other.CreatedDateTime ||
                    this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(other.CreatedDateTime)
                ) &&
                (
                    this.ModifiedDateTime == other.ModifiedDateTime ||
                    this.ModifiedDateTime != null &&
                    this.ModifiedDateTime.Equals(other.ModifiedDateTime)
                ) &&
                (
                    this.PercentageComplete == other.PercentageComplete ||
                    this.PercentageComplete != null &&
                    this.PercentageComplete.Equals(other.PercentageComplete)
                ) &&
                (
                    this.EmailStatuses == other.EmailStatuses ||
                    this.EmailStatuses != null &&
                    this.EmailStatuses.SequenceEqual(other.EmailStatuses)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.ExportFormat != null)
                    hash = hash * 59 + this.ExportFormat.GetHashCode();
                
                if (this.DownloadUrl != null)
                    hash = hash * 59 + this.DownloadUrl.GetHashCode();
                
                if (this.ViewType != null)
                    hash = hash * 59 + this.ViewType.GetHashCode();
                
                if (this.ExportErrorMessagesType != null)
                    hash = hash * 59 + this.ExportErrorMessagesType.GetHashCode();
                
                if (this.Read != null)
                    hash = hash * 59 + this.Read.GetHashCode();
                
                if (this.CreatedDateTime != null)
                    hash = hash * 59 + this.CreatedDateTime.GetHashCode();
                
                if (this.ModifiedDateTime != null)
                    hash = hash * 59 + this.ModifiedDateTime.GetHashCode();
                
                if (this.PercentageComplete != null)
                    hash = hash * 59 + this.PercentageComplete.GetHashCode();
                
                if (this.EmailStatuses != null)
                    hash = hash * 59 + this.EmailStatuses.GetHashCode();
                
                return hash;
            }
        }
    }

}
