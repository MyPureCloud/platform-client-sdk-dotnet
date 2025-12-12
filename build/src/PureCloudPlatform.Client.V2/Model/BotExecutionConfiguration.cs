using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Model for setting the launch configuration for a Nuance bot available to Genesys Cloud
	/// </summary>
	[DataContract]
	public partial class BotExecutionConfiguration : IEquatable<BotExecutionConfiguration>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BotExecutionConfiguration" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BotExecutionConfiguration() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BotExecutionConfiguration" /> class.
		/// </summary>
		/// <param name="BotId">The Nuance bot ID (required).</param>
		/// <param name="ExecutionHost">The hostname to use when contacting Nuance to execute this bot (required).</param>
		/// <param name="BotCredentials">The bot&#39;s launch credentials (required).</param>
		public BotExecutionConfiguration(string BotId = null, string ExecutionHost = null, NuanceBotCredentials BotCredentials = null)
		{
			this.BotId = BotId;
			this.ExecutionHost = ExecutionHost;
			this.BotCredentials = BotCredentials;

		}



		/// <summary>
		/// The Nuance bot ID
		/// </summary>
		/// <value>The Nuance bot ID</value>
		[DataMember(Name = "botId", EmitDefaultValue = false)]
		public string BotId { get; set; }



		/// <summary>
		/// The hostname to use when contacting Nuance to execute this bot
		/// </summary>
		/// <value>The hostname to use when contacting Nuance to execute this bot</value>
		[DataMember(Name = "executionHost", EmitDefaultValue = false)]
		public string ExecutionHost { get; set; }



		/// <summary>
		/// The bot&#39;s launch credentials
		/// </summary>
		/// <value>The bot&#39;s launch credentials</value>
		[DataMember(Name = "botCredentials", EmitDefaultValue = false)]
		public NuanceBotCredentials BotCredentials { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BotExecutionConfiguration {\n");

			sb.Append("  BotId: ").Append(BotId).Append("\n");
			sb.Append("  ExecutionHost: ").Append(ExecutionHost).Append("\n");
			sb.Append("  BotCredentials: ").Append(BotCredentials).Append("\n");
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
			return this.Equals(obj as BotExecutionConfiguration);
		}

		/// <summary>
		/// Returns true if BotExecutionConfiguration instances are equal
		/// </summary>
		/// <param name="other">Instance of BotExecutionConfiguration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BotExecutionConfiguration other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.BotId == other.BotId ||
					this.BotId != null &&
					this.BotId.Equals(other.BotId)
				) &&
				(
					this.ExecutionHost == other.ExecutionHost ||
					this.ExecutionHost != null &&
					this.ExecutionHost.Equals(other.ExecutionHost)
				) &&
				(
					this.BotCredentials == other.BotCredentials ||
					this.BotCredentials != null &&
					this.BotCredentials.Equals(other.BotCredentials)
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
				if (this.BotId != null)
					hash = hash * 59 + this.BotId.GetHashCode();

				if (this.ExecutionHost != null)
					hash = hash * 59 + this.ExecutionHost.GetHashCode();

				if (this.BotCredentials != null)
					hash = hash * 59 + this.BotCredentials.GetHashCode();

				return hash;
			}
		}
	}

}
