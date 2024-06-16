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
    /// StaCategory
    /// </summary>
    [DataContract]
    public partial class StaCategory :  IEquatable<StaCategory>
    {
        /// <summary>
        /// The type of interaction the category will apply to
        /// </summary>
        /// <value>The type of interaction the category will apply to</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InteractionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Voice for "Voice"
            /// </summary>
            [EnumMember(Value = "Voice")]
            Voice,
            
            /// <summary>
            /// Enum Digital for "Digital"
            /// </summary>
            [EnumMember(Value = "Digital")]
            Digital,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All
        }
        /// <summary>
        /// The type of interaction the category will apply to
        /// </summary>
        /// <value>The type of interaction the category will apply to</value>
        [DataMember(Name="interactionType", EmitDefaultValue=false)]
        public InteractionTypeEnum? InteractionType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaCategory" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">The description of the category.</param>
        /// <param name="InteractionType">The type of interaction the category will apply to (required).</param>
        /// <param name="Criteria">A collection of conditions joined together by logical operation to provide more refined filtering of conversations (required).</param>
        /// <param name="CreatedBy">The user who created the record.</param>
        /// <param name="DateCreated">The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">The user who last modified the record.</param>
        /// <param name="DateModified">The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public StaCategory(string Name = null, string Description = null, InteractionTypeEnum? InteractionType = null, Operand Criteria = null, AddressableEntityRef CreatedBy = null, DateTime? DateCreated = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.InteractionType = InteractionType;
            this.Criteria = Criteria;
            this.CreatedBy = CreatedBy;
            this.DateCreated = DateCreated;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the category
        /// </summary>
        /// <value>The description of the category</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// A collection of conditions joined together by logical operation to provide more refined filtering of conversations
        /// </summary>
        /// <value>A collection of conditions joined together by logical operation to provide more refined filtering of conversations</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public Operand Criteria { get; set; }



        /// <summary>
        /// The user who created the record
        /// </summary>
        /// <value>The user who created the record</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public AddressableEntityRef CreatedBy { get; set; }



        /// <summary>
        /// The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The creation date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The user who last modified the record
        /// </summary>
        /// <value>The user who last modified the record</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public AddressableEntityRef ModifiedBy { get; set; }



        /// <summary>
        /// The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The last modified date of the record. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



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
            sb.Append("class StaCategory {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as StaCategory);
        }

        /// <summary>
        /// Returns true if StaCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of StaCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaCategory other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.InteractionType == other.InteractionType ||
                    this.InteractionType != null &&
                    this.InteractionType.Equals(other.InteractionType)
                ) &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.Equals(other.Criteria)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.InteractionType != null)
                    hash = hash * 59 + this.InteractionType.GetHashCode();

                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
