using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TestTopicPhraseTopic
	/// </summary>
	[DataContract]
	public partial class TestTopicPhraseTopic : IEquatable<TestTopicPhraseTopic>
	{
		/// <summary>
		/// The topic strictness, default value is 72
		/// </summary>
		/// <value>The topic strictness, default value is 72</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StrictnessEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum _1 for "1"
			/// </summary>
			[EnumMember(Value = "1")]
			_1,

			/// <summary>
			/// Enum _55 for "55"
			/// </summary>
			[EnumMember(Value = "55")]
			_55,

			/// <summary>
			/// Enum _65 for "65"
			/// </summary>
			[EnumMember(Value = "65")]
			_65,

			/// <summary>
			/// Enum _72 for "72"
			/// </summary>
			[EnumMember(Value = "72")]
			_72,

			/// <summary>
			/// Enum _85 for "85"
			/// </summary>
			[EnumMember(Value = "85")]
			_85,

			/// <summary>
			/// Enum _90 for "90"
			/// </summary>
			[EnumMember(Value = "90")]
			_90
		}
		/// <summary>
		/// The topic participants, default value is both
		/// </summary>
		/// <value>The topic participants, default value is both</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ParticipantsEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum External for "External"
			/// </summary>
			[EnumMember(Value = "External")]
			External,

			/// <summary>
			/// Enum Internal for "Internal"
			/// </summary>
			[EnumMember(Value = "Internal")]
			Internal,

			/// <summary>
			/// Enum All for "All"
			/// </summary>
			[EnumMember(Value = "All")]
			All
		}
		/// <summary>
		/// The topic strictness, default value is 72
		/// </summary>
		/// <value>The topic strictness, default value is 72</value>
		[DataMember(Name = "strictness", EmitDefaultValue = false)]
		public StrictnessEnum? Strictness { get; set; }
		/// <summary>
		/// The topic participants, default value is both
		/// </summary>
		/// <value>The topic participants, default value is both</value>
		[DataMember(Name = "participants", EmitDefaultValue = false)]
		public ParticipantsEnum? Participants { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TestTopicPhraseTopic" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TestTopicPhraseTopic() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TestTopicPhraseTopic" /> class.
		/// </summary>
		/// <param name="Phrase">The topic phrase to test (required).</param>
		/// <param name="Strictness">The topic strictness, default value is 72.</param>
		/// <param name="Dialect">The topic dialect, default value is en-US (required).</param>
		/// <param name="Participants">The topic participants, default value is both.</param>
		public TestTopicPhraseTopic(TestTopicPhrasePhrase Phrase = null, StrictnessEnum? Strictness = null, string Dialect = null, ParticipantsEnum? Participants = null)
		{
			this.Phrase = Phrase;
			this.Strictness = Strictness;
			this.Dialect = Dialect;
			this.Participants = Participants;

		}



		/// <summary>
		/// The topic phrase to test
		/// </summary>
		/// <value>The topic phrase to test</value>
		[DataMember(Name = "phrase", EmitDefaultValue = false)]
		public TestTopicPhrasePhrase Phrase { get; set; }





		/// <summary>
		/// The topic dialect, default value is en-US
		/// </summary>
		/// <value>The topic dialect, default value is en-US</value>
		[DataMember(Name = "dialect", EmitDefaultValue = false)]
		public string Dialect { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TestTopicPhraseTopic {\n");

			sb.Append("  Phrase: ").Append(Phrase).Append("\n");
			sb.Append("  Strictness: ").Append(Strictness).Append("\n");
			sb.Append("  Dialect: ").Append(Dialect).Append("\n");
			sb.Append("  Participants: ").Append(Participants).Append("\n");
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
			return this.Equals(obj as TestTopicPhraseTopic);
		}

		/// <summary>
		/// Returns true if TestTopicPhraseTopic instances are equal
		/// </summary>
		/// <param name="other">Instance of TestTopicPhraseTopic to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TestTopicPhraseTopic other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Phrase == other.Phrase ||
					this.Phrase != null &&
					this.Phrase.Equals(other.Phrase)
				) &&
				(
					this.Strictness == other.Strictness ||
					this.Strictness != null &&
					this.Strictness.Equals(other.Strictness)
				) &&
				(
					this.Dialect == other.Dialect ||
					this.Dialect != null &&
					this.Dialect.Equals(other.Dialect)
				) &&
				(
					this.Participants == other.Participants ||
					this.Participants != null &&
					this.Participants.Equals(other.Participants)
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
				if (this.Phrase != null)
					hash = hash * 59 + this.Phrase.GetHashCode();

				if (this.Strictness != null)
					hash = hash * 59 + this.Strictness.GetHashCode();

				if (this.Dialect != null)
					hash = hash * 59 + this.Dialect.GetHashCode();

				if (this.Participants != null)
					hash = hash * 59 + this.Participants.GetHashCode();

				return hash;
			}
		}
	}

}
