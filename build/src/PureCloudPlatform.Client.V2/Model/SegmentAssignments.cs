using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SegmentAssignments
	/// </summary>
	[DataContract]
	public partial class SegmentAssignments : IEquatable<SegmentAssignments>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentAssignments" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SegmentAssignments() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentAssignments" /> class.
		/// </summary>
		/// <param name="Segments">The segments to be assigned. (required).</param>
		public SegmentAssignments(List<SegmentForAssignment> Segments = null)
		{
			this.Segments = Segments;

		}



		/// <summary>
		/// The segments to be assigned.
		/// </summary>
		/// <value>The segments to be assigned.</value>
		[DataMember(Name = "segments", EmitDefaultValue = false)]
		public List<SegmentForAssignment> Segments { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SegmentAssignments {\n");

			sb.Append("  Segments: ").Append(Segments).Append("\n");
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
			return this.Equals(obj as SegmentAssignments);
		}

		/// <summary>
		/// Returns true if SegmentAssignments instances are equal
		/// </summary>
		/// <param name="other">Instance of SegmentAssignments to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SegmentAssignments other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Segments == other.Segments ||
					this.Segments != null &&
					this.Segments.SequenceEqual(other.Segments)
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
				if (this.Segments != null)
					hash = hash * 59 + this.Segments.GetHashCode();

				return hash;
			}
		}
	}

}
