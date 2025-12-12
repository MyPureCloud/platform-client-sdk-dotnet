using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// JourneyAppEventsNotificationMktCampaign
	/// </summary>
	[DataContract]
	public partial class JourneyAppEventsNotificationMktCampaign : IEquatable<JourneyAppEventsNotificationMktCampaign>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyAppEventsNotificationMktCampaign" /> class.
		/// </summary>
		/// <param name="Content">Content.</param>
		/// <param name="Medium">Medium.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Source">Source.</param>
		/// <param name="Term">Term.</param>
		/// <param name="ClickId">ClickId.</param>
		/// <param name="Network">Network.</param>
		public JourneyAppEventsNotificationMktCampaign(string Content = null, string Medium = null, string Name = null, string Source = null, string Term = null, string ClickId = null, string Network = null)
		{
			this.Content = Content;
			this.Medium = Medium;
			this.Name = Name;
			this.Source = Source;
			this.Term = Term;
			this.ClickId = ClickId;
			this.Network = Network;

		}



		/// <summary>
		/// Gets or Sets Content
		/// </summary>
		[DataMember(Name = "content", EmitDefaultValue = false)]
		public string Content { get; set; }



		/// <summary>
		/// Gets or Sets Medium
		/// </summary>
		[DataMember(Name = "medium", EmitDefaultValue = false)]
		public string Medium { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string Source { get; set; }



		/// <summary>
		/// Gets or Sets Term
		/// </summary>
		[DataMember(Name = "term", EmitDefaultValue = false)]
		public string Term { get; set; }



		/// <summary>
		/// Gets or Sets ClickId
		/// </summary>
		[DataMember(Name = "clickId", EmitDefaultValue = false)]
		public string ClickId { get; set; }



		/// <summary>
		/// Gets or Sets Network
		/// </summary>
		[DataMember(Name = "network", EmitDefaultValue = false)]
		public string Network { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JourneyAppEventsNotificationMktCampaign {\n");

			sb.Append("  Content: ").Append(Content).Append("\n");
			sb.Append("  Medium: ").Append(Medium).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  Term: ").Append(Term).Append("\n");
			sb.Append("  ClickId: ").Append(ClickId).Append("\n");
			sb.Append("  Network: ").Append(Network).Append("\n");
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
			return this.Equals(obj as JourneyAppEventsNotificationMktCampaign);
		}

		/// <summary>
		/// Returns true if JourneyAppEventsNotificationMktCampaign instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyAppEventsNotificationMktCampaign to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyAppEventsNotificationMktCampaign other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Content == other.Content ||
					this.Content != null &&
					this.Content.Equals(other.Content)
				) &&
				(
					this.Medium == other.Medium ||
					this.Medium != null &&
					this.Medium.Equals(other.Medium)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
				) &&
				(
					this.Term == other.Term ||
					this.Term != null &&
					this.Term.Equals(other.Term)
				) &&
				(
					this.ClickId == other.ClickId ||
					this.ClickId != null &&
					this.ClickId.Equals(other.ClickId)
				) &&
				(
					this.Network == other.Network ||
					this.Network != null &&
					this.Network.Equals(other.Network)
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
				if (this.Content != null)
					hash = hash * 59 + this.Content.GetHashCode();

				if (this.Medium != null)
					hash = hash * 59 + this.Medium.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				if (this.Term != null)
					hash = hash * 59 + this.Term.GetHashCode();

				if (this.ClickId != null)
					hash = hash * 59 + this.ClickId.GetHashCode();

				if (this.Network != null)
					hash = hash * 59 + this.Network.GetHashCode();

				return hash;
			}
		}
	}

}
