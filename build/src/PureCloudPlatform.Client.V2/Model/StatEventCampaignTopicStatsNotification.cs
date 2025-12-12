using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// StatEventCampaignTopicStatsNotification
	/// </summary>
	[DataContract]
	public partial class StatEventCampaignTopicStatsNotification : IEquatable<StatEventCampaignTopicStatsNotification>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StatEventCampaignTopicStatsNotification" /> class.
		/// </summary>
		/// <param name="Group">Group.</param>
		/// <param name="Data">Data.</param>
		public StatEventCampaignTopicStatsNotification(Dictionary<string, string> Group = null, List<StatEventCampaignTopicIntervalMetrics> Data = null)
		{
			this.Group = Group;
			this.Data = Data;

		}



		/// <summary>
		/// Gets or Sets Group
		/// </summary>
		[DataMember(Name = "group", EmitDefaultValue = false)]
		public Dictionary<string, string> Group { get; set; }



		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name = "data", EmitDefaultValue = false)]
		public List<StatEventCampaignTopicIntervalMetrics> Data { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class StatEventCampaignTopicStatsNotification {\n");

			sb.Append("  Group: ").Append(Group).Append("\n");
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
			return this.Equals(obj as StatEventCampaignTopicStatsNotification);
		}

		/// <summary>
		/// Returns true if StatEventCampaignTopicStatsNotification instances are equal
		/// </summary>
		/// <param name="other">Instance of StatEventCampaignTopicStatsNotification to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(StatEventCampaignTopicStatsNotification other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Group == other.Group ||
					this.Group != null &&
					this.Group.SequenceEqual(other.Group)
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
				if (this.Group != null)
					hash = hash * 59 + this.Group.GetHashCode();

				if (this.Data != null)
					hash = hash * 59 + this.Data.GetHashCode();

				return hash;
			}
		}
	}

}
