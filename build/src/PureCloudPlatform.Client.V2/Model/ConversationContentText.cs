using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Message content element containing text only.
	/// </summary>
	[DataContract]
	public partial class ConversationContentText : IEquatable<ConversationContentText>
	{
		/// <summary>
		/// Type of text content (Deprecated).
		/// </summary>
		/// <value>Type of text content (Deprecated).</value>
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
			Text
		}
		/// <summary>
		/// Type of text content (Deprecated).
		/// </summary>
		/// <value>Type of text content (Deprecated).</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentText" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationContentText() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentText" /> class.
		/// </summary>
		/// <param name="Type">Type of text content (Deprecated)..</param>
		/// <param name="Body">Text to be shown for this content element. (required).</param>
		public ConversationContentText(TypeEnum? Type = null, string Body = null)
		{
			this.Type = Type;
			this.Body = Body;

		}





		/// <summary>
		/// Text to be shown for this content element.
		/// </summary>
		/// <value>Text to be shown for this content element.</value>
		[DataMember(Name = "body", EmitDefaultValue = false)]
		public string Body { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentText {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Body: ").Append(Body).Append("\n");
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
			return this.Equals(obj as ConversationContentText);
		}

		/// <summary>
		/// Returns true if ConversationContentText instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentText to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentText other)
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
					this.Body == other.Body ||
					this.Body != null &&
					this.Body.Equals(other.Body)
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

				if (this.Body != null)
					hash = hash * 59 + this.Body.GetHashCode();

				return hash;
			}
		}
	}

}
