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
    /// OtherProfileAssignment
    /// </summary>
    [DataContract]
    public partial class OtherProfileAssignment :  IEquatable<OtherProfileAssignment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OtherProfileAssignment" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="CurrentProfile">The current performance profile that this user belongs to.</param>
        public OtherProfileAssignment(string Id = null, DomainEntityRef CurrentProfile = null)
        {
            this.Id = Id;
            this.CurrentProfile = CurrentProfile;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The current performance profile that this user belongs to
        /// </summary>
        /// <value>The current performance profile that this user belongs to</value>
        [DataMember(Name="currentProfile", EmitDefaultValue=false)]
        public DomainEntityRef CurrentProfile { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OtherProfileAssignment {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CurrentProfile: ").Append(CurrentProfile).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as OtherProfileAssignment);
        }

        /// <summary>
        /// Returns true if OtherProfileAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of OtherProfileAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OtherProfileAssignment other)
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
                    this.CurrentProfile == other.CurrentProfile ||
                    this.CurrentProfile != null &&
                    this.CurrentProfile.Equals(other.CurrentProfile)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.CurrentProfile != null)
                    hash = hash * 59 + this.CurrentProfile.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
