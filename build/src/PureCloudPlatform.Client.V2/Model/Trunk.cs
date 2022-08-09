using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Trunk
    /// </summary>
    [DataContract]
    public partial class Trunk :  IEquatable<Trunk>
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
        /// The type of this trunk.
        /// </summary>
        /// <value>The type of this trunk.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TrunkTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum External for "EXTERNAL"
            /// </summary>
            [EnumMember(Value = "EXTERNAL")]
            External,
            
            /// <summary>
            /// Enum Phone for "PHONE"
            /// </summary>
            [EnumMember(Value = "PHONE")]
            Phone,
            
            /// <summary>
            /// Enum Edge for "EDGE"
            /// </summary>
            [EnumMember(Value = "EDGE")]
            Edge
        }
        /// <summary>
        /// Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.
        /// </summary>
        /// <value>Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OptionsEnabledStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enabled for "ENABLED"
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            Enabled,
            
            /// <summary>
            /// Enum Disabled for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            Disabled,
            
            /// <summary>
            /// Enum NotSupported for "NOT_SUPPORTED"
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORTED")]
            NotSupported
        }
        /// <summary>
        /// Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.
        /// </summary>
        /// <value>Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum RegistersEnabledStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enabled for "ENABLED"
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            Enabled,
            
            /// <summary>
            /// Enum Disabled for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            Disabled,
            
            /// <summary>
            /// Enum NotSupported for "NOT_SUPPORTED"
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORTED")]
            NotSupported
        }
        /// <summary>
        /// Indicates if the resource is active, inactive, or deleted.
        /// </summary>
        /// <value>Indicates if the resource is active, inactive, or deleted.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; private set; }
        /// <summary>
        /// The type of this trunk.
        /// </summary>
        /// <value>The type of this trunk.</value>
        [DataMember(Name="trunkType", EmitDefaultValue=false)]
        public TrunkTypeEnum? TrunkType { get; set; }
        /// <summary>
        /// Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.
        /// </summary>
        /// <value>Returns Enabled when the trunk base supports the availability interval and it has a value greater than 0.</value>
        [DataMember(Name="optionsEnabledStatus", EmitDefaultValue=false)]
        public OptionsEnabledStatusEnum? OptionsEnabledStatus { get; private set; }
        /// <summary>
        /// Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.
        /// </summary>
        /// <value>Returns Enabled when the trunk base supports the registration interval and it has a value greater than 0.</value>
        [DataMember(Name="registersEnabledStatus", EmitDefaultValue=false)]
        public RegistersEnabledStatusEnum? RegistersEnabledStatus { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trunk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Trunk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Trunk" /> class.
        /// </summary>
        /// <param name="Name">The name of the entity. (required).</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Description">The resource's description..</param>
        /// <param name="Version">The current version of the resource..</param>
        /// <param name="TrunkType">The type of this trunk..</param>
        /// <param name="Edge">The Edge using this trunk..</param>
        /// <param name="TrunkBase">The trunk base configuration used on this trunk..</param>
        /// <param name="TrunkMetabase">The metabase used to create this trunk..</param>
        /// <param name="EdgeGroup">The edge group associated with this trunk..</param>
        /// <param name="Enabled">True if the Edge used by this trunk is in-service.</param>
        public Trunk(string Name = null, Division Division = null, string Description = null, int? Version = null, TrunkTypeEnum? TrunkType = null, DomainEntityRef Edge = null, DomainEntityRef TrunkBase = null, DomainEntityRef TrunkMetabase = null, DomainEntityRef EdgeGroup = null, bool? Enabled = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.Version = Version;
            this.TrunkType = TrunkType;
            this.Edge = Edge;
            this.TrunkBase = TrunkBase;
            this.TrunkMetabase = TrunkMetabase;
            this.EdgeGroup = EdgeGroup;
            this.Enabled = Enabled;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public Division Division { get; set; }



        /// <summary>
        /// The resource's description.
        /// </summary>
        /// <value>The resource's description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The current version of the resource.
        /// </summary>
        /// <value>The current version of the resource.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The ID of the user that last modified the resource.
        /// </summary>
        /// <value>The ID of the user that last modified the resource.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; private set; }



        /// <summary>
        /// The ID of the user that created the resource.
        /// </summary>
        /// <value>The ID of the user that created the resource.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; private set; }





        /// <summary>
        /// The application that last modified the resource.
        /// </summary>
        /// <value>The application that last modified the resource.</value>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; private set; }



        /// <summary>
        /// The application that created the resource.
        /// </summary>
        /// <value>The application that created the resource.</value>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; private set; }





        /// <summary>
        /// The Edge using this trunk.
        /// </summary>
        /// <value>The Edge using this trunk.</value>
        [DataMember(Name="edge", EmitDefaultValue=false)]
        public DomainEntityRef Edge { get; set; }



        /// <summary>
        /// The trunk base configuration used on this trunk.
        /// </summary>
        /// <value>The trunk base configuration used on this trunk.</value>
        [DataMember(Name="trunkBase", EmitDefaultValue=false)]
        public DomainEntityRef TrunkBase { get; set; }



        /// <summary>
        /// The metabase used to create this trunk.
        /// </summary>
        /// <value>The metabase used to create this trunk.</value>
        [DataMember(Name="trunkMetabase", EmitDefaultValue=false)]
        public DomainEntityRef TrunkMetabase { get; set; }



        /// <summary>
        /// The edge group associated with this trunk.
        /// </summary>
        /// <value>The edge group associated with this trunk.</value>
        [DataMember(Name="edgeGroup", EmitDefaultValue=false)]
        public DomainEntityRef EdgeGroup { get; set; }



        /// <summary>
        /// True if this trunk is in-service.  This comes from the trunk_enabled property of the referenced trunk base.
        /// </summary>
        /// <value>True if this trunk is in-service.  This comes from the trunk_enabled property of the referenced trunk base.</value>
        [DataMember(Name="inService", EmitDefaultValue=false)]
        public bool? InService { get; private set; }



        /// <summary>
        /// True if the Edge used by this trunk is in-service
        /// </summary>
        /// <value>True if the Edge used by this trunk is in-service</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The Logical Interface on the Edge to which the trunk is assigned.
        /// </summary>
        /// <value>The Logical Interface on the Edge to which the trunk is assigned.</value>
        [DataMember(Name="logicalInterface", EmitDefaultValue=false)]
        public DomainEntityRef LogicalInterface { get; private set; }



        /// <summary>
        /// The connected status of the trunk
        /// </summary>
        /// <value>The connected status of the trunk</value>
        [DataMember(Name="connectedStatus", EmitDefaultValue=false)]
        public TrunkConnectedStatus ConnectedStatus { get; private set; }



        /// <summary>
        /// The trunk optionsStatus
        /// </summary>
        /// <value>The trunk optionsStatus</value>
        [DataMember(Name="optionsStatus", EmitDefaultValue=false)]
        public List<TrunkMetricsOptions> OptionsStatus { get; private set; }



        /// <summary>
        /// The trunk registersStatus
        /// </summary>
        /// <value>The trunk registersStatus</value>
        [DataMember(Name="registersStatus", EmitDefaultValue=false)]
        public List<TrunkMetricsRegisters> RegistersStatus { get; private set; }



        /// <summary>
        /// The trunk ipStatus
        /// </summary>
        /// <value>The trunk ipStatus</value>
        [DataMember(Name="ipStatus", EmitDefaultValue=false)]
        public TrunkMetricsNetworkTypeIp IpStatus { get; private set; }







        /// <summary>
        /// The IP Network Family of the trunk
        /// </summary>
        /// <value>The IP Network Family of the trunk</value>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public int? Family { get; private set; }



        /// <summary>
        /// The list of proxy addresses (ports if provided) for the trunk
        /// </summary>
        /// <value>The list of proxy addresses (ports if provided) for the trunk</value>
        [DataMember(Name="proxyAddressList", EmitDefaultValue=false)]
        public List<string> ProxyAddressList { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trunk {\n");

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
            sb.Append("  TrunkType: ").Append(TrunkType).Append("\n");
            sb.Append("  Edge: ").Append(Edge).Append("\n");
            sb.Append("  TrunkBase: ").Append(TrunkBase).Append("\n");
            sb.Append("  TrunkMetabase: ").Append(TrunkMetabase).Append("\n");
            sb.Append("  EdgeGroup: ").Append(EdgeGroup).Append("\n");
            sb.Append("  InService: ").Append(InService).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  LogicalInterface: ").Append(LogicalInterface).Append("\n");
            sb.Append("  ConnectedStatus: ").Append(ConnectedStatus).Append("\n");
            sb.Append("  OptionsStatus: ").Append(OptionsStatus).Append("\n");
            sb.Append("  RegistersStatus: ").Append(RegistersStatus).Append("\n");
            sb.Append("  IpStatus: ").Append(IpStatus).Append("\n");
            sb.Append("  OptionsEnabledStatus: ").Append(OptionsEnabledStatus).Append("\n");
            sb.Append("  RegistersEnabledStatus: ").Append(RegistersEnabledStatus).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  ProxyAddressList: ").Append(ProxyAddressList).Append("\n");
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
            return this.Equals(obj as Trunk);
        }

        /// <summary>
        /// Returns true if Trunk instances are equal
        /// </summary>
        /// <param name="other">Instance of Trunk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trunk other)
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
                    this.TrunkType == other.TrunkType ||
                    this.TrunkType != null &&
                    this.TrunkType.Equals(other.TrunkType)
                ) &&
                (
                    this.Edge == other.Edge ||
                    this.Edge != null &&
                    this.Edge.Equals(other.Edge)
                ) &&
                (
                    this.TrunkBase == other.TrunkBase ||
                    this.TrunkBase != null &&
                    this.TrunkBase.Equals(other.TrunkBase)
                ) &&
                (
                    this.TrunkMetabase == other.TrunkMetabase ||
                    this.TrunkMetabase != null &&
                    this.TrunkMetabase.Equals(other.TrunkMetabase)
                ) &&
                (
                    this.EdgeGroup == other.EdgeGroup ||
                    this.EdgeGroup != null &&
                    this.EdgeGroup.Equals(other.EdgeGroup)
                ) &&
                (
                    this.InService == other.InService ||
                    this.InService != null &&
                    this.InService.Equals(other.InService)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.LogicalInterface == other.LogicalInterface ||
                    this.LogicalInterface != null &&
                    this.LogicalInterface.Equals(other.LogicalInterface)
                ) &&
                (
                    this.ConnectedStatus == other.ConnectedStatus ||
                    this.ConnectedStatus != null &&
                    this.ConnectedStatus.Equals(other.ConnectedStatus)
                ) &&
                (
                    this.OptionsStatus == other.OptionsStatus ||
                    this.OptionsStatus != null &&
                    this.OptionsStatus.SequenceEqual(other.OptionsStatus)
                ) &&
                (
                    this.RegistersStatus == other.RegistersStatus ||
                    this.RegistersStatus != null &&
                    this.RegistersStatus.SequenceEqual(other.RegistersStatus)
                ) &&
                (
                    this.IpStatus == other.IpStatus ||
                    this.IpStatus != null &&
                    this.IpStatus.Equals(other.IpStatus)
                ) &&
                (
                    this.OptionsEnabledStatus == other.OptionsEnabledStatus ||
                    this.OptionsEnabledStatus != null &&
                    this.OptionsEnabledStatus.Equals(other.OptionsEnabledStatus)
                ) &&
                (
                    this.RegistersEnabledStatus == other.RegistersEnabledStatus ||
                    this.RegistersEnabledStatus != null &&
                    this.RegistersEnabledStatus.Equals(other.RegistersEnabledStatus)
                ) &&
                (
                    this.Family == other.Family ||
                    this.Family != null &&
                    this.Family.Equals(other.Family)
                ) &&
                (
                    this.ProxyAddressList == other.ProxyAddressList ||
                    this.ProxyAddressList != null &&
                    this.ProxyAddressList.SequenceEqual(other.ProxyAddressList)
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

                if (this.TrunkType != null)
                    hash = hash * 59 + this.TrunkType.GetHashCode();

                if (this.Edge != null)
                    hash = hash * 59 + this.Edge.GetHashCode();

                if (this.TrunkBase != null)
                    hash = hash * 59 + this.TrunkBase.GetHashCode();

                if (this.TrunkMetabase != null)
                    hash = hash * 59 + this.TrunkMetabase.GetHashCode();

                if (this.EdgeGroup != null)
                    hash = hash * 59 + this.EdgeGroup.GetHashCode();

                if (this.InService != null)
                    hash = hash * 59 + this.InService.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.LogicalInterface != null)
                    hash = hash * 59 + this.LogicalInterface.GetHashCode();

                if (this.ConnectedStatus != null)
                    hash = hash * 59 + this.ConnectedStatus.GetHashCode();

                if (this.OptionsStatus != null)
                    hash = hash * 59 + this.OptionsStatus.GetHashCode();

                if (this.RegistersStatus != null)
                    hash = hash * 59 + this.RegistersStatus.GetHashCode();

                if (this.IpStatus != null)
                    hash = hash * 59 + this.IpStatus.GetHashCode();

                if (this.OptionsEnabledStatus != null)
                    hash = hash * 59 + this.OptionsEnabledStatus.GetHashCode();

                if (this.RegistersEnabledStatus != null)
                    hash = hash * 59 + this.RegistersEnabledStatus.GetHashCode();

                if (this.Family != null)
                    hash = hash * 59 + this.Family.GetHashCode();

                if (this.ProxyAddressList != null)
                    hash = hash * 59 + this.ProxyAddressList.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
