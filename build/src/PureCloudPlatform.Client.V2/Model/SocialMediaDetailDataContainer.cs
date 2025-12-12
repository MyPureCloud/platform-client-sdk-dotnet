using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SocialMediaDetailDataContainer
	/// </summary>
	[DataContract]
	public partial class SocialMediaDetailDataContainer : IEquatable<SocialMediaDetailDataContainer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SocialMediaDetailDataContainer" /> class.
		/// </summary>
		/// <param name="Interval">Interval.</param>
		/// <param name="Messages">Messages.</param>
		public SocialMediaDetailDataContainer(string Interval = null, List<SocialMediaDetailMessageContainer> Messages = null)
		{
			this.Interval = Interval;
			this.Messages = Messages;

		}



		/// <summary>
		/// Gets or Sets Interval
		/// </summary>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// Gets or Sets Messages
		/// </summary>
		[DataMember(Name = "messages", EmitDefaultValue = false)]
		public List<SocialMediaDetailMessageContainer> Messages { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SocialMediaDetailDataContainer {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  Messages: ").Append(Messages).Append("\n");
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
			return this.Equals(obj as SocialMediaDetailDataContainer);
		}

		/// <summary>
		/// Returns true if SocialMediaDetailDataContainer instances are equal
		/// </summary>
		/// <param name="other">Instance of SocialMediaDetailDataContainer to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SocialMediaDetailDataContainer other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
				) &&
				(
					this.Messages == other.Messages ||
					this.Messages != null &&
					this.Messages.SequenceEqual(other.Messages)
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
				if (this.Interval != null)
					hash = hash * 59 + this.Interval.GetHashCode();

				if (this.Messages != null)
					hash = hash * 59 + this.Messages.GetHashCode();

				return hash;
			}
		}
	}

}
