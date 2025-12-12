using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// KnowledgeSyncJobStatistics
	/// </summary>
	[DataContract]
	public partial class KnowledgeSyncJobStatistics : IEquatable<KnowledgeSyncJobStatistics>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KnowledgeSyncJobStatistics" /> class.
		/// </summary>
		/// <param name="CountDocumentImportActivityCreate">Number of documents will be created by the sync..</param>
		/// <param name="CountDocumentImportActivityUpdate">Number of documents will be updated by the sync..</param>
		/// <param name="CountDocumentStateDraft">Number of documents will be imported as draft..</param>
		/// <param name="CountDocumentStatePublished">Number of documents will be imported as published..</param>
		/// <param name="CountDocumentImportSuccess">Number of imported documents..</param>
		/// <param name="CountDocumentImportFailure">Number of documents failed to import..</param>
		/// <param name="CountCategoryImportSuccess">Number of imported categories..</param>
		/// <param name="CountCategoryImportFailure">Number of categories failed to import..</param>
		/// <param name="CountLabelImportSuccess">Number of imported labels..</param>
		/// <param name="CountLabelImportFailure">Number of labels failed to import..</param>
		/// <param name="CountDocumentDeleteSuccess">Number of documents will be deleted by the sync..</param>
		/// <param name="CountDocumentDeleteFailure">Number of documents failed to delete..</param>
		/// <param name="CountCategoryDeleteSuccess">Number of successfully deleted categories..</param>
		/// <param name="CountCategoryDeleteFailure">Number of categories failed to delete..</param>
		/// <param name="CountLabelDeleteSuccess">Number of successfully deleted labels..</param>
		/// <param name="CountLabelDeleteFailure">Number of labels failed to delete..</param>
		public KnowledgeSyncJobStatistics(int? CountDocumentImportActivityCreate = null, int? CountDocumentImportActivityUpdate = null, int? CountDocumentStateDraft = null, int? CountDocumentStatePublished = null, int? CountDocumentImportSuccess = null, int? CountDocumentImportFailure = null, int? CountCategoryImportSuccess = null, int? CountCategoryImportFailure = null, int? CountLabelImportSuccess = null, int? CountLabelImportFailure = null, int? CountDocumentDeleteSuccess = null, int? CountDocumentDeleteFailure = null, int? CountCategoryDeleteSuccess = null, int? CountCategoryDeleteFailure = null, int? CountLabelDeleteSuccess = null, int? CountLabelDeleteFailure = null)
		{
			this.CountDocumentImportActivityCreate = CountDocumentImportActivityCreate;
			this.CountDocumentImportActivityUpdate = CountDocumentImportActivityUpdate;
			this.CountDocumentStateDraft = CountDocumentStateDraft;
			this.CountDocumentStatePublished = CountDocumentStatePublished;
			this.CountDocumentImportSuccess = CountDocumentImportSuccess;
			this.CountDocumentImportFailure = CountDocumentImportFailure;
			this.CountCategoryImportSuccess = CountCategoryImportSuccess;
			this.CountCategoryImportFailure = CountCategoryImportFailure;
			this.CountLabelImportSuccess = CountLabelImportSuccess;
			this.CountLabelImportFailure = CountLabelImportFailure;
			this.CountDocumentDeleteSuccess = CountDocumentDeleteSuccess;
			this.CountDocumentDeleteFailure = CountDocumentDeleteFailure;
			this.CountCategoryDeleteSuccess = CountCategoryDeleteSuccess;
			this.CountCategoryDeleteFailure = CountCategoryDeleteFailure;
			this.CountLabelDeleteSuccess = CountLabelDeleteSuccess;
			this.CountLabelDeleteFailure = CountLabelDeleteFailure;

		}



		/// <summary>
		/// Number of documents will be created by the sync.
		/// </summary>
		/// <value>Number of documents will be created by the sync.</value>
		[DataMember(Name = "countDocumentImportActivityCreate", EmitDefaultValue = false)]
		public int? CountDocumentImportActivityCreate { get; set; }



		/// <summary>
		/// Number of documents will be updated by the sync.
		/// </summary>
		/// <value>Number of documents will be updated by the sync.</value>
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
		/// Number of documents will be deleted by the sync.
		/// </summary>
		/// <value>Number of documents will be deleted by the sync.</value>
		[DataMember(Name = "countDocumentDeleteSuccess", EmitDefaultValue = false)]
		public int? CountDocumentDeleteSuccess { get; set; }



		/// <summary>
		/// Number of documents failed to delete.
		/// </summary>
		/// <value>Number of documents failed to delete.</value>
		[DataMember(Name = "countDocumentDeleteFailure", EmitDefaultValue = false)]
		public int? CountDocumentDeleteFailure { get; set; }



		/// <summary>
		/// Number of successfully deleted categories.
		/// </summary>
		/// <value>Number of successfully deleted categories.</value>
		[DataMember(Name = "countCategoryDeleteSuccess", EmitDefaultValue = false)]
		public int? CountCategoryDeleteSuccess { get; set; }



		/// <summary>
		/// Number of categories failed to delete.
		/// </summary>
		/// <value>Number of categories failed to delete.</value>
		[DataMember(Name = "countCategoryDeleteFailure", EmitDefaultValue = false)]
		public int? CountCategoryDeleteFailure { get; set; }



		/// <summary>
		/// Number of successfully deleted labels.
		/// </summary>
		/// <value>Number of successfully deleted labels.</value>
		[DataMember(Name = "countLabelDeleteSuccess", EmitDefaultValue = false)]
		public int? CountLabelDeleteSuccess { get; set; }



		/// <summary>
		/// Number of labels failed to delete.
		/// </summary>
		/// <value>Number of labels failed to delete.</value>
		[DataMember(Name = "countLabelDeleteFailure", EmitDefaultValue = false)]
		public int? CountLabelDeleteFailure { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class KnowledgeSyncJobStatistics {\n");

			sb.Append("  CountDocumentImportActivityCreate: ").Append(CountDocumentImportActivityCreate).Append("\n");
			sb.Append("  CountDocumentImportActivityUpdate: ").Append(CountDocumentImportActivityUpdate).Append("\n");
			sb.Append("  CountDocumentStateDraft: ").Append(CountDocumentStateDraft).Append("\n");
			sb.Append("  CountDocumentStatePublished: ").Append(CountDocumentStatePublished).Append("\n");
			sb.Append("  CountDocumentImportSuccess: ").Append(CountDocumentImportSuccess).Append("\n");
			sb.Append("  CountDocumentImportFailure: ").Append(CountDocumentImportFailure).Append("\n");
			sb.Append("  CountCategoryImportSuccess: ").Append(CountCategoryImportSuccess).Append("\n");
			sb.Append("  CountCategoryImportFailure: ").Append(CountCategoryImportFailure).Append("\n");
			sb.Append("  CountLabelImportSuccess: ").Append(CountLabelImportSuccess).Append("\n");
			sb.Append("  CountLabelImportFailure: ").Append(CountLabelImportFailure).Append("\n");
			sb.Append("  CountDocumentDeleteSuccess: ").Append(CountDocumentDeleteSuccess).Append("\n");
			sb.Append("  CountDocumentDeleteFailure: ").Append(CountDocumentDeleteFailure).Append("\n");
			sb.Append("  CountCategoryDeleteSuccess: ").Append(CountCategoryDeleteSuccess).Append("\n");
			sb.Append("  CountCategoryDeleteFailure: ").Append(CountCategoryDeleteFailure).Append("\n");
			sb.Append("  CountLabelDeleteSuccess: ").Append(CountLabelDeleteSuccess).Append("\n");
			sb.Append("  CountLabelDeleteFailure: ").Append(CountLabelDeleteFailure).Append("\n");
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
			return this.Equals(obj as KnowledgeSyncJobStatistics);
		}

		/// <summary>
		/// Returns true if KnowledgeSyncJobStatistics instances are equal
		/// </summary>
		/// <param name="other">Instance of KnowledgeSyncJobStatistics to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowledgeSyncJobStatistics other)
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
					this.CountDocumentDeleteSuccess == other.CountDocumentDeleteSuccess ||
					this.CountDocumentDeleteSuccess != null &&
					this.CountDocumentDeleteSuccess.Equals(other.CountDocumentDeleteSuccess)
				) &&
				(
					this.CountDocumentDeleteFailure == other.CountDocumentDeleteFailure ||
					this.CountDocumentDeleteFailure != null &&
					this.CountDocumentDeleteFailure.Equals(other.CountDocumentDeleteFailure)
				) &&
				(
					this.CountCategoryDeleteSuccess == other.CountCategoryDeleteSuccess ||
					this.CountCategoryDeleteSuccess != null &&
					this.CountCategoryDeleteSuccess.Equals(other.CountCategoryDeleteSuccess)
				) &&
				(
					this.CountCategoryDeleteFailure == other.CountCategoryDeleteFailure ||
					this.CountCategoryDeleteFailure != null &&
					this.CountCategoryDeleteFailure.Equals(other.CountCategoryDeleteFailure)
				) &&
				(
					this.CountLabelDeleteSuccess == other.CountLabelDeleteSuccess ||
					this.CountLabelDeleteSuccess != null &&
					this.CountLabelDeleteSuccess.Equals(other.CountLabelDeleteSuccess)
				) &&
				(
					this.CountLabelDeleteFailure == other.CountLabelDeleteFailure ||
					this.CountLabelDeleteFailure != null &&
					this.CountLabelDeleteFailure.Equals(other.CountLabelDeleteFailure)
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

				if (this.CountDocumentImportSuccess != null)
					hash = hash * 59 + this.CountDocumentImportSuccess.GetHashCode();

				if (this.CountDocumentImportFailure != null)
					hash = hash * 59 + this.CountDocumentImportFailure.GetHashCode();

				if (this.CountCategoryImportSuccess != null)
					hash = hash * 59 + this.CountCategoryImportSuccess.GetHashCode();

				if (this.CountCategoryImportFailure != null)
					hash = hash * 59 + this.CountCategoryImportFailure.GetHashCode();

				if (this.CountLabelImportSuccess != null)
					hash = hash * 59 + this.CountLabelImportSuccess.GetHashCode();

				if (this.CountLabelImportFailure != null)
					hash = hash * 59 + this.CountLabelImportFailure.GetHashCode();

				if (this.CountDocumentDeleteSuccess != null)
					hash = hash * 59 + this.CountDocumentDeleteSuccess.GetHashCode();

				if (this.CountDocumentDeleteFailure != null)
					hash = hash * 59 + this.CountDocumentDeleteFailure.GetHashCode();

				if (this.CountCategoryDeleteSuccess != null)
					hash = hash * 59 + this.CountCategoryDeleteSuccess.GetHashCode();

				if (this.CountCategoryDeleteFailure != null)
					hash = hash * 59 + this.CountCategoryDeleteFailure.GetHashCode();

				if (this.CountLabelDeleteSuccess != null)
					hash = hash * 59 + this.CountLabelDeleteSuccess.GetHashCode();

				if (this.CountLabelDeleteFailure != null)
					hash = hash * 59 + this.CountLabelDeleteFailure.GetHashCode();

				return hash;
			}
		}
	}

}
