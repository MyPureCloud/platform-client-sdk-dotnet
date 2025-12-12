using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// V2QueueObservationMetricCountGroup
	/// </summary>
	[DataContract]
	public partial class V2QueueObservationMetricCountGroup : IEquatable<V2QueueObservationMetricCountGroup>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="V2QueueObservationMetricCountGroup" /> class.
		/// </summary>
		/// <param name="MediaType">MediaType for this set of observations.</param>
		/// <param name="Data">Observation metric data.</param>
		public V2QueueObservationMetricCountGroup(string MediaType = null, List<V2QueueObservationMetricCountData> Data = null)
		{
			this.MediaType = MediaType;
			this.Data = Data;

		}



		/// <summary>
		/// MediaType for this set of observations
		/// </summary>
		/// <value>MediaType for this set of observations</value>
		[DataMember(Name = "mediaType", EmitDefaultValue = false)]
		public string MediaType { get; set; }



		/// <summary>
		/// Observation metric data
		/// </summary>
		/// <value>Observation metric data</value>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public List<V2QueueObservationMetricCountData> Data { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class V2QueueObservationMetricCountGroup {\n");

			sb.Append("  MediaType: ").Append(MediaType).Append("\n");
			sb.Append("  Data: ").Append(Data).Append("\n");
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
			return this.Equals(obj as V2QueueObservationMetricCountGroup);
		}

		/// <summary>
		/// Returns true if V2QueueObservationMetricCountGroup instances are equal
		/// </summary>
		/// <param name="other">Instance of V2QueueObservationMetricCountGroup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(V2QueueObservationMetricCountGroup other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MediaType == other.MediaType ||
					this.MediaType != null &&
					this.MediaType.Equals(other.MediaType)
				) &&
				(
					this.Data == other.Data ||
					this.Data != null &&
					this.Data.SequenceEqual(other.Data)
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
				if (this.MediaType != null)
					hash = hash * 59 + this.MediaType.GetHashCode();

				if (this.Data != null)
					hash = hash * 59 + this.Data.GetHashCode();

				return hash;
			}
		}
	}

}
