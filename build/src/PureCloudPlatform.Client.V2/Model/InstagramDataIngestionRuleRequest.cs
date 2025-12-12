using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InstagramDataIngestionRuleRequest
	/// </summary>
	[DataContract]
	public partial class InstagramDataIngestionRuleRequest : IEquatable<InstagramDataIngestionRuleRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="InstagramDataIngestionRuleRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected InstagramDataIngestionRuleRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="InstagramDataIngestionRuleRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the data ingestion rule. (required).</param>
		/// <param name="Description">A description of the data ingestion rule..</param>
		/// <param name="IntegrationId">The Integration Id from which public social posts are ingested. This entity is created using the /conversations/messaging/integrations/instagram resource (required).</param>
		public InstagramDataIngestionRuleRequest(string Name = null, string Description = null, string IntegrationId = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.IntegrationId = IntegrationId;

		}



		/// <summary>
		/// The name of the data ingestion rule.
		/// </summary>
		/// <value>The name of the data ingestion rule.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// A description of the data ingestion rule.
		/// </summary>
		/// <value>A description of the data ingestion rule.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The Integration Id from which public social posts are ingested. This entity is created using the /conversations/messaging/integrations/instagram resource
		/// </summary>
		/// <value>The Integration Id from which public social posts are ingested. This entity is created using the /conversations/messaging/integrations/instagram resource</value>
		[DataMember(Name = "integrationId", EmitDefaultValue = false)]
		public string IntegrationId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InstagramDataIngestionRuleRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
			return this.Equals(obj as InstagramDataIngestionRuleRequest);
		}

		/// <summary>
		/// Returns true if InstagramDataIngestionRuleRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of InstagramDataIngestionRuleRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InstagramDataIngestionRuleRequest other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.IntegrationId == other.IntegrationId ||
					this.IntegrationId != null &&
					this.IntegrationId.Equals(other.IntegrationId)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.IntegrationId != null)
					hash = hash * 59 + this.IntegrationId.GetHashCode();

				return hash;
			}
		}
	}

}
