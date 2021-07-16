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
    /// Action
    /// </summary>
    [DataContract]
    public partial class Action :  IEquatable<Action>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="IntegrationId">The ID of the integration for which this action is associated.</param>
        /// <param name="Category">Category of Action.</param>
        /// <param name="Contract">Action contract.</param>
        /// <param name="Version">Version of this action.</param>
        /// <param name="Secure">Indication of whether or not the action is designed to accept sensitive data.</param>
        /// <param name="Config">Configuration to support request and response processing.</param>
        public Action(string Name = null, string IntegrationId = null, string Category = null, ActionContract Contract = null, int? Version = null, bool? Secure = null, ActionConfig Config = null)
        {
            this.Name = Name;
            this.IntegrationId = IntegrationId;
            this.Category = Category;
            this.Contract = Contract;
            this.Version = Version;
            this.Secure = Secure;
            this.Config = Config;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The ID of the integration for which this action is associated
        /// </summary>
        /// <value>The ID of the integration for which this action is associated</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }
        
        
        
        /// <summary>
        /// Category of Action
        /// </summary>
        /// <value>Category of Action</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        
        
        
        /// <summary>
        /// Action contract
        /// </summary>
        /// <value>Action contract</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public ActionContract Contract { get; set; }
        
        
        
        /// <summary>
        /// Version of this action
        /// </summary>
        /// <value>Version of this action</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// Indication of whether or not the action is designed to accept sensitive data
        /// </summary>
        /// <value>Indication of whether or not the action is designed to accept sensitive data</value>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public bool? Secure { get; set; }
        
        
        
        /// <summary>
        /// Configuration to support request and response processing
        /// </summary>
        /// <value>Configuration to support request and response processing</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public ActionConfig Config { get; set; }
        
        
        
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
            sb.Append("class Action {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
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
            return this.Equals(obj as Action);
        }

        /// <summary>
        /// Returns true if Action instances are equal
        /// </summary>
        /// <param name="other">Instance of Action to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Action other)
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
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.Contract == other.Contract ||
                    this.Contract != null &&
                    this.Contract.Equals(other.Contract)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
                ) &&
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
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
                
                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.Contract != null)
                    hash = hash * 59 + this.Contract.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();
                
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
