using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConversationSummaryTopicVirtualAgentsConversationWrapUpCode
	/// </summary>
	[DataContract]
	public partial class ConversationSummaryTopicVirtualAgentsConversationWrapUpCode : IEquatable<ConversationSummaryTopicVirtualAgentsConversationWrapUpCode>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConversationSummaryTopicVirtualAgentsConversationWrapUpCode" /> class.
		/// </summary>
		/// <param name="WrapUpCodeId">WrapUpCodeId.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Score">Score.</param>
		public ConversationSummaryTopicVirtualAgentsConversationWrapUpCode(string WrapUpCodeId = null, string Name = null, string Description = null, double? Score = null)
		{
			this.WrapUpCodeId = WrapUpCodeId;
			this.Name = Name;
			this.Description = Description;
			this.Score = Score;

		}



		/// <summary>
		/// Gets or Sets WrapUpCodeId
		/// </summary>
		[DataMember(Name = "wrapUpCodeId", EmitDefaultValue = false)]
		public string WrapUpCodeId { get; set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Gets or Sets Score
		/// </summary>
		[DataMember(Name = "score", EmitDefaultValue = false)]
		public double? Score { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConversationSummaryTopicVirtualAgentsConversationWrapUpCode {\n");

			sb.Append("  WrapUpCodeId: ").Append(WrapUpCodeId).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Score: ").Append(Score).Append("\n");
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
			return this.Equals(obj as ConversationSummaryTopicVirtualAgentsConversationWrapUpCode);
		}

		/// <summary>
		/// Returns true if ConversationSummaryTopicVirtualAgentsConversationWrapUpCode instances are equal
		/// </summary>
		/// <param name="other">Instance of ConversationSummaryTopicVirtualAgentsConversationWrapUpCode to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConversationSummaryTopicVirtualAgentsConversationWrapUpCode other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WrapUpCodeId == other.WrapUpCodeId ||
					this.WrapUpCodeId != null &&
					this.WrapUpCodeId.Equals(other.WrapUpCodeId)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Score == other.Score ||
					this.Score != null &&
					this.Score.Equals(other.Score)
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
				if (this.WrapUpCodeId != null)
					hash = hash * 59 + this.WrapUpCodeId.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Score != null)
					hash = hash * 59 + this.Score.GetHashCode();

				return hash;
			}
		}
	}

}
