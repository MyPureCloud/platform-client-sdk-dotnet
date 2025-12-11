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
    /// ChecklistItem
    /// </summary>
    [DataContract]
    public partial class ChecklistItem :  IEquatable<ChecklistItem>
    {
        /// <summary>
        /// Checklist state as evaluated by the model.
        /// </summary>
        /// <value>Checklist state as evaluated by the model.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateFromModelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ticked for "Ticked"
            /// </summary>
            [EnumMember(Value = "Ticked")]
            Ticked,
            
            /// <summary>
            /// Enum Unticked for "Unticked"
            /// </summary>
            [EnumMember(Value = "Unticked")]
            Unticked
        }
        /// <summary>
        /// Checklist state as evaluated by the agent.
        /// </summary>
        /// <value>Checklist state as evaluated by the agent.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateFromAgentEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ticked for "Ticked"
            /// </summary>
            [EnumMember(Value = "Ticked")]
            Ticked,
            
            /// <summary>
            /// Enum Unticked for "Unticked"
            /// </summary>
            [EnumMember(Value = "Unticked")]
            Unticked
        }
        /// <summary>
        /// Checklist state as evaluated by the model.
        /// </summary>
        /// <value>Checklist state as evaluated by the model.</value>
        [DataMember(Name="stateFromModel", EmitDefaultValue=false)]
        public StateFromModelEnum? StateFromModel { get; set; }
        /// <summary>
        /// Checklist state as evaluated by the agent.
        /// </summary>
        /// <value>Checklist state as evaluated by the agent.</value>
        [DataMember(Name="stateFromAgent", EmitDefaultValue=false)]
        public StateFromAgentEnum? StateFromAgent { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChecklistItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistItem" /> class.
        /// </summary>
        /// <param name="Id">ID of the checklist item. (required).</param>
        /// <param name="Name">Name of the checklist item. (required).</param>
        /// <param name="Description">Description of the checklist item..</param>
        /// <param name="AutomatedCheckEnabled">Flag to indicate whether automated check is enabled for this checklist item..</param>
        /// <param name="Important">Flag to indicate whether this checklist item is marked as important..</param>
        /// <param name="StateFromModel">Checklist state as evaluated by the model..</param>
        /// <param name="StateFromAgent">Checklist state as evaluated by the agent..</param>
        /// <param name="DateLastModifiedByModel">Date when the checklist item was last modified by the model. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateLastModifiedByAgent">Date when the checklist item was last modified by the agent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="LastModifiedInAcw">Flag to indicate whether this checklist item was modified in ACW..</param>
        public ChecklistItem(string Id = null, string Name = null, string Description = null, bool? AutomatedCheckEnabled = null, bool? Important = null, StateFromModelEnum? StateFromModel = null, StateFromAgentEnum? StateFromAgent = null, DateTime? DateLastModifiedByModel = null, DateTime? DateLastModifiedByAgent = null, bool? LastModifiedInAcw = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.AutomatedCheckEnabled = AutomatedCheckEnabled;
            this.Important = Important;
            this.StateFromModel = StateFromModel;
            this.StateFromAgent = StateFromAgent;
            this.DateLastModifiedByModel = DateLastModifiedByModel;
            this.DateLastModifiedByAgent = DateLastModifiedByAgent;
            this.LastModifiedInAcw = LastModifiedInAcw;
            
        }
        


        /// <summary>
        /// ID of the checklist item.
        /// </summary>
        /// <value>ID of the checklist item.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Name of the checklist item.
        /// </summary>
        /// <value>Name of the checklist item.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Description of the checklist item.
        /// </summary>
        /// <value>Description of the checklist item.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Flag to indicate whether automated check is enabled for this checklist item.
        /// </summary>
        /// <value>Flag to indicate whether automated check is enabled for this checklist item.</value>
        [DataMember(Name="automatedCheckEnabled", EmitDefaultValue=false)]
        public bool? AutomatedCheckEnabled { get; set; }



        /// <summary>
        /// Flag to indicate whether this checklist item is marked as important.
        /// </summary>
        /// <value>Flag to indicate whether this checklist item is marked as important.</value>
        [DataMember(Name="important", EmitDefaultValue=false)]
        public bool? Important { get; set; }







        /// <summary>
        /// Date when the checklist item was last modified by the model. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the checklist item was last modified by the model. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateLastModifiedByModel", EmitDefaultValue=false)]
        public DateTime? DateLastModifiedByModel { get; set; }



        /// <summary>
        /// Date when the checklist item was last modified by the agent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the checklist item was last modified by the agent. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateLastModifiedByAgent", EmitDefaultValue=false)]
        public DateTime? DateLastModifiedByAgent { get; set; }



        /// <summary>
        /// Flag to indicate whether this checklist item was modified in ACW.
        /// </summary>
        /// <value>Flag to indicate whether this checklist item was modified in ACW.</value>
        [DataMember(Name="lastModifiedInAcw", EmitDefaultValue=false)]
        public bool? LastModifiedInAcw { get; set; }



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
            sb.Append("class ChecklistItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AutomatedCheckEnabled: ").Append(AutomatedCheckEnabled).Append("\n");
            sb.Append("  Important: ").Append(Important).Append("\n");
            sb.Append("  StateFromModel: ").Append(StateFromModel).Append("\n");
            sb.Append("  StateFromAgent: ").Append(StateFromAgent).Append("\n");
            sb.Append("  DateLastModifiedByModel: ").Append(DateLastModifiedByModel).Append("\n");
            sb.Append("  DateLastModifiedByAgent: ").Append(DateLastModifiedByAgent).Append("\n");
            sb.Append("  LastModifiedInAcw: ").Append(LastModifiedInAcw).Append("\n");
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
            return this.Equals(obj as ChecklistItem);
        }

        /// <summary>
        /// Returns true if ChecklistItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ChecklistItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChecklistItem other)
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
                    this.AutomatedCheckEnabled == other.AutomatedCheckEnabled ||
                    this.AutomatedCheckEnabled != null &&
                    this.AutomatedCheckEnabled.Equals(other.AutomatedCheckEnabled)
                ) &&
                (
                    this.Important == other.Important ||
                    this.Important != null &&
                    this.Important.Equals(other.Important)
                ) &&
                (
                    this.StateFromModel == other.StateFromModel ||
                    this.StateFromModel != null &&
                    this.StateFromModel.Equals(other.StateFromModel)
                ) &&
                (
                    this.StateFromAgent == other.StateFromAgent ||
                    this.StateFromAgent != null &&
                    this.StateFromAgent.Equals(other.StateFromAgent)
                ) &&
                (
                    this.DateLastModifiedByModel == other.DateLastModifiedByModel ||
                    this.DateLastModifiedByModel != null &&
                    this.DateLastModifiedByModel.Equals(other.DateLastModifiedByModel)
                ) &&
                (
                    this.DateLastModifiedByAgent == other.DateLastModifiedByAgent ||
                    this.DateLastModifiedByAgent != null &&
                    this.DateLastModifiedByAgent.Equals(other.DateLastModifiedByAgent)
                ) &&
                (
                    this.LastModifiedInAcw == other.LastModifiedInAcw ||
                    this.LastModifiedInAcw != null &&
                    this.LastModifiedInAcw.Equals(other.LastModifiedInAcw)
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

                if (this.AutomatedCheckEnabled != null)
                    hash = hash * 59 + this.AutomatedCheckEnabled.GetHashCode();

                if (this.Important != null)
                    hash = hash * 59 + this.Important.GetHashCode();

                if (this.StateFromModel != null)
                    hash = hash * 59 + this.StateFromModel.GetHashCode();

                if (this.StateFromAgent != null)
                    hash = hash * 59 + this.StateFromAgent.GetHashCode();

                if (this.DateLastModifiedByModel != null)
                    hash = hash * 59 + this.DateLastModifiedByModel.GetHashCode();

                if (this.DateLastModifiedByAgent != null)
                    hash = hash * 59 + this.DateLastModifiedByAgent.GetHashCode();

                if (this.LastModifiedInAcw != null)
                    hash = hash * 59 + this.LastModifiedInAcw.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
