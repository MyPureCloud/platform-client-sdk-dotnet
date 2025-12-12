using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UserChatSettingsPost
	/// </summary>
	[DataContract]
	public partial class UserChatSettingsPost : IEquatable<UserChatSettingsPost>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UserChatSettingsPost" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UserChatSettingsPost() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UserChatSettingsPost" /> class.
		/// </summary>
		/// <param name="Muted">Whether or not to enable muting notifications (required).</param>
		/// <param name="MentionsOnly">Whether or not to enable notifications for mentions only.</param>
		/// <param name="NotifyOnReactions">Whether or not to enable notifications for reactions on a user&#39;s own messages.</param>
		public UserChatSettingsPost(bool? Muted = null, bool? MentionsOnly = null, bool? NotifyOnReactions = null)
		{
			this.Muted = Muted;
			this.MentionsOnly = MentionsOnly;
			this.NotifyOnReactions = NotifyOnReactions;

		}



		/// <summary>
		/// Whether or not to enable muting notifications
		/// </summary>
		/// <value>Whether or not to enable muting notifications</value>
		[DataMember(Name = "muted", EmitDefaultValue = false)]
		public bool? Muted { get; set; }



		/// <summary>
		/// Whether or not to enable notifications for mentions only
		/// </summary>
		/// <value>Whether or not to enable notifications for mentions only</value>
		[DataMember(Name = "mentionsOnly", EmitDefaultValue = false)]
		public bool? MentionsOnly { get; set; }



		/// <summary>
		/// Whether or not to enable notifications for reactions on a user&#39;s own messages
		/// </summary>
		/// <value>Whether or not to enable notifications for reactions on a user&#39;s own messages</value>
		[DataMember(Name = "notifyOnReactions", EmitDefaultValue = false)]
		public bool? NotifyOnReactions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserChatSettingsPost {\n");

			sb.Append("  Muted: ").Append(Muted).Append("\n");
			sb.Append("  MentionsOnly: ").Append(MentionsOnly).Append("\n");
			sb.Append("  NotifyOnReactions: ").Append(NotifyOnReactions).Append("\n");
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
			return this.Equals(obj as UserChatSettingsPost);
		}

		/// <summary>
		/// Returns true if UserChatSettingsPost instances are equal
		/// </summary>
		/// <param name="other">Instance of UserChatSettingsPost to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserChatSettingsPost other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Muted == other.Muted ||
					this.Muted != null &&
					this.Muted.Equals(other.Muted)
				) &&
				(
					this.MentionsOnly == other.MentionsOnly ||
					this.MentionsOnly != null &&
					this.MentionsOnly.Equals(other.MentionsOnly)
				) &&
				(
					this.NotifyOnReactions == other.NotifyOnReactions ||
					this.NotifyOnReactions != null &&
					this.NotifyOnReactions.Equals(other.NotifyOnReactions)
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
				if (this.Muted != null)
					hash = hash * 59 + this.Muted.GetHashCode();

				if (this.MentionsOnly != null)
					hash = hash * 59 + this.MentionsOnly.GetHashCode();

				if (this.NotifyOnReactions != null)
					hash = hash * 59 + this.NotifyOnReactions.GetHashCode();

				return hash;
			}
		}
	}

}
