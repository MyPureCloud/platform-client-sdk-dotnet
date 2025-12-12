using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Outgoing Message request
	/// </summary>
	[DataContract]
	public partial class OutgoingMessageRequest : IEquatable<OutgoingMessageRequest>
	{
		/// <summary>
		/// The state of the bot reported
		/// </summary>
		/// <value>The state of the bot reported</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum BotStateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Complete for "Complete"
			/// </summary>
			[EnumMember(Value = "Complete")]
			Complete,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Moredata for "MoreData"
			/// </summary>
			[EnumMember(Value = "MoreData")]
			Moredata
		}
		/// <summary>
		/// The state of the bot reported
		/// </summary>
		/// <value>The state of the bot reported</value>
		[DataMember(Name = "botState", EmitDefaultValue = false)]
		public BotStateEnum? BotState { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="OutgoingMessageRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OutgoingMessageRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutgoingMessageRequest" /> class.
		/// </summary>
		/// <param name="BotId">The unique id of the bot. (required).</param>
		/// <param name="BotVersion">The version of the bot. (required).</param>
		/// <param name="BotSessionId">The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent). (required).</param>
		/// <param name="BotState">The state of the bot reported (required).</param>
		/// <param name="LanguageCode">The language used for this message. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code). (required).</param>
		/// <param name="ReplyMessages">This is a list of messages to send back to the user, this field can be null or an empty list..</param>
		/// <param name="Intent">The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected..</param>
		/// <param name="Confidence">A value between 0 and 1.0 denoting the confidence of the discovered intent (if found) this is optional and if left null genesys assumes a confidence of 1.0 on success and 0 on fail..</param>
		/// <param name="ErrorInfo">If the botState is Failed the bot can add this error object with more details about the error..</param>
		/// <param name="Parameters">This is a map of string-string key, value pairs containing optional fields that can be passed from the bot for custom behavior, tracking, etc, which can be used by the flow..</param>
		/// <param name="Entities">A set of entity values that go along with the intent..</param>
		public OutgoingMessageRequest(string BotId = null, string BotVersion = null, string BotSessionId = null, BotStateEnum? BotState = null, string LanguageCode = null, List<ReplyMessage> ReplyMessages = null, string Intent = null, double? Confidence = null, ErrorInfo ErrorInfo = null, Dictionary<string, string> Parameters = null, List<BotEntityValue> Entities = null)
		{
			this.BotId = BotId;
			this.BotVersion = BotVersion;
			this.BotSessionId = BotSessionId;
			this.BotState = BotState;
			this.LanguageCode = LanguageCode;
			this.ReplyMessages = ReplyMessages;
			this.Intent = Intent;
			this.Confidence = Confidence;
			this.ErrorInfo = ErrorInfo;
			this.Parameters = Parameters;
			this.Entities = Entities;

		}



		/// <summary>
		/// The unique id of the bot.
		/// </summary>
		/// <value>The unique id of the bot.</value>
		[DataMember(Name = "botId", EmitDefaultValue = false)]
		public string BotId { get; set; }



		/// <summary>
		/// The version of the bot.
		/// </summary>
		/// <value>The version of the bot.</value>
		[DataMember(Name = "botVersion", EmitDefaultValue = false)]
		public string BotVersion { get; set; }



		/// <summary>
		/// The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent).
		/// </summary>
		/// <value>The id of the session. This id will be used for an entire conversation with the bot (a series of back and forth between the bot until the bot has fulfilled its intent).</value>
		[DataMember(Name = "botSessionId", EmitDefaultValue = false)]
		public string BotSessionId { get; set; }





		/// <summary>
		/// The language used for this message. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code).
		/// </summary>
		/// <value>The language used for this message. EG &#39;en-us&#39; or &#39;es&#39;, etc; These language codes are W3C language identification tags (ISO 639-1 for the language name and ISO 3166 for the country code).</value>
		[DataMember(Name = "languageCode", EmitDefaultValue = false)]
		public string LanguageCode { get; set; }



		/// <summary>
		/// This is a list of messages to send back to the user, this field can be null or an empty list.
		/// </summary>
		/// <value>This is a list of messages to send back to the user, this field can be null or an empty list.</value>
		[DataMember(Name = "replyMessages", EmitDefaultValue = false)]
		public List<ReplyMessage> ReplyMessages { get; set; }



		/// <summary>
		/// The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected.
		/// </summary>
		/// <value>The name of the intent the bot is either processing or has processed, this will be blank if no intent could be detected.</value>
		[DataMember(Name = "intent", EmitDefaultValue = false)]
		public string Intent { get; set; }



		/// <summary>
		/// A value between 0 and 1.0 denoting the confidence of the discovered intent (if found) this is optional and if left null genesys assumes a confidence of 1.0 on success and 0 on fail.
		/// </summary>
		/// <value>A value between 0 and 1.0 denoting the confidence of the discovered intent (if found) this is optional and if left null genesys assumes a confidence of 1.0 on success and 0 on fail.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public double? Confidence { get; set; }



		/// <summary>
		/// If the botState is Failed the bot can add this error object with more details about the error.
		/// </summary>
		/// <value>If the botState is Failed the bot can add this error object with more details about the error.</value>
		[DataMember(Name = "errorInfo", EmitDefaultValue = false)]
		public ErrorInfo ErrorInfo { get; set; }



		/// <summary>
		/// This is a map of string-string key, value pairs containing optional fields that can be passed from the bot for custom behavior, tracking, etc, which can be used by the flow.
		/// </summary>
		/// <value>This is a map of string-string key, value pairs containing optional fields that can be passed from the bot for custom behavior, tracking, etc, which can be used by the flow.</value>
		[DataMember(Name = "parameters", EmitDefaultValue = false)]
		public Dictionary<string, string> Parameters { get; set; }



		/// <summary>
		/// A set of entity values that go along with the intent.
		/// </summary>
		/// <value>A set of entity values that go along with the intent.</value>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<BotEntityValue> Entities { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutgoingMessageRequest {\n");

			sb.Append("  BotId: ").Append(BotId).Append("\n");
			sb.Append("  BotVersion: ").Append(BotVersion).Append("\n");
			sb.Append("  BotSessionId: ").Append(BotSessionId).Append("\n");
			sb.Append("  BotState: ").Append(BotState).Append("\n");
			sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
			sb.Append("  ReplyMessages: ").Append(ReplyMessages).Append("\n");
			sb.Append("  Intent: ").Append(Intent).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
			sb.Append("  Parameters: ").Append(Parameters).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
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
			return this.Equals(obj as OutgoingMessageRequest);
		}

		/// <summary>
		/// Returns true if OutgoingMessageRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of OutgoingMessageRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutgoingMessageRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.BotId == other.BotId ||
					this.BotId != null &&
					this.BotId.Equals(other.BotId)
				) &&
				(
					this.BotVersion == other.BotVersion ||
					this.BotVersion != null &&
					this.BotVersion.Equals(other.BotVersion)
				) &&
				(
					this.BotSessionId == other.BotSessionId ||
					this.BotSessionId != null &&
					this.BotSessionId.Equals(other.BotSessionId)
				) &&
				(
					this.BotState == other.BotState ||
					this.BotState != null &&
					this.BotState.Equals(other.BotState)
				) &&
				(
					this.LanguageCode == other.LanguageCode ||
					this.LanguageCode != null &&
					this.LanguageCode.Equals(other.LanguageCode)
				) &&
				(
					this.ReplyMessages == other.ReplyMessages ||
					this.ReplyMessages != null &&
					this.ReplyMessages.SequenceEqual(other.ReplyMessages)
				) &&
				(
					this.Intent == other.Intent ||
					this.Intent != null &&
					this.Intent.Equals(other.Intent)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.ErrorInfo == other.ErrorInfo ||
					this.ErrorInfo != null &&
					this.ErrorInfo.Equals(other.ErrorInfo)
				) &&
				(
					this.Parameters == other.Parameters ||
					this.Parameters != null &&
					this.Parameters.SequenceEqual(other.Parameters)
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
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
				if (this.BotId != null)
					hash = hash * 59 + this.BotId.GetHashCode();

				if (this.BotVersion != null)
					hash = hash * 59 + this.BotVersion.GetHashCode();

				if (this.BotSessionId != null)
					hash = hash * 59 + this.BotSessionId.GetHashCode();

				if (this.BotState != null)
					hash = hash * 59 + this.BotState.GetHashCode();

				if (this.LanguageCode != null)
					hash = hash * 59 + this.LanguageCode.GetHashCode();

				if (this.ReplyMessages != null)
					hash = hash * 59 + this.ReplyMessages.GetHashCode();

				if (this.Intent != null)
					hash = hash * 59 + this.Intent.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.ErrorInfo != null)
					hash = hash * 59 + this.ErrorInfo.GetHashCode();

				if (this.Parameters != null)
					hash = hash * 59 + this.Parameters.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				return hash;
			}
		}
	}

}
