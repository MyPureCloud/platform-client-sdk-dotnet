using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AlternativeShiftOffersRequest
	/// </summary>
	[DataContract]
	public partial class AlternativeShiftOffersRequest : IEquatable<AlternativeShiftOffersRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AlternativeShiftOffersRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AlternativeShiftOffersRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AlternativeShiftOffersRequest" /> class.
		/// </summary>
		/// <param name="Schedule">The existing schedule being used to find alternative shift offers (required).</param>
		/// <param name="QueryWeekDate">The start date for the week in this schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		public AlternativeShiftOffersRequest(AlternativeShiftScheduleLookup Schedule = null, String QueryWeekDate = null)
		{
			this.Schedule = Schedule;
			this.QueryWeekDate = QueryWeekDate;

		}



		/// <summary>
		/// The existing schedule being used to find alternative shift offers
		/// </summary>
		/// <value>The existing schedule being used to find alternative shift offers</value>
		[DataMember(Name = "schedule", EmitDefaultValue = false)]
		public AlternativeShiftScheduleLookup Schedule { get; set; }



		/// <summary>
		/// The start date for the week in this schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start date for the week in this schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "queryWeekDate", EmitDefaultValue = false)]
		public String QueryWeekDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlternativeShiftOffersRequest {\n");

			sb.Append("  Schedule: ").Append(Schedule).Append("\n");
			sb.Append("  QueryWeekDate: ").Append(QueryWeekDate).Append("\n");
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
			return this.Equals(obj as AlternativeShiftOffersRequest);
		}

		/// <summary>
		/// Returns true if AlternativeShiftOffersRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of AlternativeShiftOffersRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AlternativeShiftOffersRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Schedule == other.Schedule ||
					this.Schedule != null &&
					this.Schedule.Equals(other.Schedule)
				) &&
				(
					this.QueryWeekDate == other.QueryWeekDate ||
					this.QueryWeekDate != null &&
					this.QueryWeekDate.Equals(other.QueryWeekDate)
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
				if (this.Schedule != null)
					hash = hash * 59 + this.Schedule.GetHashCode();

				if (this.QueryWeekDate != null)
					hash = hash * 59 + this.QueryWeekDate.GetHashCode();

				return hash;
			}
		}
	}

}
