using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EdgeAutoUpdateConfig
	/// </summary>
	[DataContract]
	public partial class EdgeAutoUpdateConfig : IEquatable<EdgeAutoUpdateConfig>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="EdgeAutoUpdateConfig" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected EdgeAutoUpdateConfig() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="EdgeAutoUpdateConfig" /> class.
		/// </summary>
		/// <param name="TimeZone">The timezone of the window in which any updates to the edges assigned to the site can be applied. The minimum size of the window is 2 hours. (required).</param>
		/// <param name="Rrule">The recurrence rule for updating the Edges assigned to the site. The only supported frequencies are daily and weekly. Weekly frequencies require a day list with at least oneday specified. All other configurations are not supported. (required).</param>
		/// <param name="Start">Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS (required).</param>
		/// <param name="End">Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS (required).</param>
		public EdgeAutoUpdateConfig(string TimeZone = null, string Rrule = null, DateTime? Start = null, DateTime? End = null)
		{
			this.TimeZone = TimeZone;
			this.Rrule = Rrule;
			this.Start = Start;
			this.End = End;

		}



		/// <summary>
		/// The timezone of the window in which any updates to the edges assigned to the site can be applied. The minimum size of the window is 2 hours.
		/// </summary>
		/// <value>The timezone of the window in which any updates to the edges assigned to the site can be applied. The minimum size of the window is 2 hours.</value>
		[DataMember(Name = "timeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }



		/// <summary>
		/// The recurrence rule for updating the Edges assigned to the site. The only supported frequencies are daily and weekly. Weekly frequencies require a day list with at least oneday specified. All other configurations are not supported.
		/// </summary>
		/// <value>The recurrence rule for updating the Edges assigned to the site. The only supported frequencies are daily and weekly. Weekly frequencies require a day list with at least oneday specified. All other configurations are not supported.</value>
		[DataMember(Name = "rrule", EmitDefaultValue = false)]
		public string Rrule { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS</value>
		[DataMember(Name = "start", EmitDefaultValue = false)]
		public DateTime? Start { get; set; }



		/// <summary>
		/// Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS
		/// </summary>
		/// <value>Date time is represented as an ISO-8601 string without a timezone. For example: yyyy-MM-ddTHH:mm:ss.SSS</value>
		[DataMember(Name = "end", EmitDefaultValue = false)]
		public DateTime? End { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EdgeAutoUpdateConfig {\n");

			sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
			sb.Append("  Rrule: ").Append(Rrule).Append("\n");
			sb.Append("  Start: ").Append(Start).Append("\n");
			sb.Append("  End: ").Append(End).Append("\n");
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
			return this.Equals(obj as EdgeAutoUpdateConfig);
		}

		/// <summary>
		/// Returns true if EdgeAutoUpdateConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of EdgeAutoUpdateConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EdgeAutoUpdateConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TimeZone == other.TimeZone ||
					this.TimeZone != null &&
					this.TimeZone.Equals(other.TimeZone)
				) &&
				(
					this.Rrule == other.Rrule ||
					this.Rrule != null &&
					this.Rrule.Equals(other.Rrule)
				) &&
				(
					this.Start == other.Start ||
					this.Start != null &&
					this.Start.Equals(other.Start)
				) &&
				(
					this.End == other.End ||
					this.End != null &&
					this.End.Equals(other.End)
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
				if (this.TimeZone != null)
					hash = hash * 59 + this.TimeZone.GetHashCode();

				if (this.Rrule != null)
					hash = hash * 59 + this.Rrule.GetHashCode();

				if (this.Start != null)
					hash = hash * 59 + this.Start.GetHashCode();

				if (this.End != null)
					hash = hash * 59 + this.End.GetHashCode();

				return hash;
			}
		}
	}

}
