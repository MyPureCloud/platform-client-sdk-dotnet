using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SentimentFeedback
	/// </summary>
	[DataContract]
	public partial class SentimentFeedback : IEquatable<SentimentFeedback>
	{
		/// <summary>
		/// The sentiment feedback value for the given phrase
		/// </summary>
		/// <value>The sentiment feedback value for the given phrase</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FeedbackValueEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Neutral for "Neutral"
			/// </summary>
			[EnumMember(Value = "Neutral")]
			Neutral,

			/// <summary>
			/// Enum Positive for "Positive"
			/// </summary>
			[EnumMember(Value = "Positive")]
			Positive,

			/// <summary>
			/// Enum Negative for "Negative"
			/// </summary>
			[EnumMember(Value = "Negative")]
			Negative
		}
		/// <summary>
		/// The sentiment feedback value for the given phrase
		/// </summary>
		/// <value>The sentiment feedback value for the given phrase</value>
		[DataMember(Name = "feedbackValue", EmitDefaultValue = false)]
		public FeedbackValueEnum? FeedbackValue { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SentimentFeedback" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SentimentFeedback() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SentimentFeedback" /> class.
		/// </summary>
		/// <param name="Phrase">The phrase for which sentiment feedback is provided (required).</param>
		/// <param name="Dialect">The dialect for the given phrase, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (required).</param>
		/// <param name="FeedbackValue">The sentiment feedback value for the given phrase (required).</param>
		public SentimentFeedback(string Phrase = null, string Dialect = null, FeedbackValueEnum? FeedbackValue = null)
		{
			this.Phrase = Phrase;
			this.Dialect = Dialect;
			this.FeedbackValue = FeedbackValue;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The phrase for which sentiment feedback is provided
		/// </summary>
		/// <value>The phrase for which sentiment feedback is provided</value>
		[DataMember(Name = "phrase", EmitDefaultValue = false)]
		public string Phrase { get; set; }



		/// <summary>
		/// The dialect for the given phrase, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard
		/// </summary>
		/// <value>The dialect for the given phrase, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard</value>
		[DataMember(Name = "dialect", EmitDefaultValue = false)]
		public string Dialect { get; set; }





		/// <summary>
		/// The Timestamp when sentiment feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The Timestamp when sentiment feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The Id of user who created the sentiment feedback
		/// </summary>
		/// <value>The Id of user who created the sentiment feedback</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public AddressableEntityRef CreatedBy { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SentimentFeedback {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Phrase: ").Append(Phrase).Append("\n");
			sb.Append("  Dialect: ").Append(Dialect).Append("\n");
			sb.Append("  FeedbackValue: ").Append(FeedbackValue).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
			return this.Equals(obj as SentimentFeedback);
		}

		/// <summary>
		/// Returns true if SentimentFeedback instances are equal
		/// </summary>
		/// <param name="other">Instance of SentimentFeedback to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SentimentFeedback other)
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
					this.Phrase == other.Phrase ||
					this.Phrase != null &&
					this.Phrase.Equals(other.Phrase)
				) &&
				(
					this.Dialect == other.Dialect ||
					this.Dialect != null &&
					this.Dialect.Equals(other.Dialect)
				) &&
				(
					this.FeedbackValue == other.FeedbackValue ||
					this.FeedbackValue != null &&
					this.FeedbackValue.Equals(other.FeedbackValue)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
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

				if (this.Phrase != null)
					hash = hash * 59 + this.Phrase.GetHashCode();

				if (this.Dialect != null)
					hash = hash * 59 + this.Dialect.GetHashCode();

				if (this.FeedbackValue != null)
					hash = hash * 59 + this.FeedbackValue.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				return hash;
			}
		}
	}

}
