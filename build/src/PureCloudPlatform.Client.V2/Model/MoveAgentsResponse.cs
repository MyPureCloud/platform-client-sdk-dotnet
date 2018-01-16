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
    /// Response for move agents query
    /// </summary>
    [DataContract]
    public partial class MoveAgentsResponse :  IEquatable<MoveAgentsResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveAgentsResponse" /> class.
        /// </summary>
        
        
        /// <param name="RequestingUser">The user that made the request.</param>
        
        
        
        /// <param name="DestinationManagementUnit">The management unit specified on the request.</param>
        
        
        
        /// <param name="Results">The list containing the agent and result of the move operation.</param>
        
        
        public MoveAgentsResponse(UserReference RequestingUser = null, ManagementUnitReference DestinationManagementUnit = null, List<MoveAgentResponse> Results = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.RequestingUser = RequestingUser;
            
            
            
            
            
            
            
            
this.DestinationManagementUnit = DestinationManagementUnit;
            
            
            
            
            
            
            
            
this.Results = Results;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The user that made the request
        /// </summary>
        /// <value>The user that made the request</value>
        [DataMember(Name="requestingUser", EmitDefaultValue=false)]
        public UserReference RequestingUser { get; set; }
        
        
        
        /// <summary>
        /// The management unit specified on the request
        /// </summary>
        /// <value>The management unit specified on the request</value>
        [DataMember(Name="destinationManagementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference DestinationManagementUnit { get; set; }
        
        
        
        /// <summary>
        /// The list containing the agent and result of the move operation
        /// </summary>
        /// <value>The list containing the agent and result of the move operation</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<MoveAgentResponse> Results { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveAgentsResponse {\n");
            
            sb.Append("  RequestingUser: ").Append(RequestingUser).Append("\n");
            
            sb.Append("  DestinationManagementUnit: ").Append(DestinationManagementUnit).Append("\n");
            
            sb.Append("  Results: ").Append(Results).Append("\n");
            
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
            return this.Equals(obj as MoveAgentsResponse);
        }

        /// <summary>
        /// Returns true if MoveAgentsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MoveAgentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoveAgentsResponse other)
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
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                
                return hash;
            }
        }
    }

}
