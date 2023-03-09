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
    /// LimitChangeRequestDetails
    /// </summary>
    [DataContract]
    public partial class LimitChangeRequestDetails :  IEquatable<LimitChangeRequestDetails>
    {
        /// <summary>
        /// Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)
        /// </summary>
        /// <value>Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)</value>
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
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
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
            /// Enum Messaging for "messaging"
            /// </summary>
            [EnumMember(Value = "messaging")]
            Messaging,
            
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
            /// Enum Workforcemanagement for "workforce.management"
            /// </summary>
            [EnumMember(Value = "workforce.management")]
            Workforcemanagement
        }
        /// <summary>
        /// Current status of the limit change request
        /// </summary>
        /// <value>Current status of the limit change request</value>
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
        /// Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)
        /// </summary>
        /// <value>Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public NamespaceEnum? Namespace { get; set; }
        /// <summary>
        /// Current status of the limit change request
        /// </summary>
        /// <value>Current status of the limit change request</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; private set; }
        /// <summary>
        /// The reason for rejecting the limit override request
        /// </summary>
        /// <value>The reason for rejecting the limit override request</value>
        [DataMember(Name="rejectReason", EmitDefaultValue=false)]
        public RejectReasonEnum? RejectReason { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitChangeRequestDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LimitChangeRequestDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitChangeRequestDetails" /> class.
        /// </summary>
        /// <param name="Key">Limit key to be overridden (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits) (required).</param>
        /// <param name="Namespace">Namespace the key belongs to (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits) (required).</param>
        /// <param name="RequestedValue">Requested limit value for a given key (required).</param>
        /// <param name="Description">Description of the need for the limit change request (required).</param>
        /// <param name="SupportCaseUrl">The support case url created by Care (required).</param>
        public LimitChangeRequestDetails(string Key = null, NamespaceEnum? Namespace = null, double? RequestedValue = null, string Description = null, string SupportCaseUrl = null)
        {
            this.Key = Key;
            this.Namespace = Namespace;
            this.RequestedValue = RequestedValue;
            this.Description = Description;
            this.SupportCaseUrl = SupportCaseUrl;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Limit key to be overridden (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)
        /// </summary>
        /// <value>Limit key to be overridden (see https://developer.mypurecloud.com/api/rest/v2/organization/limits.html#available_limits)</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }





        /// <summary>
        /// Requested limit value for a given key
        /// </summary>
        /// <value>Requested limit value for a given key</value>
        [DataMember(Name="requestedValue", EmitDefaultValue=false)]
        public double? RequestedValue { get; set; }



        /// <summary>
        /// Description of the need for the limit change request
        /// </summary>
        /// <value>Description of the need for the limit change request</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The support case url created by Care
        /// </summary>
        /// <value>The support case url created by Care</value>
        [DataMember(Name="supportCaseUrl", EmitDefaultValue=false)]
        public string SupportCaseUrl { get; set; }





        /// <summary>
        /// Current limit value for a given key
        /// </summary>
        /// <value>Current limit value for a given key</value>
        [DataMember(Name="currentValue", EmitDefaultValue=false)]
        public double? CurrentValue { get; private set; }



        /// <summary>
        /// The date of the limit change request creation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the limit change request creation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// List of statuses that a limit change request has gone through
        /// </summary>
        /// <value>List of statuses that a limit change request has gone through</value>
        [DataMember(Name="statusHistory", EmitDefaultValue=false)]
        public List<StatusChange> StatusHistory { get; private set; }



        /// <summary>
        /// The date of the limit change request completion (ChangeImplemented, Rejected, or RollbackImplemented. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the limit change request completion (ChangeImplemented, Rejected, or RollbackImplemented. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCompleted", EmitDefaultValue=false)]
        public DateTime? DateCompleted { get; private set; }





        /// <summary>
        /// The approval breakdown for this override request.
        /// </summary>
        /// <value>The approval breakdown for this override request.</value>
        [DataMember(Name="approvalNamespaces", EmitDefaultValue=false)]
        public List<ApprovalNamespace> ApprovalNamespaces { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitChangeRequestDetails {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  RequestedValue: ").Append(RequestedValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SupportCaseUrl: ").Append(SupportCaseUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  StatusHistory: ").Append(StatusHistory).Append("\n");
            sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
            sb.Append("  ApprovalNamespaces: ").Append(ApprovalNamespaces).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as LimitChangeRequestDetails);
        }

        /// <summary>
        /// Returns true if LimitChangeRequestDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of LimitChangeRequestDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitChangeRequestDetails other)
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
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.Namespace == other.Namespace ||
                    this.Namespace != null &&
                    this.Namespace.Equals(other.Namespace)
                ) &&
                (
                    this.RequestedValue == other.RequestedValue ||
                    this.RequestedValue != null &&
                    this.RequestedValue.Equals(other.RequestedValue)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.SupportCaseUrl == other.SupportCaseUrl ||
                    this.SupportCaseUrl != null &&
                    this.SupportCaseUrl.Equals(other.SupportCaseUrl)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.CurrentValue == other.CurrentValue ||
                    this.CurrentValue != null &&
                    this.CurrentValue.Equals(other.CurrentValue)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.StatusHistory == other.StatusHistory ||
                    this.StatusHistory != null &&
                    this.StatusHistory.SequenceEqual(other.StatusHistory)
                ) &&
                (
                    this.DateCompleted == other.DateCompleted ||
                    this.DateCompleted != null &&
                    this.DateCompleted.Equals(other.DateCompleted)
                ) &&
                (
                    this.RejectReason == other.RejectReason ||
                    this.RejectReason != null &&
                    this.RejectReason.Equals(other.RejectReason)
                ) &&
                (
                    this.ApprovalNamespaces == other.ApprovalNamespaces ||
                    this.ApprovalNamespaces != null &&
                    this.ApprovalNamespaces.SequenceEqual(other.ApprovalNamespaces)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();

                if (this.Namespace != null)
                    hash = hash * 59 + this.Namespace.GetHashCode();

                if (this.RequestedValue != null)
                    hash = hash * 59 + this.RequestedValue.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.SupportCaseUrl != null)
                    hash = hash * 59 + this.SupportCaseUrl.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.CurrentValue != null)
                    hash = hash * 59 + this.CurrentValue.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.StatusHistory != null)
                    hash = hash * 59 + this.StatusHistory.GetHashCode();

                if (this.DateCompleted != null)
                    hash = hash * 59 + this.DateCompleted.GetHashCode();

                if (this.RejectReason != null)
                    hash = hash * 59 + this.RejectReason.GetHashCode();

                if (this.ApprovalNamespaces != null)
                    hash = hash * 59 + this.ApprovalNamespaces.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
