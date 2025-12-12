using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EventAggregatesQueryRequest
	/// </summary>
	[DataContract]
	public partial class EventAggregatesQueryRequest : IEquatable<EventAggregatesQueryRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="EventAggregatesQueryRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected EventAggregatesQueryRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="EventAggregatesQueryRequest" /> class.
		/// </summary>
		/// <param name="Interval">Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
		public EventAggregatesQueryRequest(string Interval = null)
		{
			this.Interval = Interval;

		}



		/// <summary>
		/// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EventAggregatesQueryRequest {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
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
			return this.Equals(obj as EventAggregatesQueryRequest);
		}

		/// <summary>
		/// Returns true if EventAggregatesQueryRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of EventAggregatesQueryRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EventAggregatesQueryRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
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
				if (this.Interval != null)
					hash = hash * 59 + this.Interval.GetHashCode();

				return hash;
			}
		}
	}

}
