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
    /// UserStaffingGroupResponse
    /// </summary>
    [DataContract]
    public partial class UserStaffingGroupResponse :  IEquatable<UserStaffingGroupResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStaffingGroupResponse" /> class.
        /// </summary>
        /// <param name="User">The user associated with the staffing group.</param>
        /// <param name="StaffingGroup">The staffing group.</param>
        public UserStaffingGroupResponse(UserReference User = null, StaffingGroupReference StaffingGroup = null)
        {
            this.User = User;
            this.StaffingGroup = StaffingGroup;
            
        }
        


        /// <summary>
        /// The user associated with the staffing group
        /// </summary>
        /// <value>The user associated with the staffing group</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; set; }



        /// <summary>
        /// The staffing group
        /// </summary>
        /// <value>The staffing group</value>
        [DataMember(Name="staffingGroup", EmitDefaultValue=false)]
        public StaffingGroupReference StaffingGroup { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStaffingGroupResponse {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  StaffingGroup: ").Append(StaffingGroup).Append("\n");
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
            return this.Equals(obj as UserStaffingGroupResponse);
        }

        /// <summary>
        /// Returns true if UserStaffingGroupResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserStaffingGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStaffingGroupResponse other)
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
                    this.StaffingGroup == other.StaffingGroup ||
                    this.StaffingGroup != null &&
                    this.StaffingGroup.Equals(other.StaffingGroup)
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

                if (this.StaffingGroup != null)
                    hash = hash * 59 + this.StaffingGroup.GetHashCode();

                return hash;
            }
        }
    }

}
