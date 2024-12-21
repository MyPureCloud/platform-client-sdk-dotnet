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
    /// AnalyticsAgentStateAgentResponse
    /// </summary>
    [DataContract]
    public partial class AnalyticsAgentStateAgentResponse :  IEquatable<AnalyticsAgentStateAgentResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsAgentStateAgentResponse" /> class.
        /// </summary>
        /// <param name="UserId">User Id - only returned if division is covered by agentStateNames permission.</param>
        /// <param name="DivisionId">Division Id.</param>
        /// <param name="UserName">User name - only returned if division is covered by agentStateNames permission.</param>
        /// <param name="ManagerId">The user that this user reports to.</param>
        /// <param name="SessionCount">The count of sessions.</param>
        /// <param name="Sessions">List of sessions.</param>
        public AnalyticsAgentStateAgentResponse(string UserId = null, string DivisionId = null, string UserName = null, string ManagerId = null, int? SessionCount = null, List<AnalyticsAgentStateAgentSessionResult> Sessions = null)
        {
            this.UserId = UserId;
            this.DivisionId = DivisionId;
            this.UserName = UserName;
            this.ManagerId = ManagerId;
            this.SessionCount = SessionCount;
            this.Sessions = Sessions;
            
        }
        


        /// <summary>
        /// User Id - only returned if division is covered by agentStateNames permission
        /// </summary>
        /// <value>User Id - only returned if division is covered by agentStateNames permission</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Division Id
        /// </summary>
        /// <value>Division Id</value>
        [DataMember(Name="divisionId", EmitDefaultValue=false)]
        public string DivisionId { get; set; }



        /// <summary>
        /// User name - only returned if division is covered by agentStateNames permission
        /// </summary>
        /// <value>User name - only returned if division is covered by agentStateNames permission</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }



        /// <summary>
        /// The user that this user reports to
        /// </summary>
        /// <value>The user that this user reports to</value>
        [DataMember(Name="managerId", EmitDefaultValue=false)]
        public string ManagerId { get; set; }



        /// <summary>
        /// The count of sessions
        /// </summary>
        /// <value>The count of sessions</value>
        [DataMember(Name="sessionCount", EmitDefaultValue=false)]
        public int? SessionCount { get; set; }



        /// <summary>
        /// List of sessions
        /// </summary>
        /// <value>List of sessions</value>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<AnalyticsAgentStateAgentSessionResult> Sessions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsAgentStateAgentResponse {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  ManagerId: ").Append(ManagerId).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
            return this.Equals(obj as AnalyticsAgentStateAgentResponse);
        }

        /// <summary>
        /// Returns true if AnalyticsAgentStateAgentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsAgentStateAgentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsAgentStateAgentResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.DivisionId == other.DivisionId ||
                    this.DivisionId != null &&
                    this.DivisionId.Equals(other.DivisionId)
                ) &&
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) &&
                (
                    this.ManagerId == other.ManagerId ||
                    this.ManagerId != null &&
                    this.ManagerId.Equals(other.ManagerId)
                ) &&
                (
                    this.SessionCount == other.SessionCount ||
                    this.SessionCount != null &&
                    this.SessionCount.Equals(other.SessionCount)
                ) &&
                (
                    this.Sessions == other.Sessions ||
                    this.Sessions != null &&
                    this.Sessions.SequenceEqual(other.Sessions)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.DivisionId != null)
                    hash = hash * 59 + this.DivisionId.GetHashCode();

                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();

                if (this.ManagerId != null)
                    hash = hash * 59 + this.ManagerId.GetHashCode();

                if (this.SessionCount != null)
                    hash = hash * 59 + this.SessionCount.GetHashCode();

                if (this.Sessions != null)
                    hash = hash * 59 + this.Sessions.GetHashCode();

                return hash;
            }
        }
    }

}
