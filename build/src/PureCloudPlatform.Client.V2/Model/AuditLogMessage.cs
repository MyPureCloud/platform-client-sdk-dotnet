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
    /// AuditLogMessage
    /// </summary>
    [DataContract]
    public partial class AuditLogMessage :  IEquatable<AuditLogMessage>
    {
        /// <summary>
        /// Name of the service that logged this audit message.
        /// </summary>
        /// <value>Name of the service that logged this audit message.</value>
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
            /// Enum Agentconfig for "AgentConfig"
            /// </summary>
            [EnumMember(Value = "AgentConfig")]
            Agentconfig,
            
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
            /// Enum Callback for "Callback"
            /// </summary>
            [EnumMember(Value = "Callback")]
            Callback,
            
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
            /// Enum Emails for "Emails"
            /// </summary>
            [EnumMember(Value = "Emails")]
            Emails,
            
            /// <summary>
            /// Enum Employeeperformance for "EmployeePerformance"
            /// </summary>
            [EnumMember(Value = "EmployeePerformance")]
            Employeeperformance,
            
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
            /// Enum Logcapture for "LogCapture"
            /// </summary>
            [EnumMember(Value = "LogCapture")]
            Logcapture,
            
            /// <summary>
            /// Enum Marketplace for "Marketplace"
            /// </summary>
            [EnumMember(Value = "Marketplace")]
            Marketplace,
            
            /// <summary>
            /// Enum Messaging for "Messaging"
            /// </summary>
            [EnumMember(Value = "Messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Numberpurchasing for "NumberPurchasing"
            /// </summary>
            [EnumMember(Value = "NumberPurchasing")]
            Numberpurchasing,
            
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
            /// Enum Processautomation for "ProcessAutomation"
            /// </summary>
            [EnumMember(Value = "ProcessAutomation")]
            Processautomation,
            
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
            /// Enum Scim for "SCIM"
            /// </summary>
            [EnumMember(Value = "SCIM")]
            Scim,
            
            /// <summary>
            /// Enum Scripter for "Scripter"
            /// </summary>
            [EnumMember(Value = "Scripter")]
            Scripter,
            
            /// <summary>
            /// Enum Speechandtextanalytics for "SpeechAndTextAnalytics"
            /// </summary>
            [EnumMember(Value = "SpeechAndTextAnalytics")]
            Speechandtextanalytics,
            
            /// <summary>
            /// Enum Supportability for "Supportability"
            /// </summary>
            [EnumMember(Value = "Supportability")]
            Supportability,
            
            /// <summary>
            /// Enum Telephony for "Telephony"
            /// </summary>
            [EnumMember(Value = "Telephony")]
            Telephony,
            
            /// <summary>
            /// Enum Triggers for "Triggers"
            /// </summary>
            [EnumMember(Value = "Triggers")]
            Triggers,
            
            /// <summary>
            /// Enum Voicemail for "Voicemail"
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail,
            
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
            /// Enum Workitems for "Workitems"
            /// </summary>
            [EnumMember(Value = "Workitems")]
            Workitems
        }
        /// <summary>
        /// Level of this audit message, USER or SYSTEM.
        /// </summary>
        /// <value>Level of this audit message, USER or SYSTEM.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LevelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System
        }
        /// <summary>
        /// Action that took place.
        /// </summary>
        /// <value>Action that took place.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum View for "View"
            /// </summary>
            [EnumMember(Value = "View")]
            View,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Move for "Move"
            /// </summary>
            [EnumMember(Value = "Move")]
            Move,
            
            /// <summary>
            /// Enum Copy for "Copy"
            /// </summary>
            [EnumMember(Value = "Copy")]
            Copy,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete,
            
            /// <summary>
            /// Enum Deleteall for "DeleteAll"
            /// </summary>
            [EnumMember(Value = "DeleteAll")]
            Deleteall,
            
            /// <summary>
            /// Enum Fax for "Fax"
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax,
            
            /// <summary>
            /// Enum Versioncreate for "VersionCreate"
            /// </summary>
            [EnumMember(Value = "VersionCreate")]
            Versioncreate,
            
            /// <summary>
            /// Enum Download for "Download"
            /// </summary>
            [EnumMember(Value = "Download")]
            Download,
            
            /// <summary>
            /// Enum Upload for "Upload"
            /// </summary>
            [EnumMember(Value = "Upload")]
            Upload,
            
            /// <summary>
            /// Enum Memberadd for "MemberAdd"
            /// </summary>
            [EnumMember(Value = "MemberAdd")]
            Memberadd,
            
            /// <summary>
            /// Enum Memberupdate for "MemberUpdate"
            /// </summary>
            [EnumMember(Value = "MemberUpdate")]
            Memberupdate,
            
            /// <summary>
            /// Enum Memberremove for "MemberRemove"
            /// </summary>
            [EnumMember(Value = "MemberRemove")]
            Memberremove,
            
            /// <summary>
            /// Enum Shareadd for "ShareAdd"
            /// </summary>
            [EnumMember(Value = "ShareAdd")]
            Shareadd,
            
            /// <summary>
            /// Enum Shareremove for "ShareRemove"
            /// </summary>
            [EnumMember(Value = "ShareRemove")]
            Shareremove,
            
            /// <summary>
            /// Enum Tagadd for "TagAdd"
            /// </summary>
            [EnumMember(Value = "TagAdd")]
            Tagadd,
            
            /// <summary>
            /// Enum Tagremove for "TagRemove"
            /// </summary>
            [EnumMember(Value = "TagRemove")]
            Tagremove,
            
            /// <summary>
            /// Enum Tagupdate for "TagUpdate"
            /// </summary>
            [EnumMember(Value = "TagUpdate")]
            Tagupdate,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Readall for "ReadAll"
            /// </summary>
            [EnumMember(Value = "ReadAll")]
            Readall,
            
            /// <summary>
            /// Enum Execute for "Execute"
            /// </summary>
            [EnumMember(Value = "Execute")]
            Execute,
            
            /// <summary>
            /// Enum Applyprotection for "ApplyProtection"
            /// </summary>
            [EnumMember(Value = "ApplyProtection")]
            Applyprotection,
            
            /// <summary>
            /// Enum Revokeprotection for "RevokeProtection"
            /// </summary>
            [EnumMember(Value = "RevokeProtection")]
            Revokeprotection,
            
            /// <summary>
            /// Enum Updateretention for "UpdateRetention"
            /// </summary>
            [EnumMember(Value = "UpdateRetention")]
            Updateretention,
            
            /// <summary>
            /// Enum Abandon for "Abandon"
            /// </summary>
            [EnumMember(Value = "Abandon")]
            Abandon,
            
            /// <summary>
            /// Enum Archive for "Archive"
            /// </summary>
            [EnumMember(Value = "Archive")]
            Archive,
            
            /// <summary>
            /// Enum Restorerequest for "RestoreRequest"
            /// </summary>
            [EnumMember(Value = "RestoreRequest")]
            Restorerequest,
            
            /// <summary>
            /// Enum Restorecomplete for "RestoreComplete"
            /// </summary>
            [EnumMember(Value = "RestoreComplete")]
            Restorecomplete,
            
            /// <summary>
            /// Enum Promote for "Promote"
            /// </summary>
            [EnumMember(Value = "Promote")]
            Promote,
            
            /// <summary>
            /// Enum Publish for "Publish"
            /// </summary>
            [EnumMember(Value = "Publish")]
            Publish,
            
            /// <summary>
            /// Enum Unpublish for "Unpublish"
            /// </summary>
            [EnumMember(Value = "Unpublish")]
            Unpublish,
            
            /// <summary>
            /// Enum Activate for "Activate"
            /// </summary>
            [EnumMember(Value = "Activate")]
            Activate,
            
            /// <summary>
            /// Enum Checkin for "Checkin"
            /// </summary>
            [EnumMember(Value = "Checkin")]
            Checkin,
            
            /// <summary>
            /// Enum Checkout for "Checkout"
            /// </summary>
            [EnumMember(Value = "Checkout")]
            Checkout,
            
            /// <summary>
            /// Enum Deactivate for "Deactivate"
            /// </summary>
            [EnumMember(Value = "Deactivate")]
            Deactivate,
            
            /// <summary>
            /// Enum Debug for "Debug"
            /// </summary>
            [EnumMember(Value = "Debug")]
            Debug,
            
            /// <summary>
            /// Enum Save for "Save"
            /// </summary>
            [EnumMember(Value = "Save")]
            Save,
            
            /// <summary>
            /// Enum Revert for "Revert"
            /// </summary>
            [EnumMember(Value = "Revert")]
            Revert,
            
            /// <summary>
            /// Enum Transcode for "Transcode"
            /// </summary>
            [EnumMember(Value = "Transcode")]
            Transcode,
            
            /// <summary>
            /// Enum Enable for "Enable"
            /// </summary>
            [EnumMember(Value = "Enable")]
            Enable,
            
            /// <summary>
            /// Enum Disable for "Disable"
            /// </summary>
            [EnumMember(Value = "Disable")]
            Disable,
            
            /// <summary>
            /// Enum Authorize for "Authorize"
            /// </summary>
            [EnumMember(Value = "Authorize")]
            Authorize,
            
            /// <summary>
            /// Enum Deauthorize for "Deauthorize"
            /// </summary>
            [EnumMember(Value = "Deauthorize")]
            Deauthorize,
            
            /// <summary>
            /// Enum Authenticate for "Authenticate"
            /// </summary>
            [EnumMember(Value = "Authenticate")]
            Authenticate,
            
            /// <summary>
            /// Enum Changepassword for "ChangePassword"
            /// </summary>
            [EnumMember(Value = "ChangePassword")]
            Changepassword,
            
            /// <summary>
            /// Enum Revoke for "Revoke"
            /// </summary>
            [EnumMember(Value = "Revoke")]
            Revoke,
            
            /// <summary>
            /// Enum Export for "Export"
            /// </summary>
            [EnumMember(Value = "Export")]
            Export,
            
            /// <summary>
            /// Enum Append for "Append"
            /// </summary>
            [EnumMember(Value = "Append")]
            Append,
            
            /// <summary>
            /// Enum Recycle for "Recycle"
            /// </summary>
            [EnumMember(Value = "Recycle")]
            Recycle,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Rollback for "Rollback"
            /// </summary>
            [EnumMember(Value = "Rollback")]
            Rollback,
            
            /// <summary>
            /// Enum Implementingchange for "ImplementingChange"
            /// </summary>
            [EnumMember(Value = "ImplementingChange")]
            Implementingchange,
            
            /// <summary>
            /// Enum Changeimplemented for "ChangeImplemented"
            /// </summary>
            [EnumMember(Value = "ChangeImplemented")]
            Changeimplemented,
            
            /// <summary>
            /// Enum Implementingrollback for "ImplementingRollback"
            /// </summary>
            [EnumMember(Value = "ImplementingRollback")]
            Implementingrollback,
            
            /// <summary>
            /// Enum Rollbackimplemented for "RollbackImplemented"
            /// </summary>
            [EnumMember(Value = "RollbackImplemented")]
            Rollbackimplemented,
            
            /// <summary>
            /// Enum Write for "Write"
            /// </summary>
            [EnumMember(Value = "Write")]
            Write,
            
            /// <summary>
            /// Enum Purge for "Purge"
            /// </summary>
            [EnumMember(Value = "Purge")]
            Purge,
            
            /// <summary>
            /// Enum Processed for "Processed"
            /// </summary>
            [EnumMember(Value = "Processed")]
            Processed,
            
            /// <summary>
            /// Enum Remove for "Remove"
            /// </summary>
            [EnumMember(Value = "Remove")]
            Remove,
            
            /// <summary>
            /// Enum Replace for "Replace"
            /// </summary>
            [EnumMember(Value = "Replace")]
            Replace,
            
            /// <summary>
            /// Enum Updateinservice for "UpdateInService"
            /// </summary>
            [EnumMember(Value = "UpdateInService")]
            Updateinservice,
            
            /// <summary>
            /// Enum Updateoutofservice for "UpdateOutOfService"
            /// </summary>
            [EnumMember(Value = "UpdateOutOfService")]
            Updateoutofservice,
            
            /// <summary>
            /// Enum Cycle for "Cycle"
            /// </summary>
            [EnumMember(Value = "Cycle")]
            Cycle,
            
            /// <summary>
            /// Enum Scale for "Scale"
            /// </summary>
            [EnumMember(Value = "Scale")]
            Scale,
            
            /// <summary>
            /// Enum Ipallowlistclear for "IpAllowlistClear"
            /// </summary>
            [EnumMember(Value = "IpAllowlistClear")]
            Ipallowlistclear,
            
            /// <summary>
            /// Enum Addpairingrole for "AddPairingRole"
            /// </summary>
            [EnumMember(Value = "AddPairingRole")]
            Addpairingrole,
            
            /// <summary>
            /// Enum Add for "Add"
            /// </summary>
            [EnumMember(Value = "Add")]
            Add,
            
            /// <summary>
            /// Enum Verify for "Verify"
            /// </summary>
            [EnumMember(Value = "Verify")]
            Verify,
            
            /// <summary>
            /// Enum Assign for "Assign"
            /// </summary>
            [EnumMember(Value = "Assign")]
            Assign,
            
            /// <summary>
            /// Enum Unassign for "Unassign"
            /// </summary>
            [EnumMember(Value = "Unassign")]
            Unassign,
            
            /// <summary>
            /// Enum Reassign for "Reassign"
            /// </summary>
            [EnumMember(Value = "Reassign")]
            Reassign,
            
            /// <summary>
            /// Enum Reschedule for "Reschedule"
            /// </summary>
            [EnumMember(Value = "Reschedule")]
            Reschedule,
            
            /// <summary>
            /// Enum Cancel for "Cancel"
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel,
            
            /// <summary>
            /// Enum Softdelete for "SoftDelete"
            /// </summary>
            [EnumMember(Value = "SoftDelete")]
            Softdelete,
            
            /// <summary>
            /// Enum Harddelete for "HardDelete"
            /// </summary>
            [EnumMember(Value = "HardDelete")]
            Harddelete,
            
            /// <summary>
            /// Enum Reset for "Reset"
            /// </summary>
            [EnumMember(Value = "Reset")]
            Reset,
            
            /// <summary>
            /// Enum Rotate for "Rotate"
            /// </summary>
            [EnumMember(Value = "Rotate")]
            Rotate,
            
            /// <summary>
            /// Enum Restore for "Restore"
            /// </summary>
            [EnumMember(Value = "Restore")]
            Restore,
            
            /// <summary>
            /// Enum Restoreall for "RestoreAll"
            /// </summary>
            [EnumMember(Value = "RestoreAll")]
            Restoreall,
            
            /// <summary>
            /// Enum Restoredeleted for "RestoreDeleted"
            /// </summary>
            [EnumMember(Value = "RestoreDeleted")]
            Restoredeleted,
            
            /// <summary>
            /// Enum Unarchive for "Unarchive"
            /// </summary>
            [EnumMember(Value = "Unarchive")]
            Unarchive,
            
            /// <summary>
            /// Enum Enablecapture for "EnableCapture"
            /// </summary>
            [EnumMember(Value = "EnableCapture")]
            Enablecapture,
            
            /// <summary>
            /// Enum Downloadcapture for "DownloadCapture"
            /// </summary>
            [EnumMember(Value = "DownloadCapture")]
            Downloadcapture
        }
        /// <summary>
        /// Type of the entity that was impacted.
        /// </summary>
        /// <value>Type of the entity that was impacted.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum EntityTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Accesstoken for "AccessToken"
            /// </summary>
            [EnumMember(Value = "AccessToken")]
            Accesstoken,
            
            /// <summary>
            /// Enum Action for "Action"
            /// </summary>
            [EnumMember(Value = "Action")]
            Action,
            
            /// <summary>
            /// Enum Actiondraft for "ActionDraft"
            /// </summary>
            [EnumMember(Value = "ActionDraft")]
            Actiondraft,
            
            /// <summary>
            /// Enum Actionmap for "ActionMap"
            /// </summary>
            [EnumMember(Value = "ActionMap")]
            Actionmap,
            
            /// <summary>
            /// Enum Actiontemplate for "ActionTemplate"
            /// </summary>
            [EnumMember(Value = "ActionTemplate")]
            Actiontemplate,
            
            /// <summary>
            /// Enum Activitycode for "ActivityCode"
            /// </summary>
            [EnumMember(Value = "ActivityCode")]
            Activitycode,
            
            /// <summary>
            /// Enum Adherenceexplanation for "AdherenceExplanation"
            /// </summary>
            [EnumMember(Value = "AdherenceExplanation")]
            Adherenceexplanation,
            
            /// <summary>
            /// Enum Agentroutinginfo for "AgentRoutingInfo"
            /// </summary>
            [EnumMember(Value = "AgentRoutingInfo")]
            Agentroutinginfo,
            
            /// <summary>
            /// Enum Analyticsreportingsettings for "AnalyticsReportingSettings"
            /// </summary>
            [EnumMember(Value = "AnalyticsReportingSettings")]
            Analyticsreportingsettings,
            
            /// <summary>
            /// Enum Annotation for "Annotation"
            /// </summary>
            [EnumMember(Value = "Annotation")]
            Annotation,
            
            /// <summary>
            /// Enum Appointment for "Appointment"
            /// </summary>
            [EnumMember(Value = "Appointment")]
            Appointment,
            
            /// <summary>
            /// Enum Assignment for "Assignment"
            /// </summary>
            [EnumMember(Value = "Assignment")]
            Assignment,
            
            /// <summary>
            /// Enum Attemptlimits for "AttemptLimits"
            /// </summary>
            [EnumMember(Value = "AttemptLimits")]
            Attemptlimits,
            
            /// <summary>
            /// Enum Authorganization for "AuthOrganization"
            /// </summary>
            [EnumMember(Value = "AuthOrganization")]
            Authorganization,
            
            /// <summary>
            /// Enum Authuser for "AuthUser"
            /// </summary>
            [EnumMember(Value = "AuthUser")]
            Authuser,
            
            /// <summary>
            /// Enum Bulk for "Bulk"
            /// </summary>
            [EnumMember(Value = "Bulk")]
            Bulk,
            
            /// <summary>
            /// Enum Bulkactions for "BulkActions"
            /// </summary>
            [EnumMember(Value = "BulkActions")]
            Bulkactions,
            
            /// <summary>
            /// Enum Businessunit for "BusinessUnit"
            /// </summary>
            [EnumMember(Value = "BusinessUnit")]
            Businessunit,
            
            /// <summary>
            /// Enum Calibration for "Calibration"
            /// </summary>
            [EnumMember(Value = "Calibration")]
            Calibration,
            
            /// <summary>
            /// Enum Callabletimeset for "CallableTimeSet"
            /// </summary>
            [EnumMember(Value = "CallableTimeSet")]
            Callabletimeset,
            
            /// <summary>
            /// Enum Callanalysisresponseset for "CallAnalysisResponseSet"
            /// </summary>
            [EnumMember(Value = "CallAnalysisResponseSet")]
            Callanalysisresponseset,
            
            /// <summary>
            /// Enum Campaign for "Campaign"
            /// </summary>
            [EnumMember(Value = "Campaign")]
            Campaign,
            
            /// <summary>
            /// Enum Campaignrule for "CampaignRule"
            /// </summary>
            [EnumMember(Value = "CampaignRule")]
            Campaignrule,
            
            /// <summary>
            /// Enum Campaignschedule for "CampaignSchedule"
            /// </summary>
            [EnumMember(Value = "CampaignSchedule")]
            Campaignschedule,
            
            /// <summary>
            /// Enum Changerequest for "ChangeRequest"
            /// </summary>
            [EnumMember(Value = "ChangeRequest")]
            Changerequest,
            
            /// <summary>
            /// Enum Clickstreamsettings for "ClickstreamSettings"
            /// </summary>
            [EnumMember(Value = "ClickstreamSettings")]
            Clickstreamsettings,
            
            /// <summary>
            /// Enum Composerpage for "ComposerPage"
            /// </summary>
            [EnumMember(Value = "ComposerPage")]
            Composerpage,
            
            /// <summary>
            /// Enum Composerscript for "ComposerScript"
            /// </summary>
            [EnumMember(Value = "ComposerScript")]
            Composerscript,
            
            /// <summary>
            /// Enum Composerpublishedscript for "ComposerPublishedScript"
            /// </summary>
            [EnumMember(Value = "ComposerPublishedScript")]
            Composerpublishedscript,
            
            /// <summary>
            /// Enum Composertemplate for "ComposerTemplate"
            /// </summary>
            [EnumMember(Value = "ComposerTemplate")]
            Composertemplate,
            
            /// <summary>
            /// Enum Configuration for "Configuration"
            /// </summary>
            [EnumMember(Value = "Configuration")]
            Configuration,
            
            /// <summary>
            /// Enum Configurationversion for "ConfigurationVersion"
            /// </summary>
            [EnumMember(Value = "ConfigurationVersion")]
            Configurationversion,
            
            /// <summary>
            /// Enum Contactlist for "ContactList"
            /// </summary>
            [EnumMember(Value = "ContactList")]
            Contactlist,
            
            /// <summary>
            /// Enum Contactlistfilter for "ContactListFilter"
            /// </summary>
            [EnumMember(Value = "ContactListFilter")]
            Contactlistfilter,
            
            /// <summary>
            /// Enum Contactschema for "ContactSchema"
            /// </summary>
            [EnumMember(Value = "ContactSchema")]
            Contactschema,
            
            /// <summary>
            /// Enum Conversationattributes for "ConversationAttributes"
            /// </summary>
            [EnumMember(Value = "ConversationAttributes")]
            Conversationattributes,
            
            /// <summary>
            /// Enum Conversationaccount for "ConversationAccount"
            /// </summary>
            [EnumMember(Value = "ConversationAccount")]
            Conversationaccount,
            
            /// <summary>
            /// Enum Conversationdefaultsupportedcontent for "ConversationDefaultSupportedContent"
            /// </summary>
            [EnumMember(Value = "ConversationDefaultSupportedContent")]
            Conversationdefaultsupportedcontent,
            
            /// <summary>
            /// Enum Conversationphonenumber for "ConversationPhoneNumber"
            /// </summary>
            [EnumMember(Value = "ConversationPhoneNumber")]
            Conversationphonenumber,
            
            /// <summary>
            /// Enum Conversationrecipient for "ConversationRecipient"
            /// </summary>
            [EnumMember(Value = "ConversationRecipient")]
            Conversationrecipient,
            
            /// <summary>
            /// Enum Conversationthreadingwindow for "ConversationThreadingWindow"
            /// </summary>
            [EnumMember(Value = "ConversationThreadingWindow")]
            Conversationthreadingwindow,
            
            /// <summary>
            /// Enum Credential for "Credential"
            /// </summary>
            [EnumMember(Value = "Credential")]
            Credential,
            
            /// <summary>
            /// Enum Dashboardsettings for "DashboardSettings"
            /// </summary>
            [EnumMember(Value = "DashboardSettings")]
            Dashboardsettings,
            
            /// <summary>
            /// Enum Defaultpanelsettings for "DefaultPanelSettings"
            /// </summary>
            [EnumMember(Value = "DefaultPanelSettings")]
            Defaultpanelsettings,
            
            /// <summary>
            /// Enum Dependencytrackingbuild for "DependencyTrackingBuild"
            /// </summary>
            [EnumMember(Value = "DependencyTrackingBuild")]
            Dependencytrackingbuild,
            
            /// <summary>
            /// Enum Deployment for "Deployment"
            /// </summary>
            [EnumMember(Value = "Deployment")]
            Deployment,
            
            /// <summary>
            /// Enum Did for "DID"
            /// </summary>
            [EnumMember(Value = "DID")]
            Did,
            
            /// <summary>
            /// Enum Didpool for "DIDPool"
            /// </summary>
            [EnumMember(Value = "DIDPool")]
            Didpool,
            
            /// <summary>
            /// Enum Digitalruleset for "DigitalRuleSet"
            /// </summary>
            [EnumMember(Value = "DigitalRuleSet")]
            Digitalruleset,
            
            /// <summary>
            /// Enum Directorygroup for "DirectoryGroup"
            /// </summary>
            [EnumMember(Value = "DirectoryGroup")]
            Directorygroup,
            
            /// <summary>
            /// Enum Dnclist for "DNCList"
            /// </summary>
            [EnumMember(Value = "DNCList")]
            Dnclist,
            
            /// <summary>
            /// Enum Document for "Document"
            /// </summary>
            [EnumMember(Value = "Document")]
            Document,
            
            /// <summary>
            /// Enum Dynamicgroup for "DynamicGroup"
            /// </summary>
            [EnumMember(Value = "DynamicGroup")]
            Dynamicgroup,
            
            /// <summary>
            /// Enum Dynamicschema for "DynamicSchema"
            /// </summary>
            [EnumMember(Value = "DynamicSchema")]
            Dynamicschema,
            
            /// <summary>
            /// Enum Edge for "Edge"
            /// </summary>
            [EnumMember(Value = "Edge")]
            Edge,
            
            /// <summary>
            /// Enum Edgegroup for "EdgeGroup"
            /// </summary>
            [EnumMember(Value = "EdgeGroup")]
            Edgegroup,
            
            /// <summary>
            /// Enum Edgelog for "EdgeLog"
            /// </summary>
            [EnumMember(Value = "EdgeLog")]
            Edgelog,
            
            /// <summary>
            /// Enum Edgelogzip for "EdgeLogZip"
            /// </summary>
            [EnumMember(Value = "EdgeLogZip")]
            Edgelogzip,
            
            /// <summary>
            /// Enum Edgepcaps for "EdgePcaps"
            /// </summary>
            [EnumMember(Value = "EdgePcaps")]
            Edgepcaps,
            
            /// <summary>
            /// Enum Edgepreferences for "EdgePreferences"
            /// </summary>
            [EnumMember(Value = "EdgePreferences")]
            Edgepreferences,
            
            /// <summary>
            /// Enum Edgetracelevel for "EdgeTraceLevel"
            /// </summary>
            [EnumMember(Value = "EdgeTraceLevel")]
            Edgetracelevel,
            
            /// <summary>
            /// Enum Emailcampaignschedule for "EmailCampaignSchedule"
            /// </summary>
            [EnumMember(Value = "EmailCampaignSchedule")]
            Emailcampaignschedule,
            
            /// <summary>
            /// Enum Emergencygroup for "EmergencyGroup"
            /// </summary>
            [EnumMember(Value = "EmergencyGroup")]
            Emergencygroup,
            
            /// <summary>
            /// Enum Enterpriseagreement for "EnterpriseAgreement"
            /// </summary>
            [EnumMember(Value = "EnterpriseAgreement")]
            Enterpriseagreement,
            
            /// <summary>
            /// Enum Evaluation for "Evaluation"
            /// </summary>
            [EnumMember(Value = "Evaluation")]
            Evaluation,
            
            /// <summary>
            /// Enum Evaluationform for "EvaluationForm"
            /// </summary>
            [EnumMember(Value = "EvaluationForm")]
            Evaluationform,
            
            /// <summary>
            /// Enum Eventtype for "EventType"
            /// </summary>
            [EnumMember(Value = "EventType")]
            Eventtype,
            
            /// <summary>
            /// Enum Exports for "Exports"
            /// </summary>
            [EnumMember(Value = "Exports")]
            Exports,
            
            /// <summary>
            /// Enum Extension for "Extension"
            /// </summary>
            [EnumMember(Value = "Extension")]
            Extension,
            
            /// <summary>
            /// Enum Extensionpool for "ExtensionPool"
            /// </summary>
            [EnumMember(Value = "ExtensionPool")]
            Extensionpool,
            
            /// <summary>
            /// Enum Externalmetricsdata for "ExternalMetricsData"
            /// </summary>
            [EnumMember(Value = "ExternalMetricsData")]
            Externalmetricsdata,
            
            /// <summary>
            /// Enum Externalmetricsdefinition for "ExternalMetricsDefinition"
            /// </summary>
            [EnumMember(Value = "ExternalMetricsDefinition")]
            Externalmetricsdefinition,
            
            /// <summary>
            /// Enum Externalorganizationschema for "ExternalOrganizationSchema"
            /// </summary>
            [EnumMember(Value = "ExternalOrganizationSchema")]
            Externalorganizationschema,
            
            /// <summary>
            /// Enum Feedback for "Feedback"
            /// </summary>
            [EnumMember(Value = "Feedback")]
            Feedback,
            
            /// <summary>
            /// Enum Flow for "Flow"
            /// </summary>
            [EnumMember(Value = "Flow")]
            Flow,
            
            /// <summary>
            /// Enum Flowmilestone for "FlowMilestone"
            /// </summary>
            [EnumMember(Value = "FlowMilestone")]
            Flowmilestone,
            
            /// <summary>
            /// Enum Flowoutcome for "FlowOutcome"
            /// </summary>
            [EnumMember(Value = "FlowOutcome")]
            Flowoutcome,
            
            /// <summary>
            /// Enum Forecast for "Forecast"
            /// </summary>
            [EnumMember(Value = "Forecast")]
            Forecast,
            
            /// <summary>
            /// Enum Gdprrequest for "GdprRequest"
            /// </summary>
            [EnumMember(Value = "GdprRequest")]
            Gdprrequest,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Historicaldata for "HistoricalData"
            /// </summary>
            [EnumMember(Value = "HistoricalData")]
            Historicaldata,
            
            /// <summary>
            /// Enum Inbounddomain for "InboundDomain"
            /// </summary>
            [EnumMember(Value = "InboundDomain")]
            Inbounddomain,
            
            /// <summary>
            /// Enum Inboundroute for "InboundRoute"
            /// </summary>
            [EnumMember(Value = "InboundRoute")]
            Inboundroute,
            
            /// <summary>
            /// Enum Insightsettings for "InsightSettings"
            /// </summary>
            [EnumMember(Value = "InsightSettings")]
            Insightsettings,
            
            /// <summary>
            /// Enum Integration for "Integration"
            /// </summary>
            [EnumMember(Value = "Integration")]
            Integration,
            
            /// <summary>
            /// Enum Intentminer for "IntentMiner"
            /// </summary>
            [EnumMember(Value = "IntentMiner")]
            Intentminer,
            
            /// <summary>
            /// Enum Ivr for "IVR"
            /// </summary>
            [EnumMember(Value = "IVR")]
            Ivr,
            
            /// <summary>
            /// Enum Knowledgebase for "KnowledgeBase"
            /// </summary>
            [EnumMember(Value = "KnowledgeBase")]
            Knowledgebase,
            
            /// <summary>
            /// Enum Knowledgecategory for "KnowledgeCategory"
            /// </summary>
            [EnumMember(Value = "KnowledgeCategory")]
            Knowledgecategory,
            
            /// <summary>
            /// Enum Knowledgedocument for "KnowledgeDocument"
            /// </summary>
            [EnumMember(Value = "KnowledgeDocument")]
            Knowledgedocument,
            
            /// <summary>
            /// Enum Knowledgedocumentvariation for "KnowledgeDocumentVariation"
            /// </summary>
            [EnumMember(Value = "KnowledgeDocumentVariation")]
            Knowledgedocumentvariation,
            
            /// <summary>
            /// Enum Knowledgelabel for "KnowledgeLabel"
            /// </summary>
            [EnumMember(Value = "KnowledgeLabel")]
            Knowledgelabel,
            
            /// <summary>
            /// Enum Knowledgesearchfeedback for "KnowledgeSearchFeedback"
            /// </summary>
            [EnumMember(Value = "KnowledgeSearchFeedback")]
            Knowledgesearchfeedback,
            
            /// <summary>
            /// Enum Knowledgetraining for "KnowledgeTraining"
            /// </summary>
            [EnumMember(Value = "KnowledgeTraining")]
            Knowledgetraining,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>
            [EnumMember(Value = "Line")]
            Line,
            
            /// <summary>
            /// Enum Linebase for "LineBase"
            /// </summary>
            [EnumMember(Value = "LineBase")]
            Linebase,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Managementunit for "ManagementUnit"
            /// </summary>
            [EnumMember(Value = "ManagementUnit")]
            Managementunit,
            
            /// <summary>
            /// Enum Maxorgroutingutilizationcapacity for "MaxOrgRoutingUtilizationCapacity"
            /// </summary>
            [EnumMember(Value = "MaxOrgRoutingUtilizationCapacity")]
            Maxorgroutingutilizationcapacity,
            
            /// <summary>
            /// Enum Mediadiagnosticstracefile for "MediaDiagnosticsTraceFile"
            /// </summary>
            [EnumMember(Value = "MediaDiagnosticsTraceFile")]
            Mediadiagnosticstracefile,
            
            /// <summary>
            /// Enum Messagingcampaign for "MessagingCampaign"
            /// </summary>
            [EnumMember(Value = "MessagingCampaign")]
            Messagingcampaign,
            
            /// <summary>
            /// Enum Messagingcampaignschedule for "MessagingCampaignSchedule"
            /// </summary>
            [EnumMember(Value = "MessagingCampaignSchedule")]
            Messagingcampaignschedule,
            
            /// <summary>
            /// Enum Metric for "Metric"
            /// </summary>
            [EnumMember(Value = "Metric")]
            Metric,
            
            /// <summary>
            /// Enum Module for "Module"
            /// </summary>
            [EnumMember(Value = "Module")]
            Module,
            
            /// <summary>
            /// Enum Numberorder for "NumberOrder"
            /// </summary>
            [EnumMember(Value = "NumberOrder")]
            Numberorder,
            
            /// <summary>
            /// Enum Numberplan for "NumberPlan"
            /// </summary>
            [EnumMember(Value = "NumberPlan")]
            Numberplan,
            
            /// <summary>
            /// Enum Oauthclient for "OAuthClient"
            /// </summary>
            [EnumMember(Value = "OAuthClient")]
            Oauthclient,
            
            /// <summary>
            /// Enum Oauthclientauthorization for "OAuthClientAuthorization"
            /// </summary>
            [EnumMember(Value = "OAuthClientAuthorization")]
            Oauthclientauthorization,
            
            /// <summary>
            /// Enum Organization for "Organization"
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization,
            
            /// <summary>
            /// Enum Organizationauthorizationtrust for "OrganizationAuthorizationTrust"
            /// </summary>
            [EnumMember(Value = "OrganizationAuthorizationTrust")]
            Organizationauthorizationtrust,
            
            /// <summary>
            /// Enum Organizationauthorizationusertrust for "OrganizationAuthorizationUserTrust"
            /// </summary>
            [EnumMember(Value = "OrganizationAuthorizationUserTrust")]
            Organizationauthorizationusertrust,
            
            /// <summary>
            /// Enum Organizationfeature for "OrganizationFeature"
            /// </summary>
            [EnumMember(Value = "OrganizationFeature")]
            Organizationfeature,
            
            /// <summary>
            /// Enum Organizationintegrationsaccess for "OrganizationIntegrationsAccess"
            /// </summary>
            [EnumMember(Value = "OrganizationIntegrationsAccess")]
            Organizationintegrationsaccess,
            
            /// <summary>
            /// Enum Organizationlimits for "OrganizationLimits"
            /// </summary>
            [EnumMember(Value = "OrganizationLimits")]
            Organizationlimits,
            
            /// <summary>
            /// Enum Organizationsettings for "OrganizationSettings"
            /// </summary>
            [EnumMember(Value = "OrganizationSettings")]
            Organizationsettings,
            
            /// <summary>
            /// Enum Orphanedrecording for "OrphanedRecording"
            /// </summary>
            [EnumMember(Value = "OrphanedRecording")]
            Orphanedrecording,
            
            /// <summary>
            /// Enum Outbounddomain for "OutboundDomain"
            /// </summary>
            [EnumMember(Value = "OutboundDomain")]
            Outbounddomain,
            
            /// <summary>
            /// Enum Outboundroute for "OutboundRoute"
            /// </summary>
            [EnumMember(Value = "OutboundRoute")]
            Outboundroute,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
            /// <summary>
            /// Enum Pcaps for "Pcaps"
            /// </summary>
            [EnumMember(Value = "Pcaps")]
            Pcaps,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Phonebase for "PhoneBase"
            /// </summary>
            [EnumMember(Value = "PhoneBase")]
            Phonebase,
            
            /// <summary>
            /// Enum Planninggroup for "PlanningGroup"
            /// </summary>
            [EnumMember(Value = "PlanningGroup")]
            Planninggroup,
            
            /// <summary>
            /// Enum Policy for "Policy"
            /// </summary>
            [EnumMember(Value = "Policy")]
            Policy,
            
            /// <summary>
            /// Enum Predictor for "Predictor"
            /// </summary>
            [EnumMember(Value = "Predictor")]
            Predictor,
            
            /// <summary>
            /// Enum Product for "Product"
            /// </summary>
            [EnumMember(Value = "Product")]
            Product,
            
            /// <summary>
            /// Enum Profile for "Profile"
            /// </summary>
            [EnumMember(Value = "Profile")]
            Profile,
            
            /// <summary>
            /// Enum Profilemembers for "ProfileMembers"
            /// </summary>
            [EnumMember(Value = "ProfileMembers")]
            Profilemembers,
            
            /// <summary>
            /// Enum Program for "Program"
            /// </summary>
            [EnumMember(Value = "Program")]
            Program,
            
            /// <summary>
            /// Enum Prompt for "Prompt"
            /// </summary>
            [EnumMember(Value = "Prompt")]
            Prompt,
            
            /// <summary>
            /// Enum Promptresource for "PromptResource"
            /// </summary>
            [EnumMember(Value = "PromptResource")]
            Promptresource,
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Recording for "Recording"
            /// </summary>
            [EnumMember(Value = "Recording")]
            Recording,
            
            /// <summary>
            /// Enum Recordingannotation for "RecordingAnnotation"
            /// </summary>
            [EnumMember(Value = "RecordingAnnotation")]
            Recordingannotation,
            
            /// <summary>
            /// Enum Recordingkey for "RecordingKey"
            /// </summary>
            [EnumMember(Value = "RecordingKey")]
            Recordingkey,
            
            /// <summary>
            /// Enum Recordingkeyconfig for "RecordingKeyConfig"
            /// </summary>
            [EnumMember(Value = "RecordingKeyConfig")]
            Recordingkeyconfig,
            
            /// <summary>
            /// Enum Recordingsettings for "RecordingSettings"
            /// </summary>
            [EnumMember(Value = "RecordingSettings")]
            Recordingsettings,
            
            /// <summary>
            /// Enum Response for "Response"
            /// </summary>
            [EnumMember(Value = "Response")]
            Response,
            
            /// <summary>
            /// Enum Responseasset for "ResponseAsset"
            /// </summary>
            [EnumMember(Value = "ResponseAsset")]
            Responseasset,
            
            /// <summary>
            /// Enum Role for "Role"
            /// </summary>
            [EnumMember(Value = "Role")]
            Role,
            
            /// <summary>
            /// Enum Rolesettings for "RoleSettings"
            /// </summary>
            [EnumMember(Value = "RoleSettings")]
            Rolesettings,
            
            /// <summary>
            /// Enum Row for "Row"
            /// </summary>
            [EnumMember(Value = "Row")]
            Row,
            
            /// <summary>
            /// Enum Routingtranscriptionsettings for "RoutingTranscriptionSettings"
            /// </summary>
            [EnumMember(Value = "RoutingTranscriptionSettings")]
            Routingtranscriptionsettings,
            
            /// <summary>
            /// Enum Routingutilizationtag for "RoutingUtilizationTag"
            /// </summary>
            [EnumMember(Value = "RoutingUtilizationTag")]
            Routingutilizationtag,
            
            /// <summary>
            /// Enum Rule for "Rule"
            /// </summary>
            [EnumMember(Value = "Rule")]
            Rule,
            
            /// <summary>
            /// Enum Ruleset for "RuleSet"
            /// </summary>
            [EnumMember(Value = "RuleSet")]
            Ruleset,
            
            /// <summary>
            /// Enum Schedule for "Schedule"
            /// </summary>
            [EnumMember(Value = "Schedule")]
            Schedule,
            
            /// <summary>
            /// Enum Scheduledexports for "ScheduledExports"
            /// </summary>
            [EnumMember(Value = "ScheduledExports")]
            Scheduledexports,
            
            /// <summary>
            /// Enum Schedulegroup for "ScheduleGroup"
            /// </summary>
            [EnumMember(Value = "ScheduleGroup")]
            Schedulegroup,
            
            /// <summary>
            /// Enum Schema for "Schema"
            /// </summary>
            [EnumMember(Value = "Schema")]
            Schema,
            
            /// <summary>
            /// Enum Screenrecording for "ScreenRecording"
            /// </summary>
            [EnumMember(Value = "ScreenRecording")]
            Screenrecording,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Sentimentfeedback for "SentimentFeedback"
            /// </summary>
            [EnumMember(Value = "SentimentFeedback")]
            Sentimentfeedback,
            
            /// <summary>
            /// Enum Sequence for "Sequence"
            /// </summary>
            [EnumMember(Value = "Sequence")]
            Sequence,
            
            /// <summary>
            /// Enum Sequenceschedule for "SequenceSchedule"
            /// </summary>
            [EnumMember(Value = "SequenceSchedule")]
            Sequenceschedule,
            
            /// <summary>
            /// Enum Servicegoaltemplate for "ServiceGoalTemplate"
            /// </summary>
            [EnumMember(Value = "ServiceGoalTemplate")]
            Servicegoaltemplate,
            
            /// <summary>
            /// Enum Sessiontype for "SessionType"
            /// </summary>
            [EnumMember(Value = "SessionType")]
            Sessiontype,
            
            /// <summary>
            /// Enum Shifttrade for "ShiftTrade"
            /// </summary>
            [EnumMember(Value = "ShiftTrade")]
            Shifttrade,
            
            /// <summary>
            /// Enum Site for "Site"
            /// </summary>
            [EnumMember(Value = "Site")]
            Site,
            
            /// <summary>
            /// Enum Skillsgroup for "SkillsGroup"
            /// </summary>
            [EnumMember(Value = "SkillsGroup")]
            Skillsgroup,
            
            /// <summary>
            /// Enum Speechtextanalyticssettings for "SpeechTextAnalyticsSettings"
            /// </summary>
            [EnumMember(Value = "SpeechTextAnalyticsSettings")]
            Speechtextanalyticssettings,
            
            /// <summary>
            /// Enum Status for "Status"
            /// </summary>
            [EnumMember(Value = "Status")]
            Status,
            
            /// <summary>
            /// Enum Supportedcontent for "SupportedContent"
            /// </summary>
            [EnumMember(Value = "SupportedContent")]
            Supportedcontent,
            
            /// <summary>
            /// Enum Supportfile for "SupportFile"
            /// </summary>
            [EnumMember(Value = "SupportFile")]
            Supportfile,
            
            /// <summary>
            /// Enum Survey for "Survey"
            /// </summary>
            [EnumMember(Value = "Survey")]
            Survey,
            
            /// <summary>
            /// Enum Surveyform for "SurveyForm"
            /// </summary>
            [EnumMember(Value = "SurveyForm")]
            Surveyform,
            
            /// <summary>
            /// Enum Tag for "Tag"
            /// </summary>
            [EnumMember(Value = "Tag")]
            Tag,
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,
            
            /// <summary>
            /// Enum Timeofflimit for "TimeOffLimit"
            /// </summary>
            [EnumMember(Value = "TimeOffLimit")]
            Timeofflimit,
            
            /// <summary>
            /// Enum Timeoffplan for "TimeOffPlan"
            /// </summary>
            [EnumMember(Value = "TimeOffPlan")]
            Timeoffplan,
            
            /// <summary>
            /// Enum Timeoffrequest for "TimeOffRequest"
            /// </summary>
            [EnumMember(Value = "TimeOffRequest")]
            Timeoffrequest,
            
            /// <summary>
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Topicminer for "TopicMiner"
            /// </summary>
            [EnumMember(Value = "TopicMiner")]
            Topicminer,
            
            /// <summary>
            /// Enum Transcriptionsettings for "TranscriptionSettings"
            /// </summary>
            [EnumMember(Value = "TranscriptionSettings")]
            Transcriptionsettings,
            
            /// <summary>
            /// Enum Trigger for "Trigger"
            /// </summary>
            [EnumMember(Value = "Trigger")]
            Trigger,
            
            /// <summary>
            /// Enum Trunk for "Trunk"
            /// </summary>
            [EnumMember(Value = "Trunk")]
            Trunk,
            
            /// <summary>
            /// Enum Trunkbase for "TrunkBase"
            /// </summary>
            [EnumMember(Value = "TrunkBase")]
            Trunkbase,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Userlanguage for "UserLanguage"
            /// </summary>
            [EnumMember(Value = "UserLanguage")]
            Userlanguage,
            
            /// <summary>
            /// Enum Userpresence for "UserPresence"
            /// </summary>
            [EnumMember(Value = "UserPresence")]
            Userpresence,
            
            /// <summary>
            /// Enum Userskill for "UserSkill"
            /// </summary>
            [EnumMember(Value = "UserSkill")]
            Userskill,
            
            /// <summary>
            /// Enum Voicemailpolicy for "VoicemailPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailPolicy")]
            Voicemailpolicy,
            
            /// <summary>
            /// Enum Voicemailuserpolicy for "VoicemailUserPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailUserPolicy")]
            Voicemailuserpolicy,
            
            /// <summary>
            /// Enum Webhook for "Webhook"
            /// </summary>
            [EnumMember(Value = "Webhook")]
            Webhook,
            
            /// <summary>
            /// Enum Workbin for "Workbin"
            /// </summary>
            [EnumMember(Value = "Workbin")]
            Workbin,
            
            /// <summary>
            /// Enum Workitem for "Workitem"
            /// </summary>
            [EnumMember(Value = "Workitem")]
            Workitem,
            
            /// <summary>
            /// Enum Workplan for "WorkPlan"
            /// </summary>
            [EnumMember(Value = "WorkPlan")]
            Workplan,
            
            /// <summary>
            /// Enum Workplanrotation for "WorkPlanRotation"
            /// </summary>
            [EnumMember(Value = "WorkPlanRotation")]
            Workplanrotation,
            
            /// <summary>
            /// Enum Workspace for "Workspace"
            /// </summary>
            [EnumMember(Value = "Workspace")]
            Workspace,
            
            /// <summary>
            /// Enum Worktype for "Worktype"
            /// </summary>
            [EnumMember(Value = "Worktype")]
            Worktype,
            
            /// <summary>
            /// Enum Wrapupcode for "WrapupCode"
            /// </summary>
            [EnumMember(Value = "WrapupCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Wrapupcodemapping for "WrapUpCodeMapping"
            /// </summary>
            [EnumMember(Value = "WrapUpCodeMapping")]
            Wrapupcodemapping,
            
            /// <summary>
            /// Enum Participant for "Participant"
            /// </summary>
            [EnumMember(Value = "Participant")]
            Participant
        }
        /// <summary>
        /// Status of the event being audited
        /// </summary>
        /// <value>Status of the event being audited</value>
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
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Failure for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            Failure,
            
            /// <summary>
            /// Enum Warning for "WARNING"
            /// </summary>
            [EnumMember(Value = "WARNING")]
            Warning
        }
        /// <summary>
        /// Name of the service that logged this audit message.
        /// </summary>
        /// <value>Name of the service that logged this audit message.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public ServiceNameEnum? ServiceName { get; set; }
        /// <summary>
        /// Level of this audit message, USER or SYSTEM.
        /// </summary>
        /// <value>Level of this audit message, USER or SYSTEM.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Action that took place.
        /// </summary>
        /// <value>Action that took place.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Type of the entity that was impacted.
        /// </summary>
        /// <value>Type of the entity that was impacted.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        /// <summary>
        /// Status of the event being audited
        /// </summary>
        /// <value>Status of the event being audited</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogMessage" /> class.
        /// </summary>
        /// <param name="Id">Id of the audit message..</param>
        /// <param name="UserHomeOrgId">Home Organization Id associated with this audit message..</param>
        /// <param name="User">User associated with this audit message..</param>
        /// <param name="Client">Client associated with this audit message..</param>
        /// <param name="RemoteIp">List of IP addresses of systems that originated or handled the request..</param>
        /// <param name="ServiceName">Name of the service that logged this audit message..</param>
        /// <param name="Level">Level of this audit message, USER or SYSTEM..</param>
        /// <param name="EventDate">Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Message">Message describing the event being audited..</param>
        /// <param name="Action">Action that took place..</param>
        /// <param name="Entity">Entity that was impacted..</param>
        /// <param name="EntityType">Type of the entity that was impacted..</param>
        /// <param name="Status">Status of the event being audited.</param>
        /// <param name="Application">Name of the application used to perform the audit's action.</param>
        /// <param name="InitiatingAction">Id and action of the audit initiating the transaction.</param>
        /// <param name="TransactionInitiator">Whether the current audit is the initiator of the transaction.</param>
        /// <param name="PropertyChanges">List of properties that were changed and changes made to those properties..</param>
        /// <param name="Context">Additional context for this message..</param>
        /// <param name="EntityChanges">List of entities that were changed and changes made to those entities..</param>
        public AuditLogMessage(string Id = null, string UserHomeOrgId = null, DomainEntityRef User = null, AddressableEntityRef Client = null, List<string> RemoteIp = null, ServiceNameEnum? ServiceName = null, LevelEnum? Level = null, DateTime? EventDate = null, MessageInfo Message = null, ActionEnum? Action = null, DomainEntityRef Entity = null, EntityTypeEnum? EntityType = null, StatusEnum? Status = null, string Application = null, InitiatingAction InitiatingAction = null, bool? TransactionInitiator = null, List<PropertyChange> PropertyChanges = null, Dictionary<string, string> Context = null, List<EntityChange> EntityChanges = null)
        {
            this.Id = Id;
            this.UserHomeOrgId = UserHomeOrgId;
            this.User = User;
            this.Client = Client;
            this.RemoteIp = RemoteIp;
            this.ServiceName = ServiceName;
            this.Level = Level;
            this.EventDate = EventDate;
            this.Message = Message;
            this.Action = Action;
            this.Entity = Entity;
            this.EntityType = EntityType;
            this.Status = Status;
            this.Application = Application;
            this.InitiatingAction = InitiatingAction;
            this.TransactionInitiator = TransactionInitiator;
            this.PropertyChanges = PropertyChanges;
            this.Context = Context;
            this.EntityChanges = EntityChanges;
            
        }
        


        /// <summary>
        /// Id of the audit message.
        /// </summary>
        /// <value>Id of the audit message.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Home Organization Id associated with this audit message.
        /// </summary>
        /// <value>Home Organization Id associated with this audit message.</value>
        [DataMember(Name="userHomeOrgId", EmitDefaultValue=false)]
        public string UserHomeOrgId { get; set; }



        /// <summary>
        /// User associated with this audit message.
        /// </summary>
        /// <value>User associated with this audit message.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public DomainEntityRef User { get; set; }



        /// <summary>
        /// Client associated with this audit message.
        /// </summary>
        /// <value>Client associated with this audit message.</value>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public AddressableEntityRef Client { get; set; }



        /// <summary>
        /// List of IP addresses of systems that originated or handled the request.
        /// </summary>
        /// <value>List of IP addresses of systems that originated or handled the request.</value>
        [DataMember(Name="remoteIp", EmitDefaultValue=false)]
        public List<string> RemoteIp { get; set; }







        /// <summary>
        /// Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date and time of when the audit message was logged. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        public DateTime? EventDate { get; set; }



        /// <summary>
        /// Message describing the event being audited.
        /// </summary>
        /// <value>Message describing the event being audited.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public MessageInfo Message { get; set; }





        /// <summary>
        /// Entity that was impacted.
        /// </summary>
        /// <value>Entity that was impacted.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public DomainEntityRef Entity { get; set; }







        /// <summary>
        /// Name of the application used to perform the audit's action
        /// </summary>
        /// <value>Name of the application used to perform the audit's action</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public string Application { get; set; }



        /// <summary>
        /// Id and action of the audit initiating the transaction
        /// </summary>
        /// <value>Id and action of the audit initiating the transaction</value>
        [DataMember(Name="initiatingAction", EmitDefaultValue=false)]
        public InitiatingAction InitiatingAction { get; set; }



        /// <summary>
        /// Whether the current audit is the initiator of the transaction
        /// </summary>
        /// <value>Whether the current audit is the initiator of the transaction</value>
        [DataMember(Name="transactionInitiator", EmitDefaultValue=false)]
        public bool? TransactionInitiator { get; set; }



        /// <summary>
        /// List of properties that were changed and changes made to those properties.
        /// </summary>
        /// <value>List of properties that were changed and changes made to those properties.</value>
        [DataMember(Name="propertyChanges", EmitDefaultValue=false)]
        public List<PropertyChange> PropertyChanges { get; set; }



        /// <summary>
        /// Additional context for this message.
        /// </summary>
        /// <value>Additional context for this message.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public Dictionary<string, string> Context { get; set; }



        /// <summary>
        /// List of entities that were changed and changes made to those entities.
        /// </summary>
        /// <value>List of entities that were changed and changes made to those entities.</value>
        [DataMember(Name="entityChanges", EmitDefaultValue=false)]
        public List<EntityChange> EntityChanges { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditLogMessage {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserHomeOrgId: ").Append(UserHomeOrgId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  RemoteIp: ").Append(RemoteIp).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  InitiatingAction: ").Append(InitiatingAction).Append("\n");
            sb.Append("  TransactionInitiator: ").Append(TransactionInitiator).Append("\n");
            sb.Append("  PropertyChanges: ").Append(PropertyChanges).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  EntityChanges: ").Append(EntityChanges).Append("\n");
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
            return this.Equals(obj as AuditLogMessage);
        }

        /// <summary>
        /// Returns true if AuditLogMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditLogMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogMessage other)
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
                    this.UserHomeOrgId == other.UserHomeOrgId ||
                    this.UserHomeOrgId != null &&
                    this.UserHomeOrgId.Equals(other.UserHomeOrgId)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
                ) &&
                (
                    this.RemoteIp == other.RemoteIp ||
                    this.RemoteIp != null &&
                    this.RemoteIp.SequenceEqual(other.RemoteIp)
                ) &&
                (
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.EventDate == other.EventDate ||
                    this.EventDate != null &&
                    this.EventDate.Equals(other.EventDate)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Application == other.Application ||
                    this.Application != null &&
                    this.Application.Equals(other.Application)
                ) &&
                (
                    this.InitiatingAction == other.InitiatingAction ||
                    this.InitiatingAction != null &&
                    this.InitiatingAction.Equals(other.InitiatingAction)
                ) &&
                (
                    this.TransactionInitiator == other.TransactionInitiator ||
                    this.TransactionInitiator != null &&
                    this.TransactionInitiator.Equals(other.TransactionInitiator)
                ) &&
                (
                    this.PropertyChanges == other.PropertyChanges ||
                    this.PropertyChanges != null &&
                    this.PropertyChanges.SequenceEqual(other.PropertyChanges)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.SequenceEqual(other.Context)
                ) &&
                (
                    this.EntityChanges == other.EntityChanges ||
                    this.EntityChanges != null &&
                    this.EntityChanges.SequenceEqual(other.EntityChanges)
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

                if (this.UserHomeOrgId != null)
                    hash = hash * 59 + this.UserHomeOrgId.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();

                if (this.RemoteIp != null)
                    hash = hash * 59 + this.RemoteIp.GetHashCode();

                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();

                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.EventDate != null)
                    hash = hash * 59 + this.EventDate.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Application != null)
                    hash = hash * 59 + this.Application.GetHashCode();

                if (this.InitiatingAction != null)
                    hash = hash * 59 + this.InitiatingAction.GetHashCode();

                if (this.TransactionInitiator != null)
                    hash = hash * 59 + this.TransactionInitiator.GetHashCode();

                if (this.PropertyChanges != null)
                    hash = hash * 59 + this.PropertyChanges.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                if (this.EntityChanges != null)
                    hash = hash * 59 + this.EntityChanges.GetHashCode();

                return hash;
            }
        }
    }

}
