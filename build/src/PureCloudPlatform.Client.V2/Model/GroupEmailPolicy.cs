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
    /// GroupEmailPolicy
    /// </summary>
    [DataContract]
    public partial class GroupEmailPolicy :  IEquatable<GroupEmailPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupEmailPolicy" /> class.
        /// </summary>
        /// <param name="EmailMembers">EmailMembers.</param>
        /// <param name="EmailGroup">EmailGroup.</param>
        public GroupEmailPolicy(bool? EmailMembers = null, bool? EmailGroup = null)
        {
            this.EmailMembers = EmailMembers;
            this.EmailGroup = EmailGroup;
            
        }
        


        /// <summary>
        /// Gets or Sets EmailMembers
        /// </summary>
        [DataMember(Name="emailMembers", EmitDefaultValue=false)]
        public bool? EmailMembers { get; set; }



        /// <summary>
        /// Gets or Sets EmailGroup
        /// </summary>
        [DataMember(Name="emailGroup", EmitDefaultValue=false)]
        public bool? EmailGroup { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupEmailPolicy {\n");

            sb.Append("  EmailMembers: ").Append(EmailMembers).Append("\n");
            sb.Append("  EmailGroup: ").Append(EmailGroup).Append("\n");
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
            return this.Equals(obj as GroupEmailPolicy);
        }

        /// <summary>
        /// Returns true if GroupEmailPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupEmailPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupEmailPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EmailMembers == other.EmailMembers ||
                    this.EmailMembers != null &&
                    this.EmailMembers.Equals(other.EmailMembers)
                ) &&
                (
                    this.EmailGroup == other.EmailGroup ||
                    this.EmailGroup != null &&
                    this.EmailGroup.Equals(other.EmailGroup)
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
                if (this.EmailMembers != null)
                    hash = hash * 59 + this.EmailMembers.GetHashCode();

                if (this.EmailGroup != null)
                    hash = hash * 59 + this.EmailGroup.GetHashCode();

                return hash;
            }
        }
    }

}
