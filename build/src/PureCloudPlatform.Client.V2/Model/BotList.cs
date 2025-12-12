using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A list of BotConnectorBots
	/// </summary>
	[DataContract]
	public partial class BotList : IEquatable<BotList>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BotList" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BotList() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BotList" /> class.
		/// </summary>
		/// <param name="ChatBots">A list of botConnector Bots. Max 50 (required).</param>
		public BotList(List<BotConnectorBot> ChatBots = null)
		{
			this.ChatBots = ChatBots;

		}



		/// <summary>
		/// A list of botConnector Bots. Max 50
		/// </summary>
		/// <value>A list of botConnector Bots. Max 50</value>
		[DataMember(Name = "chatBots", EmitDefaultValue = false)]
		public List<BotConnectorBot> ChatBots { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BotList {\n");

			sb.Append("  ChatBots: ").Append(ChatBots).Append("\n");
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
			return this.Equals(obj as BotList);
		}

		/// <summary>
		/// Returns true if BotList instances are equal
		/// </summary>
		/// <param name="other">Instance of BotList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BotList other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ChatBots == other.ChatBots ||
					this.ChatBots != null &&
					this.ChatBots.SequenceEqual(other.ChatBots)
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
				if (this.ChatBots != null)
					hash = hash * 59 + this.ChatBots.GetHashCode();

				return hash;
			}
		}
	}

}
