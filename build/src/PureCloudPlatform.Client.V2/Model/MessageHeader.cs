using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// MessageHeader
	/// </summary>
	[DataContract]
	public partial class MessageHeader : IEquatable<MessageHeader>
	{
		/// <summary>
		/// Defines the content type of the Header in message
		/// </summary>
		/// <value>Defines the content type of the Header in message</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Text for "Text"
			/// </summary>
			[EnumMember(Value = "Text")]
			Text,

			/// <summary>
			/// Enum Image for "Image"
			/// </summary>
			[EnumMember(Value = "Image")]
			Image
		}
		/// <summary>
		/// Defines the content type of the Header in message
		/// </summary>
		/// <value>Defines the content type of the Header in message</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="MessageHeader" /> class.
		/// </summary>
		/// <param name="Type">Defines the content type of the Header in message.</param>
		/// <param name="Content">Content associated with the header in the message.</param>
		public MessageHeader(TypeEnum? Type = null, string Content = null)
		{
			this.Type = Type;
			this.Content = Content;

		}





		/// <summary>
		/// Content associated with the header in the message
		/// </summary>
		/// <value>Content associated with the header in the message</value>
		[DataMember(Name = "content", EmitDefaultValue = false)]
		public string Content { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MessageHeader {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Content: ").Append(Content).Append("\n");
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
			return this.Equals(obj as MessageHeader);
		}

		/// <summary>
		/// Returns true if MessageHeader instances are equal
		/// </summary>
		/// <param name="other">Instance of MessageHeader to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessageHeader other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Content == other.Content ||
					this.Content != null &&
					this.Content.Equals(other.Content)
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
				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Content != null)
					hash = hash * 59 + this.Content.GetHashCode();

				return hash;
			}
		}
	}

}
