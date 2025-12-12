using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage
	/// </summary>
	[DataContract]
	public partial class JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage : IEquatable<JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage>
	{
		/// <summary>
		/// Gets or Sets AssignmentState
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AssignmentStateEnum
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
			/// Enum Assigned for "Assigned"
			/// </summary>
			[EnumMember(Value = "Assigned")]
			Assigned,

			/// <summary>
			/// Enum Unassigned for "Unassigned"
			/// </summary>
			[EnumMember(Value = "Unassigned")]
			Unassigned
		}
		/// <summary>
		/// Gets or Sets AssignmentState
		/// </summary>
		[DataMember(Name = "assignmentState", EmitDefaultValue = false)]
		public AssignmentStateEnum? AssignmentState { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage" /> class.
		/// </summary>
		/// <param name="Segment">Segment.</param>
		/// <param name="AssignmentState">AssignmentState.</param>
		/// <param name="DateAssigned">DateAssigned.</param>
		/// <param name="DateForUnassignment">DateForUnassignment.</param>
		public JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage(JourneySegmentAssignmentEventsNotificationSegment Segment = null, AssignmentStateEnum? AssignmentState = null, DateTime? DateAssigned = null, DateTime? DateForUnassignment = null)
		{
			this.Segment = Segment;
			this.AssignmentState = AssignmentState;
			this.DateAssigned = DateAssigned;
			this.DateForUnassignment = DateForUnassignment;

		}



		/// <summary>
		/// Gets or Sets Segment
		/// </summary>
		[DataMember(Name = "segment", EmitDefaultValue = false)]
		public JourneySegmentAssignmentEventsNotificationSegment Segment { get; set; }





		/// <summary>
		/// Gets or Sets DateAssigned
		/// </summary>
		[DataMember(Name = "dateAssigned", EmitDefaultValue = false)]
		public DateTime? DateAssigned { get; set; }



		/// <summary>
		/// Gets or Sets DateForUnassignment
		/// </summary>
		[DataMember(Name = "dateForUnassignment", EmitDefaultValue = false)]
		public DateTime? DateForUnassignment { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage {\n");

			sb.Append("  Segment: ").Append(Segment).Append("\n");
			sb.Append("  AssignmentState: ").Append(AssignmentState).Append("\n");
			sb.Append("  DateAssigned: ").Append(DateAssigned).Append("\n");
			sb.Append("  DateForUnassignment: ").Append(DateForUnassignment).Append("\n");
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
			return this.Equals(obj as JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage);
		}

		/// <summary>
		/// Returns true if JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneySegmentAssignmentEventsNotificationSegmentAssignmentMessage other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Segment == other.Segment ||
					this.Segment != null &&
					this.Segment.Equals(other.Segment)
				) &&
				(
					this.AssignmentState == other.AssignmentState ||
					this.AssignmentState != null &&
					this.AssignmentState.Equals(other.AssignmentState)
				) &&
				(
					this.DateAssigned == other.DateAssigned ||
					this.DateAssigned != null &&
					this.DateAssigned.Equals(other.DateAssigned)
				) &&
				(
					this.DateForUnassignment == other.DateForUnassignment ||
					this.DateForUnassignment != null &&
					this.DateForUnassignment.Equals(other.DateForUnassignment)
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
				if (this.Segment != null)
					hash = hash * 59 + this.Segment.GetHashCode();

				if (this.AssignmentState != null)
					hash = hash * 59 + this.AssignmentState.GetHashCode();

				if (this.DateAssigned != null)
					hash = hash * 59 + this.DateAssigned.GetHashCode();

				if (this.DateForUnassignment != null)
					hash = hash * 59 + this.DateForUnassignment.GetHashCode();

				return hash;
			}
		}
	}

}
