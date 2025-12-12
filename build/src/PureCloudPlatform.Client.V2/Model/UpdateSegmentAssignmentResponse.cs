using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateSegmentAssignmentResponse
	/// </summary>
	[DataContract]
	public partial class UpdateSegmentAssignmentResponse : IEquatable<UpdateSegmentAssignmentResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSegmentAssignmentResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateSegmentAssignmentResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateSegmentAssignmentResponse" /> class.
		/// </summary>
		/// <param name="UnprocessedItems">The segment assignments and unassignments which could not be processed. (required).</param>
		public UpdateSegmentAssignmentResponse(UnprocessedSegmentAssignments UnprocessedItems = null)
		{
			this.UnprocessedItems = UnprocessedItems;

		}



		/// <summary>
		/// The segment assignments and unassignments which could not be processed.
		/// </summary>
		/// <value>The segment assignments and unassignments which could not be processed.</value>
		[DataMember(Name = "unprocessedItems", EmitDefaultValue = false)]
		public UnprocessedSegmentAssignments UnprocessedItems { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateSegmentAssignmentResponse {\n");

			sb.Append("  UnprocessedItems: ").Append(UnprocessedItems).Append("\n");
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
			return this.Equals(obj as UpdateSegmentAssignmentResponse);
		}

		/// <summary>
		/// Returns true if UpdateSegmentAssignmentResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateSegmentAssignmentResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateSegmentAssignmentResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.UnprocessedItems == other.UnprocessedItems ||
					this.UnprocessedItems != null &&
					this.UnprocessedItems.Equals(other.UnprocessedItems)
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
				if (this.UnprocessedItems != null)
					hash = hash * 59 + this.UnprocessedItems.GetHashCode();

				return hash;
			}
		}
	}

}
