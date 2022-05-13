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
    /// Relationship
    /// </summary>
    [DataContract]
    public partial class Relationship :  IEquatable<Relationship>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Relationship() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class.
        /// </summary>
        /// <param name="User">The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note. (required).</param>
        /// <param name="ExternalOrganization">The external organization this relationship is attached to (required).</param>
        /// <param name="_Relationship">The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant (required).</param>
        public Relationship(User User = null, ExternalOrganization ExternalOrganization = null, string _Relationship = null)
        {
            this.User = User;
            this.ExternalOrganization = ExternalOrganization;
            this._Relationship = _Relationship;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note.
        /// </summary>
        /// <value>The user associated with the external organization. When creating or updating a relationship, only User.id is required. User object is fully populated when expanding a note.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }



        /// <summary>
        /// The external organization this relationship is attached to
        /// </summary>
        /// <value>The external organization this relationship is attached to</value>
        [DataMember(Name="externalOrganization", EmitDefaultValue=false)]
        public ExternalOrganization ExternalOrganization { get; set; }



        /// <summary>
        /// The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant
        /// </summary>
        /// <value>The relationship or role of the user to this external organization.Examples: Account Manager, Sales Engineer, Implementation Consultant</value>
        [DataMember(Name="relationship", EmitDefaultValue=false)]
        public string _Relationship { get; set; }



        /// <summary>
        /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
        /// </summary>
        /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
        [DataMember(Name="externalDataSources", EmitDefaultValue=false)]
        public List<ExternalDataSource> ExternalDataSources { get; private set; }



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
            sb.Append("class Relationship {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            sb.Append("  _Relationship: ").Append(_Relationship).Append("\n");
            sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
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
            return this.Equals(obj as Relationship);
        }

        /// <summary>
        /// Returns true if Relationship instances are equal
        /// </summary>
        /// <param name="other">Instance of Relationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Relationship other)
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
                    this._Relationship == other._Relationship ||
                    this._Relationship != null &&
                    this._Relationship.Equals(other._Relationship)
                ) &&
                (
                    this.ExternalDataSources == other.ExternalDataSources ||
                    this.ExternalDataSources != null &&
                    this.ExternalDataSources.SequenceEqual(other.ExternalDataSources)
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

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.ExternalOrganization != null)
                    hash = hash * 59 + this.ExternalOrganization.GetHashCode();

                if (this._Relationship != null)
                    hash = hash * 59 + this._Relationship.GetHashCode();

                if (this.ExternalDataSources != null)
                    hash = hash * 59 + this.ExternalDataSources.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
