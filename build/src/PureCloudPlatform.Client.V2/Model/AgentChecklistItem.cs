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
    /// AgentChecklistItem
    /// </summary>
    [DataContract]
    public partial class AgentChecklistItem :  IEquatable<AgentChecklistItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklistItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentChecklistItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChecklistItem" /> class.
        /// </summary>
        /// <param name="Name">Name of the checklist item. (required).</param>
        /// <param name="Description">Description of the checklist item..</param>
        /// <param name="AutomatedCheckEnabled">Flag to indicate whether automated check is enabled for this checklist item..</param>
        /// <param name="Important">Flag to indicate whether this checklist item is marked as important..</param>
        public AgentChecklistItem(string Name = null, string Description = null, bool? AutomatedCheckEnabled = null, bool? Important = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.AutomatedCheckEnabled = AutomatedCheckEnabled;
            this.Important = Important;
            
        }
        


        /// <summary>
        /// ID of the checklist item.
        /// </summary>
        /// <value>ID of the checklist item.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



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
            sb.Append("class AgentChecklistItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AutomatedCheckEnabled: ").Append(AutomatedCheckEnabled).Append("\n");
            sb.Append("  Important: ").Append(Important).Append("\n");
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
            return this.Equals(obj as AgentChecklistItem);
        }

        /// <summary>
        /// Returns true if AgentChecklistItem instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentChecklistItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentChecklistItem other)
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

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
