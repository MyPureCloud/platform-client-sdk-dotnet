using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Edge
	/// </summary>
	[DataContract]
	public partial class Edge : IEquatable<Edge>
	{
		/// <summary>
		/// Indicates if the resource is active, inactive, or deleted.
		/// </summary>
		/// <value>Indicates if the resource is active, inactive, or deleted.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Active for "active"
			/// </summary>
			[EnumMember(Value = "active")]
			Active,

			/// <summary>
			/// Enum Inactive for "inactive"
			/// </summary>
			[EnumMember(Value = "inactive")]
			Inactive,

			/// <summary>
			/// Enum Deleted for "deleted"
			/// </summary>
			[EnumMember(Value = "deleted")]
			Deleted
		}
		/// <summary>
		/// The current status of the Edge.
		/// </summary>
		/// <value>The current status of the Edge.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusCodeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum New for "NEW"
			/// </summary>
			[EnumMember(Value = "NEW")]
			New,

			/// <summary>
			/// Enum AwaitingConnection for "AWAITING_CONNECTION"
			/// </summary>
			[EnumMember(Value = "AWAITING_CONNECTION")]
			AwaitingConnection,

			/// <summary>
			/// Enum AwaitingFingerprint for "AWAITING_FINGERPRINT"
			/// </summary>
			[EnumMember(Value = "AWAITING_FINGERPRINT")]
			AwaitingFingerprint,

			/// <summary>
			/// Enum AwaitingFingerprintVerification for "AWAITING_FINGERPRINT_VERIFICATION"
			/// </summary>
			[EnumMember(Value = "AWAITING_FINGERPRINT_VERIFICATION")]
			AwaitingFingerprintVerification,

			/// <summary>
			/// Enum FingerprintVerified for "FINGERPRINT_VERIFIED"
			/// </summary>
			[EnumMember(Value = "FINGERPRINT_VERIFIED")]
			FingerprintVerified,

			/// <summary>
			/// Enum AwaitingBootstrap for "AWAITING_BOOTSTRAP"
			/// </summary>
			[EnumMember(Value = "AWAITING_BOOTSTRAP")]
			AwaitingBootstrap,

			/// <summary>
			/// Enum Active for "ACTIVE"
			/// </summary>
			[EnumMember(Value = "ACTIVE")]
			Active,

			/// <summary>
			/// Enum Inactive for "INACTIVE"
			/// </summary>
			[EnumMember(Value = "INACTIVE")]
			Inactive,

			/// <summary>
			/// Enum Rma for "RMA"
			/// </summary>
			[EnumMember(Value = "RMA")]
			Rma,

			/// <summary>
			/// Enum Unpairing for "UNPAIRING"
			/// </summary>
			[EnumMember(Value = "UNPAIRING")]
			Unpairing,

			/// <summary>
			/// Enum Unpaired for "UNPAIRED"
			/// </summary>
			[EnumMember(Value = "UNPAIRED")]
			Unpaired,

			/// <summary>
			/// Enum Initializing for "INITIALIZING"
			/// </summary>
			[EnumMember(Value = "INITIALIZING")]
			Initializing
		}
		/// <summary>
		/// Gets or Sets OnlineStatus
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum OnlineStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Online for "ONLINE"
			/// </summary>
			[EnumMember(Value = "ONLINE")]
			Online,

			/// <summary>
			/// Enum Offline for "OFFLINE"
			/// </summary>
			[EnumMember(Value = "OFFLINE")]
			Offline
		}
		/// <summary>
		/// Gets or Sets EdgeDeploymentType
		/// </summary>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum EdgeDeploymentTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Hardware for "HARDWARE"
			/// </summary>
			[EnumMember(Value = "HARDWARE")]
			Hardware,

			/// <summary>
			/// Enum Ldm for "LDM"
			/// </summary>
			[EnumMember(Value = "LDM")]
			Ldm,

			/// <summary>
			/// Enum Cdm for "CDM"
			/// </summary>
			[EnumMember(Value = "CDM")]
			Cdm,

			/// <summary>
			/// Enum Chs for "CHS"
			/// </summary>
			[EnumMember(Value = "CHS")]
			Chs,

			/// <summary>
			/// Enum Invalid for "INVALID"
			/// </summary>
			[EnumMember(Value = "INVALID")]
			Invalid
		}
		/// <summary>
		/// The type of certificate used to communicate with edge-proxy.
		/// </summary>
		/// <value>The type of certificate used to communicate with edge-proxy.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CertTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Purecloud for "PureCloud"
			/// </summary>
			[EnumMember(Value = "PureCloud")]
			Purecloud,

			/// <summary>
			/// Enum Public for "Public"
			/// </summary>
			[EnumMember(Value = "Public")]
			Public,

			/// <summary>
			/// Enum China for "China"
			/// </summary>
			[EnumMember(Value = "China")]
			China,

			/// <summary>
			/// Enum Notrequested for "NotRequested"
			/// </summary>
			[EnumMember(Value = "NotRequested")]
			Notrequested
		}
		/// <summary>
		/// The current state of the Edge's call draining process before it can be safely rebooted or updated.
		/// </summary>
		/// <value>The current state of the Edge's call draining process before it can be safely rebooted or updated.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum CallDrainingStateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum None for "NONE"
			/// </summary>
			[EnumMember(Value = "NONE")]
			None,

			/// <summary>
			/// Enum Wait for "WAIT"
			/// </summary>
			[EnumMember(Value = "WAIT")]
			Wait,

			/// <summary>
			/// Enum WaitTimeout for "WAIT_TIMEOUT"
			/// </summary>
			[EnumMember(Value = "WAIT_TIMEOUT")]
			WaitTimeout,

			/// <summary>
			/// Enum Terminate for "TERMINATE"
			/// </summary>
			[EnumMember(Value = "TERMINATE")]
			Terminate,

			/// <summary>
			/// Enum Complete for "COMPLETE"
			/// </summary>
			[EnumMember(Value = "COMPLETE")]
			Complete
		}
		/// <summary>
		/// Indicates if the resource is active, inactive, or deleted.
		/// </summary>
		/// <value>Indicates if the resource is active, inactive, or deleted.</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; private set; }
		/// <summary>
		/// The current status of the Edge.
		/// </summary>
		/// <value>The current status of the Edge.</value>
		[DataMember(Name = "statusCode", EmitDefaultValue = false)]
		public StatusCodeEnum? StatusCode { get; set; }
		/// <summary>
		/// Gets or Sets OnlineStatus
		/// </summary>
		[DataMember(Name = "onlineStatus", EmitDefaultValue = false)]
		public OnlineStatusEnum? OnlineStatus { get; set; }
		/// <summary>
		/// Gets or Sets EdgeDeploymentType
		/// </summary>
		[DataMember(Name = "edgeDeploymentType", EmitDefaultValue = false)]
		public EdgeDeploymentTypeEnum? EdgeDeploymentType { get; set; }
		/// <summary>
		/// The type of certificate used to communicate with edge-proxy.
		/// </summary>
		/// <value>The type of certificate used to communicate with edge-proxy.</value>
		[DataMember(Name = "certType", EmitDefaultValue = false)]
		public CertTypeEnum? CertType { get; set; }
		/// <summary>
		/// The current state of the Edge's call draining process before it can be safely rebooted or updated.
		/// </summary>
		/// <value>The current state of the Edge's call draining process before it can be safely rebooted or updated.</value>
		[DataMember(Name = "callDrainingState", EmitDefaultValue = false)]
		public CallDrainingStateEnum? CallDrainingState { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Edge" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected Edge() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="Edge" /> class.
		/// </summary>
		/// <param name="Name">The name of the entity. (required).</param>
		/// <param name="Division">The division to which this entity belongs..</param>
		/// <param name="Description">The resource&#39;s description..</param>
		/// <param name="Version">The current version of the resource..</param>
		/// <param name="Interfaces">The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead.</param>
		/// <param name="Make">Make.</param>
		/// <param name="Model">Model.</param>
		/// <param name="ApiVersion">ApiVersion.</param>
		/// <param name="SoftwareVersion">SoftwareVersion.</param>
		/// <param name="SoftwareVersionTimestamp">SoftwareVersionTimestamp.</param>
		/// <param name="SoftwareVersionPlatform">SoftwareVersionPlatform.</param>
		/// <param name="SoftwareVersionConfiguration">SoftwareVersionConfiguration.</param>
		/// <param name="FullSoftwareVersion">FullSoftwareVersion.</param>
		/// <param name="PairingId">The pairing Id for a hardware Edge in the format: 00000-00000-00000-00000-00000. This field is only required when creating an Edge with a deployment type of HARDWARE..</param>
		/// <param name="Fingerprint">Fingerprint.</param>
		/// <param name="FingerprintHint">FingerprintHint.</param>
		/// <param name="CurrentVersion">CurrentVersion.</param>
		/// <param name="StagedVersion">StagedVersion.</param>
		/// <param name="Patch">Patch.</param>
		/// <param name="StatusCode">The current status of the Edge..</param>
		/// <param name="EdgeGroup">EdgeGroup.</param>
		/// <param name="Site">The Site to which the Edge is assigned..</param>
		/// <param name="SoftwareStatus">Details about an in-progress or recently in-progress Edge software upgrade. This node appears only if a software upgrade was recently initiated for this Edge..</param>
		/// <param name="OnlineStatus">OnlineStatus.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="PhysicalEdge">PhysicalEdge.</param>
		/// <param name="Managed">Managed.</param>
		/// <param name="EdgeDeploymentType">EdgeDeploymentType.</param>
		/// <param name="CertType">The type of certificate used to communicate with edge-proxy..</param>
		/// <param name="Proxy">Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed..</param>
		public Edge(string Name = null, Division Division = null, string Description = null, int? Version = null, List<EdgeInterface> Interfaces = null, string Make = null, string Model = null, string ApiVersion = null, string SoftwareVersion = null, string SoftwareVersionTimestamp = null, string SoftwareVersionPlatform = null, string SoftwareVersionConfiguration = null, string FullSoftwareVersion = null, string PairingId = null, string Fingerprint = null, string FingerprintHint = null, string CurrentVersion = null, string StagedVersion = null, string Patch = null, StatusCodeEnum? StatusCode = null, EdgeGroup EdgeGroup = null, Site Site = null, DomainEdgeSoftwareUpdateDto SoftwareStatus = null, OnlineStatusEnum? OnlineStatus = null, string SerialNumber = null, bool? PhysicalEdge = null, bool? Managed = null, EdgeDeploymentTypeEnum? EdgeDeploymentType = null, CertTypeEnum? CertType = null, string Proxy = null)
		{
			this.Name = Name;
			this.Division = Division;
			this.Description = Description;
			this.Version = Version;
			this.Interfaces = Interfaces;
			this.Make = Make;
			this.Model = Model;
			this.ApiVersion = ApiVersion;
			this.SoftwareVersion = SoftwareVersion;
			this.SoftwareVersionTimestamp = SoftwareVersionTimestamp;
			this.SoftwareVersionPlatform = SoftwareVersionPlatform;
			this.SoftwareVersionConfiguration = SoftwareVersionConfiguration;
			this.FullSoftwareVersion = FullSoftwareVersion;
			this.PairingId = PairingId;
			this.Fingerprint = Fingerprint;
			this.FingerprintHint = FingerprintHint;
			this.CurrentVersion = CurrentVersion;
			this.StagedVersion = StagedVersion;
			this.Patch = Patch;
			this.StatusCode = StatusCode;
			this.EdgeGroup = EdgeGroup;
			this.Site = Site;
			this.SoftwareStatus = SoftwareStatus;
			this.OnlineStatus = OnlineStatus;
			this.SerialNumber = SerialNumber;
			this.PhysicalEdge = PhysicalEdge;
			this.Managed = Managed;
			this.EdgeDeploymentType = EdgeDeploymentType;
			this.CertType = CertType;
			this.Proxy = Proxy;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the entity.
		/// </summary>
		/// <value>The name of the entity.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The division to which this entity belongs.
		/// </summary>
		/// <value>The division to which this entity belongs.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public Division Division { get; set; }



		/// <summary>
		/// The resource&#39;s description.
		/// </summary>
		/// <value>The resource&#39;s description.</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The current version of the resource.
		/// </summary>
		/// <value>The current version of the resource.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }



		/// <summary>
		/// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



		/// <summary>
		/// The ID of the user that last modified the resource.
		/// </summary>
		/// <value>The ID of the user that last modified the resource.</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public string ModifiedBy { get; private set; }



		/// <summary>
		/// The ID of the user that created the resource.
		/// </summary>
		/// <value>The ID of the user that created the resource.</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public string CreatedBy { get; private set; }





		/// <summary>
		/// The application that last modified the resource.
		/// </summary>
		/// <value>The application that last modified the resource.</value>
		[DataMember(Name = "modifiedByApp", EmitDefaultValue = false)]
		public string ModifiedByApp { get; private set; }



		/// <summary>
		/// The application that created the resource.
		/// </summary>
		/// <value>The application that created the resource.</value>
		[DataMember(Name = "createdByApp", EmitDefaultValue = false)]
		public string CreatedByApp { get; private set; }



		/// <summary>
		/// The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead
		/// </summary>
		/// <value>The list of interfaces for the edge. (Deprecated) Replaced by configuring trunks/ip info on the logical interface instead</value>
		[DataMember(Name = "interfaces", EmitDefaultValue = false)]
		public List<EdgeInterface> Interfaces { get; set; }



		/// <summary>
		/// Gets or Sets Make
		/// </summary>
		[DataMember(Name = "make", EmitDefaultValue = false)]
		public string Make { get; set; }



		/// <summary>
		/// Gets or Sets Model
		/// </summary>
		[DataMember(Name = "model", EmitDefaultValue = false)]
		public string Model { get; set; }



		/// <summary>
		/// Gets or Sets ApiVersion
		/// </summary>
		[DataMember(Name = "apiVersion", EmitDefaultValue = false)]
		public string ApiVersion { get; set; }



		/// <summary>
		/// Gets or Sets SoftwareVersion
		/// </summary>
		[DataMember(Name = "softwareVersion", EmitDefaultValue = false)]
		public string SoftwareVersion { get; set; }



		/// <summary>
		/// Gets or Sets SoftwareVersionTimestamp
		/// </summary>
		[DataMember(Name = "softwareVersionTimestamp", EmitDefaultValue = false)]
		public string SoftwareVersionTimestamp { get; set; }



		/// <summary>
		/// Gets or Sets SoftwareVersionPlatform
		/// </summary>
		[DataMember(Name = "softwareVersionPlatform", EmitDefaultValue = false)]
		public string SoftwareVersionPlatform { get; set; }



		/// <summary>
		/// Gets or Sets SoftwareVersionConfiguration
		/// </summary>
		[DataMember(Name = "softwareVersionConfiguration", EmitDefaultValue = false)]
		public string SoftwareVersionConfiguration { get; set; }



		/// <summary>
		/// Gets or Sets FullSoftwareVersion
		/// </summary>
		[DataMember(Name = "fullSoftwareVersion", EmitDefaultValue = false)]
		public string FullSoftwareVersion { get; set; }



		/// <summary>
		/// The pairing Id for a hardware Edge in the format: 00000-00000-00000-00000-00000. This field is only required when creating an Edge with a deployment type of HARDWARE.
		/// </summary>
		/// <value>The pairing Id for a hardware Edge in the format: 00000-00000-00000-00000-00000. This field is only required when creating an Edge with a deployment type of HARDWARE.</value>
		[DataMember(Name = "pairingId", EmitDefaultValue = false)]
		public string PairingId { get; set; }



		/// <summary>
		/// Gets or Sets Fingerprint
		/// </summary>
		[DataMember(Name = "fingerprint", EmitDefaultValue = false)]
		public string Fingerprint { get; set; }



		/// <summary>
		/// Gets or Sets FingerprintHint
		/// </summary>
		[DataMember(Name = "fingerprintHint", EmitDefaultValue = false)]
		public string FingerprintHint { get; set; }



		/// <summary>
		/// Gets or Sets CurrentVersion
		/// </summary>
		[DataMember(Name = "currentVersion", EmitDefaultValue = false)]
		public string CurrentVersion { get; set; }



		/// <summary>
		/// Gets or Sets StagedVersion
		/// </summary>
		[DataMember(Name = "stagedVersion", EmitDefaultValue = false)]
		public string StagedVersion { get; set; }



		/// <summary>
		/// Gets or Sets Patch
		/// </summary>
		[DataMember(Name = "patch", EmitDefaultValue = false)]
		public string Patch { get; set; }





		/// <summary>
		/// Gets or Sets EdgeGroup
		/// </summary>
		[DataMember(Name = "edgeGroup", EmitDefaultValue = false)]
		public EdgeGroup EdgeGroup { get; set; }



		/// <summary>
		/// The Site to which the Edge is assigned.
		/// </summary>
		/// <value>The Site to which the Edge is assigned.</value>
		[DataMember(Name = "site", EmitDefaultValue = false)]
		public Site Site { get; set; }



		/// <summary>
		/// Details about an in-progress or recently in-progress Edge software upgrade. This node appears only if a software upgrade was recently initiated for this Edge.
		/// </summary>
		/// <value>Details about an in-progress or recently in-progress Edge software upgrade. This node appears only if a software upgrade was recently initiated for this Edge.</value>
		[DataMember(Name = "softwareStatus", EmitDefaultValue = false)]
		public DomainEdgeSoftwareUpdateDto SoftwareStatus { get; set; }





		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "serialNumber", EmitDefaultValue = false)]
		public string SerialNumber { get; set; }



		/// <summary>
		/// Gets or Sets PhysicalEdge
		/// </summary>
		[DataMember(Name = "physicalEdge", EmitDefaultValue = false)]
		public bool? PhysicalEdge { get; set; }



		/// <summary>
		/// Gets or Sets Managed
		/// </summary>
		[DataMember(Name = "managed", EmitDefaultValue = false)]
		public bool? Managed { get; set; }









		/// <summary>
		/// The remaining number of conversations the Edge has to drain before it can be safely rebooted or updated. When an Edge is not draining conversations, this will be NULL or 0.
		/// </summary>
		/// <value>The remaining number of conversations the Edge has to drain before it can be safely rebooted or updated. When an Edge is not draining conversations, this will be NULL or 0.</value>
		[DataMember(Name = "conversationCount", EmitDefaultValue = false)]
		public int? ConversationCount { get; private set; }



		/// <summary>
		/// Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed.
		/// </summary>
		/// <value>Edge HTTP proxy configuration for the WAN port. The field can be a hostname, FQDN, IPv4 or IPv6 address. If port is not included, port 80 is assumed.</value>
		[DataMember(Name = "proxy", EmitDefaultValue = false)]
		public string Proxy { get; set; }



		/// <summary>
		/// True if the offline edge configuration endpoint has been called for this edge.
		/// </summary>
		/// <value>True if the offline edge configuration endpoint has been called for this edge.</value>
		[DataMember(Name = "offlineConfigCalled", EmitDefaultValue = false)]
		public bool? OfflineConfigCalled { get; private set; }



		/// <summary>
		/// The name provided by the operating system of the Edge.
		/// </summary>
		/// <value>The name provided by the operating system of the Edge.</value>
		[DataMember(Name = "osName", EmitDefaultValue = false)]
		public string OsName { get; private set; }



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
			sb.Append("class Edge {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
			sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
			sb.Append("  Interfaces: ").Append(Interfaces).Append("\n");
			sb.Append("  Make: ").Append(Make).Append("\n");
			sb.Append("  Model: ").Append(Model).Append("\n");
			sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
			sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
			sb.Append("  SoftwareVersionTimestamp: ").Append(SoftwareVersionTimestamp).Append("\n");
			sb.Append("  SoftwareVersionPlatform: ").Append(SoftwareVersionPlatform).Append("\n");
			sb.Append("  SoftwareVersionConfiguration: ").Append(SoftwareVersionConfiguration).Append("\n");
			sb.Append("  FullSoftwareVersion: ").Append(FullSoftwareVersion).Append("\n");
			sb.Append("  PairingId: ").Append(PairingId).Append("\n");
			sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
			sb.Append("  FingerprintHint: ").Append(FingerprintHint).Append("\n");
			sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
			sb.Append("  StagedVersion: ").Append(StagedVersion).Append("\n");
			sb.Append("  Patch: ").Append(Patch).Append("\n");
			sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
			sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
			sb.Append("  Site: ").Append(Site).Append("\n");
			sb.Append("  SoftwareStatus: ").Append(SoftwareStatus).Append("\n");
			sb.Append("  OnlineStatus: ").Append(OnlineStatus).Append("\n");
			sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
			sb.Append("  PhysicalEdge: ").Append(PhysicalEdge).Append("\n");
			sb.Append("  Managed: ").Append(Managed).Append("\n");
			sb.Append("  EdgeDeploymentType: ").Append(EdgeDeploymentType).Append("\n");
			sb.Append("  CertType: ").Append(CertType).Append("\n");
			sb.Append("  CallDrainingState: ").Append(CallDrainingState).Append("\n");
			sb.Append("  ConversationCount: ").Append(ConversationCount).Append("\n");
			sb.Append("  Proxy: ").Append(Proxy).Append("\n");
			sb.Append("  OfflineConfigCalled: ").Append(OfflineConfigCalled).Append("\n");
			sb.Append("  OsName: ").Append(OsName).Append("\n");
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
			return this.Equals(obj as Edge);
		}

		/// <summary>
		/// Returns true if Edge instances are equal
		/// </summary>
		/// <param name="other">Instance of Edge to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Edge other)
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
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.ModifiedByApp == other.ModifiedByApp ||
					this.ModifiedByApp != null &&
					this.ModifiedByApp.Equals(other.ModifiedByApp)
				) &&
				(
					this.CreatedByApp == other.CreatedByApp ||
					this.CreatedByApp != null &&
					this.CreatedByApp.Equals(other.CreatedByApp)
				) &&
				(
					this.Interfaces == other.Interfaces ||
					this.Interfaces != null &&
					this.Interfaces.SequenceEqual(other.Interfaces)
				) &&
				(
					this.Make == other.Make ||
					this.Make != null &&
					this.Make.Equals(other.Make)
				) &&
				(
					this.Model == other.Model ||
					this.Model != null &&
					this.Model.Equals(other.Model)
				) &&
				(
					this.ApiVersion == other.ApiVersion ||
					this.ApiVersion != null &&
					this.ApiVersion.Equals(other.ApiVersion)
				) &&
				(
					this.SoftwareVersion == other.SoftwareVersion ||
					this.SoftwareVersion != null &&
					this.SoftwareVersion.Equals(other.SoftwareVersion)
				) &&
				(
					this.SoftwareVersionTimestamp == other.SoftwareVersionTimestamp ||
					this.SoftwareVersionTimestamp != null &&
					this.SoftwareVersionTimestamp.Equals(other.SoftwareVersionTimestamp)
				) &&
				(
					this.SoftwareVersionPlatform == other.SoftwareVersionPlatform ||
					this.SoftwareVersionPlatform != null &&
					this.SoftwareVersionPlatform.Equals(other.SoftwareVersionPlatform)
				) &&
				(
					this.SoftwareVersionConfiguration == other.SoftwareVersionConfiguration ||
					this.SoftwareVersionConfiguration != null &&
					this.SoftwareVersionConfiguration.Equals(other.SoftwareVersionConfiguration)
				) &&
				(
					this.FullSoftwareVersion == other.FullSoftwareVersion ||
					this.FullSoftwareVersion != null &&
					this.FullSoftwareVersion.Equals(other.FullSoftwareVersion)
				) &&
				(
					this.PairingId == other.PairingId ||
					this.PairingId != null &&
					this.PairingId.Equals(other.PairingId)
				) &&
				(
					this.Fingerprint == other.Fingerprint ||
					this.Fingerprint != null &&
					this.Fingerprint.Equals(other.Fingerprint)
				) &&
				(
					this.FingerprintHint == other.FingerprintHint ||
					this.FingerprintHint != null &&
					this.FingerprintHint.Equals(other.FingerprintHint)
				) &&
				(
					this.CurrentVersion == other.CurrentVersion ||
					this.CurrentVersion != null &&
					this.CurrentVersion.Equals(other.CurrentVersion)
				) &&
				(
					this.StagedVersion == other.StagedVersion ||
					this.StagedVersion != null &&
					this.StagedVersion.Equals(other.StagedVersion)
				) &&
				(
					this.Patch == other.Patch ||
					this.Patch != null &&
					this.Patch.Equals(other.Patch)
				) &&
				(
					this.StatusCode == other.StatusCode ||
					this.StatusCode != null &&
					this.StatusCode.Equals(other.StatusCode)
				) &&
				(
					this.EdgeGroup == other.EdgeGroup ||
					this.EdgeGroup != null &&
					this.EdgeGroup.Equals(other.EdgeGroup)
				) &&
				(
					this.Site == other.Site ||
					this.Site != null &&
					this.Site.Equals(other.Site)
				) &&
				(
					this.SoftwareStatus == other.SoftwareStatus ||
					this.SoftwareStatus != null &&
					this.SoftwareStatus.Equals(other.SoftwareStatus)
				) &&
				(
					this.OnlineStatus == other.OnlineStatus ||
					this.OnlineStatus != null &&
					this.OnlineStatus.Equals(other.OnlineStatus)
				) &&
				(
					this.SerialNumber == other.SerialNumber ||
					this.SerialNumber != null &&
					this.SerialNumber.Equals(other.SerialNumber)
				) &&
				(
					this.PhysicalEdge == other.PhysicalEdge ||
					this.PhysicalEdge != null &&
					this.PhysicalEdge.Equals(other.PhysicalEdge)
				) &&
				(
					this.Managed == other.Managed ||
					this.Managed != null &&
					this.Managed.Equals(other.Managed)
				) &&
				(
					this.EdgeDeploymentType == other.EdgeDeploymentType ||
					this.EdgeDeploymentType != null &&
					this.EdgeDeploymentType.Equals(other.EdgeDeploymentType)
				) &&
				(
					this.CertType == other.CertType ||
					this.CertType != null &&
					this.CertType.Equals(other.CertType)
				) &&
				(
					this.CallDrainingState == other.CallDrainingState ||
					this.CallDrainingState != null &&
					this.CallDrainingState.Equals(other.CallDrainingState)
				) &&
				(
					this.ConversationCount == other.ConversationCount ||
					this.ConversationCount != null &&
					this.ConversationCount.Equals(other.ConversationCount)
				) &&
				(
					this.Proxy == other.Proxy ||
					this.Proxy != null &&
					this.Proxy.Equals(other.Proxy)
				) &&
				(
					this.OfflineConfigCalled == other.OfflineConfigCalled ||
					this.OfflineConfigCalled != null &&
					this.OfflineConfigCalled.Equals(other.OfflineConfigCalled)
				) &&
				(
					this.OsName == other.OsName ||
					this.OsName != null &&
					this.OsName.Equals(other.OsName)
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

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.ModifiedByApp != null)
					hash = hash * 59 + this.ModifiedByApp.GetHashCode();

				if (this.CreatedByApp != null)
					hash = hash * 59 + this.CreatedByApp.GetHashCode();

				if (this.Interfaces != null)
					hash = hash * 59 + this.Interfaces.GetHashCode();

				if (this.Make != null)
					hash = hash * 59 + this.Make.GetHashCode();

				if (this.Model != null)
					hash = hash * 59 + this.Model.GetHashCode();

				if (this.ApiVersion != null)
					hash = hash * 59 + this.ApiVersion.GetHashCode();

				if (this.SoftwareVersion != null)
					hash = hash * 59 + this.SoftwareVersion.GetHashCode();

				if (this.SoftwareVersionTimestamp != null)
					hash = hash * 59 + this.SoftwareVersionTimestamp.GetHashCode();

				if (this.SoftwareVersionPlatform != null)
					hash = hash * 59 + this.SoftwareVersionPlatform.GetHashCode();

				if (this.SoftwareVersionConfiguration != null)
					hash = hash * 59 + this.SoftwareVersionConfiguration.GetHashCode();

				if (this.FullSoftwareVersion != null)
					hash = hash * 59 + this.FullSoftwareVersion.GetHashCode();

				if (this.PairingId != null)
					hash = hash * 59 + this.PairingId.GetHashCode();

				if (this.Fingerprint != null)
					hash = hash * 59 + this.Fingerprint.GetHashCode();

				if (this.FingerprintHint != null)
					hash = hash * 59 + this.FingerprintHint.GetHashCode();

				if (this.CurrentVersion != null)
					hash = hash * 59 + this.CurrentVersion.GetHashCode();

				if (this.StagedVersion != null)
					hash = hash * 59 + this.StagedVersion.GetHashCode();

				if (this.Patch != null)
					hash = hash * 59 + this.Patch.GetHashCode();

				if (this.StatusCode != null)
					hash = hash * 59 + this.StatusCode.GetHashCode();

				if (this.EdgeGroup != null)
					hash = hash * 59 + this.EdgeGroup.GetHashCode();

				if (this.Site != null)
					hash = hash * 59 + this.Site.GetHashCode();

				if (this.SoftwareStatus != null)
					hash = hash * 59 + this.SoftwareStatus.GetHashCode();

				if (this.OnlineStatus != null)
					hash = hash * 59 + this.OnlineStatus.GetHashCode();

				if (this.SerialNumber != null)
					hash = hash * 59 + this.SerialNumber.GetHashCode();

				if (this.PhysicalEdge != null)
					hash = hash * 59 + this.PhysicalEdge.GetHashCode();

				if (this.Managed != null)
					hash = hash * 59 + this.Managed.GetHashCode();

				if (this.EdgeDeploymentType != null)
					hash = hash * 59 + this.EdgeDeploymentType.GetHashCode();

				if (this.CertType != null)
					hash = hash * 59 + this.CertType.GetHashCode();

				if (this.CallDrainingState != null)
					hash = hash * 59 + this.CallDrainingState.GetHashCode();

				if (this.ConversationCount != null)
					hash = hash * 59 + this.ConversationCount.GetHashCode();

				if (this.Proxy != null)
					hash = hash * 59 + this.Proxy.GetHashCode();

				if (this.OfflineConfigCalled != null)
					hash = hash * 59 + this.OfflineConfigCalled.GetHashCode();

				if (this.OsName != null)
					hash = hash * 59 + this.OsName.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
