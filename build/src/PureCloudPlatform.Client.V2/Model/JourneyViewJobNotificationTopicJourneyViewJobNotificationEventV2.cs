using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2
	/// </summary>
	[DataContract]
	public partial class JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2 : IEquatable<JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2>
	{
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
			/// Enum Accepted for "Accepted"
			/// </summary>
			[EnumMember(Value = "Accepted")]
			Accepted,

			/// <summary>
			/// Enum Executing for "Executing"
			/// </summary>
			[EnumMember(Value = "Executing")]
			Executing,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Cancelled for "Cancelled"
			/// </summary>
			[EnumMember(Value = "Cancelled")]
			Cancelled,

			/// <summary>
			/// Enum Scheduled for "Scheduled"
			/// </summary>
			[EnumMember(Value = "Scheduled")]
			Scheduled
		}
		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Status">Status.</param>
		/// <param name="DateCreated">DateCreated.</param>
		/// <param name="DateCompleted">DateCompleted.</param>
		/// <param name="JourneyView">JourneyView.</param>
		/// <param name="DateCompletionEstimated">DateCompletionEstimated.</param>
		/// <param name="EstimatedCompletionMargin">EstimatedCompletionMargin.</param>
		/// <param name="UserId">UserId.</param>
		public JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2(Guid? Id = null, StatusEnum? Status = null, string DateCreated = null, string DateCompleted = null, JourneyViewJobNotificationTopicJourneyView JourneyView = null, string DateCompletionEstimated = null, long? EstimatedCompletionMargin = null, string UserId = null)
		{
			this.Id = Id;
			this.Status = Status;
			this.DateCreated = DateCreated;
			this.DateCompleted = DateCompleted;
			this.JourneyView = JourneyView;
			this.DateCompletionEstimated = DateCompletionEstimated;
			this.EstimatedCompletionMargin = EstimatedCompletionMargin;
			this.UserId = UserId;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Guid? Id { get; set; }





		/// <summary>
		/// Gets or Sets DateCreated
		/// </summary>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public string DateCreated { get; set; }



		/// <summary>
		/// Gets or Sets DateCompleted
		/// </summary>
		[DataMember(Name = "dateCompleted", EmitDefaultValue = false)]
		public string DateCompleted { get; set; }



		/// <summary>
		/// Gets or Sets JourneyView
		/// </summary>
		[DataMember(Name = "journeyView", EmitDefaultValue = false)]
		public JourneyViewJobNotificationTopicJourneyView JourneyView { get; set; }



		/// <summary>
		/// Gets or Sets DateCompletionEstimated
		/// </summary>
		[DataMember(Name = "dateCompletionEstimated", EmitDefaultValue = false)]
		public string DateCompletionEstimated { get; set; }



		/// <summary>
		/// Gets or Sets EstimatedCompletionMargin
		/// </summary>
		[DataMember(Name = "estimatedCompletionMargin", EmitDefaultValue = false)]
		public long? EstimatedCompletionMargin { get; set; }



		/// <summary>
		/// Gets or Sets UserId
		/// </summary>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2 {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
			sb.Append("  JourneyView: ").Append(JourneyView).Append("\n");
			sb.Append("  DateCompletionEstimated: ").Append(DateCompletionEstimated).Append("\n");
			sb.Append("  EstimatedCompletionMargin: ").Append(EstimatedCompletionMargin).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
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
			return this.Equals(obj as JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2);
		}

		/// <summary>
		/// Returns true if JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2 instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2 to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyViewJobNotificationTopicJourneyViewJobNotificationEventV2 other)
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
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateCompleted == other.DateCompleted ||
					this.DateCompleted != null &&
					this.DateCompleted.Equals(other.DateCompleted)
				) &&
				(
					this.JourneyView == other.JourneyView ||
					this.JourneyView != null &&
					this.JourneyView.Equals(other.JourneyView)
				) &&
				(
					this.DateCompletionEstimated == other.DateCompletionEstimated ||
					this.DateCompletionEstimated != null &&
					this.DateCompletionEstimated.Equals(other.DateCompletionEstimated)
				) &&
				(
					this.EstimatedCompletionMargin == other.EstimatedCompletionMargin ||
					this.EstimatedCompletionMargin != null &&
					this.EstimatedCompletionMargin.Equals(other.EstimatedCompletionMargin)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
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

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateCompleted != null)
					hash = hash * 59 + this.DateCompleted.GetHashCode();

				if (this.JourneyView != null)
					hash = hash * 59 + this.JourneyView.GetHashCode();

				if (this.DateCompletionEstimated != null)
					hash = hash * 59 + this.DateCompletionEstimated.GetHashCode();

				if (this.EstimatedCompletionMargin != null)
					hash = hash * 59 + this.EstimatedCompletionMargin.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				return hash;
			}
		}
	}

}
