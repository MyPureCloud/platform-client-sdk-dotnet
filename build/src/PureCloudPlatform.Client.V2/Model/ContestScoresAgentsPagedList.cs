using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContestScoresAgentsPagedList
	/// </summary>
	[DataContract]
	public partial class ContestScoresAgentsPagedList : IEquatable<ContestScoresAgentsPagedList>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContestScoresAgentsPagedList" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="PageSize">PageSize.</param>
		/// <param name="PageNumber">PageNumber.</param>
		/// <param name="Total">Total.</param>
		/// <param name="DateWorkday">Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="PageCount">PageCount.</param>
		public ContestScoresAgentsPagedList(List<ContestScoresAgents> Entities = null, int? PageSize = null, int? PageNumber = null, long? Total = null, String DateWorkday = null, int? PageCount = null)
		{
			this.Entities = Entities;
			this.PageSize = PageSize;
			this.PageNumber = PageNumber;
			this.Total = Total;
			this.DateWorkday = DateWorkday;
			this.PageCount = PageCount;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<ContestScoresAgents> Entities { get; set; }



		/// <summary>
		/// Gets or Sets PageSize
		/// </summary>
		[DataMember(Name = "pageSize", EmitDefaultValue = false)]
		public int? PageSize { get; set; }



		/// <summary>
		/// Gets or Sets PageNumber
		/// </summary>
		[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
		public int? PageNumber { get; set; }



		/// <summary>
		/// Gets or Sets Total
		/// </summary>
		[DataMember(Name = "total", EmitDefaultValue = false)]
		public long? Total { get; set; }



		/// <summary>
		/// Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>Workday of the contest scores leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateWorkday", EmitDefaultValue = false)]
		public String DateWorkday { get; set; }



		/// <summary>
		/// Gets or Sets PageCount
		/// </summary>
		[DataMember(Name = "pageCount", EmitDefaultValue = false)]
		public int? PageCount { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContestScoresAgentsPagedList {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  PageSize: ").Append(PageSize).Append("\n");
			sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
			sb.Append("  Total: ").Append(Total).Append("\n");
			sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
			sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
			return this.Equals(obj as ContestScoresAgentsPagedList);
		}

		/// <summary>
		/// Returns true if ContestScoresAgentsPagedList instances are equal
		/// </summary>
		/// <param name="other">Instance of ContestScoresAgentsPagedList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContestScoresAgentsPagedList other)
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
					this.PageSize == other.PageSize ||
					this.PageSize != null &&
					this.PageSize.Equals(other.PageSize)
				) &&
				(
					this.PageNumber == other.PageNumber ||
					this.PageNumber != null &&
					this.PageNumber.Equals(other.PageNumber)
				) &&
				(
					this.Total == other.Total ||
					this.Total != null &&
					this.Total.Equals(other.Total)
				) &&
				(
					this.DateWorkday == other.DateWorkday ||
					this.DateWorkday != null &&
					this.DateWorkday.Equals(other.DateWorkday)
				) &&
				(
					this.PageCount == other.PageCount ||
					this.PageCount != null &&
					this.PageCount.Equals(other.PageCount)
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

				if (this.PageSize != null)
					hash = hash * 59 + this.PageSize.GetHashCode();

				if (this.PageNumber != null)
					hash = hash * 59 + this.PageNumber.GetHashCode();

				if (this.Total != null)
					hash = hash * 59 + this.Total.GetHashCode();

				if (this.DateWorkday != null)
					hash = hash * 59 + this.DateWorkday.GetHashCode();

				if (this.PageCount != null)
					hash = hash * 59 + this.PageCount.GetHashCode();

				return hash;
			}
		}
	}

}
