using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateMuAgentRequest
	/// </summary>
	[DataContract]
	public partial class UpdateMuAgentRequest : IEquatable<UpdateMuAgentRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateMuAgentRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateMuAgentRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateMuAgentRequest" /> class.
		/// </summary>
		/// <param name="Schedulable">Whether the agent can be included in schedule generation.</param>
		/// <param name="UserId">User to be updated (required).</param>
		public UpdateMuAgentRequest(bool? Schedulable = null, string UserId = null)
		{
			this.Schedulable = Schedulable;
			this.UserId = UserId;

		}



		/// <summary>
		/// Whether the agent can be included in schedule generation
		/// </summary>
		/// <value>Whether the agent can be included in schedule generation</value>
		[DataMember(Name = "schedulable", EmitDefaultValue = false)]
		public bool? Schedulable { get; set; }



		/// <summary>
		/// User to be updated
		/// </summary>
		/// <value>User to be updated</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateMuAgentRequest {\n");

			sb.Append("  Schedulable: ").Append(Schedulable).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
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
			return this.Equals(obj as UpdateMuAgentRequest);
		}

		/// <summary>
		/// Returns true if UpdateMuAgentRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateMuAgentRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateMuAgentRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Schedulable == other.Schedulable ||
					this.Schedulable != null &&
					this.Schedulable.Equals(other.Schedulable)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
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
				if (this.Schedulable != null)
					hash = hash * 59 + this.Schedulable.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				return hash;
			}
		}
	}

}
