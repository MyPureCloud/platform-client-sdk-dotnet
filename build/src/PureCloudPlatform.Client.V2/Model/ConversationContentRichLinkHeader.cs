using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Header for a Rich Link
	/// </summary>
	[DataContract]
	public partial class ConversationContentRichLinkHeader : IEquatable<ConversationContentRichLinkHeader>
	{
		/// <summary>
		/// Describes the Rich Link header type.
		/// </summary>
		/// <value>Describes the Rich Link header type.</value>
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
			/// Enum File for "File"
			/// </summary>
			[EnumMember(Value = "File")]
			File,

			/// <summary>
			/// Enum Image for "Image"
			/// </summary>
			[EnumMember(Value = "Image")]
			Image,

			/// <summary>
			/// Enum Text for "Text"
			/// </summary>
			[EnumMember(Value = "Text")]
			Text,

			/// <summary>
			/// Enum Video for "Video"
			/// </summary>
			[EnumMember(Value = "Video")]
			Video
		}
		/// <summary>
		/// Describes the Rich Link header type.
		/// </summary>
		/// <value>Describes the Rich Link header type.</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentRichLinkHeader" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationContentRichLinkHeader() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentRichLinkHeader" /> class.
		/// </summary>
		/// <param name="Type">Describes the Rich Link header type. (required).</param>
		/// <param name="Value">Rich Link header value. (required).</param>
		public ConversationContentRichLinkHeader(TypeEnum? Type = null, string Value = null)
		{
			this.Type = Type;
			this.Value = Value;

		}





		/// <summary>
		/// Rich Link header value.
		/// </summary>
		/// <value>Rich Link header value.</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentRichLinkHeader {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as ConversationContentRichLinkHeader);
		}

		/// <summary>
		/// Returns true if ConversationContentRichLinkHeader instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentRichLinkHeader to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentRichLinkHeader other)
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
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
