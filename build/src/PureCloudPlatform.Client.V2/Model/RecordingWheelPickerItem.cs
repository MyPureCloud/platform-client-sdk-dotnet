using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingWheelPickerItem
	/// </summary>
	[DataContract]
	public partial class RecordingWheelPickerItem : IEquatable<RecordingWheelPickerItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingWheelPickerItem" /> class.
		/// </summary>
		/// <param name="Id">Unique identifier for the wheel picker item..</param>
		/// <param name="Title">The main text displayed for the item..</param>
		/// <param name="Value">The value of the item.</param>
		/// <param name="IsSelected">Indicates if the item is selected by end customer..</param>
		public RecordingWheelPickerItem(string Id = null, string Title = null, string Value = null, bool? IsSelected = null)
		{
			this.Id = Id;
			this.Title = Title;
			this.Value = Value;
			this.IsSelected = IsSelected;

		}



		/// <summary>
		/// Unique identifier for the wheel picker item.
		/// </summary>
		/// <value>Unique identifier for the wheel picker item.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The main text displayed for the item.
		/// </summary>
		/// <value>The main text displayed for the item.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// The value of the item
		/// </summary>
		/// <value>The value of the item</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }



		/// <summary>
		/// Indicates if the item is selected by end customer.
		/// </summary>
		/// <value>Indicates if the item is selected by end customer.</value>
		[DataMember(Name = "isSelected", EmitDefaultValue = false)]
		public bool? IsSelected { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingWheelPickerItem {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as RecordingWheelPickerItem);
		}

		/// <summary>
		/// Returns true if RecordingWheelPickerItem instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingWheelPickerItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingWheelPickerItem other)
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
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				if (this.IsSelected != null)
					hash = hash * 59 + this.IsSelected.GetHashCode();

				return hash;
			}
		}
	}

}
