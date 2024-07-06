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
    /// Program
    /// </summary>
    [DataContract]
    public partial class Program :  IEquatable<Program>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Program" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Published">Published.</param>
        /// <param name="Topics">Topics.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="PublishedBy">PublishedBy.</param>
        /// <param name="DatePublished">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="TopicLinksJob">TopicLinksJob.</param>
        public Program(string Name = null, string Description = null, bool? Published = null, List<BaseTopicEntitiy> Topics = null, List<string> Tags = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null, AddressableEntityRef PublishedBy = null, DateTime? DatePublished = null, AddressableEntityRef TopicLinksJob = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Published = Published;
            this.Topics = Topics;
            this.Tags = Tags;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            this.PublishedBy = PublishedBy;
            this.DatePublished = DatePublished;
            this.TopicLinksJob = TopicLinksJob;
            
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }



        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name="topics", EmitDefaultValue=false)]
        public List<BaseTopicEntitiy> Topics { get; set; }



        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public AddressableEntityRef ModifiedBy { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Gets or Sets PublishedBy
        /// </summary>
        [DataMember(Name="publishedBy", EmitDefaultValue=false)]
        public AddressableEntityRef PublishedBy { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublished", EmitDefaultValue=false)]
        public DateTime? DatePublished { get; set; }



        /// <summary>
        /// Gets or Sets TopicLinksJob
        /// </summary>
        [DataMember(Name="topicLinksJob", EmitDefaultValue=false)]
        public AddressableEntityRef TopicLinksJob { get; set; }



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
            sb.Append("class Program {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
            sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
            sb.Append("  TopicLinksJob: ").Append(TopicLinksJob).Append("\n");
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
            return this.Equals(obj as Program);
        }

        /// <summary>
        /// Returns true if Program instances are equal
        /// </summary>
        /// <param name="other">Instance of Program to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Program other)
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
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.Topics == other.Topics ||
                    this.Topics != null &&
                    this.Topics.SequenceEqual(other.Topics)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
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
                    this.PublishedBy == other.PublishedBy ||
                    this.PublishedBy != null &&
                    this.PublishedBy.Equals(other.PublishedBy)
                ) &&
                (
                    this.DatePublished == other.DatePublished ||
                    this.DatePublished != null &&
                    this.DatePublished.Equals(other.DatePublished)
                ) &&
                (
                    this.TopicLinksJob == other.TopicLinksJob ||
                    this.TopicLinksJob != null &&
                    this.TopicLinksJob.Equals(other.TopicLinksJob)
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

                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();

                if (this.Topics != null)
                    hash = hash * 59 + this.Topics.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.PublishedBy != null)
                    hash = hash * 59 + this.PublishedBy.GetHashCode();

                if (this.DatePublished != null)
                    hash = hash * 59 + this.DatePublished.GetHashCode();

                if (this.TopicLinksJob != null)
                    hash = hash * 59 + this.TopicLinksJob.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
