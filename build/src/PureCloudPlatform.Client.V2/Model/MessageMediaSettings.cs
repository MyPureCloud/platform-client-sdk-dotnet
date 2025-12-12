using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MessageMediaSettings
	/// </summary>
	[DataContract]
	public partial class MessageMediaSettings : IEquatable<MessageMediaSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MessageMediaSettings" /> class.
		/// </summary>
		/// <param name="EnableAutoAnswer">Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings..</param>
		/// <param name="AlertingTimeoutSeconds">The alerting timeout for the media type, in seconds.</param>
		/// <param name="ServiceLevel">The targeted service level for the media type.</param>
		/// <param name="AutoAnswerAlertToneSeconds">How long to play the alerting tone for an auto-answer interaction.</param>
		/// <param name="ManualAnswerAlertToneSeconds">How long to play the alerting tone for a manual-answer interaction.</param>
		/// <param name="SubTypeSettings">Map of media subtype to media subtype specific settings..</param>
		public MessageMediaSettings(bool? EnableAutoAnswer = null, int? AlertingTimeoutSeconds = null, ServiceLevel ServiceLevel = null, double? AutoAnswerAlertToneSeconds = null, double? ManualAnswerAlertToneSeconds = null, Dictionary<string, MessageSubtypeSettings> SubTypeSettings = null)
		{
			this.EnableAutoAnswer = EnableAutoAnswer;
			this.AlertingTimeoutSeconds = AlertingTimeoutSeconds;
			this.ServiceLevel = ServiceLevel;
			this.AutoAnswerAlertToneSeconds = AutoAnswerAlertToneSeconds;
			this.ManualAnswerAlertToneSeconds = ManualAnswerAlertToneSeconds;
			this.SubTypeSettings = SubTypeSettings;

		}



		/// <summary>
		/// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
		/// </summary>
		/// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
		[DataMember(Name = "enableAutoAnswer", EmitDefaultValue = false)]
		public bool? EnableAutoAnswer { get; set; }



		/// <summary>
		/// The alerting timeout for the media type, in seconds
		/// </summary>
		/// <value>The alerting timeout for the media type, in seconds</value>
		[DataMember(Name = "alertingTimeoutSeconds", EmitDefaultValue = false)]
		public int? AlertingTimeoutSeconds { get; set; }



		/// <summary>
		/// The targeted service level for the media type
		/// </summary>
		/// <value>The targeted service level for the media type</value>
		[DataMember(Name = "serviceLevel", EmitDefaultValue = false)]
		public ServiceLevel ServiceLevel { get; set; }



		/// <summary>
		/// How long to play the alerting tone for an auto-answer interaction
		/// </summary>
		/// <value>How long to play the alerting tone for an auto-answer interaction</value>
		[DataMember(Name = "autoAnswerAlertToneSeconds", EmitDefaultValue = false)]
		public double? AutoAnswerAlertToneSeconds { get; set; }



		/// <summary>
		/// How long to play the alerting tone for a manual-answer interaction
		/// </summary>
		/// <value>How long to play the alerting tone for a manual-answer interaction</value>
		[DataMember(Name = "manualAnswerAlertToneSeconds", EmitDefaultValue = false)]
		public double? ManualAnswerAlertToneSeconds { get; set; }



		/// <summary>
		/// Map of media subtype to media subtype specific settings.
		/// </summary>
		/// <value>Map of media subtype to media subtype specific settings.</value>
		[DataMember(Name = "subTypeSettings", EmitDefaultValue = false)]
		public Dictionary<string, MessageSubtypeSettings> SubTypeSettings { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MessageMediaSettings {\n");

			sb.Append("  EnableAutoAnswer: ").Append(EnableAutoAnswer).Append("\n");
			sb.Append("  AlertingTimeoutSeconds: ").Append(AlertingTimeoutSeconds).Append("\n");
			sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
			sb.Append("  AutoAnswerAlertToneSeconds: ").Append(AutoAnswerAlertToneSeconds).Append("\n");
			sb.Append("  ManualAnswerAlertToneSeconds: ").Append(ManualAnswerAlertToneSeconds).Append("\n");
			sb.Append("  SubTypeSettings: ").Append(SubTypeSettings).Append("\n");
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
			return this.Equals(obj as MessageMediaSettings);
		}

		/// <summary>
		/// Returns true if MessageMediaSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of MessageMediaSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessageMediaSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EnableAutoAnswer == other.EnableAutoAnswer ||
					this.EnableAutoAnswer != null &&
					this.EnableAutoAnswer.Equals(other.EnableAutoAnswer)
				) &&
				(
					this.AlertingTimeoutSeconds == other.AlertingTimeoutSeconds ||
					this.AlertingTimeoutSeconds != null &&
					this.AlertingTimeoutSeconds.Equals(other.AlertingTimeoutSeconds)
				) &&
				(
					this.ServiceLevel == other.ServiceLevel ||
					this.ServiceLevel != null &&
					this.ServiceLevel.Equals(other.ServiceLevel)
				) &&
				(
					this.AutoAnswerAlertToneSeconds == other.AutoAnswerAlertToneSeconds ||
					this.AutoAnswerAlertToneSeconds != null &&
					this.AutoAnswerAlertToneSeconds.Equals(other.AutoAnswerAlertToneSeconds)
				) &&
				(
					this.ManualAnswerAlertToneSeconds == other.ManualAnswerAlertToneSeconds ||
					this.ManualAnswerAlertToneSeconds != null &&
					this.ManualAnswerAlertToneSeconds.Equals(other.ManualAnswerAlertToneSeconds)
				) &&
				(
					this.SubTypeSettings == other.SubTypeSettings ||
					this.SubTypeSettings != null &&
					this.SubTypeSettings.SequenceEqual(other.SubTypeSettings)
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
				if (this.EnableAutoAnswer != null)
					hash = hash * 59 + this.EnableAutoAnswer.GetHashCode();

				if (this.AlertingTimeoutSeconds != null)
					hash = hash * 59 + this.AlertingTimeoutSeconds.GetHashCode();

				if (this.ServiceLevel != null)
					hash = hash * 59 + this.ServiceLevel.GetHashCode();

				if (this.AutoAnswerAlertToneSeconds != null)
					hash = hash * 59 + this.AutoAnswerAlertToneSeconds.GetHashCode();

				if (this.ManualAnswerAlertToneSeconds != null)
					hash = hash * 59 + this.ManualAnswerAlertToneSeconds.GetHashCode();

				if (this.SubTypeSettings != null)
					hash = hash * 59 + this.SubTypeSettings.GetHashCode();

				return hash;
			}
		}
	}

}
