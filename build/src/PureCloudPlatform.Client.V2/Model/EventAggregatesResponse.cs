using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EventAggregatesResponse
	/// </summary>
	[DataContract]
	public partial class EventAggregatesResponse : IEquatable<EventAggregatesResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EventAggregatesResponse" /> class.
		/// </summary>
		/// <param name="Interval">Interval for returned aggregates. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
		/// <param name="EventDefinitionAggregates">Aggregates by event definition.</param>
		public EventAggregatesResponse(string Interval = null, List<EventDefinitionAggregates> EventDefinitionAggregates = null)
		{
			this.Interval = Interval;
			this.EventDefinitionAggregates = EventDefinitionAggregates;

		}



		/// <summary>
		/// Interval for returned aggregates. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Interval for returned aggregates. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// Aggregates by event definition
		/// </summary>
		/// <value>Aggregates by event definition</value>
		[DataMember(Name = "eventDefinitionAggregates", EmitDefaultValue = false)]
		public List<EventDefinitionAggregates> EventDefinitionAggregates { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EventAggregatesResponse {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  EventDefinitionAggregates: ").Append(EventDefinitionAggregates).Append("\n");
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
			return this.Equals(obj as EventAggregatesResponse);
		}

		/// <summary>
		/// Returns true if EventAggregatesResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of EventAggregatesResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EventAggregatesResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
				) &&
				(
					this.EventDefinitionAggregates == other.EventDefinitionAggregates ||
					this.EventDefinitionAggregates != null &&
					this.EventDefinitionAggregates.SequenceEqual(other.EventDefinitionAggregates)
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

				if (this.EventDefinitionAggregates != null)
					hash = hash * 59 + this.EventDefinitionAggregates.GetHashCode();

				return hash;
			}
		}
	}

}
