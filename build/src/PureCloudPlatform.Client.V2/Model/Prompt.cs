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
    /// Prompt
    /// </summary>
    [DataContract]
    public partial class Prompt :  IEquatable<Prompt>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Prompt() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt" /> class.
        /// </summary>
        /// <param name="Id">The prompt identifier.</param>
        /// <param name="Name">The prompt name. (required).</param>
        /// <param name="Description">Description.</param>
        public Prompt(string Id = null, string Name = null, string Description = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            
        }
        
        
        
        /// <summary>
        /// The prompt identifier
        /// </summary>
        /// <value>The prompt identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The prompt name.
        /// </summary>
        /// <value>The prompt name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// List of resources associated with this prompt
        /// </summary>
        /// <value>List of resources associated with this prompt</value>
        [DataMember(Name="resources", EmitDefaultValue=false)]
        public List<PromptAsset> Resources { get; private set; }
        
        
        
        /// <summary>
        /// Current prompt operation status
        /// </summary>
        /// <value>Current prompt operation status</value>
        [DataMember(Name="currentOperation", EmitDefaultValue=false)]
        public Operation CurrentOperation { get; private set; }
        
        
        
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
            sb.Append("class Prompt {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  CurrentOperation: ").Append(CurrentOperation).Append("\n");
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
            return this.Equals(obj as Prompt);
        }

        /// <summary>
        /// Returns true if Prompt instances are equal
        /// </summary>
        /// <param name="other">Instance of Prompt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Prompt other)
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
                    this.Resources == other.Resources ||
                    this.Resources != null &&
                    this.Resources.SequenceEqual(other.Resources)
                ) &&
                (
                    this.CurrentOperation == other.CurrentOperation ||
                    this.CurrentOperation != null &&
                    this.CurrentOperation.Equals(other.CurrentOperation)
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
                
                if (this.Resources != null)
                    hash = hash * 59 + this.Resources.GetHashCode();
                
                if (this.CurrentOperation != null)
                    hash = hash * 59 + this.CurrentOperation.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
