using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DeploymentPing
	/// </summary>
	[DataContract]
	public partial class DeploymentPing : IEquatable<DeploymentPing>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DeploymentPing" /> class.
		/// </summary>
		/// <param name="Actions">Collection of actions to be offered or displayed to the visitor..</param>
		/// <param name="PollIntervalMilliseconds">Custom poll interval in milliseconds; when the return value is -1, disable pings..</param>
		public DeploymentPing(List<DeploymentWebAction> Actions = null, int? PollIntervalMilliseconds = null)
		{
			this.Actions = Actions;
			this.PollIntervalMilliseconds = PollIntervalMilliseconds;

		}



		/// <summary>
		/// Collection of actions to be offered or displayed to the visitor.
		/// </summary>
		/// <value>Collection of actions to be offered or displayed to the visitor.</value>
		[DataMember(Name = "actions", EmitDefaultValue = false)]
		public List<DeploymentWebAction> Actions { get; set; }



		/// <summary>
		/// Custom poll interval in milliseconds; when the return value is -1, disable pings.
		/// </summary>
		/// <value>Custom poll interval in milliseconds; when the return value is -1, disable pings.</value>
		[DataMember(Name = "pollIntervalMilliseconds", EmitDefaultValue = false)]
		public int? PollIntervalMilliseconds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeploymentPing {\n");

			sb.Append("  Actions: ").Append(Actions).Append("\n");
			sb.Append("  PollIntervalMilliseconds: ").Append(PollIntervalMilliseconds).Append("\n");
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
			return this.Equals(obj as DeploymentPing);
		}

		/// <summary>
		/// Returns true if DeploymentPing instances are equal
		/// </summary>
		/// <param name="other">Instance of DeploymentPing to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DeploymentPing other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Actions == other.Actions ||
					this.Actions != null &&
					this.Actions.SequenceEqual(other.Actions)
				) &&
				(
					this.PollIntervalMilliseconds == other.PollIntervalMilliseconds ||
					this.PollIntervalMilliseconds != null &&
					this.PollIntervalMilliseconds.Equals(other.PollIntervalMilliseconds)
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
				if (this.Actions != null)
					hash = hash * 59 + this.Actions.GetHashCode();

				if (this.PollIntervalMilliseconds != null)
					hash = hash * 59 + this.PollIntervalMilliseconds.GetHashCode();

				return hash;
			}
		}
	}

}
