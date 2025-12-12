using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConfusionIntentDetails
	/// </summary>
	[DataContract]
	public partial class ConfusionIntentDetails : IEquatable<ConfusionIntentDetails>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConfusionIntentDetails" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="UtteranceCount">Number of utterances in this intent which are similar to parent utterance..</param>
		/// <param name="Utterances">List of utterance which are similar to parent utterance..</param>
		public ConfusionIntentDetails(string Name = null, int? UtteranceCount = null, List<ConfusionUtterance> Utterances = null)
		{
			this.Name = Name;
			this.UtteranceCount = UtteranceCount;
			this.Utterances = Utterances;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Number of utterances in this intent which are similar to parent utterance.
		/// </summary>
		/// <value>Number of utterances in this intent which are similar to parent utterance.</value>
		[DataMember(Name = "utteranceCount", EmitDefaultValue = false)]
		public int? UtteranceCount { get; set; }



		/// <summary>
		/// List of utterance which are similar to parent utterance.
		/// </summary>
		/// <value>List of utterance which are similar to parent utterance.</value>
		[DataMember(Name = "utterances", EmitDefaultValue = false)]
		public List<ConfusionUtterance> Utterances { get; set; }



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
			sb.Append("class ConfusionIntentDetails {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
			sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
			return this.Equals(obj as ConfusionIntentDetails);
		}

		/// <summary>
		/// Returns true if ConfusionIntentDetails instances are equal
		/// </summary>
		/// <param name="other">Instance of ConfusionIntentDetails to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConfusionIntentDetails other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.UtteranceCount == other.UtteranceCount ||
					this.UtteranceCount != null &&
					this.UtteranceCount.Equals(other.UtteranceCount)
				) &&
				(
					this.Utterances == other.Utterances ||
					this.Utterances != null &&
					this.Utterances.SequenceEqual(other.Utterances)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.UtteranceCount != null)
					hash = hash * 59 + this.UtteranceCount.GetHashCode();

				if (this.Utterances != null)
					hash = hash * 59 + this.Utterances.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
