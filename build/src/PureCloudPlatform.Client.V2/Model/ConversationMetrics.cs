using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationMetrics
	/// </summary>
	[DataContract]
	public partial class ConversationMetrics : IEquatable<ConversationMetrics>
	{
		/// <summary>
		/// The Sentiment Trend Class
		/// </summary>
		/// <value>The Sentiment Trend Class</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SentimentTrendClassEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Notcalculated for "NotCalculated"
			/// </summary>
			[EnumMember(Value = "NotCalculated")]
			Notcalculated,

			/// <summary>
			/// Enum Declining for "Declining"
			/// </summary>
			[EnumMember(Value = "Declining")]
			Declining,

			/// <summary>
			/// Enum Slightlydeclining for "SlightlyDeclining"
			/// </summary>
			[EnumMember(Value = "SlightlyDeclining")]
			Slightlydeclining,

			/// <summary>
			/// Enum Nochange for "NoChange"
			/// </summary>
			[EnumMember(Value = "NoChange")]
			Nochange,

			/// <summary>
			/// Enum Slightlyimproving for "SlightlyImproving"
			/// </summary>
			[EnumMember(Value = "SlightlyImproving")]
			Slightlyimproving,

			/// <summary>
			/// Enum Improving for "Improving"
			/// </summary>
			[EnumMember(Value = "Improving")]
			Improving
		}
		/// <summary>
		/// The Sentiment Trend Class
		/// </summary>
		/// <value>The Sentiment Trend Class</value>
		[DataMember(Name = "sentimentTrendClass", EmitDefaultValue = false)]
		public SentimentTrendClassEnum? SentimentTrendClass { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationMetrics" /> class.
		/// </summary>
		/// <param name="Conversation">The Conversation Reference.</param>
		/// <param name="SentimentScore">The Sentiment Score.</param>
		/// <param name="SentimentTrend">The Sentiment Trend.</param>
		/// <param name="SentimentTrendClass">The Sentiment Trend Class.</param>
		/// <param name="EmpathyScores">The Empathy Scores.</param>
		/// <param name="ParticipantMetrics">The Participant Metrics.</param>
		public ConversationMetrics(AddressableEntityRef Conversation = null, double? SentimentScore = null, double? SentimentTrend = null, SentimentTrendClassEnum? SentimentTrendClass = null, List<EmpathyScore> EmpathyScores = null, ParticipantMetrics ParticipantMetrics = null)
		{
			this.Conversation = Conversation;
			this.SentimentScore = SentimentScore;
			this.SentimentTrend = SentimentTrend;
			this.SentimentTrendClass = SentimentTrendClass;
			this.EmpathyScores = EmpathyScores;
			this.ParticipantMetrics = ParticipantMetrics;

		}



		/// <summary>
		/// The Conversation Reference
		/// </summary>
		/// <value>The Conversation Reference</value>
		[DataMember(Name = "conversation", EmitDefaultValue = false)]
		public AddressableEntityRef Conversation { get; set; }



		/// <summary>
		/// The Sentiment Score
		/// </summary>
		/// <value>The Sentiment Score</value>
		[DataMember(Name = "sentimentScore", EmitDefaultValue = false)]
		public double? SentimentScore { get; set; }



		/// <summary>
		/// The Sentiment Trend
		/// </summary>
		/// <value>The Sentiment Trend</value>
		[DataMember(Name = "sentimentTrend", EmitDefaultValue = false)]
		public double? SentimentTrend { get; set; }





		/// <summary>
		/// The Empathy Scores
		/// </summary>
		/// <value>The Empathy Scores</value>
		[DataMember(Name = "empathyScores", EmitDefaultValue = false)]
		public List<EmpathyScore> EmpathyScores { get; set; }



		/// <summary>
		/// The Participant Metrics
		/// </summary>
		/// <value>The Participant Metrics</value>
		[DataMember(Name = "participantMetrics", EmitDefaultValue = false)]
		public ParticipantMetrics ParticipantMetrics { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationMetrics {\n");

			sb.Append("  Conversation: ").Append(Conversation).Append("\n");
			sb.Append("  SentimentScore: ").Append(SentimentScore).Append("\n");
			sb.Append("  SentimentTrend: ").Append(SentimentTrend).Append("\n");
			sb.Append("  SentimentTrendClass: ").Append(SentimentTrendClass).Append("\n");
			sb.Append("  EmpathyScores: ").Append(EmpathyScores).Append("\n");
			sb.Append("  ParticipantMetrics: ").Append(ParticipantMetrics).Append("\n");
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
			return this.Equals(obj as ConversationMetrics);
		}

		/// <summary>
		/// Returns true if ConversationMetrics instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationMetrics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationMetrics other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Conversation == other.Conversation ||
					this.Conversation != null &&
					this.Conversation.Equals(other.Conversation)
				) &&
				(
					this.SentimentScore == other.SentimentScore ||
					this.SentimentScore != null &&
					this.SentimentScore.Equals(other.SentimentScore)
				) &&
				(
					this.SentimentTrend == other.SentimentTrend ||
					this.SentimentTrend != null &&
					this.SentimentTrend.Equals(other.SentimentTrend)
				) &&
				(
					this.SentimentTrendClass == other.SentimentTrendClass ||
					this.SentimentTrendClass != null &&
					this.SentimentTrendClass.Equals(other.SentimentTrendClass)
				) &&
				(
					this.EmpathyScores == other.EmpathyScores ||
					this.EmpathyScores != null &&
					this.EmpathyScores.SequenceEqual(other.EmpathyScores)
				) &&
				(
					this.ParticipantMetrics == other.ParticipantMetrics ||
					this.ParticipantMetrics != null &&
					this.ParticipantMetrics.Equals(other.ParticipantMetrics)
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
				if (this.Conversation != null)
					hash = hash * 59 + this.Conversation.GetHashCode();

				if (this.SentimentScore != null)
					hash = hash * 59 + this.SentimentScore.GetHashCode();

				if (this.SentimentTrend != null)
					hash = hash * 59 + this.SentimentTrend.GetHashCode();

				if (this.SentimentTrendClass != null)
					hash = hash * 59 + this.SentimentTrendClass.GetHashCode();

				if (this.EmpathyScores != null)
					hash = hash * 59 + this.EmpathyScores.GetHashCode();

				if (this.ParticipantMetrics != null)
					hash = hash * 59 + this.ParticipantMetrics.GetHashCode();

				return hash;
			}
		}
	}

}
