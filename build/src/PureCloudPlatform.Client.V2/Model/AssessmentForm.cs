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
    /// AssessmentForm
    /// </summary>
    [DataContract]
    public partial class AssessmentForm :  IEquatable<AssessmentForm>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssessmentForm() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentForm" /> class.
        /// </summary>
        /// <param name="PassPercent">The pass percent for the assessment form (required).</param>
        /// <param name="QuestionGroups">A list of question groups (required).</param>
        public AssessmentForm(int? PassPercent = null, List<AssessmentFormQuestionGroup> QuestionGroups = null)
        {
            this.PassPercent = PassPercent;
            this.QuestionGroups = QuestionGroups;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Last modified date of the assessment form. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified date of the assessment form. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// The unique Id for all versions of this assessment form
        /// </summary>
        /// <value>The unique Id for all versions of this assessment form</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; private set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// If true, assessment form is published
        /// </summary>
        /// <value>If true, assessment form is published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; private set; }
        
        
        
        /// <summary>
        /// The pass percent for the assessment form
        /// </summary>
        /// <value>The pass percent for the assessment form</value>
        [DataMember(Name="passPercent", EmitDefaultValue=false)]
        public int? PassPercent { get; set; }
        
        
        
        /// <summary>
        /// A list of question groups
        /// </summary>
        /// <value>A list of question groups</value>
        [DataMember(Name="questionGroups", EmitDefaultValue=false)]
        public List<AssessmentFormQuestionGroup> QuestionGroups { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssessmentForm {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  PassPercent: ").Append(PassPercent).Append("\n");
            sb.Append("  QuestionGroups: ").Append(QuestionGroups).Append("\n");
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
            return this.Equals(obj as AssessmentForm);
        }

        /// <summary>
        /// Returns true if AssessmentForm instances are equal
        /// </summary>
        /// <param name="other">Instance of AssessmentForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssessmentForm other)
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
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.PassPercent == other.PassPercent ||
                    this.PassPercent != null &&
                    this.PassPercent.Equals(other.PassPercent)
                ) &&
                (
                    this.QuestionGroups == other.QuestionGroups ||
                    this.QuestionGroups != null &&
                    this.QuestionGroups.SequenceEqual(other.QuestionGroups)
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
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();
                
                if (this.PassPercent != null)
                    hash = hash * 59 + this.PassPercent.GetHashCode();
                
                if (this.QuestionGroups != null)
                    hash = hash * 59 + this.QuestionGroups.GetHashCode();
                
                return hash;
            }
        }
    }

}
