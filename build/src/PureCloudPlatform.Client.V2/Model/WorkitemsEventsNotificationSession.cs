using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemsEventsNotificationSession
	/// </summary>
	[DataContract]
	public partial class WorkitemsEventsNotificationSession : IEquatable<WorkitemsEventsNotificationSession>
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
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
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Agent for "Agent"
			/// </summary>
			[EnumMember(Value = "Agent")]
			Agent,

			/// <summary>
			/// Enum Queueassignment for "QueueAssignment"
			/// </summary>
			[EnumMember(Value = "QueueAssignment")]
			Queueassignment,

			/// <summary>
			/// Enum Directassignment for "DirectAssignment"
			/// </summary>
			[EnumMember(Value = "DirectAssignment")]
			Directassignment,

			/// <summary>
			/// Enum Agentcomplete for "AgentComplete"
			/// </summary>
			[EnumMember(Value = "AgentComplete")]
			Agentcomplete
		}
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
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
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown,

			/// <summary>
			/// Enum Active for "Active"
			/// </summary>
			[EnumMember(Value = "Active")]
			Active,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed
		}
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemsEventsNotificationSession" /> class.
		/// </summary>
		/// <param name="Type">Type.</param>
		/// <param name="Id">Id.</param>
		/// <param name="Status">Status.</param>
		/// <param name="DateSessionStart">DateSessionStart.</param>
		/// <param name="DateSessionEnd">DateSessionEnd.</param>
		/// <param name="AssignmentSegments">AssignmentSegments.</param>
		public WorkitemsEventsNotificationSession(TypeEnum? Type = null, Guid? Id = null, StatusEnum? Status = null, string DateSessionStart = null, string DateSessionEnd = null, List<WorkitemsEventsNotificationAssignmentSegment> AssignmentSegments = null)
		{
			this.Type = Type;
			this.Id = Id;
			this.Status = Status;
			this.DateSessionStart = DateSessionStart;
			this.DateSessionEnd = DateSessionEnd;
			this.AssignmentSegments = AssignmentSegments;

		}





		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Guid? Id { get; set; }





		/// <summary>
		/// Gets or Sets DateSessionStart
		/// </summary>
		[DataMember(Name = "dateSessionStart", EmitDefaultValue = false)]
		public string DateSessionStart { get; set; }



		/// <summary>
		/// Gets or Sets DateSessionEnd
		/// </summary>
		[DataMember(Name = "dateSessionEnd", EmitDefaultValue = false)]
		public string DateSessionEnd { get; set; }



		/// <summary>
		/// Gets or Sets AssignmentSegments
		/// </summary>
		[DataMember(Name = "assignmentSegments", EmitDefaultValue = false)]
		public List<WorkitemsEventsNotificationAssignmentSegment> AssignmentSegments { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemsEventsNotificationSession {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  DateSessionStart: ").Append(DateSessionStart).Append("\n");
			sb.Append("  DateSessionEnd: ").Append(DateSessionEnd).Append("\n");
			sb.Append("  AssignmentSegments: ").Append(AssignmentSegments).Append("\n");
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
			return this.Equals(obj as WorkitemsEventsNotificationSession);
		}

		/// <summary>
		/// Returns true if WorkitemsEventsNotificationSession instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemsEventsNotificationSession to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemsEventsNotificationSession other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.DateSessionStart == other.DateSessionStart ||
					this.DateSessionStart != null &&
					this.DateSessionStart.Equals(other.DateSessionStart)
				) &&
				(
					this.DateSessionEnd == other.DateSessionEnd ||
					this.DateSessionEnd != null &&
					this.DateSessionEnd.Equals(other.DateSessionEnd)
				) &&
				(
					this.AssignmentSegments == other.AssignmentSegments ||
					this.AssignmentSegments != null &&
					this.AssignmentSegments.SequenceEqual(other.AssignmentSegments)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.DateSessionStart != null)
					hash = hash * 59 + this.DateSessionStart.GetHashCode();

				if (this.DateSessionEnd != null)
					hash = hash * 59 + this.DateSessionEnd.GetHashCode();

				if (this.AssignmentSegments != null)
					hash = hash * 59 + this.AssignmentSegments.GetHashCode();

				return hash;
			}
		}
	}

}
