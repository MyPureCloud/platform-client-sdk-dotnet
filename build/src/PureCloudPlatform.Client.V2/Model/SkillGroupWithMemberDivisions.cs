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
    /// SkillGroupWithMemberDivisions
    /// </summary>
    [DataContract]
    public partial class SkillGroupWithMemberDivisions :  IEquatable<SkillGroupWithMemberDivisions>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillGroupWithMemberDivisions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SkillGroupWithMemberDivisions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillGroupWithMemberDivisions" /> class.
        /// </summary>
        /// <param name="Name">The group name. (required).</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Description">Group description.</param>
        /// <param name="SkillConditions">Conditions for this group (required).</param>
        /// <param name="MemberDivisions">Member divisions for this skill group.</param>
        public SkillGroupWithMemberDivisions(string Name = null, WritableDivision Division = null, string Description = null, List<SkillGroupCondition> SkillConditions = null, List<string> MemberDivisions = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.SkillConditions = SkillConditions;
            this.MemberDivisions = MemberDivisions;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The group name.
        /// </summary>
        /// <value>The group name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableDivision Division { get; set; }



        /// <summary>
        /// Group description
        /// </summary>
        /// <value>Group description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Estimated number of members in this group. It can take some time for the count to be updated after expressions are changed.
        /// </summary>
        /// <value>Estimated number of members in this group. It can take some time for the count to be updated after expressions are changed.</value>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public long? MemberCount { get; private set; }



        /// <summary>
        /// Last modified date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Created date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Created date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Conditions for this group
        /// </summary>
        /// <value>Conditions for this group</value>
        [DataMember(Name="skillConditions", EmitDefaultValue=false)]
        public List<SkillGroupCondition> SkillConditions { get; set; }



        /// <summary>
        /// Member divisions for this skill group
        /// </summary>
        /// <value>Member divisions for this skill group</value>
        [DataMember(Name="memberDivisions", EmitDefaultValue=false)]
        public List<string> MemberDivisions { get; set; }



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
            sb.Append("class SkillGroupWithMemberDivisions {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  SkillConditions: ").Append(SkillConditions).Append("\n");
            sb.Append("  MemberDivisions: ").Append(MemberDivisions).Append("\n");
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
            return this.Equals(obj as SkillGroupWithMemberDivisions);
        }

        /// <summary>
        /// Returns true if SkillGroupWithMemberDivisions instances are equal
        /// </summary>
        /// <param name="other">Instance of SkillGroupWithMemberDivisions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkillGroupWithMemberDivisions other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.SkillConditions == other.SkillConditions ||
                    this.SkillConditions != null &&
                    this.SkillConditions.SequenceEqual(other.SkillConditions)
                ) &&
                (
                    this.MemberDivisions == other.MemberDivisions ||
                    this.MemberDivisions != null &&
                    this.MemberDivisions.SequenceEqual(other.MemberDivisions)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.SkillConditions != null)
                    hash = hash * 59 + this.SkillConditions.GetHashCode();

                if (this.MemberDivisions != null)
                    hash = hash * 59 + this.MemberDivisions.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
