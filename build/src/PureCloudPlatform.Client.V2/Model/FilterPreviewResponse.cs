using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FilterPreviewResponse
	/// </summary>
	[DataContract]
	public partial class FilterPreviewResponse : IEquatable<FilterPreviewResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FilterPreviewResponse" /> class.
		/// </summary>
		/// <param name="FilteredContacts">FilteredContacts.</param>
		/// <param name="TotalContacts">TotalContacts.</param>
		/// <param name="Preview">Preview.</param>
		public FilterPreviewResponse(long? FilteredContacts = null, long? TotalContacts = null, List<DialerContact> Preview = null)
		{
			this.FilteredContacts = FilteredContacts;
			this.TotalContacts = TotalContacts;
			this.Preview = Preview;

		}



		/// <summary>
		/// Gets or Sets FilteredContacts
		/// </summary>
		[DataMember(Name = "filteredContacts", EmitDefaultValue = false)]
		public long? FilteredContacts { get; set; }



		/// <summary>
		/// Gets or Sets TotalContacts
		/// </summary>
		[DataMember(Name = "totalContacts", EmitDefaultValue = false)]
		public long? TotalContacts { get; set; }



		/// <summary>
		/// Gets or Sets Preview
		/// </summary>
		[DataMember(Name = "preview", EmitDefaultValue = false)]
		public List<DialerContact> Preview { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FilterPreviewResponse {\n");

			sb.Append("  FilteredContacts: ").Append(FilteredContacts).Append("\n");
			sb.Append("  TotalContacts: ").Append(TotalContacts).Append("\n");
			sb.Append("  Preview: ").Append(Preview).Append("\n");
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
			return this.Equals(obj as FilterPreviewResponse);
		}

		/// <summary>
		/// Returns true if FilterPreviewResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of FilterPreviewResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FilterPreviewResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FilteredContacts == other.FilteredContacts ||
					this.FilteredContacts != null &&
					this.FilteredContacts.Equals(other.FilteredContacts)
				) &&
				(
					this.TotalContacts == other.TotalContacts ||
					this.TotalContacts != null &&
					this.TotalContacts.Equals(other.TotalContacts)
				) &&
				(
					this.Preview == other.Preview ||
					this.Preview != null &&
					this.Preview.SequenceEqual(other.Preview)
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
				if (this.FilteredContacts != null)
					hash = hash * 59 + this.FilteredContacts.GetHashCode();

				if (this.TotalContacts != null)
					hash = hash * 59 + this.TotalContacts.GetHashCode();

				if (this.Preview != null)
					hash = hash * 59 + this.Preview.GetHashCode();

				return hash;
			}
		}
	}

}
