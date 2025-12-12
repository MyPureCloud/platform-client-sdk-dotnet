using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Widget
	/// </summary>
	[DataContract]
	public partial class Widget : IEquatable<Widget>
	{
		/// <summary>
		/// The type of dashboard widget configuration.
		/// </summary>
		/// <value>The type of dashboard widget configuration.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Metric for "METRIC"
			/// </summary>
			[EnumMember(Value = "METRIC")]
			Metric,

			/// <summary>
			/// Enum Chart for "CHART"
			/// </summary>
			[EnumMember(Value = "CHART")]
			Chart,

			/// <summary>
			/// Enum Pie for "PIE"
			/// </summary>
			[EnumMember(Value = "PIE")]
			Pie,

			/// <summary>
			/// Enum HeatMap for "HEAT_MAP"
			/// </summary>
			[EnumMember(Value = "HEAT_MAP")]
			HeatMap,

			/// <summary>
			/// Enum FreeText for "FREE_TEXT"
			/// </summary>
			[EnumMember(Value = "FREE_TEXT")]
			FreeText,

			/// <summary>
			/// Enum AgentStatus for "AGENT_STATUS"
			/// </summary>
			[EnumMember(Value = "AGENT_STATUS")]
			AgentStatus,

			/// <summary>
			/// Enum RealtimeAdherence for "REALTIME_ADHERENCE"
			/// </summary>
			[EnumMember(Value = "REALTIME_ADHERENCE")]
			RealtimeAdherence,

			/// <summary>
			/// Enum WebContentUrl for "WEB_CONTENT_URL"
			/// </summary>
			[EnumMember(Value = "WEB_CONTENT_URL")]
			WebContentUrl,

			/// <summary>
			/// Enum AgentActivity for "AGENT_ACTIVITY"
			/// </summary>
			[EnumMember(Value = "AGENT_ACTIVITY")]
			AgentActivity
		}
		/// <summary>
		/// Gets or Sets Metrics
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum MetricsEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum AvgTalkTime for "AVG_TALK_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_TALK_TIME")]
			AvgTalkTime,

			/// <summary>
			/// Enum AvgHoldTime for "AVG_HOLD_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_HOLD_TIME")]
			AvgHoldTime,

			/// <summary>
			/// Enum AvgAcwTime for "AVG_ACW_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_ACW_TIME")]
			AvgAcwTime,

			/// <summary>
			/// Enum AvgWaitTime for "AVG_WAIT_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_WAIT_TIME")]
			AvgWaitTime,

			/// <summary>
			/// Enum AvgHandleTime for "AVG_HANDLE_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_HANDLE_TIME")]
			AvgHandleTime,

			/// <summary>
			/// Enum AvgAlertTime for "AVG_ALERT_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_ALERT_TIME")]
			AvgAlertTime,

			/// <summary>
			/// Enum AvgAnswerTime for "AVG_ANSWER_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_ANSWER_TIME")]
			AvgAnswerTime,

			/// <summary>
			/// Enum AvgAbandonTime for "AVG_ABANDON_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_ABANDON_TIME")]
			AvgAbandonTime,

			/// <summary>
			/// Enum TotalTalkTime for "TOTAL_TALK_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_TALK_TIME")]
			TotalTalkTime,

			/// <summary>
			/// Enum TotalHandleTime for "TOTAL_HANDLE_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_HANDLE_TIME")]
			TotalHandleTime,

			/// <summary>
			/// Enum TotalHoldTime for "TOTAL_HOLD_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_HOLD_TIME")]
			TotalHoldTime,

			/// <summary>
			/// Enum TotalAcwTime for "TOTAL_ACW_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_ACW_TIME")]
			TotalAcwTime,

			/// <summary>
			/// Enum TotalAlertTime for "TOTAL_ALERT_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_ALERT_TIME")]
			TotalAlertTime,

			/// <summary>
			/// Enum MaxAbandonTime for "MAX_ABANDON_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_ABANDON_TIME")]
			MaxAbandonTime,

			/// <summary>
			/// Enum MaxWaitTime for "MAX_WAIT_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_WAIT_TIME")]
			MaxWaitTime,

			/// <summary>
			/// Enum MaxTalkTime for "MAX_TALK_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_TALK_TIME")]
			MaxTalkTime,

			/// <summary>
			/// Enum MaxHoldTime for "MAX_HOLD_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_HOLD_TIME")]
			MaxHoldTime,

			/// <summary>
			/// Enum MaxAcwTime for "MAX_ACW_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_ACW_TIME")]
			MaxAcwTime,

			/// <summary>
			/// Enum MinAbandonTime for "MIN_ABANDON_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_ABANDON_TIME")]
			MinAbandonTime,

			/// <summary>
			/// Enum MinWaitTime for "MIN_WAIT_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_WAIT_TIME")]
			MinWaitTime,

			/// <summary>
			/// Enum MinTalkTime for "MIN_TALK_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_TALK_TIME")]
			MinTalkTime,

			/// <summary>
			/// Enum MinHoldTime for "MIN_HOLD_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_HOLD_TIME")]
			MinHoldTime,

			/// <summary>
			/// Enum MinAcwTime for "MIN_ACW_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_ACW_TIME")]
			MinAcwTime,

			/// <summary>
			/// Enum AlertCount for "ALERT_COUNT"
			/// </summary>
			[EnumMember(Value = "ALERT_COUNT")]
			AlertCount,

			/// <summary>
			/// Enum OfferedCount for "OFFERED_COUNT"
			/// </summary>
			[EnumMember(Value = "OFFERED_COUNT")]
			OfferedCount,

			/// <summary>
			/// Enum AbandonedCount for "ABANDONED_COUNT"
			/// </summary>
			[EnumMember(Value = "ABANDONED_COUNT")]
			AbandonedCount,

			/// <summary>
			/// Enum AbandonedPercent for "ABANDONED_PERCENT"
			/// </summary>
			[EnumMember(Value = "ABANDONED_PERCENT")]
			AbandonedPercent,

			/// <summary>
			/// Enum ShortAbandonedCount for "SHORT_ABANDONED_COUNT"
			/// </summary>
			[EnumMember(Value = "SHORT_ABANDONED_COUNT")]
			ShortAbandonedCount,

			/// <summary>
			/// Enum ShortAbandonedPercent for "SHORT_ABANDONED_PERCENT"
			/// </summary>
			[EnumMember(Value = "SHORT_ABANDONED_PERCENT")]
			ShortAbandonedPercent,

			/// <summary>
			/// Enum AbandonedNoShortCount for "ABANDONED_NO_SHORT_COUNT"
			/// </summary>
			[EnumMember(Value = "ABANDONED_NO_SHORT_COUNT")]
			AbandonedNoShortCount,

			/// <summary>
			/// Enum AbandonedNoShortPercent for "ABANDONED_NO_SHORT_PERCENT"
			/// </summary>
			[EnumMember(Value = "ABANDONED_NO_SHORT_PERCENT")]
			AbandonedNoShortPercent,

			/// <summary>
			/// Enum AnsweredCount for "ANSWERED_COUNT"
			/// </summary>
			[EnumMember(Value = "ANSWERED_COUNT")]
			AnsweredCount,

			/// <summary>
			/// Enum AnsweredPercent for "ANSWERED_PERCENT"
			/// </summary>
			[EnumMember(Value = "ANSWERED_PERCENT")]
			AnsweredPercent,

			/// <summary>
			/// Enum FlowoutCount for "FLOWOUT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOWOUT_COUNT")]
			FlowoutCount,

			/// <summary>
			/// Enum FlowoutPercent for "FLOWOUT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOWOUT_PERCENT")]
			FlowoutPercent,

			/// <summary>
			/// Enum OutboundCount for "OUTBOUND_COUNT"
			/// </summary>
			[EnumMember(Value = "OUTBOUND_COUNT")]
			OutboundCount,

			/// <summary>
			/// Enum OutboundAttemptedCount for "OUTBOUND_ATTEMPTED_COUNT"
			/// </summary>
			[EnumMember(Value = "OUTBOUND_ATTEMPTED_COUNT")]
			OutboundAttemptedCount,

			/// <summary>
			/// Enum VoicemailCount for "VOICEMAIL_COUNT"
			/// </summary>
			[EnumMember(Value = "VOICEMAIL_COUNT")]
			VoicemailCount,

			/// <summary>
			/// Enum HandledCount for "HANDLED_COUNT"
			/// </summary>
			[EnumMember(Value = "HANDLED_COUNT")]
			HandledCount,

			/// <summary>
			/// Enum HeldCount for "HELD_COUNT"
			/// </summary>
			[EnumMember(Value = "HELD_COUNT")]
			HeldCount,

			/// <summary>
			/// Enum TransferredCount for "TRANSFERRED_COUNT"
			/// </summary>
			[EnumMember(Value = "TRANSFERRED_COUNT")]
			TransferredCount,

			/// <summary>
			/// Enum TransferredPercent for "TRANSFERRED_PERCENT"
			/// </summary>
			[EnumMember(Value = "TRANSFERRED_PERCENT")]
			TransferredPercent,

			/// <summary>
			/// Enum WaitingCurrent for "WAITING_CURRENT"
			/// </summary>
			[EnumMember(Value = "WAITING_CURRENT")]
			WaitingCurrent,

			/// <summary>
			/// Enum InteractingCurrent for "INTERACTING_CURRENT"
			/// </summary>
			[EnumMember(Value = "INTERACTING_CURRENT")]
			InteractingCurrent,

			/// <summary>
			/// Enum HeldCurrent for "HELD_CURRENT"
			/// </summary>
			[EnumMember(Value = "HELD_CURRENT")]
			HeldCurrent,

			/// <summary>
			/// Enum AlertingCurrent for "ALERTING_CURRENT"
			/// </summary>
			[EnumMember(Value = "ALERTING_CURRENT")]
			AlertingCurrent,

			/// <summary>
			/// Enum ServiceLevel for "SERVICE_LEVEL"
			/// </summary>
			[EnumMember(Value = "SERVICE_LEVEL")]
			ServiceLevel,

			/// <summary>
			/// Enum OverServiceLevel for "OVER_SERVICE_LEVEL"
			/// </summary>
			[EnumMember(Value = "OVER_SERVICE_LEVEL")]
			OverServiceLevel,

			/// <summary>
			/// Enum OnlineAgents for "ONLINE_AGENTS"
			/// </summary>
			[EnumMember(Value = "ONLINE_AGENTS")]
			OnlineAgents,

			/// <summary>
			/// Enum AvailableAgents for "AVAILABLE_AGENTS"
			/// </summary>
			[EnumMember(Value = "AVAILABLE_AGENTS")]
			AvailableAgents,

			/// <summary>
			/// Enum AwayAgents for "AWAY_AGENTS"
			/// </summary>
			[EnumMember(Value = "AWAY_AGENTS")]
			AwayAgents,

			/// <summary>
			/// Enum BreakAgents for "BREAK_AGENTS"
			/// </summary>
			[EnumMember(Value = "BREAK_AGENTS")]
			BreakAgents,

			/// <summary>
			/// Enum MealAgents for "MEAL_AGENTS"
			/// </summary>
			[EnumMember(Value = "MEAL_AGENTS")]
			MealAgents,

			/// <summary>
			/// Enum TrainingAgents for "TRAINING_AGENTS"
			/// </summary>
			[EnumMember(Value = "TRAINING_AGENTS")]
			TrainingAgents,

			/// <summary>
			/// Enum BusyAgents for "BUSY_AGENTS"
			/// </summary>
			[EnumMember(Value = "BUSY_AGENTS")]
			BusyAgents,

			/// <summary>
			/// Enum MeetingAgents for "MEETING_AGENTS"
			/// </summary>
			[EnumMember(Value = "MEETING_AGENTS")]
			MeetingAgents,

			/// <summary>
			/// Enum SystemAwayAgents for "SYSTEM_AWAY_AGENTS"
			/// </summary>
			[EnumMember(Value = "SYSTEM_AWAY_AGENTS")]
			SystemAwayAgents,

			/// <summary>
			/// Enum OfflineAgents for "OFFLINE_AGENTS"
			/// </summary>
			[EnumMember(Value = "OFFLINE_AGENTS")]
			OfflineAgents,

			/// <summary>
			/// Enum OnQueueAgents for "ON_QUEUE_AGENTS"
			/// </summary>
			[EnumMember(Value = "ON_QUEUE_AGENTS")]
			OnQueueAgents,

			/// <summary>
			/// Enum OffQueueAgents for "OFF_QUEUE_AGENTS"
			/// </summary>
			[EnumMember(Value = "OFF_QUEUE_AGENTS")]
			OffQueueAgents,

			/// <summary>
			/// Enum InteractingAgents for "INTERACTING_AGENTS"
			/// </summary>
			[EnumMember(Value = "INTERACTING_AGENTS")]
			InteractingAgents,

			/// <summary>
			/// Enum AcwAgents for "ACW_AGENTS"
			/// </summary>
			[EnumMember(Value = "ACW_AGENTS")]
			AcwAgents,

			/// <summary>
			/// Enum CommunicatingAgents for "COMMUNICATING_AGENTS"
			/// </summary>
			[EnumMember(Value = "COMMUNICATING_AGENTS")]
			CommunicatingAgents,

			/// <summary>
			/// Enum IdleAgents for "IDLE_AGENTS"
			/// </summary>
			[EnumMember(Value = "IDLE_AGENTS")]
			IdleAgents,

			/// <summary>
			/// Enum NotRespondingAgents for "NOT_RESPONDING_AGENTS"
			/// </summary>
			[EnumMember(Value = "NOT_RESPONDING_AGENTS")]
			NotRespondingAgents,

			/// <summary>
			/// Enum LongestWaiting for "LONGEST_WAITING"
			/// </summary>
			[EnumMember(Value = "LONGEST_WAITING")]
			LongestWaiting,

			/// <summary>
			/// Enum LongestInteracting for "LONGEST_INTERACTING"
			/// </summary>
			[EnumMember(Value = "LONGEST_INTERACTING")]
			LongestInteracting,

			/// <summary>
			/// Enum FlowActiveLongest for "FLOW_ACTIVE_LONGEST"
			/// </summary>
			[EnumMember(Value = "FLOW_ACTIVE_LONGEST")]
			FlowActiveLongest,

			/// <summary>
			/// Enum FlowActiveCurrent for "FLOW_ACTIVE_CURRENT"
			/// </summary>
			[EnumMember(Value = "FLOW_ACTIVE_CURRENT")]
			FlowActiveCurrent,

			/// <summary>
			/// Enum FlowEntriesCount for "FLOW_ENTRIES_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_ENTRIES_COUNT")]
			FlowEntriesCount,

			/// <summary>
			/// Enum FlowTotalDuration for "FLOW_TOTAL_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_TOTAL_DURATION")]
			FlowTotalDuration,

			/// <summary>
			/// Enum FlowMaxDuration for "FLOW_MAX_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_MAX_DURATION")]
			FlowMaxDuration,

			/// <summary>
			/// Enum FlowAvgDuration for "FLOW_AVG_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_AVG_DURATION")]
			FlowAvgDuration,

			/// <summary>
			/// Enum FlowDisconnectCount for "FLOW_DISCONNECT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_DISCONNECT_COUNT")]
			FlowDisconnectCount,

			/// <summary>
			/// Enum FlowDisconnectPercent for "FLOW_DISCONNECT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_DISCONNECT_PERCENT")]
			FlowDisconnectPercent,

			/// <summary>
			/// Enum FlowTotalDisconnectDuration for "FLOW_TOTAL_DISCONNECT_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_TOTAL_DISCONNECT_DURATION")]
			FlowTotalDisconnectDuration,

			/// <summary>
			/// Enum FlowAvgDisconnectDuration for "FLOW_AVG_DISCONNECT_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_AVG_DISCONNECT_DURATION")]
			FlowAvgDisconnectDuration,

			/// <summary>
			/// Enum FlowMaxDisconnectDuration for "FLOW_MAX_DISCONNECT_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_MAX_DISCONNECT_DURATION")]
			FlowMaxDisconnectDuration,

			/// <summary>
			/// Enum FlowFlowDisconnect for "FLOW_FLOW_DISCONNECT"
			/// </summary>
			[EnumMember(Value = "FLOW_FLOW_DISCONNECT")]
			FlowFlowDisconnect,

			/// <summary>
			/// Enum FlowFlowDisconnectPercent for "FLOW_FLOW_DISCONNECT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_FLOW_DISCONNECT_PERCENT")]
			FlowFlowDisconnectPercent,

			/// <summary>
			/// Enum FlowSystemErrorDisconnect for "FLOW_SYSTEM_ERROR_DISCONNECT"
			/// </summary>
			[EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT")]
			FlowSystemErrorDisconnect,

			/// <summary>
			/// Enum FlowSystemErrorDisconnectPercent for "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT")]
			FlowSystemErrorDisconnectPercent,

			/// <summary>
			/// Enum FlowCustomerDisconnect for "FLOW_CUSTOMER_DISCONNECT"
			/// </summary>
			[EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT")]
			FlowCustomerDisconnect,

			/// <summary>
			/// Enum FlowCustomerDisconnectPercent for "FLOW_CUSTOMER_DISCONNECT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT_PERCENT")]
			FlowCustomerDisconnectPercent,

			/// <summary>
			/// Enum FlowShortDisconnect for "FLOW_SHORT_DISCONNECT"
			/// </summary>
			[EnumMember(Value = "FLOW_SHORT_DISCONNECT")]
			FlowShortDisconnect,

			/// <summary>
			/// Enum FlowShortDisconnectPercent for "FLOW_SHORT_DISCONNECT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_SHORT_DISCONNECT_PERCENT")]
			FlowShortDisconnectPercent,

			/// <summary>
			/// Enum FlowExitCount for "FLOW_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_EXIT_COUNT")]
			FlowExitCount,

			/// <summary>
			/// Enum FlowExitPercent for "FLOW_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_EXIT_PERCENT")]
			FlowExitPercent,

			/// <summary>
			/// Enum FlowTotalExitDuration for "FLOW_TOTAL_EXIT_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_TOTAL_EXIT_DURATION")]
			FlowTotalExitDuration,

			/// <summary>
			/// Enum FlowMaxExitDuration for "FLOW_MAX_EXIT_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_MAX_EXIT_DURATION")]
			FlowMaxExitDuration,

			/// <summary>
			/// Enum FlowAvgExitDuration for "FLOW_AVG_EXIT_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_AVG_EXIT_DURATION")]
			FlowAvgExitDuration,

			/// <summary>
			/// Enum FlowAcdExitCount for "FLOW_ACD_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_ACD_EXIT_COUNT")]
			FlowAcdExitCount,

			/// <summary>
			/// Enum FlowAcdExitPercent for "FLOW_ACD_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_ACD_EXIT_PERCENT")]
			FlowAcdExitPercent,

			/// <summary>
			/// Enum FlowGroupExitCount for "FLOW_GROUP_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_GROUP_EXIT_COUNT")]
			FlowGroupExitCount,

			/// <summary>
			/// Enum FlowGroupExitPercent for "FLOW_GROUP_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_GROUP_EXIT_PERCENT")]
			FlowGroupExitPercent,

			/// <summary>
			/// Enum FlowNumberExitCount for "FLOW_NUMBER_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_NUMBER_EXIT_COUNT")]
			FlowNumberExitCount,

			/// <summary>
			/// Enum FlowNumberExitPercent for "FLOW_NUMBER_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_NUMBER_EXIT_PERCENT")]
			FlowNumberExitPercent,

			/// <summary>
			/// Enum FlowUserExitCount for "FLOW_USER_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_USER_EXIT_COUNT")]
			FlowUserExitCount,

			/// <summary>
			/// Enum FlowUserExitPercent for "FLOW_USER_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_USER_EXIT_PERCENT")]
			FlowUserExitPercent,

			/// <summary>
			/// Enum FlowFlowExitCount for "FLOW_FLOW_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_FLOW_EXIT_COUNT")]
			FlowFlowExitCount,

			/// <summary>
			/// Enum FlowFlowExitPercent for "FLOW_FLOW_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_FLOW_EXIT_PERCENT")]
			FlowFlowExitPercent,

			/// <summary>
			/// Enum FlowSecureFlowExitCount for "FLOW_SECURE_FLOW_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_COUNT")]
			FlowSecureFlowExitCount,

			/// <summary>
			/// Enum FlowSecureFlowExitPercent for "FLOW_SECURE_FLOW_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_PERCENT")]
			FlowSecureFlowExitPercent,

			/// <summary>
			/// Enum FlowAcdVoicemailExitCount for "FLOW_ACD_VOICEMAIL_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_COUNT")]
			FlowAcdVoicemailExitCount,

			/// <summary>
			/// Enum FlowAcdVoicemailExitPercent for "FLOW_ACD_VOICEMAIL_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_PERCENT")]
			FlowAcdVoicemailExitPercent,

			/// <summary>
			/// Enum FlowUserVoicemailExitCount for "FLOW_USER_VOICEMAIL_EXIT_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_COUNT")]
			FlowUserVoicemailExitCount,

			/// <summary>
			/// Enum FlowUserVoicemailExitPercent for "FLOW_USER_VOICEMAIL_EXIT_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_PERCENT")]
			FlowUserVoicemailExitPercent,

			/// <summary>
			/// Enum FlowOutcomeCount for "FLOW_OUTCOME_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_COUNT")]
			FlowOutcomeCount,

			/// <summary>
			/// Enum FlowAvgOutcomeDecimal for "FLOW_AVG_OUTCOME_DECIMAL"
			/// </summary>
			[EnumMember(Value = "FLOW_AVG_OUTCOME_DECIMAL")]
			FlowAvgOutcomeDecimal,

			/// <summary>
			/// Enum FlowOutcomeFailureCount for "FLOW_OUTCOME_FAILURE_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_FAILURE_COUNT")]
			FlowOutcomeFailureCount,

			/// <summary>
			/// Enum FlowOutcomeFailurePercent for "FLOW_OUTCOME_FAILURE_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_FAILURE_PERCENT")]
			FlowOutcomeFailurePercent,

			/// <summary>
			/// Enum FlowOutcomeSuccessCount for "FLOW_OUTCOME_SUCCESS_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_SUCCESS_COUNT")]
			FlowOutcomeSuccessCount,

			/// <summary>
			/// Enum FlowOutcomeSuccessPercent for "FLOW_OUTCOME_SUCCESS_PERCENT"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_SUCCESS_PERCENT")]
			FlowOutcomeSuccessPercent,

			/// <summary>
			/// Enum FlowOutcomeTotalDuration for "FLOW_OUTCOME_TOTAL_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_TOTAL_DURATION")]
			FlowOutcomeTotalDuration,

			/// <summary>
			/// Enum FlowOutcomeMaxDuration for "FLOW_OUTCOME_MAX_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_MAX_DURATION")]
			FlowOutcomeMaxDuration,

			/// <summary>
			/// Enum FlowOutcomeAvgDuration for "FLOW_OUTCOME_AVG_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_AVG_DURATION")]
			FlowOutcomeAvgDuration,

			/// <summary>
			/// Enum FlowOutcomeMinDuration for "FLOW_OUTCOME_MIN_DURATION"
			/// </summary>
			[EnumMember(Value = "FLOW_OUTCOME_MIN_DURATION")]
			FlowOutcomeMinDuration,

			/// <summary>
			/// Enum OffQueueTime for "OFF_QUEUE_TIME"
			/// </summary>
			[EnumMember(Value = "OFF_QUEUE_TIME")]
			OffQueueTime,

			/// <summary>
			/// Enum OffQueuePercent for "OFF_QUEUE_PERCENT"
			/// </summary>
			[EnumMember(Value = "OFF_QUEUE_PERCENT")]
			OffQueuePercent,

			/// <summary>
			/// Enum AvailableTime for "AVAILABLE_TIME"
			/// </summary>
			[EnumMember(Value = "AVAILABLE_TIME")]
			AvailableTime,

			/// <summary>
			/// Enum AvailablePercent for "AVAILABLE_PERCENT"
			/// </summary>
			[EnumMember(Value = "AVAILABLE_PERCENT")]
			AvailablePercent,

			/// <summary>
			/// Enum BusyTime for "BUSY_TIME"
			/// </summary>
			[EnumMember(Value = "BUSY_TIME")]
			BusyTime,

			/// <summary>
			/// Enum BusyPercent for "BUSY_PERCENT"
			/// </summary>
			[EnumMember(Value = "BUSY_PERCENT")]
			BusyPercent,

			/// <summary>
			/// Enum AwayTime for "AWAY_TIME"
			/// </summary>
			[EnumMember(Value = "AWAY_TIME")]
			AwayTime,

			/// <summary>
			/// Enum AwayPercent for "AWAY_PERCENT"
			/// </summary>
			[EnumMember(Value = "AWAY_PERCENT")]
			AwayPercent,

			/// <summary>
			/// Enum BreakTime for "BREAK_TIME"
			/// </summary>
			[EnumMember(Value = "BREAK_TIME")]
			BreakTime,

			/// <summary>
			/// Enum BreakPercent for "BREAK_PERCENT"
			/// </summary>
			[EnumMember(Value = "BREAK_PERCENT")]
			BreakPercent,

			/// <summary>
			/// Enum MealTime for "MEAL_TIME"
			/// </summary>
			[EnumMember(Value = "MEAL_TIME")]
			MealTime,

			/// <summary>
			/// Enum MealPercent for "MEAL_PERCENT"
			/// </summary>
			[EnumMember(Value = "MEAL_PERCENT")]
			MealPercent,

			/// <summary>
			/// Enum MeetingTime for "MEETING_TIME"
			/// </summary>
			[EnumMember(Value = "MEETING_TIME")]
			MeetingTime,

			/// <summary>
			/// Enum MeetingPercent for "MEETING_PERCENT"
			/// </summary>
			[EnumMember(Value = "MEETING_PERCENT")]
			MeetingPercent,

			/// <summary>
			/// Enum TrainingTime for "TRAINING_TIME"
			/// </summary>
			[EnumMember(Value = "TRAINING_TIME")]
			TrainingTime,

			/// <summary>
			/// Enum TrainingPercent for "TRAINING_PERCENT"
			/// </summary>
			[EnumMember(Value = "TRAINING_PERCENT")]
			TrainingPercent,

			/// <summary>
			/// Enum InteractingTime for "INTERACTING_TIME"
			/// </summary>
			[EnumMember(Value = "INTERACTING_TIME")]
			InteractingTime,

			/// <summary>
			/// Enum InteractingPercent for "INTERACTING_PERCENT"
			/// </summary>
			[EnumMember(Value = "INTERACTING_PERCENT")]
			InteractingPercent,

			/// <summary>
			/// Enum CommunicatingTime for "COMMUNICATING_TIME"
			/// </summary>
			[EnumMember(Value = "COMMUNICATING_TIME")]
			CommunicatingTime,

			/// <summary>
			/// Enum CommunicatingPercent for "COMMUNICATING_PERCENT"
			/// </summary>
			[EnumMember(Value = "COMMUNICATING_PERCENT")]
			CommunicatingPercent,

			/// <summary>
			/// Enum SystemAwayTime for "SYSTEM_AWAY_TIME"
			/// </summary>
			[EnumMember(Value = "SYSTEM_AWAY_TIME")]
			SystemAwayTime,

			/// <summary>
			/// Enum SystemAwayPercent for "SYSTEM_AWAY_PERCENT"
			/// </summary>
			[EnumMember(Value = "SYSTEM_AWAY_PERCENT")]
			SystemAwayPercent,

			/// <summary>
			/// Enum OnQueueTime for "ON_QUEUE_TIME"
			/// </summary>
			[EnumMember(Value = "ON_QUEUE_TIME")]
			OnQueueTime,

			/// <summary>
			/// Enum OnQueuePercent for "ON_QUEUE_PERCENT"
			/// </summary>
			[EnumMember(Value = "ON_QUEUE_PERCENT")]
			OnQueuePercent,

			/// <summary>
			/// Enum IdleTime for "IDLE_TIME"
			/// </summary>
			[EnumMember(Value = "IDLE_TIME")]
			IdleTime,

			/// <summary>
			/// Enum IdlePercent for "IDLE_PERCENT"
			/// </summary>
			[EnumMember(Value = "IDLE_PERCENT")]
			IdlePercent,

			/// <summary>
			/// Enum NotRespondingTime for "NOT_RESPONDING_TIME"
			/// </summary>
			[EnumMember(Value = "NOT_RESPONDING_TIME")]
			NotRespondingTime,

			/// <summary>
			/// Enum NotRespondingPercent for "NOT_RESPONDING_PERCENT"
			/// </summary>
			[EnumMember(Value = "NOT_RESPONDING_PERCENT")]
			NotRespondingPercent,

			/// <summary>
			/// Enum LoggedInTime for "LOGGED_IN_TIME"
			/// </summary>
			[EnumMember(Value = "LOGGED_IN_TIME")]
			LoggedInTime,

			/// <summary>
			/// Enum OccupancyPercent for "OCCUPANCY_PERCENT"
			/// </summary>
			[EnumMember(Value = "OCCUPANCY_PERCENT")]
			OccupancyPercent,

			/// <summary>
			/// Enum MinAlertTime for "MIN_ALERT_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_ALERT_TIME")]
			MinAlertTime,

			/// <summary>
			/// Enum MaxAlertTime for "MAX_ALERT_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_ALERT_TIME")]
			MaxAlertTime,

			/// <summary>
			/// Enum MinHandleTime for "MIN_HANDLE_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_HANDLE_TIME")]
			MinHandleTime,

			/// <summary>
			/// Enum MaxHandleTime for "MAX_HANDLE_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_HANDLE_TIME")]
			MaxHandleTime,

			/// <summary>
			/// Enum MinAnsweredTime for "MIN_ANSWERED_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_ANSWERED_TIME")]
			MinAnsweredTime,

			/// <summary>
			/// Enum MaxAnsweredTime for "MAX_ANSWERED_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_ANSWERED_TIME")]
			MaxAnsweredTime,

			/// <summary>
			/// Enum MinNotRespondingTime for "MIN_NOT_RESPONDING_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_NOT_RESPONDING_TIME")]
			MinNotRespondingTime,

			/// <summary>
			/// Enum MaxNotRespondingTime for "MAX_NOT_RESPONDING_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_NOT_RESPONDING_TIME")]
			MaxNotRespondingTime,

			/// <summary>
			/// Enum MetServiceLevel for "MET_SERVICE_LEVEL"
			/// </summary>
			[EnumMember(Value = "MET_SERVICE_LEVEL")]
			MetServiceLevel,

			/// <summary>
			/// Enum WfmAdherenceStatus for "WFM_ADHERENCE_STATUS"
			/// </summary>
			[EnumMember(Value = "WFM_ADHERENCE_STATUS")]
			WfmAdherenceStatus,

			/// <summary>
			/// Enum WfmScheduledActivity for "WFM_SCHEDULED_ACTIVITY"
			/// </summary>
			[EnumMember(Value = "WFM_SCHEDULED_ACTIVITY")]
			WfmScheduledActivity,

			/// <summary>
			/// Enum WfmAdherenceDuration for "WFM_ADHERENCE_DURATION"
			/// </summary>
			[EnumMember(Value = "WFM_ADHERENCE_DURATION")]
			WfmAdherenceDuration,

			/// <summary>
			/// Enum AgentTitle for "AGENT_TITLE"
			/// </summary>
			[EnumMember(Value = "AGENT_TITLE")]
			AgentTitle,

			/// <summary>
			/// Enum AgentDepartment for "AGENT_DEPARTMENT"
			/// </summary>
			[EnumMember(Value = "AGENT_DEPARTMENT")]
			AgentDepartment,

			/// <summary>
			/// Enum AgentExtension for "AGENT_EXTENSION"
			/// </summary>
			[EnumMember(Value = "AGENT_EXTENSION")]
			AgentExtension,

			/// <summary>
			/// Enum AgentSkills for "AGENT_SKILLS"
			/// </summary>
			[EnumMember(Value = "AGENT_SKILLS")]
			AgentSkills,

			/// <summary>
			/// Enum AgentLocation for "AGENT_LOCATION"
			/// </summary>
			[EnumMember(Value = "AGENT_LOCATION")]
			AgentLocation,

			/// <summary>
			/// Enum AgentReportsTo for "AGENT_REPORTS_TO"
			/// </summary>
			[EnumMember(Value = "AGENT_REPORTS_TO")]
			AgentReportsTo,

			/// <summary>
			/// Enum AgentEmail for "AGENT_EMAIL"
			/// </summary>
			[EnumMember(Value = "AGENT_EMAIL")]
			AgentEmail,

			/// <summary>
			/// Enum AgentRole for "AGENT_ROLE"
			/// </summary>
			[EnumMember(Value = "AGENT_ROLE")]
			AgentRole,

			/// <summary>
			/// Enum AgentGroup for "AGENT_GROUP"
			/// </summary>
			[EnumMember(Value = "AGENT_GROUP")]
			AgentGroup,

			/// <summary>
			/// Enum AgentTimeInStatus for "AGENT_TIME_IN_STATUS"
			/// </summary>
			[EnumMember(Value = "AGENT_TIME_IN_STATUS")]
			AgentTimeInStatus,

			/// <summary>
			/// Enum AgentTimeInRoutingStatus for "AGENT_TIME_IN_ROUTING_STATUS"
			/// </summary>
			[EnumMember(Value = "AGENT_TIME_IN_ROUTING_STATUS")]
			AgentTimeInRoutingStatus,

			/// <summary>
			/// Enum AgentStatus for "AGENT_STATUS"
			/// </summary>
			[EnumMember(Value = "AGENT_STATUS")]
			AgentStatus,

			/// <summary>
			/// Enum AgentSecondaryStatus for "AGENT_SECONDARY_STATUS"
			/// </summary>
			[EnumMember(Value = "AGENT_SECONDARY_STATUS")]
			AgentSecondaryStatus,

			/// <summary>
			/// Enum AgentRoutingStatus for "AGENT_ROUTING_STATUS"
			/// </summary>
			[EnumMember(Value = "AGENT_ROUTING_STATUS")]
			AgentRoutingStatus,

			/// <summary>
			/// Enum AgentMediaTypes for "AGENT_MEDIA_TYPES"
			/// </summary>
			[EnumMember(Value = "AGENT_MEDIA_TYPES")]
			AgentMediaTypes,

			/// <summary>
			/// Enum AcwCount for "ACW_COUNT"
			/// </summary>
			[EnumMember(Value = "ACW_COUNT")]
			AcwCount,

			/// <summary>
			/// Enum AnswerTransferredPercent for "ANSWER_TRANSFERRED_PERCENT"
			/// </summary>
			[EnumMember(Value = "ANSWER_TRANSFERRED_PERCENT")]
			AnswerTransferredPercent,

			/// <summary>
			/// Enum FlowAvgMilestoneDecimal for "FLOW_AVG_MILESTONE_DECIMAL"
			/// </summary>
			[EnumMember(Value = "FLOW_AVG_MILESTONE_DECIMAL")]
			FlowAvgMilestoneDecimal,

			/// <summary>
			/// Enum NotRespondingCount for "NOT_RESPONDING_COUNT"
			/// </summary>
			[EnumMember(Value = "NOT_RESPONDING_COUNT")]
			NotRespondingCount,

			/// <summary>
			/// Enum AvgAcwHandled for "AVG_ACW_HANDLED"
			/// </summary>
			[EnumMember(Value = "AVG_ACW_HANDLED")]
			AvgAcwHandled,

			/// <summary>
			/// Enum AvgContactingTime for "AVG_CONTACTING_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_CONTACTING_TIME")]
			AvgContactingTime,

			/// <summary>
			/// Enum AvgDialingTime for "AVG_DIALING_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_DIALING_TIME")]
			AvgDialingTime,

			/// <summary>
			/// Enum AvgFlowoutTime for "AVG_FLOWOUT_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_FLOWOUT_TIME")]
			AvgFlowoutTime,

			/// <summary>
			/// Enum AvgHoldHandled for "AVG_HOLD_HANDLED"
			/// </summary>
			[EnumMember(Value = "AVG_HOLD_HANDLED")]
			AvgHoldHandled,

			/// <summary>
			/// Enum AvgMonitor for "AVG_MONITOR"
			/// </summary>
			[EnumMember(Value = "AVG_MONITOR")]
			AvgMonitor,

			/// <summary>
			/// Enum BlindTransferCount for "BLIND_TRANSFER_COUNT"
			/// </summary>
			[EnumMember(Value = "BLIND_TRANSFER_COUNT")]
			BlindTransferCount,

			/// <summary>
			/// Enum BlindTransferPercent for "BLIND_TRANSFER_PERCENT"
			/// </summary>
			[EnumMember(Value = "BLIND_TRANSFER_PERCENT")]
			BlindTransferPercent,

			/// <summary>
			/// Enum ConnectedCount for "CONNECTED_COUNT"
			/// </summary>
			[EnumMember(Value = "CONNECTED_COUNT")]
			ConnectedCount,

			/// <summary>
			/// Enum ConsultCount for "CONSULT_COUNT"
			/// </summary>
			[EnumMember(Value = "CONSULT_COUNT")]
			ConsultCount,

			/// <summary>
			/// Enum ConsultTransferCount for "CONSULT_TRANSFER_COUNT"
			/// </summary>
			[EnumMember(Value = "CONSULT_TRANSFER_COUNT")]
			ConsultTransferCount,

			/// <summary>
			/// Enum ConsultTransferPercent for "CONSULT_TRANSFER_PERCENT"
			/// </summary>
			[EnumMember(Value = "CONSULT_TRANSFER_PERCENT")]
			ConsultTransferPercent,

			/// <summary>
			/// Enum ContactingCount for "CONTACTING_COUNT"
			/// </summary>
			[EnumMember(Value = "CONTACTING_COUNT")]
			ContactingCount,

			/// <summary>
			/// Enum DialingCount for "DIALING_COUNT"
			/// </summary>
			[EnumMember(Value = "DIALING_COUNT")]
			DialingCount,

			/// <summary>
			/// Enum ErrorCount for "ERROR_COUNT"
			/// </summary>
			[EnumMember(Value = "ERROR_COUNT")]
			ErrorCount,

			/// <summary>
			/// Enum ExternalMediaCount for "EXTERNAL_MEDIA_COUNT"
			/// </summary>
			[EnumMember(Value = "EXTERNAL_MEDIA_COUNT")]
			ExternalMediaCount,

			/// <summary>
			/// Enum MaxContactingTime for "MAX_CONTACTING_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_CONTACTING_TIME")]
			MaxContactingTime,

			/// <summary>
			/// Enum MaxDialingTime for "MAX_DIALING_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_DIALING_TIME")]
			MaxDialingTime,

			/// <summary>
			/// Enum MaxFlowoutTime for "MAX_FLOWOUT_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_FLOWOUT_TIME")]
			MaxFlowoutTime,

			/// <summary>
			/// Enum FlowMilestoneCount for "FLOW_MILESTONE_COUNT"
			/// </summary>
			[EnumMember(Value = "FLOW_MILESTONE_COUNT")]
			FlowMilestoneCount,

			/// <summary>
			/// Enum MinFlowoutTime for "MIN_FLOWOUT_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_FLOWOUT_TIME")]
			MinFlowoutTime,

			/// <summary>
			/// Enum MaxMonitor for "MAX_MONITOR"
			/// </summary>
			[EnumMember(Value = "MAX_MONITOR")]
			MaxMonitor,

			/// <summary>
			/// Enum MinContactingTime for "MIN_CONTACTING_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_CONTACTING_TIME")]
			MinContactingTime,

			/// <summary>
			/// Enum MinDialingTime for "MIN_DIALING_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_DIALING_TIME")]
			MinDialingTime,

			/// <summary>
			/// Enum MinMonitor for "MIN_MONITOR"
			/// </summary>
			[EnumMember(Value = "MIN_MONITOR")]
			MinMonitor,

			/// <summary>
			/// Enum MonitorCount for "MONITOR_COUNT"
			/// </summary>
			[EnumMember(Value = "MONITOR_COUNT")]
			MonitorCount,

			/// <summary>
			/// Enum MediaCount for "MEDIA_COUNT"
			/// </summary>
			[EnumMember(Value = "MEDIA_COUNT")]
			MediaCount,

			/// <summary>
			/// Enum ServiceLevelTarget for "SERVICE_LEVEL_TARGET"
			/// </summary>
			[EnumMember(Value = "SERVICE_LEVEL_TARGET")]
			ServiceLevelTarget,

			/// <summary>
			/// Enum ServiceLevelTargetCurrent for "SERVICE_LEVEL_TARGET_CURRENT"
			/// </summary>
			[EnumMember(Value = "SERVICE_LEVEL_TARGET_CURRENT")]
			ServiceLevelTargetCurrent,

			/// <summary>
			/// Enum TalkCount for "TALK_COUNT"
			/// </summary>
			[EnumMember(Value = "TALK_COUNT")]
			TalkCount,

			/// <summary>
			/// Enum TotalAbandonTime for "TOTAL_ABANDON_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_ABANDON_TIME")]
			TotalAbandonTime,

			/// <summary>
			/// Enum TotalNotRespondingTime for "TOTAL_NOT_RESPONDING_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_NOT_RESPONDING_TIME")]
			TotalNotRespondingTime,

			/// <summary>
			/// Enum TotalContacting for "TOTAL_CONTACTING"
			/// </summary>
			[EnumMember(Value = "TOTAL_CONTACTING")]
			TotalContacting,

			/// <summary>
			/// Enum TotalDialing for "TOTAL_DIALING"
			/// </summary>
			[EnumMember(Value = "TOTAL_DIALING")]
			TotalDialing,

			/// <summary>
			/// Enum TotalMonitor for "TOTAL_MONITOR"
			/// </summary>
			[EnumMember(Value = "TOTAL_MONITOR")]
			TotalMonitor,

			/// <summary>
			/// Enum TotalWaitTime for "TOTAL_WAIT_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_WAIT_TIME")]
			TotalWaitTime,

			/// <summary>
			/// Enum WaitCount for "WAIT_COUNT"
			/// </summary>
			[EnumMember(Value = "WAIT_COUNT")]
			WaitCount,

			/// <summary>
			/// Enum ParkCount for "PARK_COUNT"
			/// </summary>
			[EnumMember(Value = "PARK_COUNT")]
			ParkCount,

			/// <summary>
			/// Enum AvgParkTime for "AVG_PARK_TIME"
			/// </summary>
			[EnumMember(Value = "AVG_PARK_TIME")]
			AvgParkTime,

			/// <summary>
			/// Enum TotalParkTime for "TOTAL_PARK_TIME"
			/// </summary>
			[EnumMember(Value = "TOTAL_PARK_TIME")]
			TotalParkTime,

			/// <summary>
			/// Enum MinParkTime for "MIN_PARK_TIME"
			/// </summary>
			[EnumMember(Value = "MIN_PARK_TIME")]
			MinParkTime,

			/// <summary>
			/// Enum MaxParkTime for "MAX_PARK_TIME"
			/// </summary>
			[EnumMember(Value = "MAX_PARK_TIME")]
			MaxParkTime,

			/// <summary>
			/// Enum InboundAudioCount for "INBOUND_AUDIO_COUNT"
			/// </summary>
			[EnumMember(Value = "INBOUND_AUDIO_COUNT")]
			InboundAudioCount,

			/// <summary>
			/// Enum OutboundAudioCount for "OUTBOUND_AUDIO_COUNT"
			/// </summary>
			[EnumMember(Value = "OUTBOUND_AUDIO_COUNT")]
			OutboundAudioCount
		}
		/// <summary>
		/// The sort order of the table.
		/// </summary>
		/// <value>The sort order of the table.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SortOrderEnum
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
		/// The sort key of the table.
		/// </summary>
		/// <value>The sort key of the table.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SortKeyEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Name for "Name"
			/// </summary>
			[EnumMember(Value = "Name")]
			Name,

			/// <summary>
			/// Enum Duration for "Duration"
			/// </summary>
			[EnumMember(Value = "Duration")]
			Duration
		}
		/// <summary>
		/// Gets or Sets Periods
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum PeriodsEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum None for "NONE"
			/// </summary>
			[EnumMember(Value = "NONE")]
			None,

			/// <summary>
			/// Enum CurrentHalfHour for "CURRENT_HALF_HOUR"
			/// </summary>
			[EnumMember(Value = "CURRENT_HALF_HOUR")]
			CurrentHalfHour,

			/// <summary>
			/// Enum Today for "TODAY"
			/// </summary>
			[EnumMember(Value = "TODAY")]
			Today,

			/// <summary>
			/// Enum Yesterday for "YESTERDAY"
			/// </summary>
			[EnumMember(Value = "YESTERDAY")]
			Yesterday,

			/// <summary>
			/// Enum ThisWeek for "THIS_WEEK"
			/// </summary>
			[EnumMember(Value = "THIS_WEEK")]
			ThisWeek,

			/// <summary>
			/// Enum LastWeek for "LAST_WEEK"
			/// </summary>
			[EnumMember(Value = "LAST_WEEK")]
			LastWeek,

			/// <summary>
			/// Enum ThisMonth for "THIS_MONTH"
			/// </summary>
			[EnumMember(Value = "THIS_MONTH")]
			ThisMonth,

			/// <summary>
			/// Enum LastMonth for "LAST_MONTH"
			/// </summary>
			[EnumMember(Value = "LAST_MONTH")]
			LastMonth,

			/// <summary>
			/// Enum Prior7Days for "PRIOR_7_DAYS"
			/// </summary>
			[EnumMember(Value = "PRIOR_7_DAYS")]
			Prior7Days,

			/// <summary>
			/// Enum Past7DaysToDate for "PAST_7_DAYS_TO_DATE"
			/// </summary>
			[EnumMember(Value = "PAST_7_DAYS_TO_DATE")]
			Past7DaysToDate,

			/// <summary>
			/// Enum Prior30Days for "PRIOR_30_DAYS"
			/// </summary>
			[EnumMember(Value = "PRIOR_30_DAYS")]
			Prior30Days,

			/// <summary>
			/// Enum Past30DaysToDate for "PAST_30_DAYS_TO_DATE"
			/// </summary>
			[EnumMember(Value = "PAST_30_DAYS_TO_DATE")]
			Past30DaysToDate,

			/// <summary>
			/// Enum Prior3Months for "PRIOR_3_MONTHS"
			/// </summary>
			[EnumMember(Value = "PRIOR_3_MONTHS")]
			Prior3Months
		}
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
			/// Enum Callback for "callback"
			/// </summary>
			[EnumMember(Value = "callback")]
			Callback,

			/// <summary>
			/// Enum Chat for "chat"
			/// </summary>
			[EnumMember(Value = "chat")]
			Chat,

			/// <summary>
			/// Enum Cobrowse for "cobrowse"
			/// </summary>
			[EnumMember(Value = "cobrowse")]
			Cobrowse,

			/// <summary>
			/// Enum Email for "email"
			/// </summary>
			[EnumMember(Value = "email")]
			Email,

			/// <summary>
			/// Enum Internalmessage for "internalmessage"
			/// </summary>
			[EnumMember(Value = "internalmessage")]
			Internalmessage,

			/// <summary>
			/// Enum Message for "message"
			/// </summary>
			[EnumMember(Value = "message")]
			Message,

			/// <summary>
			/// Enum Screenshare for "screenshare"
			/// </summary>
			[EnumMember(Value = "screenshare")]
			Screenshare,

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Video for "video"
			/// </summary>
			[EnumMember(Value = "video")]
			Video,

			/// <summary>
			/// Enum Voice for "voice"
			/// </summary>
			[EnumMember(Value = "voice")]
			Voice
		}
		/// <summary>
		/// Gets or Sets SelectedStatuses
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SelectedStatusesEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Available for "Available"
			/// </summary>
			[EnumMember(Value = "Available")]
			Available,

			/// <summary>
			/// Enum Away for "Away"
			/// </summary>
			[EnumMember(Value = "Away")]
			Away,

			/// <summary>
			/// Enum Busy for "Busy"
			/// </summary>
			[EnumMember(Value = "Busy")]
			Busy,

			/// <summary>
			/// Enum Break for "Break"
			/// </summary>
			[EnumMember(Value = "Break")]
			Break,

			/// <summary>
			/// Enum Meeting for "Meeting"
			/// </summary>
			[EnumMember(Value = "Meeting")]
			Meeting,

			/// <summary>
			/// Enum Training for "Training"
			/// </summary>
			[EnumMember(Value = "Training")]
			Training,

			/// <summary>
			/// Enum Meal for "Meal"
			/// </summary>
			[EnumMember(Value = "Meal")]
			Meal,

			/// <summary>
			/// Enum Systemaway for "SystemAway"
			/// </summary>
			[EnumMember(Value = "SystemAway")]
			Systemaway,

			/// <summary>
			/// Enum Onqueue for "OnQueue"
			/// </summary>
			[EnumMember(Value = "OnQueue")]
			Onqueue,

			/// <summary>
			/// Enum Interacting for "Interacting"
			/// </summary>
			[EnumMember(Value = "Interacting")]
			Interacting,

			/// <summary>
			/// Enum Notresponding for "NotResponding"
			/// </summary>
			[EnumMember(Value = "NotResponding")]
			Notresponding,

			/// <summary>
			/// Enum Idle for "Idle"
			/// </summary>
			[EnumMember(Value = "Idle")]
			Idle,

			/// <summary>
			/// Enum Communicating for "Communicating"
			/// </summary>
			[EnumMember(Value = "Communicating")]
			Communicating,

			/// <summary>
			/// Enum Offqueue for "OffQueue"
			/// </summary>
			[EnumMember(Value = "OffQueue")]
			Offqueue,

			/// <summary>
			/// Enum Online for "Online"
			/// </summary>
			[EnumMember(Value = "Online")]
			Online,

			/// <summary>
			/// Enum Offline for "Offline"
			/// </summary>
			[EnumMember(Value = "Offline")]
			Offline
		}
		/// <summary>
		/// Gets or Sets SelectedSegmentTypes
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SelectedSegmentTypesEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Alert for "alert"
			/// </summary>
			[EnumMember(Value = "alert")]
			Alert,

			/// <summary>
			/// Enum Barging for "barging"
			/// </summary>
			[EnumMember(Value = "barging")]
			Barging,

			/// <summary>
			/// Enum Callback for "callback"
			/// </summary>
			[EnumMember(Value = "callback")]
			Callback,

			/// <summary>
			/// Enum Coaching for "coaching"
			/// </summary>
			[EnumMember(Value = "coaching")]
			Coaching,

			/// <summary>
			/// Enum Contacting for "contacting"
			/// </summary>
			[EnumMember(Value = "contacting")]
			Contacting,

			/// <summary>
			/// Enum Converting for "converting"
			/// </summary>
			[EnumMember(Value = "converting")]
			Converting,

			/// <summary>
			/// Enum Delay for "delay"
			/// </summary>
			[EnumMember(Value = "delay")]
			Delay,

			/// <summary>
			/// Enum Dialing for "dialing"
			/// </summary>
			[EnumMember(Value = "dialing")]
			Dialing,

			/// <summary>
			/// Enum Hold for "hold"
			/// </summary>
			[EnumMember(Value = "hold")]
			Hold,

			/// <summary>
			/// Enum Interact for "interact"
			/// </summary>
			[EnumMember(Value = "interact")]
			Interact,

			/// <summary>
			/// Enum Ivr for "ivr"
			/// </summary>
			[EnumMember(Value = "ivr")]
			Ivr,

			/// <summary>
			/// Enum Monitoring for "monitoring"
			/// </summary>
			[EnumMember(Value = "monitoring")]
			Monitoring,

			/// <summary>
			/// Enum Parked for "parked"
			/// </summary>
			[EnumMember(Value = "parked")]
			Parked,

			/// <summary>
			/// Enum Scheduled for "scheduled"
			/// </summary>
			[EnumMember(Value = "scheduled")]
			Scheduled,

			/// <summary>
			/// Enum Sharing for "sharing"
			/// </summary>
			[EnumMember(Value = "sharing")]
			Sharing,

			/// <summary>
			/// Enum System for "system"
			/// </summary>
			[EnumMember(Value = "system")]
			System,

			/// <summary>
			/// Enum Transmitting for "transmitting"
			/// </summary>
			[EnumMember(Value = "transmitting")]
			Transmitting,

			/// <summary>
			/// Enum Unknown for "unknown"
			/// </summary>
			[EnumMember(Value = "unknown")]
			Unknown,

			/// <summary>
			/// Enum Uploading for "uploading"
			/// </summary>
			[EnumMember(Value = "uploading")]
			Uploading,

			/// <summary>
			/// Enum Voicemail for "voicemail"
			/// </summary>
			[EnumMember(Value = "voicemail")]
			Voicemail,

			/// <summary>
			/// Enum Wrapup for "wrapup"
			/// </summary>
			[EnumMember(Value = "wrapup")]
			Wrapup
		}
		/// <summary>
		/// The sort order of the interactions in the agent status widget.
		/// </summary>
		/// <value>The sort order of the interactions in the agent status widget.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AgentInteractionSortOrderEnum
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
		/// The type of dashboard widget configuration.
		/// </summary>
		/// <value>The type of dashboard widget configuration.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// The sort order of the table.
		/// </summary>
		/// <value>The sort order of the table.</value>
		[DataMember(Name = "sortOrder", EmitDefaultValue = false)]
		public SortOrderEnum? SortOrder { get; set; }
		/// <summary>
		/// The sort key of the table.
		/// </summary>
		/// <value>The sort key of the table.</value>
		[DataMember(Name = "sortKey", EmitDefaultValue = false)]
		public SortKeyEnum? SortKey { get; set; }
		/// <summary>
		/// The sort order of the interactions in the agent status widget.
		/// </summary>
		/// <value>The sort order of the interactions in the agent status widget.</value>
		[DataMember(Name = "agentInteractionSortOrder", EmitDefaultValue = false)]
		public AgentInteractionSortOrderEnum? AgentInteractionSortOrder { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Widget" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Widget() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Widget" /> class.
		/// </summary>
		/// <param name="Row">The row number for the specific dashboard widget configuration..</param>
		/// <param name="Column">The column number for the specific dashboard widget configuration..</param>
		/// <param name="Title">The title for the dashboard widget configuration..</param>
		/// <param name="Type">The type of dashboard widget configuration. (required).</param>
		/// <param name="Metrics">The list of metrics for the dashboard widget configuration..</param>
		/// <param name="DisplayText">The display text for the dashboard widget configuration..</param>
		/// <param name="DisplayTextColor">The color of the display text for the dashboard widget configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red)..</param>
		/// <param name="WebContentUrl">The external web URL for the dashboard widget configuration..</param>
		/// <param name="SplitFilters">Indicates each filter to be displayed individually..</param>
		/// <param name="SplitByMediaType">Indicates that data for each media type should be shown individually..</param>
		/// <param name="ShowLongest">Indicates the display be the longest time..</param>
		/// <param name="DisplayAsTable">Indicates the widget to be displayed as table..</param>
		/// <param name="ShowDuration">Indicates the display to include duration..</param>
		/// <param name="SortOrder">The sort order of the table..</param>
		/// <param name="SortKey">The sort key of the table..</param>
		/// <param name="EntityLimit">Indicates the limit of displayed entities..</param>
		/// <param name="DisplayAggregates">Indicates whether to display aggregate across all entity and media type combination..</param>
		/// <param name="IsFullWidth">Indicates whether a widget should take the full width of a dashboard or be shown only in a single slot..</param>
		/// <param name="ShowPercentageChange">Indicates whether a widget should show the percentage diff between two values..</param>
		/// <param name="ShowProfilePicture">Indicates whether a widget should show the profile picture of an agent..</param>
		/// <param name="Filter">The filters to be applied for dashboard widget configuration.</param>
		/// <param name="Periods">The list of periods for the dashboard widget configuration.</param>
		/// <param name="MediaTypes">The list of media types for the dashboard widget configuration.</param>
		/// <param name="Warnings">List of warnings for dashboard widget configuration.</param>
		/// <param name="ShowTimeInStatus">Indicates the show time in status of a widget configuration..</param>
		/// <param name="ShowOfflineAgents">Indicates to show offline agent widget..</param>
		/// <param name="SelectedStatuses">Indicates the selected statuses used to filter the agent widget in the dashboard..</param>
		/// <param name="SelectedSegmentTypes">Indicates the selected segment types used to filter the agent activity in the dashboard..</param>
		/// <param name="AgentInteractionSortOrder">The sort order of the interactions in the agent status widget..</param>
		public Widget(int? Row = null, int? Column = null, string Title = null, TypeEnum? Type = null, List<MetricsEnum> Metrics = null, string DisplayText = null, string DisplayTextColor = null, string WebContentUrl = null, bool? SplitFilters = null, bool? SplitByMediaType = null, bool? ShowLongest = null, bool? DisplayAsTable = null, bool? ShowDuration = null, SortOrderEnum? SortOrder = null, SortKeyEnum? SortKey = null, int? EntityLimit = null, bool? DisplayAggregates = null, bool? IsFullWidth = null, bool? ShowPercentageChange = null, bool? ShowProfilePicture = null, ViewFilter Filter = null, List<PeriodsEnum> Periods = null, List<MediaTypesEnum> MediaTypes = null, List<Warning> Warnings = null, bool? ShowTimeInStatus = null, bool? ShowOfflineAgents = null, List<SelectedStatusesEnum> SelectedStatuses = null, List<SelectedSegmentTypesEnum> SelectedSegmentTypes = null, AgentInteractionSortOrderEnum? AgentInteractionSortOrder = null)
		{
			this.Row = Row;
			this.Column = Column;
			this.Title = Title;
			this.Type = Type;
			this.Metrics = Metrics;
			this.DisplayText = DisplayText;
			this.DisplayTextColor = DisplayTextColor;
			this.WebContentUrl = WebContentUrl;
			this.SplitFilters = SplitFilters;
			this.SplitByMediaType = SplitByMediaType;
			this.ShowLongest = ShowLongest;
			this.DisplayAsTable = DisplayAsTable;
			this.ShowDuration = ShowDuration;
			this.SortOrder = SortOrder;
			this.SortKey = SortKey;
			this.EntityLimit = EntityLimit;
			this.DisplayAggregates = DisplayAggregates;
			this.IsFullWidth = IsFullWidth;
			this.ShowPercentageChange = ShowPercentageChange;
			this.ShowProfilePicture = ShowProfilePicture;
			this.Filter = Filter;
			this.Periods = Periods;
			this.MediaTypes = MediaTypes;
			this.Warnings = Warnings;
			this.ShowTimeInStatus = ShowTimeInStatus;
			this.ShowOfflineAgents = ShowOfflineAgents;
			this.SelectedStatuses = SelectedStatuses;
			this.SelectedSegmentTypes = SelectedSegmentTypes;
			this.AgentInteractionSortOrder = AgentInteractionSortOrder;

		}



		/// <summary>
		/// The row number for the specific dashboard widget configuration.
		/// </summary>
		/// <value>The row number for the specific dashboard widget configuration.</value>
		[DataMember(Name = "row", EmitDefaultValue = false)]
		public int? Row { get; set; }



		/// <summary>
		/// The column number for the specific dashboard widget configuration.
		/// </summary>
		/// <value>The column number for the specific dashboard widget configuration.</value>
		[DataMember(Name = "column", EmitDefaultValue = false)]
		public int? Column { get; set; }



		/// <summary>
		/// The title for the dashboard widget configuration.
		/// </summary>
		/// <value>The title for the dashboard widget configuration.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }





		/// <summary>
		/// The list of metrics for the dashboard widget configuration.
		/// </summary>
		/// <value>The list of metrics for the dashboard widget configuration.</value>
		[DataMember(Name = "metrics", EmitDefaultValue = false)]
		public List<MetricsEnum> Metrics { get; set; }



		/// <summary>
		/// The display text for the dashboard widget configuration.
		/// </summary>
		/// <value>The display text for the dashboard widget configuration.</value>
		[DataMember(Name = "displayText", EmitDefaultValue = false)]
		public string DisplayText { get; set; }



		/// <summary>
		/// The color of the display text for the dashboard widget configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).
		/// </summary>
		/// <value>The color of the display text for the dashboard widget configuration in RGB hexadecimal format (for example \&quot;#FF0000\&quot; represents red).</value>
		[DataMember(Name = "displayTextColor", EmitDefaultValue = false)]
		public string DisplayTextColor { get; set; }



		/// <summary>
		/// The external web URL for the dashboard widget configuration.
		/// </summary>
		/// <value>The external web URL for the dashboard widget configuration.</value>
		[DataMember(Name = "webContentUrl", EmitDefaultValue = false)]
		public string WebContentUrl { get; set; }



		/// <summary>
		/// Indicates each filter to be displayed individually.
		/// </summary>
		/// <value>Indicates each filter to be displayed individually.</value>
		[DataMember(Name = "splitFilters", EmitDefaultValue = false)]
		public bool? SplitFilters { get; set; }



		/// <summary>
		/// Indicates that data for each media type should be shown individually.
		/// </summary>
		/// <value>Indicates that data for each media type should be shown individually.</value>
		[DataMember(Name = "splitByMediaType", EmitDefaultValue = false)]
		public bool? SplitByMediaType { get; set; }



		/// <summary>
		/// Indicates the display be the longest time.
		/// </summary>
		/// <value>Indicates the display be the longest time.</value>
		[DataMember(Name = "showLongest", EmitDefaultValue = false)]
		public bool? ShowLongest { get; set; }



		/// <summary>
		/// Indicates the widget to be displayed as table.
		/// </summary>
		/// <value>Indicates the widget to be displayed as table.</value>
		[DataMember(Name = "displayAsTable", EmitDefaultValue = false)]
		public bool? DisplayAsTable { get; set; }



		/// <summary>
		/// Indicates the display to include duration.
		/// </summary>
		/// <value>Indicates the display to include duration.</value>
		[DataMember(Name = "showDuration", EmitDefaultValue = false)]
		public bool? ShowDuration { get; set; }







		/// <summary>
		/// Indicates the limit of displayed entities.
		/// </summary>
		/// <value>Indicates the limit of displayed entities.</value>
		[DataMember(Name = "entityLimit", EmitDefaultValue = false)]
		public int? EntityLimit { get; set; }



		/// <summary>
		/// Indicates whether to display aggregate across all entity and media type combination.
		/// </summary>
		/// <value>Indicates whether to display aggregate across all entity and media type combination.</value>
		[DataMember(Name = "displayAggregates", EmitDefaultValue = false)]
		public bool? DisplayAggregates { get; set; }



		/// <summary>
		/// Indicates whether a widget should take the full width of a dashboard or be shown only in a single slot.
		/// </summary>
		/// <value>Indicates whether a widget should take the full width of a dashboard or be shown only in a single slot.</value>
		[DataMember(Name = "isFullWidth", EmitDefaultValue = false)]
		public bool? IsFullWidth { get; set; }



		/// <summary>
		/// Indicates whether a widget should show the percentage diff between two values.
		/// </summary>
		/// <value>Indicates whether a widget should show the percentage diff between two values.</value>
		[DataMember(Name = "showPercentageChange", EmitDefaultValue = false)]
		public bool? ShowPercentageChange { get; set; }



		/// <summary>
		/// Indicates whether a widget should show the profile picture of an agent.
		/// </summary>
		/// <value>Indicates whether a widget should show the profile picture of an agent.</value>
		[DataMember(Name = "showProfilePicture", EmitDefaultValue = false)]
		public bool? ShowProfilePicture { get; set; }



		/// <summary>
		/// The filters to be applied for dashboard widget configuration
		/// </summary>
		/// <value>The filters to be applied for dashboard widget configuration</value>
		[DataMember(Name = "filter", EmitDefaultValue = false)]
		public ViewFilter Filter { get; set; }



		/// <summary>
		/// The list of periods for the dashboard widget configuration
		/// </summary>
		/// <value>The list of periods for the dashboard widget configuration</value>
		[DataMember(Name = "periods", EmitDefaultValue = false)]
		public List<PeriodsEnum> Periods { get; set; }



		/// <summary>
		/// The list of media types for the dashboard widget configuration
		/// </summary>
		/// <value>The list of media types for the dashboard widget configuration</value>
		[DataMember(Name = "mediaTypes", EmitDefaultValue = false)]
		public List<MediaTypesEnum> MediaTypes { get; set; }



		/// <summary>
		/// List of warnings for dashboard widget configuration
		/// </summary>
		/// <value>List of warnings for dashboard widget configuration</value>
		[DataMember(Name = "warnings", EmitDefaultValue = false)]
		public List<Warning> Warnings { get; set; }



		/// <summary>
		/// Indicates the show time in status of a widget configuration.
		/// </summary>
		/// <value>Indicates the show time in status of a widget configuration.</value>
		[DataMember(Name = "showTimeInStatus", EmitDefaultValue = false)]
		public bool? ShowTimeInStatus { get; set; }



		/// <summary>
		/// Indicates to show offline agent widget.
		/// </summary>
		/// <value>Indicates to show offline agent widget.</value>
		[DataMember(Name = "showOfflineAgents", EmitDefaultValue = false)]
		public bool? ShowOfflineAgents { get; set; }



		/// <summary>
		/// Indicates the selected statuses used to filter the agent widget in the dashboard.
		/// </summary>
		/// <value>Indicates the selected statuses used to filter the agent widget in the dashboard.</value>
		[DataMember(Name = "selectedStatuses", EmitDefaultValue = false)]
		public List<SelectedStatusesEnum> SelectedStatuses { get; set; }



		/// <summary>
		/// Indicates the selected segment types used to filter the agent activity in the dashboard.
		/// </summary>
		/// <value>Indicates the selected segment types used to filter the agent activity in the dashboard.</value>
		[DataMember(Name = "selectedSegmentTypes", EmitDefaultValue = false)]
		public List<SelectedSegmentTypesEnum> SelectedSegmentTypes { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Widget {\n");

			sb.Append("  Row: ").Append(Row).Append("\n");
			sb.Append("  Column: ").Append(Column).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Metrics: ").Append(Metrics).Append("\n");
			sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
			sb.Append("  DisplayTextColor: ").Append(DisplayTextColor).Append("\n");
			sb.Append("  WebContentUrl: ").Append(WebContentUrl).Append("\n");
			sb.Append("  SplitFilters: ").Append(SplitFilters).Append("\n");
			sb.Append("  SplitByMediaType: ").Append(SplitByMediaType).Append("\n");
			sb.Append("  ShowLongest: ").Append(ShowLongest).Append("\n");
			sb.Append("  DisplayAsTable: ").Append(DisplayAsTable).Append("\n");
			sb.Append("  ShowDuration: ").Append(ShowDuration).Append("\n");
			sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
			sb.Append("  SortKey: ").Append(SortKey).Append("\n");
			sb.Append("  EntityLimit: ").Append(EntityLimit).Append("\n");
			sb.Append("  DisplayAggregates: ").Append(DisplayAggregates).Append("\n");
			sb.Append("  IsFullWidth: ").Append(IsFullWidth).Append("\n");
			sb.Append("  ShowPercentageChange: ").Append(ShowPercentageChange).Append("\n");
			sb.Append("  ShowProfilePicture: ").Append(ShowProfilePicture).Append("\n");
			sb.Append("  Filter: ").Append(Filter).Append("\n");
			sb.Append("  Periods: ").Append(Periods).Append("\n");
			sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
			sb.Append("  Warnings: ").Append(Warnings).Append("\n");
			sb.Append("  ShowTimeInStatus: ").Append(ShowTimeInStatus).Append("\n");
			sb.Append("  ShowOfflineAgents: ").Append(ShowOfflineAgents).Append("\n");
			sb.Append("  SelectedStatuses: ").Append(SelectedStatuses).Append("\n");
			sb.Append("  SelectedSegmentTypes: ").Append(SelectedSegmentTypes).Append("\n");
			sb.Append("  AgentInteractionSortOrder: ").Append(AgentInteractionSortOrder).Append("\n");
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
			return this.Equals(obj as Widget);
		}

		/// <summary>
		/// Returns true if Widget instances are equal
		/// </summary>
		/// <param name="other">Instance of Widget to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Widget other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Row == other.Row ||
					this.Row != null &&
					this.Row.Equals(other.Row)
				) &&
				(
					this.Column == other.Column ||
					this.Column != null &&
					this.Column.Equals(other.Column)
				) &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Metrics == other.Metrics ||
					this.Metrics != null &&
					this.Metrics.SequenceEqual(other.Metrics)
				) &&
				(
					this.DisplayText == other.DisplayText ||
					this.DisplayText != null &&
					this.DisplayText.Equals(other.DisplayText)
				) &&
				(
					this.DisplayTextColor == other.DisplayTextColor ||
					this.DisplayTextColor != null &&
					this.DisplayTextColor.Equals(other.DisplayTextColor)
				) &&
				(
					this.WebContentUrl == other.WebContentUrl ||
					this.WebContentUrl != null &&
					this.WebContentUrl.Equals(other.WebContentUrl)
				) &&
				(
					this.SplitFilters == other.SplitFilters ||
					this.SplitFilters != null &&
					this.SplitFilters.Equals(other.SplitFilters)
				) &&
				(
					this.SplitByMediaType == other.SplitByMediaType ||
					this.SplitByMediaType != null &&
					this.SplitByMediaType.Equals(other.SplitByMediaType)
				) &&
				(
					this.ShowLongest == other.ShowLongest ||
					this.ShowLongest != null &&
					this.ShowLongest.Equals(other.ShowLongest)
				) &&
				(
					this.DisplayAsTable == other.DisplayAsTable ||
					this.DisplayAsTable != null &&
					this.DisplayAsTable.Equals(other.DisplayAsTable)
				) &&
				(
					this.ShowDuration == other.ShowDuration ||
					this.ShowDuration != null &&
					this.ShowDuration.Equals(other.ShowDuration)
				) &&
				(
					this.SortOrder == other.SortOrder ||
					this.SortOrder != null &&
					this.SortOrder.Equals(other.SortOrder)
				) &&
				(
					this.SortKey == other.SortKey ||
					this.SortKey != null &&
					this.SortKey.Equals(other.SortKey)
				) &&
				(
					this.EntityLimit == other.EntityLimit ||
					this.EntityLimit != null &&
					this.EntityLimit.Equals(other.EntityLimit)
				) &&
				(
					this.DisplayAggregates == other.DisplayAggregates ||
					this.DisplayAggregates != null &&
					this.DisplayAggregates.Equals(other.DisplayAggregates)
				) &&
				(
					this.IsFullWidth == other.IsFullWidth ||
					this.IsFullWidth != null &&
					this.IsFullWidth.Equals(other.IsFullWidth)
				) &&
				(
					this.ShowPercentageChange == other.ShowPercentageChange ||
					this.ShowPercentageChange != null &&
					this.ShowPercentageChange.Equals(other.ShowPercentageChange)
				) &&
				(
					this.ShowProfilePicture == other.ShowProfilePicture ||
					this.ShowProfilePicture != null &&
					this.ShowProfilePicture.Equals(other.ShowProfilePicture)
				) &&
				(
					this.Filter == other.Filter ||
					this.Filter != null &&
					this.Filter.Equals(other.Filter)
				) &&
				(
					this.Periods == other.Periods ||
					this.Periods != null &&
					this.Periods.SequenceEqual(other.Periods)
				) &&
				(
					this.MediaTypes == other.MediaTypes ||
					this.MediaTypes != null &&
					this.MediaTypes.SequenceEqual(other.MediaTypes)
				) &&
				(
					this.Warnings == other.Warnings ||
					this.Warnings != null &&
					this.Warnings.SequenceEqual(other.Warnings)
				) &&
				(
					this.ShowTimeInStatus == other.ShowTimeInStatus ||
					this.ShowTimeInStatus != null &&
					this.ShowTimeInStatus.Equals(other.ShowTimeInStatus)
				) &&
				(
					this.ShowOfflineAgents == other.ShowOfflineAgents ||
					this.ShowOfflineAgents != null &&
					this.ShowOfflineAgents.Equals(other.ShowOfflineAgents)
				) &&
				(
					this.SelectedStatuses == other.SelectedStatuses ||
					this.SelectedStatuses != null &&
					this.SelectedStatuses.SequenceEqual(other.SelectedStatuses)
				) &&
				(
					this.SelectedSegmentTypes == other.SelectedSegmentTypes ||
					this.SelectedSegmentTypes != null &&
					this.SelectedSegmentTypes.SequenceEqual(other.SelectedSegmentTypes)
				) &&
				(
					this.AgentInteractionSortOrder == other.AgentInteractionSortOrder ||
					this.AgentInteractionSortOrder != null &&
					this.AgentInteractionSortOrder.Equals(other.AgentInteractionSortOrder)
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
				if (this.Row != null)
					hash = hash * 59 + this.Row.GetHashCode();

				if (this.Column != null)
					hash = hash * 59 + this.Column.GetHashCode();

				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Metrics != null)
					hash = hash * 59 + this.Metrics.GetHashCode();

				if (this.DisplayText != null)
					hash = hash * 59 + this.DisplayText.GetHashCode();

				if (this.DisplayTextColor != null)
					hash = hash * 59 + this.DisplayTextColor.GetHashCode();

				if (this.WebContentUrl != null)
					hash = hash * 59 + this.WebContentUrl.GetHashCode();

				if (this.SplitFilters != null)
					hash = hash * 59 + this.SplitFilters.GetHashCode();

				if (this.SplitByMediaType != null)
					hash = hash * 59 + this.SplitByMediaType.GetHashCode();

				if (this.ShowLongest != null)
					hash = hash * 59 + this.ShowLongest.GetHashCode();

				if (this.DisplayAsTable != null)
					hash = hash * 59 + this.DisplayAsTable.GetHashCode();

				if (this.ShowDuration != null)
					hash = hash * 59 + this.ShowDuration.GetHashCode();

				if (this.SortOrder != null)
					hash = hash * 59 + this.SortOrder.GetHashCode();

				if (this.SortKey != null)
					hash = hash * 59 + this.SortKey.GetHashCode();

				if (this.EntityLimit != null)
					hash = hash * 59 + this.EntityLimit.GetHashCode();

				if (this.DisplayAggregates != null)
					hash = hash * 59 + this.DisplayAggregates.GetHashCode();

				if (this.IsFullWidth != null)
					hash = hash * 59 + this.IsFullWidth.GetHashCode();

				if (this.ShowPercentageChange != null)
					hash = hash * 59 + this.ShowPercentageChange.GetHashCode();

				if (this.ShowProfilePicture != null)
					hash = hash * 59 + this.ShowProfilePicture.GetHashCode();

				if (this.Filter != null)
					hash = hash * 59 + this.Filter.GetHashCode();

				if (this.Periods != null)
					hash = hash * 59 + this.Periods.GetHashCode();

				if (this.MediaTypes != null)
					hash = hash * 59 + this.MediaTypes.GetHashCode();

				if (this.Warnings != null)
					hash = hash * 59 + this.Warnings.GetHashCode();

				if (this.ShowTimeInStatus != null)
					hash = hash * 59 + this.ShowTimeInStatus.GetHashCode();

				if (this.ShowOfflineAgents != null)
					hash = hash * 59 + this.ShowOfflineAgents.GetHashCode();

				if (this.SelectedStatuses != null)
					hash = hash * 59 + this.SelectedStatuses.GetHashCode();

				if (this.SelectedSegmentTypes != null)
					hash = hash * 59 + this.SelectedSegmentTypes.GetHashCode();

				if (this.AgentInteractionSortOrder != null)
					hash = hash * 59 + this.AgentInteractionSortOrder.GetHashCode();

				return hash;
			}
		}
	}

}
