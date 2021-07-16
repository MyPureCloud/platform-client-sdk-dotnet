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
    /// WfmMoveAgentsCompleteTopicWfmMoveAgentData
    /// </summary>
    [DataContract]
    public partial class WfmMoveAgentsCompleteTopicWfmMoveAgentData :  IEquatable<WfmMoveAgentsCompleteTopicWfmMoveAgentData>
    {
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alreadymoved for "AlreadyMoved"
            /// </summary>
            [EnumMember(Value = "AlreadyMoved")]
            Alreadymoved,
            
            /// <summary>
            /// Enum Destinationbusinessunitagentlimitexceeded for "DestinationBusinessUnitAgentLimitExceeded"
            /// </summary>
            [EnumMember(Value = "DestinationBusinessUnitAgentLimitExceeded")]
            Destinationbusinessunitagentlimitexceeded,
            
            /// <summary>
            /// Enum Destinationmanagementunitagentlimitexceeded for "DestinationManagementUnitAgentLimitExceeded"
            /// </summary>
            [EnumMember(Value = "DestinationManagementUnitAgentLimitExceeded")]
            Destinationmanagementunitagentlimitexceeded,
            
            /// <summary>
            /// Enum Destinationmanagementunitdoesnotexist for "DestinationManagementUnitDoesNotExist"
            /// </summary>
            [EnumMember(Value = "DestinationManagementUnitDoesNotExist")]
            Destinationmanagementunitdoesnotexist,
            
            /// <summary>
            /// Enum Movesuccessful for "MoveSuccessful"
            /// </summary>
            [EnumMember(Value = "MoveSuccessful")]
            Movesuccessful,
            
            /// <summary>
            /// Enum Movingtodifferentmanagementunit for "MovingToDifferentManagementUnit"
            /// </summary>
            [EnumMember(Value = "MovingToDifferentManagementUnit")]
            Movingtodifferentmanagementunit,
            
            /// <summary>
            /// Enum Nothingtodo for "NothingToDo"
            /// </summary>
            [EnumMember(Value = "NothingToDo")]
            Nothingtodo,
            
            /// <summary>
            /// Enum Sourcemanagementunitnotauthorized for "SourceManagementUnitNotAuthorized"
            /// </summary>
            [EnumMember(Value = "SourceManagementUnitNotAuthorized")]
            Sourcemanagementunitnotauthorized
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public ResultEnum? Result { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmMoveAgentsCompleteTopicWfmMoveAgentData" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Result">Result.</param>
        public WfmMoveAgentsCompleteTopicWfmMoveAgentData(WfmMoveAgentsCompleteTopicUserReference User = null, ResultEnum? Result = null)
        {
            this.User = User;
            this.Result = Result;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public WfmMoveAgentsCompleteTopicUserReference User { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmMoveAgentsCompleteTopicWfmMoveAgentData {\n");
            
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as WfmMoveAgentsCompleteTopicWfmMoveAgentData);
        }

        /// <summary>
        /// Returns true if WfmMoveAgentsCompleteTopicWfmMoveAgentData instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmMoveAgentsCompleteTopicWfmMoveAgentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmMoveAgentsCompleteTopicWfmMoveAgentData other)
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
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                
                return hash;
            }
        }
    }

}
