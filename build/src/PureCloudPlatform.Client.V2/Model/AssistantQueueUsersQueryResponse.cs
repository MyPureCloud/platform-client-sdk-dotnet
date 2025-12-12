using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AssistantQueueUsersQueryResponse
	/// </summary>
	[DataContract]
	public partial class AssistantQueueUsersQueryResponse : IEquatable<AssistantQueueUsersQueryResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssistantQueueUsersQueryResponse" /> class.
		/// </summary>
		public AssistantQueueUsersQueryResponse()
		{

		}



		/// <summary>
		/// The queue information.
		/// </summary>
		/// <value>The queue information.</value>
		[DataMember(Name = "queue", EmitDefaultValue = false)]
		public AssistantQueue Queue { get; private set; }



		/// <summary>
		/// List of users in the queue for which assistant is assigned.
		/// </summary>
		/// <value>List of users in the queue for which assistant is assigned.</value>
		[DataMember(Name = "users", EmitDefaultValue = false)]
		public List<UserReference> Users { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AssistantQueueUsersQueryResponse {\n");

			sb.Append("  Queue: ").Append(Queue).Append("\n");
			sb.Append("  Users: ").Append(Users).Append("\n");
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
			return this.Equals(obj as AssistantQueueUsersQueryResponse);
		}

		/// <summary>
		/// Returns true if AssistantQueueUsersQueryResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of AssistantQueueUsersQueryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AssistantQueueUsersQueryResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Queue == other.Queue ||
					this.Queue != null &&
					this.Queue.Equals(other.Queue)
				) &&
				(
					this.Users == other.Users ||
					this.Users != null &&
					this.Users.SequenceEqual(other.Users)
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
				if (this.Queue != null)
					hash = hash * 59 + this.Queue.GetHashCode();

				if (this.Users != null)
					hash = hash * 59 + this.Users.GetHashCode();

				return hash;
			}
		}
	}

}
