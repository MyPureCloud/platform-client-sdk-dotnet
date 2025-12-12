using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationCategory
	/// </summary>
	[DataContract]
	public partial class ConversationCategory : IEquatable<ConversationCategory>
	{
		/// <summary>
		/// The type of interaction the category will apply to
		/// </summary>
		/// <value>The type of interaction the category will apply to</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum InteractionTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Voice for "Voice"
			/// </summary>
			[EnumMember(Value = "Voice")]
			Voice,

			/// <summary>
			/// Enum Digital for "Digital"
			/// </summary>
			[EnumMember(Value = "Digital")]
			Digital,

			/// <summary>
			/// Enum All for "All"
			/// </summary>
			[EnumMember(Value = "All")]
			All
		}
		/// <summary>
		/// The type of interaction the category will apply to
		/// </summary>
		/// <value>The type of interaction the category will apply to</value>
		[DataMember(Name = "interactionType", EmitDefaultValue = false)]
		public InteractionTypeEnum? InteractionType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationCategory" /> class.
		/// </summary>
		/// <param name="Id">The id of the category.</param>
		/// <param name="Name">The name of the category.</param>
		/// <param name="Description">The description of the category.</param>
		/// <param name="InteractionType">The type of interaction the category will apply to.</param>
		/// <param name="Criteria">A collection of conditions joined together by logical operation to provide more refined filtering of conversations.</param>
		public ConversationCategory(string Id = null, string Name = null, string Description = null, InteractionTypeEnum? InteractionType = null, Operand Criteria = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.InteractionType = InteractionType;
			this.Criteria = Criteria;

		}



		/// <summary>
		/// The id of the category
		/// </summary>
		/// <value>The id of the category</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The name of the category
		/// </summary>
		/// <value>The name of the category</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The description of the category
		/// </summary>
		/// <value>The description of the category</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }





		/// <summary>
		/// A collection of conditions joined together by logical operation to provide more refined filtering of conversations
		/// </summary>
		/// <value>A collection of conditions joined together by logical operation to provide more refined filtering of conversations</value>
		[DataMember(Name = "criteria", EmitDefaultValue = false)]
		public Operand Criteria { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationCategory {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
			sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
			return this.Equals(obj as ConversationCategory);
		}

		/// <summary>
		/// Returns true if ConversationCategory instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationCategory to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationCategory other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.InteractionType == other.InteractionType ||
					this.InteractionType != null &&
					this.InteractionType.Equals(other.InteractionType)
				) &&
				(
					this.Criteria == other.Criteria ||
					this.Criteria != null &&
					this.Criteria.Equals(other.Criteria)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.InteractionType != null)
					hash = hash * 59 + this.InteractionType.GetHashCode();

				if (this.Criteria != null)
					hash = hash * 59 + this.Criteria.GetHashCode();

				return hash;
			}
		}
	}

}
