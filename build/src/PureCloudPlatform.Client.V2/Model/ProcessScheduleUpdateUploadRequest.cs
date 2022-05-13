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
    /// ProcessScheduleUpdateUploadRequest
    /// </summary>
    [DataContract]
    public partial class ProcessScheduleUpdateUploadRequest :  IEquatable<ProcessScheduleUpdateUploadRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessScheduleUpdateUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessScheduleUpdateUploadRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessScheduleUpdateUploadRequest" /> class.
        /// </summary>
        /// <param name="UploadKey">The uploadKey provided by the request to get an upload URL (required).</param>
        /// <param name="TeamIds">The list of teams to which the users being modified belong. Only required if the requesting user has conditional permission to wfm:schedule:edit.</param>
        /// <param name="ManagementUnitIdsForAddedTeamUsers">The set of muIds to which agents belong if agents are being newly added to the schedule, if the requesting user has conditional permission to wfm:schedule:edit.</param>
        public ProcessScheduleUpdateUploadRequest(string UploadKey = null, List<string> TeamIds = null, List<string> ManagementUnitIdsForAddedTeamUsers = null)
        {
            this.UploadKey = UploadKey;
            this.TeamIds = TeamIds;
            this.ManagementUnitIdsForAddedTeamUsers = ManagementUnitIdsForAddedTeamUsers;
            
        }
        


        /// <summary>
        /// The uploadKey provided by the request to get an upload URL
        /// </summary>
        /// <value>The uploadKey provided by the request to get an upload URL</value>
        [DataMember(Name="uploadKey", EmitDefaultValue=false)]
        public string UploadKey { get; set; }



        /// <summary>
        /// The list of teams to which the users being modified belong. Only required if the requesting user has conditional permission to wfm:schedule:edit
        /// </summary>
        /// <value>The list of teams to which the users being modified belong. Only required if the requesting user has conditional permission to wfm:schedule:edit</value>
        [DataMember(Name="teamIds", EmitDefaultValue=false)]
        public List<string> TeamIds { get; set; }



        /// <summary>
        /// The set of muIds to which agents belong if agents are being newly added to the schedule, if the requesting user has conditional permission to wfm:schedule:edit
        /// </summary>
        /// <value>The set of muIds to which agents belong if agents are being newly added to the schedule, if the requesting user has conditional permission to wfm:schedule:edit</value>
        [DataMember(Name="managementUnitIdsForAddedTeamUsers", EmitDefaultValue=false)]
        public List<string> ManagementUnitIdsForAddedTeamUsers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessScheduleUpdateUploadRequest {\n");

            sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
            sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
            sb.Append("  ManagementUnitIdsForAddedTeamUsers: ").Append(ManagementUnitIdsForAddedTeamUsers).Append("\n");
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
            return this.Equals(obj as ProcessScheduleUpdateUploadRequest);
        }

        /// <summary>
        /// Returns true if ProcessScheduleUpdateUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ProcessScheduleUpdateUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessScheduleUpdateUploadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UploadKey == other.UploadKey ||
                    this.UploadKey != null &&
                    this.UploadKey.Equals(other.UploadKey)
                ) &&
                (
                    this.TeamIds == other.TeamIds ||
                    this.TeamIds != null &&
                    this.TeamIds.SequenceEqual(other.TeamIds)
                ) &&
                (
                    this.ManagementUnitIdsForAddedTeamUsers == other.ManagementUnitIdsForAddedTeamUsers ||
                    this.ManagementUnitIdsForAddedTeamUsers != null &&
                    this.ManagementUnitIdsForAddedTeamUsers.SequenceEqual(other.ManagementUnitIdsForAddedTeamUsers)
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
                if (this.UploadKey != null)
                    hash = hash * 59 + this.UploadKey.GetHashCode();

                if (this.TeamIds != null)
                    hash = hash * 59 + this.TeamIds.GetHashCode();

                if (this.ManagementUnitIdsForAddedTeamUsers != null)
                    hash = hash * 59 + this.ManagementUnitIdsForAddedTeamUsers.GetHashCode();

                return hash;
            }
        }
    }

}
