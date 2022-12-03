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
    /// DialerCampaignConfigChangeCampaign
    /// </summary>
    [DataContract]
    public partial class DialerCampaignConfigChangeCampaign :  IEquatable<DialerCampaignConfigChangeCampaign>
    {
        /// <summary>
        /// dialing mode of the campaign
        /// </summary>
        /// <value>dialing mode of the campaign</value>
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
            /// Enum External for "external"
            /// </summary>
            [EnumMember(Value = "external")]
            External,
            
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
            Progressive
        }
        /// <summary>
        /// Gets or Sets CampaignStatus
        /// </summary>
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
            /// Enum Stopping for "stopping"
            /// </summary>
            [EnumMember(Value = "stopping")]
            Stopping,
            
            /// <summary>
            /// Enum Invalid for "invalid"
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid
        }
        /// <summary>
        /// dialing mode of the campaign
        /// </summary>
        /// <value>dialing mode of the campaign</value>
        [DataMember(Name="dialingMode", EmitDefaultValue=false)]
        public DialingModeEnum? DialingMode { get; set; }
        /// <summary>
        /// Gets or Sets CampaignStatus
        /// </summary>
        [DataMember(Name="campaignStatus", EmitDefaultValue=false)]
        public CampaignStatusEnum? CampaignStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignConfigChangeCampaign" /> class.
        /// </summary>
        /// <param name="ContactList">ContactList.</param>
        /// <param name="Queue">A UriReference for a resource.</param>
        /// <param name="DialingMode">dialing mode of the campaign.</param>
        /// <param name="Script">A UriReference for a resource.</param>
        /// <param name="EdgeGroup">A UriReference for a resource.</param>
        /// <param name="Site">A UriReference for a resource.</param>
        /// <param name="CampaignStatus">CampaignStatus.</param>
        /// <param name="PhoneColumns">the contact list phone columns to be called for the campaign.</param>
        /// <param name="AbandonRate">the targeted abandon rate percentage.</param>
        /// <param name="DncLists">identifiers of the do not call lists.</param>
        /// <param name="CallableTimeSet">A UriReference for a resource.</param>
        /// <param name="CallAnalysisResponseSet">A UriReference for a resource.</param>
        /// <param name="CallerName">caller id name to be displayed on the outbound call.</param>
        /// <param name="CallerAddress">caller id phone number to be displayed on the outbound call.</param>
        /// <param name="OutboundLineCount">for agentless campaigns, the number of outbound lines to be concurrently dialed.</param>
        /// <param name="Errors">a list of current error conditions associated with the campaign.</param>
        /// <param name="RuleSets">identifiers of the rule sets.</param>
        /// <param name="SkipPreviewDisabled">for preview campaigns, indicator of whether the agent can skip a preview without placing a call.</param>
        /// <param name="PreviewTimeOutSeconds">for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls.</param>
        /// <param name="SingleNumberPreview">for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview.</param>
        /// <param name="ContactSort">ContactSort.</param>
        /// <param name="ContactSorts">List of contact sort objects..</param>
        /// <param name="NoAnswerTimeout">for non-preview campaigns, how long to wait before dispositioning as 'no-answer', default 30 seconds.</param>
        /// <param name="CallAnalysisLanguage">The language the edge will use to analyze the call.</param>
        /// <param name="Priority">The priority of this campaign relative to other campaigns.</param>
        /// <param name="ContactListFilters">List of contact filters.</param>
        /// <param name="Division">A UriReference for a resource.</param>
        /// <param name="AgentOwnedColumn">For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to..</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        public DialerCampaignConfigChangeCampaign(DialerCampaignConfigChangeUriReference ContactList = null, DialerCampaignConfigChangeUriReference Queue = null, DialingModeEnum? DialingMode = null, DialerCampaignConfigChangeUriReference Script = null, DialerCampaignConfigChangeUriReference EdgeGroup = null, DialerCampaignConfigChangeUriReference Site = null, CampaignStatusEnum? CampaignStatus = null, List<DialerCampaignConfigChangePhoneColumn> PhoneColumns = null, double? AbandonRate = null, List<DialerCampaignConfigChangeUriReference> DncLists = null, DialerCampaignConfigChangeUriReference CallableTimeSet = null, DialerCampaignConfigChangeUriReference CallAnalysisResponseSet = null, string CallerName = null, string CallerAddress = null, int? OutboundLineCount = null, List<DialerCampaignConfigChangeRestErrorDetail> Errors = null, List<DialerCampaignConfigChangeUriReference> RuleSets = null, bool? SkipPreviewDisabled = null, int? PreviewTimeOutSeconds = null, bool? SingleNumberPreview = null, DialerCampaignConfigChangeContactSort ContactSort = null, List<DialerCampaignConfigChangeContactSort> ContactSorts = null, int? NoAnswerTimeout = null, string CallAnalysisLanguage = null, int? Priority = null, List<DialerCampaignConfigChangeUriReference> ContactListFilters = null, DialerCampaignConfigChangeUriReference Division = null, string AgentOwnedColumn = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null)
        {
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
            this.Errors = Errors;
            this.RuleSets = RuleSets;
            this.SkipPreviewDisabled = SkipPreviewDisabled;
            this.PreviewTimeOutSeconds = PreviewTimeOutSeconds;
            this.SingleNumberPreview = SingleNumberPreview;
            this.ContactSort = ContactSort;
            this.ContactSorts = ContactSorts;
            this.NoAnswerTimeout = NoAnswerTimeout;
            this.CallAnalysisLanguage = CallAnalysisLanguage;
            this.Priority = Priority;
            this.ContactListFilters = ContactListFilters;
            this.Division = Division;
            this.AgentOwnedColumn = AgentOwnedColumn;
            this.AdditionalProperties = AdditionalProperties;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            
        }
        


        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference ContactList { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference Queue { get; set; }





        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference Script { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference EdgeGroup { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference Site { get; set; }





        /// <summary>
        /// the contact list phone columns to be called for the campaign
        /// </summary>
        /// <value>the contact list phone columns to be called for the campaign</value>
        [DataMember(Name="phoneColumns", EmitDefaultValue=false)]
        public List<DialerCampaignConfigChangePhoneColumn> PhoneColumns { get; set; }



        /// <summary>
        /// the targeted abandon rate percentage
        /// </summary>
        /// <value>the targeted abandon rate percentage</value>
        [DataMember(Name="abandonRate", EmitDefaultValue=false)]
        public double? AbandonRate { get; set; }



        /// <summary>
        /// identifiers of the do not call lists
        /// </summary>
        /// <value>identifiers of the do not call lists</value>
        [DataMember(Name="dncLists", EmitDefaultValue=false)]
        public List<DialerCampaignConfigChangeUriReference> DncLists { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="callableTimeSet", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference CallableTimeSet { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="callAnalysisResponseSet", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference CallAnalysisResponseSet { get; set; }



        /// <summary>
        /// caller id name to be displayed on the outbound call
        /// </summary>
        /// <value>caller id name to be displayed on the outbound call</value>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }



        /// <summary>
        /// caller id phone number to be displayed on the outbound call
        /// </summary>
        /// <value>caller id phone number to be displayed on the outbound call</value>
        [DataMember(Name="callerAddress", EmitDefaultValue=false)]
        public string CallerAddress { get; set; }



        /// <summary>
        /// for agentless campaigns, the number of outbound lines to be concurrently dialed
        /// </summary>
        /// <value>for agentless campaigns, the number of outbound lines to be concurrently dialed</value>
        [DataMember(Name="outboundLineCount", EmitDefaultValue=false)]
        public int? OutboundLineCount { get; set; }



        /// <summary>
        /// a list of current error conditions associated with the campaign
        /// </summary>
        /// <value>a list of current error conditions associated with the campaign</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<DialerCampaignConfigChangeRestErrorDetail> Errors { get; set; }



        /// <summary>
        /// identifiers of the rule sets
        /// </summary>
        /// <value>identifiers of the rule sets</value>
        [DataMember(Name="ruleSets", EmitDefaultValue=false)]
        public List<DialerCampaignConfigChangeUriReference> RuleSets { get; set; }



        /// <summary>
        /// for preview campaigns, indicator of whether the agent can skip a preview without placing a call
        /// </summary>
        /// <value>for preview campaigns, indicator of whether the agent can skip a preview without placing a call</value>
        [DataMember(Name="skipPreviewDisabled", EmitDefaultValue=false)]
        public bool? SkipPreviewDisabled { get; set; }



        /// <summary>
        /// for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls
        /// </summary>
        /// <value>for preview campaigns, number of seconds before a call will be automatically placed. A value of 0 indicates no automatic placement of calls</value>
        [DataMember(Name="previewTimeOutSeconds", EmitDefaultValue=false)]
        public int? PreviewTimeOutSeconds { get; set; }



        /// <summary>
        /// for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview
        /// </summary>
        /// <value>for preview campaigns with multiple phone columns, indicator if one (true) or multiple (false) phone numbers will be available to call for each preview</value>
        [DataMember(Name="singleNumberPreview", EmitDefaultValue=false)]
        public bool? SingleNumberPreview { get; set; }



        /// <summary>
        /// Gets or Sets ContactSort
        /// </summary>
        [DataMember(Name="contactSort", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeContactSort ContactSort { get; set; }



        /// <summary>
        /// List of contact sort objects.
        /// </summary>
        /// <value>List of contact sort objects.</value>
        [DataMember(Name="contactSorts", EmitDefaultValue=false)]
        public List<DialerCampaignConfigChangeContactSort> ContactSorts { get; set; }



        /// <summary>
        /// for non-preview campaigns, how long to wait before dispositioning as 'no-answer', default 30 seconds
        /// </summary>
        /// <value>for non-preview campaigns, how long to wait before dispositioning as 'no-answer', default 30 seconds</value>
        [DataMember(Name="noAnswerTimeout", EmitDefaultValue=false)]
        public int? NoAnswerTimeout { get; set; }



        /// <summary>
        /// The language the edge will use to analyze the call
        /// </summary>
        /// <value>The language the edge will use to analyze the call</value>
        [DataMember(Name="callAnalysisLanguage", EmitDefaultValue=false)]
        public string CallAnalysisLanguage { get; set; }



        /// <summary>
        /// The priority of this campaign relative to other campaigns
        /// </summary>
        /// <value>The priority of this campaign relative to other campaigns</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }



        /// <summary>
        /// List of contact filters
        /// </summary>
        /// <value>List of contact filters</value>
        [DataMember(Name="contactListFilters", EmitDefaultValue=false)]
        public List<DialerCampaignConfigChangeUriReference> ContactListFilters { get; set; }



        /// <summary>
        /// A UriReference for a resource
        /// </summary>
        /// <value>A UriReference for a resource</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DialerCampaignConfigChangeUriReference Division { get; set; }



        /// <summary>
        /// For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to.
        /// </summary>
        /// <value>For Preview Campaigns. Name of the contact column in the contact list containing the userIds of agents to assign specific contact records to.</value>
        [DataMember(Name="agentOwnedColumn", EmitDefaultValue=false)]
        public string AgentOwnedColumn { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignConfigChangeCampaign {\n");

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
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
            sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  RuleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  SkipPreviewDisabled: ").Append(SkipPreviewDisabled).Append("\n");
            sb.Append("  PreviewTimeOutSeconds: ").Append(PreviewTimeOutSeconds).Append("\n");
            sb.Append("  SingleNumberPreview: ").Append(SingleNumberPreview).Append("\n");
            sb.Append("  ContactSort: ").Append(ContactSort).Append("\n");
            sb.Append("  ContactSorts: ").Append(ContactSorts).Append("\n");
            sb.Append("  NoAnswerTimeout: ").Append(NoAnswerTimeout).Append("\n");
            sb.Append("  CallAnalysisLanguage: ").Append(CallAnalysisLanguage).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ContactListFilters: ").Append(ContactListFilters).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  AgentOwnedColumn: ").Append(AgentOwnedColumn).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as DialerCampaignConfigChangeCampaign);
        }

        /// <summary>
        /// Returns true if DialerCampaignConfigChangeCampaign instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignConfigChangeCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignConfigChangeCampaign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                    this.SingleNumberPreview == other.SingleNumberPreview ||
                    this.SingleNumberPreview != null &&
                    this.SingleNumberPreview.Equals(other.SingleNumberPreview)
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
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
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

                if (this.CallerName != null)
                    hash = hash * 59 + this.CallerName.GetHashCode();

                if (this.CallerAddress != null)
                    hash = hash * 59 + this.CallerAddress.GetHashCode();

                if (this.OutboundLineCount != null)
                    hash = hash * 59 + this.OutboundLineCount.GetHashCode();

                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();

                if (this.RuleSets != null)
                    hash = hash * 59 + this.RuleSets.GetHashCode();

                if (this.SkipPreviewDisabled != null)
                    hash = hash * 59 + this.SkipPreviewDisabled.GetHashCode();

                if (this.PreviewTimeOutSeconds != null)
                    hash = hash * 59 + this.PreviewTimeOutSeconds.GetHashCode();

                if (this.SingleNumberPreview != null)
                    hash = hash * 59 + this.SingleNumberPreview.GetHashCode();

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

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

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

                return hash;
            }
        }
    }

}
