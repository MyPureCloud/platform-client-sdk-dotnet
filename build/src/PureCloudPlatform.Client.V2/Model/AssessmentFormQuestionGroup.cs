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
    /// AssessmentFormQuestionGroup
    /// </summary>
    [DataContract]
    public partial class AssessmentFormQuestionGroup :  IEquatable<AssessmentFormQuestionGroup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentFormQuestionGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssessmentFormQuestionGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentFormQuestionGroup" /> class.
        /// </summary>
        /// <param name="Id">The ID of the question group,.</param>
        /// <param name="Name">The question group name (required).</param>
        /// <param name="Type">The question group type (required).</param>
        /// <param name="DefaultAnswersToHighest">DefaultAnswersToHighest.</param>
        /// <param name="DefaultAnswersToNA">DefaultAnswersToNA.</param>
        /// <param name="NaEnabled">NaEnabled.</param>
        /// <param name="Weight">Weight.</param>
        /// <param name="ManualWeight">ManualWeight.</param>
        /// <param name="Questions">The list of questions for this question group (required).</param>
        /// <param name="VisibilityCondition">VisibilityCondition.</param>
        public AssessmentFormQuestionGroup(string Id = null, string Name = null, string Type = null, bool? DefaultAnswersToHighest = null, bool? DefaultAnswersToNA = null, bool? NaEnabled = null, float? Weight = null, bool? ManualWeight = null, List<AssessmentFormQuestion> Questions = null, VisibilityCondition VisibilityCondition = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.DefaultAnswersToHighest = DefaultAnswersToHighest;
            this.DefaultAnswersToNA = DefaultAnswersToNA;
            this.NaEnabled = NaEnabled;
            this.Weight = Weight;
            this.ManualWeight = ManualWeight;
            this.Questions = Questions;
            this.VisibilityCondition = VisibilityCondition;
            
        }
        


        /// <summary>
        /// The ID of the question group,
        /// </summary>
        /// <value>The ID of the question group,</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The question group name
        /// </summary>
        /// <value>The question group name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The question group type
        /// </summary>
        /// <value>The question group type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// An identifier for this question group that stays the same across versions of the form.
        /// </summary>
        /// <value>An identifier for this question group that stays the same across versions of the form.</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; private set; }



        /// <summary>
        /// Gets or Sets DefaultAnswersToHighest
        /// </summary>
        [DataMember(Name="defaultAnswersToHighest", EmitDefaultValue=false)]
        public bool? DefaultAnswersToHighest { get; set; }



        /// <summary>
        /// Gets or Sets DefaultAnswersToNA
        /// </summary>
        [DataMember(Name="defaultAnswersToNA", EmitDefaultValue=false)]
        public bool? DefaultAnswersToNA { get; set; }



        /// <summary>
        /// Gets or Sets NaEnabled
        /// </summary>
        [DataMember(Name="naEnabled", EmitDefaultValue=false)]
        public bool? NaEnabled { get; set; }



        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public float? Weight { get; set; }



        /// <summary>
        /// Gets or Sets ManualWeight
        /// </summary>
        [DataMember(Name="manualWeight", EmitDefaultValue=false)]
        public bool? ManualWeight { get; set; }



        /// <summary>
        /// The list of questions for this question group
        /// </summary>
        /// <value>The list of questions for this question group</value>
        [DataMember(Name="questions", EmitDefaultValue=false)]
        public List<AssessmentFormQuestion> Questions { get; set; }



        /// <summary>
        /// Gets or Sets VisibilityCondition
        /// </summary>
        [DataMember(Name="visibilityCondition", EmitDefaultValue=false)]
        public VisibilityCondition VisibilityCondition { get; set; }



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
            sb.Append("class AssessmentFormQuestionGroup {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  DefaultAnswersToHighest: ").Append(DefaultAnswersToHighest).Append("\n");
            sb.Append("  DefaultAnswersToNA: ").Append(DefaultAnswersToNA).Append("\n");
            sb.Append("  NaEnabled: ").Append(NaEnabled).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  ManualWeight: ").Append(ManualWeight).Append("\n");
            sb.Append("  Questions: ").Append(Questions).Append("\n");
            sb.Append("  VisibilityCondition: ").Append(VisibilityCondition).Append("\n");
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
            return this.Equals(obj as AssessmentFormQuestionGroup);
        }

        /// <summary>
        /// Returns true if AssessmentFormQuestionGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of AssessmentFormQuestionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssessmentFormQuestionGroup other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.DefaultAnswersToHighest == other.DefaultAnswersToHighest ||
                    this.DefaultAnswersToHighest != null &&
                    this.DefaultAnswersToHighest.Equals(other.DefaultAnswersToHighest)
                ) &&
                (
                    this.DefaultAnswersToNA == other.DefaultAnswersToNA ||
                    this.DefaultAnswersToNA != null &&
                    this.DefaultAnswersToNA.Equals(other.DefaultAnswersToNA)
                ) &&
                (
                    this.NaEnabled == other.NaEnabled ||
                    this.NaEnabled != null &&
                    this.NaEnabled.Equals(other.NaEnabled)
                ) &&
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) &&
                (
                    this.ManualWeight == other.ManualWeight ||
                    this.ManualWeight != null &&
                    this.ManualWeight.Equals(other.ManualWeight)
                ) &&
                (
                    this.Questions == other.Questions ||
                    this.Questions != null &&
                    this.Questions.SequenceEqual(other.Questions)
                ) &&
                (
                    this.VisibilityCondition == other.VisibilityCondition ||
                    this.VisibilityCondition != null &&
                    this.VisibilityCondition.Equals(other.VisibilityCondition)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();

                if (this.DefaultAnswersToHighest != null)
                    hash = hash * 59 + this.DefaultAnswersToHighest.GetHashCode();

                if (this.DefaultAnswersToNA != null)
                    hash = hash * 59 + this.DefaultAnswersToNA.GetHashCode();

                if (this.NaEnabled != null)
                    hash = hash * 59 + this.NaEnabled.GetHashCode();

                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();

                if (this.ManualWeight != null)
                    hash = hash * 59 + this.ManualWeight.GetHashCode();

                if (this.Questions != null)
                    hash = hash * 59 + this.Questions.GetHashCode();

                if (this.VisibilityCondition != null)
                    hash = hash * 59 + this.VisibilityCondition.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
