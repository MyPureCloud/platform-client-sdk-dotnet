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
    /// ExternalPageMetadata
    /// </summary>
    [DataContract]
    public partial class ExternalPageMetadata :  IEquatable<ExternalPageMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPageMetadata" /> class.
        /// </summary>
        /// <param name="Name">The name of the external page.</param>
        /// <param name="ProfilePictureUrl">The profile picture URL of the external page.</param>
        public ExternalPageMetadata(string Name = null, string ProfilePictureUrl = null)
        {
            this.Name = Name;
            this.ProfilePictureUrl = ProfilePictureUrl;
            
        }
        


        /// <summary>
        /// The name of the external page
        /// </summary>
        /// <value>The name of the external page</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The profile picture URL of the external page
        /// </summary>
        /// <value>The profile picture URL of the external page</value>
        [DataMember(Name="profilePictureUrl", EmitDefaultValue=false)]
        public string ProfilePictureUrl { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalPageMetadata {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProfilePictureUrl: ").Append(ProfilePictureUrl).Append("\n");
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
            return this.Equals(obj as ExternalPageMetadata);
        }

        /// <summary>
        /// Returns true if ExternalPageMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalPageMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalPageMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ProfilePictureUrl == other.ProfilePictureUrl ||
                    this.ProfilePictureUrl != null &&
                    this.ProfilePictureUrl.Equals(other.ProfilePictureUrl)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ProfilePictureUrl != null)
                    hash = hash * 59 + this.ProfilePictureUrl.GetHashCode();

                return hash;
            }
        }
    }

}
