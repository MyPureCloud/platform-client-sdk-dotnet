using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// References of failed messages requiring a push.
	/// </summary>
	[DataContract]
	public partial class ConversationPushFailedMessageReferences : IEquatable<ConversationPushFailedMessageReferences>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationPushFailedMessageReferences" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationPushFailedMessageReferences() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationPushFailedMessageReferences" /> class.
		/// </summary>
		/// <param name="Id">Unique ID of the message. (required).</param>
		public ConversationPushFailedMessageReferences(string Id = null)
		{
			this.Id = Id;

		}



		/// <summary>
		/// Unique ID of the message.
		/// </summary>
		/// <value>Unique ID of the message.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationPushFailedMessageReferences {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
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
			return this.Equals(obj as ConversationPushFailedMessageReferences);
		}

		/// <summary>
		/// Returns true if ConversationPushFailedMessageReferences instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationPushFailedMessageReferences to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationPushFailedMessageReferences other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
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

				return hash;
			}
		}
	}

}
