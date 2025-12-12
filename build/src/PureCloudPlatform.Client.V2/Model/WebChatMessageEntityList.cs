using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WebChatMessageEntityList
	/// </summary>
	[DataContract]
	public partial class WebChatMessageEntityList : IEquatable<WebChatMessageEntityList>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WebChatMessageEntityList" /> class.
		/// </summary>
		/// <param name="PageSize">PageSize.</param>
		/// <param name="Entities">Entities.</param>
		/// <param name="PreviousPage">PreviousPage.</param>
		/// <param name="Next">Next.</param>
		/// <param name="SelfUri">SelfUri.</param>
		public WebChatMessageEntityList(int? PageSize = null, List<WebChatMessage> Entities = null, string PreviousPage = null, string Next = null, string SelfUri = null)
		{
			this.PageSize = PageSize;
			this.Entities = Entities;
			this.PreviousPage = PreviousPage;
			this.Next = Next;
			this.SelfUri = SelfUri;

		}



		/// <summary>
		/// Gets or Sets PageSize
		/// </summary>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<WebChatMessage> Entities { get; set; }



		/// <summary>
		/// Gets or Sets PreviousPage
		/// </summary>
		[DataMember(Name = "previousPage", EmitDefaultValue = false)]
		public string PreviousPage { get; set; }



		/// <summary>
		/// Gets or Sets Next
		/// </summary>
		[DataMember(Name = "next", EmitDefaultValue = false)]
		public string Next { get; set; }



		/// <summary>
		/// Gets or Sets SelfUri
		/// </summary>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebChatMessageEntityList {\n");

			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
			sb.Append("  Next: ").Append(Next).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as WebChatMessageEntityList);
		}

		/// <summary>
		/// Returns true if WebChatMessageEntityList instances are equal
		/// </summary>
		/// <param name="other">Instance of WebChatMessageEntityList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebChatMessageEntityList other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PageSize == other.PageSize ||
					this.PageSize != null &&
					this.PageSize.Equals(other.PageSize)
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.PreviousPage == other.PreviousPage ||
					this.PreviousPage != null &&
					this.PreviousPage.Equals(other.PreviousPage)
				) &&
				(
					this.Next == other.Next ||
					this.Next != null &&
					this.Next.Equals(other.Next)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.PreviousPage != null)
					hash = hash * 59 + this.PreviousPage.GetHashCode();

				if (this.Next != null)
					hash = hash * 59 + this.Next.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
