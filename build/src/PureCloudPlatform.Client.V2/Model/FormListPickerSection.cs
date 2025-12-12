using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Section within a list picker
	/// </summary>
	[DataContract]
	public partial class FormListPickerSection : IEquatable<FormListPickerSection>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="FormListPickerSection" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected FormListPickerSection() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="FormListPickerSection" /> class.
		/// </summary>
		/// <param name="Title">Title of the section.</param>
		/// <param name="MultipleSelection">Whether multiple items can be selected (required).</param>
		/// <param name="Items">Items in this section (required).</param>
		public FormListPickerSection(string Title = null, bool? MultipleSelection = null, List<FormListPickerItem> Items = null)
		{
			this.Title = Title;
			this.MultipleSelection = MultipleSelection;
			this.Items = Items;

		}



		/// <summary>
		/// Title of the section
		/// </summary>
		/// <value>Title of the section</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Whether multiple items can be selected
		/// </summary>
		/// <value>Whether multiple items can be selected</value>
		[DataMember(Name = "multipleSelection", EmitDefaultValue = false)]
		public bool? MultipleSelection { get; set; }



		/// <summary>
		/// Items in this section
		/// </summary>
		/// <value>Items in this section</value>
		[DataMember(Name = "items", EmitDefaultValue = false)]
		public List<FormListPickerItem> Items { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FormListPickerSection {\n");

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
			return this.Equals(obj as FormListPickerSection);
		}

		/// <summary>
		/// Returns true if FormListPickerSection instances are equal
		/// </summary>
		/// <param name="other">Instance of FormListPickerSection to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FormListPickerSection other)
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
