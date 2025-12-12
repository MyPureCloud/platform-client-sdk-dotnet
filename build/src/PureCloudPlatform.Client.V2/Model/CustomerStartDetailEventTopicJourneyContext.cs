using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CustomerStartDetailEventTopicJourneyContext
	/// </summary>
	[DataContract]
	public partial class CustomerStartDetailEventTopicJourneyContext : IEquatable<CustomerStartDetailEventTopicJourneyContext>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CustomerStartDetailEventTopicJourneyContext" /> class.
		/// </summary>
		/// <param name="SessionId">SessionId.</param>
		/// <param name="SessionIdType">SessionIdType.</param>
		/// <param name="ActionId">ActionId.</param>
		/// <param name="ActionMapId">ActionMapId.</param>
		public CustomerStartDetailEventTopicJourneyContext(string SessionId = null, string SessionIdType = null, string ActionId = null, string ActionMapId = null)
		{
			this.SessionId = SessionId;
			this.SessionIdType = SessionIdType;
			this.ActionId = ActionId;
			this.ActionMapId = ActionMapId;

		}



		/// <summary>
		/// Gets or Sets SessionId
		/// </summary>
		[DataMember(Name = "sessionId", EmitDefaultValue = false)]
		public string SessionId { get; set; }



		/// <summary>
		/// Gets or Sets SessionIdType
		/// </summary>
		[DataMember(Name = "sessionIdType", EmitDefaultValue = false)]
		public string SessionIdType { get; set; }



		/// <summary>
		/// Gets or Sets ActionId
		/// </summary>
		[DataMember(Name = "actionId", EmitDefaultValue = false)]
		public string ActionId { get; set; }



		/// <summary>
		/// Gets or Sets ActionMapId
		/// </summary>
		[DataMember(Name = "actionMapId", EmitDefaultValue = false)]
		public string ActionMapId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CustomerStartDetailEventTopicJourneyContext {\n");

			sb.Append("  SessionId: ").Append(SessionId).Append("\n");
			sb.Append("  SessionIdType: ").Append(SessionIdType).Append("\n");
			sb.Append("  ActionId: ").Append(ActionId).Append("\n");
			sb.Append("  ActionMapId: ").Append(ActionMapId).Append("\n");
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
			return this.Equals(obj as CustomerStartDetailEventTopicJourneyContext);
		}

		/// <summary>
		/// Returns true if CustomerStartDetailEventTopicJourneyContext instances are equal
		/// </summary>
		/// <param name="other">Instance of CustomerStartDetailEventTopicJourneyContext to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CustomerStartDetailEventTopicJourneyContext other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SessionId == other.SessionId ||
					this.SessionId != null &&
					this.SessionId.Equals(other.SessionId)
				) &&
				(
					this.SessionIdType == other.SessionIdType ||
					this.SessionIdType != null &&
					this.SessionIdType.Equals(other.SessionIdType)
				) &&
				(
					this.ActionId == other.ActionId ||
					this.ActionId != null &&
					this.ActionId.Equals(other.ActionId)
				) &&
				(
					this.ActionMapId == other.ActionMapId ||
					this.ActionMapId != null &&
					this.ActionMapId.Equals(other.ActionMapId)
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
				if (this.SessionId != null)
					hash = hash * 59 + this.SessionId.GetHashCode();

				if (this.SessionIdType != null)
					hash = hash * 59 + this.SessionIdType.GetHashCode();

				if (this.ActionId != null)
					hash = hash * 59 + this.ActionId.GetHashCode();

				if (this.ActionMapId != null)
					hash = hash * 59 + this.ActionMapId.GetHashCode();

				return hash;
			}
		}
	}

}
