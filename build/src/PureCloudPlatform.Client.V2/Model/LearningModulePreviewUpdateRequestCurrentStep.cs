using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Learning module preview update request current step
	/// </summary>
	[DataContract]
	public partial class LearningModulePreviewUpdateRequestCurrentStep : IEquatable<LearningModulePreviewUpdateRequestCurrentStep>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningModulePreviewUpdateRequestCurrentStep" /> class.
		/// </summary>
		/// <param name="Id">The id of this step.</param>
		/// <param name="CompletionPercentage">The completion percentage for this step.</param>
		/// <param name="ShareableContentObject">The SCO (Shareable Content Object) data.</param>
		public LearningModulePreviewUpdateRequestCurrentStep(string Id = null, float? CompletionPercentage = null, LearningShareableContentObject ShareableContentObject = null)
		{
			this.Id = Id;
			this.CompletionPercentage = CompletionPercentage;
			this.ShareableContentObject = ShareableContentObject;

		}



		/// <summary>
		/// The id of this step
		/// </summary>
		/// <value>The id of this step</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The completion percentage for this step
		/// </summary>
		/// <value>The completion percentage for this step</value>
		[DataMember(Name = "completionPercentage", EmitDefaultValue = false)]
		public float? CompletionPercentage { get; set; }



		/// <summary>
		/// The SCO (Shareable Content Object) data
		/// </summary>
		/// <value>The SCO (Shareable Content Object) data</value>
		[DataMember(Name = "shareableContentObject", EmitDefaultValue = false)]
		public LearningShareableContentObject ShareableContentObject { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningModulePreviewUpdateRequestCurrentStep {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
			sb.Append("  ShareableContentObject: ").Append(ShareableContentObject).Append("\n");
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
			return this.Equals(obj as LearningModulePreviewUpdateRequestCurrentStep);
		}

		/// <summary>
		/// Returns true if LearningModulePreviewUpdateRequestCurrentStep instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningModulePreviewUpdateRequestCurrentStep to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningModulePreviewUpdateRequestCurrentStep other)
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
					this.CompletionPercentage == other.CompletionPercentage ||
					this.CompletionPercentage != null &&
					this.CompletionPercentage.Equals(other.CompletionPercentage)
				) &&
				(
					this.ShareableContentObject == other.ShareableContentObject ||
					this.ShareableContentObject != null &&
					this.ShareableContentObject.Equals(other.ShareableContentObject)
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

				if (this.CompletionPercentage != null)
					hash = hash * 59 + this.CompletionPercentage.GetHashCode();

				if (this.ShareableContentObject != null)
					hash = hash * 59 + this.ShareableContentObject.GetHashCode();

				return hash;
			}
		}
	}

}
