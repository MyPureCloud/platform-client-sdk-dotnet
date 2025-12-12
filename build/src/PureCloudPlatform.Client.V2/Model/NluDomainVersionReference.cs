using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NluDomainVersionReference
	/// </summary>
	[DataContract]
	public partial class NluDomainVersionReference : IEquatable<NluDomainVersionReference>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NluDomainVersionReference" /> class.
		/// </summary>
		/// <param name="Intents">The intents defined for this NLU domain version..</param>
		public NluDomainVersionReference(List<IntentReference> Intents = null)
		{
			this.Intents = Intents;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The NLU domain of the version.
		/// </summary>
		/// <value>The NLU domain of the version.</value>
		[DataMember(Name = "domain", EmitDefaultValue = false)]
		public NluDomain Domain { get; private set; }



		/// <summary>
		/// The intents defined for this NLU domain version.
		/// </summary>
		/// <value>The intents defined for this NLU domain version.</value>
		[DataMember(Name = "intents", EmitDefaultValue = false)]
		public List<IntentReference> Intents { get; set; }



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
			sb.Append("class NluDomainVersionReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Domain: ").Append(Domain).Append("\n");
			sb.Append("  Intents: ").Append(Intents).Append("\n");
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
			return this.Equals(obj as NluDomainVersionReference);
		}

		/// <summary>
		/// Returns true if NluDomainVersionReference instances are equal
		/// </summary>
		/// <param name="other">Instance of NluDomainVersionReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NluDomainVersionReference other)
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
					this.Domain == other.Domain ||
					this.Domain != null &&
					this.Domain.Equals(other.Domain)
				) &&
				(
					this.Intents == other.Intents ||
					this.Intents != null &&
					this.Intents.SequenceEqual(other.Intents)
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

				if (this.Domain != null)
					hash = hash * 59 + this.Domain.GetHashCode();

				if (this.Intents != null)
					hash = hash * 59 + this.Intents.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
