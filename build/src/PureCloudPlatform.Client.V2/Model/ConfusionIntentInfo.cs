using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConfusionIntentInfo
	/// </summary>
	[DataContract]
	public partial class ConfusionIntentInfo : IEquatable<ConfusionIntentInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConfusionIntentInfo" /> class.
		/// </summary>
		/// <param name="UtteranceCount">Number of utterances in this intent which are similar to parent utterance..</param>
		public ConfusionIntentInfo(int? UtteranceCount = null)
		{
			this.UtteranceCount = UtteranceCount;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the object.
		/// </summary>
		/// <value>The name of the object.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; private set; }



		/// <summary>
		/// Number of utterances in this intent which are similar to parent utterance.
		/// </summary>
		/// <value>Number of utterances in this intent which are similar to parent utterance.</value>
		[DataMember(Name = "utteranceCount", EmitDefaultValue = false)]
		public int? UtteranceCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConfusionIntentInfo {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
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
			return this.Equals(obj as ConfusionIntentInfo);
		}

		/// <summary>
		/// Returns true if ConfusionIntentInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of ConfusionIntentInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConfusionIntentInfo other)
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

				return hash;
			}
		}
	}

}
