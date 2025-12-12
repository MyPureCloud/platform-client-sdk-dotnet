using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TimeOffBalancesResponse
	/// </summary>
	[DataContract]
	public partial class TimeOffBalancesResponse : IEquatable<TimeOffBalancesResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TimeOffBalancesResponse" /> class.
		/// </summary>
		/// <param name="Job">The asynchronous job handling the query.</param>
		/// <param name="Entities">The list of time off balances. May come via notification.</param>
		public TimeOffBalancesResponse(TimeOffBalanceJobReference Job = null, List<TimeOffBalanceResponse> Entities = null)
		{
			this.Job = Job;
			this.Entities = Entities;

		}



		/// <summary>
		/// The asynchronous job handling the query
		/// </summary>
		/// <value>The asynchronous job handling the query</value>
		[DataMember(Name = "job", EmitDefaultValue = false)]
		public TimeOffBalanceJobReference Job { get; set; }



		/// <summary>
		/// The list of time off balances. May come via notification
		/// </summary>
		/// <value>The list of time off balances. May come via notification</value>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<TimeOffBalanceResponse> Entities { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TimeOffBalancesResponse {\n");

			sb.Append("  Job: ").Append(Job).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
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
			return this.Equals(obj as TimeOffBalancesResponse);
		}

		/// <summary>
		/// Returns true if TimeOffBalancesResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of TimeOffBalancesResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TimeOffBalancesResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Job == other.Job ||
					this.Job != null &&
					this.Job.Equals(other.Job)
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
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
				if (this.Job != null)
					hash = hash * 59 + this.Job.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				return hash;
			}
		}
	}

}
