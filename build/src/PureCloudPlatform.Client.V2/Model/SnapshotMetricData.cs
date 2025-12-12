using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SnapshotMetricData
	/// </summary>
	[DataContract]
	public partial class SnapshotMetricData : IEquatable<SnapshotMetricData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SnapshotMetricData" /> class.
		/// </summary>
		/// <param name="Weekly">Weekly time series for snapshot data.</param>
		/// <param name="QuarterHour">Quarter hour time series for snapshot data.</param>
		public SnapshotMetricData(Weekly Weekly = null, QuarterHourly QuarterHour = null)
		{
			this.Weekly = Weekly;
			this.QuarterHour = QuarterHour;

		}



		/// <summary>
		/// Weekly time series for snapshot data
		/// </summary>
		/// <value>Weekly time series for snapshot data</value>
		[DataMember(Name = "weekly", EmitDefaultValue = false)]
		public Weekly Weekly { get; set; }



		/// <summary>
		/// Quarter hour time series for snapshot data
		/// </summary>
		/// <value>Quarter hour time series for snapshot data</value>
		[DataMember(Name = "quarterHour", EmitDefaultValue = false)]
		public QuarterHourly QuarterHour { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SnapshotMetricData {\n");

			sb.Append("  Weekly: ").Append(Weekly).Append("\n");
			sb.Append("  QuarterHour: ").Append(QuarterHour).Append("\n");
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
			return this.Equals(obj as SnapshotMetricData);
		}

		/// <summary>
		/// Returns true if SnapshotMetricData instances are equal
		/// </summary>
		/// <param name="other">Instance of SnapshotMetricData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SnapshotMetricData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Weekly == other.Weekly ||
					this.Weekly != null &&
					this.Weekly.Equals(other.Weekly)
				) &&
				(
					this.QuarterHour == other.QuarterHour ||
					this.QuarterHour != null &&
					this.QuarterHour.Equals(other.QuarterHour)
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
				if (this.Weekly != null)
					hash = hash * 59 + this.Weekly.GetHashCode();

				if (this.QuarterHour != null)
					hash = hash * 59 + this.QuarterHour.GetHashCode();

				return hash;
			}
		}
	}

}
