using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RoomParticipant
	/// </summary>
	[DataContract]
	public partial class RoomParticipant : IEquatable<RoomParticipant>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="RoomParticipant" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected RoomParticipant() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="RoomParticipant" /> class.
		/// </summary>
		/// <param name="ParticipantJid">participantJid (required).</param>
		public RoomParticipant(string ParticipantJid = null)
		{
			this.ParticipantJid = ParticipantJid;

		}



		/// <summary>
		/// participantJid
		/// </summary>
		/// <value>participantJid</value>
		[DataMember(Name = "participantJid", EmitDefaultValue = false)]
		public string ParticipantJid { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RoomParticipant {\n");

			sb.Append("  ParticipantJid: ").Append(ParticipantJid).Append("\n");
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
			return this.Equals(obj as RoomParticipant);
		}

		/// <summary>
		/// Returns true if RoomParticipant instances are equal
		/// </summary>
		/// <param name="other">Instance of RoomParticipant to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RoomParticipant other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ParticipantJid == other.ParticipantJid ||
					this.ParticipantJid != null &&
					this.ParticipantJid.Equals(other.ParticipantJid)
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
				if (this.ParticipantJid != null)
					hash = hash * 59 + this.ParticipantJid.GetHashCode();

				return hash;
			}
		}
	}

}
