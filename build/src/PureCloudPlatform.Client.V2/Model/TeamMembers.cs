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
    /// TeamMembers
    /// </summary>
    [DataContract]
    public partial class TeamMembers :  IEquatable<TeamMembers>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamMembers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembers" /> class.
        /// </summary>
        /// <param name="MemberIds">A list of the ids of the members to add or remove (required).</param>
        public TeamMembers(List<string> MemberIds = null)
        {
            this.MemberIds = MemberIds;
            
        }
        


        /// <summary>
        /// A list of the ids of the members to add or remove
        /// </summary>
        /// <value>A list of the ids of the members to add or remove</value>
        [DataMember(Name="memberIds", EmitDefaultValue=false)]
        public List<string> MemberIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMembers {\n");

            sb.Append("  MemberIds: ").Append(MemberIds).Append("\n");
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
            return this.Equals(obj as TeamMembers);
        }

        /// <summary>
        /// Returns true if TeamMembers instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamMembers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMembers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MemberIds == other.MemberIds ||
                    this.MemberIds != null &&
                    this.MemberIds.SequenceEqual(other.MemberIds)
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

                return hash;
            }
        }
    }

}
