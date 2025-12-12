using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// List Picker object for presenting a section of selectable items.
	/// </summary>
	[DataContract]
	public partial class ConversationContentListPickerSection : IEquatable<ConversationContentListPickerSection>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentListPickerSection" /> class.
		/// </summary>
		/// <param name="Title">Required title for the section..</param>
		/// <param name="MultipleSelection">Whether multiple items can be selected in this section..</param>
		/// <param name="Items">List of items to choice from in the section.</param>
		public ConversationContentListPickerSection(string Title = null, bool? MultipleSelection = null, List<ConversationContentListPickerItem> Items = null)
		{
			this.Title = Title;
			this.MultipleSelection = MultipleSelection;
			this.Items = Items;

		}



		/// <summary>
		/// Required title for the section.
		/// </summary>
		/// <value>Required title for the section.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Whether multiple items can be selected in this section.
		/// </summary>
		/// <value>Whether multiple items can be selected in this section.</value>
		[DataMember(Name = "multipleSelection", EmitDefaultValue = false)]
		public bool? MultipleSelection { get; set; }



		/// <summary>
		/// List of items to choice from in the section
		/// </summary>
		/// <value>List of items to choice from in the section</value>
		[DataMember(Name = "items", EmitDefaultValue = false)]
		public List<ConversationContentListPickerItem> Items { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentListPickerSection {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  MultipleSelection: ").Append(MultipleSelection).Append("\n");
			sb.Append("  Items: ").Append(Items).Append("\n");
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
			return this.Equals(obj as ConversationContentListPickerSection);
		}

		/// <summary>
		/// Returns true if ConversationContentListPickerSection instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentListPickerSection to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentListPickerSection other)
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
					this.MultipleSelection == other.MultipleSelection ||
					this.MultipleSelection != null &&
					this.MultipleSelection.Equals(other.MultipleSelection)
				) &&
				(
					this.Items == other.Items ||
					this.Items != null &&
					this.Items.SequenceEqual(other.Items)
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

				if (this.MultipleSelection != null)
					hash = hash * 59 + this.MultipleSelection.GetHashCode();

				if (this.Items != null)
					hash = hash * 59 + this.Items.GetHashCode();

				return hash;
			}
		}
	}

}
