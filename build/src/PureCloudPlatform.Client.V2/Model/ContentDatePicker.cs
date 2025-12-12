using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DatePicker content object.
	/// </summary>
	[DataContract]
	public partial class ContentDatePicker : IEquatable<ContentDatePicker>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContentDatePicker" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContentDatePicker() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContentDatePicker" /> class.
		/// </summary>
		/// <param name="Title">Text to show in the title..</param>
		/// <param name="Subtitle">Text to show in the description..</param>
		/// <param name="ImageUrl">URL of an image.</param>
		/// <param name="DateMinimum">The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="DateMaximum">The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="AvailableTimes">An array of available times objects. (required).</param>
		public ContentDatePicker(string Title = null, string Subtitle = null, string ImageUrl = null, DateTime? DateMinimum = null, DateTime? DateMaximum = null, List<ContentDatePickerAvailableTime> AvailableTimes = null)
		{
			this.Title = Title;
			this.Subtitle = Subtitle;
			this.ImageUrl = ImageUrl;
			this.DateMinimum = DateMinimum;
			this.DateMaximum = DateMaximum;
			this.AvailableTimes = AvailableTimes;

		}



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
		/// URL of an image
		/// </summary>
		/// <value>URL of an image</value>
		[DataMember(Name = "imageUrl", EmitDefaultValue = false)]
		public string ImageUrl { get; set; }



		/// <summary>
		/// The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateMinimum", EmitDefaultValue = false)]
		public DateTime? DateMinimum { get; set; }



		/// <summary>
		/// The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateMaximum", EmitDefaultValue = false)]
		public DateTime? DateMaximum { get; set; }



		/// <summary>
		/// An array of available times objects.
		/// </summary>
		/// <value>An array of available times objects.</value>
		[DataMember(Name = "availableTimes", EmitDefaultValue = false)]
		public List<ContentDatePickerAvailableTime> AvailableTimes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContentDatePicker {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
			sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
			sb.Append("  DateMinimum: ").Append(DateMinimum).Append("\n");
			sb.Append("  DateMaximum: ").Append(DateMaximum).Append("\n");
			sb.Append("  AvailableTimes: ").Append(AvailableTimes).Append("\n");
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
			return this.Equals(obj as ContentDatePicker);
		}

		/// <summary>
		/// Returns true if ContentDatePicker instances are equal
		/// </summary>
		/// <param name="other">Instance of ContentDatePicker to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContentDatePicker other)
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
					this.Subtitle == other.Subtitle ||
					this.Subtitle != null &&
					this.Subtitle.Equals(other.Subtitle)
				) &&
				(
					this.ImageUrl == other.ImageUrl ||
					this.ImageUrl != null &&
					this.ImageUrl.Equals(other.ImageUrl)
				) &&
				(
					this.DateMinimum == other.DateMinimum ||
					this.DateMinimum != null &&
					this.DateMinimum.Equals(other.DateMinimum)
				) &&
				(
					this.DateMaximum == other.DateMaximum ||
					this.DateMaximum != null &&
					this.DateMaximum.Equals(other.DateMaximum)
				) &&
				(
					this.AvailableTimes == other.AvailableTimes ||
					this.AvailableTimes != null &&
					this.AvailableTimes.SequenceEqual(other.AvailableTimes)
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

				if (this.Subtitle != null)
					hash = hash * 59 + this.Subtitle.GetHashCode();

				if (this.ImageUrl != null)
					hash = hash * 59 + this.ImageUrl.GetHashCode();

				if (this.DateMinimum != null)
					hash = hash * 59 + this.DateMinimum.GetHashCode();

				if (this.DateMaximum != null)
					hash = hash * 59 + this.DateMaximum.GetHashCode();

				if (this.AvailableTimes != null)
					hash = hash * 59 + this.AvailableTimes.GetHashCode();

				return hash;
			}
		}
	}

}
