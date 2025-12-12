using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateRecognition
	/// </summary>
	[DataContract]
	public partial class CreateRecognition : IEquatable<CreateRecognition>
	{
		/// <summary>
		/// The type of the recognition
		/// </summary>
		/// <value>The type of the recognition</value>
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
		/// The type of the recognition
		/// </summary>
		/// <value>The type of the recognition</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }
		/// <summary>
		/// The context type (optional)
		/// </summary>
		/// <value>The context type (optional)</value>
		[DataMember(Name = "contextType", EmitDefaultValue = false)]
		public ContextTypeEnum? ContextType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateRecognition" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateRecognition() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateRecognition" /> class.
		/// </summary>
		/// <param name="RecipientId">The recipient of the recognition (required).</param>
		/// <param name="Type">The type of the recognition (required).</param>
		/// <param name="Title">The title of the recognition. Max length of 100 characters (optional).</param>
		/// <param name="Note">The note of the recognition. Max length of 800 characters (optional).</param>
		/// <param name="ContextType">The context type (optional).</param>
		/// <param name="ContextId">The context id (optional).</param>
		public CreateRecognition(string RecipientId = null, TypeEnum? Type = null, string Title = null, string Note = null, ContextTypeEnum? ContextType = null, string ContextId = null)
		{
			this.RecipientId = RecipientId;
			this.Type = Type;
			this.Title = Title;
			this.Note = Note;
			this.ContextType = ContextType;
			this.ContextId = ContextId;

		}



		/// <summary>
		/// The recipient of the recognition
		/// </summary>
		/// <value>The recipient of the recognition</value>
		[DataMember(Name = "recipientId", EmitDefaultValue = false)]
		public string RecipientId { get; set; }





		/// <summary>
		/// The title of the recognition. Max length of 100 characters (optional)
		/// </summary>
		/// <value>The title of the recognition. Max length of 100 characters (optional)</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// The note of the recognition. Max length of 800 characters (optional)
		/// </summary>
		/// <value>The note of the recognition. Max length of 800 characters (optional)</value>
		[DataMember(Name = "note", EmitDefaultValue = false)]
		public string Note { get; set; }





		/// <summary>
		/// The context id (optional)
		/// </summary>
		/// <value>The context id (optional)</value>
		[DataMember(Name = "contextId", EmitDefaultValue = false)]
		public string ContextId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateRecognition {\n");

			sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Note: ").Append(Note).Append("\n");
			sb.Append("  ContextType: ").Append(ContextType).Append("\n");
			sb.Append("  ContextId: ").Append(ContextId).Append("\n");
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
			return this.Equals(obj as CreateRecognition);
		}

		/// <summary>
		/// Returns true if CreateRecognition instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateRecognition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateRecognition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RecipientId == other.RecipientId ||
					this.RecipientId != null &&
					this.RecipientId.Equals(other.RecipientId)
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
				if (this.RecipientId != null)
					hash = hash * 59 + this.RecipientId.GetHashCode();

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

				return hash;
			}
		}
	}

}
