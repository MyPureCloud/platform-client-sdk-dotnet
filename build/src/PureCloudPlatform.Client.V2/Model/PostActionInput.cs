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
    /// Definition of an Action to be created or updated.
    /// </summary>
    [DataContract]
    public partial class PostActionInput :  IEquatable<PostActionInput>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostActionInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostActionInput() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostActionInput" /> class.
        /// </summary>
        /// <param name="Category">Category of action (required).</param>
        /// <param name="Name">Name of action (required).</param>
        /// <param name="IntegrationId">The ID of the integration this action is associated to (required).</param>
        /// <param name="Config">Configuration to support request and response processing (required).</param>
        /// <param name="Contract">Action contract (required).</param>
        /// <param name="Secure">Indication of whether or not the action is designed to accept sensitive data.</param>
        public PostActionInput(string Category = null, string Name = null, string IntegrationId = null, ActionConfig Config = null, ActionContractInput Contract = null, bool? Secure = null)
        {
            this.Category = Category;
            this.Name = Name;
            this.IntegrationId = IntegrationId;
            this.Config = Config;
            this.Contract = Contract;
            this.Secure = Secure;
            
        }
        
        
        
        /// <summary>
        /// Category of action
        /// </summary>
        /// <value>Category of action</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        
        
        
        /// <summary>
        /// Name of action
        /// </summary>
        /// <value>Name of action</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The ID of the integration this action is associated to
        /// </summary>
        /// <value>The ID of the integration this action is associated to</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }
        
        
        
        /// <summary>
        /// Configuration to support request and response processing
        /// </summary>
        /// <value>Configuration to support request and response processing</value>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public ActionConfig Config { get; set; }
        
        
        
        /// <summary>
        /// Action contract
        /// </summary>
        /// <value>Action contract</value>
        [DataMember(Name="contract", EmitDefaultValue=false)]
        public ActionContractInput Contract { get; set; }
        
        
        
        /// <summary>
        /// Indication of whether or not the action is designed to accept sensitive data
        /// </summary>
        /// <value>Indication of whether or not the action is designed to accept sensitive data</value>
        [DataMember(Name="secure", EmitDefaultValue=false)]
        public bool? Secure { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostActionInput {\n");
            
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
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
            return this.Equals(obj as PostActionInput);
        }

        /// <summary>
        /// Returns true if PostActionInput instances are equal
        /// </summary>
        /// <param name="other">Instance of PostActionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostActionInput other)
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
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) &&
                (
                    this.Contract == other.Contract ||
                    this.Contract != null &&
                    this.Contract.Equals(other.Contract)
                ) &&
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
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
                
                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();
                
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                
                if (this.Contract != null)
                    hash = hash * 59 + this.Contract.GetHashCode();
                
                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();
                
                return hash;
            }
        }
    }

}
