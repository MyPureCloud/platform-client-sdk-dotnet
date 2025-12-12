using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SegmentAssignment
	/// </summary>
	[DataContract]
	public partial class SegmentAssignment : IEquatable<SegmentAssignment>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentAssignment" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SegmentAssignment() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SegmentAssignment" /> class.
		/// </summary>
		/// <param name="DateAssigned">Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="DateForUnassignment">Date indicating when a segment is scheduled to be unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="Segment">The segment the assignment is for. (required).</param>
		/// <param name="Session">For session-scoped segments, the session for which the segment was assigned..</param>
		public SegmentAssignment(DateTime? DateAssigned = null, DateTime? DateForUnassignment = null, SegmentAssignmentSegment Segment = null, SegmentAssignmentSession Session = null)
		{
			this.DateAssigned = DateAssigned;
			this.DateForUnassignment = DateForUnassignment;
			this.Segment = Segment;
			this.Session = Session;

		}



		/// <summary>
		/// Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateAssigned", EmitDefaultValue = false)]
		public DateTime? DateAssigned { get; set; }



		/// <summary>
		/// Date indicating when a segment is scheduled to be unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Date indicating when a segment is scheduled to be unassigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateForUnassignment", EmitDefaultValue = false)]
		public DateTime? DateForUnassignment { get; set; }



		/// <summary>
		/// The segment the assignment is for.
		/// </summary>
		/// <value>The segment the assignment is for.</value>
		[DataMember(Name = "segment", EmitDefaultValue = false)]
		public SegmentAssignmentSegment Segment { get; set; }



		/// <summary>
		/// For session-scoped segments, the session for which the segment was assigned.
		/// </summary>
		/// <value>For session-scoped segments, the session for which the segment was assigned.</value>
		[DataMember(Name = "session", EmitDefaultValue = false)]
		public SegmentAssignmentSession Session { get; set; }



		/// <summary>
		/// External contact of the customer to which the segment is assigned.
		/// </summary>
		/// <value>External contact of the customer to which the segment is assigned.</value>
		[DataMember(Name = "externalContact", EmitDefaultValue = false)]
		public AddressableEntityRef ExternalContact { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SegmentAssignment {\n");

			sb.Append("  DateAssigned: ").Append(DateAssigned).Append("\n");
			sb.Append("  DateForUnassignment: ").Append(DateForUnassignment).Append("\n");
			sb.Append("  Segment: ").Append(Segment).Append("\n");
			sb.Append("  Session: ").Append(Session).Append("\n");
			sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
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
			return this.Equals(obj as SegmentAssignment);
		}

		/// <summary>
		/// Returns true if SegmentAssignment instances are equal
		/// </summary>
		/// <param name="other">Instance of SegmentAssignment to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SegmentAssignment other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateAssigned == other.DateAssigned ||
					this.DateAssigned != null &&
					this.DateAssigned.Equals(other.DateAssigned)
				) &&
				(
					this.DateForUnassignment == other.DateForUnassignment ||
					this.DateForUnassignment != null &&
					this.DateForUnassignment.Equals(other.DateForUnassignment)
				) &&
				(
					this.Segment == other.Segment ||
					this.Segment != null &&
					this.Segment.Equals(other.Segment)
				) &&
				(
					this.Session == other.Session ||
					this.Session != null &&
					this.Session.Equals(other.Session)
				) &&
				(
					this.ExternalContact == other.ExternalContact ||
					this.ExternalContact != null &&
					this.ExternalContact.Equals(other.ExternalContact)
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
				if (this.DateAssigned != null)
					hash = hash * 59 + this.DateAssigned.GetHashCode();

				if (this.DateForUnassignment != null)
					hash = hash * 59 + this.DateForUnassignment.GetHashCode();

				if (this.Segment != null)
					hash = hash * 59 + this.Segment.GetHashCode();

				if (this.Session != null)
					hash = hash * 59 + this.Session.GetHashCode();

				if (this.ExternalContact != null)
					hash = hash * 59 + this.ExternalContact.GetHashCode();

				return hash;
			}
		}
	}

}
