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
    /// EvaluationForm
    /// </summary>
    [DataContract]
    public partial class EvaluationForm :  IEquatable<EvaluationForm>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EvaluationForm() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationForm" /> class.
        /// </summary>
        /// <param name="Name">The evaluation form name (required).</param>
        /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Published">Published.</param>
        /// <param name="ContextId">ContextId.</param>
        /// <param name="QuestionGroups">A list of question groups (required).</param>
        /// <param name="PublishedVersions">PublishedVersions.</param>
        public EvaluationForm(string Name = null, DateTime? ModifiedDate = null, bool? Published = null, string ContextId = null, List<EvaluationQuestionGroup> QuestionGroups = null, DomainEntityListingEvaluationForm PublishedVersions = null)
        {
            this.Name = Name;
            this.ModifiedDate = ModifiedDate;
            this.Published = Published;
            this.ContextId = ContextId;
            this.QuestionGroups = QuestionGroups;
            this.PublishedVersions = PublishedVersions;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The evaluation form name
        /// </summary>
        /// <value>The evaluation form name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContextId
        /// </summary>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; set; }
        
        
        
        /// <summary>
        /// A list of question groups
        /// </summary>
        /// <value>A list of question groups</value>
        [DataMember(Name="questionGroups", EmitDefaultValue=false)]
        public List<EvaluationQuestionGroup> QuestionGroups { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PublishedVersions
        /// </summary>
        [DataMember(Name="publishedVersions", EmitDefaultValue=false)]
        public DomainEntityListingEvaluationForm PublishedVersions { get; set; }
        
        
        
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
            sb.Append("class EvaluationForm {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  QuestionGroups: ").Append(QuestionGroups).Append("\n");
            sb.Append("  PublishedVersions: ").Append(PublishedVersions).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EvaluationForm);
        }

        /// <summary>
        /// Returns true if EvaluationForm instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationForm other)
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
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.QuestionGroups == other.QuestionGroups ||
                    this.QuestionGroups != null &&
                    this.QuestionGroups.SequenceEqual(other.QuestionGroups)
                ) &&
                (
                    this.PublishedVersions == other.PublishedVersions ||
                    this.PublishedVersions != null &&
                    this.PublishedVersions.Equals(other.PublishedVersions)
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
                
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                
                if (this.QuestionGroups != null)
                    hash = hash * 59 + this.QuestionGroups.GetHashCode();
                
                if (this.PublishedVersions != null)
                    hash = hash * 59 + this.PublishedVersions.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
