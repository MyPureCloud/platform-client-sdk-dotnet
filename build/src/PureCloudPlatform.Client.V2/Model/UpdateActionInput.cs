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
    /// UpdateActionInput
    /// </summary>
    [DataContract]
    public partial class UpdateActionInput :  IEquatable<UpdateActionInput>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActionInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateActionInput() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActionInput" /> class.
        /// </summary>
        /// <param name="Category">Category of action, Can be up to 256 characters long.</param>
        /// <param name="Name">Name of action, Can be up to 256 characters long.</param>
        /// <param name="Config">Configuration to support request and response processing.</param>
        /// <param name="Version">Version of this action (required).</param>
        public UpdateActionInput(string Category = null, string Name = null, ActionConfig Config = null, int? Version = null)
        {
            this.Category = Category;
            this.Name = Name;
            this.Config = Config;
            this.Version = Version;
            
        }
        
        
        
        /// <summary>
        /// Category of action, Can be up to 256 characters long
        /// </summary>
        /// <value>Category of action, Can be up to 256 characters long</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        
        
        
        /// <summary>
        /// Name of action, Can be up to 256 characters long
        /// </summary>
        /// <value>Name of action, Can be up to 256 characters long</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Configuration to support request and response processing
        /// </summary>
        /// <value>Configuration to support request and response processing</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public ActionConfig Config { get; set; }
        
        
        
        /// <summary>
        /// Version of this action
        /// </summary>
        /// <value>Version of this action</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateActionInput {\n");
            
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as UpdateActionInput);
        }

        /// <summary>
        /// Returns true if UpdateActionInput instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateActionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateActionInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                return hash;
            }
        }
    }

}
