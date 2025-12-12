using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Details about the action map from the Journey System which triggered this action
	/// </summary>
	[DataContract]
	public partial class ConversationChatEventTopicJourneyActionMap : IEquatable<ConversationChatEventTopicJourneyActionMap>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationChatEventTopicJourneyActionMap" /> class.
		/// </summary>
		/// <param name="Id">The ID of the actionMap in the Journey System which triggered this action.</param>
		/// <param name="Version">The version number of the actionMap in the Journey System at the time this action was triggered.</param>
		public ConversationChatEventTopicJourneyActionMap(string Id = null, long? Version = null)
		{
			this.Id = Id;
			this.Version = Version;

		}



		/// <summary>
		/// The ID of the actionMap in the Journey System which triggered this action
		/// </summary>
		/// <value>The ID of the actionMap in the Journey System which triggered this action</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The version number of the actionMap in the Journey System at the time this action was triggered
		/// </summary>
		/// <value>The version number of the actionMap in the Journey System at the time this action was triggered</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public long? Version { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationChatEventTopicJourneyActionMap {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as ConversationChatEventTopicJourneyActionMap);
		}

		/// <summary>
		/// Returns true if ConversationChatEventTopicJourneyActionMap instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationChatEventTopicJourneyActionMap to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationChatEventTopicJourneyActionMap other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				return hash;
			}
		}
	}

}
