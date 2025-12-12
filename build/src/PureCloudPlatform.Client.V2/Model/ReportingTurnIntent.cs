using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ReportingTurnIntent
	/// </summary>
	[DataContract]
	public partial class ReportingTurnIntent : IEquatable<ReportingTurnIntent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ReportingTurnIntent" /> class.
		/// </summary>
		/// <param name="Name">The name of the intent detected during this reporting turn..</param>
		/// <param name="Confidence">The confidence score of the intent detected during this reporting turn..</param>
		/// <param name="Slots">The slots detected during this reporting turn..</param>
		public ReportingTurnIntent(string Name = null, double? Confidence = null, List<ReportingTurnIntentSlot> Slots = null)
		{
			this.Name = Name;
			this.Confidence = Confidence;
			this.Slots = Slots;

		}



		/// <summary>
		/// The name of the intent detected during this reporting turn.
		/// </summary>
		/// <value>The name of the intent detected during this reporting turn.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The confidence score of the intent detected during this reporting turn.
		/// </summary>
		/// <value>The confidence score of the intent detected during this reporting turn.</value>
		[DataMember(Name = "confidence", EmitDefaultValue = false)]
		public double? Confidence { get; set; }



		/// <summary>
		/// The slots detected during this reporting turn.
		/// </summary>
		/// <value>The slots detected during this reporting turn.</value>
		[DataMember(Name = "slots", EmitDefaultValue = false)]
		public List<ReportingTurnIntentSlot> Slots { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ReportingTurnIntent {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Confidence: ").Append(Confidence).Append("\n");
			sb.Append("  Slots: ").Append(Slots).Append("\n");
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
			return this.Equals(obj as ReportingTurnIntent);
		}

		/// <summary>
		/// Returns true if ReportingTurnIntent instances are equal
		/// </summary>
		/// <param name="other">Instance of ReportingTurnIntent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ReportingTurnIntent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Confidence == other.Confidence ||
					this.Confidence != null &&
					this.Confidence.Equals(other.Confidence)
				) &&
				(
					this.Slots == other.Slots ||
					this.Slots != null &&
					this.Slots.SequenceEqual(other.Slots)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Confidence != null)
					hash = hash * 59 + this.Confidence.GetHashCode();

				if (this.Slots != null)
					hash = hash * 59 + this.Slots.GetHashCode();

				return hash;
			}
		}
	}

}
