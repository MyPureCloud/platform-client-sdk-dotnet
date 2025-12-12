using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentContentHighlightIndex
	/// </summary>
	[DataContract]
	public partial class DocumentContentHighlightIndex : IEquatable<DocumentContentHighlightIndex>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentContentHighlightIndex" /> class.
		/// </summary>
		/// <param name="StartIndex">Highlight text start index..</param>
		/// <param name="EndIndex">Highlight text end index..</param>
		public DocumentContentHighlightIndex(int? StartIndex = null, int? EndIndex = null)
		{
			this.StartIndex = StartIndex;
			this.EndIndex = EndIndex;

		}



		/// <summary>
		/// Highlight text start index.
		/// </summary>
		/// <value>Highlight text start index.</value>
		[DataMember(Name = "startIndex", EmitDefaultValue = false)]
		public int? StartIndex { get; set; }



		/// <summary>
		/// Highlight text end index.
		/// </summary>
		/// <value>Highlight text end index.</value>
		[DataMember(Name = "endIndex", EmitDefaultValue = false)]
		public int? EndIndex { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentContentHighlightIndex {\n");

			sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
			sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
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
			return this.Equals(obj as DocumentContentHighlightIndex);
		}

		/// <summary>
		/// Returns true if DocumentContentHighlightIndex instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentContentHighlightIndex to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentContentHighlightIndex other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.StartIndex == other.StartIndex ||
					this.StartIndex != null &&
					this.StartIndex.Equals(other.StartIndex)
				) &&
				(
					this.EndIndex == other.EndIndex ||
					this.EndIndex != null &&
					this.EndIndex.Equals(other.EndIndex)
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
				if (this.StartIndex != null)
					hash = hash * 59 + this.StartIndex.GetHashCode();

				if (this.EndIndex != null)
					hash = hash * 59 + this.EndIndex.GetHashCode();

				return hash;
			}
		}
	}

}
