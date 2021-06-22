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
    /// FlowDivisionView
    /// </summary>
    [DataContract]
    public partial class FlowDivisionView :  IEquatable<FlowDivisionView>
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
            /// Enum Inqueueemail for "INQUEUEEMAIL"
            /// </summary>
            [EnumMember(Value = "INQUEUEEMAIL")]
            Inqueueemail,
            
            /// <summary>
            /// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
            /// </summary>
            [EnumMember(Value = "INQUEUESHORTMESSAGE")]
            Inqueueshortmessage,
            
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
            Workflow,
            
            /// <summary>
            /// Enum Workitem for "WORKITEM"
            /// </summary>
            [EnumMember(Value = "WORKITEM")]
            Workitem
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowDivisionView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowDivisionView() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowDivisionView" /> class.
        /// </summary>
        /// <param name="Id">The flow identifier.</param>
        /// <param name="Name">The flow name (required).</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Type">Type.</param>
        /// <param name="InputSchema">json schema describing the inputs for the flow.</param>
        /// <param name="OutputSchema">json schema describing the outputs for the flow.</param>
        /// <param name="PublishedVersion">published version information if there is a published version.</param>
        /// <param name="DebugVersion">debug version information if there is a debug version.</param>
        public FlowDivisionView(string Id = null, string Name = null, WritableDivision Division = null, TypeEnum? Type = null, JsonSchemaDocument InputSchema = null, JsonSchemaDocument OutputSchema = null, FlowVersion PublishedVersion = null, FlowVersion DebugVersion = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Division = Division;
            this.Type = Type;
            this.InputSchema = InputSchema;
            this.OutputSchema = OutputSchema;
            this.PublishedVersion = PublishedVersion;
            this.DebugVersion = DebugVersion;
            
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
        /// json schema describing the inputs for the flow
        /// </summary>
        /// <value>json schema describing the inputs for the flow</value>
        [DataMember(Name="inputSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument InputSchema { get; set; }
        
        
        
        /// <summary>
        /// json schema describing the outputs for the flow
        /// </summary>
        /// <value>json schema describing the outputs for the flow</value>
        [DataMember(Name="outputSchema", EmitDefaultValue=false)]
        public JsonSchemaDocument OutputSchema { get; set; }
        
        
        
        /// <summary>
        /// published version information if there is a published version
        /// </summary>
        /// <value>published version information if there is a published version</value>
        [DataMember(Name="publishedVersion", EmitDefaultValue=false)]
        public FlowVersion PublishedVersion { get; set; }
        
        
        
        /// <summary>
        /// debug version information if there is a debug version
        /// </summary>
        /// <value>debug version information if there is a debug version</value>
        [DataMember(Name="debugVersion", EmitDefaultValue=false)]
        public FlowVersion DebugVersion { get; set; }
        
        
        
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
            sb.Append("class FlowDivisionView {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
            sb.Append("  PublishedVersion: ").Append(PublishedVersion).Append("\n");
            sb.Append("  DebugVersion: ").Append(DebugVersion).Append("\n");
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
            return this.Equals(obj as FlowDivisionView);
        }

        /// <summary>
        /// Returns true if FlowDivisionView instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowDivisionView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowDivisionView other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    this.PublishedVersion == other.PublishedVersion ||
                    this.PublishedVersion != null &&
                    this.PublishedVersion.Equals(other.PublishedVersion)
                ) &&
                (
                    this.DebugVersion == other.DebugVersion ||
                    this.DebugVersion != null &&
                    this.DebugVersion.Equals(other.DebugVersion)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.InputSchema != null)
                    hash = hash * 59 + this.InputSchema.GetHashCode();
                
                if (this.OutputSchema != null)
                    hash = hash * 59 + this.OutputSchema.GetHashCode();
                
                if (this.PublishedVersion != null)
                    hash = hash * 59 + this.PublishedVersion.GetHashCode();
                
                if (this.DebugVersion != null)
                    hash = hash * 59 + this.DebugVersion.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
