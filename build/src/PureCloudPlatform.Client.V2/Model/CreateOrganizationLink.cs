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
    /// CreateOrganizationLink
    /// </summary>
    [DataContract]
    public partial class CreateOrganizationLink :  IEquatable<CreateOrganizationLink>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrganizationLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationLink" /> class.
        /// </summary>
        /// <param name="TargetOrganizationId">Id for the linking organization. (required).</param>
        /// <param name="TargetRegion">Region where target organization is hosted. (required).</param>
        public CreateOrganizationLink(string TargetOrganizationId = null, string TargetRegion = null)
        {
            this.TargetOrganizationId = TargetOrganizationId;
            this.TargetRegion = TargetRegion;
            
        }
        


        /// <summary>
        /// Id for the linking organization.
        /// </summary>
        /// <value>Id for the linking organization.</value>
        [DataMember(Name="targetOrganizationId", EmitDefaultValue=false)]
        public string TargetOrganizationId { get; set; }



        /// <summary>
        /// Region where target organization is hosted.
        /// </summary>
        /// <value>Region where target organization is hosted.</value>
        [DataMember(Name="targetRegion", EmitDefaultValue=false)]
        public string TargetRegion { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrganizationLink {\n");

            sb.Append("  TargetOrganizationId: ").Append(TargetOrganizationId).Append("\n");
            sb.Append("  TargetRegion: ").Append(TargetRegion).Append("\n");
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
            return this.Equals(obj as CreateOrganizationLink);
        }

        /// <summary>
        /// Returns true if CreateOrganizationLink instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrganizationLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrganizationLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TargetOrganizationId == other.TargetOrganizationId ||
                    this.TargetOrganizationId != null &&
                    this.TargetOrganizationId.Equals(other.TargetOrganizationId)
                ) &&
                (
                    this.TargetRegion == other.TargetRegion ||
                    this.TargetRegion != null &&
                    this.TargetRegion.Equals(other.TargetRegion)
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
                if (this.TargetOrganizationId != null)
                    hash = hash * 59 + this.TargetOrganizationId.GetHashCode();

                if (this.TargetRegion != null)
                    hash = hash * 59 + this.TargetRegion.GetHashCode();

                return hash;
            }
        }
    }

}
