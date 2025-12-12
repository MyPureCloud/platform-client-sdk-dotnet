using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Annotation
	/// </summary>
	[DataContract]
	public partial class Annotation : IEquatable<Annotation>
	{
		/// <summary>
		/// Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause
		/// </summary>
		/// <value>Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ReasonEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Hold for "Hold"
			/// </summary>
			[EnumMember(Value = "Hold")]
			Hold,

			/// <summary>
			/// Enum Securepause for "SecurePause"
			/// </summary>
			[EnumMember(Value = "SecurePause")]
			Securepause,

			/// <summary>
			/// Enum Floworqueue for "FlowOrQueue"
			/// </summary>
			[EnumMember(Value = "FlowOrQueue")]
			Floworqueue,

			/// <summary>
			/// Enum Pause for "Pause"
			/// </summary>
			[EnumMember(Value = "Pause")]
			Pause
		}
		/// <summary>
		/// Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause
		/// </summary>
		/// <value>Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause</value>
		[DataMember(Name = "reason", EmitDefaultValue = false)]
		public ReasonEnum? Reason { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="Annotation" /> class.
		/// </summary>
		/// <param name="Id">Annotation id. All pause annotations on a recording will share an ID value, bookmark annotations will have unique IDs, and hold annotations will have randomly generated UUIDs (i.e. the ID will change at each request)..</param>
		/// <param name="Name">Name.</param>
		/// <param name="Type">Type.</param>
		/// <param name="Location">Offset of annotation in milliseconds..</param>
		/// <param name="DurationMs">Duration of annotation in milliseconds..</param>
		/// <param name="AbsoluteLocation">Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses)..</param>
		/// <param name="AbsoluteDurationMs">Duration of annotation (milliseconds)..</param>
		/// <param name="RecordingLocation">Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts.</param>
		/// <param name="RecordingDurationMs">Duration of annotation (milliseconds), adjusted for any recording cuts..</param>
		/// <param name="User">User that created this annotation (if any)..</param>
		/// <param name="Description">Text of annotation. Maximum character limit is 500..</param>
		public Annotation(string Id = null, string Name = null, string Type = null, long? Location = null, long? DurationMs = null, long? AbsoluteLocation = null, long? AbsoluteDurationMs = null, long? RecordingLocation = null, long? RecordingDurationMs = null, User User = null, string Description = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Type = Type;
			this.Location = Location;
			this.DurationMs = DurationMs;
			this.AbsoluteLocation = AbsoluteLocation;
			this.AbsoluteDurationMs = AbsoluteDurationMs;
			this.RecordingLocation = RecordingLocation;
			this.RecordingDurationMs = RecordingDurationMs;
			this.User = User;
			this.Description = Description;

		}



		/// <summary>
		/// Annotation id. All pause annotations on a recording will share an ID value, bookmark annotations will have unique IDs, and hold annotations will have randomly generated UUIDs (i.e. the ID will change at each request).
		/// </summary>
		/// <value>Annotation id. All pause annotations on a recording will share an ID value, bookmark annotations will have unique IDs, and hold annotations will have randomly generated UUIDs (i.e. the ID will change at each request).</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



		/// <summary>
		/// Offset of annotation in milliseconds.
		/// </summary>
		/// <value>Offset of annotation in milliseconds.</value>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public long? Location { get; set; }



		/// <summary>
		/// Duration of annotation in milliseconds.
		/// </summary>
		/// <value>Duration of annotation in milliseconds.</value>
		[DataMember(Name = "durationMs", EmitDefaultValue = false)]
		public long? DurationMs { get; set; }



		/// <summary>
		/// Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses).
		/// </summary>
		/// <value>Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses).</value>
		[DataMember(Name = "absoluteLocation", EmitDefaultValue = false)]
		public long? AbsoluteLocation { get; set; }



		/// <summary>
		/// Duration of annotation (milliseconds).
		/// </summary>
		/// <value>Duration of annotation (milliseconds).</value>
		[DataMember(Name = "absoluteDurationMs", EmitDefaultValue = false)]
		public long? AbsoluteDurationMs { get; set; }



		/// <summary>
		/// Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts
		/// </summary>
		/// <value>Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts</value>
		[DataMember(Name = "recordingLocation", EmitDefaultValue = false)]
		public long? RecordingLocation { get; set; }



		/// <summary>
		/// Duration of annotation (milliseconds), adjusted for any recording cuts.
		/// </summary>
		/// <value>Duration of annotation (milliseconds), adjusted for any recording cuts.</value>
		[DataMember(Name = "recordingDurationMs", EmitDefaultValue = false)]
		public long? RecordingDurationMs { get; set; }



		/// <summary>
		/// User that created this annotation (if any).
		/// </summary>
		/// <value>User that created this annotation (if any).</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public User User { get; set; }



		/// <summary>
		/// Text of annotation. Maximum character limit is 500.
		/// </summary>
		/// <value>Text of annotation. Maximum character limit is 500.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }





		/// <summary>
		/// List of annotations
		/// </summary>
		/// <value>List of annotations</value>
		[DataMember(Name = "annotations", EmitDefaultValue = false)]
		public List<Annotation> Annotations { get; private set; }



		/// <summary>
		/// Offset of annotation (milliseconds) from start of the recording before removing the cumulative duration of all pauses before this annotation
		/// </summary>
		/// <value>Offset of annotation (milliseconds) from start of the recording before removing the cumulative duration of all pauses before this annotation</value>
		[DataMember(Name = "realtimeLocation", EmitDefaultValue = false)]
		public long? RealtimeLocation { get; private set; }



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
			sb.Append("class Annotation {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
			sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
			sb.Append("  AbsoluteLocation: ").Append(AbsoluteLocation).Append("\n");
			sb.Append("  AbsoluteDurationMs: ").Append(AbsoluteDurationMs).Append("\n");
			sb.Append("  RecordingLocation: ").Append(RecordingLocation).Append("\n");
			sb.Append("  RecordingDurationMs: ").Append(RecordingDurationMs).Append("\n");
			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Reason: ").Append(Reason).Append("\n");
			sb.Append("  Annotations: ").Append(Annotations).Append("\n");
			sb.Append("  RealtimeLocation: ").Append(RealtimeLocation).Append("\n");
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
			return this.Equals(obj as Annotation);
		}

		/// <summary>
		/// Returns true if Annotation instances are equal
		/// </summary>
		/// <param name="other">Instance of Annotation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Annotation other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Location == other.Location ||
					this.Location != null &&
					this.Location.Equals(other.Location)
				) &&
				(
					this.DurationMs == other.DurationMs ||
					this.DurationMs != null &&
					this.DurationMs.Equals(other.DurationMs)
				) &&
				(
					this.AbsoluteLocation == other.AbsoluteLocation ||
					this.AbsoluteLocation != null &&
					this.AbsoluteLocation.Equals(other.AbsoluteLocation)
				) &&
				(
					this.AbsoluteDurationMs == other.AbsoluteDurationMs ||
					this.AbsoluteDurationMs != null &&
					this.AbsoluteDurationMs.Equals(other.AbsoluteDurationMs)
				) &&
				(
					this.RecordingLocation == other.RecordingLocation ||
					this.RecordingLocation != null &&
					this.RecordingLocation.Equals(other.RecordingLocation)
				) &&
				(
					this.RecordingDurationMs == other.RecordingDurationMs ||
					this.RecordingDurationMs != null &&
					this.RecordingDurationMs.Equals(other.RecordingDurationMs)
				) &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Reason == other.Reason ||
					this.Reason != null &&
					this.Reason.Equals(other.Reason)
				) &&
				(
					this.Annotations == other.Annotations ||
					this.Annotations != null &&
					this.Annotations.SequenceEqual(other.Annotations)
				) &&
				(
					this.RealtimeLocation == other.RealtimeLocation ||
					this.RealtimeLocation != null &&
					this.RealtimeLocation.Equals(other.RealtimeLocation)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Location != null)
					hash = hash * 59 + this.Location.GetHashCode();

				if (this.DurationMs != null)
					hash = hash * 59 + this.DurationMs.GetHashCode();

				if (this.AbsoluteLocation != null)
					hash = hash * 59 + this.AbsoluteLocation.GetHashCode();

				if (this.AbsoluteDurationMs != null)
					hash = hash * 59 + this.AbsoluteDurationMs.GetHashCode();

				if (this.RecordingLocation != null)
					hash = hash * 59 + this.RecordingLocation.GetHashCode();

				if (this.RecordingDurationMs != null)
					hash = hash * 59 + this.RecordingDurationMs.GetHashCode();

				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Reason != null)
					hash = hash * 59 + this.Reason.GetHashCode();

				if (this.Annotations != null)
					hash = hash * 59 + this.Annotations.GetHashCode();

				if (this.RealtimeLocation != null)
					hash = hash * 59 + this.RealtimeLocation.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
