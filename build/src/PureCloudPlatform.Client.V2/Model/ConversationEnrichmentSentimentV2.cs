using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Sentiment analysis of this message.
	/// </summary>
	[DataContract]
	public partial class ConversationEnrichmentSentimentV2 : IEquatable<ConversationEnrichmentSentimentV2>
	{
		/// <summary>
		/// Detected Sentiment tag
		/// </summary>
		/// <value>Detected Sentiment tag</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TagEnum
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
			/// Enum Neutral for "Neutral"
			/// </summary>
			[EnumMember(Value = "Neutral")]
			Neutral
		}
		/// <summary>
		/// Detected Sentiment tag
		/// </summary>
		/// <value>Detected Sentiment tag</value>
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		public TagEnum? Tag { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEnrichmentSentimentV2" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationEnrichmentSentimentV2() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationEnrichmentSentimentV2" /> class.
		/// </summary>
		/// <param name="Tag">Detected Sentiment tag (required).</param>
		public ConversationEnrichmentSentimentV2(TagEnum? Tag = null)
		{
			this.Tag = Tag;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationEnrichmentSentimentV2 {\n");

			sb.Append("  Tag: ").Append(Tag).Append("\n");
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
			return this.Equals(obj as ConversationEnrichmentSentimentV2);
		}

		/// <summary>
		/// Returns true if ConversationEnrichmentSentimentV2 instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationEnrichmentSentimentV2 to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationEnrichmentSentimentV2 other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Tag == other.Tag ||
					this.Tag != null &&
					this.Tag.Equals(other.Tag)
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
				if (this.Tag != null)
					hash = hash * 59 + this.Tag.GetHashCode();

				return hash;
			}
		}
	}

}
