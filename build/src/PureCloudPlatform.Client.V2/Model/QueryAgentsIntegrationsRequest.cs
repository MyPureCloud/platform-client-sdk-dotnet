using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Query integrations for agents request
	/// </summary>
	[DataContract]
	public partial class QueryAgentsIntegrationsRequest : IEquatable<QueryAgentsIntegrationsRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="QueryAgentsIntegrationsRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected QueryAgentsIntegrationsRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="QueryAgentsIntegrationsRequest" /> class.
		/// </summary>
		/// <param name="AgentIds">The IDs of the agents to query associated integrations (required).</param>
		public QueryAgentsIntegrationsRequest(List<string> AgentIds = null)
		{
			this.AgentIds = AgentIds;

		}



		/// <summary>
		/// The IDs of the agents to query associated integrations
		/// </summary>
		/// <value>The IDs of the agents to query associated integrations</value>
		[DataMember(Name = "agentIds", EmitDefaultValue = false)]
		public List<string> AgentIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueryAgentsIntegrationsRequest {\n");

			sb.Append("  AgentIds: ").Append(AgentIds).Append("\n");
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
			return this.Equals(obj as QueryAgentsIntegrationsRequest);
		}

		/// <summary>
		/// Returns true if QueryAgentsIntegrationsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of QueryAgentsIntegrationsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueryAgentsIntegrationsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.AgentIds == other.AgentIds ||
					this.AgentIds != null &&
					this.AgentIds.SequenceEqual(other.AgentIds)
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
				if (this.AgentIds != null)
					hash = hash * 59 + this.AgentIds.GetHashCode();

				return hash;
			}
		}
	}

}
