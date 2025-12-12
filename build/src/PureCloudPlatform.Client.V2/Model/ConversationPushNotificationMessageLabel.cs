using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A Push notification message label.
	/// </summary>
	[DataContract]
	public partial class ConversationPushNotificationMessageLabel : IEquatable<ConversationPushNotificationMessageLabel>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationPushNotificationMessageLabel" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationPushNotificationMessageLabel() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationPushNotificationMessageLabel" /> class.
		/// </summary>
		/// <param name="Title">Title to use in the push for each language configured in the deploymentId (required).</param>
		/// <param name="Body">Body to use in the push for each language configured in the deploymentId (required).</param>
		public ConversationPushNotificationMessageLabel(string Title = null, string Body = null)
		{
			this.Title = Title;
			this.Body = Body;

		}



		/// <summary>
		/// Title to use in the push for each language configured in the deploymentId
		/// </summary>
		/// <value>Title to use in the push for each language configured in the deploymentId</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Body to use in the push for each language configured in the deploymentId
		/// </summary>
		/// <value>Body to use in the push for each language configured in the deploymentId</value>
		[DataMember(Name = "body", EmitDefaultValue = false)]
		public string Body { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationPushNotificationMessageLabel {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Body: ").Append(Body).Append("\n");
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
			return this.Equals(obj as ConversationPushNotificationMessageLabel);
		}

		/// <summary>
		/// Returns true if ConversationPushNotificationMessageLabel instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationPushNotificationMessageLabel to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationPushNotificationMessageLabel other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Body == other.Body ||
					this.Body != null &&
					this.Body.Equals(other.Body)
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
				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Body != null)
					hash = hash * 59 + this.Body.GetHashCode();

				return hash;
			}
		}
	}

}
