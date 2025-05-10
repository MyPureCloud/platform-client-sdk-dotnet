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
    /// StatusChange
    /// </summary>
    [DataContract]
    public partial class StatusChange :  IEquatable<StatusChange>
    {
        /// <summary>
        /// The status the change request transitioned to
        /// </summary>
        /// <value>The status the change request transitioned to</value>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Secondaryapprovalnamespacesadded for "SecondaryApprovalNamespacesAdded"
            /// </summary>
            [EnumMember(Value = "SecondaryApprovalNamespacesAdded")]
            Secondaryapprovalnamespacesadded,
            
            /// <summary>
            /// Enum Reviewerapproved for "ReviewerApproved"
            /// </summary>
            [EnumMember(Value = "ReviewerApproved")]
            Reviewerapproved,
            
            /// <summary>
            /// Enum Reviewerrejected for "ReviewerRejected"
            /// </summary>
            [EnumMember(Value = "ReviewerRejected")]
            Reviewerrejected,
            
            /// <summary>
            /// Enum Reviewerrollback for "ReviewerRollback"
            /// </summary>
            [EnumMember(Value = "ReviewerRollback")]
            Reviewerrollback,
            
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
            Rollbackimplemented
        }
        /// <summary>
        /// The status the change request transitioned from
        /// </summary>
        /// <value>The status the change request transitioned from</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PreviousStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Secondaryapprovalnamespacesadded for "SecondaryApprovalNamespacesAdded"
            /// </summary>
            [EnumMember(Value = "SecondaryApprovalNamespacesAdded")]
            Secondaryapprovalnamespacesadded,
            
            /// <summary>
            /// Enum Reviewerapproved for "ReviewerApproved"
            /// </summary>
            [EnumMember(Value = "ReviewerApproved")]
            Reviewerapproved,
            
            /// <summary>
            /// Enum Reviewerrejected for "ReviewerRejected"
            /// </summary>
            [EnumMember(Value = "ReviewerRejected")]
            Reviewerrejected,
            
            /// <summary>
            /// Enum Reviewerrollback for "ReviewerRollback"
            /// </summary>
            [EnumMember(Value = "ReviewerRollback")]
            Reviewerrollback,
            
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
            Rollbackimplemented
        }
        /// <summary>
        /// The namespace for the status change
        /// </summary>
        /// <value>The namespace for the status change</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NamespaceEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentassistant for "agent.assistant"
            /// </summary>
            [EnumMember(Value = "agent.assistant")]
            Agentassistant,
            
            /// <summary>
            /// Enum Analyticsagents for "analytics.agents"
            /// </summary>
            [EnumMember(Value = "analytics.agents")]
            Analyticsagents,
            
            /// <summary>
            /// Enum Analyticsalerting for "analytics.alerting"
            /// </summary>
            [EnumMember(Value = "analytics.alerting")]
            Analyticsalerting,
            
            /// <summary>
            /// Enum Analytics for "analytics"
            /// </summary>
            [EnumMember(Value = "analytics")]
            Analytics,
            
            /// <summary>
            /// Enum Analyticsrealtime for "analytics.realtime"
            /// </summary>
            [EnumMember(Value = "analytics.realtime")]
            Analyticsrealtime,
            
            /// <summary>
            /// Enum Analyticsreportingsettings for "analytics.reporting.settings"
            /// </summary>
            [EnumMember(Value = "analytics.reporting.settings")]
            Analyticsreportingsettings,
            
            /// <summary>
            /// Enum Architect for "architect"
            /// </summary>
            [EnumMember(Value = "architect")]
            Architect,
            
            /// <summary>
            /// Enum Audiohook for "audiohook"
            /// </summary>
            [EnumMember(Value = "audiohook")]
            Audiohook,
            
            /// <summary>
            /// Enum Audit for "audit"
            /// </summary>
            [EnumMember(Value = "audit")]
            Audit,
            
            /// <summary>
            /// Enum Authapi for "auth.api"
            /// </summary>
            [EnumMember(Value = "auth.api")]
            Authapi,
            
            /// <summary>
            /// Enum Authorization for "authorization"
            /// </summary>
            [EnumMember(Value = "authorization")]
            Authorization,
            
            /// <summary>
            /// Enum Automationtesting for "automation.testing"
            /// </summary>
            [EnumMember(Value = "automation.testing")]
            Automationtesting,
            
            /// <summary>
            /// Enum Bots for "bots"
            /// </summary>
            [EnumMember(Value = "bots")]
            Bots,
            
            /// <summary>
            /// Enum Botsvoice for "bots.voice"
            /// </summary>
            [EnumMember(Value = "bots.voice")]
            Botsvoice,
            
            /// <summary>
            /// Enum Businessrules for "business.rules"
            /// </summary>
            [EnumMember(Value = "business.rules")]
            Businessrules,
            
            /// <summary>
            /// Enum Callback for "callback"
            /// </summary>
            [EnumMember(Value = "callback")]
            Callback,
            
            /// <summary>
            /// Enum Cobrowse for "cobrowse"
            /// </summary>
            [EnumMember(Value = "cobrowse")]
            Cobrowse,
            
            /// <summary>
            /// Enum Contentmanagement for "content.management"
            /// </summary>
            [EnumMember(Value = "content.management")]
            Contentmanagement,
            
            /// <summary>
            /// Enum Conversation for "conversation"
            /// </summary>
            [EnumMember(Value = "conversation")]
            Conversation,
            
            /// <summary>
            /// Enum Dataactions for "dataactions"
            /// </summary>
            [EnumMember(Value = "dataactions")]
            Dataactions,
            
            /// <summary>
            /// Enum Datatables for "datatables"
            /// </summary>
            [EnumMember(Value = "datatables")]
            Datatables,
            
            /// <summary>
            /// Enum Directory for "directory"
            /// </summary>
            [EnumMember(Value = "directory")]
            Directory,
            
            /// <summary>
            /// Enum Dsar for "dsar"
            /// </summary>
            [EnumMember(Value = "dsar")]
            Dsar,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Employeeengagement for "employee.engagement"
            /// </summary>
            [EnumMember(Value = "employee.engagement")]
            Employeeengagement,
            
            /// <summary>
            /// Enum Eventorchestration for "event.orchestration"
            /// </summary>
            [EnumMember(Value = "event.orchestration")]
            Eventorchestration,
            
            /// <summary>
            /// Enum Externalcontacts for "external.contacts"
            /// </summary>
            [EnumMember(Value = "external.contacts")]
            Externalcontacts,
            
            /// <summary>
            /// Enum Externaleventsdataingestion for "external.events.data.ingestion"
            /// </summary>
            [EnumMember(Value = "external.events.data.ingestion")]
            Externaleventsdataingestion,
            
            /// <summary>
            /// Enum Gamification for "gamification"
            /// </summary>
            [EnumMember(Value = "gamification")]
            Gamification,
            
            /// <summary>
            /// Enum Gcv for "gcv"
            /// </summary>
            [EnumMember(Value = "gcv")]
            Gcv,
            
            /// <summary>
            /// Enum Gdpr for "gdpr"
            /// </summary>
            [EnumMember(Value = "gdpr")]
            Gdpr,
            
            /// <summary>
            /// Enum Groups for "groups"
            /// </summary>
            [EnumMember(Value = "groups")]
            Groups,
            
            /// <summary>
            /// Enum Guides for "guides"
            /// </summary>
            [EnumMember(Value = "guides")]
            Guides,
            
            /// <summary>
            /// Enum Historicaladherence for "historical.adherence"
            /// </summary>
            [EnumMember(Value = "historical.adherence")]
            Historicaladherence,
            
            /// <summary>
            /// Enum Infrastructureascode for "infrastructureascode"
            /// </summary>
            [EnumMember(Value = "infrastructureascode")]
            Infrastructureascode,
            
            /// <summary>
            /// Enum Integrations for "integrations"
            /// </summary>
            [EnumMember(Value = "integrations")]
            Integrations,
            
            /// <summary>
            /// Enum Intentminer for "intent.miner"
            /// </summary>
            [EnumMember(Value = "intent.miner")]
            Intentminer,
            
            /// <summary>
            /// Enum Internalmessaging for "internal.messaging"
            /// </summary>
            [EnumMember(Value = "internal.messaging")]
            Internalmessaging,
            
            /// <summary>
            /// Enum Journey for "journey"
            /// </summary>
            [EnumMember(Value = "journey")]
            Journey,
            
            /// <summary>
            /// Enum Knowledge for "knowledge"
            /// </summary>
            [EnumMember(Value = "knowledge")]
            Knowledge,
            
            /// <summary>
            /// Enum Languageunderstanding for "language.understanding"
            /// </summary>
            [EnumMember(Value = "language.understanding")]
            Languageunderstanding,
            
            /// <summary>
            /// Enum Learning for "learning"
            /// </summary>
            [EnumMember(Value = "learning")]
            Learning,
            
            /// <summary>
            /// Enum Limitregistry for "limit.registry"
            /// </summary>
            [EnumMember(Value = "limit.registry")]
            Limitregistry,
            
            /// <summary>
            /// Enum Marketplace for "marketplace"
            /// </summary>
            [EnumMember(Value = "marketplace")]
            Marketplace,
            
            /// <summary>
            /// Enum Mediacommunications for "media.communications"
            /// </summary>
            [EnumMember(Value = "media.communications")]
            Mediacommunications,
            
            /// <summary>
            /// Enum Messaging for "messaging"
            /// </summary>
            [EnumMember(Value = "messaging")]
            Messaging,
            
            /// <summary>
            /// Enum Microfrontend for "micro.frontend"
            /// </summary>
            [EnumMember(Value = "micro.frontend")]
            Microfrontend,
            
            /// <summary>
            /// Enum Notifications for "notifications"
            /// </summary>
            [EnumMember(Value = "notifications")]
            Notifications,
            
            /// <summary>
            /// Enum Onboarding for "onboarding"
            /// </summary>
            [EnumMember(Value = "onboarding")]
            Onboarding,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound,
            
            /// <summary>
            /// Enum Platformapi for "platform.api"
            /// </summary>
            [EnumMember(Value = "platform.api")]
            Platformapi,
            
            /// <summary>
            /// Enum Predictiverouting for "predictive.routing"
            /// </summary>
            [EnumMember(Value = "predictive.routing")]
            Predictiverouting,
            
            /// <summary>
            /// Enum Presence for "presence"
            /// </summary>
            [EnumMember(Value = "presence")]
            Presence,
            
            /// <summary>
            /// Enum Quality for "quality"
            /// </summary>
            [EnumMember(Value = "quality")]
            Quality,
            
            /// <summary>
            /// Enum Recording for "recording"
            /// </summary>
            [EnumMember(Value = "recording")]
            Recording,
            
            /// <summary>
            /// Enum Responsemanagement for "response.management"
            /// </summary>
            [EnumMember(Value = "response.management")]
            Responsemanagement,
            
            /// <summary>
            /// Enum Routing for "routing"
            /// </summary>
            [EnumMember(Value = "routing")]
            Routing,
            
            /// <summary>
            /// Enum Scim for "scim"
            /// </summary>
            [EnumMember(Value = "scim")]
            Scim,
            
            /// <summary>
            /// Enum Search for "search"
            /// </summary>
            [EnumMember(Value = "search")]
            Search,
            
            /// <summary>
            /// Enum Secondaryautomationtesting for "secondary.automation.testing"
            /// </summary>
            [EnumMember(Value = "secondary.automation.testing")]
            Secondaryautomationtesting,
            
            /// <summary>
            /// Enum Skills for "skills"
            /// </summary>
            [EnumMember(Value = "skills")]
            Skills,
            
            /// <summary>
            /// Enum Socialmedia for "social.media"
            /// </summary>
            [EnumMember(Value = "social.media")]
            Socialmedia,
            
            /// <summary>
            /// Enum Speechandtextanalytics for "speech.and.text.analytics"
            /// </summary>
            [EnumMember(Value = "speech.and.text.analytics")]
            Speechandtextanalytics,
            
            /// <summary>
            /// Enum Speechintegration for "speech.integration"
            /// </summary>
            [EnumMember(Value = "speech.integration")]
            Speechintegration,
            
            /// <summary>
            /// Enum Supportability for "supportability"
            /// </summary>
            [EnumMember(Value = "supportability")]
            Supportability,
            
            /// <summary>
            /// Enum Taskmanagement for "task.management"
            /// </summary>
            [EnumMember(Value = "task.management")]
            Taskmanagement,
            
            /// <summary>
            /// Enum Telephonyconfiguration for "telephony.configuration"
            /// </summary>
            [EnumMember(Value = "telephony.configuration")]
            Telephonyconfiguration,
            
            /// <summary>
            /// Enum Usage for "usage"
            /// </summary>
            [EnumMember(Value = "usage")]
            Usage,
            
            /// <summary>
            /// Enum Users for "users"
            /// </summary>
            [EnumMember(Value = "users")]
            Users,
            
            /// <summary>
            /// Enum Webdeployments for "web.deployments"
            /// </summary>
            [EnumMember(Value = "web.deployments")]
            Webdeployments,
            
            /// <summary>
            /// Enum Webmessaging for "web.messaging"
            /// </summary>
            [EnumMember(Value = "web.messaging")]
            Webmessaging,
            
            /// <summary>
            /// Enum Webchat for "webchat"
            /// </summary>
            [EnumMember(Value = "webchat")]
            Webchat,
            
            /// <summary>
            /// Enum Webhooks for "webhooks"
            /// </summary>
            [EnumMember(Value = "webhooks")]
            Webhooks,
            
            /// <summary>
            /// Enum Workforcemanagementforecast for "workforce.management.forecast"
            /// </summary>
            [EnumMember(Value = "workforce.management.forecast")]
            Workforcemanagementforecast,
            
            /// <summary>
            /// Enum Workforcemanagement for "workforce.management"
            /// </summary>
            [EnumMember(Value = "workforce.management")]
            Workforcemanagement,
            
            /// <summary>
            /// Enum System for "system"
            /// </summary>
            [EnumMember(Value = "system")]
            System
        }
        /// <summary>
        /// The reason for rejecting the limit override request
        /// </summary>
        /// <value>The reason for rejecting the limit override request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RejectReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alternativeexists for "AlternativeExists"
            /// </summary>
            [EnumMember(Value = "AlternativeExists")]
            Alternativeexists,
            
            /// <summary>
            /// Enum Increasenotrequired for "IncreaseNotRequired"
            /// </summary>
            [EnumMember(Value = "IncreaseNotRequired")]
            Increasenotrequired,
            
            /// <summary>
            /// Enum Platformmisuse for "PlatformMisuse"
            /// </summary>
            [EnumMember(Value = "PlatformMisuse")]
            Platformmisuse,
            
            /// <summary>
            /// Enum Platformstability for "PlatformStability"
            /// </summary>
            [EnumMember(Value = "PlatformStability")]
            Platformstability,
            
            /// <summary>
            /// Enum Otherreason for "OtherReason"
            /// </summary>
            [EnumMember(Value = "OtherReason")]
            Otherreason
        }
        /// <summary>
        /// The status the change request transitioned to
        /// </summary>
        /// <value>The status the change request transitioned to</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// The status the change request transitioned from
        /// </summary>
        /// <value>The status the change request transitioned from</value>
        [DataMember(Name="previousStatus", EmitDefaultValue=false)]
        public PreviousStatusEnum? PreviousStatus { get; private set; }
        /// <summary>
        /// The namespace for the status change
        /// </summary>
        /// <value>The namespace for the status change</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public NamespaceEnum? Namespace { get; private set; }
        /// <summary>
        /// The reason for rejecting the limit override request
        /// </summary>
        /// <value>The reason for rejecting the limit override request</value>
        [DataMember(Name="rejectReason", EmitDefaultValue=false)]
        public RejectReasonEnum? RejectReason { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusChange" /> class.
        /// </summary>
        public StatusChange()
        {
            
        }
        


        /// <summary>
        /// The date of this status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of this status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStatusChanged", EmitDefaultValue=false)]
        public DateTime? DateStatusChanged { get; private set; }









        /// <summary>
        /// A short message describing the status change
        /// </summary>
        /// <value>A short message describing the status change</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusChange {\n");

            sb.Append("  DateStatusChanged: ").Append(DateStatusChanged).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PreviousStatus: ").Append(PreviousStatus).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
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
            return this.Equals(obj as StatusChange);
        }

        /// <summary>
        /// Returns true if StatusChange instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateStatusChanged == other.DateStatusChanged ||
                    this.DateStatusChanged != null &&
                    this.DateStatusChanged.Equals(other.DateStatusChanged)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.PreviousStatus == other.PreviousStatus ||
                    this.PreviousStatus != null &&
                    this.PreviousStatus.Equals(other.PreviousStatus)
                ) &&
                (
                    this.Namespace == other.Namespace ||
                    this.Namespace != null &&
                    this.Namespace.Equals(other.Namespace)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.RejectReason == other.RejectReason ||
                    this.RejectReason != null &&
                    this.RejectReason.Equals(other.RejectReason)
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
                if (this.DateStatusChanged != null)
                    hash = hash * 59 + this.DateStatusChanged.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.PreviousStatus != null)
                    hash = hash * 59 + this.PreviousStatus.GetHashCode();

                if (this.Namespace != null)
                    hash = hash * 59 + this.Namespace.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.RejectReason != null)
                    hash = hash * 59 + this.RejectReason.GetHashCode();

                return hash;
            }
        }
    }

}
