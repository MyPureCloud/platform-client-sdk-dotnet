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
    /// ConnectedEdge
    /// </summary>
    [DataContract]
    public partial class ConnectedEdge :  IEquatable<ConnectedEdge>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedEdge" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="EdgeConnectionList">EdgeConnectionList.</param>
        public ConnectedEdge(string Name = null, List<EdgeConnectionInfo> EdgeConnectionList = null)
        {
            this.Name = Name;
            this.EdgeConnectionList = EdgeConnectionList;
            
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
        /// Edge interface name used for the connection
        /// </summary>
        /// <value>Edge interface name used for the connection</value>
        [DataMember(Name="interfaceName", EmitDefaultValue=false)]
        public string InterfaceName { get; private set; }
        
        
        
        /// <summary>
        /// Edge interface IP address
        /// </summary>
        /// <value>Edge interface IP address</value>
        [DataMember(Name="interfaceIpAddress", EmitDefaultValue=false)]
        public string InterfaceIpAddress { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets EdgeConnectionList
        /// </summary>
        [DataMember(Name="edgeConnectionList", EmitDefaultValue=false)]
        public List<EdgeConnectionInfo> EdgeConnectionList { get; set; }
        
        
        
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
            sb.Append("class ConnectedEdge {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
            sb.Append("  InterfaceIpAddress: ").Append(InterfaceIpAddress).Append("\n");
            sb.Append("  EdgeConnectionList: ").Append(EdgeConnectionList).Append("\n");
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
            return this.Equals(obj as ConnectedEdge);
        }

        /// <summary>
        /// Returns true if ConnectedEdge instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectedEdge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectedEdge other)
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
                    this.EdgeConnectionList == other.EdgeConnectionList ||
                    this.EdgeConnectionList != null &&
                    this.EdgeConnectionList.SequenceEqual(other.EdgeConnectionList)
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
                
                if (this.EdgeConnectionList != null)
                    hash = hash * 59 + this.EdgeConnectionList.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
