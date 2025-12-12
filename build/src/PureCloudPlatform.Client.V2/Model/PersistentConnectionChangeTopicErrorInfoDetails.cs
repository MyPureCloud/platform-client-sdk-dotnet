using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PersistentConnectionChangeTopicErrorInfoDetails
	/// </summary>
	[DataContract]
	public partial class PersistentConnectionChangeTopicErrorInfoDetails : IEquatable<PersistentConnectionChangeTopicErrorInfoDetails>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PersistentConnectionChangeTopicErrorInfoDetails" /> class.
		/// </summary>
		/// <param name="Code">Code.</param>
		/// <param name="UserMessage">UserMessage.</param>
		/// <param name="UserParams">UserParams.</param>
		/// <param name="Hostname">Hostname.</param>
		/// <param name="Location">Location.</param>
		public PersistentConnectionChangeTopicErrorInfoDetails(string Code = null, string UserMessage = null, Dictionary<string, string> UserParams = null, string Hostname = null, PersistentConnectionChangeTopicErrorLocation Location = null)
		{
			this.Code = Code;
			this.UserMessage = UserMessage;
			this.UserParams = UserParams;
			this.Hostname = Hostname;
			this.Location = Location;

		}



		/// <summary>
		/// Gets or Sets Code
		/// </summary>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }



		/// <summary>
		/// Gets or Sets UserMessage
		/// </summary>
		[DataMember(Name = "userMessage", EmitDefaultValue = false)]
		public string UserMessage { get; set; }



		/// <summary>
		/// Gets or Sets UserParams
		/// </summary>
		[DataMember(Name = "userParams", EmitDefaultValue = false)]
		public Dictionary<string, string> UserParams { get; set; }



		/// <summary>
		/// Gets or Sets Hostname
		/// </summary>
		[DataMember(Name = "hostname", EmitDefaultValue = false)]
		public string Hostname { get; set; }



		/// <summary>
		/// Gets or Sets Location
		/// </summary>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public PersistentConnectionChangeTopicErrorLocation Location { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PersistentConnectionChangeTopicErrorInfoDetails {\n");

			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
			sb.Append("  UserParams: ").Append(UserParams).Append("\n");
			sb.Append("  Hostname: ").Append(Hostname).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
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
			return this.Equals(obj as PersistentConnectionChangeTopicErrorInfoDetails);
		}

		/// <summary>
		/// Returns true if PersistentConnectionChangeTopicErrorInfoDetails instances are equal
		/// </summary>
		/// <param name="other">Instance of PersistentConnectionChangeTopicErrorInfoDetails to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PersistentConnectionChangeTopicErrorInfoDetails other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Code == other.Code ||
					this.Code != null &&
					this.Code.Equals(other.Code)
				) &&
				(
					this.UserMessage == other.UserMessage ||
					this.UserMessage != null &&
					this.UserMessage.Equals(other.UserMessage)
				) &&
				(
					this.UserParams == other.UserParams ||
					this.UserParams != null &&
					this.UserParams.SequenceEqual(other.UserParams)
				) &&
				(
					this.Hostname == other.Hostname ||
					this.Hostname != null &&
					this.Hostname.Equals(other.Hostname)
				) &&
				(
					this.Location == other.Location ||
					this.Location != null &&
					this.Location.Equals(other.Location)
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
				if (this.Code != null)
					hash = hash * 59 + this.Code.GetHashCode();

				if (this.UserMessage != null)
					hash = hash * 59 + this.UserMessage.GetHashCode();

				if (this.UserParams != null)
					hash = hash * 59 + this.UserParams.GetHashCode();

				if (this.Hostname != null)
					hash = hash * 59 + this.Hostname.GetHashCode();

				if (this.Location != null)
					hash = hash * 59 + this.Location.GetHashCode();

				return hash;
			}
		}
	}

}
