using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Details about a Web Deployment
	/// </summary>
	[DataContract]
	public partial class ExpandableWebDeployment : IEquatable<ExpandableWebDeployment>
	{
		/// <summary>
		/// The current status of the deployment
		/// </summary>
		/// <value>The current status of the deployment</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Pending for "Pending"
			/// </summary>
			[EnumMember(Value = "Pending")]
			Pending,

			/// <summary>
			/// Enum Active for "Active"
			/// </summary>
			[EnumMember(Value = "Active")]
			Active,

			/// <summary>
			/// Enum Inactive for "Inactive"
			/// </summary>
			[EnumMember(Value = "Inactive")]
			Inactive,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error,

			/// <summary>
			/// Enum Deleting for "Deleting"
			/// </summary>
			[EnumMember(Value = "Deleting")]
			Deleting
		}
		/// <summary>
		/// The current status of the deployment
		/// </summary>
		/// <value>The current status of the deployment</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ExpandableWebDeployment" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ExpandableWebDeployment() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ExpandableWebDeployment" /> class.
		/// </summary>
		/// <param name="Name">The deployment name (required).</param>
		/// <param name="Description">The description of the config.</param>
		/// <param name="AllowAllDomains">Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true..</param>
		/// <param name="AllowedDomains">The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use..</param>
		/// <param name="SupportedContent">The supported content profile for a deployment.</param>
		/// <param name="Flow">A reference to the inboundshortmessage flow used by this deployment.</param>
		/// <param name="Status">The current status of the deployment.</param>
		/// <param name="PushIntegrations">The push integration objects associated with the deployment.</param>
		/// <param name="Configuration">The config version this deployment uses (required).</param>
		public ExpandableWebDeployment(string Name = null, string Description = null, bool? AllowAllDomains = null, List<string> AllowedDomains = null, SupportedContentReference SupportedContent = null, WebDeploymentFlowEntityRef Flow = null, StatusEnum? Status = null, List<PushIntegration> PushIntegrations = null, WebDeploymentConfigurationVersionResponse Configuration = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.AllowAllDomains = AllowAllDomains;
			this.AllowedDomains = AllowedDomains;
			this.SupportedContent = SupportedContent;
			this.Flow = Flow;
			this.Status = Status;
			this.PushIntegrations = PushIntegrations;
			this.Configuration = Configuration;

		}



		/// <summary>
		/// The deployment ID
		/// </summary>
		/// <value>The deployment ID</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The deployment name
		/// </summary>
		/// <value>The deployment name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The description of the config
		/// </summary>
		/// <value>The description of the config</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true.
		/// </summary>
		/// <value>Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true.</value>
		[DataMember(Name = "allowAllDomains", EmitDefaultValue = false)]
		public bool? AllowAllDomains { get; set; }



		/// <summary>
		/// The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use.
		/// </summary>
		/// <value>The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use.</value>
		[DataMember(Name = "allowedDomains", EmitDefaultValue = false)]
		public List<string> AllowedDomains { get; set; }



		/// <summary>
		/// The supported content profile for a deployment
		/// </summary>
		/// <value>The supported content profile for a deployment</value>
		[DataMember(Name = "supportedContent", EmitDefaultValue = false)]
		public SupportedContentReference SupportedContent { get; set; }



		/// <summary>
		/// Javascript snippet used to load the config
		/// </summary>
		/// <value>Javascript snippet used to load the config</value>
		[DataMember(Name = "snippet", EmitDefaultValue = false)]
		public string Snippet { get; private set; }



		/// <summary>
		/// The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// A reference to the user who most recently modified the deployment
		/// </summary>
		/// <value>A reference to the user who most recently modified the deployment</value>
		[DataMember(Name = "lastModifiedUser", EmitDefaultValue = false)]
		public AddressableEntityRef LastModifiedUser { get; private set; }



		/// <summary>
		/// A reference to the inboundshortmessage flow used by this deployment
		/// </summary>
		/// <value>A reference to the inboundshortmessage flow used by this deployment</value>
		[DataMember(Name = "flow", EmitDefaultValue = false)]
		public WebDeploymentFlowEntityRef Flow { get; set; }





		/// <summary>
		/// The push integration objects associated with the deployment
		/// </summary>
		/// <value>The push integration objects associated with the deployment</value>
		[DataMember(Name = "pushIntegrations", EmitDefaultValue = false)]
		public List<PushIntegration> PushIntegrations { get; set; }



		/// <summary>
		/// The config version this deployment uses
		/// </summary>
		/// <value>The config version this deployment uses</value>
		[DataMember(Name = "configuration", EmitDefaultValue = false)]
		public WebDeploymentConfigurationVersionResponse Configuration { get; set; }



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
			sb.Append("class ExpandableWebDeployment {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  AllowAllDomains: ").Append(AllowAllDomains).Append("\n");
			sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
			sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
			sb.Append("  Snippet: ").Append(Snippet).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  LastModifiedUser: ").Append(LastModifiedUser).Append("\n");
			sb.Append("  Flow: ").Append(Flow).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  PushIntegrations: ").Append(PushIntegrations).Append("\n");
			sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
			return this.Equals(obj as ExpandableWebDeployment);
		}

		/// <summary>
		/// Returns true if ExpandableWebDeployment instances are equal
		/// </summary>
		/// <param name="other">Instance of ExpandableWebDeployment to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExpandableWebDeployment other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.AllowAllDomains == other.AllowAllDomains ||
					this.AllowAllDomains != null &&
					this.AllowAllDomains.Equals(other.AllowAllDomains)
				) &&
				(
					this.AllowedDomains == other.AllowedDomains ||
					this.AllowedDomains != null &&
					this.AllowedDomains.SequenceEqual(other.AllowedDomains)
				) &&
				(
					this.SupportedContent == other.SupportedContent ||
					this.SupportedContent != null &&
					this.SupportedContent.Equals(other.SupportedContent)
				) &&
				(
					this.Snippet == other.Snippet ||
					this.Snippet != null &&
					this.Snippet.Equals(other.Snippet)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.LastModifiedUser == other.LastModifiedUser ||
					this.LastModifiedUser != null &&
					this.LastModifiedUser.Equals(other.LastModifiedUser)
				) &&
				(
					this.Flow == other.Flow ||
					this.Flow != null &&
					this.Flow.Equals(other.Flow)
				) &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.PushIntegrations == other.PushIntegrations ||
					this.PushIntegrations != null &&
					this.PushIntegrations.SequenceEqual(other.PushIntegrations)
				) &&
				(
					this.Configuration == other.Configuration ||
					this.Configuration != null &&
					this.Configuration.Equals(other.Configuration)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.AllowAllDomains != null)
					hash = hash * 59 + this.AllowAllDomains.GetHashCode();

				if (this.AllowedDomains != null)
					hash = hash * 59 + this.AllowedDomains.GetHashCode();

				if (this.SupportedContent != null)
					hash = hash * 59 + this.SupportedContent.GetHashCode();

				if (this.Snippet != null)
					hash = hash * 59 + this.Snippet.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.LastModifiedUser != null)
					hash = hash * 59 + this.LastModifiedUser.GetHashCode();

				if (this.Flow != null)
					hash = hash * 59 + this.Flow.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.PushIntegrations != null)
					hash = hash * 59 + this.PushIntegrations.GetHashCode();

				if (this.Configuration != null)
					hash = hash * 59 + this.Configuration.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
