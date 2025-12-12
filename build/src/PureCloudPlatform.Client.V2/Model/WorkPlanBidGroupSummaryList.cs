using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkPlanBidGroupSummaryList
	/// </summary>
	[DataContract]
	public partial class WorkPlanBidGroupSummaryList : IEquatable<WorkPlanBidGroupSummaryList>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanBidGroupSummaryList" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WorkPlanBidGroupSummaryList() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanBidGroupSummaryList" /> class.
		/// </summary>
		/// <param name="_WorkPlanBidGroupSummaryList">List of work plan bid group summary (required).</param>
		public WorkPlanBidGroupSummaryList(List<WorkPlanBidGroupSummary> _WorkPlanBidGroupSummaryList = null)
		{
			this._WorkPlanBidGroupSummaryList = _WorkPlanBidGroupSummaryList;

		}



		/// <summary>
		/// List of work plan bid group summary
		/// </summary>
		/// <value>List of work plan bid group summary</value>
		[DataMember(Name = "workPlanBidGroupSummaryList", EmitDefaultValue = false)]
		public List<WorkPlanBidGroupSummary> _WorkPlanBidGroupSummaryList { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkPlanBidGroupSummaryList {\n");

			sb.Append("  _WorkPlanBidGroupSummaryList: ").Append(_WorkPlanBidGroupSummaryList).Append("\n");
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
			return this.Equals(obj as WorkPlanBidGroupSummaryList);
		}

		/// <summary>
		/// Returns true if WorkPlanBidGroupSummaryList instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkPlanBidGroupSummaryList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkPlanBidGroupSummaryList other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this._WorkPlanBidGroupSummaryList == other._WorkPlanBidGroupSummaryList ||
					this._WorkPlanBidGroupSummaryList != null &&
					this._WorkPlanBidGroupSummaryList.SequenceEqual(other._WorkPlanBidGroupSummaryList)
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
				if (this._WorkPlanBidGroupSummaryList != null)
					hash = hash * 59 + this._WorkPlanBidGroupSummaryList.GetHashCode();

				return hash;
			}
		}
	}

}
