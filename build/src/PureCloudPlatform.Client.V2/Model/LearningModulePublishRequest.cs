using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Learning module publish request
	/// </summary>
	[DataContract]
	public partial class LearningModulePublishRequest : IEquatable<LearningModulePublishRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningModulePublishRequest" /> class.
		/// </summary>
		/// <param name="TermsAndConditionsAccepted">Whether the terms and conditions were accepted.</param>
		public LearningModulePublishRequest(bool? TermsAndConditionsAccepted = null)
		{
			this.TermsAndConditionsAccepted = TermsAndConditionsAccepted;

		}



		/// <summary>
		/// Whether the terms and conditions were accepted
		/// </summary>
		/// <value>Whether the terms and conditions were accepted</value>
		[DataMember(Name = "termsAndConditionsAccepted", EmitDefaultValue = false)]
		public bool? TermsAndConditionsAccepted { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningModulePublishRequest {\n");

			sb.Append("  TermsAndConditionsAccepted: ").Append(TermsAndConditionsAccepted).Append("\n");
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
			return this.Equals(obj as LearningModulePublishRequest);
		}

		/// <summary>
		/// Returns true if LearningModulePublishRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningModulePublishRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningModulePublishRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TermsAndConditionsAccepted == other.TermsAndConditionsAccepted ||
					this.TermsAndConditionsAccepted != null &&
					this.TermsAndConditionsAccepted.Equals(other.TermsAndConditionsAccepted)
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
				if (this.TermsAndConditionsAccepted != null)
					hash = hash * 59 + this.TermsAndConditionsAccepted.GetHashCode();

				return hash;
			}
		}
	}

}
