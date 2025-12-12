using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ManualEscalationRequest
	/// </summary>
	[DataContract]
	public partial class ManualEscalationRequest : IEquatable<ManualEscalationRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ManualEscalationRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ManualEscalationRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ManualEscalationRequest" /> class.
		/// </summary>
		/// <param name="SocialMediaNormalizedMessageId">The social media normalized message ID to be escalated. (required).</param>
		/// <param name="EscalationTarget">The escalation target to which the specified social media normalized message should be routed..</param>
		public ManualEscalationRequest(string SocialMediaNormalizedMessageId = null, EscalationTarget EscalationTarget = null)
		{
			this.SocialMediaNormalizedMessageId = SocialMediaNormalizedMessageId;
			this.EscalationTarget = EscalationTarget;

		}



		/// <summary>
		/// The social media normalized message ID to be escalated.
		/// </summary>
		/// <value>The social media normalized message ID to be escalated.</value>
		[DataMember(Name = "socialMediaNormalizedMessageId", EmitDefaultValue = false)]
		public string SocialMediaNormalizedMessageId { get; set; }



		/// <summary>
		/// The escalation target to which the specified social media normalized message should be routed.
		/// </summary>
		/// <value>The escalation target to which the specified social media normalized message should be routed.</value>
		[DataMember(Name = "escalationTarget", EmitDefaultValue = false)]
		public EscalationTarget EscalationTarget { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ManualEscalationRequest {\n");

			sb.Append("  SocialMediaNormalizedMessageId: ").Append(SocialMediaNormalizedMessageId).Append("\n");
			sb.Append("  EscalationTarget: ").Append(EscalationTarget).Append("\n");
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
			return this.Equals(obj as ManualEscalationRequest);
		}

		/// <summary>
		/// Returns true if ManualEscalationRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ManualEscalationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ManualEscalationRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SocialMediaNormalizedMessageId == other.SocialMediaNormalizedMessageId ||
					this.SocialMediaNormalizedMessageId != null &&
					this.SocialMediaNormalizedMessageId.Equals(other.SocialMediaNormalizedMessageId)
				) &&
				(
					this.EscalationTarget == other.EscalationTarget ||
					this.EscalationTarget != null &&
					this.EscalationTarget.Equals(other.EscalationTarget)
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
				if (this.SocialMediaNormalizedMessageId != null)
					hash = hash * 59 + this.SocialMediaNormalizedMessageId.GetHashCode();

				if (this.EscalationTarget != null)
					hash = hash * 59 + this.EscalationTarget.GetHashCode();

				return hash;
			}
		}
	}

}
