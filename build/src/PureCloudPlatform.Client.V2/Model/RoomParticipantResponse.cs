using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RoomParticipantResponse
	/// </summary>
	[DataContract]
	public partial class RoomParticipantResponse : IEquatable<RoomParticipantResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoomParticipantResponse" /> class.
		/// </summary>
		/// <param name="Jid">jid of the participant.</param>
		/// <param name="User">User id of the participant.</param>
		public RoomParticipantResponse(string Jid = null, AddressableEntityRef User = null)
		{
			this.Jid = Jid;
			this.User = User;

		}



		/// <summary>
		/// jid of the participant
		/// </summary>
		/// <value>jid of the participant</value>
		[DataMember(Name = "jid", EmitDefaultValue = false)]
		public string Jid { get; set; }



		/// <summary>
		/// User id of the participant
		/// </summary>
		/// <value>User id of the participant</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public AddressableEntityRef User { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoomParticipantResponse {\n");

			sb.Append("  Jid: ").Append(Jid).Append("\n");
			sb.Append("  User: ").Append(User).Append("\n");
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
			return this.Equals(obj as RoomParticipantResponse);
		}

		/// <summary>
		/// Returns true if RoomParticipantResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of RoomParticipantResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RoomParticipantResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Jid == other.Jid ||
					this.Jid != null &&
					this.Jid.Equals(other.Jid)
				) &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
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
				if (this.Jid != null)
					hash = hash * 59 + this.Jid.GetHashCode();

				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				return hash;
			}
		}
	}

}
