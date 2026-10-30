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
    /// OrgSettings
    /// </summary>
    [DataContract]
    public partial class OrgSettings :  IEquatable<OrgSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgSettings" /> class.
        /// </summary>
        /// <param name="ContentSearchEnabled">If true, enables full-text search of interaction transcripts.</param>
        /// <param name="UseDivisionedPermissions">If true, the results of searches for users are restricted to the divisions the user has directory:user:view permissions in.</param>
        public OrgSettings(bool? ContentSearchEnabled = null, bool? UseDivisionedPermissions = null)
        {
            this.ContentSearchEnabled = ContentSearchEnabled;
            this.UseDivisionedPermissions = UseDivisionedPermissions;
            
        }
        


        /// <summary>
        /// If true, enables full-text search of interaction transcripts
        /// </summary>
        /// <value>If true, enables full-text search of interaction transcripts</value>
        [DataMember(Name="contentSearchEnabled", EmitDefaultValue=false)]
        public bool? ContentSearchEnabled { get; set; }



        /// <summary>
        /// If true, the results of searches for users are restricted to the divisions the user has directory:user:view permissions in
        /// </summary>
        /// <value>If true, the results of searches for users are restricted to the divisions the user has directory:user:view permissions in</value>
        [DataMember(Name="useDivisionedPermissions", EmitDefaultValue=false)]
        public bool? UseDivisionedPermissions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgSettings {\n");

            sb.Append("  ContentSearchEnabled: ").Append(ContentSearchEnabled).Append("\n");
            sb.Append("  UseDivisionedPermissions: ").Append(UseDivisionedPermissions).Append("\n");
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
            return this.Equals(obj as OrgSettings);
        }

        /// <summary>
        /// Returns true if OrgSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentSearchEnabled == other.ContentSearchEnabled ||
                    this.ContentSearchEnabled != null &&
                    this.ContentSearchEnabled.Equals(other.ContentSearchEnabled)
                ) &&
                (
                    this.UseDivisionedPermissions == other.UseDivisionedPermissions ||
                    this.UseDivisionedPermissions != null &&
                    this.UseDivisionedPermissions.Equals(other.UseDivisionedPermissions)
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
                if (this.ContentSearchEnabled != null)
                    hash = hash * 59 + this.ContentSearchEnabled.GetHashCode();

                if (this.UseDivisionedPermissions != null)
                    hash = hash * 59 + this.UseDivisionedPermissions.GetHashCode();

                return hash;
            }
        }
    }

}
