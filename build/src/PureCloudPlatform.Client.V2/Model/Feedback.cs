using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Feedback
	/// </summary>
	[DataContract]
	public partial class Feedback : IEquatable<Feedback>
	{
		/// <summary>
		/// Feedback relevance.
		/// </summary>
		/// <value>Feedback relevance.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum RelevanceEnum
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
			/// Enum Relevant for "Relevant"
			/// </summary>
			[EnumMember(Value = "Relevant")]
			Relevant,

			/// <summary>
			/// Enum Irrelevant for "Irrelevant"
			/// </summary>
			[EnumMember(Value = "Irrelevant")]
			Irrelevant
		}
		/// <summary>
		/// Feedback relevance.
		/// </summary>
		/// <value>Feedback relevance.</value>
		[DataMember(Name = "relevance", EmitDefaultValue = false)]
		public RelevanceEnum? Relevance { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Feedback" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Feedback() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Feedback" /> class.
		/// </summary>
		/// <param name="SuggestionId">Feedback suggestion id. (required).</param>
		/// <param name="UserProvided">Indicates whether the answer/item was clicked by the human agent or not..</param>
		/// <param name="Relevance">Feedback relevance. (required).</param>
		public Feedback(string SuggestionId = null, bool? UserProvided = null, RelevanceEnum? Relevance = null)
		{
			this.SuggestionId = SuggestionId;
			this.UserProvided = UserProvided;
			this.Relevance = Relevance;

		}



		/// <summary>
		/// Feedback suggestion id.
		/// </summary>
		/// <value>Feedback suggestion id.</value>
		[DataMember(Name = "suggestionId", EmitDefaultValue = false)]
		public string SuggestionId { get; set; }



		/// <summary>
		/// Indicates whether the answer/item was clicked by the human agent or not.
		/// </summary>
		/// <value>Indicates whether the answer/item was clicked by the human agent or not.</value>
		[DataMember(Name = "userProvided", EmitDefaultValue = false)]
		public bool? UserProvided { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Feedback {\n");

			sb.Append("  SuggestionId: ").Append(SuggestionId).Append("\n");
			sb.Append("  UserProvided: ").Append(UserProvided).Append("\n");
			sb.Append("  Relevance: ").Append(Relevance).Append("\n");
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
			return this.Equals(obj as Feedback);
		}

		/// <summary>
		/// Returns true if Feedback instances are equal
		/// </summary>
		/// <param name="other">Instance of Feedback to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Feedback other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SuggestionId == other.SuggestionId ||
					this.SuggestionId != null &&
					this.SuggestionId.Equals(other.SuggestionId)
				) &&
				(
					this.UserProvided == other.UserProvided ||
					this.UserProvided != null &&
					this.UserProvided.Equals(other.UserProvided)
				) &&
				(
					this.Relevance == other.Relevance ||
					this.Relevance != null &&
					this.Relevance.Equals(other.Relevance)
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
				if (this.SuggestionId != null)
					hash = hash * 59 + this.SuggestionId.GetHashCode();

				if (this.UserProvided != null)
					hash = hash * 59 + this.UserProvided.GetHashCode();

				if (this.Relevance != null)
					hash = hash * 59 + this.Relevance.GetHashCode();

				return hash;
			}
		}
	}

}
