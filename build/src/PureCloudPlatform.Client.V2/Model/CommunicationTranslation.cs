using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CommunicationTranslation
	/// </summary>
	[DataContract]
	public partial class CommunicationTranslation : IEquatable<CommunicationTranslation>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CommunicationTranslation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CommunicationTranslation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CommunicationTranslation" /> class.
		/// </summary>
		/// <param name="CommunicationId">Communication Id (required).</param>
		/// <param name="Transcripts">List of translated transcripts (required).</param>
		public CommunicationTranslation(string CommunicationId = null, List<TranscriptTranslation> Transcripts = null)
		{
			this.CommunicationId = CommunicationId;
			this.Transcripts = Transcripts;

		}



		/// <summary>
		/// Communication Id
		/// </summary>
		/// <value>Communication Id</value>
		[DataMember(Name = "communicationId", EmitDefaultValue = false)]
		public string CommunicationId { get; set; }



		/// <summary>
		/// List of translated transcripts
		/// </summary>
		/// <value>List of translated transcripts</value>
		[DataMember(Name = "transcripts", EmitDefaultValue = false)]
		public List<TranscriptTranslation> Transcripts { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CommunicationTranslation {\n");

			sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
			sb.Append("  Transcripts: ").Append(Transcripts).Append("\n");
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
			return this.Equals(obj as CommunicationTranslation);
		}

		/// <summary>
		/// Returns true if CommunicationTranslation instances are equal
		/// </summary>
		/// <param name="other">Instance of CommunicationTranslation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CommunicationTranslation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CommunicationId == other.CommunicationId ||
					this.CommunicationId != null &&
					this.CommunicationId.Equals(other.CommunicationId)
				) &&
				(
					this.Transcripts == other.Transcripts ||
					this.Transcripts != null &&
					this.Transcripts.SequenceEqual(other.Transcripts)
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
				if (this.CommunicationId != null)
					hash = hash * 59 + this.CommunicationId.GetHashCode();

				if (this.Transcripts != null)
					hash = hash * 59 + this.Transcripts.GetHashCode();

				return hash;
			}
		}
	}

}
