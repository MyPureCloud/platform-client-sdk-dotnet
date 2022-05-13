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
    /// ReportMetaData
    /// </summary>
    [DataContract]
    public partial class ReportMetaData :  IEquatable<ReportMetaData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportMetaData" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Keywords">Keywords.</param>
        /// <param name="AvailableLocales">AvailableLocales.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="ExampleUrl">ExampleUrl.</param>
        public ReportMetaData(string Name = null, string Title = null, string Description = null, List<string> Keywords = null, List<string> AvailableLocales = null, List<Parameter> Parameters = null, string ExampleUrl = null)
        {
            this.Name = Name;
            this.Title = Title;
            this.Description = Description;
            this.Keywords = Keywords;
            this.AvailableLocales = AvailableLocales;
            this.Parameters = Parameters;
            this.ExampleUrl = ExampleUrl;
            
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
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }



        /// <summary>
        /// Gets or Sets AvailableLocales
        /// </summary>
        [DataMember(Name="availableLocales", EmitDefaultValue=false)]
        public List<string> AvailableLocales { get; set; }



        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<Parameter> Parameters { get; set; }



        /// <summary>
        /// Gets or Sets ExampleUrl
        /// </summary>
        [DataMember(Name="exampleUrl", EmitDefaultValue=false)]
        public string ExampleUrl { get; set; }



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
            sb.Append("class ReportMetaData {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  AvailableLocales: ").Append(AvailableLocales).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ExampleUrl: ").Append(ExampleUrl).Append("\n");
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
            return this.Equals(obj as ReportMetaData);
        }

        /// <summary>
        /// Returns true if ReportMetaData instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportMetaData other)
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
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
                ) &&
                (
                    this.AvailableLocales == other.AvailableLocales ||
                    this.AvailableLocales != null &&
                    this.AvailableLocales.SequenceEqual(other.AvailableLocales)
                ) &&
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) &&
                (
                    this.ExampleUrl == other.ExampleUrl ||
                    this.ExampleUrl != null &&
                    this.ExampleUrl.Equals(other.ExampleUrl)
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

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();

                if (this.AvailableLocales != null)
                    hash = hash * 59 + this.AvailableLocales.GetHashCode();

                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();

                if (this.ExampleUrl != null)
                    hash = hash * 59 + this.ExampleUrl.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
