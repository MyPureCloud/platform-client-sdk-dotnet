using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ChatMessageUser
	/// </summary>
	[DataContract]
	public partial class ChatMessageUser : IEquatable<ChatMessageUser>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChatMessageUser" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="Username">Username.</param>
		/// <param name="Images">Images.</param>
		public ChatMessageUser(string Id = null, string Name = null, string DisplayName = null, string Username = null, List<Image> Images = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.DisplayName = DisplayName;
			this.Username = Username;
			this.Images = Images;

		}



		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "displayName", EmitDefaultValue = false)]
		public string DisplayName { get; set; }



		/// <summary>
		/// Gets or Sets Username
		/// </summary>
		[DataMember(Name = "username", EmitDefaultValue = false)]
		public string Username { get; set; }



		/// <summary>
		/// Gets or Sets Images
		/// </summary>
		[DataMember(Name = "images", EmitDefaultValue = false)]
		public List<Image> Images { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ChatMessageUser {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  Images: ").Append(Images).Append("\n");
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
			return this.Equals(obj as ChatMessageUser);
		}

		/// <summary>
		/// Returns true if ChatMessageUser instances are equal
		/// </summary>
		/// <param name="other">Instance of ChatMessageUser to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ChatMessageUser other)
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
					this.DisplayName == other.DisplayName ||
					this.DisplayName != null &&
					this.DisplayName.Equals(other.DisplayName)
				) &&
				(
					this.Username == other.Username ||
					this.Username != null &&
					this.Username.Equals(other.Username)
				) &&
				(
					this.Images == other.Images ||
					this.Images != null &&
					this.Images.SequenceEqual(other.Images)
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

				if (this.DisplayName != null)
					hash = hash * 59 + this.DisplayName.GetHashCode();

				if (this.Username != null)
					hash = hash * 59 + this.Username.GetHashCode();

				if (this.Images != null)
					hash = hash * 59 + this.Images.GetHashCode();

				return hash;
			}
		}
	}

}
