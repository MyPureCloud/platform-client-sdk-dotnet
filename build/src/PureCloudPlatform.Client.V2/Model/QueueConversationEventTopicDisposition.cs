using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Call resolution data for Dialer bulk make calls commands.
	/// </summary>
	[DataContract]
	public partial class QueueConversationEventTopicDisposition : IEquatable<QueueConversationEventTopicDisposition>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueueConversationEventTopicDisposition" /> class.
		/// </summary>
		/// <param name="Name">Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table...</param>
		/// <param name="Analyzer">The final media analyzer result that triggered the disposition result, if any..</param>
		/// <param name="AmdTimeout">AmdTimeout.</param>
		/// <param name="SilentCallTimeout">SilentCallTimeout.</param>
		public QueueConversationEventTopicDisposition(string Name = null, string Analyzer = null, QueueConversationEventTopicDispositionAmdTimeout AmdTimeout = null, QueueConversationEventTopicDispositionSilentCallTimeout SilentCallTimeout = null)
		{
			this.Name = Name;
			this.Analyzer = Analyzer;
			this.AmdTimeout = AmdTimeout;
			this.SilentCallTimeout = SilentCallTimeout;

		}



		/// <summary>
		/// Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..
		/// </summary>
		/// <value>Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The final media analyzer result that triggered the disposition result, if any.
		/// </summary>
		/// <value>The final media analyzer result that triggered the disposition result, if any.</value>
		[DataMember(Name = "analyzer", EmitDefaultValue = false)]
		public string Analyzer { get; set; }



		/// <summary>
		/// Gets or Sets AmdTimeout
		/// </summary>
		[DataMember(Name = "amdTimeout", EmitDefaultValue = false)]
		public QueueConversationEventTopicDispositionAmdTimeout AmdTimeout { get; set; }



		/// <summary>
		/// Gets or Sets SilentCallTimeout
		/// </summary>
		[DataMember(Name = "silentCallTimeout", EmitDefaultValue = false)]
		public QueueConversationEventTopicDispositionSilentCallTimeout SilentCallTimeout { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueueConversationEventTopicDisposition {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Analyzer: ").Append(Analyzer).Append("\n");
			sb.Append("  AmdTimeout: ").Append(AmdTimeout).Append("\n");
			sb.Append("  SilentCallTimeout: ").Append(SilentCallTimeout).Append("\n");
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
			return this.Equals(obj as QueueConversationEventTopicDisposition);
		}

		/// <summary>
		/// Returns true if QueueConversationEventTopicDisposition instances are equal
		/// </summary>
		/// <param name="other">Instance of QueueConversationEventTopicDisposition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueueConversationEventTopicDisposition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Analyzer == other.Analyzer ||
					this.Analyzer != null &&
					this.Analyzer.Equals(other.Analyzer)
				) &&
				(
					this.AmdTimeout == other.AmdTimeout ||
					this.AmdTimeout != null &&
					this.AmdTimeout.Equals(other.AmdTimeout)
				) &&
				(
					this.SilentCallTimeout == other.SilentCallTimeout ||
					this.SilentCallTimeout != null &&
					this.SilentCallTimeout.Equals(other.SilentCallTimeout)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Analyzer != null)
					hash = hash * 59 + this.Analyzer.GetHashCode();

				if (this.AmdTimeout != null)
					hash = hash * 59 + this.AmdTimeout.GetHashCode();

				if (this.SilentCallTimeout != null)
					hash = hash * 59 + this.SilentCallTimeout.GetHashCode();

				return hash;
			}
		}
	}

}
