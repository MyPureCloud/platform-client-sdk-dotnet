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
    /// WfmMoveAgentsCompleteNotificationWfmMoveAgentData
    /// </summary>
    [DataContract]
    public partial class WfmMoveAgentsCompleteNotificationWfmMoveAgentData :  IEquatable<WfmMoveAgentsCompleteNotificationWfmMoveAgentData>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MoveAgentResult
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MoveAgentResultEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Movesuccessful for "MoveSuccessful"
            /// </summary>
            [EnumMember(Value = "MoveSuccessful")]
            Movesuccessful,
            
            /// <summary>
            /// Enum Nothingtodo for "NothingToDo"
            /// </summary>
            [EnumMember(Value = "NothingToDo")]
            Nothingtodo,
            
            /// <summary>
            /// Enum Alreadymoved for "AlreadyMoved"
            /// </summary>
            [EnumMember(Value = "AlreadyMoved")]
            Alreadymoved,
            
            /// <summary>
            /// Enum Destinationmanagementunitdoesnotexist for "DestinationManagementUnitDoesNotExist"
            /// </summary>
            [EnumMember(Value = "DestinationManagementUnitDoesNotExist")]
            Destinationmanagementunitdoesnotexist,
            
            /// <summary>
            /// Enum Destinationmanagementunitagentlimitexceeded for "DestinationManagementUnitAgentLimitExceeded"
            /// </summary>
            [EnumMember(Value = "DestinationManagementUnitAgentLimitExceeded")]
            Destinationmanagementunitagentlimitexceeded,
            
            /// <summary>
            /// Enum Movingtodifferentmanagementunit for "MovingToDifferentManagementUnit"
            /// </summary>
            [EnumMember(Value = "MovingToDifferentManagementUnit")]
            Movingtodifferentmanagementunit
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets MoveAgentResult
        /// </summary>
        [DataMember(Name="moveAgentResult", EmitDefaultValue=false)]
        public MoveAgentResultEnum? MoveAgentResult { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmMoveAgentsCompleteNotificationWfmMoveAgentData" /> class.
        /// </summary>
        
        
        /// <param name="User">User.</param>
        
        
        
        /// <param name="MoveAgentResult">MoveAgentResult.</param>
        
        
        public WfmMoveAgentsCompleteNotificationWfmMoveAgentData(WfmMoveAgentsCompleteNotificationUser User = null, MoveAgentResultEnum? MoveAgentResult = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.User = User;
            
            
            
            
            
            
            
            
this.MoveAgentResult = MoveAgentResult;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmMoveAgentsCompleteNotificationUser User { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmMoveAgentsCompleteNotificationWfmMoveAgentData {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            
            sb.Append("  MoveAgentResult: ").Append(MoveAgentResult).Append("\n");
            
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
            return this.Equals(obj as WfmMoveAgentsCompleteNotificationWfmMoveAgentData);
        }

        /// <summary>
        /// Returns true if WfmMoveAgentsCompleteNotificationWfmMoveAgentData instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmMoveAgentsCompleteNotificationWfmMoveAgentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmMoveAgentsCompleteNotificationWfmMoveAgentData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.MoveAgentResult == other.MoveAgentResult ||
                    this.MoveAgentResult != null &&
                    this.MoveAgentResult.Equals(other.MoveAgentResult)
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
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.MoveAgentResult != null)
                    hash = hash * 59 + this.MoveAgentResult.GetHashCode();
                
                return hash;
            }
        }
    }

}
