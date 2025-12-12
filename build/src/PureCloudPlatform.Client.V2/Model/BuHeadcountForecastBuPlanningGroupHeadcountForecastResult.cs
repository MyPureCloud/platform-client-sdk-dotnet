using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuHeadcountForecastBuPlanningGroupHeadcountForecastResult
	/// </summary>
	[DataContract]
	public partial class BuHeadcountForecastBuPlanningGroupHeadcountForecastResult : IEquatable<BuHeadcountForecastBuPlanningGroupHeadcountForecastResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BuHeadcountForecastBuPlanningGroupHeadcountForecastResult" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="ReferenceStartDate">Reference start date for the interval values in each forecast entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public BuHeadcountForecastBuPlanningGroupHeadcountForecastResult(List<BuPlanningGroupHeadcountForecastResult> Entities = null, DateTime? ReferenceStartDate = null)
		{
			this.Entities = Entities;
			this.ReferenceStartDate = ReferenceStartDate;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<BuPlanningGroupHeadcountForecastResult> Entities { get; set; }



		/// <summary>
		/// Reference start date for the interval values in each forecast entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Reference start date for the interval values in each forecast entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "referenceStartDate", EmitDefaultValue = false)]
		public DateTime? ReferenceStartDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuHeadcountForecastBuPlanningGroupHeadcountForecastResult {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
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
			return this.Equals(obj as BuHeadcountForecastBuPlanningGroupHeadcountForecastResult);
		}

		/// <summary>
		/// Returns true if BuHeadcountForecastBuPlanningGroupHeadcountForecastResult instances are equal
		/// </summary>
		/// <param name="other">Instance of BuHeadcountForecastBuPlanningGroupHeadcountForecastResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuHeadcountForecastBuPlanningGroupHeadcountForecastResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.ReferenceStartDate == other.ReferenceStartDate ||
					this.ReferenceStartDate != null &&
					this.ReferenceStartDate.Equals(other.ReferenceStartDate)
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
				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.ReferenceStartDate != null)
					hash = hash * 59 + this.ReferenceStartDate.GetHashCode();

				return hash;
			}
		}
	}

}
