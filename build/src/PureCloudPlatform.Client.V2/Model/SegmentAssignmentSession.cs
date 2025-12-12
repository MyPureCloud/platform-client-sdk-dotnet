using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SegmentAssignmentSession
	/// </summary>
	[DataContract]
	public partial class SegmentAssignmentSession : IEquatable<SegmentAssignmentSession>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentAssignmentSession" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SegmentAssignmentSession() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentAssignmentSession" /> class.
		/// </summary>
		/// <param name="Id">The ID of the session. (required).</param>
		/// <param name="Type">The type or category of session (e.g. web, app). (required).</param>
		public SegmentAssignmentSession(string Id = null, string Type = null)
		{
			this.Id = Id;
			this.Type = Type;

		}



		/// <summary>
		/// The ID of the session.
		/// </summary>
		/// <value>The ID of the session.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The type or category of session (e.g. web, app).
		/// </summary>
		/// <value>The type or category of session (e.g. web, app).</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



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
			sb.Append("class SegmentAssignmentSession {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return this.Equals(obj as SegmentAssignmentSession);
		}

		/// <summary>
		/// Returns true if SegmentAssignmentSession instances are equal
		/// </summary>
		/// <param name="other">Instance of SegmentAssignmentSession to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SegmentAssignmentSession other)
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
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
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

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
