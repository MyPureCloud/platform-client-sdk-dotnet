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
    /// GroupMembersUpdate
    /// </summary>
    [DataContract]
    public partial class GroupMembersUpdate :  IEquatable<GroupMembersUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMembersUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupMembersUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMembersUpdate" /> class.
        /// </summary>
        /// <param name="MemberIds">A list of the ids of the members to add. A maximum of 50 members are allowed per request. (required).</param>
        /// <param name="Version">The current group version..</param>
        public GroupMembersUpdate(List<string> MemberIds = null, int? Version = null)
        {
            this.MemberIds = MemberIds;
            this.Version = Version;
            
        }
        


        /// <summary>
        /// A list of the ids of the members to add. A maximum of 50 members are allowed per request.
        /// </summary>
        /// <value>A list of the ids of the members to add. A maximum of 50 members are allowed per request.</value>
        [DataMember(Name="memberIds", EmitDefaultValue=false)]
        public List<string> MemberIds { get; set; }



        /// <summary>
        /// The current group version.
        /// </summary>
        /// <value>The current group version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMembersUpdate {\n");

            sb.Append("  MemberIds: ").Append(MemberIds).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as GroupMembersUpdate);
        }

        /// <summary>
        /// Returns true if GroupMembersUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupMembersUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMembersUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MemberIds == other.MemberIds ||
                    this.MemberIds != null &&
                    this.MemberIds.SequenceEqual(other.MemberIds)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.MemberIds != null)
                    hash = hash * 59 + this.MemberIds.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                return hash;
            }
        }
    }

}
