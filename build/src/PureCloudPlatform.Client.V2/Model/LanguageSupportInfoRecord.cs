using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LanguageSupportInfoRecord
	/// </summary>
	[DataContract]
	public partial class LanguageSupportInfoRecord : IEquatable<LanguageSupportInfoRecord>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LanguageSupportInfoRecord" /> class.
		/// </summary>
		public LanguageSupportInfoRecord()
		{

		}



		/// <summary>
		/// Language of the copilot, e.g. &#39;en-US&#39;.
		/// </summary>
		/// <value>Language of the copilot, e.g. &#39;en-US&#39;.</value>
		[DataMember(Name = "language", EmitDefaultValue = false)]
		public string Language { get; private set; }



		/// <summary>
		/// Information about the support of features.
		/// </summary>
		/// <value>Information about the support of features.</value>
		[DataMember(Name = "featureSupport", EmitDefaultValue = false)]
		public List<FeatureSupport> FeatureSupport { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LanguageSupportInfoRecord {\n");

			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  FeatureSupport: ").Append(FeatureSupport).Append("\n");
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
			return this.Equals(obj as LanguageSupportInfoRecord);
		}

		/// <summary>
		/// Returns true if LanguageSupportInfoRecord instances are equal
		/// </summary>
		/// <param name="other">Instance of LanguageSupportInfoRecord to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LanguageSupportInfoRecord other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Language == other.Language ||
					this.Language != null &&
					this.Language.Equals(other.Language)
				) &&
				(
					this.FeatureSupport == other.FeatureSupport ||
					this.FeatureSupport != null &&
					this.FeatureSupport.SequenceEqual(other.FeatureSupport)
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
				if (this.Language != null)
					hash = hash * 59 + this.Language.GetHashCode();

				if (this.FeatureSupport != null)
					hash = hash * 59 + this.FeatureSupport.GetHashCode();

				return hash;
			}
		}
	}

}
