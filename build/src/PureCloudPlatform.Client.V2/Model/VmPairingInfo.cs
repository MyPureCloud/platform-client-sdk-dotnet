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
    /// VmPairingInfo
    /// </summary>
    [DataContract]
    public partial class VmPairingInfo :  IEquatable<VmPairingInfo>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VmPairingInfo" /> class.
        /// </summary>
        
        
        /// <param name="MetaData">This is to be used to complete the setup process of a locally deployed virtual edge device..</param>
        
        
        
        /// <param name="EdgeId">EdgeId.</param>
        
        
        
        /// <param name="AuthToken">AuthToken.</param>
        
        
        
        /// <param name="OrgId">OrgId.</param>
        
        
        public VmPairingInfo(MetaData MetaData = null, string EdgeId = null, string AuthToken = null, string OrgId = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MetaData = MetaData;
            
            
            
            
            
            
            
            
this.EdgeId = EdgeId;
            
            
            
            
            
            
            
            
this.AuthToken = AuthToken;
            
            
            
            
            
            
            
            
this.OrgId = OrgId;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// This is to be used to complete the setup process of a locally deployed virtual edge device.
        /// </summary>
        /// <value>This is to be used to complete the setup process of a locally deployed virtual edge device.</value>
        [DataMember(Name="meta-data", EmitDefaultValue=false)]
        public MetaData MetaData { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EdgeId
        /// </summary>
        [DataMember(Name="edge-id", EmitDefaultValue=false)]
        public string EdgeId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name="auth-token", EmitDefaultValue=false)]
        public string AuthToken { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OrgId
        /// </summary>
        [DataMember(Name="org-id", EmitDefaultValue=false)]
        public string OrgId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VmPairingInfo {\n");
            
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            
            sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
            
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            
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
            return this.Equals(obj as VmPairingInfo);
        }

        /// <summary>
        /// Returns true if VmPairingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of VmPairingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmPairingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.Equals(other.MetaData)
                ) &&
                (
                    this.EdgeId == other.EdgeId ||
                    this.EdgeId != null &&
                    this.EdgeId.Equals(other.EdgeId)
                ) &&
                (
                    this.AuthToken == other.AuthToken ||
                    this.AuthToken != null &&
                    this.AuthToken.Equals(other.AuthToken)
                ) &&
                (
                    this.OrgId == other.OrgId ||
                    this.OrgId != null &&
                    this.OrgId.Equals(other.OrgId)
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
                
                if (this.MetaData != null)
                    hash = hash * 59 + this.MetaData.GetHashCode();
                
                if (this.EdgeId != null)
                    hash = hash * 59 + this.EdgeId.GetHashCode();
                
                if (this.AuthToken != null)
                    hash = hash * 59 + this.AuthToken.GetHashCode();
                
                if (this.OrgId != null)
                    hash = hash * 59 + this.OrgId.GetHashCode();
                
                return hash;
            }
        }
    }

}
