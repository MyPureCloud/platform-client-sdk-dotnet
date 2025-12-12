using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FeedbackUpdateRequest
	/// </summary>
	[DataContract]
	public partial class FeedbackUpdateRequest : IEquatable<FeedbackUpdateRequest>
	{
		/// <summary>
		/// Agent’s rating for the system-generated summary.
		/// </summary>
		/// <value>Agent’s rating for the system-generated summary.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum RatingEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Positive for "Positive"
			/// </summary>
			[EnumMember(Value = "Positive")]
			Positive,

			/// <summary>
			/// Enum Negative for "Negative"
			/// </summary>
			[EnumMember(Value = "Negative")]
			Negative,

			/// <summary>
			/// Enum Unknown for "Unknown"
			/// </summary>
			[EnumMember(Value = "Unknown")]
			Unknown
		}
		/// <summary>
		/// Agent’s rating for the system-generated summary.
		/// </summary>
		/// <value>Agent’s rating for the system-generated summary.</value>
		[DataMember(Name = "rating", EmitDefaultValue = false)]
		public RatingEnum? Rating { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FeedbackUpdateRequest" /> class.
		/// </summary>
		/// <param name="Rating">Agent’s rating for the system-generated summary..</param>
		/// <param name="Summary">Agent&#39;s summary for the conversation.</param>
		public FeedbackUpdateRequest(RatingEnum? Rating = null, string Summary = null)
		{
			this.Rating = Rating;
			this.Summary = Summary;

		}





		/// <summary>
		/// Agent&#39;s summary for the conversation
		/// </summary>
		/// <value>Agent&#39;s summary for the conversation</value>
		[DataMember(Name = "summary", EmitDefaultValue = false)]
		public string Summary { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FeedbackUpdateRequest {\n");

			sb.Append("  Rating: ").Append(Rating).Append("\n");
			sb.Append("  Summary: ").Append(Summary).Append("\n");
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
			return this.Equals(obj as FeedbackUpdateRequest);
		}

		/// <summary>
		/// Returns true if FeedbackUpdateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of FeedbackUpdateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FeedbackUpdateRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Rating == other.Rating ||
					this.Rating != null &&
					this.Rating.Equals(other.Rating)
				) &&
				(
					this.Summary == other.Summary ||
					this.Summary != null &&
					this.Summary.Equals(other.Summary)
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
				if (this.Rating != null)
					hash = hash * 59 + this.Rating.GetHashCode();

				if (this.Summary != null)
					hash = hash * 59 + this.Summary.GetHashCode();

				return hash;
			}
		}
	}

}
