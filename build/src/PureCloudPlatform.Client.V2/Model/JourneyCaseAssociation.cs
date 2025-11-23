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
    /// The representation of a case association on a journey session.
    /// </summary>
    [DataContract]
    public partial class JourneyCaseAssociation :  IEquatable<JourneyCaseAssociation>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyCaseAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyCaseAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyCaseAssociation" /> class.
        /// </summary>
        /// <param name="Id">The ID of the association. (required).</param>
        /// <param name="AssociatedCase">The case that was associated with the journey session..</param>
        /// <param name="CaseReference">The reference for the case that was associated with the journey session..</param>
        /// <param name="DateAssociated">The date of the association. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public JourneyCaseAssociation(string Id = null, AddressableEntityRef AssociatedCase = null, string CaseReference = null, DateTime? DateAssociated = null)
        {
            this.Id = Id;
            this.AssociatedCase = AssociatedCase;
            this.CaseReference = CaseReference;
            this.DateAssociated = DateAssociated;
            
        }
        


        /// <summary>
        /// The ID of the association.
        /// </summary>
        /// <value>The ID of the association.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The case that was associated with the journey session.
        /// </summary>
        /// <value>The case that was associated with the journey session.</value>
        [DataMember(Name="associatedCase", EmitDefaultValue=false)]
        public AddressableEntityRef AssociatedCase { get; set; }



        /// <summary>
        /// The reference for the case that was associated with the journey session.
        /// </summary>
        /// <value>The reference for the case that was associated with the journey session.</value>
        [DataMember(Name="caseReference", EmitDefaultValue=false)]
        public string CaseReference { get; set; }



        /// <summary>
        /// The date of the association. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the association. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateAssociated", EmitDefaultValue=false)]
        public DateTime? DateAssociated { get; set; }



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
            sb.Append("class JourneyCaseAssociation {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssociatedCase: ").Append(AssociatedCase).Append("\n");
            sb.Append("  CaseReference: ").Append(CaseReference).Append("\n");
            sb.Append("  DateAssociated: ").Append(DateAssociated).Append("\n");
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
            return this.Equals(obj as JourneyCaseAssociation);
        }

        /// <summary>
        /// Returns true if JourneyCaseAssociation instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyCaseAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyCaseAssociation other)
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
                    this.AssociatedCase == other.AssociatedCase ||
                    this.AssociatedCase != null &&
                    this.AssociatedCase.Equals(other.AssociatedCase)
                ) &&
                (
                    this.CaseReference == other.CaseReference ||
                    this.CaseReference != null &&
                    this.CaseReference.Equals(other.CaseReference)
                ) &&
                (
                    this.DateAssociated == other.DateAssociated ||
                    this.DateAssociated != null &&
                    this.DateAssociated.Equals(other.DateAssociated)
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

                if (this.AssociatedCase != null)
                    hash = hash * 59 + this.AssociatedCase.GetHashCode();

                if (this.CaseReference != null)
                    hash = hash * 59 + this.CaseReference.GetHashCode();

                if (this.DateAssociated != null)
                    hash = hash * 59 + this.DateAssociated.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
