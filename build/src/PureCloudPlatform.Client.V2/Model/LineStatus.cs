using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LineStatus
	/// </summary>
	[DataContract]
	public partial class LineStatus : IEquatable<LineStatus>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LineStatus" /> class.
		/// </summary>
		/// <param name="Id">The id of this line.</param>
		/// <param name="Reachable">Indicates whether the edge can reach the line..</param>
		/// <param name="AddressOfRecord">The line&#39;s address of record..</param>
		/// <param name="ContactAddresses">The addresses used to contact the line..</param>
		/// <param name="ReachableStateTime">The time the line entered its current reachable state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public LineStatus(string Id = null, bool? Reachable = null, string AddressOfRecord = null, List<string> ContactAddresses = null, DateTime? ReachableStateTime = null)
		{
			this.Id = Id;
			this.Reachable = Reachable;
			this.AddressOfRecord = AddressOfRecord;
			this.ContactAddresses = ContactAddresses;
			this.ReachableStateTime = ReachableStateTime;

		}



		/// <summary>
		/// The id of this line
		/// </summary>
		/// <value>The id of this line</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Indicates whether the edge can reach the line.
		/// </summary>
		/// <value>Indicates whether the edge can reach the line.</value>
		[DataMember(Name = "reachable", EmitDefaultValue = false)]
		public bool? Reachable { get; set; }



		/// <summary>
		/// The line&#39;s address of record.
		/// </summary>
		/// <value>The line&#39;s address of record.</value>
		[DataMember(Name = "addressOfRecord", EmitDefaultValue = false)]
		public string AddressOfRecord { get; set; }



		/// <summary>
		/// The addresses used to contact the line.
		/// </summary>
		/// <value>The addresses used to contact the line.</value>
		[DataMember(Name = "contactAddresses", EmitDefaultValue = false)]
		public List<string> ContactAddresses { get; set; }



		/// <summary>
		/// The time the line entered its current reachable state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The time the line entered its current reachable state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "reachableStateTime", EmitDefaultValue = false)]
		public DateTime? ReachableStateTime { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LineStatus {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Reachable: ").Append(Reachable).Append("\n");
			sb.Append("  AddressOfRecord: ").Append(AddressOfRecord).Append("\n");
			sb.Append("  ContactAddresses: ").Append(ContactAddresses).Append("\n");
			sb.Append("  ReachableStateTime: ").Append(ReachableStateTime).Append("\n");
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
			return this.Equals(obj as LineStatus);
		}

		/// <summary>
		/// Returns true if LineStatus instances are equal
		/// </summary>
		/// <param name="other">Instance of LineStatus to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LineStatus other)
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
					this.Reachable == other.Reachable ||
					this.Reachable != null &&
					this.Reachable.Equals(other.Reachable)
				) &&
				(
					this.AddressOfRecord == other.AddressOfRecord ||
					this.AddressOfRecord != null &&
					this.AddressOfRecord.Equals(other.AddressOfRecord)
				) &&
				(
					this.ContactAddresses == other.ContactAddresses ||
					this.ContactAddresses != null &&
					this.ContactAddresses.SequenceEqual(other.ContactAddresses)
				) &&
				(
					this.ReachableStateTime == other.ReachableStateTime ||
					this.ReachableStateTime != null &&
					this.ReachableStateTime.Equals(other.ReachableStateTime)
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

				if (this.Reachable != null)
					hash = hash * 59 + this.Reachable.GetHashCode();

				if (this.AddressOfRecord != null)
					hash = hash * 59 + this.AddressOfRecord.GetHashCode();

				if (this.ContactAddresses != null)
					hash = hash * 59 + this.ContactAddresses.GetHashCode();

				if (this.ReachableStateTime != null)
					hash = hash * 59 + this.ReachableStateTime.GetHashCode();

				return hash;
			}
		}
	}

}
