using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Model for a Nuance bot environment
	/// </summary>
	[DataContract]
	public partial class NuanceEnvironment : IEquatable<NuanceEnvironment>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="NuanceEnvironment" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected NuanceEnvironment() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="NuanceEnvironment" /> class.
		/// </summary>
		/// <param name="Id">The environment ID (required).</param>
		/// <param name="Name">The environment name (required).</param>
		/// <param name="EnvironmentDesignation">The environment type, usually a value like SANDBOX or PRODUCTION (required).</param>
		/// <param name="ExecutionHost">The host used to execute this bot, similar to &#39;api.nuance.com:443&#39;.</param>
		public NuanceEnvironment(string Id = null, string Name = null, string EnvironmentDesignation = null, string ExecutionHost = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.EnvironmentDesignation = EnvironmentDesignation;
			this.ExecutionHost = ExecutionHost;

		}



		/// <summary>
		/// The environment ID
		/// </summary>
		/// <value>The environment ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The environment name
		/// </summary>
		/// <value>The environment name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The environment type, usually a value like SANDBOX or PRODUCTION
		/// </summary>
		/// <value>The environment type, usually a value like SANDBOX or PRODUCTION</value>
		[DataMember(Name = "environmentDesignation", EmitDefaultValue = false)]
		public string EnvironmentDesignation { get; set; }



		/// <summary>
		/// The host used to execute this bot, similar to &#39;api.nuance.com:443&#39;
		/// </summary>
		/// <value>The host used to execute this bot, similar to &#39;api.nuance.com:443&#39;</value>
		[DataMember(Name = "executionHost", EmitDefaultValue = false)]
		public string ExecutionHost { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NuanceEnvironment {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  EnvironmentDesignation: ").Append(EnvironmentDesignation).Append("\n");
			sb.Append("  ExecutionHost: ").Append(ExecutionHost).Append("\n");
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
			return this.Equals(obj as NuanceEnvironment);
		}

		/// <summary>
		/// Returns true if NuanceEnvironment instances are equal
		/// </summary>
		/// <param name="other">Instance of NuanceEnvironment to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NuanceEnvironment other)
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
					this.EnvironmentDesignation == other.EnvironmentDesignation ||
					this.EnvironmentDesignation != null &&
					this.EnvironmentDesignation.Equals(other.EnvironmentDesignation)
				) &&
				(
					this.ExecutionHost == other.ExecutionHost ||
					this.ExecutionHost != null &&
					this.ExecutionHost.Equals(other.ExecutionHost)
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

				if (this.EnvironmentDesignation != null)
					hash = hash * 59 + this.EnvironmentDesignation.GetHashCode();

				if (this.ExecutionHost != null)
					hash = hash * 59 + this.ExecutionHost.GetHashCode();

				return hash;
			}
		}
	}

}
