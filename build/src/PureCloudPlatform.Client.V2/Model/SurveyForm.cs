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
    /// SurveyForm
    /// </summary>
    [DataContract]
    public partial class SurveyForm :  IEquatable<SurveyForm>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyForm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SurveyForm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyForm" /> class.
        /// </summary>
        /// <param name="Name">The survey form name (required).</param>
        /// <param name="Disabled">Is this form disabled.</param>
        /// <param name="Language">Language for survey viewer localization. Currently localized languages: da, de, en-US, es, fi, fr, it, ja, ko, nl, no, pl, pt-BR, sv, th, tr, zh-CH, zh-TW (required).</param>
        /// <param name="Header">Markdown text for the top of the form..</param>
        /// <param name="Footer">Markdown text for the bottom of the form..</param>
        /// <param name="QuestionGroups">A list of question groups (required).</param>
        public SurveyForm(string Name = null, bool? Disabled = null, string Language = null, string Header = null, string Footer = null, List<SurveyQuestionGroup> QuestionGroups = null)
        {
            this.Name = Name;
            this.Disabled = Disabled;
            this.Language = Language;
            this.Header = Header;
            this.Footer = Footer;
            this.QuestionGroups = QuestionGroups;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The survey form name
        /// </summary>
        /// <value>The survey form name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }



        /// <summary>
        /// Is this form published
        /// </summary>
        /// <value>Is this form published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; private set; }



        /// <summary>
        /// Is this form disabled
        /// </summary>
        /// <value>Is this form disabled</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool? Disabled { get; set; }



        /// <summary>
        /// Unique Id for all versions of this form
        /// </summary>
        /// <value>Unique Id for all versions of this form</value>
        [DataMember(Name="contextId", EmitDefaultValue=false)]
        public string ContextId { get; private set; }



        /// <summary>
        /// Language for survey viewer localization. Currently localized languages: da, de, en-US, es, fi, fr, it, ja, ko, nl, no, pl, pt-BR, sv, th, tr, zh-CH, zh-TW
        /// </summary>
        /// <value>Language for survey viewer localization. Currently localized languages: da, de, en-US, es, fi, fr, it, ja, ko, nl, no, pl, pt-BR, sv, th, tr, zh-CH, zh-TW</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Markdown text for the top of the form.
        /// </summary>
        /// <value>Markdown text for the top of the form.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public string Header { get; set; }



        /// <summary>
        /// Markdown text for the bottom of the form.
        /// </summary>
        /// <value>Markdown text for the bottom of the form.</value>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public string Footer { get; set; }



        /// <summary>
        /// A list of question groups
        /// </summary>
        /// <value>A list of question groups</value>
        [DataMember(Name="questionGroups", EmitDefaultValue=false)]
        public List<SurveyQuestionGroup> QuestionGroups { get; set; }



        /// <summary>
        /// List of published version of this form
        /// </summary>
        /// <value>List of published version of this form</value>
        [DataMember(Name="publishedVersions", EmitDefaultValue=false)]
        public DomainEntityListingSurveyForm PublishedVersions { get; private set; }



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
            sb.Append("class SurveyForm {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  ContextId: ").Append(ContextId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
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
            return this.Equals(obj as SurveyForm);
        }

        /// <summary>
        /// Returns true if SurveyForm instances are equal
        /// </summary>
        /// <param name="other">Instance of SurveyForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurveyForm other)
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
                    this.Disabled == other.Disabled ||
                    this.Disabled != null &&
                    this.Disabled.Equals(other.Disabled)
                ) &&
                (
                    this.ContextId == other.ContextId ||
                    this.ContextId != null &&
                    this.ContextId.Equals(other.ContextId)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.Equals(other.Header)
                ) &&
                (
                    this.Footer == other.Footer ||
                    this.Footer != null &&
                    this.Footer.Equals(other.Footer)
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

                if (this.Disabled != null)
                    hash = hash * 59 + this.Disabled.GetHashCode();

                if (this.ContextId != null)
                    hash = hash * 59 + this.ContextId.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.Footer != null)
                    hash = hash * 59 + this.Footer.GetHashCode();

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
