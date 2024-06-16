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
    /// Learning module preview get response
    /// </summary>
    [DataContract]
    public partial class LearningModulePreviewGetResponse :  IEquatable<LearningModulePreviewGetResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModulePreviewGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningModulePreviewGetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningModulePreviewGetResponse" /> class.
        /// </summary>
        /// <param name="Name">The name of learning module (required).</param>
        /// <param name="Description">The description of learning module.</param>
        /// <param name="CoverArt">The cover art for the learning module.</param>
        /// <param name="EnforceContentOrder">If true, learning module content should be viewed one by one in order.</param>
        /// <param name="ReviewAssessmentResults">Allows to view Assessment results in detail.</param>
        /// <param name="AssessmentForm">The assessment form for learning module.</param>
        /// <param name="Assignment">the assignment preview.</param>
        public LearningModulePreviewGetResponse(string Name = null, string Description = null, LearningModuleCoverArtResponse CoverArt = null, bool? EnforceContentOrder = null, ReviewAssessmentResults ReviewAssessmentResults = null, AssessmentForm AssessmentForm = null, LearningModulePreviewGetResponseAssignment Assignment = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.CoverArt = CoverArt;
            this.EnforceContentOrder = EnforceContentOrder;
            this.ReviewAssessmentResults = ReviewAssessmentResults;
            this.AssessmentForm = AssessmentForm;
            this.Assignment = Assignment;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of learning module
        /// </summary>
        /// <value>The name of learning module</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of learning module
        /// </summary>
        /// <value>The description of learning module</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The cover art for the learning module
        /// </summary>
        /// <value>The cover art for the learning module</value>
        [DataMember(Name="coverArt", EmitDefaultValue=false)]
        public LearningModuleCoverArtResponse CoverArt { get; set; }



        /// <summary>
        /// If true, learning module content should be viewed one by one in order
        /// </summary>
        /// <value>If true, learning module content should be viewed one by one in order</value>
        [DataMember(Name="enforceContentOrder", EmitDefaultValue=false)]
        public bool? EnforceContentOrder { get; set; }



        /// <summary>
        /// Allows to view Assessment results in detail
        /// </summary>
        /// <value>Allows to view Assessment results in detail</value>
        [DataMember(Name="reviewAssessmentResults", EmitDefaultValue=false)]
        public ReviewAssessmentResults ReviewAssessmentResults { get; set; }



        /// <summary>
        /// The assessment form for learning module
        /// </summary>
        /// <value>The assessment form for learning module</value>
        [DataMember(Name="assessmentForm", EmitDefaultValue=false)]
        public AssessmentForm AssessmentForm { get; set; }



        /// <summary>
        /// the assignment preview
        /// </summary>
        /// <value>the assignment preview</value>
        [DataMember(Name="assignment", EmitDefaultValue=false)]
        public LearningModulePreviewGetResponseAssignment Assignment { get; set; }



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
            sb.Append("class LearningModulePreviewGetResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CoverArt: ").Append(CoverArt).Append("\n");
            sb.Append("  EnforceContentOrder: ").Append(EnforceContentOrder).Append("\n");
            sb.Append("  ReviewAssessmentResults: ").Append(ReviewAssessmentResults).Append("\n");
            sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
            sb.Append("  Assignment: ").Append(Assignment).Append("\n");
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
            return this.Equals(obj as LearningModulePreviewGetResponse);
        }

        /// <summary>
        /// Returns true if LearningModulePreviewGetResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningModulePreviewGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningModulePreviewGetResponse other)
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
                    this.CoverArt == other.CoverArt ||
                    this.CoverArt != null &&
                    this.CoverArt.Equals(other.CoverArt)
                ) &&
                (
                    this.EnforceContentOrder == other.EnforceContentOrder ||
                    this.EnforceContentOrder != null &&
                    this.EnforceContentOrder.Equals(other.EnforceContentOrder)
                ) &&
                (
                    this.ReviewAssessmentResults == other.ReviewAssessmentResults ||
                    this.ReviewAssessmentResults != null &&
                    this.ReviewAssessmentResults.Equals(other.ReviewAssessmentResults)
                ) &&
                (
                    this.AssessmentForm == other.AssessmentForm ||
                    this.AssessmentForm != null &&
                    this.AssessmentForm.Equals(other.AssessmentForm)
                ) &&
                (
                    this.Assignment == other.Assignment ||
                    this.Assignment != null &&
                    this.Assignment.Equals(other.Assignment)
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

                if (this.CoverArt != null)
                    hash = hash * 59 + this.CoverArt.GetHashCode();

                if (this.EnforceContentOrder != null)
                    hash = hash * 59 + this.EnforceContentOrder.GetHashCode();

                if (this.ReviewAssessmentResults != null)
                    hash = hash * 59 + this.ReviewAssessmentResults.GetHashCode();

                if (this.AssessmentForm != null)
                    hash = hash * 59 + this.AssessmentForm.GetHashCode();

                if (this.Assignment != null)
                    hash = hash * 59 + this.Assignment.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
