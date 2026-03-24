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
    /// ManagementUnitUserListing
    /// </summary>
    [DataContract]
    public partial class ManagementUnitUserListing :  IEquatable<ManagementUnitUserListing>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnitUserListing" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManagementUnitUserListing() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementUnitUserListing" /> class.
        /// </summary>
        /// <param name="ManagementUnit">The management unit associated with the users (required).</param>
        /// <param name="Users">Users in the management unit (required).</param>
        public ManagementUnitUserListing(ManagementUnitReference ManagementUnit = null, List<UserReference> Users = null)
        {
            this.ManagementUnit = ManagementUnit;
            this.Users = Users;
            
        }
        


        /// <summary>
        /// The management unit associated with the users
        /// </summary>
        /// <value>The management unit associated with the users</value>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public ManagementUnitReference ManagementUnit { get; set; }



        /// <summary>
        /// Users in the management unit
        /// </summary>
        /// <value>Users in the management unit</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserReference> Users { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagementUnitUserListing {\n");

            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
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
            return this.Equals(obj as ManagementUnitUserListing);
        }

        /// <summary>
        /// Returns true if ManagementUnitUserListing instances are equal
        /// </summary>
        /// <param name="other">Instance of ManagementUnitUserListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagementUnitUserListing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
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
                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();

                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();

                return hash;
            }
        }
    }

}
