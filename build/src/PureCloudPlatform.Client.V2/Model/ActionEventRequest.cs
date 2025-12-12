using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ActionEventRequest
	/// </summary>
	[DataContract]
	public partial class ActionEventRequest : IEquatable<ActionEventRequest>
	{
		/// <summary>
		/// State the action is transitioning to.
		/// </summary>
		/// <value>State the action is transitioning to.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionStateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Accepted for "accepted"
			/// </summary>
			[EnumMember(Value = "accepted")]
			Accepted,

			/// <summary>
			/// Enum Rejected for "rejected"
			/// </summary>
			[EnumMember(Value = "rejected")]
			Rejected,

			/// <summary>
			/// Enum Timedout for "timedout"
			/// </summary>
			[EnumMember(Value = "timedout")]
			Timedout,

			/// <summary>
			/// Enum Errored for "errored"
			/// </summary>
			[EnumMember(Value = "errored")]
			Errored,

			/// <summary>
			/// Enum Ignored for "ignored"
			/// </summary>
			[EnumMember(Value = "ignored")]
			Ignored,

			/// <summary>
			/// Enum Qualified for "qualified"
			/// </summary>
			[EnumMember(Value = "qualified")]
			Qualified,

			/// <summary>
			/// Enum Offered for "offered"
			/// </summary>
			[EnumMember(Value = "offered")]
			Offered,

			/// <summary>
			/// Enum Started for "started"
			/// </summary>
			[EnumMember(Value = "started")]
			Started,

			/// <summary>
			/// Enum Engaged for "engaged"
			/// </summary>
			[EnumMember(Value = "engaged")]
			Engaged,

			/// <summary>
			/// Enum Qualifiedoutsideschedule for "qualifiedOutsideSchedule"
			/// </summary>
			[EnumMember(Value = "qualifiedOutsideSchedule")]
			Qualifiedoutsideschedule,

			/// <summary>
			/// Enum Offeredoutsideschedule for "offeredOutsideSchedule"
			/// </summary>
			[EnumMember(Value = "offeredOutsideSchedule")]
			Offeredoutsideschedule,

			/// <summary>
			/// Enum Abandoned for "abandoned"
			/// </summary>
			[EnumMember(Value = "abandoned")]
			Abandoned,

			/// <summary>
			/// Enum Completed for "completed"
			/// </summary>
			[EnumMember(Value = "completed")]
			Completed,

			/// <summary>
			/// Enum Frequencycapreached for "frequencyCapReached"
			/// </summary>
			[EnumMember(Value = "frequencyCapReached")]
			Frequencycapreached
		}
		/// <summary>
		/// State the action is transitioning to.
		/// </summary>
		/// <value>State the action is transitioning to.</value>
		[DataMember(Name = "actionState", EmitDefaultValue = false)]
		public ActionStateEnum? ActionState { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionEventRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ActionEventRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ActionEventRequest" /> class.
		/// </summary>
		/// <param name="SessionId">UUID of the customer session for this action. (required).</param>
		/// <param name="ActionId">UUID for the action, as returned by the Ping endpoint when the action was qualified. (required).</param>
		/// <param name="ActionState">State the action is transitioning to. (required).</param>
		/// <param name="ErrorCode">Client defined error code (when state transitions to errored).</param>
		/// <param name="ErrorMessage">Message of the error returned when the action fails (when state transitions to errored).</param>
		public ActionEventRequest(string SessionId = null, string ActionId = null, ActionStateEnum? ActionState = null, string ErrorCode = null, string ErrorMessage = null)
		{
			this.SessionId = SessionId;
			this.ActionId = ActionId;
			this.ActionState = ActionState;
			this.ErrorCode = ErrorCode;
			this.ErrorMessage = ErrorMessage;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// UUID of the customer session for this action.
		/// </summary>
		/// <value>UUID of the customer session for this action.</value>
		[DataMember(Name = "sessionId", EmitDefaultValue = false)]
		public string SessionId { get; set; }



		/// <summary>
		/// UUID for the action, as returned by the Ping endpoint when the action was qualified.
		/// </summary>
		/// <value>UUID for the action, as returned by the Ping endpoint when the action was qualified.</value>
		[DataMember(Name = "actionId", EmitDefaultValue = false)]
		public string ActionId { get; set; }





		/// <summary>
		/// Client defined error code (when state transitions to errored)
		/// </summary>
		/// <value>Client defined error code (when state transitions to errored)</value>
		[DataMember(Name = "errorCode", EmitDefaultValue = false)]
		public string ErrorCode { get; set; }



		/// <summary>
		/// Message of the error returned when the action fails (when state transitions to errored)
		/// </summary>
		/// <value>Message of the error returned when the action fails (when state transitions to errored)</value>
		[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
		public string ErrorMessage { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ActionEventRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  SessionId: ").Append(SessionId).Append("\n");
			sb.Append("  ActionId: ").Append(ActionId).Append("\n");
			sb.Append("  ActionState: ").Append(ActionState).Append("\n");
			sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
			sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
			return this.Equals(obj as ActionEventRequest);
		}

		/// <summary>
		/// Returns true if ActionEventRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ActionEventRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ActionEventRequest other)
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
					this.SessionId == other.SessionId ||
					this.SessionId != null &&
					this.SessionId.Equals(other.SessionId)
				) &&
				(
					this.ActionId == other.ActionId ||
					this.ActionId != null &&
					this.ActionId.Equals(other.ActionId)
				) &&
				(
					this.ActionState == other.ActionState ||
					this.ActionState != null &&
					this.ActionState.Equals(other.ActionState)
				) &&
				(
					this.ErrorCode == other.ErrorCode ||
					this.ErrorCode != null &&
					this.ErrorCode.Equals(other.ErrorCode)
				) &&
				(
					this.ErrorMessage == other.ErrorMessage ||
					this.ErrorMessage != null &&
					this.ErrorMessage.Equals(other.ErrorMessage)
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

				if (this.SessionId != null)
					hash = hash * 59 + this.SessionId.GetHashCode();

				if (this.ActionId != null)
					hash = hash * 59 + this.ActionId.GetHashCode();

				if (this.ActionState != null)
					hash = hash * 59 + this.ActionState.GetHashCode();

				if (this.ErrorCode != null)
					hash = hash * 59 + this.ErrorCode.GetHashCode();

				if (this.ErrorMessage != null)
					hash = hash * 59 + this.ErrorMessage.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
