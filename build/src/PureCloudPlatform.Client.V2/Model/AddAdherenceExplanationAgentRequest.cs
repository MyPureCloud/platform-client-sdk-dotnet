using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AddAdherenceExplanationAgentRequest
	/// </summary>
	[DataContract]
	public partial class AddAdherenceExplanationAgentRequest : IEquatable<AddAdherenceExplanationAgentRequest>
	{
		/// <summary>
		/// The type of the adherence explanation
		/// </summary>
		/// <value>The type of the adherence explanation</value>
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
			/// Enum Late for "Late"
			/// </summary>
			[EnumMember(Value = "Late")]
			Late
		}
		/// <summary>
		/// The type of the adherence explanation
		/// </summary>
		/// <value>The type of the adherence explanation</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="AddAdherenceExplanationAgentRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AddAdherenceExplanationAgentRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AddAdherenceExplanationAgentRequest" /> class.
		/// </summary>
		/// <param name="Type">The type of the adherence explanation (required).</param>
		/// <param name="StartDate">The start timestamp of the adherence explanation in ISO-8601 format (required).</param>
		/// <param name="LengthMinutes">The length of the adherence explanation in minutes (required).</param>
		/// <param name="Notes">Notes about the adherence explanation.</param>
		public AddAdherenceExplanationAgentRequest(TypeEnum? Type = null, DateTime? StartDate = null, int? LengthMinutes = null, string Notes = null)
		{
			this.Type = Type;
			this.StartDate = StartDate;
			this.LengthMinutes = LengthMinutes;
			this.Notes = Notes;

		}





		/// <summary>
		/// The start timestamp of the adherence explanation in ISO-8601 format
		/// </summary>
		/// <value>The start timestamp of the adherence explanation in ISO-8601 format</value>
		[DataMember(Name = "startDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }



		/// <summary>
		/// The length of the adherence explanation in minutes
		/// </summary>
		/// <value>The length of the adherence explanation in minutes</value>
		[DataMember(Name = "lengthMinutes", EmitDefaultValue = false)]
		public int? LengthMinutes { get; set; }



		/// <summary>
		/// Notes about the adherence explanation
		/// </summary>
		/// <value>Notes about the adherence explanation</value>
		[DataMember(Name = "notes", EmitDefaultValue = false)]
		public string Notes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AddAdherenceExplanationAgentRequest {\n");

			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
			sb.Append("  Notes: ").Append(Notes).Append("\n");
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
			return this.Equals(obj as AddAdherenceExplanationAgentRequest);
		}

		/// <summary>
		/// Returns true if AddAdherenceExplanationAgentRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of AddAdherenceExplanationAgentRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AddAdherenceExplanationAgentRequest other)
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
					this.StartDate == other.StartDate ||
					this.StartDate != null &&
					this.StartDate.Equals(other.StartDate)
				) &&
				(
					this.LengthMinutes == other.LengthMinutes ||
					this.LengthMinutes != null &&
					this.LengthMinutes.Equals(other.LengthMinutes)
				) &&
				(
					this.Notes == other.Notes ||
					this.Notes != null &&
					this.Notes.Equals(other.Notes)
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

				if (this.StartDate != null)
					hash = hash * 59 + this.StartDate.GetHashCode();

				if (this.LengthMinutes != null)
					hash = hash * 59 + this.LengthMinutes.GetHashCode();

				if (this.Notes != null)
					hash = hash * 59 + this.Notes.GetHashCode();

				return hash;
			}
		}
	}

}
