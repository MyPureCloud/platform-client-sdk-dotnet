using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Contact fields a merchant requires to complete a payment request.
	/// </summary>
	[DataContract]
	public partial class ConversationContentRequiredContactField : IEquatable<ConversationContentRequiredContactField>
	{
		/// <summary>
		/// The name of the contact field
		/// </summary>
		/// <value>The name of the contact field</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ContactFieldEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Address for "Address"
			/// </summary>
			[EnumMember(Value = "Address")]
			Address,

			/// <summary>
			/// Enum Name for "Name"
			/// </summary>
			[EnumMember(Value = "Name")]
			Name,

			/// <summary>
			/// Enum Phone for "Phone"
			/// </summary>
			[EnumMember(Value = "Phone")]
			Phone,

			/// <summary>
			/// Enum Email for "Email"
			/// </summary>
			[EnumMember(Value = "Email")]
			Email
		}
		/// <summary>
		/// The name of the contact field
		/// </summary>
		/// <value>The name of the contact field</value>
		[DataMember(Name = "contactField", EmitDefaultValue = false)]
		public ContactFieldEnum? ContactField { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentRequiredContactField" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationContentRequiredContactField() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentRequiredContactField" /> class.
		/// </summary>
		/// <param name="ContactField">The name of the contact field (required).</param>
		public ConversationContentRequiredContactField(ContactFieldEnum? ContactField = null)
		{
			this.ContactField = ContactField;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentRequiredContactField {\n");

			sb.Append("  ContactField: ").Append(ContactField).Append("\n");
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
			return this.Equals(obj as ConversationContentRequiredContactField);
		}

		/// <summary>
		/// Returns true if ConversationContentRequiredContactField instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentRequiredContactField to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentRequiredContactField other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ContactField == other.ContactField ||
					this.ContactField != null &&
					this.ContactField.Equals(other.ContactField)
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
				if (this.ContactField != null)
					hash = hash * 59 + this.ContactField.GetHashCode();

				return hash;
			}
		}
	}

}
