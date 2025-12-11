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
    /// AgentChecklist
    /// </summary>
    [DataContract]
    public partial class AgentChecklist :  IEquatable<AgentChecklist>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklist" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentChecklist() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklist" /> class.
        /// </summary>
        /// <param name="Name">Agent Checklist Name. (required).</param>
        /// <param name="Language">Agent Checklist Language. (required).</param>
        /// <param name="ChecklistItems">Agent Checklist Items. (required).</param>
        public AgentChecklist(string Name = null, string Language = null, List<AgentChecklistItem> ChecklistItems = null)
        {
            this.Name = Name;
            this.Language = Language;
            this.ChecklistItems = ChecklistItems;
            
        }
        


        /// <summary>
        /// Agent Checklist ID.
        /// </summary>
        /// <value>Agent Checklist ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Agent Checklist Name.
        /// </summary>
        /// <value>Agent Checklist Name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Agent Checklist Language.
        /// </summary>
        /// <value>Agent Checklist Language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Agent Checklist Items.
        /// </summary>
        /// <value>Agent Checklist Items.</value>
        [DataMember(Name="checklistItems", EmitDefaultValue=false)]
        public List<AgentChecklistItem> ChecklistItems { get; set; }



        /// <summary>
        /// The user who created the agent checklist.
        /// </summary>
        /// <value>The user who created the agent checklist.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserReference CreatedBy { get; private set; }



        /// <summary>
        /// The user who last modified the agent checklist.
        /// </summary>
        /// <value>The user who last modified the agent checklist.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; private set; }



        /// <summary>
        /// Date when the agent checklist was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the agent checklist was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Date when the agent checklist was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date when the agent checklist was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



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
            sb.Append("class AgentChecklist {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ChecklistItems: ").Append(ChecklistItems).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as AgentChecklist);
        }

        /// <summary>
        /// Returns true if AgentChecklist instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentChecklist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentChecklist other)
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
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.ChecklistItems == other.ChecklistItems ||
                    this.ChecklistItems != null &&
                    this.ChecklistItems.SequenceEqual(other.ChecklistItems)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
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

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.ChecklistItems != null)
                    hash = hash * 59 + this.ChecklistItems.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
