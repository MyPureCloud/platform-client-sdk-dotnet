using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Structured template button object.
	/// </summary>
	[DataContract]
	public partial class RecordingButtonComponent : IEquatable<RecordingButtonComponent>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingButtonComponent" /> class.
		/// </summary>
		/// <param name="Title">Title.</param>
		/// <param name="Actions">Actions.</param>
		/// <param name="IsSelected">IsSelected.</param>
		public RecordingButtonComponent(string Title = null, RecordingContentActions Actions = null, bool? IsSelected = null)
		{
			this.Title = Title;
			this.Actions = Actions;
			this.IsSelected = IsSelected;

		}



		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Gets or Sets Actions
		/// </summary>
		[DataMember(Name = "actions", EmitDefaultValue = false)]
		public RecordingContentActions Actions { get; set; }



		/// <summary>
		/// Gets or Sets IsSelected
		/// </summary>
		[DataMember(Name = "isSelected", EmitDefaultValue = false)]
		public bool? IsSelected { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingButtonComponent {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Actions: ").Append(Actions).Append("\n");
			sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
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
			return this.Equals(obj as RecordingButtonComponent);
		}

		/// <summary>
		/// Returns true if RecordingButtonComponent instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingButtonComponent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingButtonComponent other)
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
					this.Actions == other.Actions ||
					this.Actions != null &&
					this.Actions.Equals(other.Actions)
				) &&
				(
					this.IsSelected == other.IsSelected ||
					this.IsSelected != null &&
					this.IsSelected.Equals(other.IsSelected)
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

				if (this.Actions != null)
					hash = hash * 59 + this.Actions.GetHashCode();

				if (this.IsSelected != null)
					hash = hash * 59 + this.IsSelected.GetHashCode();

				return hash;
			}
		}
	}

}
