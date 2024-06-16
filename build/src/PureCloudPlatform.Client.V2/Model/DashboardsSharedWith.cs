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
    /// DashboardsSharedWith
    /// </summary>
    [DataContract]
    public partial class DashboardsSharedWith :  IEquatable<DashboardsSharedWith>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardsSharedWith" /> class.
        /// </summary>
        /// <param name="UserIds">The list of user ids to share the dashboard with.</param>
        /// <param name="TeamIds">The list of team ids to share the dashboard with.</param>
        public DashboardsSharedWith(List<string> UserIds = null, List<string> TeamIds = null)
        {
            this.UserIds = UserIds;
            this.TeamIds = TeamIds;
            
        }
        


        /// <summary>
        /// The list of user ids to share the dashboard with
        /// </summary>
        /// <value>The list of user ids to share the dashboard with</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<string> UserIds { get; set; }



        /// <summary>
        /// The list of team ids to share the dashboard with
        /// </summary>
        /// <value>The list of team ids to share the dashboard with</value>
        [DataMember(Name="teamIds", EmitDefaultValue=false)]
        public List<string> TeamIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardsSharedWith {\n");

            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
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
            return this.Equals(obj as DashboardsSharedWith);
        }

        /// <summary>
        /// Returns true if DashboardsSharedWith instances are equal
        /// </summary>
        /// <param name="other">Instance of DashboardsSharedWith to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardsSharedWith other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.TeamIds == other.TeamIds ||
                    this.TeamIds != null &&
                    this.TeamIds.SequenceEqual(other.TeamIds)
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
                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();

                if (this.TeamIds != null)
                    hash = hash * 59 + this.TeamIds.GetHashCode();

                return hash;
            }
        }
    }

}
