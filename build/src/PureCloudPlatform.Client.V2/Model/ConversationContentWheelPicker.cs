using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Wheel Picker object for representing single selection of selectable items.
	/// </summary>
	[DataContract]
	public partial class ConversationContentWheelPicker : IEquatable<ConversationContentWheelPicker>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentWheelPicker" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ConversationContentWheelPicker() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationContentWheelPicker" /> class.
		/// </summary>
		/// <param name="Id">Optional unique identifier to help map component replies to form messages where multiple Wheel Pickers can be present..</param>
		/// <param name="Items">The main text displayed for the item. (required).</param>
		public ConversationContentWheelPicker(string Id = null, List<ConversationContentWheelPickerItem> Items = null)
		{
			this.Id = Id;
			this.Items = Items;

		}



		/// <summary>
		/// Optional unique identifier to help map component replies to form messages where multiple Wheel Pickers can be present.
		/// </summary>
		/// <value>Optional unique identifier to help map component replies to form messages where multiple Wheel Pickers can be present.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The main text displayed for the item.
		/// </summary>
		/// <value>The main text displayed for the item.</value>
		[DataMember(Name = "items", EmitDefaultValue = false)]
		public List<ConversationContentWheelPickerItem> Items { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationContentWheelPicker {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
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
			return this.Equals(obj as ConversationContentWheelPicker);
		}

		/// <summary>
		/// Returns true if ConversationContentWheelPicker instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationContentWheelPicker to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationContentWheelPicker other)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Items != null)
					hash = hash * 59 + this.Items.GetHashCode();

				return hash;
			}
		}
	}

}
