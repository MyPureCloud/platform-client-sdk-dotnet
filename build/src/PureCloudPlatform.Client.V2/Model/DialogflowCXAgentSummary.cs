using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialogflowCXAgentSummary
	/// </summary>
	[DataContract]
	public partial class DialogflowCXAgentSummary : IEquatable<DialogflowCXAgentSummary>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DialogflowCXAgentSummary" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Project">The project this Dialogflow CX agent belongs to..</param>
		/// <param name="Description">A description of the Dialogflow CX agent..</param>
		/// <param name="Integration">The Integration this Dialogflow CX agent was referenced from..</param>
		public DialogflowCXAgentSummary(string Name = null, DialogflowCXProject Project = null, string Description = null, DomainEntityRef Integration = null)
		{
			this.Name = Name;
			this.Project = Project;
			this.Description = Description;
			this.Integration = Integration;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The project this Dialogflow CX agent belongs to.
		/// </summary>
		/// <value>The project this Dialogflow CX agent belongs to.</value>
		[DataMember(Name = "project", EmitDefaultValue = false)]
		public DialogflowCXProject Project { get; set; }



		/// <summary>
		/// A description of the Dialogflow CX agent.
		/// </summary>
		/// <value>A description of the Dialogflow CX agent.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The Integration this Dialogflow CX agent was referenced from.
		/// </summary>
		/// <value>The Integration this Dialogflow CX agent was referenced from.</value>
		[DataMember(Name = "integration", EmitDefaultValue = false)]
		public DomainEntityRef Integration { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialogflowCXAgentSummary {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Project: ").Append(Project).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Integration: ").Append(Integration).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as DialogflowCXAgentSummary);
		}

		/// <summary>
		/// Returns true if DialogflowCXAgentSummary instances are equal
		/// </summary>
		/// <param name="other">Instance of DialogflowCXAgentSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialogflowCXAgentSummary other)
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
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Project == other.Project ||
					this.Project != null &&
					this.Project.Equals(other.Project)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Integration == other.Integration ||
					this.Integration != null &&
					this.Integration.Equals(other.Integration)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Project != null)
					hash = hash * 59 + this.Project.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Integration != null)
					hash = hash * 59 + this.Integration.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
