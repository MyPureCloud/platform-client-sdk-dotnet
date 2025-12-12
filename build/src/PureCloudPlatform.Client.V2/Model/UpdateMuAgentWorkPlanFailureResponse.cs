using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateMuAgentWorkPlanFailureResponse
	/// </summary>
	[DataContract]
	public partial class UpdateMuAgentWorkPlanFailureResponse : IEquatable<UpdateMuAgentWorkPlanFailureResponse>
	{
		/// <summary>
		/// The work plan update failure reason
		/// </summary>
		/// <value>The work plan update failure reason</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FailureEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Agentnotinmanagementunit for "AgentNotInManagementUnit"
			/// </summary>
			[EnumMember(Value = "AgentNotInManagementUnit")]
			Agentnotinmanagementunit,

			/// <summary>
			/// Enum Overlappingoverride for "OverlappingOverride"
			/// </summary>
			[EnumMember(Value = "OverlappingOverride")]
			Overlappingoverride,

			/// <summary>
			/// Enum Overridenotfound for "OverrideNotFound"
			/// </summary>
			[EnumMember(Value = "OverrideNotFound")]
			Overridenotfound,

			/// <summary>
			/// Enum Toomanyoverrides for "TooManyOverrides"
			/// </summary>
			[EnumMember(Value = "TooManyOverrides")]
			Toomanyoverrides,

			/// <summary>
			/// Enum Workplannotfound for "WorkPlanNotFound"
			/// </summary>
			[EnumMember(Value = "WorkPlanNotFound")]
			Workplannotfound
		}
		/// <summary>
		/// The work plan update failure reason
		/// </summary>
		/// <value>The work plan update failure reason</value>
		[DataMember(Name = "failure", EmitDefaultValue = false)]
		public FailureEnum? Failure { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlanFailureResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateMuAgentWorkPlanFailureResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateMuAgentWorkPlanFailureResponse" /> class.
		/// </summary>
		/// <param name="User">The user for whom the work plan update has failed (required).</param>
		/// <param name="Failure">The work plan update failure reason (required).</param>
		/// <param name="NotFoundWorkPlanId">The id of the work plan that has not been found.</param>
		public UpdateMuAgentWorkPlanFailureResponse(UserReference User = null, FailureEnum? Failure = null, string NotFoundWorkPlanId = null)
		{
			this.User = User;
			this.Failure = Failure;
			this.NotFoundWorkPlanId = NotFoundWorkPlanId;

		}



		/// <summary>
		/// The user for whom the work plan update has failed
		/// </summary>
		/// <value>The user for whom the work plan update has failed</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserReference User { get; set; }





		/// <summary>
		/// The id of the work plan that has not been found
		/// </summary>
		/// <value>The id of the work plan that has not been found</value>
		[DataMember(Name = "notFoundWorkPlanId", EmitDefaultValue = false)]
		public string NotFoundWorkPlanId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateMuAgentWorkPlanFailureResponse {\n");

			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  Failure: ").Append(Failure).Append("\n");
			sb.Append("  NotFoundWorkPlanId: ").Append(NotFoundWorkPlanId).Append("\n");
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
			return this.Equals(obj as UpdateMuAgentWorkPlanFailureResponse);
		}

		/// <summary>
		/// Returns true if UpdateMuAgentWorkPlanFailureResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateMuAgentWorkPlanFailureResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateMuAgentWorkPlanFailureResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.Failure == other.Failure ||
					this.Failure != null &&
					this.Failure.Equals(other.Failure)
				) &&
				(
					this.NotFoundWorkPlanId == other.NotFoundWorkPlanId ||
					this.NotFoundWorkPlanId != null &&
					this.NotFoundWorkPlanId.Equals(other.NotFoundWorkPlanId)
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
				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.Failure != null)
					hash = hash * 59 + this.Failure.GetHashCode();

				if (this.NotFoundWorkPlanId != null)
					hash = hash * 59 + this.NotFoundWorkPlanId.GetHashCode();

				return hash;
			}
		}
	}

}
