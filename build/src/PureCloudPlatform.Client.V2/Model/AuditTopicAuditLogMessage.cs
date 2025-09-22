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
    /// AuditTopicAuditLogMessage
    /// </summary>
    [DataContract]
    public partial class AuditTopicAuditLogMessage :  IEquatable<AuditTopicAuditLogMessage>
    {
        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
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
            /// Enum Languageunderstanding for "LanguageUnderstanding"
            /// </summary>
            [EnumMember(Value = "LanguageUnderstanding")]
            Languageunderstanding,
            
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
            /// Enum Presence for "Presence"
            /// </summary>
            [EnumMember(Value = "Presence")]
            Presence,
            
            /// <summary>
            /// Enum Architect for "Architect"
            /// </summary>
            [EnumMember(Value = "Architect")]
            Architect,
            
            /// <summary>
            /// Enum Contactcenter for "ContactCenter"
            /// </summary>
            [EnumMember(Value = "ContactCenter")]
            Contactcenter,
            
            /// <summary>
            /// Enum Quality for "Quality"
            /// </summary>
            [EnumMember(Value = "Quality")]
            Quality,
            
            /// <summary>
            /// Enum Speechandtextanalytics for "SpeechAndTextAnalytics"
            /// </summary>
            [EnumMember(Value = "SpeechAndTextAnalytics")]
            Speechandtextanalytics,
            
            /// <summary>
            /// Enum Predictiveengagement for "PredictiveEngagement"
            /// </summary>
            [EnumMember(Value = "PredictiveEngagement")]
            Predictiveengagement,
            
            /// <summary>
            /// Enum Knowledge for "Knowledge"
            /// </summary>
            [EnumMember(Value = "Knowledge")]
            Knowledge,
            
            /// <summary>
            /// Enum Coaching for "Coaching"
            /// </summary>
            [EnumMember(Value = "Coaching")]
            Coaching,
            
            /// <summary>
            /// Enum Learning for "Learning"
            /// </summary>
            [EnumMember(Value = "Learning")]
            Learning,
            
            /// <summary>
            /// Enum Usersrules for "UsersRules"
            /// </summary>
            [EnumMember(Value = "UsersRules")]
            Usersrules,
            
            /// <summary>
            /// Enum Gamification for "Gamification"
            /// </summary>
            [EnumMember(Value = "Gamification")]
            Gamification,
            
            /// <summary>
            /// Enum Employeeengagement for "EmployeeEngagement"
            /// </summary>
            [EnumMember(Value = "EmployeeEngagement")]
            Employeeengagement,
            
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
            /// Enum Processautomation for "ProcessAutomation"
            /// </summary>
            [EnumMember(Value = "ProcessAutomation")]
            Processautomation,
            
            /// <summary>
            /// Enum Responsemanagement for "ResponseManagement"
            /// </summary>
            [EnumMember(Value = "ResponseManagement")]
            Responsemanagement,
            
            /// <summary>
            /// Enum Groups for "Groups"
            /// </summary>
            [EnumMember(Value = "Groups")]
            Groups,
            
            /// <summary>
            /// Enum Telephony for "Telephony"
            /// </summary>
            [EnumMember(Value = "Telephony")]
            Telephony,
            
            /// <summary>
            /// Enum Outbound for "Outbound"
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Routing for "Routing"
            /// </summary>
            [EnumMember(Value = "Routing")]
            Routing,
            
            /// <summary>
            /// Enum Integrations for "Integrations"
            /// </summary>
            [EnumMember(Value = "Integrations")]
            Integrations,
            
            /// <summary>
            /// Enum Webhooks for "Webhooks"
            /// </summary>
            [EnumMember(Value = "Webhooks")]
            Webhooks,
            
            /// <summary>
            /// Enum Analyticsreporting for "AnalyticsReporting"
            /// </summary>
            [EnumMember(Value = "AnalyticsReporting")]
            Analyticsreporting,
            
            /// <summary>
            /// Enum Limits for "Limits"
            /// </summary>
            [EnumMember(Value = "Limits")]
            Limits,
            
            /// <summary>
            /// Enum Employeeperformance for "EmployeePerformance"
            /// </summary>
            [EnumMember(Value = "EmployeePerformance")]
            Employeeperformance,
            
            /// <summary>
            /// Enum Datatables for "Datatables"
            /// </summary>
            [EnumMember(Value = "Datatables")]
            Datatables,
            
            /// <summary>
            /// Enum Messaging for "Messaging"
            /// </summary>
            [EnumMember(Value = "Messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Webdeployments for "WebDeployments"
            /// </summary>
            [EnumMember(Value = "WebDeployments")]
            Webdeployments,
            
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
            /// Enum Directory for "Directory"
            /// </summary>
            [EnumMember(Value = "Directory")]
            Directory,
            
            /// <summary>
            /// Enum Externalcontacts for "ExternalContacts"
            /// </summary>
            [EnumMember(Value = "ExternalContacts")]
            Externalcontacts,
            
            /// <summary>
            /// Enum Taskmanagement for "TaskManagement"
            /// </summary>
            [EnumMember(Value = "TaskManagement")]
            Taskmanagement,
            
            /// <summary>
            /// Enum Scim for "SCIM"
            /// </summary>
            [EnumMember(Value = "SCIM")]
            Scim,
            
            /// <summary>
            /// Enum Numberpurchasing for "NumberPurchasing"
            /// </summary>
            [EnumMember(Value = "NumberPurchasing")]
            Numberpurchasing,
            
            /// <summary>
            /// Enum Marketplace for "Marketplace"
            /// </summary>
            [EnumMember(Value = "Marketplace")]
            Marketplace,
            
            /// <summary>
            /// Enum Logcapture for "LogCapture"
            /// </summary>
            [EnumMember(Value = "LogCapture")]
            Logcapture,
            
            /// <summary>
            /// Enum Gdpr for "GDPR"
            /// </summary>
            [EnumMember(Value = "GDPR")]
            Gdpr,
            
            /// <summary>
            /// Enum Dsar for "DSAR"
            /// </summary>
            [EnumMember(Value = "DSAR")]
            Dsar,
            
            /// <summary>
            /// Enum Externalcontactsexport for "ExternalContactsExport"
            /// </summary>
            [EnumMember(Value = "ExternalContactsExport")]
            Externalcontactsexport,
            
            /// <summary>
            /// Enum Agentconfig for "AgentConfig"
            /// </summary>
            [EnumMember(Value = "AgentConfig")]
            Agentconfig,
            
            /// <summary>
            /// Enum Emails for "Emails"
            /// </summary>
            [EnumMember(Value = "Emails")]
            Emails,
            
            /// <summary>
            /// Enum Scripter for "Scripter"
            /// </summary>
            [EnumMember(Value = "Scripter")]
            Scripter,
            
            /// <summary>
            /// Enum Billing for "Billing"
            /// </summary>
            [EnumMember(Value = "Billing")]
            Billing,
            
            /// <summary>
            /// Enum Journeyanalytics for "JourneyAnalytics"
            /// </summary>
            [EnumMember(Value = "JourneyAnalytics")]
            Journeyanalytics,
            
            /// <summary>
            /// Enum Nerservice for "NerService"
            /// </summary>
            [EnumMember(Value = "NerService")]
            Nerservice,
            
            /// <summary>
            /// Enum Onboarding for "Onboarding"
            /// </summary>
            [EnumMember(Value = "Onboarding")]
            Onboarding,
            
            /// <summary>
            /// Enum Sociallistening for "SocialListening"
            /// </summary>
            [EnumMember(Value = "SocialListening")]
            Sociallistening,
            
            /// <summary>
            /// Enum Businessrules for "BusinessRules"
            /// </summary>
            [EnumMember(Value = "BusinessRules")]
            Businessrules,
            
            /// <summary>
            /// Enum Socialescalationrules for "SocialEscalationRules"
            /// </summary>
            [EnumMember(Value = "SocialEscalationRules")]
            Socialescalationrules,
            
            /// <summary>
            /// Enum Alerting for "Alerting"
            /// </summary>
            [EnumMember(Value = "Alerting")]
            Alerting
        }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
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
            /// Enum View for "View"
            /// </summary>
            [EnumMember(Value = "View")]
            View,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete,
            
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
            /// Enum Download for "Download"
            /// </summary>
            [EnumMember(Value = "Download")]
            Download,
            
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
            /// Enum Fax for "Fax"
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax,
            
            /// <summary>
            /// Enum Convert for "Convert"
            /// </summary>
            [EnumMember(Value = "Convert")]
            Convert,
            
            /// <summary>
            /// Enum Receive for "Receive"
            /// </summary>
            [EnumMember(Value = "Receive")]
            Receive,
            
            /// <summary>
            /// Enum Versioncreate for "VersionCreate"
            /// </summary>
            [EnumMember(Value = "VersionCreate")]
            Versioncreate,
            
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
            /// Enum Add for "Add"
            /// </summary>
            [EnumMember(Value = "Add")]
            Add,
            
            /// <summary>
            /// Enum Remove for "Remove"
            /// </summary>
            [EnumMember(Value = "Remove")]
            Remove,
            
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
            /// Enum Authenticate for "Authenticate"
            /// </summary>
            [EnumMember(Value = "Authenticate")]
            Authenticate,
            
            /// <summary>
            /// Enum Authenticationfailed for "AuthenticationFailed"
            /// </summary>
            [EnumMember(Value = "AuthenticationFailed")]
            Authenticationfailed,
            
            /// <summary>
            /// Enum Singlelogout for "SingleLogout"
            /// </summary>
            [EnumMember(Value = "SingleLogout")]
            Singlelogout,
            
            /// <summary>
            /// Enum Singlelogoutfailed for "SingleLogoutFailed"
            /// </summary>
            [EnumMember(Value = "SingleLogoutFailed")]
            Singlelogoutfailed,
            
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
            /// Enum Authorizationchanged for "AuthorizationChanged"
            /// </summary>
            [EnumMember(Value = "AuthorizationChanged")]
            Authorizationchanged,
            
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
            /// Enum Licenseupdate for "LicenseUpdate"
            /// </summary>
            [EnumMember(Value = "LicenseUpdate")]
            Licenseupdate,
            
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
            /// Enum Publish for "Publish"
            /// </summary>
            [EnumMember(Value = "Publish")]
            Publish,
            
            /// <summary>
            /// Enum Revert for "Revert"
            /// </summary>
            [EnumMember(Value = "Revert")]
            Revert,
            
            /// <summary>
            /// Enum Save for "Save"
            /// </summary>
            [EnumMember(Value = "Save")]
            Save,
            
            /// <summary>
            /// Enum Transcode for "Transcode"
            /// </summary>
            [EnumMember(Value = "Transcode")]
            Transcode,
            
            /// <summary>
            /// Enum Upload for "Upload"
            /// </summary>
            [EnumMember(Value = "Upload")]
            Upload,
            
            /// <summary>
            /// Enum Wrapupcodeadd for "WrapupCodeAdd"
            /// </summary>
            [EnumMember(Value = "WrapupCodeAdd")]
            Wrapupcodeadd,
            
            /// <summary>
            /// Enum Wrapupcoderemove for "WrapupCodeRemove"
            /// </summary>
            [EnumMember(Value = "WrapupCodeRemove")]
            Wrapupcoderemove,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Execute for "Execute"
            /// </summary>
            [EnumMember(Value = "Execute")]
            Execute,
            
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
            /// Enum Export for "Export"
            /// </summary>
            [EnumMember(Value = "Export")]
            Export,
            
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
            /// Enum Updateretention for "UpdateRetention"
            /// </summary>
            [EnumMember(Value = "UpdateRetention")]
            Updateretention,
            
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
            /// Enum Rotate for "Rotate"
            /// </summary>
            [EnumMember(Value = "Rotate")]
            Rotate,
            
            /// <summary>
            /// Enum Deleteall for "DeleteAll"
            /// </summary>
            [EnumMember(Value = "DeleteAll")]
            Deleteall,
            
            /// <summary>
            /// Enum Reassign for "Reassign"
            /// </summary>
            [EnumMember(Value = "Reassign")]
            Reassign,
            
            /// <summary>
            /// Enum Unarchive for "Unarchive"
            /// </summary>
            [EnumMember(Value = "Unarchive")]
            Unarchive,
            
            /// <summary>
            /// Enum Activate for "Activate"
            /// </summary>
            [EnumMember(Value = "Activate")]
            Activate,
            
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
            /// Enum Reset for "Reset"
            /// </summary>
            [EnumMember(Value = "Reset")]
            Reset,
            
            /// <summary>
            /// Enum Reschedule for "Reschedule"
            /// </summary>
            [EnumMember(Value = "Reschedule")]
            Reschedule,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Cancel for "Cancel"
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel,
            
            /// <summary>
            /// Enum Unpublish for "Unpublish"
            /// </summary>
            [EnumMember(Value = "Unpublish")]
            Unpublish,
            
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
            /// Enum Recycle for "Recycle"
            /// </summary>
            [EnumMember(Value = "Recycle")]
            Recycle,
            
            /// <summary>
            /// Enum Append for "Append"
            /// </summary>
            [EnumMember(Value = "Append")]
            Append,
            
            /// <summary>
            /// Enum Contactsupdated for "ContactsUpdated"
            /// </summary>
            [EnumMember(Value = "ContactsUpdated")]
            Contactsupdated,
            
            /// <summary>
            /// Enum Contactsdeleted for "ContactsDeleted"
            /// </summary>
            [EnumMember(Value = "ContactsDeleted")]
            Contactsdeleted,
            
            /// <summary>
            /// Enum Restore for "Restore"
            /// </summary>
            [EnumMember(Value = "Restore")]
            Restore,
            
            /// <summary>
            /// Enum Block for "Block"
            /// </summary>
            [EnumMember(Value = "Block")]
            Block,
            
            /// <summary>
            /// Enum Unblock for "Unblock"
            /// </summary>
            [EnumMember(Value = "Unblock")]
            Unblock,
            
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
            /// Enum Inreview for "InReview"
            /// </summary>
            [EnumMember(Value = "InReview")]
            Inreview,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted,
            
            /// <summary>
            /// Enum Write for "Write"
            /// </summary>
            [EnumMember(Value = "Write")]
            Write,
            
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
            /// Enum Asginservice for "AsgInservice"
            /// </summary>
            [EnumMember(Value = "AsgInservice")]
            Asginservice,
            
            /// <summary>
            /// Enum Awsoutofservice for "AwsOutofservice"
            /// </summary>
            [EnumMember(Value = "AwsOutofservice")]
            Awsoutofservice,
            
            /// <summary>
            /// Enum Asgterminate for "AsgTerminate"
            /// </summary>
            [EnumMember(Value = "AsgTerminate")]
            Asgterminate,
            
            /// <summary>
            /// Enum Detach for "Detach"
            /// </summary>
            [EnumMember(Value = "Detach")]
            Detach,
            
            /// <summary>
            /// Enum Terminate for "Terminate"
            /// </summary>
            [EnumMember(Value = "Terminate")]
            Terminate,
            
            /// <summary>
            /// Enum Blockupgrade for "BlockUpgrade"
            /// </summary>
            [EnumMember(Value = "BlockUpgrade")]
            Blockupgrade,
            
            /// <summary>
            /// Enum Unblockupgrade for "UnblockUpgrade"
            /// </summary>
            [EnumMember(Value = "UnblockUpgrade")]
            Unblockupgrade,
            
            /// <summary>
            /// Enum Asgswapinstancetype for "AsgSwapInstanceType"
            /// </summary>
            [EnumMember(Value = "AsgSwapInstanceType")]
            Asgswapinstancetype,
            
            /// <summary>
            /// Enum Recreateasg for "RecreateAsg"
            /// </summary>
            [EnumMember(Value = "RecreateAsg")]
            Recreateasg,
            
            /// <summary>
            /// Enum Deleteunconfigurededge for "DeleteUnconfiguredEdge"
            /// </summary>
            [EnumMember(Value = "DeleteUnconfiguredEdge")]
            Deleteunconfigurededge,
            
            /// <summary>
            /// Enum Getasglist for "GetAsgList"
            /// </summary>
            [EnumMember(Value = "GetAsgList")]
            Getasglist,
            
            /// <summary>
            /// Enum Getasg for "GetAsg"
            /// </summary>
            [EnumMember(Value = "GetAsg")]
            Getasg,
            
            /// <summary>
            /// Enum Upgradeorganizationsite for "UpgradeOrganizationSite"
            /// </summary>
            [EnumMember(Value = "UpgradeOrganizationSite")]
            Upgradeorganizationsite,
            
            /// <summary>
            /// Enum Updateawsconfig for "UpdateAwsConfig"
            /// </summary>
            [EnumMember(Value = "UpdateAwsConfig")]
            Updateawsconfig,
            
            /// <summary>
            /// Enum Getawsconfig for "GetAwsConfig"
            /// </summary>
            [EnumMember(Value = "GetAwsConfig")]
            Getawsconfig,
            
            /// <summary>
            /// Enum Deleteghostedgerecord for "DeleteGhostEdgeRecord"
            /// </summary>
            [EnumMember(Value = "DeleteGhostEdgeRecord")]
            Deleteghostedgerecord,
            
            /// <summary>
            /// Enum Upgradecleanup for "UpgradeCleanup"
            /// </summary>
            [EnumMember(Value = "UpgradeCleanup")]
            Upgradecleanup,
            
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
            /// Enum Verify for "Verify"
            /// </summary>
            [EnumMember(Value = "Verify")]
            Verify,
            
            /// <summary>
            /// Enum Restoredeleted for "RestoreDeleted"
            /// </summary>
            [EnumMember(Value = "RestoreDeleted")]
            Restoredeleted,
            
            /// <summary>
            /// Enum Restoreall for "RestoreAll"
            /// </summary>
            [EnumMember(Value = "RestoreAll")]
            Restoreall,
            
            /// <summary>
            /// Enum Approve for "Approve"
            /// </summary>
            [EnumMember(Value = "Approve")]
            Approve,
            
            /// <summary>
            /// Enum Reject for "Reject"
            /// </summary>
            [EnumMember(Value = "Reject")]
            Reject,
            
            /// <summary>
            /// Enum Reverse for "Reverse"
            /// </summary>
            [EnumMember(Value = "Reverse")]
            Reverse,
            
            /// <summary>
            /// Enum Send for "Send"
            /// </summary>
            [EnumMember(Value = "Send")]
            Send,
            
            /// <summary>
            /// Enum Harddelete for "HardDelete"
            /// </summary>
            [EnumMember(Value = "HardDelete")]
            Harddelete,
            
            /// <summary>
            /// Enum Softdelete for "SoftDelete"
            /// </summary>
            [EnumMember(Value = "SoftDelete")]
            Softdelete,
            
            /// <summary>
            /// Enum Submit for "Submit"
            /// </summary>
            [EnumMember(Value = "Submit")]
            Submit,
            
            /// <summary>
            /// Enum Enablecapture for "EnableCapture"
            /// </summary>
            [EnumMember(Value = "EnableCapture")]
            Enablecapture,
            
            /// <summary>
            /// Enum Downloadcapture for "DownloadCapture"
            /// </summary>
            [EnumMember(Value = "DownloadCapture")]
            Downloadcapture,
            
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
            /// Enum Initiate for "Initiate"
            /// </summary>
            [EnumMember(Value = "Initiate")]
            Initiate,
            
            /// <summary>
            /// Enum Reversemanually for "ReverseManually"
            /// </summary>
            [EnumMember(Value = "ReverseManually")]
            Reversemanually,
            
            /// <summary>
            /// Enum Calculate for "Calculate"
            /// </summary>
            [EnumMember(Value = "Calculate")]
            Calculate,
            
            /// <summary>
            /// Enum Provisioned for "Provisioned"
            /// </summary>
            [EnumMember(Value = "Provisioned")]
            Provisioned,
            
            /// <summary>
            /// Enum Updateaborted for "UpdateAborted"
            /// </summary>
            [EnumMember(Value = "UpdateAborted")]
            Updateaborted,
            
            /// <summary>
            /// Enum Edit for "Edit"
            /// </summary>
            [EnumMember(Value = "Edit")]
            Edit
        }
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
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
            /// Enum Feedback for "Feedback"
            /// </summary>
            [EnumMember(Value = "Feedback")]
            Feedback,
            
            /// <summary>
            /// Enum Document for "Document"
            /// </summary>
            [EnumMember(Value = "Document")]
            Document,
            
            /// <summary>
            /// Enum Workspace for "Workspace"
            /// </summary>
            [EnumMember(Value = "Workspace")]
            Workspace,
            
            /// <summary>
            /// Enum Tag for "Tag"
            /// </summary>
            [EnumMember(Value = "Tag")]
            Tag,
            
            /// <summary>
            /// Enum Usersamlauthentication for "UserSamlAuthentication"
            /// </summary>
            [EnumMember(Value = "UserSamlAuthentication")]
            Usersamlauthentication,
            
            /// <summary>
            /// Enum Accesstoken for "AccessToken"
            /// </summary>
            [EnumMember(Value = "AccessToken")]
            Accesstoken,
            
            /// <summary>
            /// Enum Oauthclientauthorization for "OAuthClientAuthorization"
            /// </summary>
            [EnumMember(Value = "OAuthClientAuthorization")]
            Oauthclientauthorization,
            
            /// <summary>
            /// Enum Authorganization for "AuthOrganization"
            /// </summary>
            [EnumMember(Value = "AuthOrganization")]
            Authorganization,
            
            /// <summary>
            /// Enum Oauthclient for "OAuthClient"
            /// </summary>
            [EnumMember(Value = "OAuthClient")]
            Oauthclient,
            
            /// <summary>
            /// Enum Authuser for "AuthUser"
            /// </summary>
            [EnumMember(Value = "AuthUser")]
            Authuser,
            
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
            /// Enum Policy for "Policy"
            /// </summary>
            [EnumMember(Value = "Policy")]
            Policy,
            
            /// <summary>
            /// Enum Voicemailuserpolicy for "VoicemailUserPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailUserPolicy")]
            Voicemailuserpolicy,
            
            /// <summary>
            /// Enum Userpresence for "UserPresence"
            /// </summary>
            [EnumMember(Value = "UserPresence")]
            Userpresence,
            
            /// <summary>
            /// Enum Dependencytrackingbuild for "DependencyTrackingBuild"
            /// </summary>
            [EnumMember(Value = "DependencyTrackingBuild")]
            Dependencytrackingbuild,
            
            /// <summary>
            /// Enum Flow for "Flow"
            /// </summary>
            [EnumMember(Value = "Flow")]
            Flow,
            
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
            /// Enum Flowoutcome for "FlowOutcome"
            /// </summary>
            [EnumMember(Value = "FlowOutcome")]
            Flowoutcome,
            
            /// <summary>
            /// Enum Flowmilestone for "FlowMilestone"
            /// </summary>
            [EnumMember(Value = "FlowMilestone")]
            Flowmilestone,
            
            /// <summary>
            /// Enum Grammar for "Grammar"
            /// </summary>
            [EnumMember(Value = "Grammar")]
            Grammar,
            
            /// <summary>
            /// Enum Grammarlanguage for "GrammarLanguage"
            /// </summary>
            [EnumMember(Value = "GrammarLanguage")]
            Grammarlanguage,
            
            /// <summary>
            /// Enum Agentroutinginfo for "AgentRoutingInfo"
            /// </summary>
            [EnumMember(Value = "AgentRoutingInfo")]
            Agentroutinginfo,
            
            /// <summary>
            /// Enum Queue for "Queue"
            /// </summary>
            [EnumMember(Value = "Queue")]
            Queue,
            
            /// <summary>
            /// Enum Wrapupcode for "WrapupCode"
            /// </summary>
            [EnumMember(Value = "WrapupCode")]
            Wrapupcode,
            
            /// <summary>
            /// Enum Maxorgroutingutilizationcapacity for "MaxOrgRoutingUtilizationCapacity"
            /// </summary>
            [EnumMember(Value = "MaxOrgRoutingUtilizationCapacity")]
            Maxorgroutingutilizationcapacity,
            
            /// <summary>
            /// Enum Conversationattributes for "ConversationAttributes"
            /// </summary>
            [EnumMember(Value = "ConversationAttributes")]
            Conversationattributes,
            
            /// <summary>
            /// Enum Routingutilizationtag for "RoutingUtilizationTag"
            /// </summary>
            [EnumMember(Value = "RoutingUtilizationTag")]
            Routingutilizationtag,
            
            /// <summary>
            /// Enum Evaluation for "Evaluation"
            /// </summary>
            [EnumMember(Value = "Evaluation")]
            Evaluation,
            
            /// <summary>
            /// Enum Calibration for "Calibration"
            /// </summary>
            [EnumMember(Value = "Calibration")]
            Calibration,
            
            /// <summary>
            /// Enum Survey for "Survey"
            /// </summary>
            [EnumMember(Value = "Survey")]
            Survey,
            
            /// <summary>
            /// Enum Evaluationform for "EvaluationForm"
            /// </summary>
            [EnumMember(Value = "EvaluationForm")]
            Evaluationform,
            
            /// <summary>
            /// Enum Surveyform for "SurveyForm"
            /// </summary>
            [EnumMember(Value = "SurveyForm")]
            Surveyform,
            
            /// <summary>
            /// Enum Recording for "Recording"
            /// </summary>
            [EnumMember(Value = "Recording")]
            Recording,
            
            /// <summary>
            /// Enum Screenrecording for "ScreenRecording"
            /// </summary>
            [EnumMember(Value = "ScreenRecording")]
            Screenrecording,
            
            /// <summary>
            /// Enum Snippetrecording for "SnippetRecording"
            /// </summary>
            [EnumMember(Value = "SnippetRecording")]
            Snippetrecording,
            
            /// <summary>
            /// Enum Bulkactions for "BulkActions"
            /// </summary>
            [EnumMember(Value = "BulkActions")]
            Bulkactions,
            
            /// <summary>
            /// Enum Orphanedrecording for "OrphanedRecording"
            /// </summary>
            [EnumMember(Value = "OrphanedRecording")]
            Orphanedrecording,
            
            /// <summary>
            /// Enum Recordingannotation for "RecordingAnnotation"
            /// </summary>
            [EnumMember(Value = "RecordingAnnotation")]
            Recordingannotation,
            
            /// <summary>
            /// Enum Recordingsettings for "RecordingSettings"
            /// </summary>
            [EnumMember(Value = "RecordingSettings")]
            Recordingsettings,
            
            /// <summary>
            /// Enum Snippetrecordingsettings for "SnippetRecordingSettings"
            /// </summary>
            [EnumMember(Value = "SnippetRecordingSettings")]
            Snippetrecordingsettings,
            
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
            /// Enum Topic for "Topic"
            /// </summary>
            [EnumMember(Value = "Topic")]
            Topic,
            
            /// <summary>
            /// Enum Program for "Program"
            /// </summary>
            [EnumMember(Value = "Program")]
            Program,
            
            /// <summary>
            /// Enum Category for "Category"
            /// </summary>
            [EnumMember(Value = "Category")]
            Category,
            
            /// <summary>
            /// Enum Sentimentfeedback for "SentimentFeedback"
            /// </summary>
            [EnumMember(Value = "SentimentFeedback")]
            Sentimentfeedback,
            
            /// <summary>
            /// Enum Dictionaryfeedback for "DictionaryFeedback"
            /// </summary>
            [EnumMember(Value = "DictionaryFeedback")]
            Dictionaryfeedback,
            
            /// <summary>
            /// Enum Interactionreprocessingjob for "InteractionReprocessingJob"
            /// </summary>
            [EnumMember(Value = "InteractionReprocessingJob")]
            Interactionreprocessingjob,
            
            /// <summary>
            /// Enum Segment for "Segment"
            /// </summary>
            [EnumMember(Value = "Segment")]
            Segment,
            
            /// <summary>
            /// Enum Outcome for "Outcome"
            /// </summary>
            [EnumMember(Value = "Outcome")]
            Outcome,
            
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
            /// Enum Clickstreamsettings for "ClickstreamSettings"
            /// </summary>
            [EnumMember(Value = "ClickstreamSettings")]
            Clickstreamsettings,
            
            /// <summary>
            /// Enum Eventtype for "EventType"
            /// </summary>
            [EnumMember(Value = "EventType")]
            Eventtype,
            
            /// <summary>
            /// Enum Sessiontype for "SessionType"
            /// </summary>
            [EnumMember(Value = "SessionType")]
            Sessiontype,
            
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
            /// Enum Knowledgecontext for "KnowledgeContext"
            /// </summary>
            [EnumMember(Value = "KnowledgeContext")]
            Knowledgecontext,
            
            /// <summary>
            /// Enum Knowledgecontextvalue for "KnowledgeContextValue"
            /// </summary>
            [EnumMember(Value = "KnowledgeContextValue")]
            Knowledgecontextvalue,
            
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
            /// Enum Knowledgetraining for "KnowledgeTraining"
            /// </summary>
            [EnumMember(Value = "KnowledgeTraining")]
            Knowledgetraining,
            
            /// <summary>
            /// Enum Knowledgesearchfeedback for "KnowledgeSearchFeedback"
            /// </summary>
            [EnumMember(Value = "KnowledgeSearchFeedback")]
            Knowledgesearchfeedback,
            
            /// <summary>
            /// Enum Transcriptionsettings for "TranscriptionSettings"
            /// </summary>
            [EnumMember(Value = "TranscriptionSettings")]
            Transcriptionsettings,
            
            /// <summary>
            /// Enum Speechtextanalyticssettings for "SpeechTextAnalyticsSettings"
            /// </summary>
            [EnumMember(Value = "SpeechTextAnalyticsSettings")]
            Speechtextanalyticssettings,
            
            /// <summary>
            /// Enum Appointment for "Appointment"
            /// </summary>
            [EnumMember(Value = "Appointment")]
            Appointment,
            
            /// <summary>
            /// Enum Annotation for "Annotation"
            /// </summary>
            [EnumMember(Value = "Annotation")]
            Annotation,
            
            /// <summary>
            /// Enum Organization for "Organization"
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization,
            
            /// <summary>
            /// Enum Module for "Module"
            /// </summary>
            [EnumMember(Value = "Module")]
            Module,
            
            /// <summary>
            /// Enum Rule for "Rule"
            /// </summary>
            [EnumMember(Value = "Rule")]
            Rule,
            
            /// <summary>
            /// Enum Assignment for "Assignment"
            /// </summary>
            [EnumMember(Value = "Assignment")]
            Assignment,
            
            /// <summary>
            /// Enum Contest for "Contest"
            /// </summary>
            [EnumMember(Value = "Contest")]
            Contest,
            
            /// <summary>
            /// Enum Recognition for "Recognition"
            /// </summary>
            [EnumMember(Value = "Recognition")]
            Recognition,
            
            /// <summary>
            /// Enum Activitycode for "ActivityCode"
            /// </summary>
            [EnumMember(Value = "ActivityCode")]
            Activitycode,
            
            /// <summary>
            /// Enum Activityplan for "ActivityPlan"
            /// </summary>
            [EnumMember(Value = "ActivityPlan")]
            Activityplan,
            
            /// <summary>
            /// Enum Activityplanoccurrence for "ActivityPlanOccurrence"
            /// </summary>
            [EnumMember(Value = "ActivityPlanOccurrence")]
            Activityplanoccurrence,
            
            /// <summary>
            /// Enum Adherenceexplanation for "AdherenceExplanation"
            /// </summary>
            [EnumMember(Value = "AdherenceExplanation")]
            Adherenceexplanation,
            
            /// <summary>
            /// Enum Alternativeshift for "AlternativeShift"
            /// </summary>
            [EnumMember(Value = "AlternativeShift")]
            Alternativeshift,
            
            /// <summary>
            /// Enum Businessunit for "BusinessUnit"
            /// </summary>
            [EnumMember(Value = "BusinessUnit")]
            Businessunit,
            
            /// <summary>
            /// Enum Forecast for "Forecast"
            /// </summary>
            [EnumMember(Value = "Forecast")]
            Forecast,
            
            /// <summary>
            /// Enum Managementunit for "ManagementUnit"
            /// </summary>
            [EnumMember(Value = "ManagementUnit")]
            Managementunit,
            
            /// <summary>
            /// Enum Planninggroup for "PlanningGroup"
            /// </summary>
            [EnumMember(Value = "PlanningGroup")]
            Planninggroup,
            
            /// <summary>
            /// Enum Schedule for "Schedule"
            /// </summary>
            [EnumMember(Value = "Schedule")]
            Schedule,
            
            /// <summary>
            /// Enum Servicegoaltemplate for "ServiceGoalTemplate"
            /// </summary>
            [EnumMember(Value = "ServiceGoalTemplate")]
            Servicegoaltemplate,
            
            /// <summary>
            /// Enum Shifttrade for "ShiftTrade"
            /// </summary>
            [EnumMember(Value = "ShiftTrade")]
            Shifttrade,
            
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
            /// Enum Workplan for "WorkPlan"
            /// </summary>
            [EnumMember(Value = "WorkPlan")]
            Workplan,
            
            /// <summary>
            /// Enum Workplanbid for "WorkPlanBid"
            /// </summary>
            [EnumMember(Value = "WorkPlanBid")]
            Workplanbid,
            
            /// <summary>
            /// Enum Workplanbidgroup for "WorkPlanBidGroup"
            /// </summary>
            [EnumMember(Value = "WorkPlanBidGroup")]
            Workplanbidgroup,
            
            /// <summary>
            /// Enum Workplanrotation for "WorkPlanRotation"
            /// </summary>
            [EnumMember(Value = "WorkPlanRotation")]
            Workplanrotation,
            
            /// <summary>
            /// Enum Historicaldata for "HistoricalData"
            /// </summary>
            [EnumMember(Value = "HistoricalData")]
            Historicaldata,
            
            /// <summary>
            /// Enum Staffinggroup for "StaffingGroup"
            /// </summary>
            [EnumMember(Value = "StaffingGroup")]
            Staffinggroup,
            
            /// <summary>
            /// Enum Capacityplan for "CapacityPlan"
            /// </summary>
            [EnumMember(Value = "CapacityPlan")]
            Capacityplan,
            
            /// <summary>
            /// Enum Trigger for "Trigger"
            /// </summary>
            [EnumMember(Value = "Trigger")]
            Trigger,
            
            /// <summary>
            /// Enum Response for "Response"
            /// </summary>
            [EnumMember(Value = "Response")]
            Response,
            
            /// <summary>
            /// Enum Responselibrary for "ResponseLibrary"
            /// </summary>
            [EnumMember(Value = "ResponseLibrary")]
            Responselibrary,
            
            /// <summary>
            /// Enum Responseasset for "ResponseAsset"
            /// </summary>
            [EnumMember(Value = "ResponseAsset")]
            Responseasset,
            
            /// <summary>
            /// Enum Skillgroup for "SkillGroup"
            /// </summary>
            [EnumMember(Value = "SkillGroup")]
            Skillgroup,
            
            /// <summary>
            /// Enum Directorygroup for "DirectoryGroup"
            /// </summary>
            [EnumMember(Value = "DirectoryGroup")]
            Directorygroup,
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,
            
            /// <summary>
            /// Enum Skillgroupdefinition for "SkillGroupDefinition"
            /// </summary>
            [EnumMember(Value = "SkillGroupDefinition")]
            Skillgroupdefinition,
            
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
            /// Enum Voicemailpolicy for "VoicemailPolicy"
            /// </summary>
            [EnumMember(Value = "VoicemailPolicy")]
            Voicemailpolicy,
            
            /// <summary>
            /// Enum Routingtranscriptionsettings for "RoutingTranscriptionSettings"
            /// </summary>
            [EnumMember(Value = "RoutingTranscriptionSettings")]
            Routingtranscriptionsettings,
            
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
            /// Enum Schedulegroup for "ScheduleGroup"
            /// </summary>
            [EnumMember(Value = "ScheduleGroup")]
            Schedulegroup,
            
            /// <summary>
            /// Enum Emergencygroup for "EmergencyGroup"
            /// </summary>
            [EnumMember(Value = "EmergencyGroup")]
            Emergencygroup,
            
            /// <summary>
            /// Enum Ivr for "IVR"
            /// </summary>
            [EnumMember(Value = "IVR")]
            Ivr,
            
            /// <summary>
            /// Enum Alertablepresencesoverrides for "AlertablePresencesOverrides"
            /// </summary>
            [EnumMember(Value = "AlertablePresencesOverrides")]
            Alertablepresencesoverrides,
            
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
            /// Enum Outboundroute for "OutboundRoute"
            /// </summary>
            [EnumMember(Value = "OutboundRoute")]
            Outboundroute,
            
            /// <summary>
            /// Enum Numberplan for "NumberPlan"
            /// </summary>
            [EnumMember(Value = "NumberPlan")]
            Numberplan,
            
            /// <summary>
            /// Enum Site for "Site"
            /// </summary>
            [EnumMember(Value = "Site")]
            Site,
            
            /// <summary>
            /// Enum Attemptlimits for "AttemptLimits"
            /// </summary>
            [EnumMember(Value = "AttemptLimits")]
            Attemptlimits,
            
            /// <summary>
            /// Enum Callabletimeset for "CallableTimeSet"
            /// </summary>
            [EnumMember(Value = "CallableTimeSet")]
            Callabletimeset,
            
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
            /// Enum Contactlisttemplate for "ContactListTemplate"
            /// </summary>
            [EnumMember(Value = "ContactListTemplate")]
            Contactlisttemplate,
            
            /// <summary>
            /// Enum Digitalruleset for "DigitalRuleSet"
            /// </summary>
            [EnumMember(Value = "DigitalRuleSet")]
            Digitalruleset,
            
            /// <summary>
            /// Enum Dnclist for "DNCList"
            /// </summary>
            [EnumMember(Value = "DNCList")]
            Dnclist,
            
            /// <summary>
            /// Enum Filespecificationtemplate for "FileSpecificationTemplate"
            /// </summary>
            [EnumMember(Value = "FileSpecificationTemplate")]
            Filespecificationtemplate,
            
            /// <summary>
            /// Enum Importtemplate for "ImportTemplate"
            /// </summary>
            [EnumMember(Value = "ImportTemplate")]
            Importtemplate,
            
            /// <summary>
            /// Enum Organizationsettings for "OrganizationSettings"
            /// </summary>
            [EnumMember(Value = "OrganizationSettings")]
            Organizationsettings,
            
            /// <summary>
            /// Enum Callanalysisresponseset for "CallAnalysisResponseSet"
            /// </summary>
            [EnumMember(Value = "CallAnalysisResponseSet")]
            Callanalysisresponseset,
            
            /// <summary>
            /// Enum Ruleset for "RuleSet"
            /// </summary>
            [EnumMember(Value = "RuleSet")]
            Ruleset,
            
            /// <summary>
            /// Enum Wrapupcodemapping for "WrapUpCodeMapping"
            /// </summary>
            [EnumMember(Value = "WrapUpCodeMapping")]
            Wrapupcodemapping,
            
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
            /// Enum Emailcampaignschedule for "EmailCampaignSchedule"
            /// </summary>
            [EnumMember(Value = "EmailCampaignSchedule")]
            Emailcampaignschedule,
            
            /// <summary>
            /// Enum Whatsappcampaignschedule for "WhatsAppCampaignSchedule"
            /// </summary>
            [EnumMember(Value = "WhatsAppCampaignSchedule")]
            Whatsappcampaignschedule,
            
            /// <summary>
            /// Enum Predictor for "Predictor"
            /// </summary>
            [EnumMember(Value = "Predictor")]
            Predictor,
            
            /// <summary>
            /// Enum Kpispecification for "KpiSpecification"
            /// </summary>
            [EnumMember(Value = "KpiSpecification")]
            Kpispecification,
            
            /// <summary>
            /// Enum Metric for "Metric"
            /// </summary>
            [EnumMember(Value = "Metric")]
            Metric,
            
            /// <summary>
            /// Enum Status for "Status"
            /// </summary>
            [EnumMember(Value = "Status")]
            Status,
            
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
            /// Enum Integration for "Integration"
            /// </summary>
            [EnumMember(Value = "Integration")]
            Integration,
            
            /// <summary>
            /// Enum Webhook for "Webhook"
            /// </summary>
            [EnumMember(Value = "Webhook")]
            Webhook,
            
            /// <summary>
            /// Enum Dashboardsettings for "DashboardSettings"
            /// </summary>
            [EnumMember(Value = "DashboardSettings")]
            Dashboardsettings,
            
            /// <summary>
            /// Enum Insightsettings for "InsightSettings"
            /// </summary>
            [EnumMember(Value = "InsightSettings")]
            Insightsettings,
            
            /// <summary>
            /// Enum Analyticsreportingsettings for "AnalyticsReportingSettings"
            /// </summary>
            [EnumMember(Value = "AnalyticsReportingSettings")]
            Analyticsreportingsettings,
            
            /// <summary>
            /// Enum Customcalculations for "CustomCalculations"
            /// </summary>
            [EnumMember(Value = "CustomCalculations")]
            Customcalculations,
            
            /// <summary>
            /// Enum Scheduledexports for "ScheduledExports"
            /// </summary>
            [EnumMember(Value = "ScheduledExports")]
            Scheduledexports,
            
            /// <summary>
            /// Enum Exports for "Exports"
            /// </summary>
            [EnumMember(Value = "Exports")]
            Exports,
            
            /// <summary>
            /// Enum Exportpdftemplates for "ExportPdfTemplates"
            /// </summary>
            [EnumMember(Value = "ExportPdfTemplates")]
            Exportpdftemplates,
            
            /// <summary>
            /// Enum Changerequest for "ChangeRequest"
            /// </summary>
            [EnumMember(Value = "ChangeRequest")]
            Changerequest,
            
            /// <summary>
            /// Enum Migration for "Migration"
            /// </summary>
            [EnumMember(Value = "Migration")]
            Migration,
            
            /// <summary>
            /// Enum Suspension for "Suspension"
            /// </summary>
            [EnumMember(Value = "Suspension")]
            Suspension,
            
            /// <summary>
            /// Enum Externalmetricsdefinition for "ExternalMetricsDefinition"
            /// </summary>
            [EnumMember(Value = "ExternalMetricsDefinition")]
            Externalmetricsdefinition,
            
            /// <summary>
            /// Enum Externalmetricsdata for "ExternalMetricsData"
            /// </summary>
            [EnumMember(Value = "ExternalMetricsData")]
            Externalmetricsdata,
            
            /// <summary>
            /// Enum Schema for "Schema"
            /// </summary>
            [EnumMember(Value = "Schema")]
            Schema,
            
            /// <summary>
            /// Enum Row for "Row"
            /// </summary>
            [EnumMember(Value = "Row")]
            Row,
            
            /// <summary>
            /// Enum Bulk for "Bulk"
            /// </summary>
            [EnumMember(Value = "Bulk")]
            Bulk,
            
            /// <summary>
            /// Enum Supportedcontent for "SupportedContent"
            /// </summary>
            [EnumMember(Value = "SupportedContent")]
            Supportedcontent,
            
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
            /// Enum Conversationthreadingwindow for "ConversationThreadingWindow"
            /// </summary>
            [EnumMember(Value = "ConversationThreadingWindow")]
            Conversationthreadingwindow,
            
            /// <summary>
            /// Enum Deployment for "Deployment"
            /// </summary>
            [EnumMember(Value = "Deployment")]
            Deployment,
            
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
            /// Enum Organizationintegrationsaccess for "OrganizationIntegrationsAccess"
            /// </summary>
            [EnumMember(Value = "OrganizationIntegrationsAccess")]
            Organizationintegrationsaccess,
            
            /// <summary>
            /// Enum Supportfile for "SupportFile"
            /// </summary>
            [EnumMember(Value = "SupportFile")]
            Supportfile,
            
            /// <summary>
            /// Enum Edgelogzip for "EdgeLogZip"
            /// </summary>
            [EnumMember(Value = "EdgeLogZip")]
            Edgelogzip,
            
            /// <summary>
            /// Enum Pcaps for "Pcaps"
            /// </summary>
            [EnumMember(Value = "Pcaps")]
            Pcaps,
            
            /// <summary>
            /// Enum Mediadiagnosticstracefile for "MediaDiagnosticsTraceFile"
            /// </summary>
            [EnumMember(Value = "MediaDiagnosticsTraceFile")]
            Mediadiagnosticstracefile,
            
            /// <summary>
            /// Enum Edgepcaps for "EdgePcaps"
            /// </summary>
            [EnumMember(Value = "EdgePcaps")]
            Edgepcaps,
            
            /// <summary>
            /// Enum Edgelog for "EdgeLog"
            /// </summary>
            [EnumMember(Value = "EdgeLog")]
            Edgelog,
            
            /// <summary>
            /// Enum Disasterrecoverylinkorg for "DisasterRecoveryLinkOrg"
            /// </summary>
            [EnumMember(Value = "DisasterRecoveryLinkOrg")]
            Disasterrecoverylinkorg,
            
            /// <summary>
            /// Enum Disasterrecoverynumberrouting for "DisasterRecoveryNumberRouting"
            /// </summary>
            [EnumMember(Value = "DisasterRecoveryNumberRouting")]
            Disasterrecoverynumberrouting,
            
            /// <summary>
            /// Enum Organizationfeature for "OrganizationFeature"
            /// </summary>
            [EnumMember(Value = "OrganizationFeature")]
            Organizationfeature,
            
            /// <summary>
            /// Enum Product for "Product"
            /// </summary>
            [EnumMember(Value = "Product")]
            Product,
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Conversation for "Conversation"
            /// </summary>
            [EnumMember(Value = "Conversation")]
            Conversation,
            
            /// <summary>
            /// Enum Organizationsuspension for "OrganizationSuspension"
            /// </summary>
            [EnumMember(Value = "OrganizationSuspension")]
            Organizationsuspension,
            
            /// <summary>
            /// Enum Operationalevent for "OperationalEvent"
            /// </summary>
            [EnumMember(Value = "OperationalEvent")]
            Operationalevent,
            
            /// <summary>
            /// Enum Participant for "Participant"
            /// </summary>
            [EnumMember(Value = "Participant")]
            Participant,
            
            /// <summary>
            /// Enum Contactschema for "ContactSchema"
            /// </summary>
            [EnumMember(Value = "ContactSchema")]
            Contactschema,
            
            /// <summary>
            /// Enum Externalorganizationschema for "ExternalOrganizationSchema"
            /// </summary>
            [EnumMember(Value = "ExternalOrganizationSchema")]
            Externalorganizationschema,
            
            /// <summary>
            /// Enum Workbin for "Workbin"
            /// </summary>
            [EnumMember(Value = "Workbin")]
            Workbin,
            
            /// <summary>
            /// Enum Worktype for "Worktype"
            /// </summary>
            [EnumMember(Value = "Worktype")]
            Worktype,
            
            /// <summary>
            /// Enum Bulkjob for "BulkJob"
            /// </summary>
            [EnumMember(Value = "BulkJob")]
            Bulkjob,
            
            /// <summary>
            /// Enum Credential for "Credential"
            /// </summary>
            [EnumMember(Value = "Credential")]
            Credential,
            
            /// <summary>
            /// Enum Numberorder for "NumberOrder"
            /// </summary>
            [EnumMember(Value = "NumberOrder")]
            Numberorder,
            
            /// <summary>
            /// Enum Enterpriseagreement for "EnterpriseAgreement"
            /// </summary>
            [EnumMember(Value = "EnterpriseAgreement")]
            Enterpriseagreement,
            
            /// <summary>
            /// Enum Vendorlisting for "VendorListing"
            /// </summary>
            [EnumMember(Value = "VendorListing")]
            Vendorlisting,
            
            /// <summary>
            /// Enum Gdprrequest for "GdprRequest"
            /// </summary>
            [EnumMember(Value = "GdprRequest")]
            Gdprrequest,
            
            /// <summary>
            /// Enum Dsarrequest for "DsarRequest"
            /// </summary>
            [EnumMember(Value = "DsarRequest")]
            Dsarrequest,
            
            /// <summary>
            /// Enum Exportrequest for "ExportRequest"
            /// </summary>
            [EnumMember(Value = "ExportRequest")]
            Exportrequest,
            
            /// <summary>
            /// Enum Defaultpanelsettings for "DefaultPanelSettings"
            /// </summary>
            [EnumMember(Value = "DefaultPanelSettings")]
            Defaultpanelsettings,
            
            /// <summary>
            /// Enum Inbounddomain for "InboundDomain"
            /// </summary>
            [EnumMember(Value = "InboundDomain")]
            Inbounddomain,
            
            /// <summary>
            /// Enum Outbounddomain for "OutboundDomain"
            /// </summary>
            [EnumMember(Value = "OutboundDomain")]
            Outbounddomain,
            
            /// <summary>
            /// Enum Inboundroute for "InboundRoute"
            /// </summary>
            [EnumMember(Value = "InboundRoute")]
            Inboundroute,
            
            /// <summary>
            /// Enum Emailsetting for "EmailSetting"
            /// </summary>
            [EnumMember(Value = "EmailSetting")]
            Emailsetting,
            
            /// <summary>
            /// Enum Organizationlimits for "OrganizationLimits"
            /// </summary>
            [EnumMember(Value = "OrganizationLimits")]
            Organizationlimits,
            
            /// <summary>
            /// Enum Composerpage for "ComposerPage"
            /// </summary>
            [EnumMember(Value = "ComposerPage")]
            Composerpage,
            
            /// <summary>
            /// Enum Composerpublishedscript for "ComposerPublishedScript"
            /// </summary>
            [EnumMember(Value = "ComposerPublishedScript")]
            Composerpublishedscript,
            
            /// <summary>
            /// Enum Composerscript for "ComposerScript"
            /// </summary>
            [EnumMember(Value = "ComposerScript")]
            Composerscript,
            
            /// <summary>
            /// Enum Composertemplate for "ComposerTemplate"
            /// </summary>
            [EnumMember(Value = "ComposerTemplate")]
            Composertemplate,
            
            /// <summary>
            /// Enum Intentminer for "IntentMiner"
            /// </summary>
            [EnumMember(Value = "IntentMiner")]
            Intentminer,
            
            /// <summary>
            /// Enum Topicminer for "TopicMiner"
            /// </summary>
            [EnumMember(Value = "TopicMiner")]
            Topicminer,
            
            /// <summary>
            /// Enum Softsuspension for "SoftSuspension"
            /// </summary>
            [EnumMember(Value = "SoftSuspension")]
            Softsuspension,
            
            /// <summary>
            /// Enum Journeyview for "JourneyView"
            /// </summary>
            [EnumMember(Value = "JourneyView")]
            Journeyview,
            
            /// <summary>
            /// Enum Customentity for "CustomEntity"
            /// </summary>
            [EnumMember(Value = "CustomEntity")]
            Customentity,
            
            /// <summary>
            /// Enum Directoryfeature for "DirectoryFeature"
            /// </summary>
            [EnumMember(Value = "DirectoryFeature")]
            Directoryfeature,
            
            /// <summary>
            /// Enum Rulecategory for "RuleCategory"
            /// </summary>
            [EnumMember(Value = "RuleCategory")]
            Rulecategory,
            
            /// <summary>
            /// Enum Decisiontable for "DecisionTable"
            /// </summary>
            [EnumMember(Value = "DecisionTable")]
            Decisiontable,
            
            /// <summary>
            /// Enum Decisiontableversion for "DecisionTableVersion"
            /// </summary>
            [EnumMember(Value = "DecisionTableVersion")]
            Decisiontableversion,
            
            /// <summary>
            /// Enum Decisiontablerow for "DecisionTableRow"
            /// </summary>
            [EnumMember(Value = "DecisionTableRow")]
            Decisiontablerow,
            
            /// <summary>
            /// Enum Escalationrule for "EscalationRule"
            /// </summary>
            [EnumMember(Value = "EscalationRule")]
            Escalationrule,
            
            /// <summary>
            /// Enum Rules for "Rules"
            /// </summary>
            [EnumMember(Value = "Rules")]
            Rules,
            
            /// <summary>
            /// Enum Contact for "Contact"
            /// </summary>
            [EnumMember(Value = "Contact")]
            Contact,
            
            /// <summary>
            /// Enum Note for "Note"
            /// </summary>
            [EnumMember(Value = "Note")]
            Note,
            
            /// <summary>
            /// Enum Relationship for "Relationship"
            /// </summary>
            [EnumMember(Value = "Relationship")]
            Relationship,
            
            /// <summary>
            /// Enum Externalorg for "ExternalOrg"
            /// </summary>
            [EnumMember(Value = "ExternalOrg")]
            Externalorg,
            
            /// <summary>
            /// Enum Socialmediamessage for "SocialMediaMessage"
            /// </summary>
            [EnumMember(Value = "SocialMediaMessage")]
            Socialmediamessage
        }
        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public ServiceNameEnum? ServiceName { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public EntityTypeEnum? EntityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTopicAuditLogMessage" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserHomeOrgId">UserHomeOrgId.</param>
        /// <param name="Username">Username.</param>
        /// <param name="UserDisplay">UserDisplay.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="RemoteIp">RemoteIp.</param>
        /// <param name="ServiceName">ServiceName.</param>
        /// <param name="Level">Level.</param>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Action">Action.</param>
        /// <param name="EntityType">EntityType.</param>
        /// <param name="Entity">Entity.</param>
        /// <param name="PropertyChanges">PropertyChanges.</param>
        /// <param name="Context">Context.</param>
        public AuditTopicAuditLogMessage(string Id = null, string UserId = null, string UserHomeOrgId = null, AuditTopicDomainEntityRef Username = null, string UserDisplay = null, AuditTopicAddressableEntityRef ClientId = null, List<string> RemoteIp = null, ServiceNameEnum? ServiceName = null, string Level = null, DateTime? EventTime = null, AuditTopicMessageInfo Message = null, ActionEnum? Action = null, EntityTypeEnum? EntityType = null, AuditTopicDomainEntityRef Entity = null, List<AuditTopicPropertyChange> PropertyChanges = null, Dictionary<string, string> Context = null)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.UserHomeOrgId = UserHomeOrgId;
            this.Username = Username;
            this.UserDisplay = UserDisplay;
            this.ClientId = ClientId;
            this.RemoteIp = RemoteIp;
            this.ServiceName = ServiceName;
            this.Level = Level;
            this.EventTime = EventTime;
            this.Message = Message;
            this.Action = Action;
            this.EntityType = EntityType;
            this.Entity = Entity;
            this.PropertyChanges = PropertyChanges;
            this.Context = Context;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Gets or Sets UserHomeOrgId
        /// </summary>
        [DataMember(Name="userHomeOrgId", EmitDefaultValue=false)]
        public string UserHomeOrgId { get; set; }



        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public AuditTopicDomainEntityRef Username { get; set; }



        /// <summary>
        /// Gets or Sets UserDisplay
        /// </summary>
        [DataMember(Name="userDisplay", EmitDefaultValue=false)]
        public string UserDisplay { get; set; }



        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public AuditTopicAddressableEntityRef ClientId { get; set; }



        /// <summary>
        /// Gets or Sets RemoteIp
        /// </summary>
        [DataMember(Name="remoteIp", EmitDefaultValue=false)]
        public List<string> RemoteIp { get; set; }





        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }



        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }



        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public AuditTopicMessageInfo Message { get; set; }







        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public AuditTopicDomainEntityRef Entity { get; set; }



        /// <summary>
        /// Gets or Sets PropertyChanges
        /// </summary>
        [DataMember(Name="propertyChanges", EmitDefaultValue=false)]
        public List<AuditTopicPropertyChange> PropertyChanges { get; set; }



        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public Dictionary<string, string> Context { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditTopicAuditLogMessage {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserHomeOrgId: ").Append(UserHomeOrgId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  UserDisplay: ").Append(UserDisplay).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  RemoteIp: ").Append(RemoteIp).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  PropertyChanges: ").Append(PropertyChanges).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as AuditTopicAuditLogMessage);
        }

        /// <summary>
        /// Returns true if AuditTopicAuditLogMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditTopicAuditLogMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditTopicAuditLogMessage other)
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
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.UserHomeOrgId == other.UserHomeOrgId ||
                    this.UserHomeOrgId != null &&
                    this.UserHomeOrgId.Equals(other.UserHomeOrgId)
                ) &&
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) &&
                (
                    this.UserDisplay == other.UserDisplay ||
                    this.UserDisplay != null &&
                    this.UserDisplay.Equals(other.UserDisplay)
                ) &&
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
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
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
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
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
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

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.UserHomeOrgId != null)
                    hash = hash * 59 + this.UserHomeOrgId.GetHashCode();

                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();

                if (this.UserDisplay != null)
                    hash = hash * 59 + this.UserDisplay.GetHashCode();

                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();

                if (this.RemoteIp != null)
                    hash = hash * 59 + this.RemoteIp.GetHashCode();

                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();

                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.PropertyChanges != null)
                    hash = hash * 59 + this.PropertyChanges.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                return hash;
            }
        }
    }

}
