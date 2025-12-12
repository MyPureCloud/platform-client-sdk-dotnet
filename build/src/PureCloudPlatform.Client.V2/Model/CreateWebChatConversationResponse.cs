using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateWebChatConversationResponse
	/// </summary>
	[DataContract]
	public partial class CreateWebChatConversationResponse : IEquatable<CreateWebChatConversationResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateWebChatConversationResponse" /> class.
		/// </summary>
		/// <param name="Id">Chat Conversation identifier.</param>
		/// <param name="Jwt">The JWT that you can use to identify subsequent calls on this conversation.</param>
		/// <param name="EventStreamUri">The URI which provides the conversation event stream..</param>
		/// <param name="Member">Chat Member.</param>
		public CreateWebChatConversationResponse(string Id = null, string Jwt = null, string EventStreamUri = null, WebChatMemberInfo Member = null)
		{
			this.Id = Id;
			this.Jwt = Jwt;
			this.EventStreamUri = EventStreamUri;
			this.Member = Member;

		}



		/// <summary>
		/// Chat Conversation identifier
		/// </summary>
		/// <value>Chat Conversation identifier</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The JWT that you can use to identify subsequent calls on this conversation
		/// </summary>
		/// <value>The JWT that you can use to identify subsequent calls on this conversation</value>
		[DataMember(Name = "jwt", EmitDefaultValue = false)]
		public string Jwt { get; set; }



		/// <summary>
		/// The URI which provides the conversation event stream.
		/// </summary>
		/// <value>The URI which provides the conversation event stream.</value>
		[DataMember(Name = "eventStreamUri", EmitDefaultValue = false)]
		public string EventStreamUri { get; set; }



		/// <summary>
		/// Chat Member
		/// </summary>
		/// <value>Chat Member</value>
		[DataMember(Name = "member", EmitDefaultValue = false)]
		public WebChatMemberInfo Member { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateWebChatConversationResponse {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Jwt: ").Append(Jwt).Append("\n");
			sb.Append("  EventStreamUri: ").Append(EventStreamUri).Append("\n");
			sb.Append("  Member: ").Append(Member).Append("\n");
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
			return this.Equals(obj as CreateWebChatConversationResponse);
		}

		/// <summary>
		/// Returns true if CreateWebChatConversationResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateWebChatConversationResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateWebChatConversationResponse other)
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
					this.Jwt == other.Jwt ||
					this.Jwt != null &&
					this.Jwt.Equals(other.Jwt)
				) &&
				(
					this.EventStreamUri == other.EventStreamUri ||
					this.EventStreamUri != null &&
					this.EventStreamUri.Equals(other.EventStreamUri)
				) &&
				(
					this.Member == other.Member ||
					this.Member != null &&
					this.Member.Equals(other.Member)
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

				if (this.Jwt != null)
					hash = hash * 59 + this.Jwt.GetHashCode();

				if (this.EventStreamUri != null)
					hash = hash * 59 + this.EventStreamUri.GetHashCode();

				if (this.Member != null)
					hash = hash * 59 + this.Member.GetHashCode();

				return hash;
			}
		}
	}

}
