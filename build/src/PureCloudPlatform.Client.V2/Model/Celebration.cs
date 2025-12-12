using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Celebration
	/// </summary>
	[DataContract]
	public partial class Celebration : IEquatable<Celebration>
	{
		/// <summary>
		/// The Celebration Type
		/// </summary>
		/// <value>The Celebration Type</value>
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
			/// Enum Recognition for "Recognition"
			/// </summary>
			[EnumMember(Value = "Recognition")]
			Recognition,

			/// <summary>
			/// Enum Contestcomplete for "ContestComplete"
			/// </summary>
			[EnumMember(Value = "ContestComplete")]
			Contestcomplete
		}
		/// <summary>
		/// The Celebration Type
		/// </summary>
		/// <value>The Celebration Type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="Celebration" /> class.
		/// </summary>
		/// <param name="Recipient">The Recipient of the celebration.</param>
		/// <param name="CreatedBy">The creator of the celebration.</param>
		/// <param name="DateCreated">The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Type">The Celebration Type.</param>
		/// <param name="Title">The Celebration title.</param>
		/// <param name="Note">The Celebration note.</param>
		/// <param name="SourceEntity">The celebration&#39;s source entity.</param>
		public Celebration(UserReference Recipient = null, UserReference CreatedBy = null, DateTime? DateCreated = null, TypeEnum? Type = null, string Title = null, string Note = null, SourceEntity SourceEntity = null)
		{
			this.Recipient = Recipient;
			this.CreatedBy = CreatedBy;
			this.DateCreated = DateCreated;
			this.Type = Type;
			this.Title = Title;
			this.Note = Note;
			this.SourceEntity = SourceEntity;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The Recipient of the celebration
		/// </summary>
		/// <value>The Recipient of the celebration</value>
		[DataMember(Name = "recipient", EmitDefaultValue = false)]
		public UserReference Recipient { get; set; }



		/// <summary>
		/// The creator of the celebration
		/// </summary>
		/// <value>The creator of the celebration</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; set; }



		/// <summary>
		/// The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the celebration was created on. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }





		/// <summary>
		/// The Celebration title
		/// </summary>
		/// <value>The Celebration title</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// The Celebration note
		/// </summary>
		/// <value>The Celebration note</value>
		[DataMember(Name = "note", EmitDefaultValue = false)]
		public string Note { get; set; }



		/// <summary>
		/// The celebration&#39;s source entity
		/// </summary>
		/// <value>The celebration&#39;s source entity</value>
		[DataMember(Name = "sourceEntity", EmitDefaultValue = false)]
		public SourceEntity SourceEntity { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Celebration {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Recipient: ").Append(Recipient).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Note: ").Append(Note).Append("\n");
			sb.Append("  SourceEntity: ").Append(SourceEntity).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as Celebration);
		}

		/// <summary>
		/// Returns true if Celebration instances are equal
		/// </summary>
		/// <param name="other">Instance of Celebration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Celebration other)
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
					this.Recipient == other.Recipient ||
					this.Recipient != null &&
					this.Recipient.Equals(other.Recipient)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Note == other.Note ||
					this.Note != null &&
					this.Note.Equals(other.Note)
				) &&
				(
					this.SourceEntity == other.SourceEntity ||
					this.SourceEntity != null &&
					this.SourceEntity.Equals(other.SourceEntity)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Recipient != null)
					hash = hash * 59 + this.Recipient.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Note != null)
					hash = hash * 59 + this.Note.GetHashCode();

				if (this.SourceEntity != null)
					hash = hash * 59 + this.SourceEntity.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
