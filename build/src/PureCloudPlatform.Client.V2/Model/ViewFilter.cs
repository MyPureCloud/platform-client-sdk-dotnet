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
    /// ViewFilter
    /// </summary>
    [DataContract]
    public partial class ViewFilter :  IEquatable<ViewFilter>
    {
        
        
        
        
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "voice"
            /// </summary>
            [EnumMember(Value = "voice")]
            Voice,
            
            /// <summary>
            /// Enum Chat for "chat"
            /// </summary>
            [EnumMember(Value = "chat")]
            Chat,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
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
            /// Enum Video for "video"
            /// </summary>
            [EnumMember(Value = "video")]
            Video,
            
            /// <summary>
            /// Enum Screenshare for "screenshare"
            /// </summary>
            [EnumMember(Value = "screenshare")]
            Screenshare,
            
            /// <summary>
            /// Enum Message for "message"
            /// </summary>
            [EnumMember(Value = "message")]
            Message
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Directions
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DirectionsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "inbound"
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "outbound"
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MessageTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MessageTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sms for "sms"
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms,
            
            /// <summary>
            /// Enum Twitter for "twitter"
            /// </summary>
            [EnumMember(Value = "twitter")]
            Twitter,
            
            /// <summary>
            /// Enum Line for "line"
            /// </summary>
            [EnumMember(Value = "line")]
            Line,
            
            /// <summary>
            /// Enum Facebook for "facebook"
            /// </summary>
            [EnumMember(Value = "facebook")]
            Facebook
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Provides the agent duration sort order
        /// </summary>
        /// <value>Provides the agent duration sort order</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AgentDurationSortOrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ascending for "ascending"
            /// </summary>
            [EnumMember(Value = "ascending")]
            Ascending,
            
            /// <summary>
            /// Enum Descending for "descending"
            /// </summary>
            [EnumMember(Value = "descending")]
            Descending
        }
        
        
        
        
        /// <summary>
        /// Provides the waiting duration sort order
        /// </summary>
        /// <value>Provides the waiting duration sort order</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum WaitingDurationSortOrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ascending for "ascending"
            /// </summary>
            [EnumMember(Value = "ascending")]
            Ascending,
            
            /// <summary>
            /// Enum Descending for "descending"
            /// </summary>
            [EnumMember(Value = "descending")]
            Descending
        }
        
        
        
        
        /// <summary>
        /// Provides the interacting duration sort order
        /// </summary>
        /// <value>Provides the interacting duration sort order</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InteractingDurationSortOrderEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ascending for "ascending"
            /// </summary>
            [EnumMember(Value = "ascending")]
            Ascending,
            
            /// <summary>
            /// Enum Descending for "descending"
            /// </summary>
            [EnumMember(Value = "descending")]
            Descending
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Provides the agent duration sort order
        /// </summary>
        /// <value>Provides the agent duration sort order</value>
        [DataMember(Name="agentDurationSortOrder", EmitDefaultValue=false)]
        public AgentDurationSortOrderEnum? AgentDurationSortOrder { get; set; }
        
        
        
        /// <summary>
        /// Provides the waiting duration sort order
        /// </summary>
        /// <value>Provides the waiting duration sort order</value>
        [DataMember(Name="waitingDurationSortOrder", EmitDefaultValue=false)]
        public WaitingDurationSortOrderEnum? WaitingDurationSortOrder { get; set; }
        
        
        
        /// <summary>
        /// Provides the interacting duration sort order
        /// </summary>
        /// <value>Provides the interacting duration sort order</value>
        [DataMember(Name="interactingDurationSortOrder", EmitDefaultValue=false)]
        public InteractingDurationSortOrderEnum? InteractingDurationSortOrder { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewFilter" /> class.
        /// </summary>
        /// <param name="MediaTypes">The media types are used to filter the view.</param>
        /// <param name="QueueIds">The queue ids are used to filter the view.</param>
        /// <param name="SkillIds">The skill ids are used to filter the view.</param>
        /// <param name="SkillGroups">The skill groups used to filter the view.</param>
        /// <param name="LanguageIds">The language ids are used to filter the view.</param>
        /// <param name="LanguageGroups">The language groups used to filter the view.</param>
        /// <param name="Directions">The directions are used to filter the view.</param>
        /// <param name="WrapUpCodes">The wrap up codes are used to filter the view.</param>
        /// <param name="DnisList">The dnis list is used to filter the view.</param>
        /// <param name="FilterQueuesByUserIds">The user ids are used to fetch associated queues for the view.</param>
        /// <param name="FilterUsersByQueueIds">The queue ids are used to fetch associated users for the view.</param>
        /// <param name="UserIds">The user ids are used to filter the view.</param>
        /// <param name="AddressTos">The address To values are used to filter the view.</param>
        /// <param name="AddressFroms">The address from values are used to filter the view.</param>
        /// <param name="OutboundCampaignIds">The outbound campaign ids are used to filter the view.</param>
        /// <param name="OutboundContactListIds">The outbound contact list ids are used to filter the view.</param>
        /// <param name="ContactIds">The contact ids are used to filter the view.</param>
        /// <param name="AniList">The ani list ids are used to filter the view.</param>
        /// <param name="DurationsMilliseconds">The durations in milliseconds used to filter the view.</param>
        /// <param name="EvaluationScore">The evaluationScore is used to filter the view.</param>
        /// <param name="EvaluationCriticalScore">The evaluationCriticalScore is used to filter the view.</param>
        /// <param name="EvaluationFormIds">The evaluation form ids are used to filter the view.</param>
        /// <param name="EvaluatedAgentIds">The evaluated agent ids are used to filter the view.</param>
        /// <param name="EvaluatorIds">The evaluator ids are used to filter the view.</param>
        /// <param name="Transferred">Indicates filtering for transfers.</param>
        /// <param name="Abandoned">Indicates filtering for abandons.</param>
        /// <param name="MessageTypes">The message media types used to filter the view.</param>
        /// <param name="DivisionIds">The divison Ids used to filter the view.</param>
        /// <param name="SurveyFormIds">The survey form ids used to filter the view.</param>
        /// <param name="SurveyTotalScore">The survey total score used to filter the view.</param>
        /// <param name="SurveyNpsScore">The survey NPS score used to filter the view.</param>
        /// <param name="ShowSecondaryStatus">Indicates if the Secondary Status should be shown.</param>
        /// <param name="AgentDurationSortOrder">Provides the agent duration sort order.</param>
        /// <param name="WaitingDurationSortOrder">Provides the waiting duration sort order.</param>
        /// <param name="InteractingDurationSortOrder">Provides the interacting duration sort order.</param>
        /// <param name="AgentName">Displays the Agent name as provided by the user.</param>
        /// <param name="SkillsList">The list of skill strings as free form text.</param>
        /// <param name="LanguageList">The list of language strings as free form text.</param>
        /// <param name="Mos">The desired range for mos values.</param>
        /// <param name="SurveyQuestionGroupScore">The survey question group score used to filter the view.</param>
        /// <param name="SurveyPromoterScore">The survey promoter score used to filter the view.</param>
        /// <param name="SurveyFormContextIds">The list of survey form context ids used to filter the view.</param>
        /// <param name="ConversationIds">The list of conversation ids used to filter the view.</param>
        /// <param name="IsEnded">Indicates filtering for ended.</param>
        /// <param name="IsSurveyed">Indicates filtering for survey.</param>
        /// <param name="SurveyScores">The list of survey score ranges used to filter the view.</param>
        /// <param name="PromoterScores">The list of promoter score ranges used to filter the view.</param>
        /// <param name="IsCampaign">Indicates filtering for campaign.</param>
        /// <param name="SurveyStatuses">The list of survey statuses used to filter the view.</param>
        /// <param name="ConversationProperties">A grouping of conversation level filters.</param>
        /// <param name="IsBlindTransferred">Indicates filtering for blind transferred.</param>
        /// <param name="IsConsulted">Indicates filtering for consulted.</param>
        /// <param name="IsConsultTransferred">Indicates filtering for consult transferred.</param>
        /// <param name="RemoteParticipants">The list of remote participants used to filter the view.</param>
        public ViewFilter(List<MediaTypesEnum> MediaTypes = null, List<string> QueueIds = null, List<string> SkillIds = null, List<string> SkillGroups = null, List<string> LanguageIds = null, List<string> LanguageGroups = null, List<DirectionsEnum> Directions = null, List<string> WrapUpCodes = null, List<string> DnisList = null, List<string> FilterQueuesByUserIds = null, List<string> FilterUsersByQueueIds = null, List<string> UserIds = null, List<string> AddressTos = null, List<string> AddressFroms = null, List<string> OutboundCampaignIds = null, List<string> OutboundContactListIds = null, List<string> ContactIds = null, List<string> AniList = null, List<NumericRange> DurationsMilliseconds = null, NumericRange EvaluationScore = null, NumericRange EvaluationCriticalScore = null, List<string> EvaluationFormIds = null, List<string> EvaluatedAgentIds = null, List<string> EvaluatorIds = null, bool? Transferred = null, bool? Abandoned = null, List<MessageTypesEnum> MessageTypes = null, List<string> DivisionIds = null, List<string> SurveyFormIds = null, NumericRange SurveyTotalScore = null, NumericRange SurveyNpsScore = null, bool? ShowSecondaryStatus = null, AgentDurationSortOrderEnum? AgentDurationSortOrder = null, WaitingDurationSortOrderEnum? WaitingDurationSortOrder = null, InteractingDurationSortOrderEnum? InteractingDurationSortOrder = null, string AgentName = null, List<string> SkillsList = null, List<string> LanguageList = null, NumericRange Mos = null, NumericRange SurveyQuestionGroupScore = null, NumericRange SurveyPromoterScore = null, List<string> SurveyFormContextIds = null, List<string> ConversationIds = null, bool? IsEnded = null, bool? IsSurveyed = null, List<NumericRange> SurveyScores = null, List<NumericRange> PromoterScores = null, bool? IsCampaign = null, List<string> SurveyStatuses = null, ConversationProperties ConversationProperties = null, bool? IsBlindTransferred = null, bool? IsConsulted = null, bool? IsConsultTransferred = null, List<string> RemoteParticipants = null)
        {
            this.MediaTypes = MediaTypes;
            this.QueueIds = QueueIds;
            this.SkillIds = SkillIds;
            this.SkillGroups = SkillGroups;
            this.LanguageIds = LanguageIds;
            this.LanguageGroups = LanguageGroups;
            this.Directions = Directions;
            this.WrapUpCodes = WrapUpCodes;
            this.DnisList = DnisList;
            this.FilterQueuesByUserIds = FilterQueuesByUserIds;
            this.FilterUsersByQueueIds = FilterUsersByQueueIds;
            this.UserIds = UserIds;
            this.AddressTos = AddressTos;
            this.AddressFroms = AddressFroms;
            this.OutboundCampaignIds = OutboundCampaignIds;
            this.OutboundContactListIds = OutboundContactListIds;
            this.ContactIds = ContactIds;
            this.AniList = AniList;
            this.DurationsMilliseconds = DurationsMilliseconds;
            this.EvaluationScore = EvaluationScore;
            this.EvaluationCriticalScore = EvaluationCriticalScore;
            this.EvaluationFormIds = EvaluationFormIds;
            this.EvaluatedAgentIds = EvaluatedAgentIds;
            this.EvaluatorIds = EvaluatorIds;
            this.Transferred = Transferred;
            this.Abandoned = Abandoned;
            this.MessageTypes = MessageTypes;
            this.DivisionIds = DivisionIds;
            this.SurveyFormIds = SurveyFormIds;
            this.SurveyTotalScore = SurveyTotalScore;
            this.SurveyNpsScore = SurveyNpsScore;
            this.ShowSecondaryStatus = ShowSecondaryStatus;
            this.AgentDurationSortOrder = AgentDurationSortOrder;
            this.WaitingDurationSortOrder = WaitingDurationSortOrder;
            this.InteractingDurationSortOrder = InteractingDurationSortOrder;
            this.AgentName = AgentName;
            this.SkillsList = SkillsList;
            this.LanguageList = LanguageList;
            this.Mos = Mos;
            this.SurveyQuestionGroupScore = SurveyQuestionGroupScore;
            this.SurveyPromoterScore = SurveyPromoterScore;
            this.SurveyFormContextIds = SurveyFormContextIds;
            this.ConversationIds = ConversationIds;
            this.IsEnded = IsEnded;
            this.IsSurveyed = IsSurveyed;
            this.SurveyScores = SurveyScores;
            this.PromoterScores = PromoterScores;
            this.IsCampaign = IsCampaign;
            this.SurveyStatuses = SurveyStatuses;
            this.ConversationProperties = ConversationProperties;
            this.IsBlindTransferred = IsBlindTransferred;
            this.IsConsulted = IsConsulted;
            this.IsConsultTransferred = IsConsultTransferred;
            this.RemoteParticipants = RemoteParticipants;
            
        }
        
        
        
        /// <summary>
        /// The media types are used to filter the view
        /// </summary>
        /// <value>The media types are used to filter the view</value>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<MediaTypesEnum> MediaTypes { get; set; }
        
        
        
        /// <summary>
        /// The queue ids are used to filter the view
        /// </summary>
        /// <value>The queue ids are used to filter the view</value>
        [DataMember(Name="queueIds", EmitDefaultValue=false)]
        public List<string> QueueIds { get; set; }
        
        
        
        /// <summary>
        /// The skill ids are used to filter the view
        /// </summary>
        /// <value>The skill ids are used to filter the view</value>
        [DataMember(Name="skillIds", EmitDefaultValue=false)]
        public List<string> SkillIds { get; set; }
        
        
        
        /// <summary>
        /// The skill groups used to filter the view
        /// </summary>
        /// <value>The skill groups used to filter the view</value>
        [DataMember(Name="skillGroups", EmitDefaultValue=false)]
        public List<string> SkillGroups { get; set; }
        
        
        
        /// <summary>
        /// The language ids are used to filter the view
        /// </summary>
        /// <value>The language ids are used to filter the view</value>
        [DataMember(Name="languageIds", EmitDefaultValue=false)]
        public List<string> LanguageIds { get; set; }
        
        
        
        /// <summary>
        /// The language groups used to filter the view
        /// </summary>
        /// <value>The language groups used to filter the view</value>
        [DataMember(Name="languageGroups", EmitDefaultValue=false)]
        public List<string> LanguageGroups { get; set; }
        
        
        
        /// <summary>
        /// The directions are used to filter the view
        /// </summary>
        /// <value>The directions are used to filter the view</value>
        [DataMember(Name="directions", EmitDefaultValue=false)]
        public List<DirectionsEnum> Directions { get; set; }
        
        
        
        /// <summary>
        /// The wrap up codes are used to filter the view
        /// </summary>
        /// <value>The wrap up codes are used to filter the view</value>
        [DataMember(Name="wrapUpCodes", EmitDefaultValue=false)]
        public List<string> WrapUpCodes { get; set; }
        
        
        
        /// <summary>
        /// The dnis list is used to filter the view
        /// </summary>
        /// <value>The dnis list is used to filter the view</value>
        [DataMember(Name="dnisList", EmitDefaultValue=false)]
        public List<string> DnisList { get; set; }
        
        
        
        /// <summary>
        /// The user ids are used to fetch associated queues for the view
        /// </summary>
        /// <value>The user ids are used to fetch associated queues for the view</value>
        [DataMember(Name="filterQueuesByUserIds", EmitDefaultValue=false)]
        public List<string> FilterQueuesByUserIds { get; set; }
        
        
        
        /// <summary>
        /// The queue ids are used to fetch associated users for the view
        /// </summary>
        /// <value>The queue ids are used to fetch associated users for the view</value>
        [DataMember(Name="filterUsersByQueueIds", EmitDefaultValue=false)]
        public List<string> FilterUsersByQueueIds { get; set; }
        
        
        
        /// <summary>
        /// The user ids are used to filter the view
        /// </summary>
        /// <value>The user ids are used to filter the view</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }
        
        
        
        /// <summary>
        /// The address To values are used to filter the view
        /// </summary>
        /// <value>The address To values are used to filter the view</value>
        [DataMember(Name="addressTos", EmitDefaultValue=false)]
        public List<string> AddressTos { get; set; }
        
        
        
        /// <summary>
        /// The address from values are used to filter the view
        /// </summary>
        /// <value>The address from values are used to filter the view</value>
        [DataMember(Name="addressFroms", EmitDefaultValue=false)]
        public List<string> AddressFroms { get; set; }
        
        
        
        /// <summary>
        /// The outbound campaign ids are used to filter the view
        /// </summary>
        /// <value>The outbound campaign ids are used to filter the view</value>
        [DataMember(Name="outboundCampaignIds", EmitDefaultValue=false)]
        public List<string> OutboundCampaignIds { get; set; }
        
        
        
        /// <summary>
        /// The outbound contact list ids are used to filter the view
        /// </summary>
        /// <value>The outbound contact list ids are used to filter the view</value>
        [DataMember(Name="outboundContactListIds", EmitDefaultValue=false)]
        public List<string> OutboundContactListIds { get; set; }
        
        
        
        /// <summary>
        /// The contact ids are used to filter the view
        /// </summary>
        /// <value>The contact ids are used to filter the view</value>
        [DataMember(Name="contactIds", EmitDefaultValue=false)]
        public List<string> ContactIds { get; set; }
        
        
        
        /// <summary>
        /// The ani list ids are used to filter the view
        /// </summary>
        /// <value>The ani list ids are used to filter the view</value>
        [DataMember(Name="aniList", EmitDefaultValue=false)]
        public List<string> AniList { get; set; }
        
        
        
        /// <summary>
        /// The durations in milliseconds used to filter the view
        /// </summary>
        /// <value>The durations in milliseconds used to filter the view</value>
        [DataMember(Name="durationsMilliseconds", EmitDefaultValue=false)]
        public List<NumericRange> DurationsMilliseconds { get; set; }
        
        
        
        /// <summary>
        /// The evaluationScore is used to filter the view
        /// </summary>
        /// <value>The evaluationScore is used to filter the view</value>
        [DataMember(Name="evaluationScore", EmitDefaultValue=false)]
        public NumericRange EvaluationScore { get; set; }
        
        
        
        /// <summary>
        /// The evaluationCriticalScore is used to filter the view
        /// </summary>
        /// <value>The evaluationCriticalScore is used to filter the view</value>
        [DataMember(Name="evaluationCriticalScore", EmitDefaultValue=false)]
        public NumericRange EvaluationCriticalScore { get; set; }
        
        
        
        /// <summary>
        /// The evaluation form ids are used to filter the view
        /// </summary>
        /// <value>The evaluation form ids are used to filter the view</value>
        [DataMember(Name="evaluationFormIds", EmitDefaultValue=false)]
        public List<string> EvaluationFormIds { get; set; }
        
        
        
        /// <summary>
        /// The evaluated agent ids are used to filter the view
        /// </summary>
        /// <value>The evaluated agent ids are used to filter the view</value>
        [DataMember(Name="evaluatedAgentIds", EmitDefaultValue=false)]
        public List<string> EvaluatedAgentIds { get; set; }
        
        
        
        /// <summary>
        /// The evaluator ids are used to filter the view
        /// </summary>
        /// <value>The evaluator ids are used to filter the view</value>
        [DataMember(Name="evaluatorIds", EmitDefaultValue=false)]
        public List<string> EvaluatorIds { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for transfers
        /// </summary>
        /// <value>Indicates filtering for transfers</value>
        [DataMember(Name="transferred", EmitDefaultValue=false)]
        public bool? Transferred { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for abandons
        /// </summary>
        /// <value>Indicates filtering for abandons</value>
        [DataMember(Name="abandoned", EmitDefaultValue=false)]
        public bool? Abandoned { get; set; }
        
        
        
        /// <summary>
        /// The message media types used to filter the view
        /// </summary>
        /// <value>The message media types used to filter the view</value>
        [DataMember(Name="messageTypes", EmitDefaultValue=false)]
        public List<MessageTypesEnum> MessageTypes { get; set; }
        
        
        
        /// <summary>
        /// The divison Ids used to filter the view
        /// </summary>
        /// <value>The divison Ids used to filter the view</value>
        [DataMember(Name="divisionIds", EmitDefaultValue=false)]
        public List<string> DivisionIds { get; set; }
        
        
        
        /// <summary>
        /// The survey form ids used to filter the view
        /// </summary>
        /// <value>The survey form ids used to filter the view</value>
        [DataMember(Name="surveyFormIds", EmitDefaultValue=false)]
        public List<string> SurveyFormIds { get; set; }
        
        
        
        /// <summary>
        /// The survey total score used to filter the view
        /// </summary>
        /// <value>The survey total score used to filter the view</value>
        [DataMember(Name="surveyTotalScore", EmitDefaultValue=false)]
        public NumericRange SurveyTotalScore { get; set; }
        
        
        
        /// <summary>
        /// The survey NPS score used to filter the view
        /// </summary>
        /// <value>The survey NPS score used to filter the view</value>
        [DataMember(Name="surveyNpsScore", EmitDefaultValue=false)]
        public NumericRange SurveyNpsScore { get; set; }
        
        
        
        /// <summary>
        /// Indicates if the Secondary Status should be shown
        /// </summary>
        /// <value>Indicates if the Secondary Status should be shown</value>
        [DataMember(Name="showSecondaryStatus", EmitDefaultValue=false)]
        public bool? ShowSecondaryStatus { get; set; }
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Displays the Agent name as provided by the user
        /// </summary>
        /// <value>Displays the Agent name as provided by the user</value>
        [DataMember(Name="agentName", EmitDefaultValue=false)]
        public string AgentName { get; set; }
        
        
        
        /// <summary>
        /// The list of skill strings as free form text
        /// </summary>
        /// <value>The list of skill strings as free form text</value>
        [DataMember(Name="skillsList", EmitDefaultValue=false)]
        public List<string> SkillsList { get; set; }
        
        
        
        /// <summary>
        /// The list of language strings as free form text
        /// </summary>
        /// <value>The list of language strings as free form text</value>
        [DataMember(Name="languageList", EmitDefaultValue=false)]
        public List<string> LanguageList { get; set; }
        
        
        
        /// <summary>
        /// The desired range for mos values
        /// </summary>
        /// <value>The desired range for mos values</value>
        [DataMember(Name="mos", EmitDefaultValue=false)]
        public NumericRange Mos { get; set; }
        
        
        
        /// <summary>
        /// The survey question group score used to filter the view
        /// </summary>
        /// <value>The survey question group score used to filter the view</value>
        [DataMember(Name="surveyQuestionGroupScore", EmitDefaultValue=false)]
        public NumericRange SurveyQuestionGroupScore { get; set; }
        
        
        
        /// <summary>
        /// The survey promoter score used to filter the view
        /// </summary>
        /// <value>The survey promoter score used to filter the view</value>
        [DataMember(Name="surveyPromoterScore", EmitDefaultValue=false)]
        public NumericRange SurveyPromoterScore { get; set; }
        
        
        
        /// <summary>
        /// The list of survey form context ids used to filter the view
        /// </summary>
        /// <value>The list of survey form context ids used to filter the view</value>
        [DataMember(Name="surveyFormContextIds", EmitDefaultValue=false)]
        public List<string> SurveyFormContextIds { get; set; }
        
        
        
        /// <summary>
        /// The list of conversation ids used to filter the view
        /// </summary>
        /// <value>The list of conversation ids used to filter the view</value>
        [DataMember(Name="conversationIds", EmitDefaultValue=false)]
        public List<string> ConversationIds { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for ended
        /// </summary>
        /// <value>Indicates filtering for ended</value>
        [DataMember(Name="isEnded", EmitDefaultValue=false)]
        public bool? IsEnded { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for survey
        /// </summary>
        /// <value>Indicates filtering for survey</value>
        [DataMember(Name="isSurveyed", EmitDefaultValue=false)]
        public bool? IsSurveyed { get; set; }
        
        
        
        /// <summary>
        /// The list of survey score ranges used to filter the view
        /// </summary>
        /// <value>The list of survey score ranges used to filter the view</value>
        [DataMember(Name="surveyScores", EmitDefaultValue=false)]
        public List<NumericRange> SurveyScores { get; set; }
        
        
        
        /// <summary>
        /// The list of promoter score ranges used to filter the view
        /// </summary>
        /// <value>The list of promoter score ranges used to filter the view</value>
        [DataMember(Name="promoterScores", EmitDefaultValue=false)]
        public List<NumericRange> PromoterScores { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for campaign
        /// </summary>
        /// <value>Indicates filtering for campaign</value>
        [DataMember(Name="isCampaign", EmitDefaultValue=false)]
        public bool? IsCampaign { get; set; }
        
        
        
        /// <summary>
        /// The list of survey statuses used to filter the view
        /// </summary>
        /// <value>The list of survey statuses used to filter the view</value>
        [DataMember(Name="surveyStatuses", EmitDefaultValue=false)]
        public List<string> SurveyStatuses { get; set; }
        
        
        
        /// <summary>
        /// A grouping of conversation level filters
        /// </summary>
        /// <value>A grouping of conversation level filters</value>
        [DataMember(Name="conversationProperties", EmitDefaultValue=false)]
        public ConversationProperties ConversationProperties { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for blind transferred
        /// </summary>
        /// <value>Indicates filtering for blind transferred</value>
        [DataMember(Name="isBlindTransferred", EmitDefaultValue=false)]
        public bool? IsBlindTransferred { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for consulted
        /// </summary>
        /// <value>Indicates filtering for consulted</value>
        [DataMember(Name="isConsulted", EmitDefaultValue=false)]
        public bool? IsConsulted { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for consult transferred
        /// </summary>
        /// <value>Indicates filtering for consult transferred</value>
        [DataMember(Name="isConsultTransferred", EmitDefaultValue=false)]
        public bool? IsConsultTransferred { get; set; }
        
        
        
        /// <summary>
        /// The list of remote participants used to filter the view
        /// </summary>
        /// <value>The list of remote participants used to filter the view</value>
        [DataMember(Name="remoteParticipants", EmitDefaultValue=false)]
        public List<string> RemoteParticipants { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewFilter {\n");
            
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
            sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  SkillGroups: ").Append(SkillGroups).Append("\n");
            sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
            sb.Append("  LanguageGroups: ").Append(LanguageGroups).Append("\n");
            sb.Append("  Directions: ").Append(Directions).Append("\n");
            sb.Append("  WrapUpCodes: ").Append(WrapUpCodes).Append("\n");
            sb.Append("  DnisList: ").Append(DnisList).Append("\n");
            sb.Append("  FilterQueuesByUserIds: ").Append(FilterQueuesByUserIds).Append("\n");
            sb.Append("  FilterUsersByQueueIds: ").Append(FilterUsersByQueueIds).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  AddressTos: ").Append(AddressTos).Append("\n");
            sb.Append("  AddressFroms: ").Append(AddressFroms).Append("\n");
            sb.Append("  OutboundCampaignIds: ").Append(OutboundCampaignIds).Append("\n");
            sb.Append("  OutboundContactListIds: ").Append(OutboundContactListIds).Append("\n");
            sb.Append("  ContactIds: ").Append(ContactIds).Append("\n");
            sb.Append("  AniList: ").Append(AniList).Append("\n");
            sb.Append("  DurationsMilliseconds: ").Append(DurationsMilliseconds).Append("\n");
            sb.Append("  EvaluationScore: ").Append(EvaluationScore).Append("\n");
            sb.Append("  EvaluationCriticalScore: ").Append(EvaluationCriticalScore).Append("\n");
            sb.Append("  EvaluationFormIds: ").Append(EvaluationFormIds).Append("\n");
            sb.Append("  EvaluatedAgentIds: ").Append(EvaluatedAgentIds).Append("\n");
            sb.Append("  EvaluatorIds: ").Append(EvaluatorIds).Append("\n");
            sb.Append("  Transferred: ").Append(Transferred).Append("\n");
            sb.Append("  Abandoned: ").Append(Abandoned).Append("\n");
            sb.Append("  MessageTypes: ").Append(MessageTypes).Append("\n");
            sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
            sb.Append("  SurveyFormIds: ").Append(SurveyFormIds).Append("\n");
            sb.Append("  SurveyTotalScore: ").Append(SurveyTotalScore).Append("\n");
            sb.Append("  SurveyNpsScore: ").Append(SurveyNpsScore).Append("\n");
            sb.Append("  ShowSecondaryStatus: ").Append(ShowSecondaryStatus).Append("\n");
            sb.Append("  AgentDurationSortOrder: ").Append(AgentDurationSortOrder).Append("\n");
            sb.Append("  WaitingDurationSortOrder: ").Append(WaitingDurationSortOrder).Append("\n");
            sb.Append("  InteractingDurationSortOrder: ").Append(InteractingDurationSortOrder).Append("\n");
            sb.Append("  AgentName: ").Append(AgentName).Append("\n");
            sb.Append("  SkillsList: ").Append(SkillsList).Append("\n");
            sb.Append("  LanguageList: ").Append(LanguageList).Append("\n");
            sb.Append("  Mos: ").Append(Mos).Append("\n");
            sb.Append("  SurveyQuestionGroupScore: ").Append(SurveyQuestionGroupScore).Append("\n");
            sb.Append("  SurveyPromoterScore: ").Append(SurveyPromoterScore).Append("\n");
            sb.Append("  SurveyFormContextIds: ").Append(SurveyFormContextIds).Append("\n");
            sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
            sb.Append("  IsEnded: ").Append(IsEnded).Append("\n");
            sb.Append("  IsSurveyed: ").Append(IsSurveyed).Append("\n");
            sb.Append("  SurveyScores: ").Append(SurveyScores).Append("\n");
            sb.Append("  PromoterScores: ").Append(PromoterScores).Append("\n");
            sb.Append("  IsCampaign: ").Append(IsCampaign).Append("\n");
            sb.Append("  SurveyStatuses: ").Append(SurveyStatuses).Append("\n");
            sb.Append("  ConversationProperties: ").Append(ConversationProperties).Append("\n");
            sb.Append("  IsBlindTransferred: ").Append(IsBlindTransferred).Append("\n");
            sb.Append("  IsConsulted: ").Append(IsConsulted).Append("\n");
            sb.Append("  IsConsultTransferred: ").Append(IsConsultTransferred).Append("\n");
            sb.Append("  RemoteParticipants: ").Append(RemoteParticipants).Append("\n");
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
            return this.Equals(obj as ViewFilter);
        }

        /// <summary>
        /// Returns true if ViewFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ViewFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) &&
                (
                    this.QueueIds == other.QueueIds ||
                    this.QueueIds != null &&
                    this.QueueIds.SequenceEqual(other.QueueIds)
                ) &&
                (
                    this.SkillIds == other.SkillIds ||
                    this.SkillIds != null &&
                    this.SkillIds.SequenceEqual(other.SkillIds)
                ) &&
                (
                    this.SkillGroups == other.SkillGroups ||
                    this.SkillGroups != null &&
                    this.SkillGroups.SequenceEqual(other.SkillGroups)
                ) &&
                (
                    this.LanguageIds == other.LanguageIds ||
                    this.LanguageIds != null &&
                    this.LanguageIds.SequenceEqual(other.LanguageIds)
                ) &&
                (
                    this.LanguageGroups == other.LanguageGroups ||
                    this.LanguageGroups != null &&
                    this.LanguageGroups.SequenceEqual(other.LanguageGroups)
                ) &&
                (
                    this.Directions == other.Directions ||
                    this.Directions != null &&
                    this.Directions.SequenceEqual(other.Directions)
                ) &&
                (
                    this.WrapUpCodes == other.WrapUpCodes ||
                    this.WrapUpCodes != null &&
                    this.WrapUpCodes.SequenceEqual(other.WrapUpCodes)
                ) &&
                (
                    this.DnisList == other.DnisList ||
                    this.DnisList != null &&
                    this.DnisList.SequenceEqual(other.DnisList)
                ) &&
                (
                    this.FilterQueuesByUserIds == other.FilterQueuesByUserIds ||
                    this.FilterQueuesByUserIds != null &&
                    this.FilterQueuesByUserIds.SequenceEqual(other.FilterQueuesByUserIds)
                ) &&
                (
                    this.FilterUsersByQueueIds == other.FilterUsersByQueueIds ||
                    this.FilterUsersByQueueIds != null &&
                    this.FilterUsersByQueueIds.SequenceEqual(other.FilterUsersByQueueIds)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.AddressTos == other.AddressTos ||
                    this.AddressTos != null &&
                    this.AddressTos.SequenceEqual(other.AddressTos)
                ) &&
                (
                    this.AddressFroms == other.AddressFroms ||
                    this.AddressFroms != null &&
                    this.AddressFroms.SequenceEqual(other.AddressFroms)
                ) &&
                (
                    this.OutboundCampaignIds == other.OutboundCampaignIds ||
                    this.OutboundCampaignIds != null &&
                    this.OutboundCampaignIds.SequenceEqual(other.OutboundCampaignIds)
                ) &&
                (
                    this.OutboundContactListIds == other.OutboundContactListIds ||
                    this.OutboundContactListIds != null &&
                    this.OutboundContactListIds.SequenceEqual(other.OutboundContactListIds)
                ) &&
                (
                    this.ContactIds == other.ContactIds ||
                    this.ContactIds != null &&
                    this.ContactIds.SequenceEqual(other.ContactIds)
                ) &&
                (
                    this.AniList == other.AniList ||
                    this.AniList != null &&
                    this.AniList.SequenceEqual(other.AniList)
                ) &&
                (
                    this.DurationsMilliseconds == other.DurationsMilliseconds ||
                    this.DurationsMilliseconds != null &&
                    this.DurationsMilliseconds.SequenceEqual(other.DurationsMilliseconds)
                ) &&
                (
                    this.EvaluationScore == other.EvaluationScore ||
                    this.EvaluationScore != null &&
                    this.EvaluationScore.Equals(other.EvaluationScore)
                ) &&
                (
                    this.EvaluationCriticalScore == other.EvaluationCriticalScore ||
                    this.EvaluationCriticalScore != null &&
                    this.EvaluationCriticalScore.Equals(other.EvaluationCriticalScore)
                ) &&
                (
                    this.EvaluationFormIds == other.EvaluationFormIds ||
                    this.EvaluationFormIds != null &&
                    this.EvaluationFormIds.SequenceEqual(other.EvaluationFormIds)
                ) &&
                (
                    this.EvaluatedAgentIds == other.EvaluatedAgentIds ||
                    this.EvaluatedAgentIds != null &&
                    this.EvaluatedAgentIds.SequenceEqual(other.EvaluatedAgentIds)
                ) &&
                (
                    this.EvaluatorIds == other.EvaluatorIds ||
                    this.EvaluatorIds != null &&
                    this.EvaluatorIds.SequenceEqual(other.EvaluatorIds)
                ) &&
                (
                    this.Transferred == other.Transferred ||
                    this.Transferred != null &&
                    this.Transferred.Equals(other.Transferred)
                ) &&
                (
                    this.Abandoned == other.Abandoned ||
                    this.Abandoned != null &&
                    this.Abandoned.Equals(other.Abandoned)
                ) &&
                (
                    this.MessageTypes == other.MessageTypes ||
                    this.MessageTypes != null &&
                    this.MessageTypes.SequenceEqual(other.MessageTypes)
                ) &&
                (
                    this.DivisionIds == other.DivisionIds ||
                    this.DivisionIds != null &&
                    this.DivisionIds.SequenceEqual(other.DivisionIds)
                ) &&
                (
                    this.SurveyFormIds == other.SurveyFormIds ||
                    this.SurveyFormIds != null &&
                    this.SurveyFormIds.SequenceEqual(other.SurveyFormIds)
                ) &&
                (
                    this.SurveyTotalScore == other.SurveyTotalScore ||
                    this.SurveyTotalScore != null &&
                    this.SurveyTotalScore.Equals(other.SurveyTotalScore)
                ) &&
                (
                    this.SurveyNpsScore == other.SurveyNpsScore ||
                    this.SurveyNpsScore != null &&
                    this.SurveyNpsScore.Equals(other.SurveyNpsScore)
                ) &&
                (
                    this.ShowSecondaryStatus == other.ShowSecondaryStatus ||
                    this.ShowSecondaryStatus != null &&
                    this.ShowSecondaryStatus.Equals(other.ShowSecondaryStatus)
                ) &&
                (
                    this.AgentDurationSortOrder == other.AgentDurationSortOrder ||
                    this.AgentDurationSortOrder != null &&
                    this.AgentDurationSortOrder.Equals(other.AgentDurationSortOrder)
                ) &&
                (
                    this.WaitingDurationSortOrder == other.WaitingDurationSortOrder ||
                    this.WaitingDurationSortOrder != null &&
                    this.WaitingDurationSortOrder.Equals(other.WaitingDurationSortOrder)
                ) &&
                (
                    this.InteractingDurationSortOrder == other.InteractingDurationSortOrder ||
                    this.InteractingDurationSortOrder != null &&
                    this.InteractingDurationSortOrder.Equals(other.InteractingDurationSortOrder)
                ) &&
                (
                    this.AgentName == other.AgentName ||
                    this.AgentName != null &&
                    this.AgentName.Equals(other.AgentName)
                ) &&
                (
                    this.SkillsList == other.SkillsList ||
                    this.SkillsList != null &&
                    this.SkillsList.SequenceEqual(other.SkillsList)
                ) &&
                (
                    this.LanguageList == other.LanguageList ||
                    this.LanguageList != null &&
                    this.LanguageList.SequenceEqual(other.LanguageList)
                ) &&
                (
                    this.Mos == other.Mos ||
                    this.Mos != null &&
                    this.Mos.Equals(other.Mos)
                ) &&
                (
                    this.SurveyQuestionGroupScore == other.SurveyQuestionGroupScore ||
                    this.SurveyQuestionGroupScore != null &&
                    this.SurveyQuestionGroupScore.Equals(other.SurveyQuestionGroupScore)
                ) &&
                (
                    this.SurveyPromoterScore == other.SurveyPromoterScore ||
                    this.SurveyPromoterScore != null &&
                    this.SurveyPromoterScore.Equals(other.SurveyPromoterScore)
                ) &&
                (
                    this.SurveyFormContextIds == other.SurveyFormContextIds ||
                    this.SurveyFormContextIds != null &&
                    this.SurveyFormContextIds.SequenceEqual(other.SurveyFormContextIds)
                ) &&
                (
                    this.ConversationIds == other.ConversationIds ||
                    this.ConversationIds != null &&
                    this.ConversationIds.SequenceEqual(other.ConversationIds)
                ) &&
                (
                    this.IsEnded == other.IsEnded ||
                    this.IsEnded != null &&
                    this.IsEnded.Equals(other.IsEnded)
                ) &&
                (
                    this.IsSurveyed == other.IsSurveyed ||
                    this.IsSurveyed != null &&
                    this.IsSurveyed.Equals(other.IsSurveyed)
                ) &&
                (
                    this.SurveyScores == other.SurveyScores ||
                    this.SurveyScores != null &&
                    this.SurveyScores.SequenceEqual(other.SurveyScores)
                ) &&
                (
                    this.PromoterScores == other.PromoterScores ||
                    this.PromoterScores != null &&
                    this.PromoterScores.SequenceEqual(other.PromoterScores)
                ) &&
                (
                    this.IsCampaign == other.IsCampaign ||
                    this.IsCampaign != null &&
                    this.IsCampaign.Equals(other.IsCampaign)
                ) &&
                (
                    this.SurveyStatuses == other.SurveyStatuses ||
                    this.SurveyStatuses != null &&
                    this.SurveyStatuses.SequenceEqual(other.SurveyStatuses)
                ) &&
                (
                    this.ConversationProperties == other.ConversationProperties ||
                    this.ConversationProperties != null &&
                    this.ConversationProperties.Equals(other.ConversationProperties)
                ) &&
                (
                    this.IsBlindTransferred == other.IsBlindTransferred ||
                    this.IsBlindTransferred != null &&
                    this.IsBlindTransferred.Equals(other.IsBlindTransferred)
                ) &&
                (
                    this.IsConsulted == other.IsConsulted ||
                    this.IsConsulted != null &&
                    this.IsConsulted.Equals(other.IsConsulted)
                ) &&
                (
                    this.IsConsultTransferred == other.IsConsultTransferred ||
                    this.IsConsultTransferred != null &&
                    this.IsConsultTransferred.Equals(other.IsConsultTransferred)
                ) &&
                (
                    this.RemoteParticipants == other.RemoteParticipants ||
                    this.RemoteParticipants != null &&
                    this.RemoteParticipants.SequenceEqual(other.RemoteParticipants)
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
                
                if (this.MediaTypes != null)
                    hash = hash * 59 + this.MediaTypes.GetHashCode();
                
                if (this.QueueIds != null)
                    hash = hash * 59 + this.QueueIds.GetHashCode();
                
                if (this.SkillIds != null)
                    hash = hash * 59 + this.SkillIds.GetHashCode();
                
                if (this.SkillGroups != null)
                    hash = hash * 59 + this.SkillGroups.GetHashCode();
                
                if (this.LanguageIds != null)
                    hash = hash * 59 + this.LanguageIds.GetHashCode();
                
                if (this.LanguageGroups != null)
                    hash = hash * 59 + this.LanguageGroups.GetHashCode();
                
                if (this.Directions != null)
                    hash = hash * 59 + this.Directions.GetHashCode();
                
                if (this.WrapUpCodes != null)
                    hash = hash * 59 + this.WrapUpCodes.GetHashCode();
                
                if (this.DnisList != null)
                    hash = hash * 59 + this.DnisList.GetHashCode();
                
                if (this.FilterQueuesByUserIds != null)
                    hash = hash * 59 + this.FilterQueuesByUserIds.GetHashCode();
                
                if (this.FilterUsersByQueueIds != null)
                    hash = hash * 59 + this.FilterUsersByQueueIds.GetHashCode();
                
                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();
                
                if (this.AddressTos != null)
                    hash = hash * 59 + this.AddressTos.GetHashCode();
                
                if (this.AddressFroms != null)
                    hash = hash * 59 + this.AddressFroms.GetHashCode();
                
                if (this.OutboundCampaignIds != null)
                    hash = hash * 59 + this.OutboundCampaignIds.GetHashCode();
                
                if (this.OutboundContactListIds != null)
                    hash = hash * 59 + this.OutboundContactListIds.GetHashCode();
                
                if (this.ContactIds != null)
                    hash = hash * 59 + this.ContactIds.GetHashCode();
                
                if (this.AniList != null)
                    hash = hash * 59 + this.AniList.GetHashCode();
                
                if (this.DurationsMilliseconds != null)
                    hash = hash * 59 + this.DurationsMilliseconds.GetHashCode();
                
                if (this.EvaluationScore != null)
                    hash = hash * 59 + this.EvaluationScore.GetHashCode();
                
                if (this.EvaluationCriticalScore != null)
                    hash = hash * 59 + this.EvaluationCriticalScore.GetHashCode();
                
                if (this.EvaluationFormIds != null)
                    hash = hash * 59 + this.EvaluationFormIds.GetHashCode();
                
                if (this.EvaluatedAgentIds != null)
                    hash = hash * 59 + this.EvaluatedAgentIds.GetHashCode();
                
                if (this.EvaluatorIds != null)
                    hash = hash * 59 + this.EvaluatorIds.GetHashCode();
                
                if (this.Transferred != null)
                    hash = hash * 59 + this.Transferred.GetHashCode();
                
                if (this.Abandoned != null)
                    hash = hash * 59 + this.Abandoned.GetHashCode();
                
                if (this.MessageTypes != null)
                    hash = hash * 59 + this.MessageTypes.GetHashCode();
                
                if (this.DivisionIds != null)
                    hash = hash * 59 + this.DivisionIds.GetHashCode();
                
                if (this.SurveyFormIds != null)
                    hash = hash * 59 + this.SurveyFormIds.GetHashCode();
                
                if (this.SurveyTotalScore != null)
                    hash = hash * 59 + this.SurveyTotalScore.GetHashCode();
                
                if (this.SurveyNpsScore != null)
                    hash = hash * 59 + this.SurveyNpsScore.GetHashCode();
                
                if (this.ShowSecondaryStatus != null)
                    hash = hash * 59 + this.ShowSecondaryStatus.GetHashCode();
                
                if (this.AgentDurationSortOrder != null)
                    hash = hash * 59 + this.AgentDurationSortOrder.GetHashCode();
                
                if (this.WaitingDurationSortOrder != null)
                    hash = hash * 59 + this.WaitingDurationSortOrder.GetHashCode();
                
                if (this.InteractingDurationSortOrder != null)
                    hash = hash * 59 + this.InteractingDurationSortOrder.GetHashCode();
                
                if (this.AgentName != null)
                    hash = hash * 59 + this.AgentName.GetHashCode();
                
                if (this.SkillsList != null)
                    hash = hash * 59 + this.SkillsList.GetHashCode();
                
                if (this.LanguageList != null)
                    hash = hash * 59 + this.LanguageList.GetHashCode();
                
                if (this.Mos != null)
                    hash = hash * 59 + this.Mos.GetHashCode();
                
                if (this.SurveyQuestionGroupScore != null)
                    hash = hash * 59 + this.SurveyQuestionGroupScore.GetHashCode();
                
                if (this.SurveyPromoterScore != null)
                    hash = hash * 59 + this.SurveyPromoterScore.GetHashCode();
                
                if (this.SurveyFormContextIds != null)
                    hash = hash * 59 + this.SurveyFormContextIds.GetHashCode();
                
                if (this.ConversationIds != null)
                    hash = hash * 59 + this.ConversationIds.GetHashCode();
                
                if (this.IsEnded != null)
                    hash = hash * 59 + this.IsEnded.GetHashCode();
                
                if (this.IsSurveyed != null)
                    hash = hash * 59 + this.IsSurveyed.GetHashCode();
                
                if (this.SurveyScores != null)
                    hash = hash * 59 + this.SurveyScores.GetHashCode();
                
                if (this.PromoterScores != null)
                    hash = hash * 59 + this.PromoterScores.GetHashCode();
                
                if (this.IsCampaign != null)
                    hash = hash * 59 + this.IsCampaign.GetHashCode();
                
                if (this.SurveyStatuses != null)
                    hash = hash * 59 + this.SurveyStatuses.GetHashCode();
                
                if (this.ConversationProperties != null)
                    hash = hash * 59 + this.ConversationProperties.GetHashCode();
                
                if (this.IsBlindTransferred != null)
                    hash = hash * 59 + this.IsBlindTransferred.GetHashCode();
                
                if (this.IsConsulted != null)
                    hash = hash * 59 + this.IsConsulted.GetHashCode();
                
                if (this.IsConsultTransferred != null)
                    hash = hash * 59 + this.IsConsultTransferred.GetHashCode();
                
                if (this.RemoteParticipants != null)
                    hash = hash * 59 + this.RemoteParticipants.GetHashCode();
                
                return hash;
            }
        }
    }

}
