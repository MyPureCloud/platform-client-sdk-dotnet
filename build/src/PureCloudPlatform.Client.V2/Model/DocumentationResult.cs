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
    /// DocumentationResult
    /// </summary>
    [DataContract]
    public partial class DocumentationResult :  IEquatable<DocumentationResult>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentationResult() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentationResult" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Categories">The category of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Description">The description of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Content">The text or html content for the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Excerpt">The excerpt of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Link">URL link for the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Modified">The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Name">The name of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Service">The service of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Slug">The slug of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="Title">The title of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="GetType">The search type. Will be returned in responses for certain entities..</param>
        /// <param name="FacetFeature">The facet feature of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="FacetRole">The facet role of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="FacetService">The facet service of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="FaqCategories">The faq categories of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="ReleasenoteCategory">The releasenote category of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="ReleasenoteTag">The releasenote tag of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="ServiceArea">The service area of the documentation entity. Will be returned in responses for certain entities..</param>
        /// <param name="VideoCategories">The video categories of the documentation entity. Will be returned in responses for certain entities..</param>
        public DocumentationResult(int? Id = null, List<int?> Categories = null, string Description = null, string Content = null, string Excerpt = null, string Link = null, DateTime? Modified = null, string Name = null, List<int?> Service = null, string Slug = null, string Title = null, string GetType = null, List<int?> FacetFeature = null, List<int?> FacetRole = null, List<int?> FacetService = null, List<int?> FaqCategories = null, List<int?> ReleasenoteCategory = null, List<int?> ReleasenoteTag = null, List<int?> ServiceArea = null, List<int?> VideoCategories = null)
        {
            this.Id = Id;
            this.Categories = Categories;
            this.Description = Description;
            this.Content = Content;
            this.Excerpt = Excerpt;
            this.Link = Link;
            this.Modified = Modified;
            this.Name = Name;
            this.Service = Service;
            this.Slug = Slug;
            this.Title = Title;
            this.GetType = GetType;
            this.FacetFeature = FacetFeature;
            this.FacetRole = FacetRole;
            this.FacetService = FacetService;
            this.FaqCategories = FaqCategories;
            this.ReleasenoteCategory = ReleasenoteCategory;
            this.ReleasenoteTag = ReleasenoteTag;
            this.ServiceArea = ServiceArea;
            this.VideoCategories = VideoCategories;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        
        
        
        /// <summary>
        /// The category of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The category of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<int?> Categories { get; set; }
        
        
        
        /// <summary>
        /// The description of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The description of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The text or html content for the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The text or html content for the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        
        
        
        /// <summary>
        /// The excerpt of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The excerpt of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="excerpt", EmitDefaultValue=false)]
        public string Excerpt { get; set; }
        
        
        
        /// <summary>
        /// URL link for the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>URL link for the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }
        
        
        
        /// <summary>
        /// The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; set; }
        
        
        
        /// <summary>
        /// The name of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The name of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The service of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The service of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public List<int?> Service { get; set; }
        
        
        
        /// <summary>
        /// The slug of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The slug of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; set; }
        
        
        
        /// <summary>
        /// The title of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The title of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// The search type. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The search type. Will be returned in responses for certain entities.</value>
        [DataMember(Name="get_type", EmitDefaultValue=false)]
        public string GetType { get; set; }
        
        
        
        /// <summary>
        /// The facet feature of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The facet feature of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="facet_feature", EmitDefaultValue=false)]
        public List<int?> FacetFeature { get; set; }
        
        
        
        /// <summary>
        /// The facet role of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The facet role of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="facet_role", EmitDefaultValue=false)]
        public List<int?> FacetRole { get; set; }
        
        
        
        /// <summary>
        /// The facet service of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The facet service of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="facet_service", EmitDefaultValue=false)]
        public List<int?> FacetService { get; set; }
        
        
        
        /// <summary>
        /// The faq categories of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The faq categories of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="faq_categories", EmitDefaultValue=false)]
        public List<int?> FaqCategories { get; set; }
        
        
        
        /// <summary>
        /// The releasenote category of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The releasenote category of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="releasenote_category", EmitDefaultValue=false)]
        public List<int?> ReleasenoteCategory { get; set; }
        
        
        
        /// <summary>
        /// The releasenote tag of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The releasenote tag of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="releasenote_tag", EmitDefaultValue=false)]
        public List<int?> ReleasenoteTag { get; set; }
        
        
        
        /// <summary>
        /// The service area of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The service area of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="service-area", EmitDefaultValue=false)]
        public List<int?> ServiceArea { get; set; }
        
        
        
        /// <summary>
        /// The video categories of the documentation entity. Will be returned in responses for certain entities.
        /// </summary>
        /// <value>The video categories of the documentation entity. Will be returned in responses for certain entities.</value>
        [DataMember(Name="video_categories", EmitDefaultValue=false)]
        public List<int?> VideoCategories { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentationResult {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Excerpt: ").Append(Excerpt).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  GetType: ").Append(GetType).Append("\n");
            sb.Append("  FacetFeature: ").Append(FacetFeature).Append("\n");
            sb.Append("  FacetRole: ").Append(FacetRole).Append("\n");
            sb.Append("  FacetService: ").Append(FacetService).Append("\n");
            sb.Append("  FaqCategories: ").Append(FaqCategories).Append("\n");
            sb.Append("  ReleasenoteCategory: ").Append(ReleasenoteCategory).Append("\n");
            sb.Append("  ReleasenoteTag: ").Append(ReleasenoteTag).Append("\n");
            sb.Append("  ServiceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  VideoCategories: ").Append(VideoCategories).Append("\n");
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
            return this.Equals(obj as DocumentationResult);
        }

        /// <summary>
        /// Returns true if DocumentationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentationResult other)
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
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.Excerpt == other.Excerpt ||
                    this.Excerpt != null &&
                    this.Excerpt.Equals(other.Excerpt)
                ) &&
                (
                    this.Link == other.Link ||
                    this.Link != null &&
                    this.Link.Equals(other.Link)
                ) &&
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.SequenceEqual(other.Service)
                ) &&
                (
                    this.Slug == other.Slug ||
                    this.Slug != null &&
                    this.Slug.Equals(other.Slug)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.GetType == other.GetType ||
                    this.GetType != null &&
                    this.GetType.Equals(other.GetType)
                ) &&
                (
                    this.FacetFeature == other.FacetFeature ||
                    this.FacetFeature != null &&
                    this.FacetFeature.SequenceEqual(other.FacetFeature)
                ) &&
                (
                    this.FacetRole == other.FacetRole ||
                    this.FacetRole != null &&
                    this.FacetRole.SequenceEqual(other.FacetRole)
                ) &&
                (
                    this.FacetService == other.FacetService ||
                    this.FacetService != null &&
                    this.FacetService.SequenceEqual(other.FacetService)
                ) &&
                (
                    this.FaqCategories == other.FaqCategories ||
                    this.FaqCategories != null &&
                    this.FaqCategories.SequenceEqual(other.FaqCategories)
                ) &&
                (
                    this.ReleasenoteCategory == other.ReleasenoteCategory ||
                    this.ReleasenoteCategory != null &&
                    this.ReleasenoteCategory.SequenceEqual(other.ReleasenoteCategory)
                ) &&
                (
                    this.ReleasenoteTag == other.ReleasenoteTag ||
                    this.ReleasenoteTag != null &&
                    this.ReleasenoteTag.SequenceEqual(other.ReleasenoteTag)
                ) &&
                (
                    this.ServiceArea == other.ServiceArea ||
                    this.ServiceArea != null &&
                    this.ServiceArea.SequenceEqual(other.ServiceArea)
                ) &&
                (
                    this.VideoCategories == other.VideoCategories ||
                    this.VideoCategories != null &&
                    this.VideoCategories.SequenceEqual(other.VideoCategories)
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
                
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                if (this.Excerpt != null)
                    hash = hash * 59 + this.Excerpt.GetHashCode();
                
                if (this.Link != null)
                    hash = hash * 59 + this.Link.GetHashCode();
                
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();
                
                if (this.Slug != null)
                    hash = hash * 59 + this.Slug.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.GetType != null)
                    hash = hash * 59 + this.GetType.GetHashCode();
                
                if (this.FacetFeature != null)
                    hash = hash * 59 + this.FacetFeature.GetHashCode();
                
                if (this.FacetRole != null)
                    hash = hash * 59 + this.FacetRole.GetHashCode();
                
                if (this.FacetService != null)
                    hash = hash * 59 + this.FacetService.GetHashCode();
                
                if (this.FaqCategories != null)
                    hash = hash * 59 + this.FaqCategories.GetHashCode();
                
                if (this.ReleasenoteCategory != null)
                    hash = hash * 59 + this.ReleasenoteCategory.GetHashCode();
                
                if (this.ReleasenoteTag != null)
                    hash = hash * 59 + this.ReleasenoteTag.GetHashCode();
                
                if (this.ServiceArea != null)
                    hash = hash * 59 + this.ServiceArea.GetHashCode();
                
                if (this.VideoCategories != null)
                    hash = hash * 59 + this.VideoCategories.GetHashCode();
                
                return hash;
            }
        }
    }

}
