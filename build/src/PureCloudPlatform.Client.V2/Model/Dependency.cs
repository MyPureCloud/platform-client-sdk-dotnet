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
    /// Dependency
    /// </summary>
    [DataContract]
    public partial class Dependency :  IEquatable<Dependency>
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
            /// Enum Acdlanguage for "ACDLANGUAGE"
            /// </summary>
            [EnumMember(Value = "ACDLANGUAGE")]
            Acdlanguage,
            
            /// <summary>
            /// Enum Acdskill for "ACDSKILL"
            /// </summary>
            [EnumMember(Value = "ACDSKILL")]
            Acdskill,
            
            /// <summary>
            /// Enum Acdwrapupcode for "ACDWRAPUPCODE"
            /// </summary>
            [EnumMember(Value = "ACDWRAPUPCODE")]
            Acdwrapupcode,
            
            /// <summary>
            /// Enum Botconnectorbot for "BOTCONNECTORBOT"
            /// </summary>
            [EnumMember(Value = "BOTCONNECTORBOT")]
            Botconnectorbot,
            
            /// <summary>
            /// Enum Botconnectorintegration for "BOTCONNECTORINTEGRATION"
            /// </summary>
            [EnumMember(Value = "BOTCONNECTORINTEGRATION")]
            Botconnectorintegration,
            
            /// <summary>
            /// Enum Botflow for "BOTFLOW"
            /// </summary>
            [EnumMember(Value = "BOTFLOW")]
            Botflow,
            
            /// <summary>
            /// Enum Bridgeaction for "BRIDGEACTION"
            /// </summary>
            [EnumMember(Value = "BRIDGEACTION")]
            Bridgeaction,
            
            /// <summary>
            /// Enum Commonmoduleflow for "COMMONMODULEFLOW"
            /// </summary>
            [EnumMember(Value = "COMMONMODULEFLOW")]
            Commonmoduleflow,
            
            /// <summary>
            /// Enum Composerscript for "COMPOSERSCRIPT"
            /// </summary>
            [EnumMember(Value = "COMPOSERSCRIPT")]
            Composerscript,
            
            /// <summary>
            /// Enum Contactlist for "CONTACTLIST"
            /// </summary>
            [EnumMember(Value = "CONTACTLIST")]
            Contactlist,
            
            /// <summary>
            /// Enum Dataaction for "DATAACTION"
            /// </summary>
            [EnumMember(Value = "DATAACTION")]
            Dataaction,
            
            /// <summary>
            /// Enum Datatable for "DATATABLE"
            /// </summary>
            [EnumMember(Value = "DATATABLE")]
            Datatable,
            
            /// <summary>
            /// Enum Dialogenginebot for "DIALOGENGINEBOT"
            /// </summary>
            [EnumMember(Value = "DIALOGENGINEBOT")]
            Dialogenginebot,
            
            /// <summary>
            /// Enum Dialogenginebotversion for "DIALOGENGINEBOTVERSION"
            /// </summary>
            [EnumMember(Value = "DIALOGENGINEBOTVERSION")]
            Dialogenginebotversion,
            
            /// <summary>
            /// Enum Dialogflowagent for "DIALOGFLOWAGENT"
            /// </summary>
            [EnumMember(Value = "DIALOGFLOWAGENT")]
            Dialogflowagent,
            
            /// <summary>
            /// Enum Emailroute for "EMAILROUTE"
            /// </summary>
            [EnumMember(Value = "EMAILROUTE")]
            Emailroute,
            
            /// <summary>
            /// Enum Emergencygroup for "EMERGENCYGROUP"
            /// </summary>
            [EnumMember(Value = "EMERGENCYGROUP")]
            Emergencygroup,
            
            /// <summary>
            /// Enum Flowaction for "FLOWACTION"
            /// </summary>
            [EnumMember(Value = "FLOWACTION")]
            Flowaction,
            
            /// <summary>
            /// Enum Flowdatatype for "FLOWDATATYPE"
            /// </summary>
            [EnumMember(Value = "FLOWDATATYPE")]
            Flowdatatype,
            
            /// <summary>
            /// Enum Flowmilestone for "FLOWMILESTONE"
            /// </summary>
            [EnumMember(Value = "FLOWMILESTONE")]
            Flowmilestone,
            
            /// <summary>
            /// Enum Flowoutcome for "FLOWOUTCOME"
            /// </summary>
            [EnumMember(Value = "FLOWOUTCOME")]
            Flowoutcome,
            
            /// <summary>
            /// Enum Group for "GROUP"
            /// </summary>
            [EnumMember(Value = "GROUP")]
            Group,
            
            /// <summary>
            /// Enum Inboundcallflow for "INBOUNDCALLFLOW"
            /// </summary>
            [EnumMember(Value = "INBOUNDCALLFLOW")]
            Inboundcallflow,
            
            /// <summary>
            /// Enum Inboundchatflow for "INBOUNDCHATFLOW"
            /// </summary>
            [EnumMember(Value = "INBOUNDCHATFLOW")]
            Inboundchatflow,
            
            /// <summary>
            /// Enum Inboundemailflow for "INBOUNDEMAILFLOW"
            /// </summary>
            [EnumMember(Value = "INBOUNDEMAILFLOW")]
            Inboundemailflow,
            
            /// <summary>
            /// Enum Inboundshortmessageflow for "INBOUNDSHORTMESSAGEFLOW"
            /// </summary>
            [EnumMember(Value = "INBOUNDSHORTMESSAGEFLOW")]
            Inboundshortmessageflow,
            
            /// <summary>
            /// Enum Inqueuecallflow for "INQUEUECALLFLOW"
            /// </summary>
            [EnumMember(Value = "INQUEUECALLFLOW")]
            Inqueuecallflow,
            
            /// <summary>
            /// Enum Inqueueemailflow for "INQUEUEEMAILFLOW"
            /// </summary>
            [EnumMember(Value = "INQUEUEEMAILFLOW")]
            Inqueueemailflow,
            
            /// <summary>
            /// Enum Inqueueshortmessageflow for "INQUEUESHORTMESSAGEFLOW"
            /// </summary>
            [EnumMember(Value = "INQUEUESHORTMESSAGEFLOW")]
            Inqueueshortmessageflow,
            
            /// <summary>
            /// Enum Ivrconfiguration for "IVRCONFIGURATION"
            /// </summary>
            [EnumMember(Value = "IVRCONFIGURATION")]
            Ivrconfiguration,
            
            /// <summary>
            /// Enum Knowledgebase for "KNOWLEDGEBASE"
            /// </summary>
            [EnumMember(Value = "KNOWLEDGEBASE")]
            Knowledgebase,
            
            /// <summary>
            /// Enum Language for "LANGUAGE"
            /// </summary>
            [EnumMember(Value = "LANGUAGE")]
            Language,
            
            /// <summary>
            /// Enum Lexbot for "LEXBOT"
            /// </summary>
            [EnumMember(Value = "LEXBOT")]
            Lexbot,
            
            /// <summary>
            /// Enum Lexbotalias for "LEXBOTALIAS"
            /// </summary>
            [EnumMember(Value = "LEXBOTALIAS")]
            Lexbotalias,
            
            /// <summary>
            /// Enum Lexv2bot for "LEXV2BOT"
            /// </summary>
            [EnumMember(Value = "LEXV2BOT")]
            Lexv2bot,
            
            /// <summary>
            /// Enum Lexv2botalias for "LEXV2BOTALIAS"
            /// </summary>
            [EnumMember(Value = "LEXV2BOTALIAS")]
            Lexv2botalias,
            
            /// <summary>
            /// Enum Nludomain for "NLUDOMAIN"
            /// </summary>
            [EnumMember(Value = "NLUDOMAIN")]
            Nludomain,
            
            /// <summary>
            /// Enum Outboundcallflow for "OUTBOUNDCALLFLOW"
            /// </summary>
            [EnumMember(Value = "OUTBOUNDCALLFLOW")]
            Outboundcallflow,
            
            /// <summary>
            /// Enum Queue for "QUEUE"
            /// </summary>
            [EnumMember(Value = "QUEUE")]
            Queue,
            
            /// <summary>
            /// Enum Recordingpolicy for "RECORDINGPOLICY"
            /// </summary>
            [EnumMember(Value = "RECORDINGPOLICY")]
            Recordingpolicy,
            
            /// <summary>
            /// Enum Response for "RESPONSE"
            /// </summary>
            [EnumMember(Value = "RESPONSE")]
            Response,
            
            /// <summary>
            /// Enum Schedule for "SCHEDULE"
            /// </summary>
            [EnumMember(Value = "SCHEDULE")]
            Schedule,
            
            /// <summary>
            /// Enum Schedulegroup for "SCHEDULEGROUP"
            /// </summary>
            [EnumMember(Value = "SCHEDULEGROUP")]
            Schedulegroup,
            
            /// <summary>
            /// Enum Secureaction for "SECUREACTION"
            /// </summary>
            [EnumMember(Value = "SECUREACTION")]
            Secureaction,
            
            /// <summary>
            /// Enum Securecallflow for "SECURECALLFLOW"
            /// </summary>
            [EnumMember(Value = "SECURECALLFLOW")]
            Securecallflow,
            
            /// <summary>
            /// Enum Surveyinviteflow for "SURVEYINVITEFLOW"
            /// </summary>
            [EnumMember(Value = "SURVEYINVITEFLOW")]
            Surveyinviteflow,
            
            /// <summary>
            /// Enum Systemprompt for "SYSTEMPROMPT"
            /// </summary>
            [EnumMember(Value = "SYSTEMPROMPT")]
            Systemprompt,
            
            /// <summary>
            /// Enum Ttsengine for "TTSENGINE"
            /// </summary>
            [EnumMember(Value = "TTSENGINE")]
            Ttsengine,
            
            /// <summary>
            /// Enum Ttsvoice for "TTSVOICE"
            /// </summary>
            [EnumMember(Value = "TTSVOICE")]
            Ttsvoice,
            
            /// <summary>
            /// Enum User for "USER"
            /// </summary>
            [EnumMember(Value = "USER")]
            User,
            
            /// <summary>
            /// Enum Userprompt for "USERPROMPT"
            /// </summary>
            [EnumMember(Value = "USERPROMPT")]
            Userprompt,
            
            /// <summary>
            /// Enum Widget for "WIDGET"
            /// </summary>
            [EnumMember(Value = "WIDGET")]
            Widget,
            
            /// <summary>
            /// Enum Workflow for "WORKFLOW"
            /// </summary>
            [EnumMember(Value = "WORKFLOW")]
            Workflow,
            
            /// <summary>
            /// Enum Workitemflow for "WORKITEMFLOW"
            /// </summary>
            [EnumMember(Value = "WORKITEMFLOW")]
            Workitemflow
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Dependency" /> class.
        /// </summary>
        /// <param name="Id">The dependency identifier.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Deleted">Deleted.</param>
        /// <param name="Updated">Updated.</param>
        /// <param name="StateUnknown">StateUnknown.</param>
        public Dependency(string Id = null, string Name = null, string Version = null, TypeEnum? Type = null, bool? Deleted = null, bool? Updated = null, bool? StateUnknown = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Version = Version;
            this.Type = Type;
            this.Deleted = Deleted;
            this.Updated = Updated;
            this.StateUnknown = StateUnknown;
            
        }
        
        
        
        /// <summary>
        /// The dependency identifier
        /// </summary>
        /// <value>The dependency identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool? Deleted { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public bool? Updated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets StateUnknown
        /// </summary>
        [DataMember(Name="stateUnknown", EmitDefaultValue=false)]
        public bool? StateUnknown { get; set; }
        
        
        
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
            sb.Append("class Dependency {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  StateUnknown: ").Append(StateUnknown).Append("\n");
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
            return this.Equals(obj as Dependency);
        }

        /// <summary>
        /// Returns true if Dependency instances are equal
        /// </summary>
        /// <param name="other">Instance of Dependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dependency other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Deleted == other.Deleted ||
                    this.Deleted != null &&
                    this.Deleted.Equals(other.Deleted)
                ) &&
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) &&
                (
                    this.StateUnknown == other.StateUnknown ||
                    this.StateUnknown != null &&
                    this.StateUnknown.Equals(other.StateUnknown)
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
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Deleted != null)
                    hash = hash * 59 + this.Deleted.GetHashCode();
                
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                
                if (this.StateUnknown != null)
                    hash = hash * 59 + this.StateUnknown.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
