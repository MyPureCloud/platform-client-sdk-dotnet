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
    /// UserActivityOutOfOffice
    /// </summary>
    [DataContract]
    public partial class UserActivityOutOfOffice :  IEquatable<UserActivityOutOfOffice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivityOutOfOffice" /> class.
        /// </summary>
        /// <param name="Active">Whether the user is currently out of office.</param>
        /// <param name="ModifiedDate">The date the out of office state was last modified. Date time is represented as an ISO-8601 string.</param>
        public UserActivityOutOfOffice(bool? Active = null, DateTime? ModifiedDate = null)
        {
            this.Active = Active;
            this.ModifiedDate = ModifiedDate;
            
        }
        


        /// <summary>
        /// Whether the user is currently out of office
        /// </summary>
        /// <value>Whether the user is currently out of office</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }



        /// <summary>
        /// The date the out of office state was last modified. Date time is represented as an ISO-8601 string
        /// </summary>
        /// <value>The date the out of office state was last modified. Date time is represented as an ISO-8601 string</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserActivityOutOfOffice {\n");

            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as UserActivityOutOfOffice);
        }

        /// <summary>
        /// Returns true if UserActivityOutOfOffice instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActivityOutOfOffice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActivityOutOfOffice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                return hash;
            }
        }
    }

}
