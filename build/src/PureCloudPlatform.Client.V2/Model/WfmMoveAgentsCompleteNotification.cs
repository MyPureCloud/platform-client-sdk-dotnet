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
    /// WfmMoveAgentsCompleteNotification
    /// </summary>
    [DataContract]
    public partial class WfmMoveAgentsCompleteNotification :  IEquatable<WfmMoveAgentsCompleteNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmMoveAgentsCompleteNotification" /> class.
        /// </summary>
        
        
        /// <param name="RequestingUser">RequestingUser.</param>
        
        
        
        /// <param name="DestinationManagementUnit">DestinationManagementUnit.</param>
        
        
        
        /// <param name="MoveAgentResults">MoveAgentResults.</param>
        
        
        public WfmMoveAgentsCompleteNotification(DocumentDataV2NotificationWorkspace RequestingUser = null, DocumentDataV2NotificationWorkspace DestinationManagementUnit = null, List<WfmMoveAgentsCompleteNotificationMoveAgentResults> MoveAgentResults = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.RequestingUser = RequestingUser;
            
            
            
            
            
            
            
            
this.DestinationManagementUnit = DestinationManagementUnit;
            
            
            
            
            
            
            
            
this.MoveAgentResults = MoveAgentResults;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets RequestingUser
        /// </summary>
        [DataMember(Name="requestingUser", EmitDefaultValue=false)]
        public DocumentDataV2NotificationWorkspace RequestingUser { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DestinationManagementUnit
        /// </summary>
        [DataMember(Name="destinationManagementUnit", EmitDefaultValue=false)]
        public DocumentDataV2NotificationWorkspace DestinationManagementUnit { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MoveAgentResults
        /// </summary>
        [DataMember(Name="moveAgentResults", EmitDefaultValue=false)]
        public List<WfmMoveAgentsCompleteNotificationMoveAgentResults> MoveAgentResults { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmMoveAgentsCompleteNotification {\n");
            
            sb.Append("  RequestingUser: ").Append(RequestingUser).Append("\n");
            
            sb.Append("  DestinationManagementUnit: ").Append(DestinationManagementUnit).Append("\n");
            
            sb.Append("  MoveAgentResults: ").Append(MoveAgentResults).Append("\n");
            
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
            return this.Equals(obj as WfmMoveAgentsCompleteNotification);
        }

        /// <summary>
        /// Returns true if WfmMoveAgentsCompleteNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmMoveAgentsCompleteNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmMoveAgentsCompleteNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RequestingUser == other.RequestingUser ||
                    this.RequestingUser != null &&
                    this.RequestingUser.Equals(other.RequestingUser)
                ) &&
                (
                    this.DestinationManagementUnit == other.DestinationManagementUnit ||
                    this.DestinationManagementUnit != null &&
                    this.DestinationManagementUnit.Equals(other.DestinationManagementUnit)
                ) &&
                (
                    this.MoveAgentResults == other.MoveAgentResults ||
                    this.MoveAgentResults != null &&
                    this.MoveAgentResults.SequenceEqual(other.MoveAgentResults)
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
                
                if (this.RequestingUser != null)
                    hash = hash * 59 + this.RequestingUser.GetHashCode();
                
                if (this.DestinationManagementUnit != null)
                    hash = hash * 59 + this.DestinationManagementUnit.GetHashCode();
                
                if (this.MoveAgentResults != null)
                    hash = hash * 59 + this.MoveAgentResults.GetHashCode();
                
                return hash;
            }
        }
    }

}
