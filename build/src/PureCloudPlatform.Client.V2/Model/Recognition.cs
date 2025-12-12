using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Recognition
	/// </summary>
	[DataContract]
	public partial class Recognition : IEquatable<Recognition>
	{
		/// <summary>
		/// The type of recognition
		/// </summary>
		/// <value>The type of recognition</value>
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
			/// Enum Thankyou for "ThankYou"
			/// </summary>
			[EnumMember(Value = "ThankYou")]
			Thankyou,

			/// <summary>
			/// Enum Congratulations for "Congratulations"
			/// </summary>
			[EnumMember(Value = "Congratulations")]
			Congratulations,

			/// <summary>
			/// Enum Highperformance for "HighPerformance"
			/// </summary>
			[EnumMember(Value = "HighPerformance")]
			Highperformance,

			/// <summary>
			/// Enum Companyvalues for "CompanyValues"
			/// </summary>
			[EnumMember(Value = "CompanyValues")]
			Companyvalues
		}
		/// <summary>
		/// The context type (optional)
		/// </summary>
		/// <value>The context type (optional)</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ContextTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Interaction for "Interaction"
			/// </summary>
			[EnumMember(Value = "Interaction")]
			Interaction,

			/// <summary>
			/// Enum Insights for "Insights"
			/// </summary>
			[EnumMember(Value = "Insights")]
			Insights,

			/// <summary>
			/// Enum Development for "Development"
			/// </summary>
			[EnumMember(Value = "Development")]
			Development,

			/// <summary>
			/// Enum Scorecard for "Scorecard"
			/// </summary>
			[EnumMember(Value = "Scorecard")]
			Scorecard
		}
		/// <summary>
		/// The type of recognition
		/// </summary>
		/// <value>The type of recognition</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// The context type (optional)
		/// </summary>
		/// <value>The context type (optional)</value>
		[DataMember(Name = "contextType", EmitDefaultValue = false)]
		public ContextTypeEnum? ContextType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="Recognition" /> class.
		/// </summary>
		/// <param name="Recipient">The recipient of the recognition.</param>
		/// <param name="CreatedBy">The creator of the recognition.</param>
		/// <param name="DateCreated">The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="Type">The type of recognition.</param>
		/// <param name="Title">The recognition title.</param>
		/// <param name="Note">The recognition note.</param>
		/// <param name="ContextType">The context type (optional).</param>
		/// <param name="ContextId">The context id (optional).</param>
		/// <param name="DateDisplayed">The displayed date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateAcknowledged">The acknowledged date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public Recognition(UserReference Recipient = null, UserReference CreatedBy = null, DateTime? DateCreated = null, TypeEnum? Type = null, string Title = null, string Note = null, ContextTypeEnum? ContextType = null, string ContextId = null, DateTime? DateDisplayed = null, DateTime? DateAcknowledged = null)
		{
			this.Recipient = Recipient;
			this.CreatedBy = CreatedBy;
			this.DateCreated = DateCreated;
			this.Type = Type;
			this.Title = Title;
			this.Note = Note;
			this.ContextType = ContextType;
			this.ContextId = ContextId;
			this.DateDisplayed = DateDisplayed;
			this.DateAcknowledged = DateAcknowledged;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The recipient of the recognition
		/// </summary>
		/// <value>The recipient of the recognition</value>
		[DataMember(Name = "recipient", EmitDefaultValue = false)]
		public UserReference Recipient { get; set; }



		/// <summary>
		/// The creator of the recognition
		/// </summary>
		/// <value>The creator of the recognition</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public UserReference CreatedBy { get; set; }



		/// <summary>
		/// The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }





		/// <summary>
		/// The recognition title
		/// </summary>
		/// <value>The recognition title</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// The recognition note
		/// </summary>
		/// <value>The recognition note</value>
		[DataMember(Name = "note", EmitDefaultValue = false)]
		public string Note { get; set; }





		/// <summary>
		/// The context id (optional)
		/// </summary>
		/// <value>The context id (optional)</value>
		[DataMember(Name = "contextId", EmitDefaultValue = false)]
		public string ContextId { get; set; }



		/// <summary>
		/// The displayed date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The displayed date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateDisplayed", EmitDefaultValue = false)]
		public DateTime? DateDisplayed { get; set; }



		/// <summary>
		/// The acknowledged date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The acknowledged date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateAcknowledged", EmitDefaultValue = false)]
		public DateTime? DateAcknowledged { get; set; }



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
			sb.Append("class Recognition {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Recipient: ").Append(Recipient).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Note: ").Append(Note).Append("\n");
			sb.Append("  ContextType: ").Append(ContextType).Append("\n");
			sb.Append("  ContextId: ").Append(ContextId).Append("\n");
			sb.Append("  DateDisplayed: ").Append(DateDisplayed).Append("\n");
			sb.Append("  DateAcknowledged: ").Append(DateAcknowledged).Append("\n");
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
			return this.Equals(obj as Recognition);
		}

		/// <summary>
		/// Returns true if Recognition instances are equal
		/// </summary>
		/// <param name="other">Instance of Recognition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Recognition other)
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
					this.ContextType == other.ContextType ||
					this.ContextType != null &&
					this.ContextType.Equals(other.ContextType)
				) &&
				(
					this.ContextId == other.ContextId ||
					this.ContextId != null &&
					this.ContextId.Equals(other.ContextId)
				) &&
				(
					this.DateDisplayed == other.DateDisplayed ||
					this.DateDisplayed != null &&
					this.DateDisplayed.Equals(other.DateDisplayed)
				) &&
				(
					this.DateAcknowledged == other.DateAcknowledged ||
					this.DateAcknowledged != null &&
					this.DateAcknowledged.Equals(other.DateAcknowledged)
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

				if (this.ContextType != null)
					hash = hash * 59 + this.ContextType.GetHashCode();

				if (this.ContextId != null)
					hash = hash * 59 + this.ContextId.GetHashCode();

				if (this.DateDisplayed != null)
					hash = hash * 59 + this.DateDisplayed.GetHashCode();

				if (this.DateAcknowledged != null)
					hash = hash * 59 + this.DateAcknowledged.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
