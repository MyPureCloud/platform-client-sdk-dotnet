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
    /// AgentChecklistInfo
    /// </summary>
    [DataContract]
    public partial class AgentChecklistInfo :  IEquatable<AgentChecklistInfo>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklistInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentChecklistInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklistInfo" /> class.
        /// </summary>
        /// <param name="Id">ID of the checklist. (required).</param>
        /// <param name="Name">Name of the checklist. (required).</param>
        /// <param name="ChecklistItems">List of individual Checklist Items. (required).</param>
        public AgentChecklistInfo(string Id = null, string Name = null, List<ChecklistItem> ChecklistItems = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.ChecklistItems = ChecklistItems;
            
        }
        


        /// <summary>
        /// ID of the checklist.
        /// </summary>
        /// <value>ID of the checklist.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Name of the checklist.
        /// </summary>
        /// <value>Name of the checklist.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// List of individual Checklist Items.
        /// </summary>
        /// <value>List of individual Checklist Items.</value>
        [DataMember(Name="checklistItems", EmitDefaultValue=false)]
        public List<ChecklistItem> ChecklistItems { get; set; }



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
            sb.Append("class AgentChecklistInfo {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChecklistItems: ").Append(ChecklistItems).Append("\n");
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
            return this.Equals(obj as AgentChecklistInfo);
        }

        /// <summary>
        /// Returns true if AgentChecklistInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentChecklistInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentChecklistInfo other)
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
                    this.ChecklistItems == other.ChecklistItems ||
                    this.ChecklistItems != null &&
                    this.ChecklistItems.SequenceEqual(other.ChecklistItems)
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

                if (this.ChecklistItems != null)
                    hash = hash * 59 + this.ChecklistItems.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
