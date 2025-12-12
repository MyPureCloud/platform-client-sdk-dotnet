using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DatePicker
	/// </summary>
	[DataContract]
	public partial class DatePicker : IEquatable<DatePicker>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DatePicker" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DatePicker() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DatePicker" /> class.
		/// </summary>
		/// <param name="Id">Optional unique identifier to help map component replies to form messages where multiple DatePickers can be present..</param>
		/// <param name="Title">Text to show in the title..</param>
		/// <param name="Subtitle">Text to show in the description..</param>
		/// <param name="DatePickerAvailableDateTimes">An array of available times objects. (required).</param>
		/// <param name="DateSelected">Selected date response from end customer. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public DatePicker(string Id = null, string Title = null, string Subtitle = null, List<DatePickerAvailableDateTime> DatePickerAvailableDateTimes = null, DateTime? DateSelected = null)
		{
			this.Id = Id;
			this.Title = Title;
			this.Subtitle = Subtitle;
			this.DatePickerAvailableDateTimes = DatePickerAvailableDateTimes;
			this.DateSelected = DateSelected;

		}



		/// <summary>
		/// Optional unique identifier to help map component replies to form messages where multiple DatePickers can be present.
		/// </summary>
		/// <value>Optional unique identifier to help map component replies to form messages where multiple DatePickers can be present.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Text to show in the title.
		/// </summary>
		/// <value>Text to show in the title.</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Text to show in the description.
		/// </summary>
		/// <value>Text to show in the description.</value>
		[DataMember(Name = "subtitle", EmitDefaultValue = false)]
		public string Subtitle { get; set; }



		/// <summary>
		/// An array of available times objects.
		/// </summary>
		/// <value>An array of available times objects.</value>
		[DataMember(Name = "datePickerAvailableDateTimes", EmitDefaultValue = false)]
		public List<DatePickerAvailableDateTime> DatePickerAvailableDateTimes { get; set; }



		/// <summary>
		/// Selected date response from end customer. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Selected date response from end customer. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateSelected", EmitDefaultValue = false)]
		public DateTime? DateSelected { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DatePicker {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
			sb.Append("  DatePickerAvailableDateTimes: ").Append(DatePickerAvailableDateTimes).Append("\n");
			sb.Append("  DateSelected: ").Append(DateSelected).Append("\n");
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
			return this.Equals(obj as DatePicker);
		}

		/// <summary>
		/// Returns true if DatePicker instances are equal
		/// </summary>
		/// <param name="other">Instance of DatePicker to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DatePicker other)
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
					this.Subtitle == other.Subtitle ||
					this.Subtitle != null &&
					this.Subtitle.Equals(other.Subtitle)
				) &&
				(
					this.DatePickerAvailableDateTimes == other.DatePickerAvailableDateTimes ||
					this.DatePickerAvailableDateTimes != null &&
					this.DatePickerAvailableDateTimes.SequenceEqual(other.DatePickerAvailableDateTimes)
				) &&
				(
					this.DateSelected == other.DateSelected ||
					this.DateSelected != null &&
					this.DateSelected.Equals(other.DateSelected)
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

				if (this.Subtitle != null)
					hash = hash * 59 + this.Subtitle.GetHashCode();

				if (this.DatePickerAvailableDateTimes != null)
					hash = hash * 59 + this.DatePickerAvailableDateTimes.GetHashCode();

				if (this.DateSelected != null)
					hash = hash * 59 + this.DateSelected.GetHashCode();

				return hash;
			}
		}
	}

}
