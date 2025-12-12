using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeImportJobStatistics
	/// </summary>
	[DataContract]
	public partial class KnowledgeImportJobStatistics : IEquatable<KnowledgeImportJobStatistics>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeImportJobStatistics" /> class.
		/// </summary>
		/// <param name="CountDocumentImportActivityCreate">Number of documents will be created by the import..</param>
		/// <param name="CountDocumentImportActivityUpdate">Number of documents will be updated by the import..</param>
		/// <param name="CountDocumentStateDraft">Number of documents will be imported as draft..</param>
		/// <param name="CountDocumentStatePublished">Number of documents will be imported as published..</param>
		/// <param name="CountDocumentValidationSuccess">Number of documents that validated successfully for import..</param>
		/// <param name="CountDocumentValidationFailure">Number of documents that failed validation for import..</param>
		/// <param name="CountDocumentImportSuccess">Number of imported documents..</param>
		/// <param name="CountDocumentImportFailure">Number of documents failed to import..</param>
		/// <param name="CountCategoryValidationSuccess">Number of categories that validated successfully for import..</param>
		/// <param name="CountCategoryValidationFailure">Number of categories that failed validation for import..</param>
		/// <param name="CountCategoryImportSuccess">Number of imported categories..</param>
		/// <param name="CountCategoryImportFailure">Number of categories failed to import..</param>
		/// <param name="CountLabelValidationSuccess">Number of labels that validated successfully for import..</param>
		/// <param name="CountLabelValidationFailure">Number of labels that failed validation for import..</param>
		/// <param name="CountLabelImportSuccess">Number of imported labels..</param>
		/// <param name="CountLabelImportFailure">Number of labels failed to import..</param>
		/// <param name="MigrationDetected">Shows whether the import treated as migration or not..</param>
		public KnowledgeImportJobStatistics(int? CountDocumentImportActivityCreate = null, int? CountDocumentImportActivityUpdate = null, int? CountDocumentStateDraft = null, int? CountDocumentStatePublished = null, int? CountDocumentValidationSuccess = null, int? CountDocumentValidationFailure = null, int? CountDocumentImportSuccess = null, int? CountDocumentImportFailure = null, int? CountCategoryValidationSuccess = null, int? CountCategoryValidationFailure = null, int? CountCategoryImportSuccess = null, int? CountCategoryImportFailure = null, int? CountLabelValidationSuccess = null, int? CountLabelValidationFailure = null, int? CountLabelImportSuccess = null, int? CountLabelImportFailure = null, bool? MigrationDetected = null)
		{
			this.CountDocumentImportActivityCreate = CountDocumentImportActivityCreate;
			this.CountDocumentImportActivityUpdate = CountDocumentImportActivityUpdate;
			this.CountDocumentStateDraft = CountDocumentStateDraft;
			this.CountDocumentStatePublished = CountDocumentStatePublished;
			this.CountDocumentValidationSuccess = CountDocumentValidationSuccess;
			this.CountDocumentValidationFailure = CountDocumentValidationFailure;
			this.CountDocumentImportSuccess = CountDocumentImportSuccess;
			this.CountDocumentImportFailure = CountDocumentImportFailure;
			this.CountCategoryValidationSuccess = CountCategoryValidationSuccess;
			this.CountCategoryValidationFailure = CountCategoryValidationFailure;
			this.CountCategoryImportSuccess = CountCategoryImportSuccess;
			this.CountCategoryImportFailure = CountCategoryImportFailure;
			this.CountLabelValidationSuccess = CountLabelValidationSuccess;
			this.CountLabelValidationFailure = CountLabelValidationFailure;
			this.CountLabelImportSuccess = CountLabelImportSuccess;
			this.CountLabelImportFailure = CountLabelImportFailure;
			this.MigrationDetected = MigrationDetected;

		}



		/// <summary>
		/// Number of documents will be created by the import.
		/// </summary>
		/// <value>Number of documents will be created by the import.</value>
		[DataMember(Name = "countDocumentImportActivityCreate", EmitDefaultValue = false)]
		public int? CountDocumentImportActivityCreate { get; set; }



		/// <summary>
		/// Number of documents will be updated by the import.
		/// </summary>
		/// <value>Number of documents will be updated by the import.</value>
		[DataMember(Name = "countDocumentImportActivityUpdate", EmitDefaultValue = false)]
		public int? CountDocumentImportActivityUpdate { get; set; }



		/// <summary>
		/// Number of documents will be imported as draft.
		/// </summary>
		/// <value>Number of documents will be imported as draft.</value>
		[DataMember(Name = "countDocumentStateDraft", EmitDefaultValue = false)]
		public int? CountDocumentStateDraft { get; set; }



		/// <summary>
		/// Number of documents will be imported as published.
		/// </summary>
		/// <value>Number of documents will be imported as published.</value>
		[DataMember(Name = "countDocumentStatePublished", EmitDefaultValue = false)]
		public int? CountDocumentStatePublished { get; set; }



		/// <summary>
		/// Number of documents that validated successfully for import.
		/// </summary>
		/// <value>Number of documents that validated successfully for import.</value>
		[DataMember(Name = "countDocumentValidationSuccess", EmitDefaultValue = false)]
		public int? CountDocumentValidationSuccess { get; set; }



		/// <summary>
		/// Number of documents that failed validation for import.
		/// </summary>
		/// <value>Number of documents that failed validation for import.</value>
		[DataMember(Name = "countDocumentValidationFailure", EmitDefaultValue = false)]
		public int? CountDocumentValidationFailure { get; set; }



		/// <summary>
		/// Number of imported documents.
		/// </summary>
		/// <value>Number of imported documents.</value>
		[DataMember(Name = "countDocumentImportSuccess", EmitDefaultValue = false)]
		public int? CountDocumentImportSuccess { get; set; }



		/// <summary>
		/// Number of documents failed to import.
		/// </summary>
		/// <value>Number of documents failed to import.</value>
		[DataMember(Name = "countDocumentImportFailure", EmitDefaultValue = false)]
		public int? CountDocumentImportFailure { get; set; }



		/// <summary>
		/// Number of categories that validated successfully for import.
		/// </summary>
		/// <value>Number of categories that validated successfully for import.</value>
		[DataMember(Name = "countCategoryValidationSuccess", EmitDefaultValue = false)]
		public int? CountCategoryValidationSuccess { get; set; }



		/// <summary>
		/// Number of categories that failed validation for import.
		/// </summary>
		/// <value>Number of categories that failed validation for import.</value>
		[DataMember(Name = "countCategoryValidationFailure", EmitDefaultValue = false)]
		public int? CountCategoryValidationFailure { get; set; }



		/// <summary>
		/// Number of imported categories.
		/// </summary>
		/// <value>Number of imported categories.</value>
		[DataMember(Name = "countCategoryImportSuccess", EmitDefaultValue = false)]
		public int? CountCategoryImportSuccess { get; set; }



		/// <summary>
		/// Number of categories failed to import.
		/// </summary>
		/// <value>Number of categories failed to import.</value>
		[DataMember(Name = "countCategoryImportFailure", EmitDefaultValue = false)]
		public int? CountCategoryImportFailure { get; set; }



		/// <summary>
		/// Number of labels that validated successfully for import.
		/// </summary>
		/// <value>Number of labels that validated successfully for import.</value>
		[DataMember(Name = "countLabelValidationSuccess", EmitDefaultValue = false)]
		public int? CountLabelValidationSuccess { get; set; }



		/// <summary>
		/// Number of labels that failed validation for import.
		/// </summary>
		/// <value>Number of labels that failed validation for import.</value>
		[DataMember(Name = "countLabelValidationFailure", EmitDefaultValue = false)]
		public int? CountLabelValidationFailure { get; set; }



		/// <summary>
		/// Number of imported labels.
		/// </summary>
		/// <value>Number of imported labels.</value>
		[DataMember(Name = "countLabelImportSuccess", EmitDefaultValue = false)]
		public int? CountLabelImportSuccess { get; set; }



		/// <summary>
		/// Number of labels failed to import.
		/// </summary>
		/// <value>Number of labels failed to import.</value>
		[DataMember(Name = "countLabelImportFailure", EmitDefaultValue = false)]
		public int? CountLabelImportFailure { get; set; }



		/// <summary>
		/// Shows whether the import treated as migration or not.
		/// </summary>
		/// <value>Shows whether the import treated as migration or not.</value>
		[DataMember(Name = "migrationDetected", EmitDefaultValue = false)]
		public bool? MigrationDetected { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeImportJobStatistics {\n");

			sb.Append("  CountDocumentImportActivityCreate: ").Append(CountDocumentImportActivityCreate).Append("\n");
			sb.Append("  CountDocumentImportActivityUpdate: ").Append(CountDocumentImportActivityUpdate).Append("\n");
			sb.Append("  CountDocumentStateDraft: ").Append(CountDocumentStateDraft).Append("\n");
			sb.Append("  CountDocumentStatePublished: ").Append(CountDocumentStatePublished).Append("\n");
			sb.Append("  CountDocumentValidationSuccess: ").Append(CountDocumentValidationSuccess).Append("\n");
			sb.Append("  CountDocumentValidationFailure: ").Append(CountDocumentValidationFailure).Append("\n");
			sb.Append("  CountDocumentImportSuccess: ").Append(CountDocumentImportSuccess).Append("\n");
			sb.Append("  CountDocumentImportFailure: ").Append(CountDocumentImportFailure).Append("\n");
			sb.Append("  CountCategoryValidationSuccess: ").Append(CountCategoryValidationSuccess).Append("\n");
			sb.Append("  CountCategoryValidationFailure: ").Append(CountCategoryValidationFailure).Append("\n");
			sb.Append("  CountCategoryImportSuccess: ").Append(CountCategoryImportSuccess).Append("\n");
			sb.Append("  CountCategoryImportFailure: ").Append(CountCategoryImportFailure).Append("\n");
			sb.Append("  CountLabelValidationSuccess: ").Append(CountLabelValidationSuccess).Append("\n");
			sb.Append("  CountLabelValidationFailure: ").Append(CountLabelValidationFailure).Append("\n");
			sb.Append("  CountLabelImportSuccess: ").Append(CountLabelImportSuccess).Append("\n");
			sb.Append("  CountLabelImportFailure: ").Append(CountLabelImportFailure).Append("\n");
			sb.Append("  MigrationDetected: ").Append(MigrationDetected).Append("\n");
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
			return this.Equals(obj as KnowledgeImportJobStatistics);
		}

		/// <summary>
		/// Returns true if KnowledgeImportJobStatistics instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeImportJobStatistics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeImportJobStatistics other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.CountDocumentImportActivityCreate == other.CountDocumentImportActivityCreate ||
					this.CountDocumentImportActivityCreate != null &&
					this.CountDocumentImportActivityCreate.Equals(other.CountDocumentImportActivityCreate)
				) &&
				(
					this.CountDocumentImportActivityUpdate == other.CountDocumentImportActivityUpdate ||
					this.CountDocumentImportActivityUpdate != null &&
					this.CountDocumentImportActivityUpdate.Equals(other.CountDocumentImportActivityUpdate)
				) &&
				(
					this.CountDocumentStateDraft == other.CountDocumentStateDraft ||
					this.CountDocumentStateDraft != null &&
					this.CountDocumentStateDraft.Equals(other.CountDocumentStateDraft)
				) &&
				(
					this.CountDocumentStatePublished == other.CountDocumentStatePublished ||
					this.CountDocumentStatePublished != null &&
					this.CountDocumentStatePublished.Equals(other.CountDocumentStatePublished)
				) &&
				(
					this.CountDocumentValidationSuccess == other.CountDocumentValidationSuccess ||
					this.CountDocumentValidationSuccess != null &&
					this.CountDocumentValidationSuccess.Equals(other.CountDocumentValidationSuccess)
				) &&
				(
					this.CountDocumentValidationFailure == other.CountDocumentValidationFailure ||
					this.CountDocumentValidationFailure != null &&
					this.CountDocumentValidationFailure.Equals(other.CountDocumentValidationFailure)
				) &&
				(
					this.CountDocumentImportSuccess == other.CountDocumentImportSuccess ||
					this.CountDocumentImportSuccess != null &&
					this.CountDocumentImportSuccess.Equals(other.CountDocumentImportSuccess)
				) &&
				(
					this.CountDocumentImportFailure == other.CountDocumentImportFailure ||
					this.CountDocumentImportFailure != null &&
					this.CountDocumentImportFailure.Equals(other.CountDocumentImportFailure)
				) &&
				(
					this.CountCategoryValidationSuccess == other.CountCategoryValidationSuccess ||
					this.CountCategoryValidationSuccess != null &&
					this.CountCategoryValidationSuccess.Equals(other.CountCategoryValidationSuccess)
				) &&
				(
					this.CountCategoryValidationFailure == other.CountCategoryValidationFailure ||
					this.CountCategoryValidationFailure != null &&
					this.CountCategoryValidationFailure.Equals(other.CountCategoryValidationFailure)
				) &&
				(
					this.CountCategoryImportSuccess == other.CountCategoryImportSuccess ||
					this.CountCategoryImportSuccess != null &&
					this.CountCategoryImportSuccess.Equals(other.CountCategoryImportSuccess)
				) &&
				(
					this.CountCategoryImportFailure == other.CountCategoryImportFailure ||
					this.CountCategoryImportFailure != null &&
					this.CountCategoryImportFailure.Equals(other.CountCategoryImportFailure)
				) &&
				(
					this.CountLabelValidationSuccess == other.CountLabelValidationSuccess ||
					this.CountLabelValidationSuccess != null &&
					this.CountLabelValidationSuccess.Equals(other.CountLabelValidationSuccess)
				) &&
				(
					this.CountLabelValidationFailure == other.CountLabelValidationFailure ||
					this.CountLabelValidationFailure != null &&
					this.CountLabelValidationFailure.Equals(other.CountLabelValidationFailure)
				) &&
				(
					this.CountLabelImportSuccess == other.CountLabelImportSuccess ||
					this.CountLabelImportSuccess != null &&
					this.CountLabelImportSuccess.Equals(other.CountLabelImportSuccess)
				) &&
				(
					this.CountLabelImportFailure == other.CountLabelImportFailure ||
					this.CountLabelImportFailure != null &&
					this.CountLabelImportFailure.Equals(other.CountLabelImportFailure)
				) &&
				(
					this.MigrationDetected == other.MigrationDetected ||
					this.MigrationDetected != null &&
					this.MigrationDetected.Equals(other.MigrationDetected)
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
				if (this.CountDocumentImportActivityCreate != null)
					hash = hash * 59 + this.CountDocumentImportActivityCreate.GetHashCode();

				if (this.CountDocumentImportActivityUpdate != null)
					hash = hash * 59 + this.CountDocumentImportActivityUpdate.GetHashCode();

				if (this.CountDocumentStateDraft != null)
					hash = hash * 59 + this.CountDocumentStateDraft.GetHashCode();

				if (this.CountDocumentStatePublished != null)
					hash = hash * 59 + this.CountDocumentStatePublished.GetHashCode();

				if (this.CountDocumentValidationSuccess != null)
					hash = hash * 59 + this.CountDocumentValidationSuccess.GetHashCode();

				if (this.CountDocumentValidationFailure != null)
					hash = hash * 59 + this.CountDocumentValidationFailure.GetHashCode();

				if (this.CountDocumentImportSuccess != null)
					hash = hash * 59 + this.CountDocumentImportSuccess.GetHashCode();

				if (this.CountDocumentImportFailure != null)
					hash = hash * 59 + this.CountDocumentImportFailure.GetHashCode();

				if (this.CountCategoryValidationSuccess != null)
					hash = hash * 59 + this.CountCategoryValidationSuccess.GetHashCode();

				if (this.CountCategoryValidationFailure != null)
					hash = hash * 59 + this.CountCategoryValidationFailure.GetHashCode();

				if (this.CountCategoryImportSuccess != null)
					hash = hash * 59 + this.CountCategoryImportSuccess.GetHashCode();

				if (this.CountCategoryImportFailure != null)
					hash = hash * 59 + this.CountCategoryImportFailure.GetHashCode();

				if (this.CountLabelValidationSuccess != null)
					hash = hash * 59 + this.CountLabelValidationSuccess.GetHashCode();

				if (this.CountLabelValidationFailure != null)
					hash = hash * 59 + this.CountLabelValidationFailure.GetHashCode();

				if (this.CountLabelImportSuccess != null)
					hash = hash * 59 + this.CountLabelImportSuccess.GetHashCode();

				if (this.CountLabelImportFailure != null)
					hash = hash * 59 + this.CountLabelImportFailure.GetHashCode();

				if (this.MigrationDetected != null)
					hash = hash * 59 + this.MigrationDetected.GetHashCode();

				return hash;
			}
		}
	}

}
