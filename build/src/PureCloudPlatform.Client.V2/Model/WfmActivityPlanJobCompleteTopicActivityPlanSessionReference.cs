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
    /// WfmActivityPlanJobCompleteTopicActivityPlanSessionReference
    /// </summary>
    [DataContract]
    public partial class WfmActivityPlanJobCompleteTopicActivityPlanSessionReference :  IEquatable<WfmActivityPlanJobCompleteTopicActivityPlanSessionReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmActivityPlanJobCompleteTopicActivityPlanSessionReference" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Users">Users.</param>
        public WfmActivityPlanJobCompleteTopicActivityPlanSessionReference(string Id = null, List<WfmActivityPlanJobCompleteTopicUserReference> Users = null)
        {
            this.Id = Id;
            this.Users = Users;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<WfmActivityPlanJobCompleteTopicUserReference> Users { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmActivityPlanJobCompleteTopicActivityPlanSessionReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as WfmActivityPlanJobCompleteTopicActivityPlanSessionReference);
        }

        /// <summary>
        /// Returns true if WfmActivityPlanJobCompleteTopicActivityPlanSessionReference instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmActivityPlanJobCompleteTopicActivityPlanSessionReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmActivityPlanJobCompleteTopicActivityPlanSessionReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();

                return hash;
            }
        }
    }

}
