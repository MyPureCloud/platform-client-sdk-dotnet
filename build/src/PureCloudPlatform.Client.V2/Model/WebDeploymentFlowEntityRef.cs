using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WebDeploymentFlowEntityRef
	/// </summary>
	[DataContract]
	public partial class WebDeploymentFlowEntityRef : IEquatable<WebDeploymentFlowEntityRef>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="WebDeploymentFlowEntityRef" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WebDeploymentFlowEntityRef() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WebDeploymentFlowEntityRef" /> class.
		/// </summary>
		/// <param name="Id">The Flow ID (required).</param>
		/// <param name="Name">The Flow name.</param>
		/// <param name="SelfUri">SelfUri.</param>
		/// <param name="FlowDescription">The flow description for the webdeployment.</param>
		/// <param name="PublishVersion">The published config version for the associated deployment.</param>
		public WebDeploymentFlowEntityRef(string Id = null, string Name = null, string SelfUri = null, string FlowDescription = null, FlowVersion PublishVersion = null)
		{
			this.Id = Id;
			this.Name = Name;
			this.SelfUri = SelfUri;
			this.FlowDescription = FlowDescription;
			this.PublishVersion = PublishVersion;

		}



		/// <summary>
		/// The Flow ID
		/// </summary>
		/// <value>The Flow ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The Flow name
		/// </summary>
		/// <value>The Flow name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets SelfUri
		/// </summary>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; set; }



		/// <summary>
		/// The flow description for the webdeployment
		/// </summary>
		/// <value>The flow description for the webdeployment</value>
		[DataMember(Name = "flowDescription", EmitDefaultValue = false)]
		public string FlowDescription { get; set; }



		/// <summary>
		/// The published config version for the associated deployment
		/// </summary>
		/// <value>The published config version for the associated deployment</value>
		[DataMember(Name = "publishVersion", EmitDefaultValue = false)]
		public FlowVersion PublishVersion { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WebDeploymentFlowEntityRef {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
			sb.Append("  FlowDescription: ").Append(FlowDescription).Append("\n");
			sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
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
			return this.Equals(obj as WebDeploymentFlowEntityRef);
		}

		/// <summary>
		/// Returns true if WebDeploymentFlowEntityRef instances are equal
		/// </summary>
		/// <param name="other">Instance of WebDeploymentFlowEntityRef to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WebDeploymentFlowEntityRef other)
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
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
				) &&
				(
					this.FlowDescription == other.FlowDescription ||
					this.FlowDescription != null &&
					this.FlowDescription.Equals(other.FlowDescription)
				) &&
				(
					this.PublishVersion == other.PublishVersion ||
					this.PublishVersion != null &&
					this.PublishVersion.Equals(other.PublishVersion)
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

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				if (this.FlowDescription != null)
					hash = hash * 59 + this.FlowDescription.GetHashCode();

				if (this.PublishVersion != null)
					hash = hash * 59 + this.PublishVersion.GetHashCode();

				return hash;
			}
		}
	}

}
