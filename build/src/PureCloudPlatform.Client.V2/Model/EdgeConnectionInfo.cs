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
    /// EdgeConnectionInfo
    /// </summary>
    [DataContract]
    public partial class EdgeConnectionInfo :  IEquatable<EdgeConnectionInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeConnectionInfo" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ConnectionErrors">Connection errors.</param>
        /// <param name="Site">Site.</param>
        public EdgeConnectionInfo(string Name = null, List<string> ConnectionErrors = null, AddressableEntityRef Site = null)
        {
            this.Name = Name;
            this.ConnectionErrors = ConnectionErrors;
            this.Site = Site;
            
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
        /// Interface used for the connection on the edge
        /// </summary>
        /// <value>Interface used for the connection on the edge</value>
        [DataMember(Name="interfaceName", EmitDefaultValue=false)]
        public string InterfaceName { get; private set; }
        
        
        
        /// <summary>
        /// IP address of the interface
        /// </summary>
        /// <value>IP address of the interface</value>
        [DataMember(Name="interfaceIpAddress", EmitDefaultValue=false)]
        public string InterfaceIpAddress { get; private set; }
        
        
        
        /// <summary>
        /// Connection errors
        /// </summary>
        /// <value>Connection errors</value>
        [DataMember(Name="connectionErrors", EmitDefaultValue=false)]
        public List<string> ConnectionErrors { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public AddressableEntityRef Site { get; set; }
        
        
        
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
            sb.Append("class EdgeConnectionInfo {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
            sb.Append("  InterfaceIpAddress: ").Append(InterfaceIpAddress).Append("\n");
            sb.Append("  ConnectionErrors: ").Append(ConnectionErrors).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
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
            return this.Equals(obj as EdgeConnectionInfo);
        }

        /// <summary>
        /// Returns true if EdgeConnectionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeConnectionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeConnectionInfo other)
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
                    this.InterfaceName == other.InterfaceName ||
                    this.InterfaceName != null &&
                    this.InterfaceName.Equals(other.InterfaceName)
                ) &&
                (
                    this.InterfaceIpAddress == other.InterfaceIpAddress ||
                    this.InterfaceIpAddress != null &&
                    this.InterfaceIpAddress.Equals(other.InterfaceIpAddress)
                ) &&
                (
                    this.ConnectionErrors == other.ConnectionErrors ||
                    this.ConnectionErrors != null &&
                    this.ConnectionErrors.SequenceEqual(other.ConnectionErrors)
                ) &&
                (
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
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
                
                if (this.InterfaceName != null)
                    hash = hash * 59 + this.InterfaceName.GetHashCode();
                
                if (this.InterfaceIpAddress != null)
                    hash = hash * 59 + this.InterfaceIpAddress.GetHashCode();
                
                if (this.ConnectionErrors != null)
                    hash = hash * 59 + this.ConnectionErrors.GetHashCode();
                
                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
