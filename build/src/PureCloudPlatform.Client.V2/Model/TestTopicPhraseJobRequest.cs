using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TestTopicPhraseJobRequest
	/// </summary>
	[DataContract]
	public partial class TestTopicPhraseJobRequest : IEquatable<TestTopicPhraseJobRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="TestTopicPhraseJobRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TestTopicPhraseJobRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TestTopicPhraseJobRequest" /> class.
		/// </summary>
		/// <param name="Topic">The topic to test (required).</param>
		/// <param name="TranscriptsFilters">The transcripts filters.</param>
		public TestTopicPhraseJobRequest(TestTopicPhraseTopic Topic = null, TranscriptsFilters TranscriptsFilters = null)
		{
			this.Topic = Topic;
			this.TranscriptsFilters = TranscriptsFilters;

		}



		/// <summary>
		/// The topic to test
		/// </summary>
		/// <value>The topic to test</value>
		[DataMember(Name = "topic", EmitDefaultValue = false)]
		public TestTopicPhraseTopic Topic { get; set; }



		/// <summary>
		/// The transcripts filters
		/// </summary>
		/// <value>The transcripts filters</value>
		[DataMember(Name = "transcriptsFilters", EmitDefaultValue = false)]
		public TranscriptsFilters TranscriptsFilters { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TestTopicPhraseJobRequest {\n");

			sb.Append("  Topic: ").Append(Topic).Append("\n");
			sb.Append("  TranscriptsFilters: ").Append(TranscriptsFilters).Append("\n");
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
			return this.Equals(obj as TestTopicPhraseJobRequest);
		}

		/// <summary>
		/// Returns true if TestTopicPhraseJobRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of TestTopicPhraseJobRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TestTopicPhraseJobRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Topic == other.Topic ||
					this.Topic != null &&
					this.Topic.Equals(other.Topic)
				) &&
				(
					this.TranscriptsFilters == other.TranscriptsFilters ||
					this.TranscriptsFilters != null &&
					this.TranscriptsFilters.Equals(other.TranscriptsFilters)
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
				if (this.Topic != null)
					hash = hash * 59 + this.Topic.GetHashCode();

				if (this.TranscriptsFilters != null)
					hash = hash * 59 + this.TranscriptsFilters.GetHashCode();

				return hash;
			}
		}
	}

}
