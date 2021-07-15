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
    /// A botConnector Bot Instance
    /// </summary>
    [DataContract]
    public partial class BotConnectorBot :  IEquatable<BotConnectorBot>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BotConnectorBot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BotConnectorBot() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BotConnectorBot" /> class.
        /// </summary>
        /// <param name="Id">The Botconnector Bot Id - this is configurable by the user when put (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace.</param>
        /// <param name="Versions">This bots versions, limit of 50 per bot (required).</param>
        public BotConnectorBot(string Id = null, string Name = null, string Description = null, List<BotConnectorBotVersion> Versions = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Versions = Versions;
            
        }
        
        
        
        /// <summary>
        /// The Botconnector Bot Id - this is configurable by the user when put
        /// </summary>
        /// <value>The Botconnector Bot Id - this is configurable by the user when put</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace
        /// </summary>
        /// <value>An optional description of the bot.  This can be up to 256 characters long and must be comprised of displayable characters without leading or trailing whitespace</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// This bots versions, limit of 50 per bot
        /// </summary>
        /// <value>This bots versions, limit of 50 per bot</value>
        [DataMember(Name="versions", EmitDefaultValue=false)]
        public List<BotConnectorBotVersion> Versions { get; set; }
        
        
        
        /// <summary>
        /// A system-generated string that contains metadata about this bot.
        /// </summary>
        /// <value>A system-generated string that contains metadata about this bot.</value>
        [DataMember(Name="botCompositeTag", EmitDefaultValue=false)]
        public string BotCompositeTag { get; private set; }
        
        
        
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
            sb.Append("class BotConnectorBot {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("  BotCompositeTag: ").Append(BotCompositeTag).Append("\n");
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
            return this.Equals(obj as BotConnectorBot);
        }

        /// <summary>
        /// Returns true if BotConnectorBot instances are equal
        /// </summary>
        /// <param name="other">Instance of BotConnectorBot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotConnectorBot other)
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
                    this.Versions == other.Versions ||
                    this.Versions != null &&
                    this.Versions.SequenceEqual(other.Versions)
                ) &&
                (
                    this.BotCompositeTag == other.BotCompositeTag ||
                    this.BotCompositeTag != null &&
                    this.BotCompositeTag.Equals(other.BotCompositeTag)
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
                
                if (this.Versions != null)
                    hash = hash * 59 + this.Versions.GetHashCode();
                
                if (this.BotCompositeTag != null)
                    hash = hash * 59 + this.BotCompositeTag.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
