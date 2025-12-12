using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Messaging setting for messaging platform integrations
	/// </summary>
	[DataContract]
	public partial class MessagingSettingPatchRequest : IEquatable<MessagingSettingPatchRequest>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingSettingPatchRequest" /> class.
		/// </summary>
		/// <param name="Name">The messaging Setting profile name.</param>
		/// <param name="Content">Settings relating to message contents.</param>
		/// <param name="Event">Settings relating to events which may occur.</param>
		public MessagingSettingPatchRequest(string Name = null, ContentSetting Content = null, EventSetting Event = null)
		{
			this.Name = Name;
			this.Content = Content;
			this.Event = Event;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The messaging Setting profile name
		/// </summary>
		/// <value>The messaging Setting profile name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Settings relating to message contents
		/// </summary>
		/// <value>Settings relating to message contents</value>
		[DataMember(Name = "content", EmitDefaultValue = false)]
		public ContentSetting Content { get; set; }



		/// <summary>
		/// Settings relating to events which may occur
		/// </summary>
		/// <value>Settings relating to events which may occur</value>
		[DataMember(Name = "event", EmitDefaultValue = false)]
		public EventSetting Event { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MessagingSettingPatchRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Content: ").Append(Content).Append("\n");
			sb.Append("  Event: ").Append(Event).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as MessagingSettingPatchRequest);
		}

		/// <summary>
		/// Returns true if MessagingSettingPatchRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of MessagingSettingPatchRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessagingSettingPatchRequest other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Content == other.Content ||
					this.Content != null &&
					this.Content.Equals(other.Content)
				) &&
				(
					this.Event == other.Event ||
					this.Event != null &&
					this.Event.Equals(other.Event)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Content != null)
					hash = hash * 59 + this.Content.GetHashCode();

				if (this.Event != null)
					hash = hash * 59 + this.Event.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
