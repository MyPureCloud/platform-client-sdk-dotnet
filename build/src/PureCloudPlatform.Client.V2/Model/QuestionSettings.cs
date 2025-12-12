using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// QuestionSettings
	/// </summary>
	[DataContract]
	public partial class QuestionSettings : IEquatable<QuestionSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionSettings" /> class.
		/// </summary>
		/// <param name="QuestionContextId">The context id of the question in the group.</param>
		/// <param name="Settings">Settings.</param>
		public QuestionSettings(string QuestionContextId = null, AiScoringSetting Settings = null)
		{
			this.QuestionContextId = QuestionContextId;
			this.Settings = Settings;

		}



		/// <summary>
		/// The context id of the question in the group
		/// </summary>
		/// <value>The context id of the question in the group</value>
		[DataMember(Name = "questionContextId", EmitDefaultValue = false)]
		public string QuestionContextId { get; set; }



		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public AiScoringSetting Settings { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QuestionSettings {\n");

			sb.Append("  QuestionContextId: ").Append(QuestionContextId).Append("\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
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
			return this.Equals(obj as QuestionSettings);
		}

		/// <summary>
		/// Returns true if QuestionSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of QuestionSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QuestionSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.QuestionContextId == other.QuestionContextId ||
					this.QuestionContextId != null &&
					this.QuestionContextId.Equals(other.QuestionContextId)
				) &&
				(
					this.Settings == other.Settings ||
					this.Settings != null &&
					this.Settings.Equals(other.Settings)
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
				if (this.QuestionContextId != null)
					hash = hash * 59 + this.QuestionContextId.GetHashCode();

				if (this.Settings != null)
					hash = hash * 59 + this.Settings.GetHashCode();

				return hash;
			}
		}
	}

}
