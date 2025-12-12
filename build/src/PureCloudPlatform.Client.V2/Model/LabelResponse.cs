using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LabelResponse
	/// </summary>
	[DataContract]
	public partial class LabelResponse : IEquatable<LabelResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LabelResponse" /> class.
		/// </summary>
		/// <param name="Name">The name of the label..</param>
		/// <param name="Color">The color of the label..</param>
		/// <param name="DateCreated">The creation date and time of the label. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateModified">The last modification date and time of the label. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DocumentCount">Number of documents assigned to this label..</param>
		/// <param name="ExternalId">The external id associated with the label..</param>
		public LabelResponse(string Name = null, string Color = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? DocumentCount = null, string ExternalId = null)
		{
			this.Name = Name;
			this.Color = Color;
			this.DateCreated = DateCreated;
			this.DateModified = DateModified;
			this.DocumentCount = DocumentCount;
			this.ExternalId = ExternalId;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the label.
		/// </summary>
		/// <value>The name of the label.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The color of the label.
		/// </summary>
		/// <value>The color of the label.</value>
		[DataMember(Name = "color", EmitDefaultValue = false)]
		public string Color { get; set; }



		/// <summary>
		/// The creation date and time of the label. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The creation date and time of the label. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; set; }



		/// <summary>
		/// The last modification date and time of the label. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The last modification date and time of the label. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// Number of documents assigned to this label.
		/// </summary>
		/// <value>Number of documents assigned to this label.</value>
		[DataMember(Name = "documentCount", EmitDefaultValue = false)]
		public int? DocumentCount { get; set; }



		/// <summary>
		/// The external id associated with the label.
		/// </summary>
		/// <value>The external id associated with the label.</value>
		[DataMember(Name = "externalId", EmitDefaultValue = false)]
		public string ExternalId { get; set; }



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
			sb.Append("class LabelResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Color: ").Append(Color).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
			sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
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
			return this.Equals(obj as LabelResponse);
		}

		/// <summary>
		/// Returns true if LabelResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of LabelResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LabelResponse other)
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
					this.Color == other.Color ||
					this.Color != null &&
					this.Color.Equals(other.Color)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.DocumentCount == other.DocumentCount ||
					this.DocumentCount != null &&
					this.DocumentCount.Equals(other.DocumentCount)
				) &&
				(
					this.ExternalId == other.ExternalId ||
					this.ExternalId != null &&
					this.ExternalId.Equals(other.ExternalId)
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

				if (this.Color != null)
					hash = hash * 59 + this.Color.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.DocumentCount != null)
					hash = hash * 59 + this.DocumentCount.GetHashCode();

				if (this.ExternalId != null)
					hash = hash * 59 + this.ExternalId.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
