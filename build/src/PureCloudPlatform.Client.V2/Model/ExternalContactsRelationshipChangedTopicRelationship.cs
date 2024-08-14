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
    /// ExternalContactsRelationshipChangedTopicRelationship
    /// </summary>
    [DataContract]
    public partial class ExternalContactsRelationshipChangedTopicRelationship :  IEquatable<ExternalContactsRelationshipChangedTopicRelationship>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsRelationshipChangedTopicRelationship" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Division">Division.</param>
        /// <param name="User">User.</param>
        /// <param name="ExternalOrganization">ExternalOrganization.</param>
        /// <param name="Relationship">Relationship.</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        public ExternalContactsRelationshipChangedTopicRelationship(string Id = null, ExternalContactsRelationshipChangedTopicDivision Division = null, ExternalContactsRelationshipChangedTopicUser User = null, ExternalContactsRelationshipChangedTopicExternalOrganization ExternalOrganization = null, string Relationship = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
        {
            this.Id = Id;
            this.Division = Division;
            this.User = User;
            this.ExternalOrganization = ExternalOrganization;
            this.Relationship = Relationship;
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public ExternalContactsRelationshipChangedTopicDivision Division { get; set; }



        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public ExternalContactsRelationshipChangedTopicUser User { get; set; }



        /// <summary>
        /// Gets or Sets ExternalOrganization
        /// </summary>
        [DataMember(Name="externalOrganization", EmitDefaultValue=false)]
        public ExternalContactsRelationshipChangedTopicExternalOrganization ExternalOrganization { get; set; }



        /// <summary>
        /// Gets or Sets Relationship
        /// </summary>
        [DataMember(Name="relationship", EmitDefaultValue=false)]
        public string Relationship { get; set; }



        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }



        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsRelationshipChangedTopicRelationship {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
            return this.Equals(obj as ExternalContactsRelationshipChangedTopicRelationship);
        }

        /// <summary>
        /// Returns true if ExternalContactsRelationshipChangedTopicRelationship instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsRelationshipChangedTopicRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsRelationshipChangedTopicRelationship other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.ExternalOrganization == other.ExternalOrganization ||
                    this.ExternalOrganization != null &&
                    this.ExternalOrganization.Equals(other.ExternalOrganization)
                ) &&
                (
                    this.Relationship == other.Relationship ||
                    this.Relationship != null &&
                    this.Relationship.Equals(other.Relationship)
                ) &&
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) &&
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.ExternalOrganization != null)
                    hash = hash * 59 + this.ExternalOrganization.GetHashCode();

                if (this.Relationship != null)
                    hash = hash * 59 + this.Relationship.GetHashCode();

                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();

                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();

                return hash;
            }
        }
    }

}
