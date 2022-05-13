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
    /// ArchitectFlowNotificationHomeOrganization
    /// </summary>
    [DataContract]
    public partial class ArchitectFlowNotificationHomeOrganization :  IEquatable<ArchitectFlowNotificationHomeOrganization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchitectFlowNotificationHomeOrganization" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ThirdPartyOrgName">ThirdPartyOrgName.</param>
        public ArchitectFlowNotificationHomeOrganization(string Id = null, string Name = null, string ThirdPartyOrgName = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.ThirdPartyOrgName = ThirdPartyOrgName;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets ThirdPartyOrgName
        /// </summary>
        [DataMember(Name="thirdPartyOrgName", EmitDefaultValue=false)]
        public string ThirdPartyOrgName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchitectFlowNotificationHomeOrganization {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ThirdPartyOrgName: ").Append(ThirdPartyOrgName).Append("\n");
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
            return this.Equals(obj as ArchitectFlowNotificationHomeOrganization);
        }

        /// <summary>
        /// Returns true if ArchitectFlowNotificationHomeOrganization instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchitectFlowNotificationHomeOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchitectFlowNotificationHomeOrganization other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ThirdPartyOrgName == other.ThirdPartyOrgName ||
                    this.ThirdPartyOrgName != null &&
                    this.ThirdPartyOrgName.Equals(other.ThirdPartyOrgName)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ThirdPartyOrgName != null)
                    hash = hash * 59 + this.ThirdPartyOrgName.GetHashCode();

                return hash;
            }
        }
    }

}
