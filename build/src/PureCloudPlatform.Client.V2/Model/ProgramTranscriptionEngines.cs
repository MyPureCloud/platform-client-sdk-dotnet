using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ProgramTranscriptionEngines
	/// </summary>
	[DataContract]
	public partial class ProgramTranscriptionEngines : IEquatable<ProgramTranscriptionEngines>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProgramTranscriptionEngines" /> class.
		/// </summary>
		/// <param name="Program">The ID of the program.</param>
		/// <param name="TranscriptionEngines">The program transcription engine settings.</param>
		/// <param name="ModifiedBy">The user last modified the record.</param>
		/// <param name="DateModified">The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public ProgramTranscriptionEngines(BaseProgramEntity Program = null, List<ProgramTranscriptionEngine> TranscriptionEngines = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null)
		{
			this.Program = Program;
			this.TranscriptionEngines = TranscriptionEngines;
			this.ModifiedBy = ModifiedBy;
			this.DateModified = DateModified;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The ID of the program
		/// </summary>
		/// <value>The ID of the program</value>
		[DataMember(Name = "program", EmitDefaultValue = false)]
		public BaseProgramEntity Program { get; set; }



		/// <summary>
		/// The program transcription engine settings
		/// </summary>
		/// <value>The program transcription engine settings</value>
		[DataMember(Name = "transcriptionEngines", EmitDefaultValue = false)]
		public List<ProgramTranscriptionEngine> TranscriptionEngines { get; set; }



		/// <summary>
		/// The user last modified the record
		/// </summary>
		/// <value>The user last modified the record</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public AddressableEntityRef ModifiedBy { get; set; }



		/// <summary>
		/// The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



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
			sb.Append("class ProgramTranscriptionEngines {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Program: ").Append(Program).Append("\n");
			sb.Append("  TranscriptionEngines: ").Append(TranscriptionEngines).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
			return this.Equals(obj as ProgramTranscriptionEngines);
		}

		/// <summary>
		/// Returns true if ProgramTranscriptionEngines instances are equal
		/// </summary>
		/// <param name="other">Instance of ProgramTranscriptionEngines to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ProgramTranscriptionEngines other)
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
					this.Program == other.Program ||
					this.Program != null &&
					this.Program.Equals(other.Program)
				) &&
				(
					this.TranscriptionEngines == other.TranscriptionEngines ||
					this.TranscriptionEngines != null &&
					this.TranscriptionEngines.SequenceEqual(other.TranscriptionEngines)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
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

				if (this.Program != null)
					hash = hash * 59 + this.Program.GetHashCode();

				if (this.TranscriptionEngines != null)
					hash = hash * 59 + this.TranscriptionEngines.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
