using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuIntradayScheduleData
	/// </summary>
	[DataContract]
	public partial class BuIntradayScheduleData : IEquatable<BuIntradayScheduleData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BuIntradayScheduleData" /> class.
		/// </summary>
		/// <param name="OnQueueTimeSeconds">The total on-queue time in seconds for all agents in this group.</param>
		public BuIntradayScheduleData(long? OnQueueTimeSeconds = null)
		{
			this.OnQueueTimeSeconds = OnQueueTimeSeconds;

		}



		/// <summary>
		/// The total on-queue time in seconds for all agents in this group
		/// </summary>
		/// <value>The total on-queue time in seconds for all agents in this group</value>
		[DataMember(Name = "onQueueTimeSeconds", EmitDefaultValue = false)]
		public long? OnQueueTimeSeconds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuIntradayScheduleData {\n");

			sb.Append("  OnQueueTimeSeconds: ").Append(OnQueueTimeSeconds).Append("\n");
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
			return this.Equals(obj as BuIntradayScheduleData);
		}

		/// <summary>
		/// Returns true if BuIntradayScheduleData instances are equal
		/// </summary>
		/// <param name="other">Instance of BuIntradayScheduleData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuIntradayScheduleData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OnQueueTimeSeconds == other.OnQueueTimeSeconds ||
					this.OnQueueTimeSeconds != null &&
					this.OnQueueTimeSeconds.Equals(other.OnQueueTimeSeconds)
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
				if (this.OnQueueTimeSeconds != null)
					hash = hash * 59 + this.OnQueueTimeSeconds.GetHashCode();

				return hash;
			}
		}
	}

}
