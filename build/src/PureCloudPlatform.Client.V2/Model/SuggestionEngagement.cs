using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SuggestionEngagement
	/// </summary>
	[DataContract]
	public partial class SuggestionEngagement : IEquatable<SuggestionEngagement>
	{
		/// <summary>
		/// The type of engagement with the suggestion.
		/// </summary>
		/// <value>The type of engagement with the suggestion.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EngagementTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Dismissed for "Dismissed"
			/// </summary>
			[EnumMember(Value = "Dismissed")]
			Dismissed,

			/// <summary>
			/// Enum Copied for "Copied"
			/// </summary>
			[EnumMember(Value = "Copied")]
			Copied,

			/// <summary>
			/// Enum Opened for "Opened"
			/// </summary>
			[EnumMember(Value = "Opened")]
			Opened,

			/// <summary>
			/// Enum Feedback for "Feedback"
			/// </summary>
			[EnumMember(Value = "Feedback")]
			Feedback
		}
		/// <summary>
		/// The type of engagement with the suggestion.
		/// </summary>
		/// <value>The type of engagement with the suggestion.</value>
		[DataMember(Name = "engagementType", EmitDefaultValue = false)]
		public EngagementTypeEnum? EngagementType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SuggestionEngagement" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SuggestionEngagement() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SuggestionEngagement" /> class.
		/// </summary>
		/// <param name="EngagementType">The type of engagement with the suggestion. (required).</param>
		/// <param name="Feedback">The given feedback on the suggestion, if any..</param>
		public SuggestionEngagement(EngagementTypeEnum? EngagementType = null, SuggestionFeedback Feedback = null)
		{
			this.EngagementType = EngagementType;
			this.Feedback = Feedback;

		}





		/// <summary>
		/// The given feedback on the suggestion, if any.
		/// </summary>
		/// <value>The given feedback on the suggestion, if any.</value>
		[DataMember(Name = "feedback", EmitDefaultValue = false)]
		public SuggestionFeedback Feedback { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SuggestionEngagement {\n");

			sb.Append("  EngagementType: ").Append(EngagementType).Append("\n");
			sb.Append("  Feedback: ").Append(Feedback).Append("\n");
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
			return this.Equals(obj as SuggestionEngagement);
		}

		/// <summary>
		/// Returns true if SuggestionEngagement instances are equal
		/// </summary>
		/// <param name="other">Instance of SuggestionEngagement to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SuggestionEngagement other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EngagementType == other.EngagementType ||
					this.EngagementType != null &&
					this.EngagementType.Equals(other.EngagementType)
				) &&
				(
					this.Feedback == other.Feedback ||
					this.Feedback != null &&
					this.Feedback.Equals(other.Feedback)
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
				if (this.EngagementType != null)
					hash = hash * 59 + this.EngagementType.GetHashCode();

				if (this.Feedback != null)
					hash = hash * 59 + this.Feedback.GetHashCode();

				return hash;
			}
		}
	}

}
