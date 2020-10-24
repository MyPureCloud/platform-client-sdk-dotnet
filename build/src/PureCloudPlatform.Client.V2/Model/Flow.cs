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
    /// Flow
    /// </summary>
    [DataContract]
    public partial class Flow :  IEquatable<Flow>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Bot for "BOT"
            /// </summary>
            [EnumMember(Value = "BOT")]
            Bot,
            
            /// <summary>
            /// Enum Commonmodule for "COMMONMODULE"
            /// </summary>
            [EnumMember(Value = "COMMONMODULE")]
            Commonmodule,
            
            /// <summary>
            /// Enum Inboundcall for "INBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "INBOUNDCALL")]
            Inboundcall,
            
            /// <summary>
            /// Enum Inboundchat for "INBOUNDCHAT"
            /// </summary>
            [EnumMember(Value = "INBOUNDCHAT")]
            Inboundchat,
            
            /// <summary>
            /// Enum Inboundemail for "INBOUNDEMAIL"
            /// </summary>
            [EnumMember(Value = "INBOUNDEMAIL")]
            Inboundemail,
            
            /// <summary>
            /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
            /// </summary>
            [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
            Inboundshortmessage,
            
            /// <summary>
            /// Enum Inqueuecall for "INQUEUECALL"
            /// </summary>
            [EnumMember(Value = "INQUEUECALL")]
            Inqueuecall,
            
            /// <summary>
            /// Enum Outboundcall for "OUTBOUNDCALL"
            /// </summary>
            [EnumMember(Value = "OUTBOUNDCALL")]
            Outboundcall,
            
            /// <summary>
            /// Enum Securecall for "SECURECALL"
            /// </summary>
            [EnumMember(Value = "SECURECALL")]
            Securecall,
            
            /// <summary>
            /// Enum Speech for "SPEECH"
            /// </summary>
            [EnumMember(Value = "SPEECH")]
            Speech,
            
            /// <summary>
            /// Enum Surveyinvite for "SURVEYINVITE"
            /// </summary>
            [EnumMember(Value = "SURVEYINVITE")]
            Surveyinvite,
            
            /// <summary>
            /// Enum Workflow for "WORKFLOW"
            /// </summary>
            [EnumMember(Value = "WORKFLOW")]
            Workflow
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Flow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Flow() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Flow" /> class.
        /// </summary>
        /// <param name="Id">The flow identifier.</param>
        /// <param name="Name">The flow name (required).</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Description">Description.</param>
        /// <param name="Type">Type.</param>
        /// <param name="LockedUser">User that has the flow locked..</param>
        /// <param name="LockedClient">OAuth client that has the flow locked..</param>
        /// <param name="Active">Active.</param>
        /// <param name="System">System.</param>
        /// <param name="Deleted">Deleted.</param>
        /// <param name="PublishedVersion">PublishedVersion.</param>
        /// <param name="SavedVersion">SavedVersion.</param>
        /// <param name="InputSchema">json schema describing the inputs for the flow.</param>
        /// <param name="OutputSchema">json schema describing the outputs for the flow.</param>
        /// <param name="CheckedInVersion">CheckedInVersion.</param>
        /// <param name="DebugVersion">DebugVersion.</param>
        /// <param name="PublishedBy">PublishedBy.</param>
        /// <param name="CurrentOperation">CurrentOperation.</param>
        /// <param name="NluInfo">Information about the NLU domain version for the flow.</param>
        public Flow(string Id = null, string Name = null, WritableDivision Division = null, string Description = null, TypeEnum? Type = null, User LockedUser = null, DomainEntityRef LockedClient = null, bool? Active = null, bool? System = null, bool? Deleted = null, FlowVersion PublishedVersion = null, FlowVersion SavedVersion = null, Object InputSchema = null, Object OutputSchema = null, FlowVersion CheckedInVersion = null, FlowVersion DebugVersion = null, User PublishedBy = null, Operation CurrentOperation = null, NluInfo NluInfo = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.Type = Type;
            this.LockedUser = LockedUser;
            this.LockedClient = LockedClient;
            this.Active = Active;
            this.System = System;
            this.Deleted = Deleted;
            this.PublishedVersion = PublishedVersion;
            this.SavedVersion = SavedVersion;
            this.InputSchema = InputSchema;
            this.OutputSchema = OutputSchema;
            this.CheckedInVersion = CheckedInVersion;
            this.DebugVersion = DebugVersion;
            this.PublishedBy = PublishedBy;
            this.CurrentOperation = CurrentOperation;
            this.NluInfo = NluInfo;
            
        }
        
        
        
        /// <summary>
        /// The flow identifier
        /// </summary>
        /// <value>The flow identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The flow name
        /// </summary>
        /// <value>The flow name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableDivision Division { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        
        
        /// <summary>
        /// User that has the flow locked.
        /// </summary>
        /// <value>User that has the flow locked.</value>
        [DataMember(Name="lockedUser", EmitDefaultValue=false)]
        public User LockedUser { get; set; }
        
        
        
        /// <summary>
        /// OAuth client that has the flow locked.
        /// </summary>
        /// <value>OAuth client that has the flow locked.</value>
        [DataMember(Name="lockedClient", EmitDefaultValue=false)]
        public DomainEntityRef LockedClient { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=false)]
        public bool? System { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PublishedVersion
        /// </summary>
        [DataMember(Name="publishedVersion", EmitDefaultValue=false)]
        public FlowVersion PublishedVersion { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SavedVersion
        /// </summary>
        [DataMember(Name="savedVersion", EmitDefaultValue=false)]
        public FlowVersion SavedVersion { get; set; }
        
        
        
        /// <summary>
        /// json schema describing the inputs for the flow
        /// </summary>
        /// <value>json schema describing the inputs for the flow</value>
        [DataMember(Name="inputSchema", EmitDefaultValue=false)]
        public Object InputSchema { get; set; }
        
        
        
        /// <summary>
        /// json schema describing the outputs for the flow
        /// </summary>
        /// <value>json schema describing the outputs for the flow</value>
        [DataMember(Name="outputSchema", EmitDefaultValue=false)]
        public Object OutputSchema { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CheckedInVersion
        /// </summary>
        [DataMember(Name="checkedInVersion", EmitDefaultValue=false)]
        public FlowVersion CheckedInVersion { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DebugVersion
        /// </summary>
        [DataMember(Name="debugVersion", EmitDefaultValue=false)]
        public FlowVersion DebugVersion { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PublishedBy
        /// </summary>
        [DataMember(Name="publishedBy", EmitDefaultValue=false)]
        public User PublishedBy { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CurrentOperation
        /// </summary>
        [DataMember(Name="currentOperation", EmitDefaultValue=false)]
        public Operation CurrentOperation { get; set; }
        
        
        
        /// <summary>
        /// Information about the NLU domain version for the flow
        /// </summary>
        /// <value>Information about the NLU domain version for the flow</value>
        [DataMember(Name="nluInfo", EmitDefaultValue=false)]
        public NluInfo NluInfo { get; set; }
        
        
        
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
            sb.Append("class Flow {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LockedUser: ").Append(LockedUser).Append("\n");
            sb.Append("  LockedClient: ").Append(LockedClient).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
            sb.Append("  SavedVersion: ").Append(SavedVersion).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
            sb.Append("  CheckedInVersion: ").Append(CheckedInVersion).Append("\n");
            sb.Append("  DebugVersion: ").Append(DebugVersion).Append("\n");
            sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
            sb.Append("  CurrentOperation: ").Append(CurrentOperation).Append("\n");
            sb.Append("  NluInfo: ").Append(NluInfo).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Flow);
        }

        /// <summary>
        /// Returns true if Flow instances are equal
        /// </summary>
        /// <param name="other">Instance of Flow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Flow other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.LockedUser == other.LockedUser ||
                    this.LockedUser != null &&
                    this.LockedUser.Equals(other.LockedUser)
                ) &&
                (
                    this.LockedClient == other.LockedClient ||
                    this.LockedClient != null &&
                    this.LockedClient.Equals(other.LockedClient)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.System == other.System ||
                    this.System != null &&
                    this.System.Equals(other.System)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.PublishedVersion == other.PublishedVersion ||
                    this.PublishedVersion != null &&
                    this.PublishedVersion.Equals(other.PublishedVersion)
                ) &&
                (
                    this.SavedVersion == other.SavedVersion ||
                    this.SavedVersion != null &&
                    this.SavedVersion.Equals(other.SavedVersion)
                ) &&
                (
                    this.InputSchema == other.InputSchema ||
                    this.InputSchema != null &&
                    this.InputSchema.Equals(other.InputSchema)
                ) &&
                (
                    this.OutputSchema == other.OutputSchema ||
                    this.OutputSchema != null &&
                    this.OutputSchema.Equals(other.OutputSchema)
                ) &&
                (
                    this.CheckedInVersion == other.CheckedInVersion ||
                    this.CheckedInVersion != null &&
                    this.CheckedInVersion.Equals(other.CheckedInVersion)
                ) &&
                (
                    this.DebugVersion == other.DebugVersion ||
                    this.DebugVersion != null &&
                    this.DebugVersion.Equals(other.DebugVersion)
                ) &&
                (
                    this.PublishedBy == other.PublishedBy ||
                    this.PublishedBy != null &&
                    this.PublishedBy.Equals(other.PublishedBy)
                ) &&
                (
                    this.CurrentOperation == other.CurrentOperation ||
                    this.CurrentOperation != null &&
                    this.CurrentOperation.Equals(other.CurrentOperation)
                ) &&
                (
                    this.NluInfo == other.NluInfo ||
                    this.NluInfo != null &&
                    this.NluInfo.Equals(other.NluInfo)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.LockedUser != null)
                    hash = hash * 59 + this.LockedUser.GetHashCode();
                
                if (this.LockedClient != null)
                    hash = hash * 59 + this.LockedClient.GetHashCode();
                
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                
                if (this.System != null)
                    hash = hash * 59 + this.System.GetHashCode();
                
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                
                if (this.PublishedVersion != null)
                    hash = hash * 59 + this.PublishedVersion.GetHashCode();
                
                if (this.SavedVersion != null)
                    hash = hash * 59 + this.SavedVersion.GetHashCode();
                
                if (this.InputSchema != null)
                    hash = hash * 59 + this.InputSchema.GetHashCode();
                
                if (this.OutputSchema != null)
                    hash = hash * 59 + this.OutputSchema.GetHashCode();
                
                if (this.CheckedInVersion != null)
                    hash = hash * 59 + this.CheckedInVersion.GetHashCode();
                
                if (this.DebugVersion != null)
                    hash = hash * 59 + this.DebugVersion.GetHashCode();
                
                if (this.PublishedBy != null)
                    hash = hash * 59 + this.PublishedBy.GetHashCode();
                
                if (this.CurrentOperation != null)
                    hash = hash * 59 + this.CurrentOperation.GetHashCode();
                
                if (this.NluInfo != null)
                    hash = hash * 59 + this.NluInfo.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
