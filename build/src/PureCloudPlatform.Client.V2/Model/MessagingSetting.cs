using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Messaging setting for messaging platform integrations
	/// </summary>
	[DataContract]
	public partial class MessagingSetting : IEquatable<MessagingSetting>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MessagingSetting" /> class.
		/// </summary>
		/// <param name="Name">The messaging Setting profile name.</param>
		/// <param name="Content">Configuration relating to message contents.</param>
		/// <param name="Event">Configuration relating to events which may occur.</param>
		public MessagingSetting(string Name = null, ContentSetting Content = null, EventSetting Event = null)
		{
			this.Name = Name;
			this.Content = Content;
			this.Event = Event;

		}



		/// <summary>
		/// The messaging Setting unique identifier associated with this integration
		/// </summary>
		/// <value>The messaging Setting unique identifier associated with this integration</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The messaging Setting profile name
		/// </summary>
		/// <value>The messaging Setting profile name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Date this messaging setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date this messaging setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// Date this messaging setting was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date this messaging setting was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// Version number
		/// </summary>
		/// <value>Version number</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string Version { get; private set; }



		/// <summary>
		/// User reference that created this Setting
		/// </summary>
		/// <value>User reference that created this Setting</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public DomainEntityRef CreatedBy { get; private set; }



		/// <summary>
		/// User reference that modified this Setting
		/// </summary>
		/// <value>User reference that modified this Setting</value>
		[DataMember(Name = "updatedBy", EmitDefaultValue = false)]
		public DomainEntityRef UpdatedBy { get; private set; }



		/// <summary>
		/// Configuration relating to message contents
		/// </summary>
		/// <value>Configuration relating to message contents</value>
		[DataMember(Name = "content", EmitDefaultValue = false)]
		public ContentSetting Content { get; set; }



		/// <summary>
		/// Configuration relating to events which may occur
		/// </summary>
		/// <value>Configuration relating to events which may occur</value>
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
			sb.Append("class MessagingSetting {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
			return this.Equals(obj as MessagingSetting);
		}

		/// <summary>
		/// Returns true if MessagingSetting instances are equal
		/// </summary>
		/// <param name="other">Instance of MessagingSetting to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MessagingSetting other)
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
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.UpdatedBy == other.UpdatedBy ||
					this.UpdatedBy != null &&
					this.UpdatedBy.Equals(other.UpdatedBy)
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

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.UpdatedBy != null)
					hash = hash * 59 + this.UpdatedBy.GetHashCode();

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
