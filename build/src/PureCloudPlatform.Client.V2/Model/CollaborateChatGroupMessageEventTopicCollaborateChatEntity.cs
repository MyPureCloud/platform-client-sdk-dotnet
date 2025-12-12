using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CollaborateChatGroupMessageEventTopicCollaborateChatEntity
	/// </summary>
	[DataContract]
	public partial class CollaborateChatGroupMessageEventTopicCollaborateChatEntity : IEquatable<CollaborateChatGroupMessageEventTopicCollaborateChatEntity>
	{
		/// <summary>
		/// Gets or Sets EntityType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EntityTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Group for "Group"
			/// </summary>
			[EnumMember(Value = "Group")]
			Group,

			/// <summary>
			/// Enum User for "User"
			/// </summary>
			[EnumMember(Value = "User")]
			User,

			/// <summary>
			/// Enum Adhoc for "Adhoc"
			/// </summary>
			[EnumMember(Value = "Adhoc")]
			Adhoc
		}
		/// <summary>
		/// Gets or Sets EntityType
		/// </summary>
		[DataMember(Name = "entityType", EmitDefaultValue = false)]
		public EntityTypeEnum? EntityType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CollaborateChatGroupMessageEventTopicCollaborateChatEntity" /> class.
		/// </summary>
		/// <param name="EntityJid">EntityJid.</param>
		/// <param name="EntityId">EntityId.</param>
		/// <param name="EntityType">EntityType.</param>
		public CollaborateChatGroupMessageEventTopicCollaborateChatEntity(string EntityJid = null, string EntityId = null, EntityTypeEnum? EntityType = null)
		{
			this.EntityJid = EntityJid;
			this.EntityId = EntityId;
			this.EntityType = EntityType;

		}



		/// <summary>
		/// Gets or Sets EntityJid
		/// </summary>
		[DataMember(Name = "entityJid", EmitDefaultValue = false)]
		public string EntityJid { get; set; }



		/// <summary>
		/// Gets or Sets EntityId
		/// </summary>
		[DataMember(Name = "entityId", EmitDefaultValue = false)]
		public string EntityId { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CollaborateChatGroupMessageEventTopicCollaborateChatEntity {\n");

			sb.Append("  EntityJid: ").Append(EntityJid).Append("\n");
			sb.Append("  EntityId: ").Append(EntityId).Append("\n");
			sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
			return this.Equals(obj as CollaborateChatGroupMessageEventTopicCollaborateChatEntity);
		}

		/// <summary>
		/// Returns true if CollaborateChatGroupMessageEventTopicCollaborateChatEntity instances are equal
		/// </summary>
		/// <param name="other">Instance of CollaborateChatGroupMessageEventTopicCollaborateChatEntity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CollaborateChatGroupMessageEventTopicCollaborateChatEntity other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.EntityJid == other.EntityJid ||
					this.EntityJid != null &&
					this.EntityJid.Equals(other.EntityJid)
				) &&
				(
					this.EntityId == other.EntityId ||
					this.EntityId != null &&
					this.EntityId.Equals(other.EntityId)
				) &&
				(
					this.EntityType == other.EntityType ||
					this.EntityType != null &&
					this.EntityType.Equals(other.EntityType)
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
				if (this.EntityJid != null)
					hash = hash * 59 + this.EntityJid.GetHashCode();

				if (this.EntityId != null)
					hash = hash * 59 + this.EntityId.GetHashCode();

				if (this.EntityType != null)
					hash = hash * 59 + this.EntityType.GetHashCode();

				return hash;
			}
		}
	}

}
