using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreatePlanningGroupRequest
	/// </summary>
	[DataContract]
	public partial class CreatePlanningGroupRequest : IEquatable<CreatePlanningGroupRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CreatePlanningGroupRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreatePlanningGroupRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreatePlanningGroupRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the planning group (required).</param>
		/// <param name="RoutePaths">Set of route paths to associate with the planning group (required).</param>
		/// <param name="ServiceGoalTemplateId">The ID of the service goal template to associate with this planning group (required).</param>
		public CreatePlanningGroupRequest(string Name = null, List<RoutePathRequest> RoutePaths = null, string ServiceGoalTemplateId = null)
		{
			this.Name = Name;
			this.RoutePaths = RoutePaths;
			this.ServiceGoalTemplateId = ServiceGoalTemplateId;

		}



		/// <summary>
		/// The name of the planning group
		/// </summary>
		/// <value>The name of the planning group</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Set of route paths to associate with the planning group
		/// </summary>
		/// <value>Set of route paths to associate with the planning group</value>
		[DataMember(Name = "routePaths", EmitDefaultValue = false)]
		public List<RoutePathRequest> RoutePaths { get; set; }



		/// <summary>
		/// The ID of the service goal template to associate with this planning group
		/// </summary>
		/// <value>The ID of the service goal template to associate with this planning group</value>
		[DataMember(Name = "serviceGoalTemplateId", EmitDefaultValue = false)]
		public string ServiceGoalTemplateId { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreatePlanningGroupRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  RoutePaths: ").Append(RoutePaths).Append("\n");
			sb.Append("  ServiceGoalTemplateId: ").Append(ServiceGoalTemplateId).Append("\n");
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
			return this.Equals(obj as CreatePlanningGroupRequest);
		}

		/// <summary>
		/// Returns true if CreatePlanningGroupRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CreatePlanningGroupRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreatePlanningGroupRequest other)
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
					this.RoutePaths == other.RoutePaths ||
					this.RoutePaths != null &&
					this.RoutePaths.SequenceEqual(other.RoutePaths)
				) &&
				(
					this.ServiceGoalTemplateId == other.ServiceGoalTemplateId ||
					this.ServiceGoalTemplateId != null &&
					this.ServiceGoalTemplateId.Equals(other.ServiceGoalTemplateId)
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

				if (this.RoutePaths != null)
					hash = hash * 59 + this.RoutePaths.GetHashCode();

				if (this.ServiceGoalTemplateId != null)
					hash = hash * 59 + this.ServiceGoalTemplateId.GetHashCode();

				return hash;
			}
		}
	}

}
