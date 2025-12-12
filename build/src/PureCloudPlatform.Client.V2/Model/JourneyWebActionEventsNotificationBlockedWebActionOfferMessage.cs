using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyWebActionEventsNotificationBlockedWebActionOfferMessage
	/// </summary>
	[DataContract]
	public partial class JourneyWebActionEventsNotificationBlockedWebActionOfferMessage : IEquatable<JourneyWebActionEventsNotificationBlockedWebActionOfferMessage>
	{
		/// <summary>
		/// Gets or Sets BlockingReason
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum BlockingReasonEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Pageurlconditionsnotmatching for "PageUrlConditionsNotMatching"
			/// </summary>
			[EnumMember(Value = "PageUrlConditionsNotMatching")]
			Pageurlconditionsnotmatching,

			/// <summary>
			/// Enum Servicelevelthrottling for "ServiceLevelThrottling"
			/// </summary>
			[EnumMember(Value = "ServiceLevelThrottling")]
			Servicelevelthrottling,

			/// <summary>
			/// Enum Alreadyexistingoffer for "AlreadyExistingOffer"
			/// </summary>
			[EnumMember(Value = "AlreadyExistingOffer")]
			Alreadyexistingoffer,

			/// <summary>
			/// Enum Triggerdateinfuture for "TriggerDateInFuture"
			/// </summary>
			[EnumMember(Value = "TriggerDateInFuture")]
			Triggerdateinfuture,

			/// <summary>
			/// Enum Multiplesimultaneousoffers for "MultipleSimultaneousOffers"
			/// </summary>
			[EnumMember(Value = "MultipleSimultaneousOffers")]
			Multiplesimultaneousoffers,

			/// <summary>
			/// Enum Noavailableagents for "NoAvailableAgents"
			/// </summary>
			[EnumMember(Value = "NoAvailableAgents")]
			Noavailableagents,

			/// <summary>
			/// Enum Frequencycapping for "FrequencyCapping"
			/// </summary>
			[EnumMember(Value = "FrequencyCapping")]
			Frequencycapping,

			/// <summary>
			/// Enum Offeredoutsideschedule for "OfferedOutsideSchedule"
			/// </summary>
			[EnumMember(Value = "OfferedOutsideSchedule")]
			Offeredoutsideschedule
		}
		/// <summary>
		/// Gets or Sets BlockingFrequencyCapBehaviour
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum BlockingFrequencyCapBehaviourEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Caponcefinalized for "CapOnceFinalized"
			/// </summary>
			[EnumMember(Value = "CapOnceFinalized")]
			Caponcefinalized,

			/// <summary>
			/// Enum Caponcerejected for "CapOnceRejected"
			/// </summary>
			[EnumMember(Value = "CapOnceRejected")]
			Caponcerejected,

			/// <summary>
			/// Enum Capforperiod for "CapForPeriod"
			/// </summary>
			[EnumMember(Value = "CapForPeriod")]
			Capforperiod
		}
		/// <summary>
		/// Gets or Sets BlockingReason
		/// </summary>
		[DataMember(Name = "blockingReason", EmitDefaultValue = false)]
		public BlockingReasonEnum? BlockingReason { get; set; }
		/// <summary>
		/// Gets or Sets BlockingFrequencyCapBehaviour
		/// </summary>
		[DataMember(Name = "blockingFrequencyCapBehaviour", EmitDefaultValue = false)]
		public BlockingFrequencyCapBehaviourEnum? BlockingFrequencyCapBehaviour { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyWebActionEventsNotificationBlockedWebActionOfferMessage" /> class.
		/// </summary>
		/// <param name="Action">Action.</param>
		/// <param name="ActionMap">ActionMap.</param>
		/// <param name="ActionTarget">ActionTarget.</param>
		/// <param name="BlockingReason">BlockingReason.</param>
		/// <param name="BlockingActionMap">BlockingActionMap.</param>
		/// <param name="BlockingAction">BlockingAction.</param>
		/// <param name="BlockingFrequencyCapBehaviour">BlockingFrequencyCapBehaviour.</param>
		/// <param name="BlockingPageUrlConditions">BlockingPageUrlConditions.</param>
		/// <param name="BlockingScheduleGroup">BlockingScheduleGroup.</param>
		/// <param name="BlockingEmergencyScheduleGroup">BlockingEmergencyScheduleGroup.</param>
		public JourneyWebActionEventsNotificationBlockedWebActionOfferMessage(JourneyWebActionEventsNotificationEventAction Action = null, JourneyWebActionEventsNotificationActionMap ActionMap = null, JourneyWebActionEventsNotificationActionTarget ActionTarget = null, BlockingReasonEnum? BlockingReason = null, JourneyWebActionEventsNotificationActionMap BlockingActionMap = null, JourneyWebActionEventsNotificationEventAction BlockingAction = null, BlockingFrequencyCapBehaviourEnum? BlockingFrequencyCapBehaviour = null, List<JourneyWebActionEventsNotificationActionMapPageUrlCondition> BlockingPageUrlConditions = null, JourneyWebActionEventsNotificationScheduleGroup BlockingScheduleGroup = null, JourneyWebActionEventsNotificationEmergencyGroup BlockingEmergencyScheduleGroup = null)
		{
			this.Action = Action;
			this.ActionMap = ActionMap;
			this.ActionTarget = ActionTarget;
			this.BlockingReason = BlockingReason;
			this.BlockingActionMap = BlockingActionMap;
			this.BlockingAction = BlockingAction;
			this.BlockingFrequencyCapBehaviour = BlockingFrequencyCapBehaviour;
			this.BlockingPageUrlConditions = BlockingPageUrlConditions;
			this.BlockingScheduleGroup = BlockingScheduleGroup;
			this.BlockingEmergencyScheduleGroup = BlockingEmergencyScheduleGroup;

		}



		/// <summary>
		/// Gets or Sets Action
		/// </summary>
		[DataMember(Name = "action", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationEventAction Action { get; set; }



		/// <summary>
		/// Gets or Sets ActionMap
		/// </summary>
		[DataMember(Name = "actionMap", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationActionMap ActionMap { get; set; }



		/// <summary>
		/// Gets or Sets ActionTarget
		/// </summary>
		[DataMember(Name = "actionTarget", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationActionTarget ActionTarget { get; set; }





		/// <summary>
		/// Gets or Sets BlockingActionMap
		/// </summary>
		[DataMember(Name = "blockingActionMap", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationActionMap BlockingActionMap { get; set; }



		/// <summary>
		/// Gets or Sets BlockingAction
		/// </summary>
		[DataMember(Name = "blockingAction", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationEventAction BlockingAction { get; set; }





		/// <summary>
		/// Gets or Sets BlockingPageUrlConditions
		/// </summary>
		[DataMember(Name = "blockingPageUrlConditions", EmitDefaultValue = false)]
		public List<JourneyWebActionEventsNotificationActionMapPageUrlCondition> BlockingPageUrlConditions { get; set; }



		/// <summary>
		/// Gets or Sets BlockingScheduleGroup
		/// </summary>
		[DataMember(Name = "blockingScheduleGroup", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationScheduleGroup BlockingScheduleGroup { get; set; }



		/// <summary>
		/// Gets or Sets BlockingEmergencyScheduleGroup
		/// </summary>
		[DataMember(Name = "blockingEmergencyScheduleGroup", EmitDefaultValue = false)]
		public JourneyWebActionEventsNotificationEmergencyGroup BlockingEmergencyScheduleGroup { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyWebActionEventsNotificationBlockedWebActionOfferMessage {\n");

			sb.Append("  Action: ").Append(Action).Append("\n");
			sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
			sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
			sb.Append("  BlockingReason: ").Append(BlockingReason).Append("\n");
			sb.Append("  BlockingActionMap: ").Append(BlockingActionMap).Append("\n");
			sb.Append("  BlockingAction: ").Append(BlockingAction).Append("\n");
			sb.Append("  BlockingFrequencyCapBehaviour: ").Append(BlockingFrequencyCapBehaviour).Append("\n");
			sb.Append("  BlockingPageUrlConditions: ").Append(BlockingPageUrlConditions).Append("\n");
			sb.Append("  BlockingScheduleGroup: ").Append(BlockingScheduleGroup).Append("\n");
			sb.Append("  BlockingEmergencyScheduleGroup: ").Append(BlockingEmergencyScheduleGroup).Append("\n");
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
			return this.Equals(obj as JourneyWebActionEventsNotificationBlockedWebActionOfferMessage);
		}

		/// <summary>
		/// Returns true if JourneyWebActionEventsNotificationBlockedWebActionOfferMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyWebActionEventsNotificationBlockedWebActionOfferMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyWebActionEventsNotificationBlockedWebActionOfferMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Action == other.Action ||
					this.Action != null &&
					this.Action.Equals(other.Action)
				) &&
				(
					this.ActionMap == other.ActionMap ||
					this.ActionMap != null &&
					this.ActionMap.Equals(other.ActionMap)
				) &&
				(
					this.ActionTarget == other.ActionTarget ||
					this.ActionTarget != null &&
					this.ActionTarget.Equals(other.ActionTarget)
				) &&
				(
					this.BlockingReason == other.BlockingReason ||
					this.BlockingReason != null &&
					this.BlockingReason.Equals(other.BlockingReason)
				) &&
				(
					this.BlockingActionMap == other.BlockingActionMap ||
					this.BlockingActionMap != null &&
					this.BlockingActionMap.Equals(other.BlockingActionMap)
				) &&
				(
					this.BlockingAction == other.BlockingAction ||
					this.BlockingAction != null &&
					this.BlockingAction.Equals(other.BlockingAction)
				) &&
				(
					this.BlockingFrequencyCapBehaviour == other.BlockingFrequencyCapBehaviour ||
					this.BlockingFrequencyCapBehaviour != null &&
					this.BlockingFrequencyCapBehaviour.Equals(other.BlockingFrequencyCapBehaviour)
				) &&
				(
					this.BlockingPageUrlConditions == other.BlockingPageUrlConditions ||
					this.BlockingPageUrlConditions != null &&
					this.BlockingPageUrlConditions.SequenceEqual(other.BlockingPageUrlConditions)
				) &&
				(
					this.BlockingScheduleGroup == other.BlockingScheduleGroup ||
					this.BlockingScheduleGroup != null &&
					this.BlockingScheduleGroup.Equals(other.BlockingScheduleGroup)
				) &&
				(
					this.BlockingEmergencyScheduleGroup == other.BlockingEmergencyScheduleGroup ||
					this.BlockingEmergencyScheduleGroup != null &&
					this.BlockingEmergencyScheduleGroup.Equals(other.BlockingEmergencyScheduleGroup)
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
				if (this.Action != null)
					hash = hash * 59 + this.Action.GetHashCode();

				if (this.ActionMap != null)
					hash = hash * 59 + this.ActionMap.GetHashCode();

				if (this.ActionTarget != null)
					hash = hash * 59 + this.ActionTarget.GetHashCode();

				if (this.BlockingReason != null)
					hash = hash * 59 + this.BlockingReason.GetHashCode();

				if (this.BlockingActionMap != null)
					hash = hash * 59 + this.BlockingActionMap.GetHashCode();

				if (this.BlockingAction != null)
					hash = hash * 59 + this.BlockingAction.GetHashCode();

				if (this.BlockingFrequencyCapBehaviour != null)
					hash = hash * 59 + this.BlockingFrequencyCapBehaviour.GetHashCode();

				if (this.BlockingPageUrlConditions != null)
					hash = hash * 59 + this.BlockingPageUrlConditions.GetHashCode();

				if (this.BlockingScheduleGroup != null)
					hash = hash * 59 + this.BlockingScheduleGroup.GetHashCode();

				if (this.BlockingEmergencyScheduleGroup != null)
					hash = hash * 59 + this.BlockingEmergencyScheduleGroup.GetHashCode();

				return hash;
			}
		}
	}

}
