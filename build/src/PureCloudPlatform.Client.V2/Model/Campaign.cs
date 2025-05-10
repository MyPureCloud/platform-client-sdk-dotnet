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
    /// Campaign
    /// </summary>
    [DataContract]
    public partial class Campaign :  IEquatable<Campaign>
    {
        /// <summary>
        /// The strategy this Campaign will use for dialing.
        /// </summary>
        /// <value>The strategy this Campaign will use for dialing.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DialingModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Agentless for "agentless"
            /// </summary>
            [EnumMember(Value = "agentless")]
            Agentless,
            
            /// <summary>
            /// Enum Preview for "preview"
            /// </summary>
            [EnumMember(Value = "preview")]
            Preview,
            
            /// <summary>
            /// Enum Power for "power"
            /// </summary>
            [EnumMember(Value = "power")]
            Power,
            
            /// <summary>
            /// Enum Predictive for "predictive"
            /// </summary>
            [EnumMember(Value = "predictive")]
            Predictive,
            
            /// <summary>
            /// Enum Progressive for "progressive"
            /// </summary>
            [EnumMember(Value = "progressive")]
            Progressive,
            
            /// <summary>
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External
        }
        /// <summary>
        /// The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.
        /// </summary>
        /// <value>The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CampaignStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum On for "on"
            /// </summary>
            [EnumMember(Value = "on")]
            On,
            
            /// <summary>
            /// Enum Stopping for "stopping"
            /// </summary>
            [EnumMember(Value = "stopping")]
            Stopping,
            
            /// <summary>
            /// Enum Off for "off"
            /// </summary>
            [EnumMember(Value = "off")]
            Off,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete,
            
            /// <summary>
            /// Enum Invalid for "invalid"
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid,
            
            /// <summary>
            /// Enum ForcedOff for "forced_off"
            /// </summary>
            [EnumMember(Value = "forced_off")]
            ForcedOff,
            
            /// <summary>
            /// Enum ForcedStopping for "forced_stopping"
            /// </summary>
            [EnumMember(Value = "forced_stopping")]
            ForcedStopping
        }
        /// <summary>
        /// The strategy this Campaign will use for dialing.
        /// </summary>
        /// <value>The strategy this Campaign will use for dialing.</value>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public DialingModeEnum? DialingMode { get; set; }
        /// <summary>
        /// The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.
        /// </summary>
        /// <value>The current status of the Campaign. A Campaign may be turned 'on' or 'off'. Required for updates.</value>
        [DataMember(Name="campaignStatus", EmitDefaultValue=false)]
        public CampaignStatusEnum? CampaignStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Campaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Campaign" /> class.
        /// </summary>
        /// <param name="Name">The name of the Campaign. (required).</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="ContactList">The ContactList for this Campaign to dial. (required).</param>
        /// <param name="Queue">The Queue for this Campaign to route calls to. Required for all dialing modes except agentless..</param>
        /// <param name="DialingMode">The strategy this Campaign will use for dialing. (required).</param>
        /// <param name="Script">The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless..</param>
        /// <param name="EdgeGroup">The EdgeGroup that will place the calls. Required for all dialing modes except preview..</param>
        /// <param name="Site">The identifier of the site to be used for dialing; can be set in place of an edge group..</param>
        /// <param name="CampaignStatus">The current status of the Campaign. A Campaign may be turned &#39;on&#39; or &#39;off&#39;. Required for updates..</param>
        /// <param name="PhoneColumns">The ContactPhoneNumberColumns on the ContactList that this Campaign should dial. (required).</param>
        /// <param name="AbandonRate">The targeted compliance abandon rate percentage. Required for power and predictive campaigns..</param>
        /// <param name="DncLists">DncLists for this Campaign to check before placing a call..</param>
        /// <param name="CallableTimeSet">The callable time set for this campaign to check before placing a call..</param>
        /// <param name="CallAnalysisResponseSet">The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview..</param>
        /// <param name="CallerName">The caller id name to be displayed on the outbound call. (required).</param>
        /// <param name="CallerAddress">The caller id phone number to be displayed on the outbound call. (required).</param>
        /// <param name="OutboundLineCount">The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless..</param>
        /// <param name="RuleSets">Rule sets to be applied while this campaign is dialing..</param>
        /// <param name="SkipPreviewDisabled">Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns..</param>
        /// <param name="PreviewTimeOutSeconds">The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns..</param>
        /// <param name="AlwaysRunning">Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually..</param>
        /// <param name="ContactSort">The order in which to sort contacts for dialing, based on a column..</param>
        /// <param name="ContactSorts">The order in which to sort contacts for dialing, based on up to four columns..</param>
        /// <param name="NoAnswerTimeout">How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns..</param>
        /// <param name="CallAnalysisLanguage">The language the edge will use to analyze the call..</param>
        /// <param name="Priority">The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest..</param>
        /// <param name="ContactListFilters">Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied..</param>
        /// <param name="Division">The division this campaign belongs to..</param>
        /// <param name="AgentOwnedColumn">Name of the contact list column containing the id of the agent who owns the record. Only applicable to preview campaigns..</param>
        /// <param name="DynamicContactQueueingSettings">Settings for dynamic queueing of contacts..</param>
        /// <param name="SkillColumns">The skill columns on the ContactList that this Campaign should take into account when dialing.</param>
        /// <param name="MaxCallsPerAgent">The maximum number of calls that can be placed per agent on this campaign.</param>
        /// <param name="MaxCallsPerAgentDecimal">The maximum number of calls that can be placed per agent on this campaign with decimal precision.</param>
        /// <param name="CallbackAutoAnswer">The option manages the auto-answer callback calls.</param>
        /// <param name="DynamicLineBalancingSettings">Dynamic line balancing settings.</param>
        /// <param name="DiagnosticsSettings">Campaign diagnostics settings.</param>
        public Campaign(string Name = null, int? Version = null, DomainEntityRef ContactList = null, DomainEntityRef Queue = null, DialingModeEnum? DialingMode = null, DomainEntityRef Script = null, DomainEntityRef EdgeGroup = null, DomainEntityRef Site = null, CampaignStatusEnum? CampaignStatus = null, List<PhoneColumn> PhoneColumns = null, double? AbandonRate = null, List<DomainEntityRef> DncLists = null, DomainEntityRef CallableTimeSet = null, DomainEntityRef CallAnalysisResponseSet = null, string CallerName = null, string CallerAddress = null, int? OutboundLineCount = null, List<DomainEntityRef> RuleSets = null, bool? SkipPreviewDisabled = null, long? PreviewTimeOutSeconds = null, bool? AlwaysRunning = null, ContactSort ContactSort = null, List<ContactSort> ContactSorts = null, int? NoAnswerTimeout = null, string CallAnalysisLanguage = null, int? Priority = null, List<DomainEntityRef> ContactListFilters = null, DomainEntityRef Division = null, string AgentOwnedColumn = null, DynamicContactQueueingSettings DynamicContactQueueingSettings = null, List<string> SkillColumns = null, int? MaxCallsPerAgent = null, double? MaxCallsPerAgentDecimal = null, bool? CallbackAutoAnswer = null, DynamicLineBalancingSettings DynamicLineBalancingSettings = null, DiagnosticsSettings DiagnosticsSettings = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.ContactList = ContactList;
            this.Queue = Queue;
            this.DialingMode = DialingMode;
            this.Script = Script;
            this.EdgeGroup = EdgeGroup;
            this.Site = Site;
            this.CampaignStatus = CampaignStatus;
            this.PhoneColumns = PhoneColumns;
            this.AbandonRate = AbandonRate;
            this.DncLists = DncLists;
            this.CallableTimeSet = CallableTimeSet;
            this.CallAnalysisResponseSet = CallAnalysisResponseSet;
            this.CallerName = CallerName;
            this.CallerAddress = CallerAddress;
            this.OutboundLineCount = OutboundLineCount;
            this.RuleSets = RuleSets;
            this.SkipPreviewDisabled = SkipPreviewDisabled;
            this.PreviewTimeOutSeconds = PreviewTimeOutSeconds;
            this.AlwaysRunning = AlwaysRunning;
            this.ContactSort = ContactSort;
            this.ContactSorts = ContactSorts;
            this.NoAnswerTimeout = NoAnswerTimeout;
            this.CallAnalysisLanguage = CallAnalysisLanguage;
            this.Priority = Priority;
            this.ContactListFilters = ContactListFilters;
            this.Division = Division;
            this.AgentOwnedColumn = AgentOwnedColumn;
            this.DynamicContactQueueingSettings = DynamicContactQueueingSettings;
            this.SkillColumns = SkillColumns;
            this.MaxCallsPerAgent = MaxCallsPerAgent;
            this.MaxCallsPerAgentDecimal = MaxCallsPerAgentDecimal;
            this.CallbackAutoAnswer = CallbackAutoAnswer;
            this.DynamicLineBalancingSettings = DynamicLineBalancingSettings;
            this.DiagnosticsSettings = DiagnosticsSettings;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Campaign.
        /// </summary>
        /// <value>The name of the Campaign.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The ContactList for this Campaign to dial.
        /// </summary>
        /// <value>The ContactList for this Campaign to dial.</value>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public DomainEntityRef ContactList { get; set; }



        /// <summary>
        /// The Queue for this Campaign to route calls to. Required for all dialing modes except agentless.
        /// </summary>
        /// <value>The Queue for this Campaign to route calls to. Required for all dialing modes except agentless.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public DomainEntityRef Queue { get; set; }





        /// <summary>
        /// The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless.
        /// </summary>
        /// <value>The Script to be displayed to agents that are handling outbound calls. Required for all dialing modes except agentless.</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public DomainEntityRef Script { get; set; }



        /// <summary>
        /// The EdgeGroup that will place the calls. Required for all dialing modes except preview.
        /// </summary>
        /// <value>The EdgeGroup that will place the calls. Required for all dialing modes except preview.</value>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public DomainEntityRef EdgeGroup { get; set; }



        /// <summary>
        /// The identifier of the site to be used for dialing; can be set in place of an edge group.
        /// </summary>
        /// <value>The identifier of the site to be used for dialing; can be set in place of an edge group.</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public DomainEntityRef Site { get; set; }





        /// <summary>
        /// The ContactPhoneNumberColumns on the ContactList that this Campaign should dial.
        /// </summary>
        /// <value>The ContactPhoneNumberColumns on the ContactList that this Campaign should dial.</value>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
        public List<PhoneColumn> PhoneColumns { get; set; }



        /// <summary>
        /// The targeted compliance abandon rate percentage. Required for power and predictive campaigns.
        /// </summary>
        /// <value>The targeted compliance abandon rate percentage. Required for power and predictive campaigns.</value>
        [DataMember(Name="abandonRate", EmitDefaultValue=false)]
        public double? AbandonRate { get; set; }



        /// <summary>
        /// DncLists for this Campaign to check before placing a call.
        /// </summary>
        /// <value>DncLists for this Campaign to check before placing a call.</value>
        [DataMember(Name="dncLists", EmitDefaultValue=false)]
        public List<DomainEntityRef> DncLists { get; set; }



        /// <summary>
        /// The callable time set for this campaign to check before placing a call.
        /// </summary>
        /// <value>The callable time set for this campaign to check before placing a call.</value>
        [DataMember(Name="callableTimeSet", EmitDefaultValue=false)]
        public DomainEntityRef CallableTimeSet { get; set; }



        /// <summary>
        /// The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview.
        /// </summary>
        /// <value>The call analysis response set to handle call analysis results from the edge. Required for all dialing modes except preview.</value>
        [DataMember(Name="callAnalysisResponseSet", EmitDefaultValue=false)]
        public DomainEntityRef CallAnalysisResponseSet { get; set; }



        /// <summary>
        /// A list of current error conditions associated with the campaign.
        /// </summary>
        /// <value>A list of current error conditions associated with the campaign.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<RestErrorDetail> Errors { get; private set; }



        /// <summary>
        /// The caller id name to be displayed on the outbound call.
        /// </summary>
        /// <value>The caller id name to be displayed on the outbound call.</value>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }



        /// <summary>
        /// The caller id phone number to be displayed on the outbound call.
        /// </summary>
        /// <value>The caller id phone number to be displayed on the outbound call.</value>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }



        /// <summary>
        /// The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless.
        /// </summary>
        /// <value>The number of outbound lines to be concurrently dialed. Only applicable to non-preview campaigns; only required for agentless.</value>
        [DataMember(Name="outboundLineCount", EmitDefaultValue=false)]
        public int? OutboundLineCount { get; set; }



        /// <summary>
        /// Rule sets to be applied while this campaign is dialing.
        /// </summary>
        /// <value>Rule sets to be applied while this campaign is dialing.</value>
        [DataMember(Name="ruleSets", EmitDefaultValue=false)]
        public List<DomainEntityRef> RuleSets { get; set; }



        /// <summary>
        /// Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns.
        /// </summary>
        /// <value>Whether or not agents can skip previews without placing a call. Only applicable for preview campaigns.</value>
        [DataMember(Name="skipPreviewDisabled", EmitDefaultValue=false)]
        public bool? SkipPreviewDisabled { get; set; }



        /// <summary>
        /// The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns.
        /// </summary>
        /// <value>The number of seconds before a call will be automatically placed on a preview. A value of 0 indicates no automatic placement of calls. Only applicable to preview campaigns.</value>
        [DataMember(Name="previewTimeOutSeconds", EmitDefaultValue=false)]
        public long? PreviewTimeOutSeconds { get; set; }



        /// <summary>
        /// Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually.
        /// </summary>
        /// <value>Indicates (when true) that the campaign will remain on after contacts are depleted, allowing additional contacts to be appended/added to the contact list and processed by the still-running campaign. The campaign can still be turned off manually.</value>
        [DataMember(Name="alwaysRunning", EmitDefaultValue=false)]
        public bool? AlwaysRunning { get; set; }



        /// <summary>
        /// The order in which to sort contacts for dialing, based on a column.
        /// </summary>
        /// <value>The order in which to sort contacts for dialing, based on a column.</value>
        [DataMember(Name="contactSort", EmitDefaultValue=false)]
        public ContactSort ContactSort { get; set; }



        /// <summary>
        /// The order in which to sort contacts for dialing, based on up to four columns.
        /// </summary>
        /// <value>The order in which to sort contacts for dialing, based on up to four columns.</value>
        [DataMember(Name="contactSorts", EmitDefaultValue=false)]
        public List<ContactSort> ContactSorts { get; set; }



        /// <summary>
        /// How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns.
        /// </summary>
        /// <value>How long to wait before dispositioning a call as &#39;no-answer&#39;. Default 30 seconds. Only applicable to non-preview campaigns.</value>
        [DataMember(Name="noAnswerTimeout", EmitDefaultValue=false)]
        public int? NoAnswerTimeout { get; set; }



        /// <summary>
        /// The language the edge will use to analyze the call.
        /// </summary>
        /// <value>The language the edge will use to analyze the call.</value>
        [DataMember(Name="callAnalysisLanguage", EmitDefaultValue=false)]
        public string CallAnalysisLanguage { get; set; }



        /// <summary>
        /// The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest.
        /// </summary>
        /// <value>The priority of this campaign relative to other campaigns that are running on the same queue. 5 is the highest priority, 1 the lowest.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied.
        /// </summary>
        /// <value>Filter to apply to the contact list before dialing. Currently a campaign can only have one filter applied.</value>
        [DataMember(Name="contactListFilters", EmitDefaultValue=false)]
        public List<DomainEntityRef> ContactListFilters { get; set; }



        /// <summary>
        /// The division this campaign belongs to.
        /// </summary>
        /// <value>The division this campaign belongs to.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DomainEntityRef Division { get; set; }



        /// <summary>
        /// Name of the contact list column containing the id of the agent who owns the record. Only applicable to preview campaigns.
        /// </summary>
        /// <value>Name of the contact list column containing the id of the agent who owns the record. Only applicable to preview campaigns.</value>
        [DataMember(Name="agentOwnedColumn", EmitDefaultValue=false)]
        public string AgentOwnedColumn { get; set; }



        /// <summary>
        /// Settings for dynamic queueing of contacts.
        /// </summary>
        /// <value>Settings for dynamic queueing of contacts.</value>
        [DataMember(Name="dynamicContactQueueingSettings", EmitDefaultValue=false)]
        public DynamicContactQueueingSettings DynamicContactQueueingSettings { get; set; }



        /// <summary>
        /// The skill columns on the ContactList that this Campaign should take into account when dialing
        /// </summary>
        /// <value>The skill columns on the ContactList that this Campaign should take into account when dialing</value>
        [DataMember(Name="skillColumns", EmitDefaultValue=false)]
        public List<string> SkillColumns { get; set; }



        /// <summary>
        /// The maximum number of calls that can be placed per agent on this campaign
        /// </summary>
        /// <value>The maximum number of calls that can be placed per agent on this campaign</value>
        [DataMember(Name="maxCallsPerAgent", EmitDefaultValue=false)]
        public int? MaxCallsPerAgent { get; set; }



        /// <summary>
        /// The maximum number of calls that can be placed per agent on this campaign with decimal precision
        /// </summary>
        /// <value>The maximum number of calls that can be placed per agent on this campaign with decimal precision</value>
        [DataMember(Name="maxCallsPerAgentDecimal", EmitDefaultValue=false)]
        public double? MaxCallsPerAgentDecimal { get; set; }



        /// <summary>
        /// The option manages the auto-answer callback calls
        /// </summary>
        /// <value>The option manages the auto-answer callback calls</value>
        [DataMember(Name="callbackAutoAnswer", EmitDefaultValue=false)]
        public bool? CallbackAutoAnswer { get; set; }



        /// <summary>
        /// Dynamic line balancing settings
        /// </summary>
        /// <value>Dynamic line balancing settings</value>
        [DataMember(Name="dynamicLineBalancingSettings", EmitDefaultValue=false)]
        public DynamicLineBalancingSettings DynamicLineBalancingSettings { get; set; }



        /// <summary>
        /// Campaign diagnostics settings
        /// </summary>
        /// <value>Campaign diagnostics settings</value>
        [DataMember(Name="diagnosticsSettings", EmitDefaultValue=false)]
        public DiagnosticsSettings DiagnosticsSettings { get; set; }



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
            sb.Append("class Campaign {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  DialingMode: ").Append(DialingMode).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
            sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
            sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
            sb.Append("  DncLists: ").Append(DncLists).Append("\n");
            sb.Append("  CallableTimeSet: ").Append(CallableTimeSet).Append("\n");
            sb.Append("  CallAnalysisResponseSet: ").Append(CallAnalysisResponseSet).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
            sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  SkipPreviewDisabled: ").Append(SkipPreviewDisabled).Append("\n");
            sb.Append("  PreviewTimeOutSeconds: ").Append(PreviewTimeOutSeconds).Append("\n");
            sb.Append("  AlwaysRunning: ").Append(AlwaysRunning).Append("\n");
            sb.Append("  ContactSort: ").Append(ContactSort).Append("\n");
            sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
            sb.Append("  NoAnswerTimeout: ").Append(NoAnswerTimeout).Append("\n");
            sb.Append("  CallAnalysisLanguage: ").Append(CallAnalysisLanguage).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  AgentOwnedColumn: ").Append(AgentOwnedColumn).Append("\n");
            sb.Append("  DynamicContactQueueingSettings: ").Append(DynamicContactQueueingSettings).Append("\n");
            sb.Append("  SkillColumns: ").Append(SkillColumns).Append("\n");
            sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
            sb.Append("  MaxCallsPerAgentDecimal: ").Append(MaxCallsPerAgentDecimal).Append("\n");
            sb.Append("  CallbackAutoAnswer: ").Append(CallbackAutoAnswer).Append("\n");
            sb.Append("  DynamicLineBalancingSettings: ").Append(DynamicLineBalancingSettings).Append("\n");
            sb.Append("  DiagnosticsSettings: ").Append(DiagnosticsSettings).Append("\n");
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
            return this.Equals(obj as Campaign);
        }

        /// <summary>
        /// Returns true if Campaign instances are equal
        /// </summary>
        /// <param name="other">Instance of Campaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Campaign other)
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
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.ContactList == other.ContactList ||
                    this.ContactList != null &&
                    this.ContactList.Equals(other.ContactList)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.DialingMode == other.DialingMode ||
                    this.DialingMode != null &&
                    this.DialingMode.Equals(other.DialingMode)
                ) &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.EdgeGroup == other.EdgeGroup ||
                    this.EdgeGroup != null &&
                    this.EdgeGroup.Equals(other.EdgeGroup)
                ) &&
                (
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) &&
                (
                    this.CampaignStatus == other.CampaignStatus ||
                    this.CampaignStatus != null &&
                    this.CampaignStatus.Equals(other.CampaignStatus)
                ) &&
                (
                    this.PhoneColumns == other.PhoneColumns ||
                    this.PhoneColumns != null &&
                    this.PhoneColumns.SequenceEqual(other.PhoneColumns)
                ) &&
                (
                    this.AbandonRate == other.AbandonRate ||
                    this.AbandonRate != null &&
                    this.AbandonRate.Equals(other.AbandonRate)
                ) &&
                (
                    this.DncLists == other.DncLists ||
                    this.DncLists != null &&
                    this.DncLists.SequenceEqual(other.DncLists)
                ) &&
                (
                    this.CallableTimeSet == other.CallableTimeSet ||
                    this.CallableTimeSet != null &&
                    this.CallableTimeSet.Equals(other.CallableTimeSet)
                ) &&
                (
                    this.CallAnalysisResponseSet == other.CallAnalysisResponseSet ||
                    this.CallAnalysisResponseSet != null &&
                    this.CallAnalysisResponseSet.Equals(other.CallAnalysisResponseSet)
                ) &&
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) &&
                (
                    this.CallerName == other.CallerName ||
                    this.CallerName != null &&
                    this.CallerName.Equals(other.CallerName)
                ) &&
                (
                    this.CallerAddress == other.CallerAddress ||
                    this.CallerAddress != null &&
                    this.CallerAddress.Equals(other.CallerAddress)
                ) &&
                (
                    this.OutboundLineCount == other.OutboundLineCount ||
                    this.OutboundLineCount != null &&
                    this.OutboundLineCount.Equals(other.OutboundLineCount)
                ) &&
                (
                    this.RuleSets == other.RuleSets ||
                    this.RuleSets != null &&
                    this.RuleSets.SequenceEqual(other.RuleSets)
                ) &&
                (
                    this.SkipPreviewDisabled == other.SkipPreviewDisabled ||
                    this.SkipPreviewDisabled != null &&
                    this.SkipPreviewDisabled.Equals(other.SkipPreviewDisabled)
                ) &&
                (
                    this.PreviewTimeOutSeconds == other.PreviewTimeOutSeconds ||
                    this.PreviewTimeOutSeconds != null &&
                    this.PreviewTimeOutSeconds.Equals(other.PreviewTimeOutSeconds)
                ) &&
                (
                    this.AlwaysRunning == other.AlwaysRunning ||
                    this.AlwaysRunning != null &&
                    this.AlwaysRunning.Equals(other.AlwaysRunning)
                ) &&
                (
                    this.ContactSort == other.ContactSort ||
                    this.ContactSort != null &&
                    this.ContactSort.Equals(other.ContactSort)
                ) &&
                (
                    this.ContactSorts == other.ContactSorts ||
                    this.ContactSorts != null &&
                    this.ContactSorts.SequenceEqual(other.ContactSorts)
                ) &&
                (
                    this.NoAnswerTimeout == other.NoAnswerTimeout ||
                    this.NoAnswerTimeout != null &&
                    this.NoAnswerTimeout.Equals(other.NoAnswerTimeout)
                ) &&
                (
                    this.CallAnalysisLanguage == other.CallAnalysisLanguage ||
                    this.CallAnalysisLanguage != null &&
                    this.CallAnalysisLanguage.Equals(other.CallAnalysisLanguage)
                ) &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) &&
                (
                    this.ContactListFilters == other.ContactListFilters ||
                    this.ContactListFilters != null &&
                    this.ContactListFilters.SequenceEqual(other.ContactListFilters)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.AgentOwnedColumn == other.AgentOwnedColumn ||
                    this.AgentOwnedColumn != null &&
                    this.AgentOwnedColumn.Equals(other.AgentOwnedColumn)
                ) &&
                (
                    this.DynamicContactQueueingSettings == other.DynamicContactQueueingSettings ||
                    this.DynamicContactQueueingSettings != null &&
                    this.DynamicContactQueueingSettings.Equals(other.DynamicContactQueueingSettings)
                ) &&
                (
                    this.SkillColumns == other.SkillColumns ||
                    this.SkillColumns != null &&
                    this.SkillColumns.SequenceEqual(other.SkillColumns)
                ) &&
                (
                    this.MaxCallsPerAgent == other.MaxCallsPerAgent ||
                    this.MaxCallsPerAgent != null &&
                    this.MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
                ) &&
                (
                    this.MaxCallsPerAgentDecimal == other.MaxCallsPerAgentDecimal ||
                    this.MaxCallsPerAgentDecimal != null &&
                    this.MaxCallsPerAgentDecimal.Equals(other.MaxCallsPerAgentDecimal)
                ) &&
                (
                    this.CallbackAutoAnswer == other.CallbackAutoAnswer ||
                    this.CallbackAutoAnswer != null &&
                    this.CallbackAutoAnswer.Equals(other.CallbackAutoAnswer)
                ) &&
                (
                    this.DynamicLineBalancingSettings == other.DynamicLineBalancingSettings ||
                    this.DynamicLineBalancingSettings != null &&
                    this.DynamicLineBalancingSettings.Equals(other.DynamicLineBalancingSettings)
                ) &&
                (
                    this.DiagnosticsSettings == other.DiagnosticsSettings ||
                    this.DiagnosticsSettings != null &&
                    this.DiagnosticsSettings.Equals(other.DiagnosticsSettings)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.ContactList != null)
                    hash = hash * 59 + this.ContactList.GetHashCode();

                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();

                if (this.DialingMode != null)
                    hash = hash * 59 + this.DialingMode.GetHashCode();

                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();

                if (this.EdgeGroup != null)
                    hash = hash * 59 + this.EdgeGroup.GetHashCode();

                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();

                if (this.CampaignStatus != null)
                    hash = hash * 59 + this.CampaignStatus.GetHashCode();

                if (this.PhoneColumns != null)
                    hash = hash * 59 + this.PhoneColumns.GetHashCode();

                if (this.AbandonRate != null)
                    hash = hash * 59 + this.AbandonRate.GetHashCode();

                if (this.DncLists != null)
                    hash = hash * 59 + this.DncLists.GetHashCode();

                if (this.CallableTimeSet != null)
                    hash = hash * 59 + this.CallableTimeSet.GetHashCode();

                if (this.CallAnalysisResponseSet != null)
                    hash = hash * 59 + this.CallAnalysisResponseSet.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                if (this.CallerName != null)
                    hash = hash * 59 + this.CallerName.GetHashCode();

                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();

                if (this.OutboundLineCount != null)
                    hash = hash * 59 + this.OutboundLineCount.GetHashCode();

                if (this.RuleSets != null)
                    hash = hash * 59 + this.RuleSets.GetHashCode();

                if (this.SkipPreviewDisabled != null)
                    hash = hash * 59 + this.SkipPreviewDisabled.GetHashCode();

                if (this.PreviewTimeOutSeconds != null)
                    hash = hash * 59 + this.PreviewTimeOutSeconds.GetHashCode();

                if (this.AlwaysRunning != null)
                    hash = hash * 59 + this.AlwaysRunning.GetHashCode();

                if (this.ContactSort != null)
                    hash = hash * 59 + this.ContactSort.GetHashCode();

                if (this.ContactSorts != null)
                    hash = hash * 59 + this.ContactSorts.GetHashCode();

                if (this.NoAnswerTimeout != null)
                    hash = hash * 59 + this.NoAnswerTimeout.GetHashCode();

                if (this.CallAnalysisLanguage != null)
                    hash = hash * 59 + this.CallAnalysisLanguage.GetHashCode();

                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                if (this.ContactListFilters != null)
                    hash = hash * 59 + this.ContactListFilters.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.AgentOwnedColumn != null)
                    hash = hash * 59 + this.AgentOwnedColumn.GetHashCode();

                if (this.DynamicContactQueueingSettings != null)
                    hash = hash * 59 + this.DynamicContactQueueingSettings.GetHashCode();

                if (this.SkillColumns != null)
                    hash = hash * 59 + this.SkillColumns.GetHashCode();

                if (this.MaxCallsPerAgent != null)
                    hash = hash * 59 + this.MaxCallsPerAgent.GetHashCode();

                if (this.MaxCallsPerAgentDecimal != null)
                    hash = hash * 59 + this.MaxCallsPerAgentDecimal.GetHashCode();

                if (this.CallbackAutoAnswer != null)
                    hash = hash * 59 + this.CallbackAutoAnswer.GetHashCode();

                if (this.DynamicLineBalancingSettings != null)
                    hash = hash * 59 + this.DynamicLineBalancingSettings.GetHashCode();

                if (this.DiagnosticsSettings != null)
                    hash = hash * 59 + this.DiagnosticsSettings.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
