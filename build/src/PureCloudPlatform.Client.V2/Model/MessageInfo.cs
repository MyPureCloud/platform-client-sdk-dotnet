using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MessageInfo
	/// </summary>
	[DataContract]
	public partial class MessageInfo : IEquatable<MessageInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MessageInfo" /> class.
		/// </summary>
		/// <param name="LocalizableMessageCode">Key that can be used to localize the message..</param>
		/// <param name="Message">Description of the message..</param>
		/// <param name="MessageWithParams">Message with template fields for variable replacement..</param>
		/// <param name="MessageParams">Map with fields for variable replacement..</param>
		public MessageInfo(string LocalizableMessageCode = null, string Message = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null)
		{
			this.LocalizableMessageCode = LocalizableMessageCode;
			this.Message = Message;
			this.MessageWithParams = MessageWithParams;
			this.MessageParams = MessageParams;

		}



		/// <summary>
		/// Key that can be used to localize the message.
		/// </summary>
		/// <value>Key that can be used to localize the message.</value>
		[DataMember(Name = "localizableMessageCode", EmitDefaultValue = false)]
		public string LocalizableMessageCode { get; set; }



		/// <summary>
		/// Description of the message.
		/// </summary>
		/// <value>Description of the message.</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; set; }



		/// <summary>
		/// Message with template fields for variable replacement.
		/// </summary>
		/// <value>Message with template fields for variable replacement.</value>
		[DataMember(Name = "messageWithParams", EmitDefaultValue = false)]
		public string MessageWithParams { get; set; }



		/// <summary>
		/// Map with fields for variable replacement.
		/// </summary>
		/// <value>Map with fields for variable replacement.</value>
		[DataMember(Name = "messageParams", EmitDefaultValue = false)]
		public Dictionary<string, string> MessageParams { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MessageInfo {\n");

			sb.Append("  LocalizableMessageCode: ").Append(LocalizableMessageCode).Append("\n");
			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
			sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
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
			return this.Equals(obj as MessageInfo);
		}

		/// <summary>
		/// Returns true if MessageInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of MessageInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessageInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.LocalizableMessageCode == other.LocalizableMessageCode ||
					this.LocalizableMessageCode != null &&
					this.LocalizableMessageCode.Equals(other.LocalizableMessageCode)
				) &&
				(
					this.Message == other.Message ||
					this.Message != null &&
					this.Message.Equals(other.Message)
				) &&
				(
					this.MessageWithParams == other.MessageWithParams ||
					this.MessageWithParams != null &&
					this.MessageWithParams.Equals(other.MessageWithParams)
				) &&
				(
					this.MessageParams == other.MessageParams ||
					this.MessageParams != null &&
					this.MessageParams.SequenceEqual(other.MessageParams)
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
				if (this.LocalizableMessageCode != null)
					hash = hash * 59 + this.LocalizableMessageCode.GetHashCode();

				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				if (this.MessageWithParams != null)
					hash = hash * 59 + this.MessageWithParams.GetHashCode();

				if (this.MessageParams != null)
					hash = hash * 59 + this.MessageParams.GetHashCode();

				return hash;
			}
		}
	}

}
